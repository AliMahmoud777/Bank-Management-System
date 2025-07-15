namespace BankSys_UI
{
    partial class frmFindUser
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
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlSearchUser1
            // 
            this.ctrlSearchUser1.Location = new System.Drawing.Point(0, 73);
            this.ctrlSearchUser1.Name = "ctrlSearchUser1";
            this.ctrlSearchUser1.Size = new System.Drawing.Size(561, 88);
            this.ctrlSearchUser1.TabIndex = 3;
            this.ctrlSearchUser1.UserFoundByIDEvent += new BankSys_UI.ctrlSearchUser.UserFoundByID(this.ctrlSearchUser1_UserFoundByIDEvent);
            this.ctrlSearchUser1.UserFoundByUsernameEvent += new BankSys_UI.ctrlSearchUser.UserFoundByUsername(this.ctrlSearchUser1_UserFoundByUsernameEvent);
            // 
            // ctrlUserDetails1
            // 
            this.ctrlUserDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlUserDetails1.Location = new System.Drawing.Point(0, 167);
            this.ctrlUserDetails1.Name = "ctrlUserDetails1";
            this.ctrlUserDetails1.Size = new System.Drawing.Size(775, 227);
            this.ctrlUserDetails1.TabIndex = 2;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::BankSys_UI.Properties.Resources.undraw_the_search_cjxa;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(20, 373);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(541, 240);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            // 
            // frmFindUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 601);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.ctrlSearchUser1);
            this.Controls.Add(this.ctrlUserDetails1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFindUser";
            this.Text = "frmFindUser";
            this.Load += new System.EventHandler(this.frmFindUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlSearchUser ctrlSearchUser1;
        private ctrlUserDetails ctrlUserDetails1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}