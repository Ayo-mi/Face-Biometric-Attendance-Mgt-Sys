
namespace Attendance_Management_System.Modal
{
    partial class Loader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuLoader1 = new Bunifu.UI.WinForms.BunifuLoader();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuLoader2 = new Bunifu.UI.WinForms.BunifuLoader();
            this.SuspendLayout();
            // 
            // bunifuLoader1
            // 
            this.bunifuLoader1.AllowStylePresets = true;
            this.bunifuLoader1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuLoader1.CapStyle = Bunifu.UI.WinForms.BunifuLoader.CapStyles.Round;
            this.bunifuLoader1.Color = System.Drawing.Color.DodgerBlue;
            this.bunifuLoader1.Colors = new Bunifu.UI.WinForms.Bloom[0];
            this.bunifuLoader1.Customization = "";
            this.bunifuLoader1.DashWidth = 0.5F;
            this.bunifuLoader1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLoader1.Image = null;
            this.bunifuLoader1.Location = new System.Drawing.Point(162, 73);
            this.bunifuLoader1.Name = "bunifuLoader1";
            this.bunifuLoader1.NoRounding = false;
            this.bunifuLoader1.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Solid;
            this.bunifuLoader1.RingStyle = Bunifu.UI.WinForms.BunifuLoader.RingStyles.Solid;
            this.bunifuLoader1.ShowText = false;
            this.bunifuLoader1.Size = new System.Drawing.Size(125, 121);
            this.bunifuLoader1.Speed = 7;
            this.bunifuLoader1.TabIndex = 0;
            this.bunifuLoader1.Text = "Signing in.....";
            this.bunifuLoader1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuLoader1.Thickness = 10;
            this.bunifuLoader1.Transparent = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(178, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Signing in...";
            // 
            // bunifuLoader2
            // 
            this.bunifuLoader2.AllowStylePresets = true;
            this.bunifuLoader2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuLoader2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuLoader2.CapStyle = Bunifu.UI.WinForms.BunifuLoader.CapStyles.Round;
            this.bunifuLoader2.Color = System.Drawing.Color.DodgerBlue;
            this.bunifuLoader2.Colors = new Bunifu.UI.WinForms.Bloom[0];
            this.bunifuLoader2.Customization = "";
            this.bunifuLoader2.DashWidth = 0.5F;
            this.bunifuLoader2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLoader2.Image = null;
            this.bunifuLoader2.Location = new System.Drawing.Point(359, 28);
            this.bunifuLoader2.Name = "bunifuLoader2";
            this.bunifuLoader2.NoRounding = false;
            this.bunifuLoader2.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Dotted;
            this.bunifuLoader2.RingStyle = Bunifu.UI.WinForms.BunifuLoader.RingStyles.Dotted;
            this.bunifuLoader2.ShowText = true;
            this.bunifuLoader2.Size = new System.Drawing.Size(105, 84);
            this.bunifuLoader2.Speed = 10;
            this.bunifuLoader2.TabIndex = 2;
            this.bunifuLoader2.Text = "Please wait....";
            this.bunifuLoader2.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuLoader2.Thickness = 66;
            this.bunifuLoader2.Transparent = true;
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(496, 336);
            this.Controls.Add(this.bunifuLoader2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuLoader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loader";
            this.Opacity = 0.7D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Loader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLoader bunifuLoader1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuLoader bunifuLoader2;
    }
}