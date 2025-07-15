using BankSys_Business;
using Guna.UI2.WinForms;
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

namespace BankSys_UI
{
    public partial class frmDeposit : Form
    {
        AccountBusiness _Account;
        public frmDeposit()
        {
            InitializeComponent();
        }

        private void frmDeposit_Load(object sender, EventArgs e)
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
                txtDepositAmount.Enabled = true;
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

        private void txtDepositAmount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDepositAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDepositAmount.Text.Trim()))
            {
                e.Cancel = true;
                txtDepositAmount.Focus();
                errorProvider1.SetError(txtDepositAmount, "This field cannot be empty");
                return;
            }
            else
            {
                errorProvider1.SetError(txtDepositAmount, null);
            }

            if (Convert.ToDecimal(txtDepositAmount.Text) > 5000 || Convert.ToDecimal(txtDepositAmount.Text) < 100)
            {
                e.Cancel = true;
                txtDepositAmount.Focus();
                errorProvider1.SetError(txtDepositAmount, "Deposit Amount must be within the range of $100 and $5000");
            }
            else
            {
                errorProvider1.SetError(txtDepositAmount, null);
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Account.Deposit(Convert.ToDecimal(txtDepositAmount.Text), GlobalSettings.CurrentUser.UserID))
            {
                lblBalance.Text = "$" + _Account.Balance.ToString();
                txtDepositAmount.Text = "";

                MessageBox.Show("Deposit operation completed successfully. Current Balance: $" + _Account.Balance, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Deposit operation wasn't completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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