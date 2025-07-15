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
    public partial class frmSearchUser : Form
    {
        public frmSearchUser()
        {
            InitializeComponent();
        }

        private void ctrlSearchUser1_UserFoundByIDEvent(int UserID)
        {
            frmMain.openChildForm(new frmAddNewUser(UserID));
        }

        private void ctrlSearchUser1_UserFoundByUsernameEvent(string Username)
        {
            frmMain.openChildForm(new frmAddNewUser(Username));
        }
    }
}