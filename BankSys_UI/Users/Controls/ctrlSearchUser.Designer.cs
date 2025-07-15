namespace BankSys_UI
{
    partial class ctrlSearchUser
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
            this.txtSearchValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbSearchBy = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.BorderRadius = 20;
            this.txtSearchValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchValue.DefaultText = "";
            this.txtSearchValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchValue.ForeColor = System.Drawing.Color.Black;
            this.txtSearchValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchValue.Location = new System.Drawing.Point(186, 21);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearchValue.PlaceholderText = "User ID";
            this.txtSearchValue.SelectedText = "";
            this.txtSearchValue.Size = new System.Drawing.Size(302, 45);
            this.txtSearchValue.TabIndex = 3;
            this.txtSearchValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchValue_KeyPress);
            this.txtSearchValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtSearchValue_Validating);
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
            this.btnSearch.Location = new System.Drawing.Point(503, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(48, 45);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // cbSearchBy
            // 
            this.cbSearchBy.BackColor = System.Drawing.Color.Transparent;
            this.cbSearchBy.BorderRadius = 10;
            this.cbSearchBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchBy.FillColor = System.Drawing.Color.Gainsboro;
            this.cbSearchBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearchBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearchBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSearchBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSearchBy.ItemHeight = 30;
            this.cbSearchBy.Items.AddRange(new object[] {
            "User ID",
            "Username"});
            this.cbSearchBy.Location = new System.Drawing.Point(18, 24);
            this.cbSearchBy.Name = "cbSearchBy";
            this.cbSearchBy.Size = new System.Drawing.Size(144, 36);
            this.cbSearchBy.StartIndex = 0;
            this.cbSearchBy.TabIndex = 10;
            this.cbSearchBy.SelectedIndexChanged += new System.EventHandler(this.cbSearchBy_SelectedIndexChanged);
            // 
            // ctrlSearchUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbSearchBy);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchValue);
            this.Name = "ctrlSearchUser";
            this.Size = new System.Drawing.Size(561, 88);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchValue;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearchBy;
    }
}
