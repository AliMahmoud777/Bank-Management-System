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
    public partial class frmSearchAccount : Form
    {
        public enum enDestinationForm { frmEdit, frmAccountTransaction };
        private enDestinationForm _destinationForm;

        public frmSearchAccount(enDestinationForm DestinationForm)
        {
            InitializeComponent();

            _destinationForm = DestinationForm;
        }

        private void ctrlSearchAccount1_AccountFoundByIDEvent(int AccountID)
        {
            if (_destinationForm == enDestinationForm.frmEdit)
                frmMain.openChildForm(new frmAddNewAccount(AccountID));
            else
                frmMain.openChildForm(new frmShowAccountTransactions(AccountID));
        }
    }
}