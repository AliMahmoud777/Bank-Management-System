namespace BankSys_UI
{
    partial class frmChangePermissions
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
            this.ctrlSearchUser1 = new BankSys_UI.ctrlSearchUser();
            this.ctrlUserDetails1 = new BankSys_UI.ctrlUserDetails();
            this.chbAdmin = new Guna.UI2.WinForms.Guna2CheckBox();
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
            this.gbPermissions = new System.Windows.Forms.GroupBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.gbTransaction.SuspendLayout();
            this.gbAccount.SuspendLayout();
            this.gbUser.SuspendLayout();
            this.gbMember.SuspendLayout();
            this.gbPermissions.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlSearchUser1
            // 
            this.ctrlSearchUser1.Location = new System.Drawing.Point(-1, 55);
            this.ctrlSearchUser1.Name = "ctrlSearchUser1";
            this.ctrlSearchUser1.Size = new System.Drawing.Size(559, 73);
            this.ctrlSearchUser1.TabIndex = 5;
            this.ctrlSearchUser1.UserFoundByIDEvent += new BankSys_UI.ctrlSearchUser.UserFoundByID(this.ctrlSearchUser1_UserFoundByIDEvent);
            this.ctrlSearchUser1.UserFoundByUsernameEvent += new BankSys_UI.ctrlSearchUser.UserFoundByUsername(this.ctrlSearchUser1_UserFoundByUsernameEvent);
            // 
            // ctrlUserDetails1
            // 
            this.ctrlUserDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlUserDetails1.Location = new System.Drawing.Point(-1, 116);
            this.ctrlUserDetails1.Name = "ctrlUserDetails1";
            this.ctrlUserDetails1.Size = new System.Drawing.Size(775, 202);
            this.ctrlUserDetails1.TabIndex = 4;
            // 
            // chbAdmin
            // 
            this.chbAdmin.AutoSize = true;
            this.chbAdmin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbAdmin.CheckedState.BorderRadius = 0;
            this.chbAdmin.CheckedState.BorderThickness = 0;
            this.chbAdmin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbAdmin.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAdmin.Location = new System.Drawing.Point(16, 19);
            this.chbAdmin.Name = "chbAdmin";
            this.chbAdmin.Size = new System.Drawing.Size(77, 27);
            this.chbAdmin.TabIndex = 144;
            this.chbAdmin.Text = "Admin";
            this.chbAdmin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbAdmin.UncheckedState.BorderRadius = 0;
            this.chbAdmin.UncheckedState.BorderThickness = 0;
            this.chbAdmin.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbAdmin.CheckedChanged += new System.EventHandler(this.chbAdmin_CheckedChanged);
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
            this.gbTransaction.Location = new System.Drawing.Point(466, 20);
            this.gbTransaction.Name = "gbTransaction";
            this.gbTransaction.Size = new System.Drawing.Size(217, 160);
            this.gbTransaction.TabIndex = 148;
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
            this.gbAccount.Location = new System.Drawing.Point(291, 113);
            this.gbAccount.Name = "gbAccount";
            this.gbAccount.Size = new System.Drawing.Size(157, 75);
            this.gbAccount.TabIndex = 147;
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
            this.gbUser.Location = new System.Drawing.Point(291, 19);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(157, 75);
            this.gbUser.TabIndex = 146;
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
            this.gbMember.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.gbMember.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbMember.Location = new System.Drawing.Point(109, 19);
            this.gbMember.Name = "gbMember";
            this.gbMember.Size = new System.Drawing.Size(163, 223);
            this.gbMember.TabIndex = 145;
            this.gbMember.Text = "Member Permissions";
            this.gbMember.TextOffset = new System.Drawing.Point(0, -4);
            // 
            // chbMemberFullAccess
            // 
            this.chbMemberFullAccess.AutoSize = true;
            this.chbMemberFullAccess.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbMemberFullAccess.CheckedState.BorderRadius = 0;
            this.chbMemberFullAccess.CheckedState.BorderThickness = 0;
            this.chbMemberFullAccess.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbMemberFullAccess.Location = new System.Drawing.Point(3, 37);
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
            this.guna2Separator1.Location = new System.Drawing.Point(0, 58);
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
            this.chbEmail.Location = new System.Drawing.Point(3, 199);
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
            this.chbShowAll.Location = new System.Drawing.Point(3, 174);
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
            this.chbFind.Location = new System.Drawing.Point(3, 149);
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
            this.chbDelete.Location = new System.Drawing.Point(3, 124);
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
            this.chbEdit.Location = new System.Drawing.Point(3, 99);
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
            this.chbAddNew.Location = new System.Drawing.Point(3, 74);
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
            // gbPermissions
            // 
            this.gbPermissions.Controls.Add(this.gbMember);
            this.gbPermissions.Controls.Add(this.chbAdmin);
            this.gbPermissions.Controls.Add(this.gbUser);
            this.gbPermissions.Controls.Add(this.gbTransaction);
            this.gbPermissions.Controls.Add(this.gbAccount);
            this.gbPermissions.Enabled = false;
            this.gbPermissions.Location = new System.Drawing.Point(12, 340);
            this.gbPermissions.Name = "gbPermissions";
            this.gbPermissions.Size = new System.Drawing.Size(708, 253);
            this.gbPermissions.TabIndex = 12;
            this.gbPermissions.TabStop = false;
            this.gbPermissions.Text = "Access Permissions";
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
            this.btnSave.Location = new System.Drawing.Point(584, 295);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 39);
            this.btnSave.TabIndex = 149;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmChangePermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 601);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbPermissions);
            this.Controls.Add(this.ctrlSearchUser1);
            this.Controls.Add(this.ctrlUserDetails1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChangePermissions";
            this.Text = "frmChangePermissions";
            this.gbTransaction.ResumeLayout(false);
            this.gbTransaction.PerformLayout();
            this.gbAccount.ResumeLayout(false);
            this.gbAccount.PerformLayout();
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            this.gbMember.ResumeLayout(false);
            this.gbMember.PerformLayout();
            this.gbPermissions.ResumeLayout(false);
            this.gbPermissions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlSearchUser ctrlSearchUser1;
        private ctrlUserDetails ctrlUserDetails1;
        private Guna.UI2.WinForms.Guna2CheckBox chbAdmin;
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
        private System.Windows.Forms.GroupBox gbPermissions;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}