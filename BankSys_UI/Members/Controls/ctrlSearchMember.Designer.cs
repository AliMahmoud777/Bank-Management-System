namespace BankSys_UI
{
    partial class ctrlSearchMember
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtMemberID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMemberID
            // 
            this.txtMemberID.BorderRadius = 20;
            this.txtMemberID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMemberID.DefaultText = "";
            this.txtMemberID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMemberID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMemberID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMemberID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMemberID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMemberID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMemberID.ForeColor = System.Drawing.Color.Black;
            this.txtMemberID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMemberID.Location = new System.Drawing.Point(27, 16);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtMemberID.PlaceholderText = "Member ID";
            this.txtMemberID.SelectedText = "";
            this.txtMemberID.Size = new System.Drawing.Size(302, 45);
            this.txtMemberID.TabIndex = 1;
            this.txtMemberID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMemberID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMemberID_KeyPress);
            this.txtMemberID.Validating += new System.ComponentModel.CancelEventHandler(this.txtMemberID_Validating);
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
            this.btnSearch.Location = new System.Drawing.Point(344, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(48, 45);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // ctrlSearchMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtMemberID);
            this.Name = "ctrlSearchMember";
            this.Size = new System.Drawing.Size(412, 88);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtMemberID;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
