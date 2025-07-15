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
    public partial class frmEmailMember : Form
    {
        MemberBusiness _Member;

        public frmEmailMember()
        {
            InitializeComponent();
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                e.Cancel = true;
                txtTitle.Focus();
                errorProvider1.SetError(txtTitle, "This field cannot be empty");
            }
            else
                errorProvider1.SetError(txtTitle, null);
        }

        private void txtBody_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBody.Text))
            {
                e.Cancel = true;
                txtBody.Focus();
                errorProvider1.SetError(txtBody, "This field cannot be empty");
            }
            else
                errorProvider1.SetError(txtBody, null);
        }

        private void brnReset_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtBody.Text = "";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (GlobalSettings.SendEmail(_Member, txtTitle.Text.Trim(), txtBody.Text.Trim()))
            {
                txtTitle.Text = "";
                txtBody.Text = "";

                MessageBox.Show("Email sent successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Email wasn't sent", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctrlSearchMember1_MemberFoundEvent(int MemberID)
        {
            _Member = MemberBusiness.GetMemberByID(MemberID);
          
            if (_Member.Email == "")
            {
                MessageBox.Show("The selected member hasn't provide an email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            ctrlMemberDetails1.LoadInfo(MemberID);
            btnNext.Visible = true;
            tpEmailInfo.Enabled = true;
        }

        private void frmEmailMember_Load(object sender, EventArgs e)
        {
            tpEmailInfo.Enabled = false;
            txtTitle.Text = "";
            txtBody.Text = "";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tcSendEmail.SelectedIndex = 1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tcSendEmail.SelectedIndex = 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtBody.Text = "";
        }
    }
}