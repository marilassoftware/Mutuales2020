namespace Mutuales2020.Reportes.Prestamos
{
    partial class frmReportePrestamos
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
            this.btnGenrarInforme = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cboTipoReporte = new System.Windows.Forms.ComboBox();
            this.lblTipoReporte = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rptReportesPrestamos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtmFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.dtmFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenrarInforme
            // 
            this.btnGenrarInforme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenrarInforme.Location = new System.Drawing.Point(728, 32);
            this.btnGenrarInforme.Name = "btnGenrarInforme";
            this.btnGenrarInforme.Size = new System.Drawing.Size(128, 24);
            this.btnGenrarInforme.TabIndex = 55;
            this.btnGenrarInforme.Text = "Generar Reporte";
            this.btnGenrarInforme.Click += new System.EventHandler(this.btnGenrarInforme_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(7, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 40);
            this.panel1.TabIndex = 33;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(8, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(856, 38);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REPORTES DE PRÉSTAMOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboTipoReporte
            // 
            this.cboTipoReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoReporte.Items.AddRange(new object[] {
            "",
            "01-Préstamos Activos.",
            "02-Préstamos Anulados.",
            "03-Préstamos Registrados.",
            "04-Préstamos Registrados a una persona.",
            "05-Préstamos Registrados en un rango de fecha.",
            "06-Préstamos Registrados Detallados en un rango de fecha.",
            "07-Préstamos Registrados Detallados a una persona.",
            "08-Prestamos Cancelados detallados en un rango de fecha.",
            "09-Préstamos cartera vencida x edades.",
            "10-Informe para la equidad.",
            "11-Préstamos Agrupados por linea Registrados en un rango de fecha.",
            "12-Saldos de préstamos hasta una determinada fecha.",
            "13-Creditos con abonos."});
            this.cboTipoReporte.Location = new System.Drawing.Point(64, 8);
            this.cboTipoReporte.Name = "cboTipoReporte";
            this.cboTipoReporte.Size = new System.Drawing.Size(328, 21);
            this.cboTipoReporte.TabIndex = 37;
            this.cboTipoReporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboTipoReporte_KeyPress);
            // 
            // lblTipoReporte
            // 
            this.lblTipoReporte.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoReporte.Location = new System.Drawing.Point(5, 8);
            this.lblTipoReporte.Name = "lblTipoReporte";
            this.lblTipoReporte.Size = new System.Drawing.Size(59, 16);
            this.lblTipoReporte.TabIndex = 36;
            this.lblTipoReporte.Text = "Reporte";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rptReportesPrestamos);
            this.panel2.Controls.Add(this.dtmFechaFinal);
            this.panel2.Controls.Add(this.lblFechaFinal);
            this.panel2.Controls.Add(this.dtmFechaInicial);
            this.panel2.Controls.Add(this.lblFechaInicial);
            this.panel2.Controls.Add(this.txtCedula);
            this.panel2.Controls.Add(this.lblCedula);
            this.panel2.Controls.Add(this.btnGenrarInforme);
            this.panel2.Controls.Add(this.cboTipoReporte);
            this.panel2.Controls.Add(this.lblTipoReporte);
            this.panel2.Location = new System.Drawing.Point(7, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 444);
            this.panel2.TabIndex = 34;
            // 
            // rptReportesPrestamos
            // 
            this.rptReportesPrestamos.Location = new System.Drawing.Point(8, 64);
            this.rptReportesPrestamos.Name = "rptReportesPrestamos";
            this.rptReportesPrestamos.Size = new System.Drawing.Size(848, 368);
            this.rptReportesPrestamos.TabIndex = 65;
            // 
            // dtmFechaFinal
            // 
            this.dtmFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFechaFinal.Location = new System.Drawing.Point(648, 8);
            this.dtmFechaFinal.Name = "dtmFechaFinal";
            this.dtmFechaFinal.Size = new System.Drawing.Size(78, 20);
            this.dtmFechaFinal.TabIndex = 64;
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.Location = new System.Drawing.Point(570, 9);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(80, 16);
            this.lblFechaFinal.TabIndex = 63;
            this.lblFechaFinal.Text = "Fecha Final";
            // 
            // dtmFechaInicial
            // 
            this.dtmFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFechaInicial.Location = new System.Drawing.Point(483, 9);
            this.dtmFechaInicial.Name = "dtmFechaInicial";
            this.dtmFechaInicial.Size = new System.Drawing.Size(82, 20);
            this.dtmFechaInicial.TabIndex = 62;
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicial.Location = new System.Drawing.Point(402, 9);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(82, 16);
            this.lblFechaInicial.TabIndex = 61;
            this.lblFechaInicial.Text = "Fecha Inicial";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(781, 9);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(72, 20);
            this.txtCedula.TabIndex = 60;
            // 
            // lblCedula
            // 
            this.lblCedula.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(731, 10);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(48, 16);
            this.lblCedula.TabIndex = 59;
            this.lblCedula.Text = "Cedula";
            // 
            // frmReportePrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 501);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportePrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de préstamos";
            this.Load += new System.EventHandler(this.frmReportePrestamos_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenrarInforme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.ComboBox cboTipoReporte;
        private System.Windows.Forms.Label lblTipoReporte;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer rptReportesPrestamos;
        private System.Windows.Forms.DateTimePicker dtmFechaFinal;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.DateTimePicker dtmFechaInicial;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblCedula;
    }
}