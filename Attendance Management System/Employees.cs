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
    public partial class Employees : Form
    {
        private Dashboard parent;
        public Employees(Dashboard parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void FilterTable(string qry)
        {
            String stmt = String.Format("SELECT e.employee_id, e.first_name, e.last_name, e.date_created, p.name, s.start_time, " +
                "s.end_time FROM attenance_mgt.employees e left join positions p on e.position_id = p.position_id " +
                "left join schedules s on p.schedule_id = s.schedule_id where (e.employee_id like '%{0}%' or " +
                "e.first_name like '%{0}%' or e.last_name like '%{0}%' or p.name like '%{0}%') and e.status=@st;", qry);

            Hashtable attr = new Hashtable();
            attr.Add("@st", 1);
            tb.Rows.Clear();

            DBConnection dB = new DBConnection();
            MySqlDataReader data = (MySqlDataReader)dB.Select(stmt, attr);
            if (data != null)
            {
                while (data.Read())
                {
                    String dt = data["date_created"].ToString();
                    DateTime date = DateTime.Parse(dt, System.Globalization.CultureInfo.CurrentCulture);
                    dt = date.ToString("MMMM dd, yyyy");

                    String st = "00:00";
                    String et = "00:00";
                    if ((!String.IsNullOrEmpty(data["start_time"].ToString()) && !String.IsNullOrEmpty(data["end_time"].ToString())))
                    {
                        st = data["start_time"].ToString();
                        date = DateTime.Parse(st, System.Globalization.CultureInfo.CurrentCulture);
                        st = date.ToString("HH:mm tt");

                        et = data["end_time"].ToString();
                        date = DateTime.Parse(et, System.Globalization.CultureInfo.CurrentCulture);
                        et = date.ToString("HH:mm tt");
                    }

                    tb.Rows.Add(data["employee_id"], data["first_name"] + " " + data["last_name"], data["name"], st + " - " + et, dt);

                }
            }
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            new Modal.Add_Employee().ShowDialog();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            String stmt = "SELECT e.employee_id, e.first_name, e.last_name, e.date_created, p.name, s.start_time, " +
                "s.end_time FROM attenance_mgt.employees e left join positions p on e.position_id = p.position_id " +
                "left join schedules s on p.schedule_id = s.schedule_id where e.status=@st;";

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
                while (data.Read())
                {
                    e.Result = true;
                    String dt = data["date_created"].ToString();
                    DateTime date = DateTime.Parse(dt, System.Globalization.CultureInfo.CurrentCulture);
                    dt = date.ToString("MMMM dd, yyyy");

                    String st = "00:00";
                    String et = "00:00";
                    if ( (!String.IsNullOrEmpty(data["start_time"].ToString()) && !String.IsNullOrEmpty(data["end_time"].ToString())) )
                    {
                        st = data["start_time"].ToString();
                        date = DateTime.Parse(st, System.Globalization.CultureInfo.CurrentCulture);
                        st = date.ToString("HH:mm tt");

                        et = data["end_time"].ToString();
                        date = DateTime.Parse(et, System.Globalization.CultureInfo.CurrentCulture);
                        et = date.ToString("HH:mm tt");
                    }                                 


                    this.Invoke(new MethodInvoker(delegate
                    {
                        tb.Rows.Add(data["employee_id"], data["first_name"] + " " + data["last_name"], data["name"], st + " - " + et, dt);
                    }));

                }
            }
        }

        private void Employees_Shown(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            if (tb.SelectedRows.Count == 1)
            {
                string id = tb.SelectedRows[0].Cells[0].Value.ToString().Trim();
                new Edit_Employee(id).ShowDialog();
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
