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
using WindowsApp.Models;
using WindowsApp.Utils;

namespace WindowsApp
{
    public partial class frmEjercicio2 : Form
    {
        public frmEjercicio2()
        {
            InitializeComponent();
        }

        private async void frmEjercicio2_Load(object sender, EventArgs e)
        {
            lblLoading.Visible = true;
            cbCountries.Enabled = btnGetInfo.Enabled = false;
            
            var countriesList = await ApiLogic.CountriesGetAll();
            if (countriesList == null)
            {
                return;
            }
            var sortCountriesList = countriesList.OrderBy(x => x["name"]["common"]).ToList();
            sortCountriesList.ToList().ForEach(x =>
               {
                  cbCountries.Items.Add(x["name"]["common"].ToString());
               }
            );
            cbCountries.Enabled = btnGetInfo.Enabled = true;
            lblLoading.Visible = false;
        }

        private async void btnGetInfo_Click(object sender, EventArgs e)
        {
            var finalText = cbCountries.Text.Replace(" ", "+");
            if (string.IsNullOrEmpty(finalText))
            {
                MessageBox.Show("El nombre del país se encuentra vacío");
                return;
            }
            var universityList = await ApiLogic.UniversityInfoGetAll(finalText);
            if (universityList != null && universityList.Any())
            {
                lblQtyRecords.Text = universityList.Count().ToString();
                universityList = universityList.OrderBy(x => x.name).ToList();
                GvUniversitiesProperties(universityList);
            }
        }

        private void GvUniversitiesProperties(List<UniversityModel> response)
        {
            BindingSource bind = new BindingSource();
            if (response != null)
            {
                bind.DataSource = response;
                gvUniversidades.DataSource = bind;
                
                //Hide Columns
                gvUniversidades.Columns["alpha_two_code"].Visible = false;
                gvUniversidades.Columns["country"].Visible = false;
                gvUniversidades.Columns["StateProvince"].Visible = false;

                // Set Column Size
                gvUniversidades.Columns["name"].Width = 325;
                gvUniversidades.Columns["webpage"].Width = 325;

                // Set Column Headers Text
                gvUniversidades.Columns["name"].HeaderText = "NAME";
                gvUniversidades.Columns["webpage"].HeaderText = "WEB PAGE";
            }
            else
            {
                bind.DataSource = null;
                gvUniversidades.DataSource = bind;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkReadme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string location = string.Format(@"{0}{1}", AppDomain.CurrentDomain.BaseDirectory, @"Readme\Ejercicio2.txt");
            Process.Start(location);
        }
    }
}
