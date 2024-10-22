using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management_System.Notification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            notify.Icon = Icon;
        }

        public NotifyIcon Notify
        {
            get { return notify; }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            notify.ShowBalloonTip(2000);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
