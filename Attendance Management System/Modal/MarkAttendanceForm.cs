using Attendance_Management_System.Biometric;
using DPFP.Verification;
using DPFP;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management_System.Modal
{
    public partial class MarkAttendanceForm : Form
    {
        private FaceRecognitionSystem FaceRecognition { get; set; }

        public string Id { get; set; }
        public MarkAttendanceForm()
        {
            InitializeComponent();
            FaceRecognition = new FaceRecognitionSystem();
        }

        private bool IsVerified()
        {
            bool isVerified = false;
            DBConnection query = new DBConnection();
            String stmt = "select last_name, first_name, employee_id, position_id, curr_state, curr_id from employees where employee_id = @id LIMIT 1;";
            Hashtable attr = new Hashtable();
            attr.Add("@id", Id);

            MySqlDataReader data = (MySqlDataReader)query.Select(stmt, attr);
            if (data != null)
            {
                while (data.Read())
                {
                    Hashtable res = new Hashtable();
                    res.Add("emp", data["employee_id"]);
                    res.Add("posi", data["position_id"]);
                    res.Add("cu_id", data["curr_id"]);
                    res.Add("cu_st", data["curr_state"]);

                    string ln = data["last_name"].ToString().Trim();
                    string fn = data["first_name"].ToString().Trim();

                    switch (data["curr_state"].ToString())
                    {
                        case "0":
                            isVerified = SignIn(res);
                            if (isVerified)
                            {
                                notifyIcon1.BalloonTipTitle = "User Signed-in Successful";
                                notifyIcon1.BalloonTipText = ln + " " + fn + " Signed in at " + DateTime.Now.ToString("h:mm:ss tt");
                                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                                notifyIcon1.ShowBalloonTip(2000);
                            }
                            else
                            {
                                notifyIcon1.BalloonTipTitle = "Duplicate Sign-in Today";
                                notifyIcon1.BalloonTipText = ln + " " + fn + " already Signed in today";
                                notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                                notifyIcon1.ShowBalloonTip(2000);
                            }
                            break;
                        case "1":

                            isVerified = SignOut(res);
                            if (isVerified)
                            {
                                notifyIcon1.BalloonTipTitle = "User Signed-out Successful";
                                notifyIcon1.BalloonTipText = ln + " " + fn + " Signed out at " + DateTime.Now.ToString("h:mm:ss tt");
                                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                                notifyIcon1.ShowBalloonTip(2000);
                            }
                            break;
                    }

                    break;
                    

                }

            }
            else
            {
            }
            return isVerified;
        }

        private bool SignIn(Hashtable empde)
        {
            bool status = false;

            if (!IsAlreadySignedInToday(empde))
            {
                if (empde["cu_st"].ToString().Equals("0"))
                {
                    DBConnection dB = new DBConnection();
                    String id = Guid.NewGuid().ToString("B").ToUpper();
                    string timein = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    string pid = empde["posi"].ToString();

                    String stmt = "INSERT INTO attendance_record (attendance_id, time_in, schedule_timein," +
                        " schedule_timeout, schedule_name, position_name, employee_id)" +
                                " VALUES (@ai, @ti, @st, @so, @sn, @pn, @ed);" +
                                "UPDATE employees set curr_state=@cs, curr_id=@ai where employee_id=@ed";
                    Hashtable attr = new Hashtable();
                    attr.Add("@ai", id);
                    attr.Add("@ti", timein);
                    attr.Add("@st", getScheduleTiming(pid, "start"));
                    attr.Add("@so", getScheduleTiming(pid, "end"));
                    attr.Add("@sn", getScheduleTiming(pid, "schedule"));
                    attr.Add("@pn", getScheduleTiming(pid, "position"));
                    attr.Add("@ed", empde["emp"]);
                    attr.Add("@cs", 1);

                    if (dB.Operation(stmt, attr))
                        status = true;
                    else
                        status = false;
                }

            }
            else
                status = false;

            return status;
        }

        private bool SignOut(Hashtable empde)
        {
            bool status = false;
            if (empde["cu_st"].ToString().Equals("1"))
            {
                DBConnection dB = new DBConnection();
                string timeout = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                String stmt = "UPDATE attendance_record set time_out=@to where attendance_id=@ai;" +
                            "UPDATE employees set curr_state=@cs where employee_id=@ed;";
                Hashtable attr = new Hashtable();
                attr.Add("@ai", empde["cu_id"]);
                attr.Add("@to", timeout);
                attr.Add("@ed", empde["emp"]);
                attr.Add("@cs", 0);

                if (dB.Operation(stmt, attr))
                    status = true;
                else
                    status = false;
            }
            return status;
        }

        private String getScheduleTiming(string position_id, string key)
        {
            Hashtable values = new Hashtable();
            string value = "";
            DBConnection query = new DBConnection();
            string sql = "SELECT p.name, s.start_time, s.end_time, s.name as sche_name FROM " +
                "attenance_mgt.positions p left join schedules s on p.schedule_id = s.schedule_id where position_id=@id LIMIT 1;";

            Hashtable attr = new Hashtable();
            attr.Add("@id", position_id);
            MySqlDataReader data = (MySqlDataReader)query.Select(sql, attr);
            if (data != null)
            {
                while (data.Read())
                {
                    values.Add("position_name", data["name"]);
                    values.Add("schedule_name", data["sche_name"]);
                    values.Add("start_time", data["start_time"]);
                    values.Add("end_time", data["end_time"]);
                }
            }
            switch (key.ToLower())
            {
                case "position":
                    value = values["position_name"].ToString();
                    break;
                case "schedule":
                    value = values["schedule_name"].ToString();
                    break;
                case "start":
                    value = values["start_time"].ToString();
                    break;
                case "end":
                    value = values["end_time"].ToString();
                    break;

            }
            return value;
        }

        private bool IsAlreadySignedInToday(Hashtable empde)
        {
            bool state = false;
            DBConnection query = new DBConnection();
            String stm = "select time_in from attendance_record where attendance_id =@ar limit 1;";
            Hashtable att = new Hashtable();
            att.Add("@ar", empde["cu_id"]);

            MySqlDataReader data = (MySqlDataReader)query.Select(stm, att);
            if (data != null)
            {
                while (data.Read())
                {
                    DateTime n = DateTime.Today;
                    int comp = DateTime.Compare(n, data.GetDateTime(0));

                    if (comp < 0 || comp == 0)
                    {
                        state = true;
                    }
                }

            }

            return state;
        }

        
        private void MarkAttendanceForm_Load(object sender, EventArgs e)
        {
            FaceRecognition.openCamera(bunifuPictureBox1, bunifuPictureBox2 );
        }

        private void MarkAttendanceForm_Shown(object sender, EventArgs e)
        {
            FaceRecognition.isTrained = true;
        }

        private void MarkAttendanceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FaceRecognition.StopCamera();
            FaceRecognition.Dispose();
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {

        }
    }
}
