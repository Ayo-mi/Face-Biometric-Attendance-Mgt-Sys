using Bunifu.UI.WinForms;
using Microsoft.VisualBasic;
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
    public partial class Edit_Position : Form
    {
        private string id;
        private string schedule_id;
        private Hashtable schedIdList = new Hashtable();
        public Edit_Position(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void getSche(string id)
        {
            String stmt = "SELECT * from schedules where status=@st;";
            Hashtable attr = new Hashtable();
            attr.Add("@st", 1);
            sched_combo.Items.Clear();

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
                    sched_combo.Items.Add(data["name"] + "  " + st + " - " + en);
                    
                    int index = sched_combo.Items.Count - 1;
                    schedIdList.Add(index, data["schedule_id"]);
                    if (data["schedule_id"].Equals(id))
                    {
                        int indx = sched_combo.Items.Count - 1;
                        sched_combo.SelectedIndex = indx;
                    }
                }));

            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            String stmt = "SELECT * from positions where position_id = @id and status=@st limit 1;";
            Hashtable attr = new Hashtable();
            attr.Add("@id", id);
            attr.Add("@st", 1);
            DBConnection dB = new DBConnection();
            MySqlDataReader data = (MySqlDataReader)dB.Select(stmt, attr);
            if (data != null)
            {
                int i = 1;
                while (data.Read())
                {                    
                    string name = data["name"].ToString();
                    schedule_id = data["schedule_id"].ToString();

                    this.Invoke(new MethodInvoker(delegate
                    {
                        posiName.Text = name;
                        getSche(schedule_id);
                    }));
                    i++;
                }
            }
        }

        private void Edit_Position_Shown(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Are you sure you want to delete this position?\n\nNB: Doing this will also be removed from any employee attached to this position!",
                "Delete Position", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (a == DialogResult.Yes && !String.IsNullOrEmpty(id))
            {
                DBConnection dB = new DBConnection();

                String stmt = "update positions set status=@st where position_id=@id;" +
                    "update employees set position_id='' where position_id=@id";
                Hashtable attr = new Hashtable();
                attr.Add("@id", id);
                attr.Add("@st", 0);

                if (dB.Operation(stmt, attr))
                {
                    prompt.Show(this, "Position was deleted successfully",
                       BunifuSnackbar.MessageTypes.Success, 1000, "",
                       BunifuSnackbar.Positions.TopCenter, BunifuSnackbar.Hosts.FormOwner);
                    id = "";
                }
                else
                {
                    MessageBox.Show("Position wasn't deleted, an error occured", "Delete Position", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                if (String.IsNullOrEmpty(id))
                    MessageBox.Show("Position already deleted", "Delete Position", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(posiName.Text))
            {
                DBConnection dB = new DBConnection();
                String pos = posiName.Text.Trim();
                int ind = sched_combo.SelectedIndex;

                String stmt = "Update positions set name=@na, schedule_id=@sc where position_id=@id;";
                Hashtable attr = new Hashtable();
                attr.Add("@id", id);
                attr.Add("@na", pos);
                attr.Add("@sc", schedIdList[ind]);

                if (dB.Operation(stmt, attr))
                {
                    prompt.Show(this, "Position was updated successfully",
                       BunifuSnackbar.MessageTypes.Success, 1000, "",
                       BunifuSnackbar.Positions.TopCenter, BunifuSnackbar.Hosts.FormOwner);
                }
                else
                {
                    MessageBox.Show("Position was not updated, an error occured", "Update Position", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Enter all details", "Update Position", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
