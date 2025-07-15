namespace BankSys_UI
{
    partial class frmTransfer
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
            this.tcTransfer = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpSourceAccount = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbEye1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label12 = new System.Windows.Forms.Label();
            this.txtsPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnsSearch = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsSerialNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.gpAccountDetails = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblsCreatedDate = new System.Windows.Forms.Label();
            this.lblsBalance = new System.Windows.Forms.Label();
            this.lblsFullName = new System.Windows.Forms.Label();
            this.lblsAccountID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tpDestinationAccount = new System.Windows.Forms.TabPage();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbEye2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btndSearch = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdSerialNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTransfer = new Guna.UI2.WinForms.Guna2Button();
            this.panelDeposit = new Guna.UI2.WinForms.Guna2Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTransferAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lbldCreatedDate = new System.Windows.Forms.Label();
            this.lbldBalance = new System.Windows.Forms.Label();
            this.lbldFullName = new System.Windows.Forms.Label();
            this.lbldAccountID = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcTransfer.SuspendLayout();
            this.tpSourceAccount.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpAccountDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.tpDestinationAccount.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelDeposit.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcTransfer
            // 
            this.tcTransfer.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcTransfer.Controls.Add(this.tpSourceAccount);
            this.tcTransfer.Controls.Add(this.tpDestinationAccount);
            this.tcTransfer.Font = new System.Drawing.Font("Tahoma", 8F);
            this.tcTransfer.ItemSize = new System.Drawing.Size(120, 70);
            this.tcTransfer.Location = new System.Drawing.Point(4, 79);
            this.tcTransfer.Name = "tcTransfer";
            this.tcTransfer.SelectedIndex = 0;
            this.tcTransfer.Size = new System.Drawing.Size(790, 518);
            this.tcTransfer.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcTransfer.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcTransfer.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcTransfer.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcTransfer.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcTransfer.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcTransfer.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcTransfer.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcTransfer.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcTransfer.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcTransfer.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcTransfer.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcTransfer.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcTransfer.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcTransfer.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcTransfer.TabButtonSize = new System.Drawing.Size(120, 70);
            this.tcTransfer.TabIndex = 0;
            this.tcTransfer.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tpSourceAccount
            // 
            this.tpSourceAccount.BackColor = System.Drawing.Color.White;
            this.tpSourceAccount.Controls.Add(this.btnNext);
            this.tpSourceAccount.Controls.Add(this.groupBox1);
            this.tpSourceAccount.Controls.Add(this.gpAccountDetails);
            this.tpSourceAccount.Controls.Add(this.guna2PictureBox1);
            this.tpSourceAccount.Font = new System.Drawing.Font("Tahoma", 8F);
            this.tpSourceAccount.Location = new System.Drawing.Point(124, 4);
            this.tpSourceAccount.Name = "tpSourceAccount";
            this.tpSourceAccount.Padding = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.tpSourceAccount.Size = new System.Drawing.Size(662, 510);
            this.tpSourceAccount.TabIndex = 0;
            this.tpSourceAccount.Text = "Source         Account";
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
            this.btnNext.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNext.Location = new System.Drawing.Point(535, 401);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(65, 55);
            this.btnNext.TabIndex = 202;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbEye1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtsPassword);
            this.groupBox1.Controls.Add(this.btnsSearch);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtsSerialNumber);
            this.groupBox1.Location = new System.Drawing.Point(15, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 269);
            this.groupBox1.TabIndex = 201;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Info";
            // 
            // pbEye1
            // 
            this.pbEye1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.pbEye1.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.pbEye1.Image = global::BankSys_UI.Properties.Resources.Eye_Closed;
            this.pbEye1.ImageOffset = new System.Drawing.Point(0, 0);
            this.pbEye1.ImageRotate = 0F;
            this.pbEye1.ImageSize = new System.Drawing.Size(25, 25);
            this.pbEye1.Location = new System.Drawing.Point(38, 164);
            this.pbEye1.Name = "pbEye1";
            this.pbEye1.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.pbEye1.Size = new System.Drawing.Size(25, 20);
            this.pbEye1.TabIndex = 177;
            this.pbEye1.Click += new System.EventHandler(this.pbEye1_Click);
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
            // txtsPassword
            // 
            this.txtsPassword.Animated = true;
            this.txtsPassword.BorderColor = System.Drawing.Color.DarkGray;
            this.txtsPassword.BorderRadius = 20;
            this.txtsPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsPassword.DefaultText = "";
            this.txtsPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsPassword.ForeColor = System.Drawing.Color.Black;
            this.txtsPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsPassword.Location = new System.Drawing.Point(73, 153);
            this.txtsPassword.Name = "txtsPassword";
            this.txtsPassword.PlaceholderText = "";
            this.txtsPassword.SelectedText = "";
            this.txtsPassword.Size = new System.Drawing.Size(208, 42);
            this.txtsPassword.TabIndex = 175;
            this.txtsPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsPassword.UseSystemPasswordChar = true;
            this.txtsPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtsPassword_Validating);
            // 
            // btnsSearch
            // 
            this.btnsSearch.Animated = true;
            this.btnsSearch.BorderRadius = 20;
            this.btnsSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsSearch.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnsSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsSearch.ForeColor = System.Drawing.Color.White;
            this.btnsSearch.Image = global::BankSys_UI.Properties.Resources.search;
            this.btnsSearch.Location = new System.Drawing.Point(137, 210);
            this.btnsSearch.Name = "btnsSearch";
            this.btnsSearch.Size = new System.Drawing.Size(75, 45);
            this.btnsSearch.TabIndex = 174;
            this.btnsSearch.Click += new System.EventHandler(this.btnsSearch_Click);
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
            // txtsSerialNumber
            // 
            this.txtsSerialNumber.Animated = true;
            this.txtsSerialNumber.BorderColor = System.Drawing.Color.DarkGray;
            this.txtsSerialNumber.BorderRadius = 20;
            this.txtsSerialNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsSerialNumber.DefaultText = "";
            this.txtsSerialNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsSerialNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsSerialNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsSerialNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsSerialNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsSerialNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsSerialNumber.ForeColor = System.Drawing.Color.Black;
            this.txtsSerialNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsSerialNumber.Location = new System.Drawing.Point(73, 48);
            this.txtsSerialNumber.Name = "txtsSerialNumber";
            this.txtsSerialNumber.PlaceholderText = "";
            this.txtsSerialNumber.SelectedText = "";
            this.txtsSerialNumber.Size = new System.Drawing.Size(208, 42);
            this.txtsSerialNumber.TabIndex = 171;
            this.txtsSerialNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsSerialNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsSerialNumber_KeyPress);
            this.txtsSerialNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtsSerialNumber_Validating);
            // 
            // gpAccountDetails
            // 
            this.gpAccountDetails.BorderColor = System.Drawing.Color.Black;
            this.gpAccountDetails.Controls.Add(this.lblsCreatedDate);
            this.gpAccountDetails.Controls.Add(this.lblsBalance);
            this.gpAccountDetails.Controls.Add(this.lblsFullName);
            this.gpAccountDetails.Controls.Add(this.lblsAccountID);
            this.gpAccountDetails.Controls.Add(this.label4);
            this.gpAccountDetails.Controls.Add(this.label2);
            this.gpAccountDetails.Controls.Add(this.label1);
            this.gpAccountDetails.Controls.Add(this.label3);
            this.gpAccountDetails.CustomBorderColor = System.Drawing.Color.OliveDrab;
            this.gpAccountDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gpAccountDetails.ForeColor = System.Drawing.Color.White;
            this.gpAccountDetails.Location = new System.Drawing.Point(379, 70);
            this.gpAccountDetails.Name = "gpAccountDetails";
            this.gpAccountDetails.Size = new System.Drawing.Size(265, 198);
            this.gpAccountDetails.TabIndex = 197;
            this.gpAccountDetails.Text = "Account Details";
            // 
            // lblsCreatedDate
            // 
            this.lblsCreatedDate.AutoSize = true;
            this.lblsCreatedDate.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsCreatedDate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblsCreatedDate.Location = new System.Drawing.Point(108, 164);
            this.lblsCreatedDate.Name = "lblsCreatedDate";
            this.lblsCreatedDate.Size = new System.Drawing.Size(23, 19);
            this.lblsCreatedDate.TabIndex = 53;
            this.lblsCreatedDate.Text = "??";
            // 
            // lblsBalance
            // 
            this.lblsBalance.AutoSize = true;
            this.lblsBalance.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsBalance.ForeColor = System.Drawing.Color.Green;
            this.lblsBalance.Location = new System.Drawing.Point(67, 126);
            this.lblsBalance.Name = "lblsBalance";
            this.lblsBalance.Size = new System.Drawing.Size(23, 19);
            this.lblsBalance.TabIndex = 52;
            this.lblsBalance.Text = "??";
            // 
            // lblsFullName
            // 
            this.lblsFullName.AutoSize = true;
            this.lblsFullName.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsFullName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblsFullName.Location = new System.Drawing.Point(82, 88);
            this.lblsFullName.Name = "lblsFullName";
            this.lblsFullName.Size = new System.Drawing.Size(23, 19);
            this.lblsFullName.TabIndex = 51;
            this.lblsFullName.Text = "??";
            // 
            // lblsAccountID
            // 
            this.lblsAccountID.AutoSize = true;
            this.lblsAccountID.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsAccountID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblsAccountID.Location = new System.Drawing.Point(95, 50);
            this.lblsAccountID.Name = "lblsAccountID";
            this.lblsAccountID.Size = new System.Drawing.Size(23, 19);
            this.lblsAccountID.TabIndex = 50;
            this.lblsAccountID.Text = "??";
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
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::BankSys_UI.Properties.Resources.t1;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(72, 292);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(425, 233);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 192;
            this.guna2PictureBox1.TabStop = false;
            // 
            // tpDestinationAccount
            // 
            this.tpDestinationAccount.Controls.Add(this.btnBack);
            this.tpDestinationAccount.Controls.Add(this.groupBox2);
            this.tpDestinationAccount.Controls.Add(this.label10);
            this.tpDestinationAccount.Controls.Add(this.btnTransfer);
            this.tpDestinationAccount.Controls.Add(this.panelDeposit);
            this.tpDestinationAccount.Controls.Add(this.guna2GroupBox1);
            this.tpDestinationAccount.Controls.Add(this.lblDate);
            this.tpDestinationAccount.Controls.Add(this.label22);
            this.tpDestinationAccount.Controls.Add(this.lblUsername);
            this.tpDestinationAccount.Controls.Add(this.label23);
            this.tpDestinationAccount.Location = new System.Drawing.Point(124, 4);
            this.tpDestinationAccount.Name = "tpDestinationAccount";
            this.tpDestinationAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpDestinationAccount.Size = new System.Drawing.Size(662, 510);
            this.tpDestinationAccount.TabIndex = 1;
            this.tpDestinationAccount.Text = "Destination Account";
            this.tpDestinationAccount.UseVisualStyleBackColor = true;
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
            this.btnBack.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBack.Location = new System.Drawing.Point(15, 443);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 55);
            this.btnBack.TabIndex = 206;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbEye2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtdPassword);
            this.groupBox2.Controls.Add(this.btndSearch);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtdSerialNumber);
            this.groupBox2.Location = new System.Drawing.Point(15, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 269);
            this.groupBox2.TabIndex = 191;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Info";
            // 
            // pbEye2
            // 
            this.pbEye2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.pbEye2.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.pbEye2.Image = global::BankSys_UI.Properties.Resources.Eye_Closed;
            this.pbEye2.ImageOffset = new System.Drawing.Point(0, 0);
            this.pbEye2.ImageRotate = 0F;
            this.pbEye2.ImageSize = new System.Drawing.Size(25, 25);
            this.pbEye2.Location = new System.Drawing.Point(38, 164);
            this.pbEye2.Name = "pbEye2";
            this.pbEye2.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.pbEye2.Size = new System.Drawing.Size(25, 20);
            this.pbEye2.TabIndex = 177;
            this.pbEye2.Click += new System.EventHandler(this.pbEye2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(14, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 22);
            this.label7.TabIndex = 176;
            this.label7.Text = "Password";
            // 
            // txtdPassword
            // 
            this.txtdPassword.Animated = true;
            this.txtdPassword.BorderColor = System.Drawing.Color.DarkGray;
            this.txtdPassword.BorderRadius = 20;
            this.txtdPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdPassword.DefaultText = "";
            this.txtdPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdPassword.ForeColor = System.Drawing.Color.Black;
            this.txtdPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdPassword.Location = new System.Drawing.Point(73, 153);
            this.txtdPassword.Name = "txtdPassword";
            this.txtdPassword.PlaceholderText = "";
            this.txtdPassword.SelectedText = "";
            this.txtdPassword.Size = new System.Drawing.Size(208, 42);
            this.txtdPassword.TabIndex = 175;
            this.txtdPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdPassword.UseSystemPasswordChar = true;
            this.txtdPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtdPassword_Validating);
            // 
            // btndSearch
            // 
            this.btndSearch.Animated = true;
            this.btndSearch.BorderRadius = 20;
            this.btndSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndSearch.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btndSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btndSearch.ForeColor = System.Drawing.Color.White;
            this.btndSearch.Image = global::BankSys_UI.Properties.Resources.search;
            this.btndSearch.Location = new System.Drawing.Point(137, 210);
            this.btndSearch.Name = "btndSearch";
            this.btndSearch.Size = new System.Drawing.Size(75, 45);
            this.btndSearch.TabIndex = 174;
            this.btndSearch.Click += new System.EventHandler(this.btndSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(56, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 16);
            this.label8.TabIndex = 173;
            this.label8.Text = "(!) Don\'t forget \"-\" between each 4 digits";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(14, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 22);
            this.label9.TabIndex = 172;
            this.label9.Text = "Serial Number";
            // 
            // txtdSerialNumber
            // 
            this.txtdSerialNumber.Animated = true;
            this.txtdSerialNumber.BorderColor = System.Drawing.Color.DarkGray;
            this.txtdSerialNumber.BorderRadius = 20;
            this.txtdSerialNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdSerialNumber.DefaultText = "";
            this.txtdSerialNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdSerialNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdSerialNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdSerialNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdSerialNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdSerialNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdSerialNumber.ForeColor = System.Drawing.Color.Black;
            this.txtdSerialNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdSerialNumber.Location = new System.Drawing.Point(73, 48);
            this.txtdSerialNumber.Name = "txtdSerialNumber";
            this.txtdSerialNumber.PlaceholderText = "";
            this.txtdSerialNumber.SelectedText = "";
            this.txtdSerialNumber.Size = new System.Drawing.Size(208, 42);
            this.txtdSerialNumber.TabIndex = 171;
            this.txtdSerialNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdSerialNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdSerialNumber_KeyPress);
            this.txtdSerialNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtdSerialNumber_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(149, 480);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(424, 18);
            this.label10.TabIndex = 190;
            this.label10.Text = "(!) The maximum amount to Transfer: $5000 per one operation";
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.Transparent;
            this.btnTransfer.BorderRadius = 20;
            this.btnTransfer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTransfer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTransfer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTransfer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTransfer.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.btnTransfer.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(450, 411);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(136, 48);
            this.btnTransfer.TabIndex = 189;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // panelDeposit
            // 
            this.panelDeposit.BorderColor = System.Drawing.Color.Gray;
            this.panelDeposit.BorderThickness = 3;
            this.panelDeposit.Controls.Add(this.label11);
            this.panelDeposit.Controls.Add(this.txtTransferAmount);
            this.panelDeposit.Controls.Add(this.label13);
            this.panelDeposit.Location = new System.Drawing.Point(107, 322);
            this.panelDeposit.Name = "panelDeposit";
            this.panelDeposit.Size = new System.Drawing.Size(250, 119);
            this.panelDeposit.TabIndex = 188;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sylfaen", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(15, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 14);
            this.label11.TabIndex = 157;
            this.label11.Text = "(!) Amount is in US Dollar";
            // 
            // txtTransferAmount
            // 
            this.txtTransferAmount.BorderColor = System.Drawing.Color.Gray;
            this.txtTransferAmount.BorderRadius = 20;
            this.txtTransferAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTransferAmount.DefaultText = "";
            this.txtTransferAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTransferAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTransferAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTransferAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTransferAmount.Enabled = false;
            this.txtTransferAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTransferAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTransferAmount.ForeColor = System.Drawing.Color.Black;
            this.txtTransferAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTransferAmount.Location = new System.Drawing.Point(18, 48);
            this.txtTransferAmount.Name = "txtTransferAmount";
            this.txtTransferAmount.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTransferAmount.PlaceholderText = "";
            this.txtTransferAmount.SelectedText = "";
            this.txtTransferAmount.Size = new System.Drawing.Size(203, 41);
            this.txtTransferAmount.TabIndex = 156;
            this.txtTransferAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTransferAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTransferAmount_KeyPress);
            this.txtTransferAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtTransferAmount_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 22);
            this.label13.TabIndex = 13;
            this.label13.Text = "Transfer Amount";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Controls.Add(this.lbldCreatedDate);
            this.guna2GroupBox1.Controls.Add(this.lbldBalance);
            this.guna2GroupBox1.Controls.Add(this.lbldFullName);
            this.guna2GroupBox1.Controls.Add(this.lbldAccountID);
            this.guna2GroupBox1.Controls.Add(this.label18);
            this.guna2GroupBox1.Controls.Add(this.label19);
            this.guna2GroupBox1.Controls.Add(this.label20);
            this.guna2GroupBox1.Controls.Add(this.label21);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.OliveDrab;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(379, 70);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(265, 191);
            this.guna2GroupBox1.TabIndex = 187;
            this.guna2GroupBox1.Text = "Account Details";
            // 
            // lbldCreatedDate
            // 
            this.lbldCreatedDate.AutoSize = true;
            this.lbldCreatedDate.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldCreatedDate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbldCreatedDate.Location = new System.Drawing.Point(108, 164);
            this.lbldCreatedDate.Name = "lbldCreatedDate";
            this.lbldCreatedDate.Size = new System.Drawing.Size(23, 19);
            this.lbldCreatedDate.TabIndex = 53;
            this.lbldCreatedDate.Text = "??";
            // 
            // lbldBalance
            // 
            this.lbldBalance.AutoSize = true;
            this.lbldBalance.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldBalance.ForeColor = System.Drawing.Color.Green;
            this.lbldBalance.Location = new System.Drawing.Point(67, 126);
            this.lbldBalance.Name = "lbldBalance";
            this.lbldBalance.Size = new System.Drawing.Size(23, 19);
            this.lbldBalance.TabIndex = 52;
            this.lbldBalance.Text = "??";
            // 
            // lbldFullName
            // 
            this.lbldFullName.AutoSize = true;
            this.lbldFullName.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldFullName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbldFullName.Location = new System.Drawing.Point(82, 88);
            this.lbldFullName.Name = "lbldFullName";
            this.lbldFullName.Size = new System.Drawing.Size(23, 19);
            this.lbldFullName.TabIndex = 51;
            this.lbldFullName.Text = "??";
            // 
            // lbldAccountID
            // 
            this.lbldAccountID.AutoSize = true;
            this.lbldAccountID.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldAccountID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbldAccountID.Location = new System.Drawing.Point(95, 50);
            this.lbldAccountID.Name = "lbldAccountID";
            this.lbldAccountID.Size = new System.Drawing.Size(23, 19);
            this.lbldAccountID.TabIndex = 50;
            this.lbldAccountID.Text = "??";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(3, 88);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 19);
            this.label18.TabIndex = 49;
            this.label18.Text = "Full Name:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(3, 164);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 19);
            this.label19.TabIndex = 48;
            this.label19.Text = "Created Date:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(3, 126);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 19);
            this.label20.TabIndex = 47;
            this.label20.Text = "Balance:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(3, 50);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 19);
            this.label21.TabIndex = 46;
            this.label21.Text = "Account ID:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(499, 345);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(24, 22);
            this.lblDate.TabIndex = 186;
            this.lblDate.Text = "??";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(443, 345);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 22);
            this.label22.TabIndex = 185;
            this.label22.Text = "Date:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(546, 298);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(24, 22);
            this.lblUsername.TabIndex = 184;
            this.lblUsername.Text = "??";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(443, 298);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(97, 22);
            this.label23.TabIndex = 183;
            this.label23.Text = "Created By:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 601);
            this.Controls.Add(this.tcTransfer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransfer";
            this.Text = "frmTransfer";
            this.Load += new System.EventHandler(this.frmTransfer_Load);
            this.tcTransfer.ResumeLayout(false);
            this.tpSourceAccount.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpAccountDetails.ResumeLayout(false);
            this.gpAccountDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.tpDestinationAccount.ResumeLayout(false);
            this.tpDestinationAccount.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelDeposit.ResumeLayout(false);
            this.panelDeposit.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tcTransfer;
        private System.Windows.Forms.TabPage tpSourceAccount;
        private System.Windows.Forms.TabPage tpDestinationAccount;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2ImageButton pbEye1;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtsPassword;
        private Guna.UI2.WinForms.Guna2Button btnsSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtsSerialNumber;
        private Guna.UI2.WinForms.Guna2GroupBox gpAccountDetails;
        private System.Windows.Forms.Label lblsCreatedDate;
        private System.Windows.Forms.Label lblsBalance;
        private System.Windows.Forms.Label lblsFullName;
        private System.Windows.Forms.Label lblsAccountID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2ImageButton pbEye2;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtdPassword;
        private Guna.UI2.WinForms.Guna2Button btndSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtdSerialNumber;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button btnTransfer;
        private Guna.UI2.WinForms.Guna2Panel panelDeposit;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtTransferAmount;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label lbldCreatedDate;
        private System.Windows.Forms.Label lbldBalance;
        private System.Windows.Forms.Label lbldFullName;
        private System.Windows.Forms.Label lbldAccountID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label23;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}