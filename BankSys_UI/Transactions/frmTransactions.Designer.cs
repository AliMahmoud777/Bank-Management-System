namespace BankSys_UI
{
    partial class frmTransactions
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
            this.btnShowAllTransactions = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnShow = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowAllTransactions
            // 
            this.btnShowAllTransactions.Animated = true;
            this.btnShowAllTransactions.BackColor = System.Drawing.Color.Transparent;
            this.btnShowAllTransactions.BorderColor = System.Drawing.Color.Olive;
            this.btnShowAllTransactions.BorderRadius = 20;
            this.btnShowAllTransactions.BorderThickness = 3;
            this.btnShowAllTransactions.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.btnShowAllTransactions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowAllTransactions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowAllTransactions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowAllTransactions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowAllTransactions.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowAllTransactions.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllTransactions.ForeColor = System.Drawing.Color.Black;
            this.btnShowAllTransactions.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnShowAllTransactions.Location = new System.Drawing.Point(71, 428);
            this.btnShowAllTransactions.Name = "btnShowAllTransactions";
            this.btnShowAllTransactions.Size = new System.Drawing.Size(290, 61);
            this.btnShowAllTransactions.TabIndex = 21;
            this.btnShowAllTransactions.Text = "Show All Transactions";
            this.btnShowAllTransactions.Click += new System.EventHandler(this.btnShowAllTransactions_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 35F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(171, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 56);
            this.label1.TabIndex = 18;
            this.label1.Text = "Manage Transactions";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Gray;
            this.guna2GroupBox1.Controls.Add(this.btnShow);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.OliveDrab;
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(87, 229);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(168, 140);
            this.guna2GroupBox1.TabIndex = 24;
            this.guna2GroupBox1.Text = "Deposit";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox1.TextOffset = new System.Drawing.Point(0, 100);
            // 
            // btnShow
            // 
            this.btnShow.Animated = true;
            this.btnShow.BackColor = System.Drawing.Color.Transparent;
            this.btnShow.BorderColor = System.Drawing.Color.DimGray;
            this.btnShow.BorderRadius = 20;
            this.btnShow.BorderThickness = 2;
            this.btnShow.CheckedState.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnShow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShow.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnShow.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Black;
            this.btnShow.HoverState.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.btnShow.Image = global::BankSys_UI.Properties.Resources.deposit;
            this.btnShow.ImageSize = new System.Drawing.Size(45, 45);
            this.btnShow.Location = new System.Drawing.Point(33, 23);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(102, 61);
            this.btnShow.TabIndex = 22;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.Gray;
            this.guna2GroupBox2.Controls.Add(this.guna2Button1);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Brown;
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Location = new System.Drawing.Point(303, 229);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(168, 140);
            this.guna2GroupBox2.TabIndex = 25;
            this.guna2GroupBox2.Text = "Withdraw";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox2.TextOffset = new System.Drawing.Point(0, 100);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.IndianRed;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.guna2Button1.Image = global::BankSys_UI.Properties.Resources.cash_withdrawal;
            this.guna2Button1.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2Button1.Location = new System.Drawing.Point(34, 23);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(102, 61);
            this.guna2Button1.TabIndex = 22;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.Gray;
            this.guna2GroupBox3.Controls.Add(this.guna2Button2);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.DarkSlateBlue;
            this.guna2GroupBox3.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox3.Location = new System.Drawing.Point(521, 229);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(168, 140);
            this.guna2GroupBox3.TabIndex = 26;
            this.guna2GroupBox3.Text = "Transfer";
            this.guna2GroupBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox3.TextOffset = new System.Drawing.Point(0, 100);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderColor = System.Drawing.Color.DimGray;
            this.guna2Button2.BorderRadius = 20;
            this.guna2Button2.BorderThickness = 2;
            this.guna2Button2.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.guna2Button2.Image = global::BankSys_UI.Properties.Resources.money_transfer;
            this.guna2Button2.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2Button2.Location = new System.Drawing.Point(34, 23);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(102, 61);
            this.guna2Button2.TabIndex = 22;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderColor = System.Drawing.Color.Olive;
            this.guna2Button3.BorderRadius = 20;
            this.guna2Button3.BorderThickness = 3;
            this.guna2Button3.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.Silver;
            this.guna2Button3.Location = new System.Drawing.Point(414, 428);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(290, 61);
            this.guna2Button3.TabIndex = 27;
            this.guna2Button3.Text = "Transaction Types Details";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 601);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.btnShowAllTransactions);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransactions";
            this.Text = "frmTransactions";
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnShow;
        private Guna.UI2.WinForms.Guna2Button btnShowAllTransactions;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
    }
}