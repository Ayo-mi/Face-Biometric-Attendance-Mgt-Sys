using Attendance_Management_System.Modal;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
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
    public partial class Dashboard : Form
    {
        Main parentForm;
        private Form currentChildForm;
        private String id;
        public Dashboard(Main f, String id)
        {
            parentForm = f;
            InitializeComponent();
            this.id = id;
            //f.verification.Stop();
            
        }

        public void OpenChildForm(Form childForm)
        {
            if (childForm != null)
            {
                currentChildForm = childForm;
                currentChildForm.FormBorderStyle = FormBorderStyle.None;
                currentChildForm.Dock = DockStyle.Fill;
                currentChildForm.TopLevel = false;
                adminDesktop.Controls.Clear();
                adminDesktop.Controls.Add(currentChildForm);
                currentChildForm.Visible = true;
                currentChildForm.BringToFront();
            }
        }

        private void selectedColor(BunifuButton2 btn)
        {
            btn.IdleFillColor = Color.FromArgb(129, 164, 227);
            btn.IdleBorderColor = Color.FromArgb(129, 164, 227);

            btn.OnPressedState.FillColor = Color.FromArgb(129, 164, 227);
            btn.OnPressedState.BorderColor = Color.FromArgb(129, 164, 227);
        }

        private void unSelectedColor()
        {
            dashBtn.IdleFillColor = Color.FromArgb(74, 101, 174);
            dashBtn.IdleBorderColor = Color.FromArgb(74, 101, 174);

            emplBtn.IdleFillColor = Color.FromArgb(74, 101, 174);
            emplBtn.IdleBorderColor = Color.FromArgb(74, 101, 174);

            posiBtn.IdleFillColor = Color.FromArgb(74, 101, 174);
            posiBtn.IdleBorderColor = Color.FromArgb(74, 101, 174);

            deducBtn.IdleFillColor = Color.FromArgb(74, 101, 174);
            deducBtn.IdleBorderColor = Color.FromArgb(74, 101, 174);

            attenBtn.IdleFillColor = Color.FromArgb(74, 101, 174);
            attenBtn.IdleBorderColor = Color.FromArgb(74, 101, 174);
        }

        private void reAdjustColor(BunifuButton2 btn)
        {
            unSelectedColor();
            selectedColor(btn);
        }

        public String Initials(String firstName, String lastName)
        {
            String res = "";
            res = firstName.Substring(0, 1).ToUpper().Trim() + "" + lastName.Substring(0, 1).ToUpper().Trim();
            return res;
        }

        private int CountRecord(string table)
        {
            int count = 0;

            String stmt = String.Format("SELECT COUNT(*) as count from {0} where status=@st;", table);

            Hashtable attr = new Hashtable();
            attr.Add("@st", 1);

            DBConnection dB = new DBConnection();
            MySqlDataReader data = (MySqlDataReader)dB.Select(stmt, attr);
            if (data != null)
            {
                while (data.Read())
                {
                    count = data.GetInt32(0);
                }
            }

                    return count;
        }

        private int GetTodayAttendance()
        {
            int total = 0;

            String stmt = "SELECT COUNT(*) as count from attendance_record where Date(time_in)=Date(now());";

            Hashtable attr = new Hashtable();

            DBConnection dB = new DBConnection();
            MySqlDataReader data = (MySqlDataReader)dB.Select(stmt, attr);
            if (data != null)
            {
                while (data.Read())
                {
                    total = data.GetInt32(0);
                }
            }

            return total;
        }

        //current month
        private int GetMonthAttendance()
        {
            int total = 0;

            String stmt = "SELECT COUNT(*) as count from attendance_record where MONTH(time_in) = Month(current_date())" +
                " and YEAR(time_in) = YEAR(current_date());";


            Hashtable attr = new Hashtable();

            DBConnection dB = new DBConnection();
            MySqlDataReader data = (MySqlDataReader)dB.Select(stmt, attr);
            if (data != null)
            {
                while (data.Read())
                {
                    total = data.GetInt32(0);
                }
            }

            return total;
        }

        private int GetTodayEarly()
        {
            int total = 0;

            String stmt = "SELECT COUNT(*) as count from attendance_record where Date(time_in)=Date(now()) and TIME(TIME_FORMAT(time_in, '%H:%i')) <= TIME(TIME_FORMAT(schedule_timein, '%H:%i'));";

            Hashtable attr = new Hashtable();

            DBConnection dB = new DBConnection();
            MySqlDataReader data = (MySqlDataReader)dB.Select(stmt, attr);
            if (data != null)
            {
                while (data.Read())
                {
                    total = data.GetInt32(0);
                }
            }

            return total;
        }

        private int GetMonthEarly()
        {
            int total = 0;

            String stmt = "SELECT COUNT(*) as count from attendance_record where MONTH(time_in) = Month(current_date())" +
                " and YEAR(time_in) = YEAR(current_date()) and TIME(TIME_FORMAT(time_in, '%H:%i')) <= TIME(TIME_FORMAT(schedule_timein, '%H:%i'));";

            Hashtable attr = new Hashtable();

            DBConnection dB = new DBConnection();
            MySqlDataReader data = (MySqlDataReader)dB.Select(stmt, attr);
            if (data != null)
            {
                while (data.Read())
                {
                    total = data.GetInt32(0);
                }
            }

            return total;
        }

        private int GetTodayLate()
        {
            int total = 0;

            String stmt = "SELECT COUNT(*) as count from attendance_record where Date(time_in)=Date(now()) and TIME(TIME_FORMAT(time_in, '%H:%i')) > TIME(TIME_FORMAT(schedule_timein, '%H:%i'));";

            Hashtable attr = new Hashtable();

            DBConnection dB = new DBConnection();
            MySqlDataReader data = (MySqlDataReader)dB.Select(stmt, attr);
            if (data != null)
            {
                while (data.Read())
                {
                    total = data.GetInt32(0);
                }
            }

            return total;
        }

        private int GetMonthLate()
        {
            int total = 0;

            String stmt = "SELECT COUNT(*) as count from attendance_record where MONTH(time_in) = Month(current_date())" +
                " and YEAR(time_in) = YEAR(current_date()) and TIME(TIME_FORMAT(time_in, '%H:%i')) > TIME(TIME_FORMAT(schedule_timein, '%H:%i'));";

            Hashtable attr = new Hashtable();

            DBConnection dB = new DBConnection();
            MySqlDataReader data = (MySqlDataReader)dB.Select(stmt, attr);
            if (data != null)
            {
                while (data.Read())
                {
                    total = data.GetInt32(0);
                }
            }

            return total;
        }

        private Hashtable GetCurrentWeek()
        {
            Hashtable chartData = new Hashtable();

            chartData.Add("monE", 0);
            chartData.Add("monL", 0);
            chartData.Add("tueE", 0);
            chartData.Add("tueL", 0);
            chartData.Add("wedE", 0);
            chartData.Add("wedL", 0);
            chartData.Add("thuE", 0);
            chartData.Add("thuL", 0);
            chartData.Add("friE", 0);
            chartData.Add("friL", 0);
            chartData.Add("satE", 0);
            chartData.Add("satL", 0);
            chartData.Add("sunE", 0);
            chartData.Add("sunL", 0);

            String stmt = "select if(weekday(time_in)=0,'Monday', if(weekday(time_in)=1, 'Tuesday', " +
                "if (weekday(time_in) = 2,'Wednesday', if (weekday(time_in) = 3, 'Thursday', " +
                "if (weekday(time_in) = 4, 'Friday', if (weekday(time_in) = 5, 'Saturday', " +
                "if (weekday(time_in) = 6, 'Sunday' ,''))))))) as 'day', time_in as ti, schedule_timein" +
                " as sh from attendance_record where yearweek(date_created) = yearweek(now());";

            Hashtable attr = new Hashtable();

            DBConnection dB = new DBConnection();
            MySqlDataReader data = (MySqlDataReader)dB.Select(stmt, attr);
            if (data != null)
            {
                while (data.Read())
                {
                   switch (data.GetString(0))
                   {
                        case "Monday":
                            int a = checkPuntuality(data.GetString(1), data.GetString(2));
                            if (a <= 0)
                            {
                                int x = Convert.ToInt32(chartData["monE"]);
                                x += 1;
                                chartData["monE"] = x;
                            }
                            else
                            {
                                int x = Convert.ToInt32(chartData["monL"]);
                                x += 1;
                                chartData["monL"] = x;
                            }
                            break;

                        case "Tuesday":
                            int t = checkPuntuality(data.GetString(1), data.GetString(2));
                            if (t <= 0)
                            {
                                int x = Convert.ToInt32(chartData["tueE"]);
                                x += 1;
                                chartData["tueE"] = x;
                            }
                            else
                            {
                                int x = Convert.ToInt32(chartData["tueL"]);
                                x += 1;
                                chartData["tueL"] = x;
                            }
                            break;

                        case "Wednesday":
                            int w = checkPuntuality(data.GetString(1), data.GetString(2));
                            if (w <= 0)
                            {
                                int x = Convert.ToInt32(chartData["wedE"]);
                                x += 1;
                                chartData["wedE"] = x;
                            }
                            else
                            {
                                int x = Convert.ToInt32(chartData["wedL"]);
                                x += 1;
                                chartData["wedL"] = x;
                            }
                            break;

                        case "Thursday":
                            int th = checkPuntuality(data.GetString(1), data.GetString(2));
                            if (th <= 0)
                            {
                                int x = Convert.ToInt32(chartData["thuE"]);
                                x += 1;
                                chartData["thuE"] = x;
                            }
                            else
                            {
                                int x = Convert.ToInt32(chartData["thuL"]);
                                x += 1;
                                chartData["thuL"] = x;
                            }
                            break;

                        case "Friday":
                            int f = checkPuntuality(data.GetString(1), data.GetString(2));
                            if (f <= 0)
                            {
                                int x = Convert.ToInt32(chartData["friE"]);
                                x += 1;
                                chartData["friE"] = x;
                            }
                            else
                            {
                                int x = Convert.ToInt32(chartData["friL"]);
                                x += 1;
                                chartData["friL"] = x;
                            }
                            break;

                        case "Saturday":
                            int s = checkPuntuality(data.GetString(1), data.GetString(2));
                            if (s <= 0)
                            {
                                int x = Convert.ToInt32(chartData["satE"]);
                                x += 1;
                                chartData["satE"] = x;
                            }
                            else
                            {
                                int x = Convert.ToInt32(chartData["satL"]);
                                x += 1;
                                chartData["satL"] = x;
                            }
                            break;

                        case "Sunday":
                            int su = checkPuntuality(data.GetString(1), data.GetString(2));
                            if (su <= 0)
                            {
                                int x = Convert.ToInt32(chartData["sunE"]);
                                x += 1;
                                chartData["sunE"] = x;
                            }
                            else
                            {
                                int x = Convert.ToInt32(chartData["sunL"]);
                                x += 1;
                                chartData["sunL"] = x;
                            }
                            break;
                    }
                }
            }

            return chartData;
        }

        private void PopulatePieChart()
        {
            pieChart.Data.Clear();

            int monthTotal = GetMonthAttendance();
            int monthEarl = GetMonthEarly();
            int monthLate = GetMonthLate();
            double monOnT = 0;
            double monLat = 0;

            if (monthTotal != 0)
            {
                monOnT = (monthEarl * 100) / monthTotal;

                monLat = (monthLate * 100) / monthTotal;

                List<double> data = new List<double>();
                data.Add(monOnT);
                data.Add(monLat);
                
                pieChart.Data = data;
                
            }
            else
            {
                List<double> data = new List<double>();
                data.Add(monOnT);
                data.Add(monLat);
                pieChart.Data = data;
            }

            pieChart.TargetCanvas = this.bunifuChartCanvas1;
        }

        private void PopulateLineChart()
        {
            int totalEmp = CountRecord("employees");
            Hashtable weekRec = new Hashtable();
            weekRec = GetCurrentWeek();
            try
            {
                int monE = ((int)weekRec["monE"] * 100) / totalEmp;

                int monL = ((int)weekRec["monL"] * 100) / totalEmp;

                int tueE = ((int)weekRec["tueE"] * 100) / totalEmp;

                int tueL = ((int)weekRec["tueL"] * 100) / totalEmp;

                int wedE = ((int)weekRec["wedE"] * 100) / totalEmp;

                int wedL = ((int)weekRec["wedL"] * 100) / totalEmp;

                int thuE = ((int)weekRec["thuE"] * 100) / totalEmp;

                int thuL = ((int)weekRec["thuL"] * 100) / totalEmp;

                int friE = ((int)weekRec["friE"] * 100) / totalEmp;

                int friL = ((int)weekRec["friL"] * 100) / totalEmp;

                int satE = ((int)weekRec["satE"] * 100) / totalEmp;

                int satL = ((int)weekRec["satL"] * 100) / totalEmp;

                int sunE = ((int)weekRec["sunE"] * 100) / totalEmp;

                int sunL = ((int)weekRec["sunL"] * 100) / totalEmp;

                List<double> dataE = new List<double>();
                List<double> dataL = new List<double>();
                dataE.Add(monE);
                dataE.Add(tueE);
                dataE.Add(wedE);
                dataE.Add(thuE);
                dataE.Add(friE);
                dataE.Add(satE);
                dataE.Add(sunE);
                earlyLine.Data = dataE;                

                dataL.Add(monL);
                dataL.Add(tueL);
                dataL.Add(wedL);
                dataL.Add(thuL);
                dataL.Add(friL);
                dataL.Add(satL);
                dataL.Add(sunL);
                lateLine.Data = dataL;

            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            earlyLine.TargetCanvas = bunifuChartCanvas2;
            lateLine.TargetCanvas = bunifuChartCanvas2;
        }

        private int checkPuntuality(string t, string s)
        {
            int a=0;

            DateTime sche_in = DateTime.Parse(s, System.Globalization.CultureInfo.CurrentCulture);
            
            DateTime time_in = DateTime.Parse(t, System.Globalization.CultureInfo.CurrentCulture);
            time_in = DateTime.Parse(time_in.ToString("HH:mm:00"), System.Globalization.CultureInfo.CurrentCulture);

            a = DateTime.Compare(time_in, sche_in);

            return a;
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (!statistics.IsBusy)
                statistics.RunWorkerAsync();

            adminDesktop.Controls.Clear();
            adminDesktop.Controls.Add(dashDesktop);
            //reAdjustColor(dashBtn);
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Employees(this));
            //reAdjustColor(emplBtn);
        }

        private void label14_Click(object sender, EventArgs e)
        {
            new Add_User().ShowDialog();
        }

        private void attenBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Attendance(this));
        }

        private void deducBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Schedule(this));
        }

        private void posiBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Position(this));
        }

        private void label13_Click(object sender, EventArgs e)
        {
            new Add_Employee().ShowDialog();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            new Add_Position().ShowDialog();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            String stmt = "SELECT first_name, last_name from users where username = @us limit 1";
            Hashtable attr = new Hashtable();
            attr.Add("@us", id);
            DBConnection dB = new DBConnection();
            MySqlDataReader data = (MySqlDataReader)dB.Select(stmt, attr);
            if (data.Read())
            {
                this.Invoke(new MethodInvoker(delegate {
                    avater.Text = Initials(data.GetString(0), data.GetString(1));
                name.Text = $"{data.GetString(0).Trim()} {data.GetString(1).Trim()}";
                e.Result = true;
                }));
            }
            else
            {
                e.Result = false;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {

            }
            else if (e.Error != null)
            {
            }
            else
            {
                if ((bool)e.Result)
                {
                    prompt.Show(this, "User verified! Signing in as " + name.Text,
                       Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 1000, "",
                       Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopCenter, Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);
                }
                else
                {
                    prompt.Show(this, "Incorrect username or password",
                       BunifuSnackbar.MessageTypes.Error, 1000, "",
                       BunifuSnackbar.Positions.MiddleCenter, BunifuSnackbar.Hosts.FormOwner);
                }
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            parentForm.DesktopPanel.Controls.Clear();
            parentForm.DesktopPanel.Controls.Add(parentForm.LoginPanel);
            parentForm.LoginPanel.BringToFront();
            parentForm.verification.Start();
            parentForm.LoginPanel.Visible = true;
        }

        private void Dashboard_Shown(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void statistics_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                positions.Text = CountRecord("positions").ToString();
                users.Text = CountRecord("users").ToString();
                employees.Text = CountRecord("employees").ToString();

                int total = GetTodayAttendance();
                double onT = 0;
                double l = 0;
                int earl = GetTodayEarly();
                int lat = GetTodayLate();                

                if (total != 0)
                {
                    onT = (earl * 100) / total;

                    l = (lat * 100) / total;

                    onTime.Text = onT.ToString() + "%";
                    late.Text = l.ToString() + "%";
                }
                else
                {
                    onTime.Text = onT + "%";
                    late.Text = l + "%";
                }                               

                early.Text = earl + " of " + total;
                latelb.Text = lat + " of " + total;
                PopulatePieChart();
                PopulateLineChart();
                
            }));            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (!statistics.IsBusy)
                statistics.RunWorkerAsync();
        }
    }
}
