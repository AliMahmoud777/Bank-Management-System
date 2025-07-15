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
    public partial class frmShowAllTransactions : Form
    {
        DataTable _dtTransactions = TransactionBusiness.GetAllTransactions();

        public frmShowAllTransactions()
        {
            InitializeComponent();
        }

        public void RefreshTransactionsList()
        {
            _dtTransactions = TransactionBusiness.GetAllTransactions();
            dgvTransactions.DataSource = _dtTransactions;
            lblTotalTransactions.Text = dgvTransactions.Rows.Count.ToString();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "None")
            {
                RefreshTransactionsList();
                return;
            }

            if (cbFilter.Text == "Transfer")
                dgvTransactions.DataSource = TransactionBusiness.GetAllTransfers();
            else
            {
                dgvTransactions.DataSource = _dtTransactions;
                _dtTransactions.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", "TypeName", cbFilter.Text);
            }

            lblTotalTransactions.Text = dgvTransactions.Rows.Count.ToString();
        }

        private void frmShowAllTransactions_Load(object sender, EventArgs e)
        {
            RefreshTransactionsList();

            cbFilter.SelectedIndex = 0;

            if (dgvTransactions.Rows.Count > 0)
            {
                dgvTransactions.Columns[0].HeaderText = "Transaction ID";

                dgvTransactions.Columns[1].HeaderText = "Account ID";

                dgvTransactions.Columns[4].HeaderText = "Type";
            }
        }
    }
}