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
    public partial class frmLogRegistry : Form
    {
        private DataTable _dtLogs = UserBusiness.GetAllLogs();

        public frmLogRegistry()
        {
            InitializeComponent();
        }

        private void RefreshLogsList()
        {
            _dtLogs = UserBusiness.GetAllLogs();
            dgvLogRegistry.DataSource = _dtLogs;
        }

        private void frmLogRegistry_Load(object sender, EventArgs e)
        {
            RefreshLogsList();

            if (dgvLogRegistry.Rows.Count != 0)
            {
                dgvLogRegistry.Columns[0].HeaderText = "Log ID";

                dgvLogRegistry.Columns[1].HeaderText = "User ID";

                dgvLogRegistry.Columns[2].HeaderText = "Username";

                dgvLogRegistry.Columns[3].HeaderText = "Date";
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "")
            {
                _dtLogs.DefaultView.RowFilter = "";
                return;
            }

            _dtLogs.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", "Username", txtUsername.Text.Trim());
        }
    }
}