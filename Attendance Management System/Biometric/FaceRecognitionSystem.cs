using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;
using System.IO.Pipes;
using Attendance_Management_System.Modal;

namespace Attendance_Management_System.Biometric
{
    internal class FaceRecognitionSystem : IDisposable
    {
        private double distance = 1E+19;

        private CascadeClassifier CascadeClassifier = new CascadeClassifier(Environment.CurrentDirectory + "/Haarcascade/haarcascade_frontalface_alt.xml");

        private Image<Bgr, byte> Frame = null;

        public Image<Bgr, byte> Image { get; set; }

        private Capture camera;

        private Mat mat = new Mat();

        private List<Image<Gray, byte>> trainedFaces = new List<Image<Gray, byte>>();

        private List<int> PersonLabs = new List<int>();

        internal bool isEnable_SaveImage = false;

        private string ImageName;

        private PictureBox PictureBox_Frame;

        private PictureBox PictureBox_smallFrame;

        public Label PersonName;

        private string setPersonName;

        public bool isTrained = false;

        private List<string> Names = new List<string>();

        private EigenFaceRecognizer eigenFaceRecognizer;

        private IContainer components = null;

        public MarkAttendanceForm ParentForm {  get; set; }

        public FaceRecognitionSystem()
        {
            if (!Directory.Exists(Environment.CurrentDirectory + "\\Image"))
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Image");
            }
        }

        public FaceRecognitionSystem(MarkAttendanceForm form)
        {
            if (!Directory.Exists(Environment.CurrentDirectory + "\\Image"))
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Image");
            }

            ParentForm = form;
        }

        public void getPersonName(Control control)
        {
            //System.Timers.Timer timer = new System.Timers.Timer();
            //timer.Tick += timer_getPersonName_Tick;
            //timer.Interval = 100;
            //timer.Start();
            //void timer_getPersonName_Tick(object sender, EventArgs e)
            //{
            //    control.Text = setPersonName;
            //}
        }

        public void openCamera(PictureBox pictureBox_Camera, Bunifu.UI.WinForms.BunifuPictureBox pictureBox_Trained)
        {
            PictureBox_Frame = pictureBox_Camera;
            PictureBox_smallFrame = pictureBox_Trained;
            camera = new Capture();
            camera.ImageGrabbed += Camera_ImageGrabbed;
            camera.Start();
        }

        public void openCamera(PictureBox pictureBox_Camera, Bunifu.UI.WinForms.BunifuPictureBox pictureBox_Trained, ref Label name)
        {
            PictureBox_Frame = pictureBox_Camera;
            PictureBox_smallFrame = pictureBox_Trained;
            PersonName = name;
            camera = new Capture();
            camera.ImageGrabbed += Camera_ImageGrabbed;
            camera.Start();
        }

        public void Save_IMAGE(string imageName)
        {
            ImageName = imageName;
            isEnable_SaveImage = true;
        }

        public void StopCamera()
        {
            if(camera != null) camera.Stop();
        }

        private void Camera_ImageGrabbed(object sender, EventArgs e)
        {
            camera.Retrieve(mat);
            Frame = mat.ToImage<Bgr, byte>().Resize(PictureBox_Frame.Width, PictureBox_Frame.Height, Inter.Cubic);
            detectFace();
            PictureBox_Frame.Image = Frame.Bitmap;
        }

        private void detectFace()
        {
            Image<Bgr, byte> image = Frame.Convert<Bgr, byte>();
            Mat mat = new Mat();
            CvInvoke.CvtColor(Frame, mat, ColorConversion.Bgr2Gray);
            CvInvoke.EqualizeHist(mat, mat);
            Rectangle[] array = CascadeClassifier.DetectMultiScale(mat, 1.1, 4);
            if (array.Length != 0)
            {
                Rectangle[] array2 = array;
                foreach (Rectangle rectangle in array2)
                {
                    CvInvoke.Rectangle(Frame, rectangle, new Bgr(Color.LimeGreen).MCvScalar, 2);
                    SaveImage(rectangle);
                    image.ROI = rectangle;
                    trainedIamge();
                    checkName(image, rectangle);
                }
            }
            else
            {
                setPersonName = "";
            }
        }

        private void SaveImage(Rectangle face)
        {
            if (isEnable_SaveImage)
            {
                Image<Bgr, byte> image = Frame.Convert<Bgr, byte>();
                image.ROI = face;
                Image = image.Resize(100, 100, Inter.Cubic);//.Save(Directory.GetCurrentDirectory() + "\\Image\\" + ImageName + ".jpg");
                Image.Save(Directory.GetCurrentDirectory() + "\\Image\\" + ImageName + ".jpg");
                isEnable_SaveImage = false;
                trainedIamge();
            }
        }

        private void trainedIamge()
        {
            try
            {
                int num = 0;
                trainedFaces.Clear();
                PersonLabs.Clear();
                Names.Clear();
                string[] files = Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Image", "*.jpg", SearchOption.AllDirectories);
                string[] array = files;
                foreach (string text in array)
                {
                    Image<Gray, byte> item = new Image<Gray, byte>(text);
                    trainedFaces.Add(item);
                    PersonLabs.Add(num);
                    Names.Add(text);
                    num++;
                }

                eigenFaceRecognizer = new EigenFaceRecognizer(num, distance);
                eigenFaceRecognizer.Train(trainedFaces.ToArray(), PersonLabs.ToArray());
            }
            catch
            {
            }
        }

        private void checkName(Image<Bgr, byte> resultImage, Rectangle face)
        {
            try
            {
                if (isTrained)
                {
                    Image<Gray, byte> image = resultImage.Convert<Gray, byte>().Resize(100, 100, Inter.Cubic);
                    CvInvoke.EqualizeHist(image, image);
                    FaceRecognizer.PredictionResult predictionResult = eigenFaceRecognizer.Predict(image);
                    if (predictionResult.Label != -1 && predictionResult.Distance < distance)
                    {
                        PictureBox_smallFrame.Image = trainedFaces[predictionResult.Label].Bitmap;
                        var id = Names[predictionResult.Label].Replace(Environment.CurrentDirectory + "\\Image\\", "").Replace(".jpg", "");
                        //get employee by id
                        setPersonName = id.Split('%').Last().Trim(); //GetEmployee(id);

                        if (!string.IsNullOrEmpty(setPersonName))
                        {
                            CvInvoke.PutText(Frame, setPersonName, new Point(face.X - 2, face.Y - 2), FontFace.HersheyPlain, 1.0, new Bgr(Color.LimeGreen).MCvScalar);
                            ParentForm.SetName(setPersonName, id.Split('%').First().Trim());
                            //PersonName.Text = setPersonName;
                        }
                        else{
                            CvInvoke.PutText(Frame, "Unknown", new Point(face.X - 2, face.Y - 2), FontFace.HersheyPlain, 1.0, new Bgr(Color.LimeGreen).MCvScalar);
                            ParentForm.SetName("", "");
                        }
                    }
                    else
                    {
                        CvInvoke.PutText(Frame, "Unknown", new Point(face.X - 2, face.Y - 2), FontFace.HersheyPlain, 1.0, new Bgr(Color.OrangeRed).MCvScalar);
                        ParentForm.SetName("", "");
                    }
                }
            }
            catch
            {
            }
        }

        public void Dispose()
        {
            if(camera != null) camera.Dispose();

            GC.SuppressFinalize(this);
        }

        // Destructor as a safety net, in case Dispose is not called
        ~FaceRecognitionSystem()
        {
            Dispose();
        }
    }
}
