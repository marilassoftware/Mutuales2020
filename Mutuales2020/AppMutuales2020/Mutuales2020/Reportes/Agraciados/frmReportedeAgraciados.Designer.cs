namespace Mutuales2020.Reportes.Agraciados
{
    partial class frmReportedeAgraciados
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
            this.txtSocio = new Texto.Texto();
            this.lblSocio = new System.Windows.Forms.Label();
            this.rptReporteAgraciados = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtEdadFinal = new Texto.Texto();
            this.txtEdadInicial = new Texto.Texto();
            this.lblEdadFinal = new System.Windows.Forms.Label();
            this.lblEdadInicial = new System.Windows.Forms.Label();
            this.cboBarrios = new System.Windows.Forms.ComboBox();
            this.lblBarrios = new System.Windows.Forms.Label();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.chkSexo = new System.Windows.Forms.CheckBox();
            this.cboServicios = new System.Windows.Forms.ComboBox();
            this.lblServicios = new System.Windows.Forms.Label();
            this.dtmFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.dtmFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.cboTipoReporte = new System.Windows.Forms.ComboBox();
            this.lblTipoReporte = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 40);
            this.panel1.TabIndex = 25;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(8, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(856, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REPORTES DE BENEFICIARIOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtSocio);
            this.panel2.Controls.Add(this.lblSocio);
            this.panel2.Controls.Add(this.rptReporteAgraciados);
            this.panel2.Controls.Add(this.txtEdadFinal);
            this.panel2.Controls.Add(this.txtEdadInicial);
            this.panel2.Controls.Add(this.lblEdadFinal);
            this.panel2.Controls.Add(this.lblEdadInicial);
            this.panel2.Controls.Add(this.cboBarrios);
            this.panel2.Controls.Add(this.lblBarrios);
            this.panel2.Controls.Add(this.btnGenerarReporte);
            this.panel2.Controls.Add(this.chkSexo);
            this.panel2.Controls.Add(this.cboServicios);
            this.panel2.Controls.Add(this.lblServicios);
            this.panel2.Controls.Add(this.dtmFechaFinal);
            this.panel2.Controls.Add(this.lblFechaFinal);
            this.panel2.Controls.Add(this.dtmFechaInicial);
            this.panel2.Controls.Add(this.lblFechaInicial);
            this.panel2.Controls.Add(this.cboTipoReporte);
            this.panel2.Controls.Add(this.lblTipoReporte);
            this.panel2.Location = new System.Drawing.Point(4, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(867, 451);
            this.panel2.TabIndex = 26;
            // 
            // txtSocio
            // 
            this.txtSocio.Location = new System.Drawing.Point(440, 8);
            this.txtSocio.Name = "txtSocio";
            this.txtSocio.Size = new System.Drawing.Size(48, 20);
            this.txtSocio.TabIndex = 75;
            this.txtSocio.Text = "0";
            this.txtSocio.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtSocio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSocio_KeyPress);
            // 
            // lblSocio
            // 
            this.lblSocio.AutoSize = true;
            this.lblSocio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocio.Location = new System.Drawing.Point(400, 8);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(41, 16);
            this.lblSocio.TabIndex = 76;
            this.lblSocio.Text = "Socio";
            // 
            // rptReporteAgraciados
            // 
            this.rptReporteAgraciados.Location = new System.Drawing.Point(8, 72);
            this.rptReporteAgraciados.Name = "rptReporteAgraciados";
            this.rptReporteAgraciados.Size = new System.Drawing.Size(848, 368);
            this.rptReporteAgraciados.TabIndex = 75;
            // 
            // txtEdadFinal
            // 
            this.txtEdadFinal.Location = new System.Drawing.Point(360, 40);
            this.txtEdadFinal.Name = "txtEdadFinal";
            this.txtEdadFinal.Size = new System.Drawing.Size(32, 20);
            this.txtEdadFinal.TabIndex = 74;
            this.txtEdadFinal.Text = "0";
            this.txtEdadFinal.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtEdadFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdadFinal_KeyPress);
            // 
            // txtEdadInicial
            // 
            this.txtEdadInicial.Location = new System.Drawing.Point(312, 40);
            this.txtEdadInicial.Name = "txtEdadInicial";
            this.txtEdadInicial.Size = new System.Drawing.Size(32, 20);
            this.txtEdadInicial.TabIndex = 73;
            this.txtEdadInicial.Text = "0";
            this.txtEdadInicial.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtEdadInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdadInicial_KeyPress);
            // 
            // lblEdadFinal
            // 
            this.lblEdadFinal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadFinal.Location = new System.Drawing.Point(344, 40);
            this.lblEdadFinal.Name = "lblEdadFinal";
            this.lblEdadFinal.Size = new System.Drawing.Size(16, 16);
            this.lblEdadFinal.TabIndex = 71;
            this.lblEdadFinal.Text = "Y";
            // 
            // lblEdadInicial
            // 
            this.lblEdadInicial.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadInicial.Location = new System.Drawing.Point(224, 40);
            this.lblEdadInicial.Name = "lblEdadInicial";
            this.lblEdadInicial.Size = new System.Drawing.Size(85, 16);
            this.lblEdadInicial.TabIndex = 69;
            this.lblEdadInicial.Text = "Edades entre ";
            // 
            // cboBarrios
            // 
            this.cboBarrios.DisplayMember = "strNomBarrio";
            this.cboBarrios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarrios.Items.AddRange(new object[] {
            ""});
            this.cboBarrios.Location = new System.Drawing.Point(632, 8);
            this.cboBarrios.Name = "cboBarrios";
            this.cboBarrios.Size = new System.Drawing.Size(160, 21);
            this.cboBarrios.TabIndex = 68;
            this.cboBarrios.ValueMember = "strCodBarrio";
            this.cboBarrios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboBarrios_KeyPress);
            // 
            // lblBarrios
            // 
            this.lblBarrios.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrios.Location = new System.Drawing.Point(584, 8);
            this.lblBarrios.Name = "lblBarrios";
            this.lblBarrios.Size = new System.Drawing.Size(48, 16);
            this.lblBarrios.TabIndex = 67;
            this.lblBarrios.Text = "Barrios";
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.Location = new System.Drawing.Point(744, 40);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(112, 24);
            this.btnGenerarReporte.TabIndex = 66;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // chkSexo
            // 
            this.chkSexo.AutoSize = true;
            this.chkSexo.Location = new System.Drawing.Point(504, 8);
            this.chkSexo.Name = "chkSexo";
            this.chkSexo.Size = new System.Drawing.Size(74, 17);
            this.chkSexo.TabIndex = 63;
            this.chkSexo.Text = "Masculino";
            this.chkSexo.UseVisualStyleBackColor = true;
            this.chkSexo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chkSexo_KeyPress);
            // 
            // cboServicios
            // 
            this.cboServicios.DisplayMember = "strNombreSpr";
            this.cboServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServicios.Items.AddRange(new object[] {
            ""});
            this.cboServicios.Location = new System.Drawing.Point(72, 40);
            this.cboServicios.Name = "cboServicios";
            this.cboServicios.Size = new System.Drawing.Size(144, 21);
            this.cboServicios.TabIndex = 57;
            this.cboServicios.ValueMember = "strCodSpr";
            this.cboServicios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboServicios_KeyPress);
            // 
            // lblServicios
            // 
            this.lblServicios.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicios.Location = new System.Drawing.Point(8, 40);
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(64, 16);
            this.lblServicios.TabIndex = 56;
            this.lblServicios.Text = "Servicios";
            // 
            // dtmFechaFinal
            // 
            this.dtmFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFechaFinal.Location = new System.Drawing.Point(648, 40);
            this.dtmFechaFinal.Name = "dtmFechaFinal";
            this.dtmFechaFinal.Size = new System.Drawing.Size(88, 20);
            this.dtmFechaFinal.TabIndex = 49;
            this.dtmFechaFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtmFechaFinal_KeyPress);
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.Location = new System.Drawing.Point(568, 40);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(80, 16);
            this.lblFechaFinal.TabIndex = 48;
            this.lblFechaFinal.Text = "Fecha Final";
            // 
            // dtmFechaInicial
            // 
            this.dtmFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFechaInicial.Location = new System.Drawing.Point(480, 40);
            this.dtmFechaInicial.Name = "dtmFechaInicial";
            this.dtmFechaInicial.Size = new System.Drawing.Size(80, 20);
            this.dtmFechaInicial.TabIndex = 47;
            this.dtmFechaInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtmFechaInicial_KeyPress);
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicial.Location = new System.Drawing.Point(400, 40);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(96, 16);
            this.lblFechaInicial.TabIndex = 46;
            this.lblFechaInicial.Text = "Fecha Inicial";
            // 
            // cboTipoReporte
            // 
            this.cboTipoReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoReporte.Items.AddRange(new object[] {
            "",
            "01-Agraciados Activos",
            "02-Agraciados Anulados",
            "03-Agraciados Registrados",
            "04-Agraciados Recesados.",
            "05-Agraciados no Recesados",
            "06-Agraciados de Determinado Barrio",
            "07-Agraciados de Determinado Sexo",
            "08-Agraciados por Socio",
            "09-Agraciados con Préstamos",
            "10-Agraciados por Plan",
            "11-Agraciados entre determinada edad",
            "12-Agraciados Anulados en un rango de fecha",
            "13-Agraciados Registrados en un Rango de Fecha",
            "14-Agraciados nacidos entre 2 fechas",
            "15-Agraciados por Plan en un Rango de Fechas",
            "16-Agraciados sin actualizar informacion.",
            "17-Agraciados con informacion actualizada."});
            this.cboTipoReporte.Location = new System.Drawing.Point(96, 8);
            this.cboTipoReporte.Name = "cboTipoReporte";
            this.cboTipoReporte.Size = new System.Drawing.Size(296, 21);
            this.cboTipoReporte.TabIndex = 37;
            this.cboTipoReporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboTipoReporte_KeyPress);
            // 
            // lblTipoReporte
            // 
            this.lblTipoReporte.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoReporte.Location = new System.Drawing.Point(8, 8);
            this.lblTipoReporte.Name = "lblTipoReporte";
            this.lblTipoReporte.Size = new System.Drawing.Size(88, 16);
            this.lblTipoReporte.TabIndex = 36;
            this.lblTipoReporte.Text = "Tipo Reporte";
            // 
            // frmReportedeAgraciados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 505);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportedeAgraciados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Agraciados";
            this.Load += new System.EventHandler(this.frmReportedeAgraciados_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private Texto.Texto txtEdadFinal;
        private Texto.Texto txtEdadInicial;
        private System.Windows.Forms.Label lblEdadFinal;
        private System.Windows.Forms.Label lblEdadInicial;
        public System.Windows.Forms.ComboBox cboBarrios;
        private System.Windows.Forms.Label lblBarrios;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.CheckBox chkSexo;
        public System.Windows.Forms.ComboBox cboServicios;
        private System.Windows.Forms.Label lblServicios;
        private System.Windows.Forms.DateTimePicker dtmFechaFinal;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.DateTimePicker dtmFechaInicial;
        private System.Windows.Forms.Label lblFechaInicial;
        public System.Windows.Forms.ComboBox cboTipoReporte;
        private System.Windows.Forms.Label lblTipoReporte;
        private Microsoft.Reporting.WinForms.ReportViewer rptReporteAgraciados;
        private Texto.Texto txtSocio;
        private System.Windows.Forms.Label lblSocio;
    }
}