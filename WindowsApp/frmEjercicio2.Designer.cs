namespace WindowsApp
{
    partial class frmEjercicio2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEjercicio2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCountries = new System.Windows.Forms.ComboBox();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.gvUniversidades = new System.Windows.Forms.DataGridView();
            this.lblTxtQtyRecords = new System.Windows.Forms.Label();
            this.lblQtyRecords = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.lnkReadme = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUniversidades)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione el país:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Se obtendrá un listado de universidades por país ";
            // 
            // cbCountries
            // 
            this.cbCountries.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCountries.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCountries.FormattingEnabled = true;
            this.cbCountries.Location = new System.Drawing.Point(170, 54);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(256, 21);
            this.cbCountries.TabIndex = 5;
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(442, 41);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(115, 46);
            this.btnGetInfo.TabIndex = 6;
            this.btnGetInfo.Text = "Obtener Universidades";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 60);
            this.panel1.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnExit.Location = new System.Drawing.Point(586, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gvUniversidades
            // 
            this.gvUniversidades.AllowUserToAddRows = false;
            this.gvUniversidades.AllowUserToDeleteRows = false;
            this.gvUniversidades.AllowUserToResizeRows = false;
            this.gvUniversidades.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvUniversidades.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvUniversidades.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvUniversidades.GridColor = System.Drawing.Color.White;
            this.gvUniversidades.Location = new System.Drawing.Point(0, 113);
            this.gvUniversidades.MultiSelect = false;
            this.gvUniversidades.Name = "gvUniversidades";
            this.gvUniversidades.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvUniversidades.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvUniversidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvUniversidades.Size = new System.Drawing.Size(725, 203);
            this.gvUniversidades.TabIndex = 8;
            // 
            // lblTxtQtyRecords
            // 
            this.lblTxtQtyRecords.AutoSize = true;
            this.lblTxtQtyRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtQtyRecords.Location = new System.Drawing.Point(12, 97);
            this.lblTxtQtyRecords.Name = "lblTxtQtyRecords";
            this.lblTxtQtyRecords.Size = new System.Drawing.Size(94, 13);
            this.lblTxtQtyRecords.TabIndex = 9;
            this.lblTxtQtyRecords.Text = "Cantidad registros:";
            // 
            // lblQtyRecords
            // 
            this.lblQtyRecords.AutoSize = true;
            this.lblQtyRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtyRecords.Location = new System.Drawing.Point(104, 97);
            this.lblQtyRecords.Name = "lblQtyRecords";
            this.lblQtyRecords.Size = new System.Drawing.Size(13, 13);
            this.lblQtyRecords.TabIndex = 10;
            this.lblQtyRecords.Text = "0";
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.Red;
            this.lblLoading.Location = new System.Drawing.Point(188, 78);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(202, 13);
            this.lblLoading.TabIndex = 11;
            this.lblLoading.Text = "CARGANDO LISTADO DE PAISES";
            // 
            // lnkReadme
            // 
            this.lnkReadme.AutoSize = true;
            this.lnkReadme.Location = new System.Drawing.Point(611, 74);
            this.lnkReadme.Name = "lnkReadme";
            this.lnkReadme.Size = new System.Drawing.Size(71, 13);
            this.lnkReadme.TabIndex = 12;
            this.lnkReadme.TabStop = true;
            this.lnkReadme.Text = "Abrir Readme";
            this.lnkReadme.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReadme_LinkClicked);
            // 
            // frmEjercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 376);
            this.Controls.Add(this.lnkReadme);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.lblQtyRecords);
            this.Controls.Add(this.lblTxtQtyRecords);
            this.Controls.Add(this.gvUniversidades);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGetInfo);
            this.Controls.Add(this.cbCountries);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEjercicio2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio #2: Manejo de APIs";
            this.Load += new System.EventHandler(this.frmEjercicio2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvUniversidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCountries;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView gvUniversidades;
        private System.Windows.Forms.Label lblTxtQtyRecords;
        private System.Windows.Forms.Label lblQtyRecords;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.LinkLabel lnkReadme;
    }
}