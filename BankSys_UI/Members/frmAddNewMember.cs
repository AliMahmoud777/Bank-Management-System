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
using Guna.UI2.WinForms;

namespace BankSys_UI
{
    public partial class frmAddNewMember : Form
    {
        enum enMode { Add, Update };
        enMode _Mode = enMode.Add;

        private int _MemberID = -1;
        private MemberBusiness _Member;

        public frmAddNewMember(int memberID = -1)
        {
            InitializeComponent();

            if (memberID != -1)
            {
                _MemberID = memberID;
                _Mode = enMode.Update;
            }
        }

        private void _FillComboBoxWithCountries()
        {
            DataTable dtCountries = CountryBusiness.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {
                cbCountry.Items.Add(row["Name"]);
            }
        }

        private void _ResetDefaultValues()
        {
            _FillComboBoxWithCountries();

            if (_Mode == enMode.Add)
                _Member = new MemberBusiness();

            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-90);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

            cbCountry.SelectedIndex = cbCountry.FindString("Italy");

            txtFirstName.Text = "";
            txtLastName.Text = "";
            rbMale.Checked = true;
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            txtAddress.Text = "";

            panelMemberID.Visible = false;
        }

        private void _LoadMemberData()
        {
            _Member = MemberBusiness.GetMemberByID(_MemberID);

            if (_Member == null)
            {
                MessageBox.Show("No Member with ID = " + _MemberID, "Member Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmMain.openChildForm(new frmMembers());
            }

            panelMemberID.Visible = true;

            lblMemberID.Text = _Member.MemberID.ToString();
            txtFirstName.Text = _Member.FirstName;
            txtLastName.Text = _Member.LastName;
            txtEmail.Text = _Member.Email;
            txtPhoneNumber.Text = _Member.PhoneNumber;
            txtAddress.Text = _Member.Address;

            dtpDateOfBirth.Value = _Member.DateOfBirth;

            if (_Member.Gender == false)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            cbCountry.SelectedIndex = cbCountry.FindString(_Member.Country.Name);
        }

        private void frmAddNewMember_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadMemberData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _ResetDefaultValues();
        }

        private void _ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            Guna2TextBox textbox = (Guna2TextBox)sender;

            if (string.IsNullOrWhiteSpace(textbox.Text.Trim()))
            {
                e.Cancel = true;
                textbox.Focus();
                errorProvider1.SetError(textbox, "This field cannot be empty");
            }
            else
            {
                errorProvider1.SetError(textbox, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if(txtEmail.Text.Trim() != "")
            {
                if (!ValidationSettings.ValidateEmail(txtEmail.Text.Trim()))
                {
                    e.Cancel = true;
                    txtEmail.Focus();
                    errorProvider1.SetError(txtEmail, "This email address isn't valid");
                }
                else
                {
                    e.Cancel = false;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Member.FirstName = txtFirstName.Text;
            _Member.LastName = txtLastName.Text;

            if (rbMale.Checked)
                _Member.Gender = false;
            else
                _Member.Gender = true;

            _Member.Email = txtEmail.Text;
            _Member.DateOfBirth = dtpDateOfBirth.Value;
            _Member.Country = CountryBusiness.GetCountryByName(cbCountry.Text);
            _Member.PhoneNumber = txtPhoneNumber.Text;
            _Member.Address = txtAddress.Text;

            if (_Member.Save())
            {
                _Mode = enMode.Update;
                lblMemberID.Text = _Member.MemberID.ToString();
                panelMemberID.Visible = true;

                MessageBox.Show("Member saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Member wasn't Saved Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}