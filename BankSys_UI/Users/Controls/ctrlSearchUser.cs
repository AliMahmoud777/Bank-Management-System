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

namespace BankSys_UI
{
    public partial class ctrlSearchUser : UserControl
    {
        public delegate void UserFoundByID(int UserID);
        public event UserFoundByID UserFoundByIDEvent;

        public delegate void UserFoundByUsername(string Username);
        public event UserFoundByUsername UserFoundByUsernameEvent;

        public string txtSearchValueString
        {
            set
            {
                txtSearchValue.Text = value;
            }
        }

        public ctrlSearchUser()
        {
            InitializeComponent();
        }

        private bool FindByUserID()
        {
            int UserID = Convert.ToInt32(txtSearchValue.Text);

            if (UserBusiness.IsUserExists(UserID))
            {
                UserFoundByIDEvent?.Invoke(UserID);
                return true;
            }
            else
            {
                MessageBox.Show("No User With ID: " + UserID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool FindByUsername()
        {
            string Username = txtSearchValue.Text;

            if (UserBusiness.IsUserExists(Username))
            {
                UserFoundByUsernameEvent?.Invoke(Username);
                return true;
            }
            else
            {
                MessageBox.Show("No User With Username: " + Username, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void _Find()
        {
            switch (cbSearchBy.SelectedIndex)
            {
                case 0:
                    FindByUserID();
                    break;

                case 1:
                    FindByUsername();
                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Search field isn't valid!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Find();
        }

        private void cbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchValue.Text = "";

            if (cbSearchBy.SelectedIndex == 0)
                txtSearchValue.PlaceholderText = "User ID";
            else
                txtSearchValue.PlaceholderText = "Username";
        }

        private void txtSearchValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchValue.Text.Trim()))
            {
                e.Cancel = true;
                txtSearchValue.Focus();
                errorProvider1.SetError(txtSearchValue, "This field isn't valid!");
            }
            else
            {
                errorProvider1.SetError(txtSearchValue, null);
            }
        }

        private void txtSearchValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSearch.PerformClick();
            }

            if (cbSearchBy.SelectedIndex == 0)
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}