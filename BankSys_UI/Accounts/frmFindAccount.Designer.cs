namespace BankSys_UI
{
    partial class frmFindAccount
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
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ctrlSearchAccount1 = new BankSys_UI.ctrlSearchAccount();
            this.ctrlAccountDetails1 = new BankSys_UI.ctrlAccountDetails();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::BankSys_UI.Properties.Resources.undraw_the_search_cjxa;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(112, 324);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(452, 282);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 10;
            this.guna2PictureBox1.TabStop = false;
            // 
            // ctrlSearchAccount1
            // 
            this.ctrlSearchAccount1.BackColor = System.Drawing.Color.White;
            this.ctrlSearchAccount1.Location = new System.Drawing.Point(32, 49);
            this.ctrlSearchAccount1.Name = "ctrlSearchAccount1";
            this.ctrlSearchAccount1.Size = new System.Drawing.Size(412, 88);
            this.ctrlSearchAccount1.TabIndex = 13;
            this.ctrlSearchAccount1.AccountFoundByIDEvent += new BankSys_UI.ctrlSearchAccount.AccountFoundByID(this.ctrlSearchAccount1_AccountFoundByIDEvent);
            // 
            // ctrlAccountDetails1
            // 
            this.ctrlAccountDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlAccountDetails1.Location = new System.Drawing.Point(42, 121);
            this.ctrlAccountDetails1.Name = "ctrlAccountDetails1";
            this.ctrlAccountDetails1.Size = new System.Drawing.Size(599, 222);
            this.ctrlAccountDetails1.TabIndex = 14;
            // 
            // frmFindAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 601);
            this.Controls.Add(this.ctrlAccountDetails1);
            this.Controls.Add(this.ctrlSearchAccount1);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFindAccount";
            this.Text = "frmFindAccount";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private ctrlSearchAccount ctrlSearchAccount1;
        private ctrlAccountDetails ctrlAccountDetails1;
    }
}