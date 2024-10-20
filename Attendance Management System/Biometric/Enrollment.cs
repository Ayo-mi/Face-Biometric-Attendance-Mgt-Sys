using Attendance_Management_System.Modal;
using Attendance_Management_System.Modal.Edit_Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management_System.Biometric
{
    class Enrollment: Scanner
    {
		public delegate void OnTemplateEventHandler(DPFP.Template template);

		public event OnTemplateEventHandler OnTemplate;
		Add_User user;
		Add_Employee emp;
		Edit_Employee edEmp;
		public Enrollment(Add_User user)
        {			
			this.user = user;
			Init();			
        }

		public Enrollment(Add_Employee user)
		{
			this.emp = user;
			Init();
		}

		public Enrollment(Edit_Employee user)
		{
			this.edEmp = user;
			Init();
		}

		protected override void Init()
		{
			base.Init();
			//Enrollerr = new DPFP.Processing.Enrollment();            // Create an enrollment.
			//UpdateStatus();
		}

		internal override void Process(DPFP.Sample Sample)
		{
			base.Process(Sample);

			// Process the sample and create a feature set for the enrollment purpose.
			DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);

			// Check quality of the sample and add to enroller if it's good
			if (features != null) try
				{					
					Enrollerr.AddFeatures(features);     // Add feature set to template.
				}
				finally
				{
					UpdateStatus(); ;

					// Check if template has been created.
					switch (Enrollerr.TemplateStatus)
					{
						case DPFP.Processing.Enrollment.Status.Ready:   // report success and stop capturing
							//OnTemplate(Enrollerr.Template);
							Stop();
							break;

						case DPFP.Processing.Enrollment.Status.Failed:  // report failure and restart capturing
							Enrollerr.Clear();
							Stop();
							UpdateStatus();
							//OnTemplate(null);
							Start();
							break;
					}
				}
		}

		internal void UpdateStatus()
		{
			if(user != null)
            {
				// Show number of samples needed.
				Status = String.Format("Fingerprint sample needed: {0}", Enrollerr.FeaturesNeeded);
				if (user.Status().InvokeRequired)
				{
					user.Status().Invoke(new MethodInvoker(delegate {
						user.Status().Text = Status;
					}));
				}
				else
				{
					user.Status().Text = Status;
				}
				
			}else if(emp != null)
            {
				// Show number of samples needed.
				Status = String.Format("Fingerprint sample needed: {0}", Enrollerr.FeaturesNeeded);
				if (emp.Status().InvokeRequired)
				{
					emp.Status().Invoke(new MethodInvoker(delegate {
						emp.Status().Text = Status;
					}));
				}
				else
				{
					emp.Status().Text = Status;
				}
			}
			else if (edEmp != null)
			{
				// Show number of samples needed.
				Status = String.Format("Fingerprint sample needed: {0}", Enrollerr.FeaturesNeeded);
				if (edEmp.Status().InvokeRequired)
				{
					edEmp.Status().Invoke(new MethodInvoker(delegate {
						edEmp.Status().Text = Status;
					}));
				}
				else
				{
					edEmp.Status().Text = Status;
				}
			}

		}

		internal DPFP.Processing.Enrollment Enrollerr
        {
			get { return Enroller; }
			set { Enroller = value; }
        }

		private DPFP.Processing.Enrollment Enroller;
	}
}
