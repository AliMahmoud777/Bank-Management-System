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
    public partial class ctrlSearchMember : UserControl
    {
        public delegate void MemberFound(int MemberID);
        public event MemberFound MemberFoundEvent;

        public string txtMemberIDString
        {
            set
            {
                txtMemberID.Text = value;
            }
        }

        public ctrlSearchMember()
        {
            InitializeComponent();
        }

        private bool Find()
        {
            int MemberID = Convert.ToInt32(txtMemberID.Text);

            if (MemberBusiness.IsMemberExists(MemberID))
            {
                MemberFoundEvent?.Invoke(MemberID);
                return true;
            }
            else
            {
                MessageBox.Show("No Member With ID: " + MemberID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Member ID field isn't valid!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Find();
        }

        private void txtMemberID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMemberID.Text.Trim()))
            {
                e.Cancel = true;
                txtMemberID.Focus();
                errorProvider1.SetError(txtMemberID, "This field isn't valid!");
            }
            else
            {
                errorProvider1.SetError(txtMemberID, null);
            }
        }

        private void txtMemberID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSearch.PerformClick();
            }

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
