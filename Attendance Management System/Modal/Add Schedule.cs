using Bunifu.UI.WinForms;
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
    public partial class Add_Schedule : Form
    {
        public Add_Schedule()
        {
            InitializeComponent();
            endTime.Format = DateTimePickerFormat.Time;
            startTime.Format = DateTimePickerFormat.Time;            
            //return Guid.NewGuid().ToString("N");
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

                String id = "schd_" + Guid.NewGuid().ToString("N");

                String stmt = "INSERT INTO schedules (schedule_id, name, start_time, end_time, status)" +
                            " VALUES (@id, @na, @st, @et, @ts);";
                Hashtable attr = new Hashtable();
                attr.Add("@id", id);
                attr.Add("@na", sche);
                attr.Add("@st", st);
                attr.Add("@et", et);
                attr.Add("@ts", 1);

                if (dB.Operation(stmt, attr))
                {
                    prompt.Show(this, "Schedule was created successfully",
                       BunifuSnackbar.MessageTypes.Success, 1000, "",
                       BunifuSnackbar.Positions.TopCenter, BunifuSnackbar.Hosts.FormOwner);
                }
                else
                {
                    MessageBox.Show("Schedule was not created, an error occured", "Add New Schedule", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Enter all details", "Add New Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
