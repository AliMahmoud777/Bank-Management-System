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
    public partial class frmShowAccountTransactions : Form
    {
        int _AccountID = -1;
        DataTable _dtAccountTransactions = null;
        public frmShowAccountTransactions(int AccountID)
        {
            InitializeComponent();

            _AccountID = AccountID;
        }

        private void RefreshAccountTransactionsList()
        {
            _dtAccountTransactions = TransactionBusiness.GetAccountTransaction(_AccountID);
            dgvTransactions.DataSource = _dtAccountTransactions;
            lblTotalTransactions.Text = _dtAccountTransactions.Rows.Count.ToString();
        }

        private void frmShowAccountTransactions_Load(object sender, EventArgs e)
        {
            RefreshAccountTransactionsList();

            cbFilter.SelectedIndex = 0;

            if (dgvTransactions.Rows.Count > 0)
            {
                dgvTransactions.Columns[0].HeaderText = "Transaction ID";

                dgvTransactions.Columns[1].HeaderText = "Account ID";

                dgvTransactions.Columns[4].HeaderText = "Type";
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "None")
            {
                RefreshAccountTransactionsList();
                return;
            }

            if (cbFilter.Text == "Transfer")
                dgvTransactions.DataSource = TransactionBusiness.GetAccountTransfers(_AccountID);
            else
            {
                dgvTransactions.DataSource = _dtAccountTransactions;
                _dtAccountTransactions.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", "TypeName", cbFilter.Text);
            }

            lblTotalTransactions.Text = dgvTransactions.Rows.Count.ToString();
        }
    }
}