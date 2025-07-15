namespace BankSys_UI
{
    partial class frmDeleteAccount
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
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ctrlAccountDetails1 = new BankSys_UI.ctrlAccountDetails();
            this.ctrlSearchAccount1 = new BankSys_UI.ctrlSearchAccount();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.Maroon;
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.Enabled = false;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(490, 378);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 39);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::BankSys_UI.Properties.Resources.undraw_throw_away_k2t5;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-36, 350);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(604, 249);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 16;
            this.guna2PictureBox1.TabStop = false;
            // 
            // ctrlAccountDetails1
            // 
            this.ctrlAccountDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlAccountDetails1.Location = new System.Drawing.Point(24, 129);
            this.ctrlAccountDetails1.Name = "ctrlAccountDetails1";
            this.ctrlAccountDetails1.Size = new System.Drawing.Size(623, 222);
            this.ctrlAccountDetails1.TabIndex = 20;
            // 
            // ctrlSearchAccount1
            // 
            this.ctrlSearchAccount1.BackColor = System.Drawing.Color.White;
            this.ctrlSearchAccount1.Location = new System.Drawing.Point(12, 46);
            this.ctrlSearchAccount1.Name = "ctrlSearchAccount1";
            this.ctrlSearchAccount1.Size = new System.Drawing.Size(412, 88);
            this.ctrlSearchAccount1.TabIndex = 21;
            this.ctrlSearchAccount1.AccountFoundByIDEvent += new BankSys_UI.ctrlSearchAccount.AccountFoundByID(this.ctrlSearchAccount1_AccountFoundByIDEvent);
            // 
            // frmDeleteAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 601);
            this.Controls.Add(this.ctrlSearchAccount1);
            this.Controls.Add(this.ctrlAccountDetails1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDeleteAccount";
            this.Text = "frmDeleteAccount";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private ctrlAccountDetails ctrlAccountDetails1;
        private ctrlSearchAccount ctrlSearchAccount1;
    }
}