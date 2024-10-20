using System;
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
    public partial class Login : Form
    {
        private Main parentForm;
        public Login(Main p)
        {
            this.parentForm = p;
            InitializeComponent();
        }

        public static Dashboard OpenChildForm(Dashboard childForm)
        {
            if (childForm != null)
            {
                Main p = new Main();
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                childForm.TopLevel = false;
                p.DesktopPanel.Controls.Clear();
                p.DesktopPanel.Controls.Add(childForm);
                childForm.BringToFront();
                childForm.Visible = true;
            }
            return childForm;
        }

      
        private async void bunifuButton21_Click(object sender, EventArgs e)
        {
            //parentForm.OpenChildForm(new Dashboard(parentForm));
            //this.Close();
            //await OpenFormAsyn();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //parentForm.OpenChildForm(new Dashboard(parentForm));
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
