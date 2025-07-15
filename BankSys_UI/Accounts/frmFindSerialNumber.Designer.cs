namespace BankSys_UI.Accounts
{
    partial class frmFindSerialNumber
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
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.gpSerialNumber = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbEye = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccountID = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.gpSerialNumber.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::BankSys_UI.Properties.Resources.undraw_the_search_cjxa;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(367, 211);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(452, 332);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 175;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Sylfaen", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblWarning.Location = new System.Drawing.Point(108, 512);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(181, 14);
            this.lblWarning.TabIndex = 178;
            this.lblWarning.Text = "(!) Don\'t Share It With Anyone";
            this.lblWarning.Visible = false;
            // 
            // gpSerialNumber
            // 
            this.gpSerialNumber.BorderColor = System.Drawing.Color.DarkGray;
            this.gpSerialNumber.Controls.Add(this.lblSerialNumber);
            this.gpSerialNumber.CustomBorderColor = System.Drawing.Color.Firebrick;
            this.gpSerialNumber.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSerialNumber.ForeColor = System.Drawing.Color.Black;
            this.gpSerialNumber.Location = new System.Drawing.Point(93, 358);
            this.gpSerialNumber.Name = "gpSerialNumber";
            this.gpSerialNumber.Size = new System.Drawing.Size(282, 151);
            this.gpSerialNumber.TabIndex = 177;
            this.gpSerialNumber.Text = "Serial Number";
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.Font = new System.Drawing.Font("Sylfaen", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialNumber.Location = new System.Drawing.Point(38, 78);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(196, 48);
            this.lblSerialNumber.TabIndex = 157;
            this.lblSerialNumber.Text = "XXXX-XXXX-XXXX-XXXX";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbEye);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAccountID);
            this.groupBox1.Location = new System.Drawing.Point(60, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 262);
            this.groupBox1.TabIndex = 176;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Info";
            // 
            // pbEye
            // 
            this.pbEye.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.pbEye.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.pbEye.Image = global::BankSys_UI.Properties.Resources.Eye_Closed;
            this.pbEye.ImageOffset = new System.Drawing.Point(0, 0);
            this.pbEye.ImageRotate = 0F;
            this.pbEye.ImageSize = new System.Drawing.Size(25, 25);
            this.pbEye.Location = new System.Drawing.Point(38, 150);
            this.pbEye.Name = "pbEye";
            this.pbEye.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.pbEye.Size = new System.Drawing.Size(25, 20);
            this.pbEye.TabIndex = 177;
            this.pbEye.Click += new System.EventHandler(this.pbEye_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(14, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 22);
            this.label12.TabIndex = 176;
            this.label12.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Animated = true;
            this.txtPassword.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.BorderRadius = 20;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(73, 139);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(208, 42);
            this.txtPassword.TabIndex = 175;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // btnSearch
            // 
            this.btnSearch.Animated = true;
            this.btnSearch.BorderRadius = 20;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::BankSys_UI.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(136, 200);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 45);
            this.btnSearch.TabIndex = 174;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 172;
            this.label5.Text = "Account ID";
            // 
            // txtAccountID
            // 
            this.txtAccountID.Animated = true;
            this.txtAccountID.BorderColor = System.Drawing.Color.DarkGray;
            this.txtAccountID.BorderRadius = 20;
            this.txtAccountID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountID.DefaultText = "";
            this.txtAccountID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccountID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccountID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAccountID.ForeColor = System.Drawing.Color.Black;
            this.txtAccountID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountID.Location = new System.Drawing.Point(73, 48);
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.PlaceholderText = "";
            this.txtAccountID.SelectedText = "";
            this.txtAccountID.Size = new System.Drawing.Size(208, 42);
            this.txtAccountID.TabIndex = 171;
            this.txtAccountID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAccountID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountID_KeyPress);
            this.txtAccountID.Validating += new System.ComponentModel.CancelEventHandler(this.txtSerialNumber_Validating);
            // 
            // frmFindSerialNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 601);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.gpSerialNumber);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFindSerialNumber";
            this.Text = "frmFindSerialNumber";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.gpSerialNumber.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblWarning;
        private Guna.UI2.WinForms.Guna2GroupBox gpSerialNumber;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2ImageButton pbEye;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountID;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}