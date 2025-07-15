using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSys_UI
{
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://github.com/AliMahmoud777", UseShellExecute = true });
        }

        private void btnLinkedIn_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://www.linkedin.com/in/ali-mahmoud-9b9595362", UseShellExecute = true });
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://www.facebook.com/Ali7Mahmoud", UseShellExecute = true });
        }
    }
}
