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
    public partial class frmShowAllUsers : Form
    {
        private DataTable _dtUsers = UserBusiness.GetAllUsers();

        private void _RefreshUsersList()
        {
            _dtUsers = UserBusiness.GetAllUsers();
            dgvUsers.DataSource = _dtUsers;
            lblTotalUsers.Text = dgvUsers.Rows.Count.ToString();
        }

        public frmShowAllUsers()
        {
            InitializeComponent();
        }

        private void frmShowAllUsers_Load(object sender, EventArgs e)
        {
            _RefreshUsersList();

            cbFilter.SelectedIndex = 0;

            if (dgvUsers.Rows.Count > 0)
            {
                dgvUsers.Columns[0].HeaderText = "User ID";

                dgvUsers.Columns[1].HeaderText = "Member ID";

                dgvUsers.Columns[2].HeaderText = "Username";
                
                dgvUsers.Columns[3].HeaderText = "Full Name";
                
                dgvUsers.Columns[4].HeaderText = "Permissions";
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilter.Text != "None");
            txtFilterValue.Text = "";

            _RefreshUsersList();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterString = "";

            switch (cbFilter.Text)
            {
                case "User ID":
                    FilterString = "UserID";
                    break;

                case "Member ID":
                    FilterString = "MemberID";
                        break;

                case "Username":
                    FilterString = "Username";
                    break;

                case "Full Name":
                    FilterString = "FullName";
                    break;

                default:
                    FilterString = "None";
                    break;
            }

            if (txtFilterValue.Text.Trim() == "" || FilterString == "None")
            {
                _dtUsers.DefaultView.RowFilter = "";
                lblTotalUsers.Text = dgvUsers.Rows.Count.ToString();
                return;
            }

            if (FilterString == "UserID" || FilterString == "MemberID")
            {
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterString, txtFilterValue.Text.Trim());
            }
            else
            {
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterString, txtFilterValue.Text.Trim());
            }

            lblTotalUsers.Text = dgvUsers.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "User ID" || cbFilter.Text == "Member ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}