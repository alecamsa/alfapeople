namespace WindowsApp
{
    partial class frmEjercicio3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lnkFile1 = new System.Windows.Forms.LinkLabel();
            this.lnkFile2 = new System.Windows.Forms.LinkLabel();
            this.lnkFile3 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 8;
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
            // lnkFile1
            // 
            this.lnkFile1.AutoSize = true;
            this.lnkFile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkFile1.Location = new System.Drawing.Point(42, 99);
            this.lnkFile1.Name = "lnkFile1";
            this.lnkFile1.Size = new System.Drawing.Size(256, 26);
            this.lnkFile1.TabIndex = 13;
            this.lnkFile1.TabStop = true;
            this.lnkFile1.Text = "getBaseByTotalDays.xpp";
            this.lnkFile1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFile1_LinkClicked);
            // 
            // lnkFile2
            // 
            this.lnkFile2.AutoSize = true;
            this.lnkFile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkFile2.Location = new System.Drawing.Point(247, 190);
            this.lnkFile2.Name = "lnkFile2";
            this.lnkFile2.Size = new System.Drawing.Size(282, 26);
            this.lnkFile2.TabIndex = 14;
            this.lnkFile2.TabStop = true;
            this.lnkFile2.Text = "PurchLine_OnActivated.xpp";
            this.lnkFile2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFile2_LinkClicked);
            // 
            // lnkFile3
            // 
            this.lnkFile3.AutoSize = true;
            this.lnkFile3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkFile3.Location = new System.Drawing.Point(506, 99);
            this.lnkFile3.Name = "lnkFile3";
            this.lnkFile3.Size = new System.Drawing.Size(167, 26);
            this.lnkFile3.TabIndex = 15;
            this.lnkFile3.TabStop = true;
            this.lnkFile3.Text = "WhileQuery.xpp";
            this.lnkFile3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFile3_LinkClicked);
            // 
            // frmEjercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 376);
            this.Controls.Add(this.lnkFile3);
            this.Controls.Add(this.lnkFile2);
            this.Controls.Add(this.lnkFile1);
            this.Controls.Add(this.panel1);
            this.Name = "frmEjercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio #3: XPP";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.LinkLabel lnkFile1;
        private System.Windows.Forms.LinkLabel lnkFile2;
        private System.Windows.Forms.LinkLabel lnkFile3;
    }
}