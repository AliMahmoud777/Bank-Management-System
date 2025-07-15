namespace BankSys_UI
{
    partial class ctrlSearchAccount
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
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtAccountID = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtAccountID
            // 
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
            this.txtAccountID.Location = new System.Drawing.Point(27, 16);
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtAccountID.PlaceholderText = "Account ID";
            this.txtAccountID.SelectedText = "";
            this.txtAccountID.Size = new System.Drawing.Size(302, 45);
            this.txtAccountID.TabIndex = 3;
            this.txtAccountID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAccountID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountID_KeyPress);
            this.txtAccountID.Validating += new System.ComponentModel.CancelEventHandler(this.txtAccountID_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlSearchAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtAccountID);
            this.Name = "ctrlSearchAccount";
            this.Size = new System.Drawing.Size(412, 88);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
