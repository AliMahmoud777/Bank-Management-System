namespace BankSys_UI
{
    partial class frmFindMember
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
            this.ctrlMemberDetails1 = new BankSys_UI.ctrlMemberDetails();
            this.ctrlSearchMember1 = new BankSys_UI.ctrlSearchMember();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlMemberDetails1
            // 
            this.ctrlMemberDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlMemberDetails1.Location = new System.Drawing.Point(40, 119);
            this.ctrlMemberDetails1.Name = "ctrlMemberDetails1";
            this.ctrlMemberDetails1.Size = new System.Drawing.Size(614, 227);
            this.ctrlMemberDetails1.TabIndex = 9;
            // 
            // ctrlSearchMember1
            // 
            this.ctrlSearchMember1.BackColor = System.Drawing.Color.White;
            this.ctrlSearchMember1.Location = new System.Drawing.Point(30, 48);
            this.ctrlSearchMember1.Name = "ctrlSearchMember1";
            this.ctrlSearchMember1.Size = new System.Drawing.Size(412, 88);
            this.ctrlSearchMember1.TabIndex = 8;
            this.ctrlSearchMember1.MemberFoundEvent += new BankSys_UI.ctrlSearchMember.MemberFound(this.ctrlSearchMember1_MemberFoundEvent);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::BankSys_UI.Properties.Resources.undraw_the_search_cjxa;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(110, 322);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(452, 282);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 7;
            this.guna2PictureBox1.TabStop = false;
            // 
            // frmFindMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 601);
            this.Controls.Add(this.ctrlMemberDetails1);
            this.Controls.Add(this.ctrlSearchMember1);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFindMember";
            this.Text = "frmFindMember";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private ctrlMemberDetails ctrlMemberDetails1;
        private ctrlSearchMember ctrlSearchMember1;
    }
}