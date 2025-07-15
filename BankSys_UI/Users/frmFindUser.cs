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
    public partial class frmFindUser : Form
    {
        private int _UserID = -1;
        public frmFindUser(int UserID = -1)
        {
            InitializeComponent();

            _UserID = UserID;
        }

        private void ctrlSearchUser1_UserFoundByIDEvent(int UserID)
        {
            ctrlUserDetails1.LoadInfo(UserID);
        }

        private void ctrlSearchUser1_UserFoundByUsernameEvent(string Username)
        {
            ctrlUserDetails1.LoadInfo(Username);
        }

        private void frmFindUser_Load(object sender, EventArgs e)
        {
            if (_UserID != -1)
            {
                ctrlUserDetails1.LoadInfo(_UserID);
                ctrlSearchUser1.txtSearchValueString = _UserID.ToString();
            }
        }
    }
}