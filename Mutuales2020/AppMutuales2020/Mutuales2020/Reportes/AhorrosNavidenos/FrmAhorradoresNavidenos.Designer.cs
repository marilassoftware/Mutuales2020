namespace Mutuales2020.Reportes.AhorrosNavidenos
{
    partial class FrmAhorradoresNavidenos
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
            this.rptReporteAhorradoresNavidenos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cboTipoReporte = new System.Windows.Forms.ComboBox();
            this.lblTipoReporte = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rptReporteAhorradoresNavidenos
            // 
            this.rptReporteAhorradoresNavidenos.Location = new System.Drawing.Point(8, 40);
            this.rptReporteAhorradoresNavidenos.Name = "rptReporteAhorradoresNavidenos";
            this.rptReporteAhorradoresNavidenos.Size = new System.Drawing.Size(848, 400);
            this.rptReporteAhorradoresNavidenos.TabIndex = 77;
            // 
            // cboTipoReporte
            // 
            this.cboTipoReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoReporte.Items.AddRange(new object[] {
            "",
            "01-Ahorrorradores Navideños Activos.",
            "02-Ahorrorradores Navideños Liquidados.",
            "03-Ahorrorradores Navideños Anulados.",
            "04-Ahorradores navideños con créditos."});
            this.cboTipoReporte.Location = new System.Drawing.Point(64, 8);
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
            this.lblTipoReporte.Size = new System.Drawing.Size(56, 16);
            this.lblTipoReporte.TabIndex = 36;
            this.lblTipoReporte.Text = "Reporte";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(8, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(856, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REPORTES DE AHORROS NAVIDEÑO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 40);
            this.panel1.TabIndex = 31;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.Location = new System.Drawing.Point(744, 8);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(112, 24);
            this.btnGenerarReporte.TabIndex = 66;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rptReporteAhorradoresNavidenos);
            this.panel2.Controls.Add(this.btnGenerarReporte);
            this.panel2.Controls.Add(this.cboTipoReporte);
            this.panel2.Controls.Add(this.lblTipoReporte);
            this.panel2.Location = new System.Drawing.Point(5, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(867, 451);
            this.panel2.TabIndex = 32;
            // 
            // FrmAhorradoresNavidenos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAhorradoresNavidenos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Reporte de Ahorro Navideño";
            this.Load += new System.EventHandler(this.FrmAhorradoresNavidenos_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptReporteAhorradoresNavidenos;
        public System.Windows.Forms.ComboBox cboTipoReporte;
        private System.Windows.Forms.Label lblTipoReporte;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Panel panel2;
    }
}