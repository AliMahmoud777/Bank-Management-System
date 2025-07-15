namespace BankSys_UI
{
    partial class frmAccounts
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
            this.btnTransactions = new Guna.UI2.WinForms.Guna2Button();
            this.btnShow = new Guna.UI2.WinForms.Guna2Button();
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnFindSerialNumber = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnTransactions
            // 
            this.btnTransactions.Animated = true;
            this.btnTransactions.BackColor = System.Drawing.Color.Transparent;
            this.btnTransactions.BorderColor = System.Drawing.Color.DimGray;
            this.btnTransactions.BorderRadius = 20;
            this.btnTransactions.BorderThickness = 4;
            this.btnTransactions.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.btnTransactions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTransactions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTransactions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTransactions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTransactions.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnTransactions.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.ForeColor = System.Drawing.Color.Black;
            this.btnTransactions.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnTransactions.Location = new System.Drawing.Point(275, 374);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(248, 61);
            this.btnTransactions.TabIndex = 16;
            this.btnTransactions.Text = "Account\'s Transactions";
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnShow
            // 
            this.btnShow.Animated = true;
            this.btnShow.BackColor = System.Drawing.Color.Transparent;
            this.btnShow.BorderColor = System.Drawing.Color.DimGray;
            this.btnShow.BorderRadius = 20;
            this.btnShow.BorderThickness = 4;
            this.btnShow.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.btnShow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShow.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnShow.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Black;
            this.btnShow.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnShow.Location = new System.Drawing.Point(536, 374);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(220, 61);
            this.btnShow.TabIndex = 15;
            this.btnShow.Text = "Show All Accounts";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnFind
            // 
            this.btnFind.Animated = true;
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.BorderColor = System.Drawing.Color.DimGray;
            this.btnFind.BorderRadius = 20;
            this.btnFind.BorderThickness = 4;
            this.btnFind.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.btnFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFind.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnFind.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.Black;
            this.btnFind.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnFind.Location = new System.Drawing.Point(536, 240);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(220, 61);
            this.btnFind.TabIndex = 14;
            this.btnFind.Text = "Find Account";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderColor = System.Drawing.Color.DimGray;
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.BorderThickness = 4;
            this.btnDelete.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnDelete.Location = new System.Drawing.Point(40, 374);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(220, 61);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete Account";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Animated = true;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BorderColor = System.Drawing.Color.DimGray;
            this.btnEdit.BorderRadius = 20;
            this.btnEdit.BorderThickness = 4;
            this.btnEdit.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnEdit.Location = new System.Drawing.Point(275, 240);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(248, 61);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Change Password";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 35F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(196, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 56);
            this.label1.TabIndex = 11;
            this.label1.Text = "Manage Accounts";
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderColor = System.Drawing.Color.DimGray;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderThickness = 4;
            this.btnAdd.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnAdd.Location = new System.Drawing.Point(40, 240);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(220, 61);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add New Account";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFindSerialNumber
            // 
            this.btnFindSerialNumber.Animated = true;
            this.btnFindSerialNumber.BackColor = System.Drawing.Color.Transparent;
            this.btnFindSerialNumber.BorderColor = System.Drawing.Color.DimGray;
            this.btnFindSerialNumber.BorderRadius = 20;
            this.btnFindSerialNumber.BorderThickness = 4;
            this.btnFindSerialNumber.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.btnFindSerialNumber.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFindSerialNumber.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFindSerialNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFindSerialNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFindSerialNumber.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnFindSerialNumber.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindSerialNumber.ForeColor = System.Drawing.Color.Black;
            this.btnFindSerialNumber.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnFindSerialNumber.Location = new System.Drawing.Point(241, 494);
            this.btnFindSerialNumber.Name = "btnFindSerialNumber";
            this.btnFindSerialNumber.Size = new System.Drawing.Size(315, 61);
            this.btnFindSerialNumber.TabIndex = 17;
            this.btnFindSerialNumber.Text = "Find Serial Number";
            this.btnFindSerialNumber.Click += new System.EventHandler(this.btnFindSerialNumber_Click);
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 601);
            this.Controls.Add(this.btnFindSerialNumber);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAccounts";
            this.Text = "frmAccounts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnTransactions;
        private Guna.UI2.WinForms.Guna2Button btnShow;
        private Guna.UI2.WinForms.Guna2Button btnFind;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnFindSerialNumber;
    }
}