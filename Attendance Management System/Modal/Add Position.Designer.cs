
namespace Attendance_Management_System.Modal
{
    partial class Add_Position
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Position));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sched_combo = new Bunifu.UI.WinForms.BunifuDropdown();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.prompt = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuButton21 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuButton22 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.posiName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Schedule";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Position Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(119, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Add Position";
            // 
            // sched_combo
            // 
            this.sched_combo.BackColor = System.Drawing.Color.Transparent;
            this.sched_combo.BackgroundColor = System.Drawing.Color.DarkGray;
            this.sched_combo.BorderColor = System.Drawing.Color.DarkGray;
            this.sched_combo.BorderRadius = 10;
            this.sched_combo.Color = System.Drawing.Color.DarkGray;
            this.sched_combo.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.sched_combo.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.sched_combo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.sched_combo.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.sched_combo.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sched_combo.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.sched_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sched_combo.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.sched_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sched_combo.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.sched_combo.FillDropDown = true;
            this.sched_combo.FillIndicator = false;
            this.sched_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sched_combo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sched_combo.ForeColor = System.Drawing.Color.Black;
            this.sched_combo.FormattingEnabled = true;
            this.sched_combo.Icon = null;
            this.sched_combo.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.sched_combo.IndicatorColor = System.Drawing.Color.DimGray;
            this.sched_combo.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.sched_combo.IndicatorThickness = 2;
            this.sched_combo.IsDropdownOpened = false;
            this.sched_combo.ItemBackColor = System.Drawing.Color.White;
            this.sched_combo.ItemBorderColor = System.Drawing.Color.White;
            this.sched_combo.ItemForeColor = System.Drawing.Color.Black;
            this.sched_combo.ItemHeight = 35;
            this.sched_combo.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(164)))), ((int)(((byte)(227)))));
            this.sched_combo.ItemHighLightForeColor = System.Drawing.Color.White;
            this.sched_combo.ItemTopMargin = 3;
            this.sched_combo.Location = new System.Drawing.Point(23, 230);
            this.sched_combo.Name = "sched_combo";
            this.sched_combo.Size = new System.Drawing.Size(295, 41);
            this.sched_combo.TabIndex = 28;
            this.sched_combo.Text = null;
            this.sched_combo.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.sched_combo.TextLeftMargin = 5;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(326, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 39);
            this.button1.TabIndex = 29;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
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
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
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
            this.bunifuButton21.ButtonText = "Cancel";
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
            this.bunifuButton21.Location = new System.Drawing.Point(207, 317);
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
            this.bunifuButton21.Size = new System.Drawing.Size(103, 39);
            this.bunifuButton21.TabIndex = 25;
            this.bunifuButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton21.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton21.TextMarginLeft = 0;
            this.bunifuButton21.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton21.UseDefaultRadiusAndThickness = true;
            this.bunifuButton21.Click += new System.EventHandler(this.button1_Click);
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
            this.bunifuButton22.Location = new System.Drawing.Point(58, 317);
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
            this.bunifuButton22.TabIndex = 24;
            this.bunifuButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton22.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton22.TextMarginLeft = 0;
            this.bunifuButton22.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton22.UseDefaultRadiusAndThickness = true;
            this.bunifuButton22.Click += new System.EventHandler(this.bunifuButton22_Click);
            // 
            // posiName
            // 
            this.posiName.AcceptsReturn = false;
            this.posiName.AcceptsTab = false;
            this.posiName.AnimationSpeed = 200;
            this.posiName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.posiName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.posiName.AutoSizeHeight = true;
            this.posiName.BackColor = System.Drawing.Color.Transparent;
            this.posiName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("posiName.BackgroundImage")));
            this.posiName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(93)))), ((int)(((byte)(98)))));
            this.posiName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.posiName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(93)))), ((int)(((byte)(98)))));
            this.posiName.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.posiName.BorderRadius = 15;
            this.posiName.BorderThickness = 1;
            this.posiName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.posiName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.posiName.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posiName.DefaultText = "";
            this.posiName.FillColor = System.Drawing.Color.DarkGray;
            this.posiName.ForeColor = System.Drawing.Color.White;
            this.posiName.HideSelection = true;
            this.posiName.IconLeft = null;
            this.posiName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.posiName.IconPadding = 10;
            this.posiName.IconRight = null;
            this.posiName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.posiName.Lines = new string[0];
            this.posiName.Location = new System.Drawing.Point(23, 125);
            this.posiName.MaxLength = 32767;
            this.posiName.MinimumSize = new System.Drawing.Size(1, 1);
            this.posiName.Modified = false;
            this.posiName.Multiline = false;
            this.posiName.Name = "posiName";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(93)))), ((int)(((byte)(98)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.posiName.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.posiName.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(93)))), ((int)(((byte)(98)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.posiName.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties4.FillColor = System.Drawing.Color.DarkGray;
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.posiName.OnIdleState = stateProperties4;
            this.posiName.Padding = new System.Windows.Forms.Padding(3);
            this.posiName.PasswordChar = '\0';
            this.posiName.PlaceholderForeColor = System.Drawing.Color.White;
            this.posiName.PlaceholderText = "Enter Position Name";
            this.posiName.ReadOnly = false;
            this.posiName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.posiName.SelectedText = "";
            this.posiName.SelectionLength = 0;
            this.posiName.SelectionStart = 0;
            this.posiName.ShortcutsEnabled = true;
            this.posiName.Size = new System.Drawing.Size(295, 44);
            this.posiName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.posiName.TabIndex = 22;
            this.posiName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.posiName.TextMarginBottom = 0;
            this.posiName.TextMarginLeft = 3;
            this.posiName.TextMarginTop = 1;
            this.posiName.TextPlaceholder = "Enter Position Name";
            this.posiName.UseSystemPasswordChar = false;
            this.posiName.WordWrap = true;
            // 
            // Add_Position
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 397);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sched_combo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuButton21);
            this.Controls.Add(this.bunifuButton22);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.posiName);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Position";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add_Position";
            this.Shown += new System.EventHandler(this.Add_Position_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton21;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton22;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuTextBox posiName;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuDropdown sched_combo;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.UI.WinForms.BunifuSnackbar prompt;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}