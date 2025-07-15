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
    public partial class frmMain : Form
    {
        static Form activeForm = null;
        public static Panel panelActiveForm = null;

        public frmMain()
        {
            InitializeComponent();

            panelActiveForm = panenlChildForm;
            openChildForm(new frmHome());
        }

        public static void openChildForm(Form childForm)
        {
            if (activeForm != null && panelActiveForm.Controls[3].GetType() == childForm.GetType())
                return;

            if (activeForm != null)
                activeForm.Close();

            childForm.TopLevel = false;
            panelActiveForm.Controls.Add(childForm);
            activeForm = childForm;
            activeForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUsername.Text = CurrentUser.Username;

            if (CurrentUser.ImagePath != "")
                pbUserImage.ImageLocation = CurrentUser.ImagePath;
            else
                pbUserImage.Image = Resources.Male_512;

            if (CurrentUser.Permissions == -1)
                lblAdmin.Visible = true;
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
            openChildForm(new frmMembers());
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHome());
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
            openChildForm(new frmHelp());
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
            if (AccessValidation(enPermissions.Users))
                openChildForm(new frmUsers());
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private void userDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            openChildForm(new frmFindUser(CurrentUser.UserID));
            AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            CurrentUser = null;
            activeForm = null;
            LoginForm.Show();
            LoginForm.TriggerLoadEvent();
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            guna2ContextMenuStrip1.Show(btnSettings, new Point(0, btnSettings.Height));
            AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            openChildForm(new frmChangePassword(CurrentUser.UserID));
            AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            if (AccessValidation(enPermissions.Accounts))
                openChildForm(new frmAccounts());
            AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private void btnLogRegistry_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            openChildForm(new frmLogRegistry());
            AutoValidate = AutoValidate.EnableAllowFocusChange;
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            openChildForm(new frmTransactions());
            AutoValidate = AutoValidate.EnableAllowFocusChange;
        }
    }
}