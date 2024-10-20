
namespace Attendance_Management_System.Modal.Edit_Modal
{
    partial class Edit_Schedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Schedule));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuButton21 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuButton22 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.scheName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.prompt = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(309, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 39);
            this.button1.TabIndex = 31;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(204, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "End Time";
            // 
            // endTime
            // 
            this.endTime.CustomFormat = "H:mm tt";
            this.endTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTime.Location = new System.Drawing.Point(194, 230);
            this.endTime.Name = "endTime";
            this.endTime.ShowUpDown = true;
            this.endTime.Size = new System.Drawing.Size(130, 33);
            this.endTime.TabIndex = 29;
            this.endTime.Value = new System.DateTime(2022, 7, 9, 16, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Start Time";
            // 
            // startTime
            // 
            this.startTime.CustomFormat = "H:mm tt";
            this.startTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTime.Location = new System.Drawing.Point(14, 230);
            this.startTime.Name = "startTime";
            this.startTime.ShowUpDown = true;
            this.startTime.Size = new System.Drawing.Size(130, 33);
            this.startTime.TabIndex = 27;
            this.startTime.Value = new System.DateTime(2022, 7, 28, 8, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(42, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Schedule Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(115, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Edit Schedule";
            // 
            // bunifuButton21
            // 
            this.bunifuButton21.AllowAnimations = true;
            this.bunifuButton21.AllowMouseEffects = true;
            this.bunifuButton21.AllowToggling = false;
            this.bunifuButton21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuButton21.AnimationSpeed = 200;
            this.bunifuButton21.AutoGenerateColors = false;
            this.bunifuButton21.AutoRoundBorders = false;
            this.bunifuButton21.AutoSizeLeftIcon = true;
            this.bunifuButton21.AutoSizeRightIcon = true;
            this.bunifuButton21.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton21.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(93)))), ((int)(((byte)(98)))));
            this.bunifuButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton21.BackgroundImage")));
            this.bunifuButton21.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.ButtonText = "Delete Schedule";
            this.bunifuButton21.ButtonTextMarginLeft = 0;
            this.bunifuButton21.ColorContrastOnClick = 45;
            this.bunifuButton21.ColorContrastOnHover = 45;
            this.bunifuButton21.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton21.CustomizableEdges = borderEdges1;
            this.bunifuButton21.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton21.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton21.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton21.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton21.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Idle;
            this.bunifuButton21.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton21.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton21.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton21.IconMarginLeft = 11;
            this.bunifuButton21.IconPadding = 10;
            this.bunifuButton21.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton21.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton21.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton21.IconSize = 25;
            this.bunifuButton21.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(93)))), ((int)(((byte)(98)))));
            this.bunifuButton21.IdleBorderRadius = 15;
            this.bunifuButton21.IdleBorderThickness = 1;
            this.bunifuButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(93)))), ((int)(((byte)(98)))));
            this.bunifuButton21.IdleIconLeftImage = null;
            this.bunifuButton21.IdleIconRightImage = null;
            this.bunifuButton21.IndicateFocus = false;
            this.bunifuButton21.Location = new System.Drawing.Point(179, 306);
            this.bunifuButton21.Name = "bunifuButton21";
            this.bunifuButton21.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton21.OnDisabledState.BorderRadius = 15;
            this.bunifuButton21.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnDisabledState.BorderThickness = 1;
            this.bunifuButton21.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton21.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton21.OnDisabledState.IconLeftImage = null;
            this.bunifuButton21.OnDisabledState.IconRightImage = null;
            this.bunifuButton21.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(178)))), ((int)(((byte)(157)))));
            this.bunifuButton21.onHoverState.BorderRadius = 15;
            this.bunifuButton21.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.onHoverState.BorderThickness = 1;
            this.bunifuButton21.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(178)))), ((int)(((byte)(157)))));
            this.bunifuButton21.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.onHoverState.IconLeftImage = null;
            this.bunifuButton21.onHoverState.IconRightImage = null;
            this.bunifuButton21.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(93)))), ((int)(((byte)(98)))));
            this.bunifuButton21.OnIdleState.BorderRadius = 15;
            this.bunifuButton21.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnIdleState.BorderThickness = 1;
            this.bunifuButton21.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(93)))), ((int)(((byte)(98)))));
            this.bunifuButton21.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.OnIdleState.IconLeftImage = null;
            this.bunifuButton21.OnIdleState.IconRightImage = null;
            this.bunifuButton21.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(93)))), ((int)(((byte)(98)))));
            this.bunifuButton21.OnPressedState.BorderRadius = 15;
            this.bunifuButton21.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnPressedState.BorderThickness = 1;
            this.bunifuButton21.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(93)))), ((int)(((byte)(98)))));
            this.bunifuButton21.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton21.OnPressedState.IconLeftImage = null;
            this.bunifuButton21.OnPressedState.IconRightImage = null;
            this.bunifuButton21.Size = new System.Drawing.Size(133, 39);
            this.bunifuButton21.TabIndex = 26;
            this.bunifuButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton21.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton21.TextMarginLeft = 0;
            this.bunifuButton21.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton21.UseDefaultRadiusAndThickness = true;
            this.bunifuButton21.Click += new System.EventHandler(this.bunifuButton21_Click);
            // 
            // bunifuButton22
            // 
            this.bunifuButton22.AllowAnimations = true;
            this.bunifuButton22.AllowMouseEffects = true;
            this.bunifuButton22.AllowToggling = false;
            this.bunifuButton22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuButton22.AnimationSpeed = 200;
            this.bunifuButton22.AutoGenerateColors = false;
            this.bunifuButton22.AutoRoundBorders = false;
            this.bunifuButton22.AutoSizeLeftIcon = true;
            this.bunifuButton22.AutoSizeRightIcon = true;
            this.bunifuButton22.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton22.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(178)))), ((int)(((byte)(167)))));
            this.bunifuButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton22.BackgroundImage")));
            this.bunifuButton22.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton22.ButtonText = "Save";
            this.bunifuButton22.ButtonTextMarginLeft = 0;
            this.bunifuButton22.ColorContrastOnClick = 45;
            this.bunifuButton22.ColorContrastOnHover = 45;
            this.bunifuButton22.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButton22.CustomizableEdges = borderEdges2;
            this.bunifuButton22.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton22.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton22.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton22.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton22.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Idle;
            this.bunifuButton22.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton22.ForeColor = System.Drawing.Color.White;
            this.bunifuButton22.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton22.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton22.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton22.IconMarginLeft = 11;
            this.bunifuButton22.IconPadding = 10;
            this.bunifuButton22.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton22.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton22.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton22.IconSize = 25;
            this.bunifuButton22.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(178)))), ((int)(((byte)(167)))));
            this.bunifuButton22.IdleBorderRadius = 15;
            this.bunifuButton22.IdleBorderThickness = 1;
            this.bunifuButton22.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(178)))), ((int)(((byte)(167)))));
            this.bunifuButton22.IdleIconLeftImage = null;
            this.bunifuButton22.IdleIconRightImage = null;
            this.bunifuButton22.IndicateFocus = false;
            this.bunifuButton22.Location = new System.Drawing.Point(48, 306);
            this.bunifuButton22.Name = "bunifuButton22";
            this.bunifuButton22.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton22.OnDisabledState.BorderRadius = 15;
            this.bunifuButton22.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton22.OnDisabledState.BorderThickness = 1;
            this.bunifuButton22.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton22.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton22.OnDisabledState.IconLeftImage = null;
            this.bunifuButton22.OnDisabledState.IconRightImage = null;
            this.bunifuButton22.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(178)))), ((int)(((byte)(157)))));
            this.bunifuButton22.onHoverState.BorderRadius = 15;
            this.bunifuButton22.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton22.onHoverState.BorderThickness = 1;
            this.bunifuButton22.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(178)))), ((int)(((byte)(157)))));
            this.bunifuButton22.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton22.onHoverState.IconLeftImage = null;
            this.bunifuButton22.onHoverState.IconRightImage = null;
            this.bunifuButton22.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(178)))), ((int)(((byte)(167)))));
            this.bunifuButton22.OnIdleState.BorderRadius = 15;
            this.bunifuButton22.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton22.OnIdleState.BorderThickness = 1;
            this.bunifuButton22.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(178)))), ((int)(((byte)(167)))));
            this.bunifuButton22.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton22.OnIdleState.IconLeftImage = null;
            this.bunifuButton22.OnIdleState.IconRightImage = null;
            this.bunifuButton22.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(178)))), ((int)(((byte)(167)))));
            this.bunifuButton22.OnPressedState.BorderRadius = 15;
            this.bunifuButton22.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton22.OnPressedState.BorderThickness = 1;
            this.bunifuButton22.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(178)))), ((int)(((byte)(167)))));
            this.bunifuButton22.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton22.OnPressedState.IconLeftImage = null;
            this.bunifuButton22.OnPressedState.IconRightImage = null;
            this.bunifuButton22.Size = new System.Drawing.Size(103, 39);
            this.bunifuButton22.TabIndex = 25;
            this.bunifuButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton22.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton22.TextMarginLeft = 0;
            this.bunifuButton22.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton22.UseDefaultRadiusAndThickness = true;
            this.bunifuButton22.Click += new System.EventHandler(this.bunifuButton22_Click);
            // 
            // scheName
            // 
            this.scheName.AcceptsReturn = false;
            this.scheName.AcceptsTab = false;
            this.scheName.AnimationSpeed = 200;
            this.scheName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.scheName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.scheName.AutoSizeHeight = true;
            this.scheName.BackColor = System.Drawing.Color.Transparent;
            this.scheName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scheName.BackgroundImage")));
            this.scheName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(93)))), ((int)(((byte)(98)))));
            this.scheName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.scheName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(93)))), ((int)(((byte)(98)))));
            this.scheName.BorderColorIdle = System.Drawing.Color.Gray;
            this.scheName.BorderRadius = 15;
            this.scheName.BorderThickness = 1;
            this.scheName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.scheName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.scheName.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheName.DefaultText = "";
            this.scheName.FillColor = System.Drawing.Color.DarkGray;
            this.scheName.ForeColor = System.Drawing.Color.White;
            this.scheName.HideSelection = true;
            this.scheName.IconLeft = null;
            this.scheName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.scheName.IconPadding = 10;
            this.scheName.IconRight = null;
            this.scheName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.scheName.Lines = new string[0];
            this.scheName.Location = new System.Drawing.Point(29, 128);
            this.scheName.MaxLength = 32767;
            this.scheName.MinimumSize = new System.Drawing.Size(1, 1);
            this.scheName.Modified = false;
            this.scheName.Multiline = false;
            this.scheName.Name = "scheName";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(93)))), ((int)(((byte)(98)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.scheName.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.scheName.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(93)))), ((int)(((byte)(98)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.scheName.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Gray;
            stateProperties4.FillColor = System.Drawing.Color.DarkGray;
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.scheName.OnIdleState = stateProperties4;
            this.scheName.Padding = new System.Windows.Forms.Padding(3);
            this.scheName.PasswordChar = '\0';
            this.scheName.PlaceholderForeColor = System.Drawing.Color.White;
            this.scheName.PlaceholderText = "Enter Schedule Name";
            this.scheName.ReadOnly = false;
            this.scheName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.scheName.SelectedText = "";
            this.scheName.SelectionLength = 0;
            this.scheName.SelectionStart = 0;
            this.scheName.ShortcutsEnabled = true;
            this.scheName.Size = new System.Drawing.Size(295, 44);
            this.scheName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.scheName.TabIndex = 23;
            this.scheName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.scheName.TextMarginBottom = 0;
            this.scheName.TextMarginLeft = 3;
            this.scheName.TextMarginTop = 1;
            this.scheName.TextPlaceholder = "Enter Schedule Name";
            this.scheName.UseSystemPasswordChar = false;
            this.scheName.WordWrap = true;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // prompt
            // 
            this.prompt.AllowDragging = false;
            this.prompt.AllowMultipleViews = true;
            this.prompt.ClickToClose = true;
            this.prompt.DoubleClickToClose = true;
            this.prompt.DurationAfterIdle = 3000;
            this.prompt.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.prompt.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.prompt.ErrorOptions.ActionBorderRadius = 1;
            this.prompt.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.prompt.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.prompt.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.prompt.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.prompt.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.prompt.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.prompt.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.prompt.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.prompt.ErrorOptions.IconLeftMargin = 12;
            this.prompt.FadeCloseIcon = false;
            this.prompt.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.prompt.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.prompt.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.prompt.InformationOptions.ActionBorderRadius = 1;
            this.prompt.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.prompt.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.prompt.InformationOptions.BackColor = System.Drawing.Color.White;
            this.prompt.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.prompt.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.prompt.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.prompt.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.prompt.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.prompt.InformationOptions.IconLeftMargin = 12;
            this.prompt.Margin = 10;
            this.prompt.MaximumSize = new System.Drawing.Size(0, 0);
            this.prompt.MaximumViews = 7;
            this.prompt.MessageRightMargin = 15;
            this.prompt.MinimumSize = new System.Drawing.Size(0, 0);
            this.prompt.ShowBorders = false;
            this.prompt.ShowCloseIcon = false;
            this.prompt.ShowIcon = true;
            this.prompt.ShowShadows = true;
            this.prompt.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.prompt.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.prompt.SuccessOptions.ActionBorderRadius = 1;
            this.prompt.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.prompt.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.prompt.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.prompt.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.prompt.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.prompt.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.prompt.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.prompt.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.prompt.SuccessOptions.IconLeftMargin = 12;
            this.prompt.ViewsMargin = 7;
            this.prompt.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.prompt.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.prompt.WarningOptions.ActionBorderRadius = 1;
            this.prompt.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.prompt.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.prompt.WarningOptions.BackColor = System.Drawing.Color.White;
            this.prompt.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.prompt.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.prompt.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.prompt.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.prompt.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.prompt.WarningOptions.IconLeftMargin = 12;
            this.prompt.ZoomCloseIcon = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Edit_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 381);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.bunifuButton21);
            this.Controls.Add(this.bunifuButton22);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scheName);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit_Schedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit_Schedule";
            this.Shown += new System.EventHandler(this.Edit_Schedule_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker endTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker startTime;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton21;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton22;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuTextBox scheName;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuSnackbar prompt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}