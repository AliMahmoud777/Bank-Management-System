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
    public partial class frmShowAllAccounts : Form
    {
        private DataTable _dtAccounts = AccountBusiness.GetAllAccounts();

        public frmShowAllAccounts()
        {
            InitializeComponent();
        }

        private void RefreshAccountsList()
        {
            _dtAccounts = AccountBusiness.GetAllAccounts();
            dgvAccounts.DataSource = _dtAccounts;
            lblTotalAccounts.Text = dgvAccounts.Rows.Count.ToString();
            lblTotalBalance.Text = "$" + _dtAccounts.Compute("SUM(Balance)", "").ToString();
        }

        private void frmShowAllAccounts_Load(object sender, EventArgs e)
        {
            RefreshAccountsList();

            cbFilter.SelectedIndex = 0;

            if (dgvAccounts.Rows.Count > 0)
            {
                dgvAccounts.Columns[0].HeaderText = "Account ID";

                dgvAccounts.Columns[1].HeaderText = "Member ID";

                dgvAccounts.Columns[2].HeaderText = "Full Name";

                dgvAccounts.Columns[3].HeaderText = "Balance";

                dgvAccounts.Columns[4].HeaderText = "Created Date";
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAccountsList();

            txtFilterValue.Visible = (cbFilter.Text != "None");
            txtFilterValue.Text = "";
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterString = "";

            switch (cbFilter.Text)
            {
                case "Account ID":
                    FilterString = "AccountID";
                    break;

                case "Member ID":
                    FilterString = "MemberID";
                    break;

                case "Full Name":
                    FilterString = "FullName";
                    break;

                default:
                    FilterString = "None";
                    break;
            }

            if (FilterString == "None" || txtFilterValue.Text.Trim() == "")
            {
                _dtAccounts.DefaultView.RowFilter = "";
                lblTotalAccounts.Text = dgvAccounts.Rows.Count.ToString();
                lblTotalBalance.Text = "$" + _dtAccounts.Compute("SUM(Balance)", "").ToString();
                return;
            }

            if (FilterString != "FullName")
                _dtAccounts.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterString, txtFilterValue.Text);
            else
                _dtAccounts.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterString, txtFilterValue.Text);

            lblTotalAccounts.Text = dgvAccounts.Rows.Count.ToString();

            var totalBalance = _dtAccounts.DefaultView.ToTable().Compute("SUM(Balance)", "");
            lblTotalBalance.Text = "$" + ((totalBalance is DBNull) ? "0" : totalBalance.ToString());
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text != "Full Name")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}