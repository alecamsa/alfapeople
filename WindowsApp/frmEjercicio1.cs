using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Models;
using WindowsApp.Utils;

namespace WindowsApp
{
    public partial class frmEjercicio1 : Form
    {
        public frmEjercicio1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenFileDialog openBrowseFile = new OpenFileDialog
            {
                InitialDirectory = ConfigurationManager.AppSettings["XmlInitialDirectory"].ToString(),                
                Title = "Seleccione archivo XML",
                DefaultExt = "xml",
                Filter = "xml files(*.xml) | *.xml",
                FilterIndex = 2,
                RestoreDirectory = true,
            };

            if (openBrowseFile.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = openBrowseFile.FileName;
            }
            txtJsonFormat.Clear();
            btnSaveJson.Enabled = false;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFileName.Text))
            {
                MessageBox.Show("Debe de seleccionar un archivo tipo XML");
            }
            else
            {
                if (MessageBox.Show(string.Format("Desea procesar el archivo {0}", txtFileName.Text), "Procesar archvivo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        FileInfo file = new FileInfo(txtFileName.Text);
                        if (file.Extension != ".xml")
                        {
                            MessageBox.Show("La extensión del archivo es incorrecta. Seleccione un archivo XML");
                        }
                        else
                        {
                            string fileText = System.IO.File.ReadAllText(txtFileName.Text);
                            XmlUtility xmlUtility = new XmlUtility();
                            txtJsonFormat.Text = xmlUtility.DeserializeXml(fileText);
                            btnSaveJson.Enabled = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(string.Format("Se produjo un error procesando el archivo. Error: {0}", ex.Message));
                        btnSaveJson.Enabled = false;
                    }
                }
            }
        }

        private void btnSaveJson_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    InitialDirectory = ConfigurationManager.AppSettings["JsonOutputDirectory"].ToString(),
                    Title = "Guardar archivo JSON",
                    DefaultExt = "json",
                    Filter = "json files(*.json) | *.json",
                    FilterIndex = 2,
                    CheckPathExists = true,
                };
                saveFileDialog.ShowDialog();
                if (saveFileDialog.FileName != "")
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, true)) //// true to append data to the file
                    {
                        writer.WriteLine(txtJsonFormat.Text);
                        MessageBox.Show("Se ha guardado el archivo de manera satisfactoria.");
                    }
                }
                else
                {
                    MessageBox.Show("Debe de indicar el nombre con el que desea salvar el archivo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Se produjo un error procesando el archivo. Error: {0}", ex.Message));
            }
        }

        private void lnkReadme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string location = string.Format(@"{0}{1}", AppDomain.CurrentDomain.BaseDirectory, @"Readme\Ejercicio1.txt");
            Process.Start(location);
        }
    }
}
