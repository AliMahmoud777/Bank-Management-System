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
using BankSys_UI.Properties;

namespace BankSys_UI
{
    public partial class ctrlUserDetails : UserControl
    {
        private int _UserID = -1;
        public int UserID
        {
            get { return _UserID; }
        }

        UserBusiness _User;

        public UserBusiness User
        {
            get { return _User; }
        }

        public ctrlUserDetails()
        {
            InitializeComponent();
        }

        private void _LoadUserData()
        {
            _UserID = _User.UserID;

            lblUserID.Text = _User.UserID.ToString();
            lblUsername.Text = _User.Username;
            lblFullName.Text = _User.Member.FullName;
            lblPermissions.Text = _User.Permissions.ToString();
            lblMemberID.Text = _User.Member.MemberID.ToString();
            lblCountry.Text = _User.Member.Country.Name;
            lblDateOfBirth.Text = _User.Member.DateOfBirth.ToShortDateString();
            lblAddress.Text = _User.Member.Address;

            if (_User.ImagePath != null && _User.ImagePath != "")
                pbUserImage.ImageLocation = _User.ImagePath;
            else
                pbUserImage.Image = Resources.Male_512;
        }

        public void LoadInfo(int UserID)
        {
            _User = UserBusiness.GetUserByID(UserID);

            if (_User == null)
            {
                MessageBox.Show("No User with ID = " + UserID, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            _LoadUserData();
        }

        public void LoadInfo(string Username)
        {
            _User = UserBusiness.GetUserByUsername(Username);

            if (_User == null)
            {
                MessageBox.Show("No User with Username = " + Username, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            _LoadUserData();
        }

        public void ResetDefaultValues()
        {
            _UserID = -1;

            lblUserID.Text = "??";
            lblUsername.Text = "??";
            lblFullName.Text = "??";
            lblPermissions.Text = "??";
            lblMemberID.Text = "??";
            lblCountry.Text = "??";
            lblDateOfBirth.Text = "??";
            lblAddress.Text = "??";

            pbUserImage.Image = Resources.Male_512;
        }
    }
}