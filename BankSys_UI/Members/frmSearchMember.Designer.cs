namespace BankSys_UI
{
    partial class frmSearchMember
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
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlMemberSearch1 = new BankSys_UI.ctrlSearchMember();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::BankSys_UI.Properties.Resources.undraw_web_search_9qqc;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(102, 291);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(498, 298);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("PanRoman", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(40, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search For Member";
            // 
            // ctrlMemberSearch1
            // 
            this.ctrlMemberSearch1.BackColor = System.Drawing.Color.White;
            this.ctrlMemberSearch1.Location = new System.Drawing.Point(160, 171);
            this.ctrlMemberSearch1.Name = "ctrlMemberSearch1";
            this.ctrlMemberSearch1.Size = new System.Drawing.Size(397, 88);
            this.ctrlMemberSearch1.TabIndex = 1;
            this.ctrlMemberSearch1.MemberFoundEvent += new BankSys_UI.ctrlSearchMember.MemberFound(this.ctrlMemberSearch1_MemberFoundEvent);
            // 
            // frmSearchMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlMemberSearch1);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSearchMember";
            this.Text = "frmSearchMember";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private ctrlSearchMember ctrlMemberSearch1;
        private System.Windows.Forms.Label label1;
    }
}