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
    public partial class Edit_Schedule : Form
    {
        private string id;
        public Edit_Schedule(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            String stmt = "SELECT * from schedules where schedule_id = @id; ";
            Hashtable attr = new Hashtable();
            attr.Add("@id", id);
            DBConnection dB = new DBConnection();
            MySqlDataReader data = (MySqlDataReader)dB.Select(stmt, attr);
            if (data != null)
            {
                while (data.Read())
                {
                    e.Result = true;

                    String st = data["start_time"].ToString();
                    DateTime date = DateTime.Parse(st, System.Globalization.CultureInfo.CurrentCulture);
                    st = date.ToString("HH:mm tt");

                    String et = data["end_time"].ToString();
                    date = DateTime.Parse(et, System.Globalization.CultureInfo.CurrentCulture);
                    et = date.ToString("HH:mm tt");

                    string name = data["name"].ToString();

                    this.Invoke(new MethodInvoker(delegate
                    {
                        scheName.Text = name;
                        startTime.Text = st;
                        endTime.Text = et;
                    }));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_Schedule_Shown(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(scheName.Text))
            {
                DBConnection dB = new DBConnection();
                String sche = scheName.Text.Trim();
                String st = startTime.Value.ToShortTimeString();

                DateTime date = DateTime.Parse(st, System.Globalization.CultureInfo.CurrentCulture);
                st = date.ToString("HH:mm:ss");

                String et = endTime.Value.ToShortTimeString();

                date = DateTime.Parse(et, System.Globalization.CultureInfo.CurrentCulture);
                et = date.ToString("HH:mm:ss");

                String stmt = "Update schedules set name=@na, start_time=@st, end_time=@et where schedule_id=@id;";
                Hashtable attr = new Hashtable();
                attr.Add("@id", id);
                attr.Add("@na", sche);
                attr.Add("@st", st);
                attr.Add("@et", et);

                if (dB.Operation(stmt, attr))
                {
                    prompt.Show(this, "Schedule was updated successfully",
                       BunifuSnackbar.MessageTypes.Success, 1000, "",
                       BunifuSnackbar.Positions.TopCenter, BunifuSnackbar.Hosts.FormOwner);
                }
                else
                {
                    MessageBox.Show("Schedule was not updated, an error occured", "Update Schedule", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Enter all details", "Update Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Are you sure you want to delete this schedule?\n\nNB: Doing this will also be removed the schedule from any employee and position attached to this schedule!",
                "Delete Schedule", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (a == DialogResult.Yes && !String.IsNullOrEmpty(id))
            {
                DBConnection dB = new DBConnection();
                
                String stmt = "update schedules set status=@st where schedule_id=@id;";
                Hashtable attr = new Hashtable();
                attr.Add("@id", id);
                attr.Add("@st", 0);

                if (dB.Operation(stmt, attr))
                {
                    String stmnt = "SELECT position_id from positions where schedule_id = @id; ";
                    Hashtable attri = new Hashtable();
                    attri.Add("@id", id);
                    DBConnection d = new DBConnection();
                    MySqlDataReader data = (MySqlDataReader)d.Select(stmnt, attri);
                    if (data != null)
                    {
                        while (data.Read())
                        {
                            DBConnection db = new DBConnection();
                            string pi = data.GetString(0);
                            String sta = "update positions set schedule_id=@st where position_id=@id;" +
                                "update employees set position_id=@st where position_id=@id";
                            Hashtable atr = new Hashtable();
                            atr.Add("@id", pi);
                            atr.Add("@st", "");

                            db.Operation(sta, atr);
                        }
                    }

                    prompt.Show(this, "Schedule was deleted successfully",
                       BunifuSnackbar.MessageTypes.Success, 1000, "",
                       BunifuSnackbar.Positions.TopCenter, BunifuSnackbar.Hosts.FormOwner);
                    id = "";
                }
                else
                {
                    MessageBox.Show("Schedule was not deleted, an error occured", "Delete Schedule", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                if (String.IsNullOrEmpty(id))
                    MessageBox.Show("Schedule already deleted", "Delete Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
