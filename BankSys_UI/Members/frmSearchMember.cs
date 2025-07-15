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
    public partial class frmSearchMember : Form
    {
        public frmSearchMember()
        {
            InitializeComponent();
        }

        private void ctrlMemberSearch1_MemberFoundEvent(int MemberID)
        {
            frmMain.openChildForm(new frmAddNewMember(MemberID));
        }
    }
}
