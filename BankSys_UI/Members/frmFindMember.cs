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
    public partial class frmFindMember : Form
    {
        public frmFindMember()
        {
            InitializeComponent();
        }

        private void ctrlSearchMember1_MemberFoundEvent(int MemberID)
        {
            ctrlMemberDetails1.LoadInfo(MemberID);
        }
    }
}