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
    public partial class frmDeleteAccount : Form
    {
        public frmDeleteAccount()
        {
            InitializeComponent();
        }

        private void ctrlSearchAccount1_AccountFoundByIDEvent(int AccountID)
        {
            ctrlAccountDetails1.LoadInfo(AccountID);
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this account?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                if (AccountBusiness.DeleteAccount(ctrlAccountDetails1.AccountID))
                {
                    MessageBox.Show("Account deleted successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    ctrlAccountDetails1.ResetDefaultValues();
                    btnDelete.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Account wasn't deleted successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}