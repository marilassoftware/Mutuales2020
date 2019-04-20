namespace Mutuales2020.Ahorros
{
    partial class frmAhorrosNatilleraEscolarIntereses
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
            this.rptAhorrosInteresesaFuturo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cboOpciones = new System.Windows.Forms.ComboBox();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.spAhorrosaFuturoCalcularInteresesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbExequial2010DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlTitulo.SuspendLayout();
            this.pnlControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spAhorrosaFuturoCalcularInteresesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbExequial2010DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptAhorrosInteresesaFuturo
            // 
            this.rptAhorrosInteresesaFuturo.Location = new System.Drawing.Point(3, 41);
            this.rptAhorrosInteresesaFuturo.Name = "rptAhorrosInteresesaFuturo";
            this.rptAhorrosInteresesaFuturo.Size = new System.Drawing.Size(672, 293);
            this.rptAhorrosInteresesaFuturo.TabIndex = 10;
            // 
            // cboOpciones
            // 
            this.cboOpciones.DisplayMember = "strCodigoApp";
            this.cboOpciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpciones.FormattingEnabled = true;
            this.cboOpciones.Items.AddRange(new object[] {
            "Prueba",
            "Ejecutar",
            "Consultar"});
            this.cboOpciones.Location = new System.Drawing.Point(192, 12);
            this.cboOpciones.Name = "cboOpciones";
            this.cboOpciones.Size = new System.Drawing.Size(127, 21);
            this.cboOpciones.TabIndex = 1;
            this.cboOpciones.ValueMember = "strCodigoApp";
            // 
            // lblOpcion
            // 
            this.lblOpcion.Location = new System.Drawing.Point(145, 9);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(56, 22);
            this.lblOpcion.TabIndex = 4;
            this.lblOpcion.Text = "Opción";
            this.lblOpcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Location = new System.Drawing.Point(5, 5);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(684, 57);
            this.pnlTitulo.TabIndex = 11;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(1, 1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(682, 54);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "INTERESES AHORROS ESCOLAR";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(326, 12);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "Procesar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(47, 12);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(88, 20);
            this.dtpFecha.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(8, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(50, 22);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlControles
            // 
            this.pnlControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControles.Controls.Add(this.rptAhorrosInteresesaFuturo);
            this.pnlControles.Controls.Add(this.btnConsultar);
            this.pnlControles.Controls.Add(this.dtpFecha);
            this.pnlControles.Controls.Add(this.cboOpciones);
            this.pnlControles.Controls.Add(this.lblOpcion);
            this.pnlControles.Controls.Add(this.lblFecha);
            this.pnlControles.Location = new System.Drawing.Point(5, 68);
            this.pnlControles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(684, 339);
            this.pnlControles.TabIndex = 12;
            // 
            // spAhorrosaFuturoCalcularInteresesBindingSource
            // 
            this.spAhorrosaFuturoCalcularInteresesBindingSource.DataMember = "spAhorrosaFuturoCalcularIntereses";
            // 
            // frmAhorrosNatilleraEscolarIntereses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 415);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlControles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAhorrosNatilleraEscolarIntereses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Natillera intereses escolares";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAhorrosNatilleraEscolarIntereses_FormClosed);
            this.Load += new System.EventHandler(this.frmAhorrosNatilleraEscolarIntereses_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spAhorrosaFuturoCalcularInteresesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbExequial2010DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptAhorrosInteresesaFuturo;
        private System.Windows.Forms.ComboBox cboOpciones;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.BindingSource spAhorrosaFuturoCalcularInteresesBindingSource;
        private System.Windows.Forms.BindingSource dbExequial2010DataSetBindingSource;
    }
}