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
using System.Security.Principal;
using BankSys_UI.Properties;

namespace BankSys_UI
{
    public partial class frmTransfer : Form
    {
        AccountBusiness sourceAccount, destinationAccount;

        public frmTransfer()
        {
            InitializeComponent();
        }

        private void frmTransfer_Load(object sender, EventArgs e)
        {
            tpDestinationAccount.Enabled = false;

            lblUsername.Text = GlobalSettings.CurrentUser.Username;
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        private void LoadSourceAccountData()
        {
            sourceAccount = AccountBusiness.GetAccountBySerialNumber(txtsSerialNumber.Text.Trim());

            lblsAccountID.Text = sourceAccount.AccountID.ToString();
            lblsFullName.Text = sourceAccount.Member.FullName;
            lblsBalance.Text = "$" + sourceAccount.Balance.ToString();
            lblsCreatedDate.Text = sourceAccount.CreatedDate.ToShortDateString();
        }

        private void LoadDestinationAccountData()
        {
            destinationAccount = AccountBusiness.GetAccountBySerialNumber(txtdSerialNumber.Text.Trim());

            lbldAccountID.Text = destinationAccount.AccountID.ToString();
            lbldFullName.Text = destinationAccount.Member.FullName;
            lbldBalance.Text = "$" + destinationAccount.Balance.ToString();
            lbldCreatedDate.Text = destinationAccount.CreatedDate.ToShortDateString();
        }

        private void btnsSearch_Click(object sender, EventArgs e)
        {
            if (GlobalSettings.AccountValidation(txtsSerialNumber.Text.Trim(), txtsPassword.Text.Trim()))
            {
                LoadSourceAccountData();
                tpDestinationAccount.Enabled = true;
                btnNext.Visible = true;
            }
        }

        private void txtsSerialNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsSerialNumber.Text.Trim()))
            {
                e.Cancel = true;
                txtsSerialNumber.Focus();
                errorProvider1.SetError(txtsSerialNumber, "This field cannot be empty");
            }
            else
            {
                errorProvider1.SetError(txtsSerialNumber, null);
            }
        }

        private void txtsSerialNumber_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtsPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsPassword.Text.Trim()))
            {
                e.Cancel = true;
                txtsPassword.Focus();
                errorProvider1.SetError(txtsPassword, "This field cannot be empty");
            }
            else
            {
                errorProvider1.SetError(txtsPassword, null);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tpDestinationAccount.Enabled = true;
            tcTransfer.SelectedIndex = 1;
        }

        private void txtdSerialNumber_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtdPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtdPassword.Text.Trim()))
            {
                e.Cancel = true;
                txtdPassword.Focus();
                errorProvider1.SetError(txtdPassword, "This field cannot be empty");
            }
            else
            {
                errorProvider1.SetError(txtdPassword, null);
            }
        }

        private void txtTransferAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTransferAmount.Text.Trim()))
            {
                e.Cancel = true;
                txtTransferAmount.Focus();
                errorProvider1.SetError(txtTransferAmount, "This field cannot be empty");
                return;
            }
            else
            {
                errorProvider1.SetError(txtTransferAmount, null);
            }

            if (Convert.ToDecimal(txtTransferAmount.Text) > 5000 || Convert.ToDecimal(txtTransferAmount.Text) < 50)
            {
                e.Cancel = true;
                txtTransferAmount.Focus();
                errorProvider1.SetError(txtTransferAmount, "Transfer Amount must be within the range of $50 and $5000");
            }
            else
            {
                errorProvider1.SetError(txtTransferAmount, null);
            }
        }

        private void txtTransferAmount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (sourceAccount.Balance - Convert.ToDecimal(txtTransferAmount.Text) < 100)
            {
                MessageBox.Show("Transfer amount cannot lead Source Account's Balance to be less than $100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (AccountBusiness.Transfer(sourceAccount, destinationAccount, Convert.ToDecimal(txtTransferAmount.Text), GlobalSettings.CurrentUser.UserID))
            {
                lblsBalance.Text = "$" + sourceAccount.Balance.ToString();
                lbldBalance.Text = "$" + destinationAccount.Balance.ToString();
                txtTransferAmount.Text = "";

                MessageBox.Show(string.Format("Transfer operation completed successfully. Source Account's Current Balance: ${0}, Destination Account's Current Balance: ${1}", sourceAccount.Balance, destinationAccount.Balance),
                    "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Transfer operation wasn't completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btndSearch_Click(object sender, EventArgs e)
        {
            if (GlobalSettings.AccountValidation(txtdSerialNumber.Text.Trim(), txtdPassword.Text.Trim()))
            {
                if (txtdSerialNumber.Text == sourceAccount.SerialNumber)
                {
                    MessageBox.Show("You cannot select the same account to do the transfer operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LoadDestinationAccountData();
                txtTransferAmount.Enabled = true;
            }
        }

        private void pbEye1_Click(object sender, EventArgs e)
        {
            txtsPassword.UseSystemPasswordChar = !txtsPassword.UseSystemPasswordChar;

            if (txtsPassword.UseSystemPasswordChar)
                pbEye1.Image = Resources.Eye_Closed;
            else
                pbEye1.Image = Resources.Eye_Open;
        }

        private void pbEye2_Click(object sender, EventArgs e)
        {
            txtdPassword.UseSystemPasswordChar = !txtdPassword.UseSystemPasswordChar;

            if (txtdPassword.UseSystemPasswordChar)
                pbEye2.Image = Resources.Eye_Closed;
            else
                pbEye2.Image = Resources.Eye_Open;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tcTransfer.SelectedIndex = 0;
        }

        private void txtdSerialNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtdSerialNumber.Text.Trim()))
            {
                e.Cancel = true;
                txtdSerialNumber.Focus();
                errorProvider1.SetError(txtdSerialNumber, "This field cannot be empty");
            }
            else
            {
                errorProvider1.SetError(txtdSerialNumber, null);
            }
        }
    }
}