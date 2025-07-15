namespace BankSys_UI
{
    partial class frmDeposit
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
            this.lblDate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeposit = new Guna.UI2.WinForms.Guna2Button();
            this.panelDeposit = new Guna.UI2.WinForms.Guna2Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDepositAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gpAccountDetails = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSerialNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbEye = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelDeposit.SuspendLayout();
            this.gpAccountDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(515, 164);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(24, 22);
            this.lblDate.TabIndex = 163;
            this.lblDate.Text = "??";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(459, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 22);
            this.label10.TabIndex = 162;
            this.label10.Text = "Date:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(562, 117);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(24, 22);
            this.lblUsername.TabIndex = 161;
            this.lblUsername.Text = "??";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(459, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 22);
            this.label11.TabIndex = 160;
            this.label11.Text = "Created By:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(19, 526);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(415, 18);
            this.label9.TabIndex = 168;
            this.label9.Text = "(!) The maximum amount to deposit: $5000 per one operation";
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.Transparent;
            this.btnDeposit.BorderRadius = 20;
            this.btnDeposit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeposit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeposit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeposit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeposit.FillColor = System.Drawing.Color.DarkGreen;
            this.btnDeposit.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.Location = new System.Drawing.Point(519, 367);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(136, 48);
            this.btnDeposit.TabIndex = 167;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // panelDeposit
            // 
            this.panelDeposit.BorderColor = System.Drawing.Color.Gray;
            this.panelDeposit.BorderThickness = 3;
            this.panelDeposit.Controls.Add(this.label7);
            this.panelDeposit.Controls.Add(this.txtDepositAmount);
            this.panelDeposit.Controls.Add(this.label8);
            this.panelDeposit.Location = new System.Drawing.Point(454, 226);
            this.panelDeposit.Name = "panelDeposit";
            this.panelDeposit.Size = new System.Drawing.Size(255, 119);
            this.panelDeposit.TabIndex = 166;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sylfaen", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(15, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 14);
            this.label7.TabIndex = 157;
            this.label7.Text = "(!) Amount is in US Dollar";
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.BorderColor = System.Drawing.Color.Gray;
            this.txtDepositAmount.BorderRadius = 20;
            this.txtDepositAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDepositAmount.DefaultText = "";
            this.txtDepositAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDepositAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDepositAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDepositAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDepositAmount.Enabled = false;
            this.txtDepositAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDepositAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDepositAmount.ForeColor = System.Drawing.Color.Black;
            this.txtDepositAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDepositAmount.Location = new System.Drawing.Point(18, 48);
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtDepositAmount.PlaceholderText = "";
            this.txtDepositAmount.SelectedText = "";
            this.txtDepositAmount.Size = new System.Drawing.Size(203, 41);
            this.txtDepositAmount.TabIndex = 156;
            this.txtDepositAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDepositAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepositAmount_KeyPress);
            this.txtDepositAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtDepositAmount_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 22);
            this.label8.TabIndex = 13;
            this.label8.Text = "Deposit Amount";
            // 
            // gpAccountDetails
            // 
            this.gpAccountDetails.BorderColor = System.Drawing.Color.Black;
            this.gpAccountDetails.Controls.Add(this.lblCreatedDate);
            this.gpAccountDetails.Controls.Add(this.lblBalance);
            this.gpAccountDetails.Controls.Add(this.lblFullName);
            this.gpAccountDetails.Controls.Add(this.lblAccountID);
            this.gpAccountDetails.Controls.Add(this.label4);
            this.gpAccountDetails.Controls.Add(this.label2);
            this.gpAccountDetails.Controls.Add(this.label1);
            this.gpAccountDetails.Controls.Add(this.label3);
            this.gpAccountDetails.CustomBorderColor = System.Drawing.Color.OliveDrab;
            this.gpAccountDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gpAccountDetails.ForeColor = System.Drawing.Color.White;
            this.gpAccountDetails.Location = new System.Drawing.Point(90, 308);
            this.gpAccountDetails.Name = "gpAccountDetails";
            this.gpAccountDetails.Size = new System.Drawing.Size(265, 198);
            this.gpAccountDetails.TabIndex = 165;
            this.gpAccountDetails.Text = "Account Details";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedDate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCreatedDate.Location = new System.Drawing.Point(108, 164);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(23, 19);
            this.lblCreatedDate.TabIndex = 53;
            this.lblCreatedDate.Text = "??";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.Green;
            this.lblBalance.Location = new System.Drawing.Point(67, 126);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(23, 19);
            this.lblBalance.TabIndex = 52;
            this.lblBalance.Text = "??";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblFullName.Location = new System.Drawing.Point(82, 88);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(23, 19);
            this.lblFullName.TabIndex = 51;
            this.lblFullName.Text = "??";
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAccountID.Location = new System.Drawing.Point(95, 50);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(23, 19);
            this.lblAccountID.TabIndex = 50;
            this.lblAccountID.Text = "??";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 49;
            this.label4.Text = "Full Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 48;
            this.label2.Text = "Created Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 47;
            this.label1.Text = "Balance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 46;
            this.label3.Text = "Account ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbEye);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSerialNumber);
            this.groupBox1.Location = new System.Drawing.Point(40, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 269);
            this.groupBox1.TabIndex = 171;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Info";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(14, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 22);
            this.label12.TabIndex = 176;
            this.label12.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Animated = true;
            this.txtPassword.BorderColor = System.Drawing.Color.DarkGray;
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
            this.txtPassword.Location = new System.Drawing.Point(73, 153);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(208, 42);
            this.txtPassword.TabIndex = 175;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(56, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 16);
            this.label6.TabIndex = 173;
            this.label6.Text = "(!) Don\'t forget \"-\" between each 4 digits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 22);
            this.label5.TabIndex = 172;
            this.label5.Text = "Serial Number";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Animated = true;
            this.txtSerialNumber.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSerialNumber.BorderRadius = 20;
            this.txtSerialNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSerialNumber.DefaultText = "";
            this.txtSerialNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSerialNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSerialNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSerialNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSerialNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSerialNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSerialNumber.ForeColor = System.Drawing.Color.Black;
            this.txtSerialNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSerialNumber.Location = new System.Drawing.Point(73, 48);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.PlaceholderText = "";
            this.txtSerialNumber.SelectedText = "";
            this.txtSerialNumber.Size = new System.Drawing.Size(208, 42);
            this.txtSerialNumber.TabIndex = 171;
            this.txtSerialNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSerialNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerialNumber_KeyPress);
            this.txtSerialNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtSerialNumber_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pbEye
            // 
            this.pbEye.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.pbEye.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.pbEye.Image = global::BankSys_UI.Properties.Resources.Eye_Closed;
            this.pbEye.ImageOffset = new System.Drawing.Point(0, 0);
            this.pbEye.ImageRotate = 0F;
            this.pbEye.ImageSize = new System.Drawing.Size(25, 25);
            this.pbEye.Location = new System.Drawing.Point(38, 164);
            this.pbEye.Name = "pbEye";
            this.pbEye.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.pbEye.Size = new System.Drawing.Size(25, 20);
            this.pbEye.TabIndex = 177;
            this.pbEye.Click += new System.EventHandler(this.pbEye_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Animated = true;
            this.btnSearch.BorderRadius = 20;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::BankSys_UI.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(137, 210);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 45);
            this.btnSearch.TabIndex = 174;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::BankSys_UI.Properties.Resources.d1;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(328, 410);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(441, 200);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 159;
            this.guna2PictureBox1.TabStop = false;
            // 
            // frmDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 601);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.panelDeposit);
            this.Controls.Add(this.gpAccountDetails);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDeposit";
            this.Text = "frmDeposit";
            this.Load += new System.EventHandler(this.frmDeposit_Load);
            this.panelDeposit.ResumeLayout(false);
            this.panelDeposit.PerformLayout();
            this.gpAccountDetails.ResumeLayout(false);
            this.gpAccountDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btnDeposit;
        private Guna.UI2.WinForms.Guna2Panel panelDeposit;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtDepositAmount;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2GroupBox gpAccountDetails;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtSerialNumber;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2ImageButton pbEye;
    }
}