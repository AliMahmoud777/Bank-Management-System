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
    public partial class ctrlMemberDetails : UserControl
    {
        private int _MemberID = -1;
        public int MemberID
        {
            get { return _MemberID; }
        }

        MemberBusiness _Member;
        public ctrlMemberDetails()
        {
            InitializeComponent();
        }

        private void _LoadMemberData()
        {
            _MemberID = _Member.MemberID;

            lblMemberID.Text = _Member.MemberID.ToString();
            lblFullName.Text = _Member.FullName;
            lblGender.Text = _Member.GenderString;
            lblDateOfBirth.Text = _Member.DateOfBirth.ToShortDateString();
            lblCountry.Text = _Member.Country.Name;
            lblPhoneNumber.Text = _Member.PhoneNumber;
            lblEmail.Text = _Member.Email;
            lblAddress.Text = _Member.Address;
        }

        public void LoadInfo(int MemberID)
        {
            _Member = MemberBusiness.GetMemberByID(MemberID);

            if (_Member == null)
            {
                MessageBox.Show("No Member with ID = " + MemberID, "Member Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            _LoadMemberData();
        }

        public void ResetDefaultValues()
        {
            _MemberID = -1;

            lblMemberID.Text = "??";
            lblFullName.Text = "??";
            lblGender.Text = "??";
            lblDateOfBirth.Text = "??";
            lblCountry.Text = "??";
            lblPhoneNumber.Text = "??";
            lblEmail.Text = "??";
            lblAddress.Text = "??";
        }
    }
}
