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
    public partial class frmShowTransactionTypes : Form
    {
        DataTable _dtTypes = TransactionTypeBusiness.GetAllTransactionTypes();

        public frmShowTransactionTypes()
        {
            InitializeComponent();
        }

        private void RefreshTransactionTypesList()
        {
            _dtTypes = TransactionTypeBusiness.GetAllTransactionTypes();
            dgvTypes.DataSource = _dtTypes;
        }

        private void frmShowTransactionTypes_Load(object sender, EventArgs e)
        {
            RefreshTransactionTypesList();

            if (dgvTypes.Rows.Count > 0)
                dgvTypes.Columns[0].HeaderText = "Type Name";
        }
    }
}