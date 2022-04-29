namespace WindowsApp
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBottomR = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.pnlMCenter = new System.Windows.Forms.Panel();
            this.lnkTask3 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkTask2 = new System.Windows.Forms.LinkLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lnkTask1 = new System.Windows.Forms.LinkLabel();
            this.imgTitle = new System.Windows.Forms.PictureBox();
            this.tmrUpdatePolizas = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.pnlBottomR.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.pnlMCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pnlBottomR);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 60);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Alejandro Campos Salas";
            // 
            // pnlBottomR
            // 
            this.pnlBottomR.Controls.Add(this.btnExit);
            this.pnlBottomR.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBottomR.Location = new System.Drawing.Point(778, 0);
            this.pnlBottomR.Name = "pnlBottomR";
            this.pnlBottomR.Size = new System.Drawing.Size(141, 58);
            this.pnlBottomR.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnExit.Location = new System.Drawing.Point(15, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.pnlMCenter);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 0);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(921, 440);
            this.pnlCenter.TabIndex = 3;
            // 
            // pnlMCenter
            // 
            this.pnlMCenter.Controls.Add(this.lnkTask3);
            this.pnlMCenter.Controls.Add(this.label1);
            this.pnlMCenter.Controls.Add(this.lnkTask2);
            this.pnlMCenter.Controls.Add(this.lblTitle);
            this.pnlMCenter.Controls.Add(this.lnkTask1);
            this.pnlMCenter.Controls.Add(this.imgTitle);
            this.pnlMCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMCenter.Location = new System.Drawing.Point(0, 0);
            this.pnlMCenter.Name = "pnlMCenter";
            this.pnlMCenter.Size = new System.Drawing.Size(921, 440);
            this.pnlMCenter.TabIndex = 10;
            // 
            // lnkTask3
            // 
            this.lnkTask3.AutoSize = true;
            this.lnkTask3.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkTask3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkTask3.LinkColor = System.Drawing.Color.SteelBlue;
            this.lnkTask3.Location = new System.Drawing.Point(625, 369);
            this.lnkTask3.Name = "lnkTask3";
            this.lnkTask3.Size = new System.Drawing.Size(125, 27);
            this.lnkTask3.TabIndex = 4;
            this.lnkTask3.TabStop = true;
            this.lnkTask3.Text = "Ejercicio #3";
            this.lnkTask3.VisitedLinkColor = System.Drawing.Color.SlateGray;
            this.lnkTask3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTask3_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aplicación Demo";
            // 
            // lnkTask2
            // 
            this.lnkTask2.AutoSize = true;
            this.lnkTask2.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkTask2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkTask2.LinkColor = System.Drawing.Color.SteelBlue;
            this.lnkTask2.Location = new System.Drawing.Point(374, 369);
            this.lnkTask2.Name = "lnkTask2";
            this.lnkTask2.Size = new System.Drawing.Size(125, 27);
            this.lnkTask2.TabIndex = 1;
            this.lnkTask2.TabStop = true;
            this.lnkTask2.Text = "Ejercicio #2";
            this.lnkTask2.VisitedLinkColor = System.Drawing.Color.SlateGray;
            this.lnkTask2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTask2_LinkClicked);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(294, 193);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(297, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "PRUEBA TECNICA";
            // 
            // lnkTask1
            // 
            this.lnkTask1.AutoSize = true;
            this.lnkTask1.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkTask1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkTask1.LinkColor = System.Drawing.Color.SteelBlue;
            this.lnkTask1.Location = new System.Drawing.Point(123, 369);
            this.lnkTask1.Name = "lnkTask1";
            this.lnkTask1.Size = new System.Drawing.Size(125, 27);
            this.lnkTask1.TabIndex = 0;
            this.lnkTask1.TabStop = true;
            this.lnkTask1.Text = "Ejercicio #1";
            this.lnkTask1.VisitedLinkColor = System.Drawing.Color.SlateGray;
            this.lnkTask1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTask1_LinkClicked);
            // 
            // imgTitle
            // 
            this.imgTitle.Image = ((System.Drawing.Image)(resources.GetObject("imgTitle.Image")));
            this.imgTitle.Location = new System.Drawing.Point(311, 65);
            this.imgTitle.Name = "imgTitle";
            this.imgTitle.Size = new System.Drawing.Size(262, 75);
            this.imgTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgTitle.TabIndex = 0;
            this.imgTitle.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 500);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo Alfa People";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBottomR.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            this.pnlMCenter.ResumeLayout(false);
            this.pnlMCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.LinkLabel lnkTask2;
        private System.Windows.Forms.LinkLabel lnkTask1;
        private System.Windows.Forms.Timer tmrUpdatePolizas;
        private System.Windows.Forms.LinkLabel lnkTask3;
        private System.Windows.Forms.Panel pnlMCenter;
        private System.Windows.Forms.Panel pnlBottomR;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox imgTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}