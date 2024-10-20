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
    public partial class Attendance : Form
    {
        private Dashboard parent;
        public Attendance(Dashboard parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void FilterTable(string qry)
        {
            String stmt = String.Format("SELECT a.time_in, a.time_out, a.schedule_timein, a.schedule_timeout, " +
                "e.first_name, e.last_name FROM attendance_record a left join employees e on a.employee_id = e.employee_id" +
                " where (e.employee_id like '%{0}%' or e.first_name like '%{0}%' or e.last_name like '%{0}%' or " +
                "a.position_name like '%{0}%' or a.schedule_name like '%{0}%') order by a.id desc;", qry);
            Hashtable attr = new Hashtable();
            
            tb.Rows.Clear();
            DBConnection dB = new DBConnection();
            MySqlDataReader data = (MySqlDataReader)dB.Select(stmt, attr);
            if (data != null)
            {
                int i = 1;
                while (data.Read())
                {
                    string names = data["first_name"].ToString() + " " + data["last_name"];

                    //Scheduled time in and out
                    DateTime sche_in = DateTime.Parse(data["schedule_timein"].ToString(), System.Globalization.CultureInfo.CurrentCulture);
                    DateTime sche_out = DateTime.Parse(data["schedule_timeout"].ToString(), System.Globalization.CultureInfo.CurrentCulture);

                    //Time in to a datetime type
                    DateTime time_in = DateTime.Parse(data["time_in"].ToString(), System.Globalization.CultureInfo.CurrentCulture);
                    time_in = DateTime.Parse(time_in.ToString("HH:mm:00 yyyy-MM-dd"), System.Globalization.CultureInfo.CurrentCulture);
                    //format time in to time only format
                    string t_in = time_in.ToString("HH:mm:ss");
                    //datetime format to format to show user
                    DateTime emp_timein = DateTime.Parse(data["time_out"].ToString(), System.Globalization.CultureInfo.CurrentCulture);
                    string timeIn = emp_timein.ToString("HH:mm tt ddd, MMM dd, yyyy");

                    //format to get date employee clock in
                    string t_te = time_in.ToString("yyyy-MM-dd");
                    //format of employee clock in date to a datetime type
                    time_in = DateTime.Parse(t_in, System.Globalization.CultureInfo.CurrentCulture);

                    //object type for image cells
                    object in_t = Properties.Resources.filled_circle_n_100px;
                    object out_t = Properties.Resources.filled_circle_n_100px;

                    DateTime time_out = new DateTime();
                    string timeOut = "Still Signed In";
                    if (!String.IsNullOrEmpty(data["time_out"].ToString()))
                    {
                        time_out = DateTime.Parse(data["time_out"].ToString(), System.Globalization.CultureInfo.CurrentCulture);
                        timeOut = time_out.ToString("HH:mm tt ddd, MMM dd, yyyy");
                    }

                    //comparing timein and timeout with schedule timein and timeout
                    int in_ = DateTime.Compare(time_in, sche_in);
                    int out_ = DateTime.Compare(time_out, sche_out);

                    DateTime cur_date = DateTime.Now;
                    DateTime time_in_date = new DateTime();
                    string s = cur_date.ToString("yyyy-MM-dd HH:mm:ss");
                    cur_date = DateTime.Parse(s, System.Globalization.CultureInfo.CurrentCulture);
                    time_in_date = DateTime.Parse(t_te, System.Globalization.CultureInfo.CurrentCulture);

                    if (in_ <= 0)
                        in_t = Properties.Resources.filled_circle_g_100px;
                    else
                        in_t = Properties.Resources.filled_circle_r_100px;

                    if (out_ == 0)
                    {
                        out_t = Properties.Resources.filled_circle_g_100px;
                    }
                    else if (String.IsNullOrEmpty(data["time_out"].ToString()))
                        out_t = Properties.Resources.filled_circle_n_100px;
                    else if (out_ > 0)
                    {
                        out_t = Properties.Resources.filled_circle_y_20px;
                    }
                    else if (out_ < 0)
                    {
                        out_t = Properties.Resources.filled_circle_r_100px;

                        /*int rel = DateTime.Compare(time_in_date, cur_date);
                        if (rel < 0)
                            out_t = Properties.Resources.filled_circle_y_20px;
                        else if (rel == 0)
                            */
                    }

                    tb.Rows.Add(i, names, timeIn, in_t, timeOut, out_t);

                    i++;
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            String stmt = "SELECT a.time_in, a.time_out, a.schedule_timein, a.schedule_timeout, " +
                "e.first_name, e.last_name FROM attendance_record a left join employees e on a.employee_id = e.employee_id order by a.id DESC";
            Hashtable attr = new Hashtable();
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
                    string names = data["first_name"].ToString() + " " + data["last_name"];

                    //Scheduled time in and out
                    DateTime sche_in = DateTime.Parse(data["schedule_timein"].ToString(), System.Globalization.CultureInfo.CurrentCulture);
                    DateTime sche_out = DateTime.Parse(data["schedule_timeout"].ToString(), System.Globalization.CultureInfo.CurrentCulture);

                    //Time in to a datetime type
                    DateTime time_in = DateTime.Parse(data["time_in"].ToString(), System.Globalization.CultureInfo.CurrentCulture);
                    time_in = DateTime.Parse(time_in.ToString("HH:mm:00"), System.Globalization.CultureInfo.CurrentCulture);
                    //format time in to time only format
                    string t_in = time_in.ToString("HH:mm:ss");
                    //datetime format to format to show user
                    DateTime emp_timein = DateTime.Parse(data["time_in"].ToString(), System.Globalization.CultureInfo.CurrentCulture);
                    string timeIn = emp_timein.ToString("HH:mm tt ddd, MMM dd, yyyy");

                    //format to get date employee clock in
                    string t_te = time_in.ToString("yyyy-MM-dd");
                    //format of employee clock in date to a datetime type
                    time_in = DateTime.Parse(t_in, System.Globalization.CultureInfo.CurrentCulture);

                    //object type for image cells
                    object in_t = Properties.Resources.filled_circle_n_100px;
                    object out_t = Properties.Resources.filled_circle_n_100px;

                    DateTime time_out = new DateTime();
                    string timeOut= "Still Signed In";
                    if (!String.IsNullOrEmpty(data["time_out"].ToString()))
                    {
                        time_out = DateTime.Parse(data["time_out"].ToString(), System.Globalization.CultureInfo.CurrentCulture);
                        timeOut = time_out.ToString("HH:mm tt ddd, MMM dd, yyyy");
                    }

                    //comparing timein and timeout with schedule timein and timeout
                    int in_ = DateTime.Compare(time_in, sche_in);
                    int out_ = DateTime.Compare(time_out, sche_out);

                    DateTime cur_date = DateTime.Now;
                    DateTime time_in_date = new DateTime();
                    string s = cur_date.ToString("yyyy-MM-dd HH:mm:ss");
                    cur_date = DateTime.Parse(s, System.Globalization.CultureInfo.CurrentCulture);
                    time_in_date = DateTime.Parse(t_te, System.Globalization.CultureInfo.CurrentCulture);

                    if (in_ <= 0)
                        in_t = Properties.Resources.filled_circle_g_100px;
                    else
                        in_t = Properties.Resources.filled_circle_r_100px;

                    if (out_ == 0)
                    {
                        out_t = Properties.Resources.filled_circle_g_100px;
                    }
                    else if (String.IsNullOrEmpty(data["time_out"].ToString()))
                        out_t = Properties.Resources.filled_circle_n_100px;
                    else if (out_ > 0)
                    {
                        out_t = Properties.Resources.filled_circle_y_20px;
                    }
                    else if (out_ < 0)
                    {
                        out_t = Properties.Resources.filled_circle_r_100px;

                        /*int rel = DateTime.Compare(time_in_date, cur_date);
                        if (rel < 0)
                            out_t = Properties.Resources.filled_circle_y_20px;
                        else if (rel == 0)
                            */
                    }

                    this.Invoke(new MethodInvoker(delegate
                    {
                        tb.Rows.Add(i, names, timeIn, in_t, timeOut, out_t);
                    }));
                    i++;
                }
            }
        }

        private void Attendance_Shown(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
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
