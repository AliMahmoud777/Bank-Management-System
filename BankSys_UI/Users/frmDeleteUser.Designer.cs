namespace BankSys_UI
{
    partial class frmDeleteUser
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
            this.ctrlUserDetails1 = new BankSys_UI.ctrlUserDetails();
            this.ctrlSearchUser1 = new BankSys_UI.ctrlSearchUser();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlUserDetails1
            // 
            this.ctrlUserDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlUserDetails1.Location = new System.Drawing.Point(0, 176);
            this.ctrlUserDetails1.Name = "ctrlUserDetails1";
            this.ctrlUserDetails1.Size = new System.Drawing.Size(775, 227);
            this.ctrlUserDetails1.TabIndex = 0;
            // 
            // ctrlSearchUser1
            // 
            this.ctrlSearchUser1.Location = new System.Drawing.Point(0, 82);
            this.ctrlSearchUser1.Name = "ctrlSearchUser1";
            this.ctrlSearchUser1.Size = new System.Drawing.Size(561, 88);
            this.ctrlSearchUser1.TabIndex = 1;
            this.ctrlSearchUser1.UserFoundByIDEvent += new BankSys_UI.ctrlSearchUser.UserFoundByID(this.ctrlSearchUser1_UserFoundByIDEvent);
            this.ctrlSearchUser1.UserFoundByUsernameEvent += new BankSys_UI.ctrlSearchUser.UserFoundByUsername(this.ctrlSearchUser1_UserFoundByUsernameEvent);
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
            this.btnDelete.Location = new System.Drawing.Point(487, 430);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 39);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::BankSys_UI.Properties.Resources.undraw_throw_away_k2t5;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-13, 374);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(574, 239);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 16;
            this.guna2PictureBox1.TabStop = false;
            // 
            // frmDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 601);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.ctrlSearchUser1);
            this.Controls.Add(this.ctrlUserDetails1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDeleteUser";
            this.Text = "frmDeleteUser";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlUserDetails ctrlUserDetails1;
        private ctrlSearchUser ctrlSearchUser1;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}