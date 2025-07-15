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
    public partial class frmMembers : Form
    {
        public frmMembers()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (AccessValidation(enPermissions.Add))
                frmMain.openChildForm(new frmAddNewMember());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (AccessValidation(enPermissions.Edit))
                frmMain.openChildForm(new frmSearchMember());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (AccessValidation(enPermissions.Delete))
                frmMain.openChildForm(new frmDeleteMember());
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (AccessValidation(enPermissions.Find))
                frmMain.openChildForm(new frmFindMember());
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (AccessValidation(enPermissions.ShowAll))
                frmMain.openChildForm(new frmShowAllMembers());
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            if (AccessValidation(enPermissions.Email))
                frmMain.openChildForm(new frmEmailMember());
        }
    }
}