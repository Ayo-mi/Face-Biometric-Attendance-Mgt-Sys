using Attendance_Management_System.Biometric;
using Bunifu.UI.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management_System.Modal
{
    public partial class Add_Employee : Form
    {
        private Enrollment enrollment;
        Hashtable posi_id = new Hashtable();
        public Guid Id { get; set; } = Guid.NewGuid();
        private FaceRecognitionSystem FaceRecognition { get; set; }
        public Add_Employee()
        {
            InitializeComponent();            
            //enrollment = new Enrollment(this);
            //enrollment.Start();

            FaceRecognition = new FaceRecognitionSystem();
        }

        public Label Status()
        {
            return new Label();
        }

        public BunifuSnackbar Prompt
        {
            get { return prompt; }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            String stmt = "SELECT p.name, p.position_id, s.start_time, s.end_time FROM " +
                "attenance_mgt.positions p left join schedules s on p.schedule_id = s.schedule_id where p.status =@st and s.status=@st";
            Hashtable attr = new Hashtable();
            attr.Add("@st", 1);
            posi_id.Clear();

            DBConnection dB = new DBConnection();
            MySqlDataReader data = (MySqlDataReader)dB.Select(stmt, attr);
            while (data.Read())
            {
                e.Result = true;
                String st = data["start_time"].ToString();
                DateTime date = DateTime.Parse(st, System.Globalization.CultureInfo.CurrentCulture);
                st = date.ToString("h:mm tt");

                String en = data["end_time"].ToString();
                date = DateTime.Parse(en, System.Globalization.CultureInfo.CurrentCulture);
                en = date.ToString("h:mm tt");

                this.Invoke(new MethodInvoker(delegate
                {
                    posit_combo.Items.Add(data["name"] + "  (" + st + " - " + en+")");

                    int indx = posit_combo.Items.Count - 1;
                    posi_id.Add(indx, data["position_id"]);
                }));

            }
        }

        private void Add_Employee_Shown(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(fName.Text) && !String.IsNullOrEmpty(lName.Text) && posit_combo.SelectedIndex > -1
                && FaceRecognition.Image != null)
            {
                DBConnection dB = new DBConnection();
                int posit_id = posit_combo.SelectedIndex;
                string fname = fName.Text.Trim();
                string lname = lName.Text.Trim();
                //String id = Guid.NewGuid().ToString();
                byte[] sample = null;
                //enrollment.Enrollerr.Template.Serialize(ref sample);

                String stmt = "INSERT INTO employees (employee_id, first_name, last_name, fingerprint, position_id, status, curr_state)" +
                            " VALUES (@id, @fn, @ln, @fp, @po, @st, @cs);";
                Hashtable attr = new Hashtable();
                attr.Add("@id", Id.ToString());
                attr.Add("@fn", fname);
                attr.Add("@ln", lname);
                attr.Add("@fp", sample);
                attr.Add("@po", posi_id[posit_id]);
                attr.Add("@st", 1);
                attr.Add("@cs", 0);

                if (dB.Operation(stmt, attr))
                {
                    prompt.Show(this, "Employee account was created successfully",
                       BunifuSnackbar.MessageTypes.Success, 1000, "",
                       BunifuSnackbar.Positions.TopCenter, BunifuSnackbar.Hosts.FormOwner);
                    //    enrollment.Enrollerr.Clear();
                    //    enrollment.Start();
                    //    enrollment.UpdateStatus();
                }
                else
                {
                    MessageBox.Show("Employee account was not created, an error occured", "Add New Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Enter all details ", "Add New Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            FaceRecognition.openCamera(bunifuPictureBox1, null);
        }
        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            FaceRecognition.Save_IMAGE(Id.ToString());

            FaceRecognition.StopCamera();
            bunifuButton23.Enabled = false;
            bunifuButton24.Enabled = false;
        }
    }
}
