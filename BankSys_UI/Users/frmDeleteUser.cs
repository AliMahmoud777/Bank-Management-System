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

namespace BankSys_UI
{
    public partial class frmDeleteUser : Form
    {
        public frmDeleteUser()
        {
            InitializeComponent();
        }

        private void ctrlSearchUser1_UserFoundByIDEvent(int UserID)
        {
            ctrlUserDetails1.LoadInfo(UserID);
            btnDelete.Enabled = true;
        }

        private void ctrlSearchUser1_UserFoundByUsernameEvent(string Username)
        {
            ctrlUserDetails1.LoadInfo(Username);
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this user", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                if (UserBusiness.DeleteUser(ctrlUserDetails1.UserID))
                {
                    MessageBox.Show("User deleted successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ctrlUserDetails1.ResetDefaultValues();
                    btnDelete.Enabled = false;
                }
                else
                {
                    MessageBox.Show("User wasn't deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}