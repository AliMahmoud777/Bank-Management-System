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
using Microsoft.Win32;
using BankSys_UI.Properties;

namespace BankSys_UI
{
    public partial class frmChangePassword : Form
    {
        private int _UserID;

        UserBusiness _User;
        public frmChangePassword(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
        }

        private void _ResetDefaultValues()
        {
            ctrlUserDetails1.LoadInfo(_UserID);
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtCurrentPassword.Focus();
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                txtCurrentPassword.Focus();
                errorProvider1.SetError(txtCurrentPassword, "This field cannot be empty");
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            }

            if(txtCurrentPassword.Text.Trim() != GlobalSettings.PasswordDecryption(ctrlUserDetails1.User.Password))
            {
                e.Cancel = true;
                txtCurrentPassword.Focus();
                errorProvider1.SetError(txtCurrentPassword, "Invalid Password");
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            }
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                txtNewPassword.Focus();
                errorProvider1.SetError(txtNewPassword, "This field cannot be empty");
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text.Trim() != txtNewPassword.Text.Trim())
            {
                e.Cancel = true;
                txtConfirmPassword.Focus();
                errorProvider1.SetError(txtConfirmPassword, "Confirm Password field must be the same as New Password field");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.Password = GlobalSettings.PasswordEncryption(txtNewPassword.Text.Trim());

            if (_User.Save())
            {
                try
                {
                    using(RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                    {
                        using(RegistryKey subKey = key.OpenSubKey(@"SOFTWARE\BankSys", true))
                        {
                            if (subKey != null)
                            {
                                subKey.SetValue("Password", _User.Password, RegistryValueKind.String);
                            }
                        }
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show($"UnauthorizedAccessException: Run the program with administrative privileges");
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                    return;
                }

                MessageBox.Show("Password changed successfully", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefaultValues();
            }
            else
            {
                MessageBox.Show("Password wasn't changed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            _User = UserBusiness.GetUserByID(_UserID);

            if (_User == null)
            {
                MessageBox.Show("Could not Find User with ID = " + _UserID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmMain.openChildForm(new frmHome());
                return;
            }

            ctrlUserDetails1.LoadInfo(_User.UserID);
        }

        private void pbEye1_Click(object sender, EventArgs e)
        {
            txtCurrentPassword.UseSystemPasswordChar = !txtCurrentPassword.UseSystemPasswordChar;

            if (txtCurrentPassword.UseSystemPasswordChar)
                pbEye1.Image = Resources.Eye_Closed;
            else
                pbEye1.Image = Resources.Eye_Open;
        }

        private void pbEye2_Click(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = !txtNewPassword.UseSystemPasswordChar;

            if (txtNewPassword.UseSystemPasswordChar)
                pbEye2.Image = Resources.Eye_Closed;
            else
                pbEye2.Image = Resources.Eye_Open;
        }

        private void pbEye3_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = !txtConfirmPassword.UseSystemPasswordChar;

            if (txtConfirmPassword.UseSystemPasswordChar)
                pbEye3.Image = Resources.Eye_Closed;
            else
                pbEye3.Image = Resources.Eye_Open;
        }
    }
}