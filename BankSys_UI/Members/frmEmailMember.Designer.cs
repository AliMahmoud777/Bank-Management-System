namespace BankSys_UI
{
    partial class frmEmailMember
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcSendEmail = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpMemberDetials = new System.Windows.Forms.TabPage();
            this.ctrlMemberDetails1 = new BankSys_UI.ctrlMemberDetails();
            this.ctrlSearchMember1 = new BankSys_UI.ctrlSearchMember();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.tpEmailInfo = new System.Windows.Forms.TabPage();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.btnSend = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBody = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tcSendEmail.SuspendLayout();
            this.tpMemberDetials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.tpEmailInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tcSendEmail
            // 
            this.tcSendEmail.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcSendEmail.Controls.Add(this.tpMemberDetials);
            this.tcSendEmail.Controls.Add(this.tpEmailInfo);
            this.tcSendEmail.Font = new System.Drawing.Font("Tahoma", 8F);
            this.tcSendEmail.ItemSize = new System.Drawing.Size(120, 70);
            this.tcSendEmail.Location = new System.Drawing.Point(5, 75);
            this.tcSendEmail.Name = "tcSendEmail";
            this.tcSendEmail.SelectedIndex = 0;
            this.tcSendEmail.Size = new System.Drawing.Size(789, 514);
            this.tcSendEmail.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcSendEmail.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcSendEmail.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcSendEmail.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcSendEmail.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcSendEmail.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcSendEmail.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcSendEmail.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcSendEmail.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcSendEmail.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcSendEmail.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcSendEmail.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcSendEmail.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcSendEmail.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcSendEmail.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcSendEmail.TabButtonSize = new System.Drawing.Size(120, 70);
            this.tcSendEmail.TabIndex = 167;
            this.tcSendEmail.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // tpMemberDetials
            // 
            this.tpMemberDetials.BackColor = System.Drawing.Color.White;
            this.tpMemberDetials.Controls.Add(this.ctrlMemberDetails1);
            this.tpMemberDetials.Controls.Add(this.ctrlSearchMember1);
            this.tpMemberDetials.Controls.Add(this.guna2PictureBox1);
            this.tpMemberDetials.Controls.Add(this.btnNext);
            this.tpMemberDetials.Font = new System.Drawing.Font("Tahoma", 8F);
            this.tpMemberDetials.Location = new System.Drawing.Point(124, 4);
            this.tpMemberDetials.Name = "tpMemberDetials";
            this.tpMemberDetials.Padding = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.tpMemberDetials.Size = new System.Drawing.Size(661, 506);
            this.tpMemberDetials.TabIndex = 0;
            this.tpMemberDetials.Text = "Member Details";
            // 
            // ctrlMemberDetails1
            // 
            this.ctrlMemberDetails1.BackColor = System.Drawing.Color.White;
            this.ctrlMemberDetails1.Location = new System.Drawing.Point(28, 96);
            this.ctrlMemberDetails1.Name = "ctrlMemberDetails1";
            this.ctrlMemberDetails1.Size = new System.Drawing.Size(614, 227);
            this.ctrlMemberDetails1.TabIndex = 207;
            // 
            // ctrlSearchMember1
            // 
            this.ctrlSearchMember1.BackColor = System.Drawing.Color.White;
            this.ctrlSearchMember1.Location = new System.Drawing.Point(18, 25);
            this.ctrlSearchMember1.Name = "ctrlSearchMember1";
            this.ctrlSearchMember1.Size = new System.Drawing.Size(412, 88);
            this.ctrlSearchMember1.TabIndex = 206;
            this.ctrlSearchMember1.MemberFoundEvent += new BankSys_UI.ctrlSearchMember.MemberFound(this.ctrlSearchMember1_MemberFoundEvent);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::BankSys_UI.Properties.Resources.undraw_the_search_cjxa;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(140, 314);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(290, 207);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 205;
            this.guna2PictureBox1.TabStop = false;
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
            this.btnNext.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNext.Location = new System.Drawing.Point(535, 401);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(65, 55);
            this.btnNext.TabIndex = 202;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpEmailInfo
            // 
            this.tpEmailInfo.Controls.Add(this.btnReset);
            this.tpEmailInfo.Controls.Add(this.btnSend);
            this.tpEmailInfo.Controls.Add(this.label1);
            this.tpEmailInfo.Controls.Add(this.txtBody);
            this.tpEmailInfo.Controls.Add(this.label5);
            this.tpEmailInfo.Controls.Add(this.txtTitle);
            this.tpEmailInfo.Controls.Add(this.btnBack);
            this.tpEmailInfo.Location = new System.Drawing.Point(124, 4);
            this.tpEmailInfo.Name = "tpEmailInfo";
            this.tpEmailInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmailInfo.Size = new System.Drawing.Size(661, 506);
            this.tpEmailInfo.TabIndex = 1;
            this.tpEmailInfo.Text = "Email Info";
            this.tpEmailInfo.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BorderRadius = 20;
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.FillColor = System.Drawing.Color.Gray;
            this.btnReset.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(203, 443);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(126, 49);
            this.btnReset.TabIndex = 212;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.BorderRadius = 20;
            this.btnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSend.FillColor = System.Drawing.Color.SlateBlue;
            this.btnSend.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(345, 443);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(126, 49);
            this.btnSend.TabIndex = 211;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 26);
            this.label1.TabIndex = 210;
            this.label1.Text = "Body:";
            // 
            // txtBody
            // 
            this.txtBody.Animated = true;
            this.txtBody.BorderColor = System.Drawing.Color.Gray;
            this.txtBody.BorderRadius = 20;
            this.txtBody.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBody.DefaultText = "";
            this.txtBody.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBody.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBody.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBody.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBody.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBody.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBody.ForeColor = System.Drawing.Color.Black;
            this.txtBody.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBody.Location = new System.Drawing.Point(65, 206);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.PlaceholderText = "";
            this.txtBody.SelectedText = "";
            this.txtBody.Size = new System.Drawing.Size(406, 216);
            this.txtBody.TabIndex = 209;
            this.txtBody.Validating += new System.ComponentModel.CancelEventHandler(this.txtBody_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sylfaen", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(28, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 26);
            this.label5.TabIndex = 208;
            this.label5.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Animated = true;
            this.txtTitle.BorderColor = System.Drawing.Color.Gray;
            this.txtTitle.BorderRadius = 20;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultText = "";
            this.txtTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTitle.ForeColor = System.Drawing.Color.Black;
            this.txtTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.Location = new System.Drawing.Point(65, 88);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PlaceholderText = "";
            this.txtTitle.SelectedText = "";
            this.txtTitle.Size = new System.Drawing.Size(406, 53);
            this.txtTitle.TabIndex = 207;
            this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitle_Validating);
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
            this.btnBack.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBack.Location = new System.Drawing.Point(15, 443);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 55);
            this.btnBack.TabIndex = 206;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("PanRoman", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 40);
            this.label3.TabIndex = 203;
            this.label3.Text = "Email Member";
            // 
            // frmEmailMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 601);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tcSendEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmailMember";
            this.Text = "frmEmailMember";
            this.Load += new System.EventHandler(this.frmEmailMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tcSendEmail.ResumeLayout(false);
            this.tpMemberDetials.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.tpEmailInfo.ResumeLayout(false);
            this.tpEmailInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2TabControl tcSendEmail;
        private System.Windows.Forms.TabPage tpMemberDetials;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.TabPage tpEmailInfo;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.Label label3;
        private ctrlMemberDetails ctrlMemberDetails1;
        private ctrlSearchMember ctrlSearchMember1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtBody;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Button btnSend;
    }
}