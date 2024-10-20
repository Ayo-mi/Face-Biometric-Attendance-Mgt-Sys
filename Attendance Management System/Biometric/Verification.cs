using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management_System.Biometric
{
    class Verification: Scanner
    {
		Main main;
		public Verification(Main main)
        {
			this.main = main;
			Init();
		}
		public void Verify(DPFP.Template template)
		{
			Template = template;
			//ShowDialog();
		}

		protected override void Init()
		{
			base.Init();
			//base.Text = "Fingerprint Verification";
			//Verificator = new DPFP.Verification.Verification();     // Create a fingerprint template verificator
			//UpdateStatus(0);
		}

		internal override void Process(DPFP.Sample Sample)
		{
			base.Process(Sample);

			// Process the sample and create a feature set for the enrollment purpose.
			DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

			// Check quality of the sample and start verification if it's good
			// TODO: move to a separate task
			if (features != null)
			{
				Stop();
				// Compare the feature set with our template
				if (!IsVerified(features))
				{
					main.Invoke(new MethodInvoker(delegate
					{
						main.Prompt.Show(main, "No Match Found, Try again scanning the right\nfinger registered or check your server connectiom",
					   Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 1000, "",
					   Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter, Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);
					}));
					Start();
				}
				else
					Stop();
			}
		}

		private void UpdateStatus(int FAR)
		{
			// Show "False accept rate" value
			Status = String.Format("False Accept Rate (FAR) = {0}", FAR);
		}

		private bool IsVerified(DPFP.FeatureSet features)
        {
			bool isVerified = false;
			DBConnection query = new DBConnection();
			String stmt = "select username, first_name, fingerprint from users;";
			Hashtable attr = new Hashtable();

			MySqlDataReader data = (MySqlDataReader)query.Select(stmt, attr);
            if (data != null)
            {
				while (data.Read())
				{
					MemoryStream fp = ObjectToByteArr(data["fingerprint"]);
					Template = new DPFP.Template(fp);
					DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
					Verificator.Verify(features, Template, ref result);
					UpdateStatus(result.FARAchieved);
				if (result.Verified)
				{
					Stop();
					isVerified = true;
					main.Invoke(new MethodInvoker(delegate {						
						main.OpenChildForm(new Dashboard(main, data.GetString(0)));
					}));					
					break;
                }
				
			}

			}
			else
			{
				MessageBox.Show("No connection found, check your server is running properly and try again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return isVerified;
		}

		private MemoryStream ObjectToByteArr(Object obj)
        {
			if (obj == null)
				return null;

			//BinaryFormatter bf = new BinaryFormatter();
			MemoryStream ms = new MemoryStream((byte[])obj);
			//bf.Serialize(ms, obj);

			return ms;
        }

		private DPFP.Template Template;
		private DPFP.Verification.Verification Verificator;
	}
}
