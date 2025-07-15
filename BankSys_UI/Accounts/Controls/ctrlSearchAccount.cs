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
    public partial class ctrlSearchAccount : UserControl
    {
        public delegate void AccountFoundByID(int AccountID);
        public event AccountFoundByID AccountFoundByIDEvent; 
        public ctrlSearchAccount()
        {
            InitializeComponent();
        }

        private bool Find()
        {
            int AccountID = Convert.ToInt32(txtAccountID.Text);

            if (AccountBusiness.IsAccountExists(AccountID))
            {
                AccountFoundByIDEvent.Invoke(AccountID);
                return true;
            }
            else
            {
                MessageBox.Show("No Account With ID: " + AccountID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Account ID field isn't valid!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Find();
        }

        private void txtAccountID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAccountID.Text.Trim()))
            {
                e.Cancel = true;
                txtAccountID.Focus();
                errorProvider1.SetError(txtAccountID, "This field isn't valid!");
            }
            else
            {
                errorProvider1.SetError(txtAccountID, null);
            }
        }

        private void txtAccountID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSearch.PerformClick();
            }

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}