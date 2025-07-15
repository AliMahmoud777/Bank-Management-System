using BankSys_Business;
using BankSys_UI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSys_UI.Accounts
{
    public partial class frmFindSerialNumber : Form
    {
        public frmFindSerialNumber()
        {
            InitializeComponent();
        }

        private void txtSerialNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAccountID.Text.Trim()))
            {
                e.Cancel = true;
                txtAccountID.Focus();
                errorProvider1.SetError(txtAccountID, "This field cannot be empty");
            }
            else
            {
                errorProvider1.SetError(txtAccountID, null);
            }
        }

        private void txtAccountID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text.Trim()))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "This field cannot be empty");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (GlobalSettings.AccountValidation(Convert.ToInt32(txtAccountID.Text.Trim()), txtPassword.Text.Trim()))
            {
                lblSerialNumber.Text = AccountBusiness.GetAccountByID(Convert.ToInt32(txtAccountID.Text.Trim())).SerialNumber;
                lblWarning.Visible = true;
            }
        }
    }
}