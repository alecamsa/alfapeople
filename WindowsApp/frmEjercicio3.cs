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

namespace WindowsApp
{
    public partial class frmEjercicio3 : Form
    {
        public frmEjercicio3()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkFile1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string location = string.Format(@"{0}{1}", AppDomain.CurrentDomain.BaseDirectory, @"XPP\getBaseByTotalDays.xpp");
            Process.Start(location);
        }

        private void lnkFile3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string location = string.Format(@"{0}{1}", AppDomain.CurrentDomain.BaseDirectory, @"XPP\WhileQuery.xpp");
            Process.Start(location);
        }

        private void lnkFile2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string location = string.Format(@"{0}{1}", AppDomain.CurrentDomain.BaseDirectory, @"XPP\PurchLine_OnActivated.xpp");
            Process.Start(location);
        }
    }
}
