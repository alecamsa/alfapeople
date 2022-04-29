using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Models;
using WindowsApp.Utils;

namespace WindowsApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Desea salir de la aplicación?", "Confirmar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private async void lnkTask1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEjercicio1 fmTask1 = new frmEjercicio1();
            fmTask1.ShowDialog();
            //await LoadData();
        }


        private async void frmMain_Load(object sender, EventArgs e)
        {
          
        }

        private void lnkTask2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEjercicio2 fmTask2 = new frmEjercicio2();
            fmTask2.ShowDialog();
        }

        private void lnkTask3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
