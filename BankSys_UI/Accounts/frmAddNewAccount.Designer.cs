namespace BankSys_UI
{
    partial class frmAddNewAccount
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
            this.tcGeneralInfo = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpMemberInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlMemberDetails1 = new BankSys_UI.ctrlMemberDetails();
            this.ctrlSearchMember1 = new BankSys_UI.ctrlSearchMember();
            this.tpAccountInfo = new System.Windows.Forms.TabPage();
            this.lblWarning = new System.Windows.Forms.Label();
            this.gpSerialNumber = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.panelBalance = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBalance = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.pbEye2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pbEye1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panelAccountID = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcGeneralInfo.SuspendLayout();
            this.tpMemberInfo.SuspendLayout();
            this.tpAccountInfo.SuspendLayout();
            this.gpSerialNumber.SuspendLayout();
            this.panelBalance.SuspendLayout();
            this.panelAccountID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcGeneralInfo
            // 
            this.tcGeneralInfo.Controls.Add(this.tpMemberInfo);
            this.tcGeneralInfo.Controls.Add(this.tpAccountInfo);
            this.tcGeneralInfo.ItemSize = new System.Drawing.Size(180, 30);
            this.tcGeneralInfo.Location = new System.Drawing.Point(12, 85);
            this.tcGeneralInfo.Name = "tcGeneralInfo";
            this.tcGeneralInfo.SelectedIndex = 0;
            this.tcGeneralInfo.Size = new System.Drawing.Size(772, 513);
            this.tcGeneralInfo.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcGeneralInfo.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcGeneralInfo.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcGeneralInfo.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcGeneralInfo.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcGeneralInfo.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcGeneralInfo.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcGeneralInfo.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcGeneralInfo.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcGeneralInfo.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcGeneralInfo.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcGeneralInfo.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcGeneralInfo.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcGeneralInfo.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcGeneralInfo.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcGeneralInfo.TabButtonSize = new System.Drawing.Size(180, 30);
            this.tcGeneralInfo.TabIndex = 1;
            this.tcGeneralInfo.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcGeneralInfo.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpMemberInfo
            // 
            this.tpMemberInfo.Controls.Add(this.btnNext);
            this.tpMemberInfo.Controls.Add(this.ctrlMemberDetails1);
            this.tpMemberInfo.Controls.Add(this.ctrlSearchMember1);
            this.tpMemberInfo.Location = new System.Drawing.Point(4, 34);
            this.tpMemberInfo.Name = "tpMemberInfo";
            this.tpMemberInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpMemberInfo.Size = new System.Drawing.Size(764, 475);
            this.tpMemberInfo.TabIndex = 0;
            this.tpMemberInfo.Text = "Member Info";
            this.tpMemberInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Animated = true;
            this.btnNext.BorderRadius = 20;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.IndianRed;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = global::BankSys_UI.Properties.Resources.next;
            this.btnNext.Location = new System.Drawing.Point(618, 364);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(57, 52);
            this.btnNext.TabIndex = 14;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlMemberDetails1
            // 
            this.ctrlMemberDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlMemberDetails1.Location = new System.Drawing.Point(22, 141);
            this.ctrlMemberDetails1.Name = "ctrlMemberDetails1";
            this.ctrlMemberDetails1.Size = new System.Drawing.Size(614, 227);
            this.ctrlMemberDetails1.TabIndex = 13;
            // 
            // ctrlSearchMember1
            // 
            this.ctrlSearchMember1.BackColor = System.Drawing.Color.White;
            this.ctrlSearchMember1.Location = new System.Drawing.Point(12, 23);
            this.ctrlSearchMember1.Name = "ctrlSearchMember1";
            this.ctrlSearchMember1.Size = new System.Drawing.Size(412, 88);
            this.ctrlSearchMember1.TabIndex = 12;
            this.ctrlSearchMember1.MemberFoundEvent += new BankSys_UI.ctrlSearchMember.MemberFound(this.ctrlSearchMember1_MemberFoundEvent);
            // 
            // tpAccountInfo
            // 
            this.tpAccountInfo.Controls.Add(this.lblWarning);
            this.tpAccountInfo.Controls.Add(this.gpSerialNumber);
            this.tpAccountInfo.Controls.Add(this.panelBalance);
            this.tpAccountInfo.Controls.Add(this.lblDate);
            this.tpAccountInfo.Controls.Add(this.label4);
            this.tpAccountInfo.Controls.Add(this.lblUsername);
            this.tpAccountInfo.Controls.Add(this.label1);
            this.tpAccountInfo.Controls.Add(this.btnBack);
            this.tpAccountInfo.Controls.Add(this.pbEye2);
            this.tpAccountInfo.Controls.Add(this.pbEye1);
            this.tpAccountInfo.Controls.Add(this.panelAccountID);
            this.tpAccountInfo.Controls.Add(this.btnReset);
            this.tpAccountInfo.Controls.Add(this.btnSave);
            this.tpAccountInfo.Controls.Add(this.txtConfirmPassword);
            this.tpAccountInfo.Controls.Add(this.txtPassword);
            this.tpAccountInfo.Location = new System.Drawing.Point(4, 34);
            this.tpAccountInfo.Name = "tpAccountInfo";
            this.tpAccountInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccountInfo.Size = new System.Drawing.Size(764, 475);
            this.tpAccountInfo.TabIndex = 1;
            this.tpAccountInfo.Text = "Account Info";
            this.tpAccountInfo.UseVisualStyleBackColor = true;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Sylfaen", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblWarning.Location = new System.Drawing.Point(492, 382);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(181, 14);
            this.lblWarning.TabIndex = 158;
            this.lblWarning.Text = "(!) Don\'t Share It With Anyone";
            // 
            // gpSerialNumber
            // 
            this.gpSerialNumber.BorderColor = System.Drawing.Color.DarkGray;
            this.gpSerialNumber.Controls.Add(this.lblSerialNumber);
            this.gpSerialNumber.CustomBorderColor = System.Drawing.Color.Firebrick;
            this.gpSerialNumber.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSerialNumber.ForeColor = System.Drawing.Color.Black;
            this.gpSerialNumber.Location = new System.Drawing.Point(489, 240);
            this.gpSerialNumber.Name = "gpSerialNumber";
            this.gpSerialNumber.Size = new System.Drawing.Size(230, 139);
            this.gpSerialNumber.TabIndex = 156;
            this.gpSerialNumber.Text = "Serial Number";
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.Font = new System.Drawing.Font("Sylfaen", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialNumber.Location = new System.Drawing.Point(16, 73);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(196, 48);
            this.lblSerialNumber.TabIndex = 157;
            this.lblSerialNumber.Text = "XXXX-XXXX-XXXX-XXXX";
            // 
            // panelBalance
            // 
            this.panelBalance.BorderColor = System.Drawing.Color.Gray;
            this.panelBalance.BorderThickness = 3;
            this.panelBalance.Controls.Add(this.label6);
            this.panelBalance.Controls.Add(this.txtBalance);
            this.panelBalance.Controls.Add(this.lblBalance);
            this.panelBalance.Location = new System.Drawing.Point(471, 85);
            this.panelBalance.Name = "panelBalance";
            this.panelBalance.Size = new System.Drawing.Size(255, 119);
            this.panelBalance.TabIndex = 155;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sylfaen", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(15, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 14);
            this.label6.TabIndex = 157;
            this.label6.Text = "(!) Balance is in US Dollar";
            // 
            // txtBalance
            // 
            this.txtBalance.BorderRadius = 20;
            this.txtBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBalance.DefaultText = "";
            this.txtBalance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBalance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBalance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBalance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBalance.ForeColor = System.Drawing.Color.Black;
            this.txtBalance.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBalance.Location = new System.Drawing.Point(18, 48);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBalance.PlaceholderText = "";
            this.txtBalance.SelectedText = "";
            this.txtBalance.Size = new System.Drawing.Size(203, 41);
            this.txtBalance.TabIndex = 156;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBalance_KeyPress);
            this.txtBalance.Validating += new System.ComponentModel.CancelEventHandler(this.txtBalance_Validating);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(14, 12);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(120, 22);
            this.lblBalance.TabIndex = 13;
            this.lblBalance.Text = "Initial Balance";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(200, 311);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(24, 22);
            this.lblDate.TabIndex = 154;
            this.lblDate.Text = "??";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 153;
            this.label4.Text = "Date:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(247, 264);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(24, 22);
            this.lblUsername.TabIndex = 152;
            this.lblUsername.Text = "??";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Created By:";
            // 
            // btnBack
            // 
            this.btnBack.Animated = true;
            this.btnBack.BorderRadius = 20;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.IndianRed;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = global::BankSys_UI.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(36, 406);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 48);
            this.btnBack.TabIndex = 151;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pbEye2
            // 
            this.pbEye2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.pbEye2.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.pbEye2.Image = global::BankSys_UI.Properties.Resources.Eye_Closed;
            this.pbEye2.ImageOffset = new System.Drawing.Point(0, 0);
            this.pbEye2.ImageRotate = 0F;
            this.pbEye2.ImageSize = new System.Drawing.Size(25, 25);
            this.pbEye2.Location = new System.Drawing.Point(350, 176);
            this.pbEye2.Name = "pbEye2";
            this.pbEye2.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.pbEye2.Size = new System.Drawing.Size(25, 20);
            this.pbEye2.TabIndex = 150;
            this.pbEye2.Click += new System.EventHandler(this.pbEye2_Click);
            // 
            // pbEye1
            // 
            this.pbEye1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.pbEye1.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.pbEye1.Image = global::BankSys_UI.Properties.Resources.Eye_Closed;
            this.pbEye1.ImageOffset = new System.Drawing.Point(0, 0);
            this.pbEye1.ImageRotate = 0F;
            this.pbEye1.ImageSize = new System.Drawing.Size(25, 25);
            this.pbEye1.Location = new System.Drawing.Point(350, 113);
            this.pbEye1.Name = "pbEye1";
            this.pbEye1.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.pbEye1.Size = new System.Drawing.Size(25, 20);
            this.pbEye1.TabIndex = 149;
            this.pbEye1.Click += new System.EventHandler(this.pbEye1_Click);
            // 
            // panelAccountID
            // 
            this.panelAccountID.Controls.Add(this.label3);
            this.panelAccountID.Controls.Add(this.lblAccountID);
            this.panelAccountID.Location = new System.Drawing.Point(26, 24);
            this.panelAccountID.Name = "panelAccountID";
            this.panelAccountID.Size = new System.Drawing.Size(187, 43);
            this.panelAccountID.TabIndex = 148;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Account ID:";
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAccountID.Location = new System.Drawing.Point(109, 11);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(24, 22);
            this.lblAccountID.TabIndex = 12;
            this.lblAccountID.Text = "??";
            // 
            // btnReset
            // 
            this.btnReset.BorderRadius = 20;
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.FillColor = System.Drawing.Color.Gray;
            this.btnReset.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(284, 419);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(122, 44);
            this.btnReset.TabIndex = 145;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 20;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.DarkGreen;
            this.btnSave.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(284, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 44);
            this.btnSave.TabIndex = 144;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderRadius = 20;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(102, 169);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtConfirmPassword.PlaceholderText = "Confirm Password";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(242, 36);
            this.txtConfirmPassword.TabIndex = 137;
            this.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 20;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(102, 106);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(242, 36);
            this.txtPassword.TabIndex = 136;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // frmAddNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 601);
            this.Controls.Add(this.tcGeneralInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddNewAccount";
            this.Text = "frrmAddNewAccount";
            this.Load += new System.EventHandler(this.frrmAddNewAccount_Load);
            this.tcGeneralInfo.ResumeLayout(false);
            this.tpMemberInfo.ResumeLayout(false);
            this.tpAccountInfo.ResumeLayout(false);
            this.tpAccountInfo.PerformLayout();
            this.gpSerialNumber.ResumeLayout(false);
            this.panelBalance.ResumeLayout(false);
            this.panelBalance.PerformLayout();
            this.panelAccountID.ResumeLayout(false);
            this.panelAccountID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tcGeneralInfo;
        private System.Windows.Forms.TabPage tpMemberInfo;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private ctrlMemberDetails ctrlMemberDetails1;
        private ctrlSearchMember ctrlSearchMember1;
        private System.Windows.Forms.TabPage tpAccountInfo;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2ImageButton pbEye2;
        private Guna.UI2.WinForms.Guna2ImageButton pbEye1;
        private Guna.UI2.WinForms.Guna2Panel panelAccountID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAccountID;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Panel panelBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtBalance;
        private System.Windows.Forms.Label lblWarning;
        private Guna.UI2.WinForms.Guna2GroupBox gpSerialNumber;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}