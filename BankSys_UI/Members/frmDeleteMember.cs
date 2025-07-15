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
    public partial class frmDeleteMember : Form
    {
        public frmDeleteMember()
        {
            InitializeComponent();
        }

        private void ctrlSearchMember1_MemberFoundEvent(int MemberID)
        {
            ctrlMemberDetails1.LoadInfo(MemberID);
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this member", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                if (MemberBusiness.DeleteMember(ctrlMemberDetails1.MemberID))
                {
                    MessageBox.Show("Member deleted successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ctrlMemberDetails1.ResetDefaultValues();
                    btnDelete.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Member wasn't deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}