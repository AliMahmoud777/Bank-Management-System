using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BankSys_UI.GlobalSettings;

namespace BankSys_UI
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMain.openChildForm(new frmAddNewUser());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmMain.openChildForm(new frmSearchUser());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmMain.openChildForm(new frmDeleteUser());
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmMain.openChildForm(new frmFindUser());
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            frmMain.openChildForm(new frmShowAllUsers());
        }

        private void btnPermissions_Click(object sender, EventArgs e)
        {
            frmMain.openChildForm(new frmChangePermissions());
        }
    }
}