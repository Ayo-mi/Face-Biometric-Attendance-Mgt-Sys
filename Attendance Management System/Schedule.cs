using Attendance_Management_System.Modal.Edit_Modal;
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

namespace Attendance_Management_System
{
    public partial class Schedule : Form
    {
        Dashboard currentParent;
        public Schedule(Dashboard currentParent)
        {
            InitializeComponent();
            this.currentParent = currentParent;
        }

        private void FilterTable(string qry)
        {
            String stmt = String.Format("SELECT schedule_id, name, start_time, end_time from schedules" +
                " where name like '%{0}%' and status=@st;", qry);
            Hashtable attr = new Hashtable();
            attr.Add("@st", 1);
            
            tb.Rows.Clear();

            DBConnection dB = new DBConnection();
            MySqlDataReader data = (MySqlDataReader)dB.Select(stmt, attr);
            if (data != null)
            {
                int i = 1;
                while (data.Read())
                {
                    String st = data["start_time"].ToString();
                    DateTime date = DateTime.Parse(st, System.Globalization.CultureInfo.CurrentCulture);
                    st = date.ToString("HH:mm tt");

                    String et = data["end_time"].ToString();
                    date = DateTime.Parse(et, System.Globalization.CultureInfo.CurrentCulture);
                    et = date.ToString("HH:mm tt");

                    tb.Rows.Add(i, data["name"], st, et, data["schedule_id"]);
                    
                    i++;
                }
            }
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            new Modal.Add_Schedule().ShowDialog();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            String stmt = "SELECT * from schedules where status=@st; ";
            Hashtable attr = new Hashtable();
            attr.Add("@st", 1);
            this.Invoke(new MethodInvoker(delegate
            {
                tb.Rows.Clear();
            }));

            DBConnection dB = new DBConnection();
            MySqlDataReader data = (MySqlDataReader)dB.Select(stmt, attr);
            if (data != null)
            {
                int i = 1;
                while (data.Read())
                {
                    e.Result = true;
                    
                    String st = data["start_time"].ToString();
                    DateTime date = DateTime.Parse(st, System.Globalization.CultureInfo.CurrentCulture);
                    st = date.ToString("HH:mm tt");

                    String et = data["end_time"].ToString();
                    date = DateTime.Parse(et, System.Globalization.CultureInfo.CurrentCulture);
                    et = date.ToString("HH:mm tt");


                    this.Invoke(new MethodInvoker(delegate
                    {
                        tb.Rows.Add(i, data["name"], st, et, data["schedule_id"]);
                    }));
                    i++;
                }
            }
        }

        private void Schedule_Shown(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            if(tb.SelectedRows.Count == 1)
            {
                string id = tb.SelectedRows[0].Cells[4].Value.ToString().Trim();
                new Edit_Schedule(id).ShowDialog();
            }
        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(bunifuTextBox1.Text))
            {
                FilterTable(bunifuTextBox1.Text);
            }
            else
            {
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
        }
    }
}
