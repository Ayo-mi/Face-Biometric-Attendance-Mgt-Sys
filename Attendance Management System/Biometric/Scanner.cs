using Attendance_Management_System.Modal;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_Management_System.Biometric
{
    class Scanner : DPFP.Capture.EventHandler
    {
		Add_User user;
		Add_Employee emp;
		Main main;

		protected virtual void Init()
		{
			try
			{
				Capturer = new DPFP.Capture.Capture();              // Create a capture operation.

				if (null != Capturer)
					Capturer.EventHandler = this;                   // Subscribe for capturing events.
				else
					Prompt("Can't initiate capture operation!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
			}
			catch
			{
                System.Windows.Forms.MessageBox.Show("Can't initiate capture operation!", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			}
		}

		
		internal virtual void Process(DPFP.Sample Sample)
		{
			// Draw fingerprint sample image.
			//DrawPicture(ConvertSampleToBitmap(Sample));
		}
		

		internal void Start()
		{
			if (null != Capturer)
			{
				try
				{
					Capturer.StartCapture();
					Prompt("Using the fingerprint reader, scan your fingerprint.");
				}
				catch
				{
					Prompt("Can't initiate capture!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
				}
			}
		}

		internal void Stop()
		{
			if (null != Capturer)
			{
				try
				{
					Capturer.StopCapture();
				}
				catch
				{
					Prompt("Can't terminate capture!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
				}
			}
		}

		#region Form Event Handlers:
		/*
		private void CaptureForm_Load(object sender, EventArgs e)
		{
			Init();
			Start();                                                // Start capture operation.
		}
		*/
		#endregion

		#region EventHandler Members:

		public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
		{
			//Report = "The fingerprint sample was captured.";
			//Prompt = "Scan the same fingerprint again.";
			Process(Sample);
		}

		public void OnFingerGone(object Capture, string ReaderSerialNumber)
		{
			Report = "The finger was removed from the fingerprint reader.";
		}

		public void OnFingerTouch(object Capture, string ReaderSerialNumber)
		{
			Report = "The fingerprint reader was touched.";
		}

		public void OnReaderConnect(object Capture, string ReaderSerialNumber)
		{
			Report = "The fingerprint reader was connected.";
		}

		public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
		{
			Report = "The fingerprint reader was disconnected.";
		}

		public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
		{
			if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
				Report = "The quality of the fingerprint sample is good.";
			else
				Prompt("The quality of the fingerprint sample is poor.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
		}
		#endregion

		protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
		{
			DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();  // Create a sample convertor.
			Bitmap bitmap = null;                                                           // TODO: the size doesn't matter
			Convertor.ConvertToPicture(Sample, ref bitmap);                                 // TODO: return bitmap as a result
			return bitmap;
		}

		protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
		{
			DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();  // Create a feature extractor
			DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
			DPFP.FeatureSet features = new DPFP.FeatureSet();
			Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);            // TODO: return features as a result?
			if (feedback == DPFP.Capture.CaptureFeedback.Good)
				return features;
			else
				return null;
		}

		internal String Status
		{
			get; set;
		}

		internal void Prompt(String val, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes msgType = 0)
		{
			if(user != null)
            {
				user.Prompt.Show(user, val, msgType, 2000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter,
				Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);
			}
			else if(emp != null)
            {
				emp.Prompt.Show(emp, val, msgType, 2000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter,
				Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);
			}
			else if(main != null)
            {
				main.Prompt.Show(main, val, msgType, 2000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter,
				Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);
			}
			
		}
		internal String Report
		{
			get; set;
		}

		/*
		private void DrawPicture(Bitmap bitmap)
		{
			this.Invoke(new Function(delegate () {
				Picture.Image = new Bitmap(bitmap, Picture.Size);   // fit the image into the picture box
			}));
		}*/

		private DPFP.Capture.Capture Capturer;
	}
}
