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
using Guna.UI2.WinForms;
using static BankSys_UI.GlobalSettings;

namespace BankSys_UI
{
    public partial class frmChangePermissions : Form
    {
        UserBusiness _User;
        public frmChangePermissions()
        {
            InitializeComponent();
        }

        private void _LoadUserPermissions()
        {
            ResetDefaultPermissions();

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
                    chbDelete.Checked = true;

                if (permissions.HasFlag(enPermissions.Find))
                    chbFind.Checked = true;

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

            if (!((Guna2CheckBox)sender).Checked)
                chbTransactionFullAccess.Checked = false;
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

        private void ResetDefaultPermissions()
        {
            chbAdmin.Checked = false;
            
            chbMemberFullAccess.Checked = false;
            chbAddNew.Checked = false;
            chbEdit.Checked = false;
            chbDelete.Checked = false;
            chbFind.Checked = false;
            chbShowAll.Checked = false;
            chbFind.Checked = false;

            chbUserFullAccess.Checked = false;
            chbAccountFullAccess.Checked = false;

            chbTransactionFullAccess.Checked = false;
            chbDeposit.Checked = false;
            chbWithdraw.Checked = false;
            chbTransfer.Checked = false;;
        }

        private void ctrlSearchUser1_UserFoundByIDEvent(int UserID)
        {
            _User = UserBusiness.GetUserByID(UserID);
            
            if (_User == null)
            {
                MessageBox.Show("No User Found", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmMain.openChildForm(new frmUsers());
            }

            ctrlUserDetails1.LoadInfo(UserID);
            _LoadUserPermissions();
            gbPermissions.Enabled = true;
        }

        private void ctrlSearchUser1_UserFoundByUsernameEvent(string Username)
        {
            _User = UserBusiness.GetUserByUsername(Username);

            if (_User == null)
            {
                MessageBox.Show("No User Found", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmMain.openChildForm(new frmUsers());
            }

            ctrlUserDetails1.LoadInfo(Username);
            _LoadUserPermissions();
            gbPermissions.Enabled = true;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.Permissions = _GetUserPermissions();

            if (_User.ChangePermissions(_User.Permissions))
            {
                MessageBox.Show("User permissions saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctrlUserDetails1.LoadInfo(_User.UserID);
            }
            else
            {
                MessageBox.Show("User permissions wasn't Saved Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}