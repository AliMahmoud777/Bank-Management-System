using BankSys_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSys_UI.Properties;
using static BankSys_UI.GlobalSettings;

namespace BankSys_UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string Username = "", Password = "";

            if (GlobalSettings.GetStoredCredentials(ref Username, ref Password))
            {
                txtUsername.Text = Username;
                txtPassword.Text = Password;
                chbRememberMe.Checked = true;
            }
            else
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
                chbRememberMe.Checked = false;
            }
        }

        public void TriggerLoadEvent()
        {
            frmLogin_Load(this, EventArgs.Empty);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (LoginValidation(txtUsername.Text.Trim(), txtPassword.Text.Trim()))
            {
                if (chbRememberMe.Checked)
                    GlobalSettings.RememberMe(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                else
                    GlobalSettings.RememberMe("", "");

                CurrentUser = UserBusiness.GetUserByUsername(txtUsername.Text.Trim());
                LoginForm = this;
                CurrentUser.AddToLogRegistry();
                WriteToEventLog();

                this.Hide();
                frmMain form = new frmMain();
                form.Show();
            }
        }

        private void pbEye_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;

            if (txtPassword.UseSystemPasswordChar)
                pbEye.Image = Resources.Eye_Closed;
            else
                pbEye.Image = Resources.Eye_Open;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}