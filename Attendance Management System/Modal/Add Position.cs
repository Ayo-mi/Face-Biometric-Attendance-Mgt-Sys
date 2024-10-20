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
    public partial class Add_Position : Form
    {
        Hashtable sched_id = new Hashtable();

        public Add_Position()
        {
            InitializeComponent();            
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {            
            String stmt = "SELECT * from schedules where status=@st;";
            Hashtable attr = new Hashtable();
            attr.Add("@st", 1);
            sched_id.Clear();
            
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
                    sched_combo.Items.Add(data["name"] + "  " + st + " - " + en);

                    int indx = sched_combo.Items.Count - 1;
                    sched_id.Add(indx, data["schedule_id"]);
                }));
                
            }            
        }

        private void Add_Position_Shown(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(posiName.Text) && sched_combo.SelectedIndex > -1)
            {
                DBConnection dB = new DBConnection();
                int sche_id = sched_combo.SelectedIndex;
                string name = posiName.Text.Trim();                
                String id = "posit_" + Guid.NewGuid().ToString("N");

                String stmt = "INSERT INTO positions (position_id, name, schedule_id, status)" +
                            " VALUES (@id, @na, @sc, @st);";
                Hashtable attr = new Hashtable();
                attr.Add("@id", id);
                attr.Add("@na", name);
                attr.Add("@sc", sched_id[sche_id]);
                attr.Add("@st", 1);

                if (dB.Operation(stmt, attr))
                {
                    prompt.Show(this, "Position was created successfully",
                       BunifuSnackbar.MessageTypes.Success, 1000, "",
                       BunifuSnackbar.Positions.TopCenter, BunifuSnackbar.Hosts.FormOwner);
                }
                else
                {
                    MessageBox.Show("Position was not created, an error occured", "Add New Position", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }            
            
        }
        else
            {
                MessageBox.Show("Enter all details ", "Add New Position", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
