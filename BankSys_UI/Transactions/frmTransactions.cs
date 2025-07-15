using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BankSys_UI.GlobalSettings;

namespace BankSys_UI
{
    public partial class frmTransactions : Form
    {
        public frmTransactions()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (AccessValidation(enPermissions.Deposit))
                frmMain.openChildForm(new frmDeposit());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (AccessValidation(enPermissions.Withdraw))
                frmMain.openChildForm(new frmWithdraw());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (AccessValidation(enPermissions.Transfer))
                frmMain.openChildForm(new frmTransfer());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            frmMain.openChildForm(new frmShowTransactionTypes());
        }

        private void btnShowAllTransactions_Click(object sender, EventArgs e)
        {
            frmMain.openChildForm(new frmShowAllTransactions());
        }
    }
}