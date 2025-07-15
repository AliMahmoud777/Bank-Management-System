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
using Guna.UI2.WinForms;

namespace BankSys_UI
{
    public partial class frmAddNewAccount : Form
    {
        enum enMode { Add, Update };
        enMode _Mode = enMode.Add;

        int _AccountID = -1;
        AccountBusiness _Account;

        public frmAddNewAccount(int AccountID = -1)
        {
            InitializeComponent();

            if(AccountID != -1)
            {
                _AccountID = AccountID;
                _Mode = enMode.Update;
            }
        }

        private void ResetDefaultValues()
        {
            if (_Mode == enMode.Add)
                _Account = new AccountBusiness();

            tpAccountInfo.Enabled = false;
            btnNext.Visible = false;

            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            lblBalance.Text = "Initial Balance";
            txtBalance.Text = "";
            lblSerialNumber.Text = "XXXX-XXXX-XXXX-XXXX";
            lblUsername.Text = GlobalSettings.CurrentUser.Username;
            lblDate.Text = DateTime.Now.ToShortDateString();

            lblWarning.Visible = false;

            panelAccountID.Visible = false;
        }

        private void LoadAccountData()
        {
            _Account = AccountBusiness.GetAccountByID(_AccountID);

            if (_Account == null)
            {
                MessageBox.Show("No Account Found", "Account Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmMain.openChildForm(new frmAccounts());
            }

            tpAccountInfo.Enabled = true;
            btnNext.Visible = true;
            ctrlSearchMember1.Enabled = false;
            ctrlSearchMember1.txtMemberIDString = _Account.Member.MemberID.ToString();
            ctrlMemberDetails1.LoadInfo(_Account.Member.MemberID);

            lblAccountID.Text = _Account.AccountID.ToString();
            panelAccountID.Visible = true;

            txtPassword.Text = GlobalSettings.PasswordDecryption(_Account.Password);
            txtConfirmPassword.Text = txtPassword.Text;
            lblBalance.Text = "Current Balance";
            txtBalance.Text = _Account.Balance.ToString();
            panelBalance.Enabled = false;

            lblSerialNumber.Text = _Account.SerialNumber;

            lblWarning.Visible = true;

            lblUsername.Text = _Account.User.Username;
            lblDate.Text = _Account.CreatedDate.ToShortDateString();
        }

        private void frrmAddNewAccount_Load(object sender, EventArgs e)
        {
            ResetDefaultValues();

            if (_Mode == enMode.Update)
                LoadAccountData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";

            if (_Mode == enMode.Add)
                txtBalance.Text = "";
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

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                txtConfirmPassword.Focus();
                errorProvider1.SetError(txtConfirmPassword, "Confirm Password field must be the same as Password field");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

        private void pbEye1_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;

            if (txtPassword.UseSystemPasswordChar)
                pbEye1.Image = Resources.Eye_Closed;
            else
                pbEye1.Image = Resources.Eye_Open;
        }

        private void pbEye2_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = !txtConfirmPassword.UseSystemPasswordChar;

            if (txtConfirmPassword.UseSystemPasswordChar)
                pbEye2.Image = Resources.Eye_Closed;
            else
                pbEye2.Image = Resources.Eye_Open;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tcGeneralInfo.SelectedIndex = 0;
        }

        private void ctrlSearchMember1_MemberFoundEvent(int MemberID)
        {
            ctrlMemberDetails1.LoadInfo(MemberID);
            btnNext.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(_Mode == enMode.Update)
            {
                tcGeneralInfo.SelectedIndex = 1;
                return;
            }

            if (AccountBusiness.IsAccountExistsByMemberID(ctrlMemberDetails1.MemberID))
            {
                MessageBox.Show("Selected Member already has an account, choose another one", "Select another Member", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tpAccountInfo.Enabled = true;
                tcGeneralInfo.SelectedIndex = 1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Account.Member = MemberBusiness.GetMemberByID(ctrlMemberDetails1.MemberID);
            _Account.Password = GlobalSettings.PasswordEncryption(txtPassword.Text);
            _Account.Balance = Convert.ToDecimal(txtBalance.Text);
            _Account.CreatedDate = Convert.ToDateTime(lblDate.Text);
            _Account.User = UserBusiness.GetUserByUsername(lblUsername.Text);

            if (_Mode == enMode.Add)
                _Account.SerialNumber = GlobalSettings.GenerateSerialNumber();

            if (_Account.Save())
            {
                _Mode = enMode.Update;
                lblAccountID.Text = _Account.AccountID.ToString();
                panelAccountID.Visible = true;
                ctrlSearchMember1.Enabled = false;
                txtBalance.Enabled = false;
                lblBalance.Text = "Current Balance";

                lblSerialNumber.Text = _Account.SerialNumber;
                lblWarning.Visible = true;

                MessageBox.Show("Account saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Account wasn't Saved Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBalance_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBalance.Text.Trim()))
            {
                e.Cancel = true;
                txtBalance.Focus();
                errorProvider1.SetError(txtBalance, "This field cannot be empty");
            }
            else
            {
                errorProvider1.SetError(txtBalance, null);
            }
        }

        private void txtBalance_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}