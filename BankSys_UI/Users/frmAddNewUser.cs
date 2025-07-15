using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSys_Business;
using BankSys_UI.Properties;
using Guna.UI2.WinForms;
using static BankSys_UI.GlobalSettings;

namespace BankSys_UI
{
    public partial class frmAddNewUser : Form
    {
        enum enMode { Add, Update };
        enMode _Mode = enMode.Add;

        private int _UserID = -1;
        private string _Username = null;
        private UserBusiness _User;

        public frmAddNewUser(int UserID = -1)
        {
            InitializeComponent();

            if (UserID != -1)
            {
                _UserID = UserID;
                _Mode = enMode.Update;
            }
        }

        public frmAddNewUser(string Username)
        {
            InitializeComponent();

            _Username = Username;
            _Mode = enMode.Update;
        }

        private void _LoadUserPermissions()
        {
            enPermissions permissions = (enPermissions)_User.Permissions;

            if (permissions == enPermissions.None)
                return;

            if (permissions == enPermissions.Admin)
            {
                chbAdmin.Checked = true;
                return;
            }

            if (permissions.HasFlag(enPermissions.MemberFullAccess))
            {
                chbMemberFullAccess.Checked = true;
            }
            else
            {
                if (permissions.HasFlag(enPermissions.Add))
                    chbAddNew.Checked = true;

                if (permissions.HasFlag(enPermissions.Edit))
                    chbEdit.Checked = true;

                if (permissions.HasFlag(enPermissions.Delete))
                    chbFind.Checked = true;

                if (permissions.HasFlag(enPermissions.Find))
                    chbDelete.Checked = true;

                if (permissions.HasFlag(enPermissions.ShowAll))
                    chbShowAll.Checked = true;

                if (permissions.HasFlag(enPermissions.Email))
                    chbEmail.Checked = true;
            }

            if (permissions.HasFlag(enPermissions.TransactionFullAccess))
            {
                chbTransactionFullAccess.Checked = true;
            }
            else
            {
                if (permissions.HasFlag(enPermissions.Deposit))
                    chbDeposit.Checked = true;

                if (permissions.HasFlag(enPermissions.Withdraw))
                    chbWithdraw.Checked = true;

                if (permissions.HasFlag(enPermissions.Transfer))
                    chbTransfer.Checked = true;
            }

            if (permissions.HasFlag(enPermissions.Users))
                chbUserFullAccess.Checked = true;

            if (permissions.HasFlag(enPermissions.Accounts))
                chbAccountFullAccess.Checked = true;
        }

        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.Add)
                _User = new UserBusiness();

            tpUserInfo.Enabled = false;
            btnNext.Visible = false;

            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";

            panelUserID.Visible = false;

            chbAdmin.Checked = false;

            chbMemberFullAccess.Checked = false;
            chbAddNew.Checked = false;
            chbEdit.Checked = false;
            chbDelete.Checked = false;
            chbFind.Checked = false;
            chbShowAll.Checked = false;
            chbEmail.Checked = false;

            chbUserFullAccess.Checked = false;
            chbAccountFullAccess.Checked = false;

            chbTransactionFullAccess.Checked = false;
            chbDeposit.Checked = false;
            chbWithdraw.Checked = false;
            chbTransfer.Checked = false;

            pbUserImage.ImageLocation = null;
            pbUserImage.Image = Resources.Male_512;
            llRemove.Visible = false;
        }

        private int _GetUserPermissions()
        {
            enPermissions permissions = enPermissions.None;

            if (chbAdmin.Checked)
            {
                return -1;
            }

            if (chbMemberFullAccess.Checked)
            {
                permissions |= enPermissions.MemberFullAccess;
            }
            else
            {
                if (chbAddNew.Checked)
                    permissions |= enPermissions.Add;

                if (chbEdit.Checked)
                    permissions |= enPermissions.Edit;

                if (chbDelete.Checked)
                    permissions |= enPermissions.Delete;

                if (chbFind.Checked)
                    permissions |= enPermissions.Find;

                if (chbShowAll.Checked)
                    permissions |= enPermissions.ShowAll;

                if (chbEmail.Checked)
                    permissions |= enPermissions.Email;
            }

            if (chbTransactionFullAccess.Checked)
            {
                permissions |= enPermissions.TransactionFullAccess;
            }
            else
            {
                if (chbDeposit.Checked)
                    permissions |= enPermissions.Deposit;

                if (chbWithdraw.Checked)
                    permissions |= enPermissions.Withdraw;

                if (chbTransfer.Checked)
                    permissions |= enPermissions.Transfer;
            }

            if (chbUserFullAccess.Checked)
                permissions |= enPermissions.Users;

            if (chbAccountFullAccess.Checked)
                permissions |= enPermissions.Accounts;


            return (int)permissions;
        }

        private void LoadUserData()
        {
            if (_UserID != -1)
                _User = UserBusiness.GetUserByID(_UserID);
            else
                _User = UserBusiness.GetUserByUsername(_Username);

            if (_User == null)
            {
                MessageBox.Show("No User Found", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmMain.openChildForm(new frmUsers());
            }

            _UserID = _User.UserID;
            _Username = _User.Username;

            tpUserInfo.Enabled = true;
            btnNext.Visible = true;
            ctrlSearchMember1.Enabled = false;
            ctrlSearchMember1.txtMemberIDString = _User.Member.MemberID.ToString();
            ctrlMemberDetails1.LoadInfo(_User.Member.MemberID);

            lblUserID.Text = _User.UserID.ToString();
            panelUserID.Visible = true;

            txtUsername.Text = _User.Username;
            txtPassword.Text = PasswordDecryption(_User.Password);
            txtConfirmPassword.Text = txtPassword.Text;

            if (_User.ImagePath != null && _User.ImagePath != "")
            {
                pbUserImage.ImageLocation = _User.ImagePath;
                llRemove.Visible = true;
            }

            _LoadUserPermissions();
        }

        private void frmAddNewUser_Load(object sender, EventArgs e)
        {
            pbEye1.PressedState.ImageSize = pbEye1.ImageSize;
            pbEye2.PressedState.ImageSize = pbEye2.ImageSize;

            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                LoadUserData();
        }

        private void chbMemberFullAccess_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMemberFullAccess.Checked)
            {
                chbAddNew.Checked = true;
                chbEdit.Checked = true;
                chbDelete.Checked = true;
                chbFind.Checked = true;
                chbShowAll.Checked = true;
                chbEmail.Checked = true;
            }
        }

        private void chbTransactionFullAccess_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTransactionFullAccess.Checked)
            {
                chbDeposit.Checked = true;
                chbWithdraw.Checked = true;
                chbTransfer.Checked = true;
            }
        }

        private void llRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbUserImage.ImageLocation = null;

            pbUserImage.Image = Resources.Male_512;

            llRemove.Visible = false;
        }

        private void _HandleMemberFullAccessCheckBox(object sender, EventArgs e)
        {
            if (chbAddNew.Checked && chbEdit.Checked && chbDelete.Checked && chbFind.Checked && chbShowAll.Checked
                && chbEmail.Checked)
                chbMemberFullAccess.Checked = true;

            if (!((Guna2CheckBox)sender).Checked)
                chbMemberFullAccess.Checked = false;
        }

        private void _HandleTransactionFullAccessCheckBox(object sender, EventArgs e)
        {
            if (chbDeposit.Checked && chbWithdraw.Checked && chbTransfer.Checked)
                chbTransactionFullAccess.Checked = true;

            if(!((Guna2CheckBox)sender).Checked)
               chbTransactionFullAccess.Checked = false;
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbUserImage.ImageLocation = openFileDialog1.FileName;
                llRemove.Visible = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";

            chbAdmin.Checked = false;

            chbMemberFullAccess.Checked = false;
            chbAddNew.Checked = false;
            chbEdit.Checked = false;
            chbDelete.Checked = false;
            chbFind.Checked = false;
            chbShowAll.Checked = false;
            chbEmail.Checked = false;

            chbUserFullAccess.Checked = false;
            chbAccountFullAccess.Checked = false;

            chbTransactionFullAccess.Checked = false;
            chbDeposit.Checked = false;
            chbWithdraw.Checked = false;
            chbTransfer.Checked = false;

            pbUserImage.ImageLocation = null;
            pbUserImage.Image = Resources.Male_512;
            llRemove.Visible = false;
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text.Trim()))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "This field cannot be empty");
            }
            else
            {
                errorProvider1.SetError(txtUsername, null);
            }

            if (txtUsername.Text.Trim() != _User.Username && UserBusiness.IsUserExists(txtUsername.Text.Trim()))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "This Username is used for another user");
            }
            else
            {
                errorProvider1.SetError(txtUsername, null);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.Member = MemberBusiness.GetMemberByID(ctrlMemberDetails1.MemberID);
            _User.Username = txtUsername.Text.Trim();
            _User.Password = PasswordEncryption(txtPassword.Text.Trim());
            _User.ImagePath = pbUserImage.ImageLocation;

            _User.Permissions = _GetUserPermissions();

            if (_User.Save())
            {
                _Mode = enMode.Update;
                lblUserID.Text = _User.UserID.ToString();
                panelUserID.Visible = true;
                ctrlSearchMember1.Enabled = false;

                MessageBox.Show("User saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("User wasn't Saved Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (_Mode == enMode.Update)
            {
                tcGeneralInfo.SelectedIndex = 1;
                return;
            }

            if (UserBusiness.IsUserExistsByMemberID(ctrlMemberDetails1.MemberID))
            {
                MessageBox.Show("Selected Member is already a user, choose another one", "Select another Member", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tpUserInfo.Enabled = true;
                tcGeneralInfo.SelectedIndex = 1;
            }
        }

        private void chbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAdmin.Checked)
            {
                gbMember.Enabled = false;
                gbUser.Enabled = false;
                gbAccount.Enabled = false;
                gbTransaction.Enabled = false;
            }
            else
            {
                gbMember.Enabled = true;
                gbUser.Enabled = true;
                gbAccount.Enabled = true;
                gbTransaction.Enabled = true;
            }
        }
    }
}