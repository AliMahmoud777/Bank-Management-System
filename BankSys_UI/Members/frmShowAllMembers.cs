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
    public partial class frmShowAllMembers : Form
    {
        private DataTable _dtMembers = MemberBusiness.GetAllMembers();

        private void _RefreshMembersList()
        {
            _dtMembers = MemberBusiness.GetAllMembers();
            dgvMembers.DataSource = _dtMembers;
            lblTotalMembers.Text = dgvMembers.Rows.Count.ToString();
        }
        public frmShowAllMembers()
        {
            InitializeComponent();
        }

        private void frmShowAllMembers_Load(object sender, EventArgs e)
        {
            _RefreshMembersList();

            cbFilter.SelectedIndex = 0;

            if (dgvMembers.Rows.Count > 0)
            {
                dgvMembers.Columns[0].HeaderText = "Member ID";

                dgvMembers.Columns[1].HeaderText = "First Name";

                dgvMembers.Columns[2].HeaderText = "Last Name";

                dgvMembers.Columns[3].HeaderText = "Country";

                dgvMembers.Columns[4].HeaderText = "Gender";
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilter.Text != "None");
            txtFilterValue.Text = "";

            _RefreshMembersList();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterString = "";

            switch (cbFilter.Text)
            {
                case "Member ID":
                    FilterString = "MemberID";
                    break;

                case "First Name":
                    FilterString = "FirstName";
                    break;

                case "Second Name":
                    FilterString = "SecondName";
                    break;

                case "Country":
                    FilterString = "Country";
                    break;

                case "Gender":
                    FilterString = "GenderString";
                    break;

                default:
                    FilterString = "None";
                    break;
            }

            if(txtFilterValue.Text.Trim() == "" || FilterString == "None")
            {
                _dtMembers.DefaultView.RowFilter = "";
                lblTotalMembers.Text = dgvMembers.Rows.Count.ToString();
                return;
            }

            if (FilterString == "MemberID")
            {
                _dtMembers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterString, txtFilterValue.Text.Trim());
            }
            else
            {
                _dtMembers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterString, txtFilterValue.Text.Trim());
            }

            lblTotalMembers.Text = dgvMembers.Rows.Count.ToString();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Member ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
    }
}