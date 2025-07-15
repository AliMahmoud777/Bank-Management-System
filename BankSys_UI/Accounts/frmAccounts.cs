using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSys_UI.Accounts;
using static BankSys_UI.GlobalSettings;

namespace BankSys_UI
{
    public partial class frmAccounts : Form
    {
        public frmAccounts()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMain.openChildForm(new frmAddNewAccount());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmMain.openChildForm(new frmSearchAccount(frmSearchAccount.enDestinationForm.frmEdit));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmMain.openChildForm(new frmDeleteAccount());
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmMain.openChildForm(new frmFindAccount());
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            frmMain.openChildForm(new frmShowAllAccounts());
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            frmMain.openChildForm(new frmSearchAccount(frmSearchAccount.enDestinationForm.frmAccountTransaction));
        }

        private void btnFindSerialNumber_Click(object sender, EventArgs e)
        {
            frmMain.openChildForm(new frmFindSerialNumber());
        }
    }
}