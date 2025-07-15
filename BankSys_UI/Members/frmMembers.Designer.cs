namespace BankSys_UI
{
    partial class frmMembers
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
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.btnShow = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmail = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderColor = System.Drawing.Color.DimGray;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderThickness = 4;
            this.btnAdd.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnAdd.Location = new System.Drawing.Point(125, 235);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(220, 49);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add New Member";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 35F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(201, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manage Members";
            // 
            // btnEdit
            // 
            this.btnEdit.Animated = true;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BorderColor = System.Drawing.Color.DimGray;
            this.btnEdit.BorderRadius = 20;
            this.btnEdit.BorderThickness = 4;
            this.btnEdit.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnEdit.Location = new System.Drawing.Point(125, 323);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(220, 49);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit Member";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderColor = System.Drawing.Color.DimGray;
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.BorderThickness = 4;
            this.btnDelete.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnDelete.Location = new System.Drawing.Point(125, 411);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(220, 49);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Member";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFind
            // 
            this.btnFind.Animated = true;
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.BorderColor = System.Drawing.Color.DimGray;
            this.btnFind.BorderRadius = 20;
            this.btnFind.BorderThickness = 4;
            this.btnFind.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.btnFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFind.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnFind.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.Black;
            this.btnFind.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnFind.Location = new System.Drawing.Point(423, 235);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(220, 49);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "Find Member";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnShow
            // 
            this.btnShow.Animated = true;
            this.btnShow.BackColor = System.Drawing.Color.Transparent;
            this.btnShow.BorderColor = System.Drawing.Color.DimGray;
            this.btnShow.BorderRadius = 20;
            this.btnShow.BorderThickness = 4;
            this.btnShow.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.btnShow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShow.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnShow.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Black;
            this.btnShow.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnShow.Location = new System.Drawing.Point(423, 323);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(220, 49);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "Show All Members";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.Animated = true;
            this.btnEmail.BackColor = System.Drawing.Color.Transparent;
            this.btnEmail.BorderColor = System.Drawing.Color.DimGray;
            this.btnEmail.BorderRadius = 20;
            this.btnEmail.BorderThickness = 4;
            this.btnEmail.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.btnEmail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmail.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnEmail.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmail.ForeColor = System.Drawing.Color.Black;
            this.btnEmail.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnEmail.Location = new System.Drawing.Point(423, 411);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(220, 49);
            this.btnEmail.TabIndex = 9;
            this.btnEmail.Text = "Email Member";
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // frmMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 601);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMembers";
            this.Text = "frmMembers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnFind;
        private Guna.UI2.WinForms.Guna2Button btnShow;
        private Guna.UI2.WinForms.Guna2Button btnEmail;
    }
}