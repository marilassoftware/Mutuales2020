namespace Mutuales2020.Reportes.Recibos
{
    partial class frmReportesRecibos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cboOtrosIngresos = new System.Windows.Forms.ComboBox();
            this.lblOtrosIngresos = new System.Windows.Forms.Label();
            this.txtCedula = new Texto.Texto();
            this.txtPrestamo = new Texto.Texto();
            this.lblPrestamo = new System.Windows.Forms.Label();
            this.rptReportesRecibo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.dtmFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.dtmFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.cboTipoReporte = new System.Windows.Forms.ComboBox();
            this.lblTipoReporte = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(8, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(872, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REPORTES DE RECIBOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboOtrosIngresos
            // 
            this.cboOtrosIngresos.DisplayMember = "strNomOtrosIngresos";
            this.cboOtrosIngresos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOtrosIngresos.Items.AddRange(new object[] {
            ""});
            this.cboOtrosIngresos.Location = new System.Drawing.Point(232, 40);
            this.cboOtrosIngresos.Name = "cboOtrosIngresos";
            this.cboOtrosIngresos.Size = new System.Drawing.Size(208, 21);
            this.cboOtrosIngresos.TabIndex = 78;
            this.cboOtrosIngresos.ValueMember = "strCodOtrosIngresos";
            // 
            // lblOtrosIngresos
            // 
            this.lblOtrosIngresos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtrosIngresos.Location = new System.Drawing.Point(144, 40);
            this.lblOtrosIngresos.Name = "lblOtrosIngresos";
            this.lblOtrosIngresos.Size = new System.Drawing.Size(80, 16);
            this.lblOtrosIngresos.TabIndex = 77;
            this.lblOtrosIngresos.Text = "Otro Ingreso";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(800, 8);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(72, 20);
            this.txtCedula.TabIndex = 76;
            this.txtCedula.Text = "0";
            this.txtCedula.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // txtPrestamo
            // 
            this.txtPrestamo.Location = new System.Drawing.Point(72, 40);
            this.txtPrestamo.Name = "txtPrestamo";
            this.txtPrestamo.Size = new System.Drawing.Size(56, 20);
            this.txtPrestamo.TabIndex = 75;
            this.txtPrestamo.Text = "0";
            this.txtPrestamo.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtPrestamo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrestamo_KeyPress);
            // 
            // lblPrestamo
            // 
            this.lblPrestamo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestamo.Location = new System.Drawing.Point(8, 40);
            this.lblPrestamo.Name = "lblPrestamo";
            this.lblPrestamo.Size = new System.Drawing.Size(64, 16);
            this.lblPrestamo.TabIndex = 57;
            this.lblPrestamo.Text = "Préstamo";
            // 
            // rptReportesRecibo
            // 
            this.rptReportesRecibo.Location = new System.Drawing.Point(8, 72);
            this.rptReportesRecibo.Name = "rptReportesRecibo";
            this.rptReportesRecibo.Size = new System.Drawing.Size(864, 376);
            this.rptReportesRecibo.TabIndex = 56;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.Location = new System.Drawing.Point(760, 40);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(112, 24);
            this.btnGenerarReporte.TabIndex = 55;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // dtmFechaFinal
            // 
            this.dtmFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFechaFinal.Location = new System.Drawing.Point(664, 9);
            this.dtmFechaFinal.Name = "dtmFechaFinal";
            this.dtmFechaFinal.Size = new System.Drawing.Size(78, 20);
            this.dtmFechaFinal.TabIndex = 49;
            this.dtmFechaFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtmFechaFinal_KeyPress);
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.Location = new System.Drawing.Point(586, 10);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(80, 16);
            this.lblFechaFinal.TabIndex = 48;
            this.lblFechaFinal.Text = "Fecha Final";
            // 
            // dtmFechaInicial
            // 
            this.dtmFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFechaInicial.Location = new System.Drawing.Point(499, 10);
            this.dtmFechaInicial.Name = "dtmFechaInicial";
            this.dtmFechaInicial.Size = new System.Drawing.Size(82, 20);
            this.dtmFechaInicial.TabIndex = 47;
            this.dtmFechaInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtmFechaInicial_KeyPress);
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicial.Location = new System.Drawing.Point(418, 10);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(82, 16);
            this.lblFechaInicial.TabIndex = 46;
            this.lblFechaInicial.Text = "Fecha Inicial";
            // 
            // lblCedula
            // 
            this.lblCedula.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(747, 11);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(48, 16);
            this.lblCedula.TabIndex = 44;
            this.lblCedula.Text = "Cedula";
            // 
            // cboTipoReporte
            // 
            this.cboTipoReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoReporte.Items.AddRange(new object[] {
            "",
            "01-Recibos Registrados",
            "02-Recibos Registrados en un rango de fecha",
            "03-Recibos Registrados de una persona",
            "04-Recibos Activos",
            "05-Recibos Anulados ",
            "06-Recibos Anulados en un rango de fecha.",
            "07-Recibos cuotas exequiales activos en un rango de fecha.",
            "08-Recibos cuotas exequiales anulados en un rango de fecha.",
            "09-Recibos cuotas exequiales registrados en un rango de fecha.",
            "10-Recibos cuotas exequiales de un socio.",
            "11-Recibos cuotas de préstamos activos en un rango de fecha.",
            "12-Recibos cuotas de préstamos anulados en un rango de fecha.",
            "13-Recibos cuotas de préstamos registrados en un rango de fecha.",
            "14-Recibos cuotas de préstamos de una persona.",
            "15-Recibos cuotas de préstamos de un crédito.",
            "16-Recibos otros ingresos activos en un rango de fecha.",
            "17-Recibos otros ingresos anulados en un rango de fecha.",
            "18-Recibos otros ingresos registrados en un rango de fecha.",
            "19-Recibos otros ingresos de una persona.",
            "20-Recibos otros ingresos de un item.",
            "21-Recibos Informe diario global."});
            this.cboTipoReporte.Location = new System.Drawing.Point(62, 10);
            this.cboTipoReporte.Name = "cboTipoReporte";
            this.cboTipoReporte.Size = new System.Drawing.Size(346, 21);
            this.cboTipoReporte.TabIndex = 37;
            this.cboTipoReporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboTipoReporte_KeyPress);
            // 
            // lblTipoReporte
            // 
            this.lblTipoReporte.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoReporte.Location = new System.Drawing.Point(6, 10);
            this.lblTipoReporte.Name = "lblTipoReporte";
            this.lblTipoReporte.Size = new System.Drawing.Size(58, 16);
            this.lblTipoReporte.TabIndex = 36;
            this.lblTipoReporte.Text = "Reporte";
            this.lblTipoReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cboOtrosIngresos);
            this.panel2.Controls.Add(this.lblOtrosIngresos);
            this.panel2.Controls.Add(this.txtCedula);
            this.panel2.Controls.Add(this.txtPrestamo);
            this.panel2.Controls.Add(this.lblPrestamo);
            this.panel2.Controls.Add(this.rptReportesRecibo);
            this.panel2.Controls.Add(this.btnGenerarReporte);
            this.panel2.Controls.Add(this.dtmFechaFinal);
            this.panel2.Controls.Add(this.lblFechaFinal);
            this.panel2.Controls.Add(this.dtmFechaInicial);
            this.panel2.Controls.Add(this.lblFechaInicial);
            this.panel2.Controls.Add(this.lblCedula);
            this.panel2.Controls.Add(this.cboTipoReporte);
            this.panel2.Controls.Add(this.lblTipoReporte);
            this.panel2.Location = new System.Drawing.Point(5, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 456);
            this.panel2.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 35);
            this.panel1.TabIndex = 31;
            // 
            // frmReportesRecibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 509);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportesRecibos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes recibos";
            this.Load += new System.EventHandler(this.frmReportesRecibos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.ComboBox cboOtrosIngresos;
        private System.Windows.Forms.Label lblOtrosIngresos;
        private Texto.Texto txtCedula;
        private Texto.Texto txtPrestamo;
        private System.Windows.Forms.Label lblPrestamo;
        private Microsoft.Reporting.WinForms.ReportViewer rptReportesRecibo;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.DateTimePicker dtmFechaFinal;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.DateTimePicker dtmFechaInicial;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.Label lblCedula;
        public System.Windows.Forms.ComboBox cboTipoReporte;
        private System.Windows.Forms.Label lblTipoReporte;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}