using Attendance_Management_System.Biometric;
using Bunifu.UI.WinForms;
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
    public partial class Add_User : Form
    {
        private Enrollment enrollment;
        public Add_User()
        {
            InitializeComponent();
            enrollment = new Enrollment(this);
            enrollment.Start();
        }

        public void Status (String val)
        {
            if (samplelbl.InvokeRequired)
            {
                samplelbl.Invoke(new MethodInvoker(delegate {
                    samplelbl.Text = val;
                }));
            }
            else
            {
                samplelbl.Text = val;
            }
            
        }

        public Label Status()
        {
            return samplelbl;
        }

        public BunifuSnackbar Prompt
        {
            get { return prompt; }
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(fName.Text) && !String.IsNullOrEmpty(lName.Text) && !String.IsNullOrEmpty(userid.Text) && !String.IsNullOrEmpty(psw.Text) && psw.Text.Length >5 && enrollment.Enrollerr.TemplateStatus == DPFP.Processing.Enrollment.Status.Ready) 
            {
                DBConnection dB = new DBConnection();
                String fir = fName.Text.Trim();
                String las = lName.Text.Trim();
                String id = userid.Text.Trim();
                String ps = psw.Text.Trim();
                byte[] sample = null;
                enrollment.Enrollerr.Template.Serialize(ref sample);
                String stmt = "INSERT INTO users (username, first_name, last_name, password, fingerprint, status)" +
                            " VALUES (@id, @fn, @ln, @pw, @fp, @st);";
                Hashtable attr = new Hashtable();
                attr.Add("@id", id);
                attr.Add("@fn", fir);
                attr.Add("@ln", las);
                attr.Add("@pw", ps);
                attr.Add("@fp", sample);
                attr.Add("@st", 1);

                if (dB.Operation(stmt, attr))
                {
                    MessageBox.Show("Account Created Successfully", "Add New User");
                    enrollment.Enrollerr.Clear();
                }
                else
                {
                    MessageBox.Show("Account was not created, an error occured", "Add New User");
                }
            }
            else
            {
                MessageBox.Show("Enter all details and your fingerprint samples", "Add New User");
            }
            
        }
    }
}
