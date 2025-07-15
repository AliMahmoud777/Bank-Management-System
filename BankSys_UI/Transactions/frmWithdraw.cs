using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using BankSys_Business;
using BankSys_UI.Properties;

namespace BankSys_UI
{
    public partial class frmWithdraw : Form
    {
        AccountBusiness _Account;
        public frmWithdraw()
        {
            InitializeComponent();
        }

        private void frmWithdraw_Load(object sender, EventArgs e)
        {
            lblUsername.Text = GlobalSettings.CurrentUser.Username;
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        private void LoadAccountData()
        {
            _Account = AccountBusiness.GetAccountBySerialNumber(txtSerialNumber.Text.Trim());

            lblAccountID.Text = _Account.AccountID.ToString();
            lblFullName.Text = _Account.Member.FullName;
            lblBalance.Text = "$" + _Account.Balance.ToString();
            lblCreatedDate.Text = _Account.CreatedDate.ToShortDateString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (GlobalSettings.AccountValidation(txtSerialNumber.Text.Trim(), txtPassword.Text.Trim()))
            {
                LoadAccountData();
                txtWithdrawAmount.Enabled = true;
            }
        }

        private void txtSerialNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSerialNumber.Text.Trim()))
            {
                e.Cancel = true;
                txtSerialNumber.Focus();
                errorProvider1.SetError(txtSerialNumber, "This field cannot be empty");
            }
            else
            {
                errorProvider1.SetError(txtSerialNumber, null);
            }
        }

        private void txtSerialNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && (sender as Guna2TextBox).Text.Count(c => c == '-') >= 3)
            {
                e.Handled = true;
            }
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

        private void txtWithdrawAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtWithdrawAmount.Text.Trim()))
            {
                e.Cancel = true;
                txtWithdrawAmount.Focus();
                errorProvider1.SetError(txtWithdrawAmount, "This field cannot be empty");
                return;
            }
            else
            {
                errorProvider1.SetError(txtWithdrawAmount, null);
            }

            if (Convert.ToDecimal(txtWithdrawAmount.Text) > 5000 || Convert.ToDecimal(txtWithdrawAmount.Text) < 50)
            {
                e.Cancel = true;
                txtWithdrawAmount.Focus();
                errorProvider1.SetError(txtWithdrawAmount, "Withdraw Amount must be within the range of $50 and $5000");
            }
            else
            {
                errorProvider1.SetError(txtWithdrawAmount, null);
            }
        }

        private void txtWithdrawAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && (sender as Guna2TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(_Account.Balance - Convert.ToDecimal(txtWithdrawAmount.Text) < 100)
            {
                MessageBox.Show("Withdraw amount cannot lead the total balance to be less than $100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Account.Withdraw(Convert.ToDecimal(txtWithdrawAmount.Text), GlobalSettings.CurrentUser.UserID))
            {
                lblBalance.Text = "$" + _Account.Balance.ToString();
                txtWithdrawAmount.Text = "";

                MessageBox.Show("Withdraw operation completed successfully. Current Balance: $" + _Account.Balance, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Withdraw operation wasn't completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
    }
}