using Attendance_Management_System.Biometric;
using Attendance_Management_System.Modal;
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
using System.Threading;
using System.Windows.Forms;

namespace Attendance_Management_System
{
    public partial class Main : Form
    {
        private Form currentChildForm;
        internal Verification verification;
        public Main()
        {
            InitializeComponent();
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //verification = new Verification(this);
            //verification.Start();
        }
        
        public void OpenChildForm(Form childForm)
        {
            if(childForm != null)
            {
                currentChildForm = childForm;
                currentChildForm.FormBorderStyle = FormBorderStyle.None;
                currentChildForm.Dock = DockStyle.Fill;
                currentChildForm.TopLevel = false;
                
                if (desktopPanel.InvokeRequired)
                {
                    desktopPanel.Invoke(new MethodInvoker(delegate {
                        desktopPanel.Controls.Clear();
                        desktopPanel.Controls.Add(currentChildForm);
                        currentChildForm.Visible = true;
                        currentChildForm.BringToFront();
                    }));
                }
                else
                {
                    desktopPanel.Controls.Clear();
                    desktopPanel.Controls.Add(currentChildForm);
                    currentChildForm.Visible = true;
                    currentChildForm.BringToFront();
                }
               
            }
        }
        
/*
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
        }*/

        public Panel DesktopPanel
        {
            get { return desktopPanel; }
        }

        public Panel LoginPanel
        {
            get { return loginPanel; }
        }

        public BunifuSnackbar Prompt
        {
            get { return prompt; }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //OpenChildForm(new Login(this));
            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(0);
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
                loginPanel.Visible = true;
            }
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (loaderBgWorker.IsBusy != true)
            {
                // Start the asynchronous operation.
                loaderBgWorker.RunWorkerAsync();
            }
        }

        private void loaderBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            String user = username.Text;
            String pw = psw.Text;
            String stmt = "SELECT username, first_name, last_name from users where username = @us and password = @pw limit 1";
            Hashtable attr = new Hashtable();
            attr.Add("@us", user);
            attr.Add("@pw", pw);
            DBConnection dB = new DBConnection();
            MySqlDataReader data = (MySqlDataReader)dB.Select(stmt, attr);
            if (data !=null && data.Read())
            {
                e.Result = true;                
            }
            else
            {
                e.Result = false;
            }
        }

        private void loaderBgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
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
                    OpenChildForm(new Dashboard(this, username.Text));
                }
                else
                {
                    prompt.Show(this, "Incorrect username or password",
                       BunifuSnackbar.MessageTypes.Error, 1000, "",
                       BunifuSnackbar.Positions.MiddleCenter, BunifuSnackbar.Hosts.FormOwner);
                }
                
                //Thread.Sleep(100);
                //isF = true;
            }
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            new MarkAttendanceForm().ShowDialog(this);
        }
    }
}
