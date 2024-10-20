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

namespace Attendance_Management_System.Modal.Edit_Modal
{
    public partial class Edit_Employee : Form
    {
        private Enrollment enrollment;
        Hashtable posi_id = new Hashtable();
        private string id;
        private string posId;
        private FaceRecognitionSystem FaceRecognition { get; set; }
        public Edit_Employee(String id)
        {
            InitializeComponent();
            //enrollment = new Enrollment(this);
            this.id = id;

            FaceRecognition = new FaceRecognitionSystem();
        }

        public Label Status()
        {
            return new Label();
        }

        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox1.Checked)
            {
                bunifuPictureBox1.Enabled = false;
                bunifuButton23.Enabled = false;
                bunifuButton24.Enabled = false;
            }
            else
            {
                bunifuPictureBox1.Enabled = true;
                bunifuButton23.Enabled = true;
                bunifuButton24.Enabled = true;
            }
        }

        private void getPositions(string id)
        {
            String stmt = "SELECT p.name, p.position_id, s.start_time, s.end_time FROM " +
                "attenance_mgt.positions p left join schedules s on p.schedule_id = s.schedule_id where p.status=@st and s.status=@st;";
            Hashtable attr = new Hashtable();
            attr.Add("@st", 1);
            posi_id.Clear();

            DBConnection dB = new DBConnection();
            MySqlDataReader data = (MySqlDataReader)dB.Select(stmt, attr);
            while (data.Read())
            {
                String st = data["start_time"].ToString();
                DateTime date = DateTime.Parse(st, System.Globalization.CultureInfo.CurrentCulture);
                st = date.ToString("h:mm tt");

                String en = data["end_time"].ToString();
                date = DateTime.Parse(en, System.Globalization.CultureInfo.CurrentCulture);
                en = date.ToString("h:mm tt");

                this.Invoke(new MethodInvoker(delegate
                {
                    posit_combo.Items.Add(data["name"] + "  (" + st + " - " + en + ")");

                    int indx = posit_combo.Items.Count - 1;
                    posi_id.Add(indx, data["position_id"]);
                    if (data["position_id"].Equals(id))
                    {
                        posit_combo.SelectedIndex = indx;
                    }
                }));

            }
        }

            private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            String stmt = "SELECT * from employees where employee_id=@id and status=@st limit 1";
            Hashtable attr = new Hashtable();
            attr.Add("@id", id);
            attr.Add("@st", 1);
            posi_id.Clear();

            DBConnection dB = new DBConnection();
            MySqlDataReader data = (MySqlDataReader)dB.Select(stmt, attr);
            while (data.Read())
            {
                posId = data["position_id"].ToString();

                this.Invoke(new MethodInvoker(delegate
                {
                    fName.Text = data["first_name"].ToString();
                    lName.Text = data["last_name"].ToString();
                    //emId.Text = data["employee_id"].ToString();
                    getPositions(posId);
                }));

            }
        }

        private void Edit_Employee_Shown(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(fName.Text) && !String.IsNullOrEmpty(lName.Text) && posit_combo.SelectedIndex > -1)
            {
                DBConnection dB = new DBConnection();
                String fn = fName.Text.Trim();
                String ln = lName.Text.Trim();
                //String emp = emId.Text.Trim();
                int ind = posit_combo.SelectedIndex;

                String stmt = "";
                Hashtable attr = new Hashtable();
                if (bunifuCheckBox1.Checked)
                {
                    stmt = "Update employees set first_name=@fn, last_name=@ln, position_id=@po where employee_id=@id;";
                    attr.Add("@id", id);
                    attr.Add("@fn", fn);
                    attr.Add("@ln", ln);
                    attr.Add("@po", posi_id[ind]);
                }
                else
                {
                    if (FaceRecognition.Image != null)
                    {
                        stmt = "Update employees set first_name=@fn, last_name=@ln, fingerprint=@fp, employee_id=@id, position_id=@po where employee_id=@id;";
                        
                        byte[] sample = null;
                        enrollment.Enrollerr.Template.Serialize(ref sample);

                        attr.Add("@id", id);
                        attr.Add("@fn", fn);
                        attr.Add("@ln", ln);
                        attr.Add("@fp", sample);
                        attr.Add("@po", posi_id[ind]);
                    }
                    else
                    {
                        MessageBox.Show("Capture your face before updating data", "Update Employee Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    
                }            

                if (dB.Operation(stmt, attr))
                {
                    prompt.Show(this, "Employee data updated successfully",
                       BunifuSnackbar.MessageTypes.Success, 1000, "",
                       BunifuSnackbar.Positions.TopCenter, BunifuSnackbar.Hosts.FormOwner);
                }
                else
                {
                    MessageBox.Show("Employee wasn't updated, an error occured", "Update Employee Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Enter all details", "Update Employee Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Are you sure you want to delete this employee's data?\n\nNB: " +
                "Doing this will remove all employee's data from the system except his/her attendance record for legal reasons",
                "Delete Position", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (a == DialogResult.Yes && !String.IsNullOrEmpty(id))
            {
                DBConnection dB = new DBConnection();

                String stmt = "update employees set status=@st where employee_id=@id;";
                Hashtable attr = new Hashtable();
                attr.Add("@id", id);
                attr.Add("@st", 0);

                if (dB.Operation(stmt, attr))
                {
                    prompt.Show(this, "Employee was deleted successfully",
                       BunifuSnackbar.MessageTypes.Success, 1000, "",
                       BunifuSnackbar.Positions.TopCenter, BunifuSnackbar.Hosts.FormOwner);
                    id = "";
                }
                else
                {
                    MessageBox.Show("Employee wasn't deleted, an error occured", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                if (String.IsNullOrEmpty(id))
                    MessageBox.Show("Employee data already deleted", "Delete Position", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            FaceRecognition.openCamera(bunifuPictureBox1, null);
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            FaceRecognition.Save_IMAGE(id);

            FaceRecognition.StopCamera();
            bunifuButton23.Enabled = false;
            bunifuButton24.Enabled = false;
        }
    }
}
