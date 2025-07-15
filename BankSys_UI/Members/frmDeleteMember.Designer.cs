namespace BankSys_UI
{
    partial class frmDeleteMember
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
            this.ctrlMemberDetails1 = new BankSys_UI.ctrlMemberDetails();
            this.ctrlSearchMember1 = new BankSys_UI.ctrlSearchMember();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
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
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ctrlMemberDetails1
            // 
            this.ctrlMemberDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlMemberDetails1.Location = new System.Drawing.Point(23, 128);
            this.ctrlMemberDetails1.Name = "ctrlMemberDetails1";
            this.ctrlMemberDetails1.Size = new System.Drawing.Size(627, 227);
            this.ctrlMemberDetails1.TabIndex = 4;
            // 
            // ctrlSearchMember1
            // 
            this.ctrlSearchMember1.BackColor = System.Drawing.Color.White;
            this.ctrlSearchMember1.Location = new System.Drawing.Point(12, 45);
            this.ctrlSearchMember1.Name = "ctrlSearchMember1";
            this.ctrlSearchMember1.Size = new System.Drawing.Size(412, 88);
            this.ctrlSearchMember1.TabIndex = 3;
            this.ctrlSearchMember1.MemberFoundEvent += new BankSys_UI.ctrlSearchMember.MemberFound(this.ctrlSearchMember1_MemberFoundEvent);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::BankSys_UI.Properties.Resources.undraw_throw_away_k2t5;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-36, 350);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(604, 249);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // frmDeleteMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 601);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.ctrlMemberDetails1);
            this.Controls.Add(this.ctrlSearchMember1);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDeleteMember";
            this.Text = "frmDeleteMember";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private ctrlSearchMember ctrlSearchMember1;
        private ctrlMemberDetails ctrlMemberDetails1;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
    }
}