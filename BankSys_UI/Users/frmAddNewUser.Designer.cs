namespace BankSys_UI
{
    partial class frmAddNewUser
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcGeneralInfo = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpMemberInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.tpUserInfo = new System.Windows.Forms.TabPage();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.pbEye2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pbEye1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panelUserID = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.llRemove = new System.Windows.Forms.LinkLabel();
            this.llSetImage = new System.Windows.Forms.LinkLabel();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.gbTransaction = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chbTransactionFullAccess = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.chbDeposit = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chbTransfer = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chbWithdraw = new Guna.UI2.WinForms.Guna2CheckBox();
            this.gbAccount = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chbAccountFullAccess = new Guna.UI2.WinForms.Guna2CheckBox();
            this.gbUser = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chbUserFullAccess = new Guna.UI2.WinForms.Guna2CheckBox();
            this.gbMember = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chbMemberFullAccess = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.chbEmail = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chbShowAll = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chbFind = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chbDelete = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chbEdit = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chbAddNew = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbUserImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.ctrlMemberDetails1 = new BankSys_UI.ctrlMemberDetails();
            this.ctrlSearchMember1 = new BankSys_UI.ctrlSearchMember();
            this.chbAdmin = new Guna.UI2.WinForms.Guna2CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tcGeneralInfo.SuspendLayout();
            this.tpMemberInfo.SuspendLayout();
            this.tpUserInfo.SuspendLayout();
            this.panelUserID.SuspendLayout();
            this.gbTransaction.SuspendLayout();
            this.gbAccount.SuspendLayout();
            this.gbUser.SuspendLayout();
            this.gbMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // tcGeneralInfo
            // 
            this.tcGeneralInfo.Controls.Add(this.tpMemberInfo);
            this.tcGeneralInfo.Controls.Add(this.tpUserInfo);
            this.tcGeneralInfo.ItemSize = new System.Drawing.Size(180, 30);
            this.tcGeneralInfo.Location = new System.Drawing.Point(12, 84);
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
            this.tcGeneralInfo.TabIndex = 0;
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
            // tpUserInfo
            // 
            this.tpUserInfo.Controls.Add(this.chbAdmin);
            this.tpUserInfo.Controls.Add(this.btnBack);
            this.tpUserInfo.Controls.Add(this.pbEye2);
            this.tpUserInfo.Controls.Add(this.pbEye1);
            this.tpUserInfo.Controls.Add(this.panelUserID);
            this.tpUserInfo.Controls.Add(this.llRemove);
            this.tpUserInfo.Controls.Add(this.llSetImage);
            this.tpUserInfo.Controls.Add(this.btnReset);
            this.tpUserInfo.Controls.Add(this.btnSave);
            this.tpUserInfo.Controls.Add(this.gbTransaction);
            this.tpUserInfo.Controls.Add(this.gbAccount);
            this.tpUserInfo.Controls.Add(this.gbUser);
            this.tpUserInfo.Controls.Add(this.gbMember);
            this.tpUserInfo.Controls.Add(this.label1);
            this.tpUserInfo.Controls.Add(this.pbUserImage);
            this.tpUserInfo.Controls.Add(this.txtConfirmPassword);
            this.tpUserInfo.Controls.Add(this.txtPassword);
            this.tpUserInfo.Controls.Add(this.txtUsername);
            this.tpUserInfo.Location = new System.Drawing.Point(4, 34);
            this.tpUserInfo.Name = "tpUserInfo";
            this.tpUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpUserInfo.Size = new System.Drawing.Size(764, 475);
            this.tpUserInfo.TabIndex = 1;
            this.tpUserInfo.Text = "User Info";
            this.tpUserInfo.UseVisualStyleBackColor = true;
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
            this.pbEye2.Location = new System.Drawing.Point(230, 182);
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
            this.pbEye1.Location = new System.Drawing.Point(230, 119);
            this.pbEye1.Name = "pbEye1";
            this.pbEye1.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.pbEye1.Size = new System.Drawing.Size(25, 20);
            this.pbEye1.TabIndex = 149;
            this.pbEye1.Click += new System.EventHandler(this.pbEye1_Click);
            // 
            // panelUserID
            // 
            this.panelUserID.Controls.Add(this.label3);
            this.panelUserID.Controls.Add(this.lblUserID);
            this.panelUserID.Location = new System.Drawing.Point(10, 6);
            this.panelUserID.Name = "panelUserID";
            this.panelUserID.Size = new System.Drawing.Size(157, 43);
            this.panelUserID.TabIndex = 148;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "User ID:";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblUserID.Location = new System.Drawing.Point(83, 11);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(24, 22);
            this.lblUserID.TabIndex = 12;
            this.lblUserID.Text = "??";
            // 
            // llRemove
            // 
            this.llRemove.AutoSize = true;
            this.llRemove.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llRemove.Location = new System.Drawing.Point(427, 130);
            this.llRemove.Name = "llRemove";
            this.llRemove.Size = new System.Drawing.Size(59, 17);
            this.llRemove.TabIndex = 147;
            this.llRemove.TabStop = true;
            this.llRemove.Text = "Remove";
            this.llRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemove_LinkClicked);
            // 
            // llSetImage
            // 
            this.llSetImage.AutoSize = true;
            this.llSetImage.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llSetImage.Location = new System.Drawing.Point(421, 92);
            this.llSetImage.Name = "llSetImage";
            this.llSetImage.Size = new System.Drawing.Size(70, 17);
            this.llSetImage.TabIndex = 146;
            this.llSetImage.TabStop = true;
            this.llSetImage.Text = "Set Image";
            this.llSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSetImage_LinkClicked);
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
            this.btnReset.Location = new System.Drawing.Point(471, 423);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(111, 39);
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
            this.btnSave.Location = new System.Drawing.Point(345, 423);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 39);
            this.btnSave.TabIndex = 144;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbTransaction
            // 
            this.gbTransaction.Controls.Add(this.chbTransactionFullAccess);
            this.gbTransaction.Controls.Add(this.guna2Separator2);
            this.gbTransaction.Controls.Add(this.chbDeposit);
            this.gbTransaction.Controls.Add(this.chbTransfer);
            this.gbTransaction.Controls.Add(this.chbWithdraw);
            this.gbTransaction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbTransaction.Location = new System.Drawing.Point(492, 234);
            this.gbTransaction.Name = "gbTransaction";
            this.gbTransaction.Size = new System.Drawing.Size(217, 160);
            this.gbTransaction.TabIndex = 143;
            this.gbTransaction.Text = "Transaction Permissions";
            // 
            // chbTransactionFullAccess
            // 
            this.chbTransactionFullAccess.AutoSize = true;
            this.chbTransactionFullAccess.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbTransactionFullAccess.CheckedState.BorderRadius = 0;
            this.chbTransactionFullAccess.CheckedState.BorderThickness = 0;
            this.chbTransactionFullAccess.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbTransactionFullAccess.Location = new System.Drawing.Point(3, 48);
            this.chbTransactionFullAccess.Name = "chbTransactionFullAccess";
            this.chbTransactionFullAccess.Size = new System.Drawing.Size(84, 19);
            this.chbTransactionFullAccess.TabIndex = 16;
            this.chbTransactionFullAccess.Text = "Full Access";
            this.chbTransactionFullAccess.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbTransactionFullAccess.UncheckedState.BorderRadius = 0;
            this.chbTransactionFullAccess.UncheckedState.BorderThickness = 0;
            this.chbTransactionFullAccess.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbTransactionFullAccess.CheckedChanged += new System.EventHandler(this.chbTransactionFullAccess_CheckedChanged);
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(0, 70);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator2.TabIndex = 14;
            // 
            // chbDeposit
            // 
            this.chbDeposit.AutoSize = true;
            this.chbDeposit.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbDeposit.CheckedState.BorderRadius = 0;
            this.chbDeposit.CheckedState.BorderThickness = 0;
            this.chbDeposit.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbDeposit.Location = new System.Drawing.Point(3, 85);
            this.chbDeposit.Name = "chbDeposit";
            this.chbDeposit.Size = new System.Drawing.Size(66, 19);
            this.chbDeposit.TabIndex = 12;
            this.chbDeposit.Text = "Deposit";
            this.chbDeposit.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbDeposit.UncheckedState.BorderRadius = 0;
            this.chbDeposit.UncheckedState.BorderThickness = 0;
            this.chbDeposit.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbDeposit.CheckedChanged += new System.EventHandler(this._HandleTransactionFullAccessCheckBox);
            // 
            // chbTransfer
            // 
            this.chbTransfer.AutoSize = true;
            this.chbTransfer.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbTransfer.CheckedState.BorderRadius = 0;
            this.chbTransfer.CheckedState.BorderThickness = 0;
            this.chbTransfer.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbTransfer.Location = new System.Drawing.Point(3, 135);
            this.chbTransfer.Name = "chbTransfer";
            this.chbTransfer.Size = new System.Drawing.Size(67, 19);
            this.chbTransfer.TabIndex = 15;
            this.chbTransfer.Text = "Transfer";
            this.chbTransfer.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbTransfer.UncheckedState.BorderRadius = 0;
            this.chbTransfer.UncheckedState.BorderThickness = 0;
            this.chbTransfer.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbTransfer.CheckedChanged += new System.EventHandler(this._HandleTransactionFullAccessCheckBox);
            // 
            // chbWithdraw
            // 
            this.chbWithdraw.AutoSize = true;
            this.chbWithdraw.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbWithdraw.CheckedState.BorderRadius = 0;
            this.chbWithdraw.CheckedState.BorderThickness = 0;
            this.chbWithdraw.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbWithdraw.Location = new System.Drawing.Point(3, 110);
            this.chbWithdraw.Name = "chbWithdraw";
            this.chbWithdraw.Size = new System.Drawing.Size(77, 19);
            this.chbWithdraw.TabIndex = 13;
            this.chbWithdraw.Text = "Withdraw";
            this.chbWithdraw.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbWithdraw.UncheckedState.BorderRadius = 0;
            this.chbWithdraw.UncheckedState.BorderThickness = 0;
            this.chbWithdraw.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbWithdraw.CheckedChanged += new System.EventHandler(this._HandleTransactionFullAccessCheckBox);
            // 
            // gbAccount
            // 
            this.gbAccount.Controls.Add(this.chbAccountFullAccess);
            this.gbAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbAccount.Location = new System.Drawing.Point(317, 328);
            this.gbAccount.Name = "gbAccount";
            this.gbAccount.Size = new System.Drawing.Size(157, 75);
            this.gbAccount.TabIndex = 142;
            this.gbAccount.Text = "Account Permissions";
            // 
            // chbAccountFullAccess
            // 
            this.chbAccountFullAccess.AutoSize = true;
            this.chbAccountFullAccess.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbAccountFullAccess.CheckedState.BorderRadius = 0;
            this.chbAccountFullAccess.CheckedState.BorderThickness = 0;
            this.chbAccountFullAccess.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbAccountFullAccess.Location = new System.Drawing.Point(3, 48);
            this.chbAccountFullAccess.Name = "chbAccountFullAccess";
            this.chbAccountFullAccess.Size = new System.Drawing.Size(84, 19);
            this.chbAccountFullAccess.TabIndex = 11;
            this.chbAccountFullAccess.Text = "Full Access";
            this.chbAccountFullAccess.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbAccountFullAccess.UncheckedState.BorderRadius = 0;
            this.chbAccountFullAccess.UncheckedState.BorderThickness = 0;
            this.chbAccountFullAccess.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // gbUser
            // 
            this.gbUser.Controls.Add(this.chbUserFullAccess);
            this.gbUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbUser.Location = new System.Drawing.Point(317, 234);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(157, 75);
            this.gbUser.TabIndex = 141;
            this.gbUser.Text = "User Permissions";
            // 
            // chbUserFullAccess
            // 
            this.chbUserFullAccess.AutoSize = true;
            this.chbUserFullAccess.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbUserFullAccess.CheckedState.BorderRadius = 0;
            this.chbUserFullAccess.CheckedState.BorderThickness = 0;
            this.chbUserFullAccess.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbUserFullAccess.Location = new System.Drawing.Point(3, 48);
            this.chbUserFullAccess.Name = "chbUserFullAccess";
            this.chbUserFullAccess.Size = new System.Drawing.Size(84, 19);
            this.chbUserFullAccess.TabIndex = 11;
            this.chbUserFullAccess.Text = "Full Access";
            this.chbUserFullAccess.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbUserFullAccess.UncheckedState.BorderRadius = 0;
            this.chbUserFullAccess.UncheckedState.BorderThickness = 0;
            this.chbUserFullAccess.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // gbMember
            // 
            this.gbMember.Controls.Add(this.chbMemberFullAccess);
            this.gbMember.Controls.Add(this.guna2Separator1);
            this.gbMember.Controls.Add(this.chbEmail);
            this.gbMember.Controls.Add(this.chbShowAll);
            this.gbMember.Controls.Add(this.chbFind);
            this.gbMember.Controls.Add(this.chbDelete);
            this.gbMember.Controls.Add(this.chbEdit);
            this.gbMember.Controls.Add(this.chbAddNew);
            this.gbMember.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbMember.Location = new System.Drawing.Point(137, 234);
            this.gbMember.Name = "gbMember";
            this.gbMember.Size = new System.Drawing.Size(163, 238);
            this.gbMember.TabIndex = 140;
            this.gbMember.Text = "Member Permissions";
            // 
            // chbMemberFullAccess
            // 
            this.chbMemberFullAccess.AutoSize = true;
            this.chbMemberFullAccess.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbMemberFullAccess.CheckedState.BorderRadius = 0;
            this.chbMemberFullAccess.CheckedState.BorderThickness = 0;
            this.chbMemberFullAccess.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbMemberFullAccess.Location = new System.Drawing.Point(3, 48);
            this.chbMemberFullAccess.Name = "chbMemberFullAccess";
            this.chbMemberFullAccess.Size = new System.Drawing.Size(84, 19);
            this.chbMemberFullAccess.TabIndex = 11;
            this.chbMemberFullAccess.Text = "Full Access";
            this.chbMemberFullAccess.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbMemberFullAccess.UncheckedState.BorderRadius = 0;
            this.chbMemberFullAccess.UncheckedState.BorderThickness = 0;
            this.chbMemberFullAccess.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbMemberFullAccess.CheckedChanged += new System.EventHandler(this.chbMemberFullAccess_CheckedChanged);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(0, 73);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator1.TabIndex = 8;
            // 
            // chbEmail
            // 
            this.chbEmail.AutoSize = true;
            this.chbEmail.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbEmail.CheckedState.BorderRadius = 0;
            this.chbEmail.CheckedState.BorderThickness = 0;
            this.chbEmail.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbEmail.Location = new System.Drawing.Point(3, 214);
            this.chbEmail.Name = "chbEmail";
            this.chbEmail.Size = new System.Drawing.Size(103, 19);
            this.chbEmail.TabIndex = 8;
            this.chbEmail.Text = "Email Member";
            this.chbEmail.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbEmail.UncheckedState.BorderRadius = 0;
            this.chbEmail.UncheckedState.BorderThickness = 0;
            this.chbEmail.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbEmail.CheckedChanged += new System.EventHandler(this._HandleMemberFullAccessCheckBox);
            // 
            // chbShowAll
            // 
            this.chbShowAll.AutoSize = true;
            this.chbShowAll.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbShowAll.CheckedState.BorderRadius = 0;
            this.chbShowAll.CheckedState.BorderThickness = 0;
            this.chbShowAll.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbShowAll.Location = new System.Drawing.Point(3, 189);
            this.chbShowAll.Name = "chbShowAll";
            this.chbShowAll.Size = new System.Drawing.Size(125, 19);
            this.chbShowAll.TabIndex = 10;
            this.chbShowAll.Text = "Show All Members";
            this.chbShowAll.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbShowAll.UncheckedState.BorderRadius = 0;
            this.chbShowAll.UncheckedState.BorderThickness = 0;
            this.chbShowAll.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbShowAll.CheckedChanged += new System.EventHandler(this._HandleMemberFullAccessCheckBox);
            // 
            // chbFind
            // 
            this.chbFind.AutoSize = true;
            this.chbFind.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbFind.CheckedState.BorderRadius = 0;
            this.chbFind.CheckedState.BorderThickness = 0;
            this.chbFind.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbFind.Location = new System.Drawing.Point(3, 164);
            this.chbFind.Name = "chbFind";
            this.chbFind.Size = new System.Drawing.Size(97, 19);
            this.chbFind.TabIndex = 9;
            this.chbFind.Text = "Find Member";
            this.chbFind.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbFind.UncheckedState.BorderRadius = 0;
            this.chbFind.UncheckedState.BorderThickness = 0;
            this.chbFind.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbFind.CheckedChanged += new System.EventHandler(this._HandleMemberFullAccessCheckBox);
            // 
            // chbDelete
            // 
            this.chbDelete.AutoSize = true;
            this.chbDelete.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbDelete.CheckedState.BorderRadius = 0;
            this.chbDelete.CheckedState.BorderThickness = 0;
            this.chbDelete.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbDelete.Location = new System.Drawing.Point(3, 139);
            this.chbDelete.Name = "chbDelete";
            this.chbDelete.Size = new System.Drawing.Size(107, 19);
            this.chbDelete.TabIndex = 8;
            this.chbDelete.Text = "Delete Member";
            this.chbDelete.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbDelete.UncheckedState.BorderRadius = 0;
            this.chbDelete.UncheckedState.BorderThickness = 0;
            this.chbDelete.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbDelete.CheckedChanged += new System.EventHandler(this._HandleMemberFullAccessCheckBox);
            // 
            // chbEdit
            // 
            this.chbEdit.AutoSize = true;
            this.chbEdit.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbEdit.CheckedState.BorderRadius = 0;
            this.chbEdit.CheckedState.BorderThickness = 0;
            this.chbEdit.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbEdit.Location = new System.Drawing.Point(3, 114);
            this.chbEdit.Name = "chbEdit";
            this.chbEdit.Size = new System.Drawing.Size(94, 19);
            this.chbEdit.TabIndex = 7;
            this.chbEdit.Text = "Edit Member";
            this.chbEdit.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbEdit.UncheckedState.BorderRadius = 0;
            this.chbEdit.UncheckedState.BorderThickness = 0;
            this.chbEdit.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbEdit.CheckedChanged += new System.EventHandler(this._HandleMemberFullAccessCheckBox);
            // 
            // chbAddNew
            // 
            this.chbAddNew.AutoSize = true;
            this.chbAddNew.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbAddNew.CheckedState.BorderRadius = 0;
            this.chbAddNew.CheckedState.BorderThickness = 0;
            this.chbAddNew.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbAddNew.Location = new System.Drawing.Point(3, 89);
            this.chbAddNew.Name = "chbAddNew";
            this.chbAddNew.Size = new System.Drawing.Size(123, 19);
            this.chbAddNew.TabIndex = 6;
            this.chbAddNew.Text = "Add New Member";
            this.chbAddNew.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbAddNew.UncheckedState.BorderRadius = 0;
            this.chbAddNew.UncheckedState.BorderThickness = 0;
            this.chbAddNew.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbAddNew.CheckedChanged += new System.EventHandler(this._HandleMemberFullAccessCheckBox);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(534, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 139;
            this.label1.Text = "User Image";
            // 
            // pbUserImage
            // 
            this.pbUserImage.BackColor = System.Drawing.Color.White;
            this.pbUserImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUserImage.Image = global::BankSys_UI.Properties.Resources.Male_512;
            this.pbUserImage.ImageRotate = 0F;
            this.pbUserImage.Location = new System.Drawing.Point(508, 55);
            this.pbUserImage.Name = "pbUserImage";
            this.pbUserImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbUserImage.Size = new System.Drawing.Size(148, 136);
            this.pbUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserImage.TabIndex = 138;
            this.pbUserImage.TabStop = false;
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
            this.txtConfirmPassword.Location = new System.Drawing.Point(24, 175);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtConfirmPassword.PlaceholderText = "Confirm Password";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(200, 36);
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
            this.txtPassword.Location = new System.Drawing.Point(24, 112);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(200, 36);
            this.txtPassword.TabIndex = 136;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtUsername
            // 
            this.txtUsername.BorderRadius = 20;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(24, 55);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(200, 36);
            this.txtUsername.TabIndex = 135;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
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
            // chbAdmin
            // 
            this.chbAdmin.AutoSize = true;
            this.chbAdmin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbAdmin.CheckedState.BorderRadius = 0;
            this.chbAdmin.CheckedState.BorderThickness = 0;
            this.chbAdmin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbAdmin.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAdmin.Location = new System.Drawing.Point(36, 234);
            this.chbAdmin.Name = "chbAdmin";
            this.chbAdmin.Size = new System.Drawing.Size(77, 27);
            this.chbAdmin.TabIndex = 12;
            this.chbAdmin.Text = "Admin";
            this.chbAdmin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbAdmin.UncheckedState.BorderRadius = 0;
            this.chbAdmin.UncheckedState.BorderThickness = 0;
            this.chbAdmin.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbAdmin.CheckedChanged += new System.EventHandler(this.chbAdmin_CheckedChanged);
            // 
            // frmAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 601);
            this.Controls.Add(this.tcGeneralInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddNewUser";
            this.Text = "frmAddNewUser";
            this.Load += new System.EventHandler(this.frmAddNewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tcGeneralInfo.ResumeLayout(false);
            this.tpMemberInfo.ResumeLayout(false);
            this.tpUserInfo.ResumeLayout(false);
            this.tpUserInfo.PerformLayout();
            this.panelUserID.ResumeLayout(false);
            this.panelUserID.PerformLayout();
            this.gbTransaction.ResumeLayout(false);
            this.gbTransaction.PerformLayout();
            this.gbAccount.ResumeLayout(false);
            this.gbAccount.PerformLayout();
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            this.gbMember.ResumeLayout(false);
            this.gbMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2TabControl tcGeneralInfo;
        private System.Windows.Forms.TabPage tpMemberInfo;
        private System.Windows.Forms.TabPage tpUserInfo;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2ImageButton pbEye2;
        private Guna.UI2.WinForms.Guna2ImageButton pbEye1;
        private Guna.UI2.WinForms.Guna2Panel panelUserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.LinkLabel llRemove;
        private System.Windows.Forms.LinkLabel llSetImage;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2GroupBox gbTransaction;
        private Guna.UI2.WinForms.Guna2CheckBox chbTransactionFullAccess;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2CheckBox chbDeposit;
        private Guna.UI2.WinForms.Guna2CheckBox chbTransfer;
        private Guna.UI2.WinForms.Guna2CheckBox chbWithdraw;
        private Guna.UI2.WinForms.Guna2GroupBox gbAccount;
        private Guna.UI2.WinForms.Guna2CheckBox chbAccountFullAccess;
        private Guna.UI2.WinForms.Guna2GroupBox gbUser;
        private Guna.UI2.WinForms.Guna2CheckBox chbUserFullAccess;
        private Guna.UI2.WinForms.Guna2GroupBox gbMember;
        private Guna.UI2.WinForms.Guna2CheckBox chbMemberFullAccess;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2CheckBox chbEmail;
        private Guna.UI2.WinForms.Guna2CheckBox chbShowAll;
        private Guna.UI2.WinForms.Guna2CheckBox chbFind;
        private Guna.UI2.WinForms.Guna2CheckBox chbDelete;
        private Guna.UI2.WinForms.Guna2CheckBox chbEdit;
        private Guna.UI2.WinForms.Guna2CheckBox chbAddNew;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbUserImage;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private ctrlMemberDetails ctrlMemberDetails1;
        private ctrlSearchMember ctrlSearchMember1;
        private Guna.UI2.WinForms.Guna2CheckBox chbAdmin;
    }
}