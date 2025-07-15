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
    public partial class frmFindAccount : Form
    {
        public frmFindAccount()
        {
            InitializeComponent();
        }

        private void ctrlSearchAccount1_AccountFoundByIDEvent(int AccountID)
        {
            ctrlAccountDetails1.LoadInfo(AccountID);
        }
    }
}