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
    public partial class ctrlAccountDetails : UserControl
    {
        private int _AccountID = -1;
        public int AccountID
        {
            get { return _AccountID; }
        }

        AccountBusiness _Account;
        public AccountBusiness Account
        {
            get { return _Account; }
        }

        public ctrlAccountDetails()
        {
            InitializeComponent();
        }

        private void _LoadAccountData()
        {
            _AccountID = _Account.AccountID;

            lblAccountID.Text = _Account.AccountID.ToString();
            lblFullName.Text = _Account.Member.FullName;
            lblMemberID.Text = _Account.Member.FullName;
            lblBalance.Text = _Account.Balance.ToString();
            lblCreatedDate.Text = _Account.CreatedDate.ToShortDateString();
            lblPhoneNumber.Text = _Account.Member.PhoneNumber;
            lblCountry.Text = _Account.Member.Country.Name;
            lblGender.Text = _Account.Member.GenderString;
        }

        public void LoadInfo(int AccountID)
        {
            _Account = AccountBusiness.GetAccountByID(AccountID);

            if (_Account == null)
            {
                MessageBox.Show("No Account with ID = " + AccountID, "Account Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            _LoadAccountData();
        }

        public void ResetDefaultValues()
        {
            _AccountID = -1;

            lblAccountID.Text = "??";
            lblFullName.Text = "??";
            lblMemberID.Text = "??";
            lblBalance.Text = "??";
            lblCreatedDate.Text = "??";
            lblPhoneNumber.Text = "??";
            lblCountry.Text = "??";
            lblGender.Text = "??";
        }
    }
}