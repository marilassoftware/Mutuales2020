namespace Mutuales2020.Creditos
{
    partial class frmProvisiondeCartera
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAccion = new System.Windows.Forms.Label();
            this.cboAccion = new System.Windows.Forms.ComboBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.dtmFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIni = new System.Windows.Forms.Label();
            this.rptProvisiondeCartera = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 40);
            this.panel1.TabIndex = 25;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(8, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(928, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REPORTE DE PROVISIÓN DE CARTERA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblAccion);
            this.panel2.Controls.Add(this.cboAccion);
            this.panel2.Controls.Add(this.btnProcesar);
            this.panel2.Controls.Add(this.dtmFechaFinal);
            this.panel2.Controls.Add(this.lblFechaFinal);
            this.panel2.Controls.Add(this.dtpFechaIni);
            this.panel2.Controls.Add(this.lblFechaIni);
            this.panel2.Controls.Add(this.rptProvisiondeCartera);
            this.panel2.Location = new System.Drawing.Point(3, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 464);
            this.panel2.TabIndex = 26;
            // 
            // lblAccion
            // 
            this.lblAccion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccion.Location = new System.Drawing.Point(400, 8);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(48, 23);
            this.lblAccion.TabIndex = 7;
            this.lblAccion.Text = "Acción";
            this.lblAccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboAccion
            // 
            this.cboAccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccion.FormattingEnabled = true;
            this.cboAccion.Items.AddRange(new object[] {
            "Consultar",
            "Procesar"});
            this.cboAccion.Location = new System.Drawing.Point(456, 8);
            this.cboAccion.Name = "cboAccion";
            this.cboAccion.Size = new System.Drawing.Size(128, 21);
            this.cboAccion.TabIndex = 2;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(600, 8);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 3;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // dtmFechaFinal
            // 
            this.dtmFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFechaFinal.Location = new System.Drawing.Point(288, 8);
            this.dtmFechaFinal.Name = "dtmFechaFinal";
            this.dtmFechaFinal.Size = new System.Drawing.Size(96, 20);
            this.dtmFechaFinal.TabIndex = 1;
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.Location = new System.Drawing.Point(208, 8);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(80, 23);
            this.lblFechaFinal.TabIndex = 3;
            this.lblFechaFinal.Text = "Fecha Final";
            this.lblFechaFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIni.Location = new System.Drawing.Point(96, 8);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(96, 20);
            this.dtpFechaIni.TabIndex = 0;
            // 
            // lblFechaIni
            // 
            this.lblFechaIni.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIni.Location = new System.Drawing.Point(8, 8);
            this.lblFechaIni.Name = "lblFechaIni";
            this.lblFechaIni.Size = new System.Drawing.Size(88, 23);
            this.lblFechaIni.TabIndex = 1;
            this.lblFechaIni.Text = "Fecha Inicial";
            this.lblFechaIni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rptProvisiondeCartera
            // 
            this.rptProvisiondeCartera.LocalReport.ReportEmbeddedResource = "Mutuales2020.Creditos.Reportes.rptProvisiondeCartera.rdlc";
            this.rptProvisiondeCartera.Location = new System.Drawing.Point(8, 40);
            this.rptProvisiondeCartera.Name = "rptProvisiondeCartera";
            this.rptProvisiondeCartera.Size = new System.Drawing.Size(932, 416);
            this.rptProvisiondeCartera.TabIndex = 0;
            // 
            // frmProvisiondeCartera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 519);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProvisiondeCartera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Provisión de Cartera";
            this.Load += new System.EventHandler(this.frmProvisiondeCartera_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer rptProvisiondeCartera;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.Label lblFechaIni;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.DateTimePicker dtmFechaFinal;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.ComboBox cboAccion;
    }
}