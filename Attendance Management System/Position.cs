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
    public partial class Position : Form
    {
        private Dashboard currentParent;
        public Position(Dashboard currentParent)
        {
            InitializeComponent();
            this.currentParent = currentParent;
        }

        private void FilterTable(string qry)
        {
            String stmt = String.Format("SELECT p.position_id, p.name as title, s.start_time, s.end_time, s.name, s.status from positions p " +
                "left join schedules s on p.schedule_id = s.schedule_id where (p.name like '%{0}%' or s.name like '%{0}%') and p.status=@st;", qry);
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
                    string st = "00:00";
                    string et = "00:00";
                    string diff = "0";
                    string na = "NIL";
                    if (data["status"].ToString() == "1")
                    {
                        st = data["start_time"].ToString();
                        DateTime date = DateTime.Parse(st, System.Globalization.CultureInfo.CurrentCulture);
                        st = date.ToString("HH:mm tt");

                        et = data["end_time"].ToString();
                        DateTime date2 = DateTime.Parse(et, System.Globalization.CultureInfo.CurrentCulture);
                        et = date2.ToString("HH:mm tt");
                        diff = (date2.Subtract(date).TotalHours).ToString();
                        na = data["name"].ToString();
                    }
                    
                    tb.Rows.Add(i, data["title"], na, st + " - " + et, diff, data["position_id"]);

                    i++;
                }
            }
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            new Modal.Add_Position().ShowDialog();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            String stmt = "SELECT p.position_id, p.name as title, s.start_time, s.end_time, s.name, s.status from positions p " +
                "left join schedules s on p.schedule_id = s.schedule_id where p.status=@st;";
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
                    string st = "00:00";
                    string et = "00:00";
                    string diff = "0";
                    string na = "NIL";
                    if (data["status"].ToString() == "1")
                    {
                        st = data["start_time"].ToString();
                        DateTime date = DateTime.Parse(st, System.Globalization.CultureInfo.CurrentCulture);
                        st = date.ToString("HH:mm tt");

                        et = data["end_time"].ToString();
                        DateTime date2 = DateTime.Parse(et, System.Globalization.CultureInfo.CurrentCulture);
                        et = date2.ToString("HH:mm tt");
                        diff = (date2.Subtract(date).TotalHours).ToString();
                        na = data["name"].ToString();
                    }
                                                          
                    this.Invoke(new MethodInvoker(delegate
                    {
                        tb.Rows.Add(i, data["title"], na, st+" - "+et, diff, data["position_id"]);
                    }));
                    i++;
                }
            }
        }

        private void Position_Shown(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            if (tb.SelectedRows.Count == 1)
            {
                string id = tb.SelectedRows[0].Cells[5].Value.ToString().Trim();
                new Edit_Position(id).ShowDialog();
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
