namespace Mutuales2020.Utilidades
{
    partial class FrmLiquidarIntereses
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.rptLiquidarIntereses = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblTipodeReporte = new System.Windows.Forms.Label();
            this.cboTrimestre = new System.Windows.Forms.ComboBox();
            this.lblTrimestre = new System.Windows.Forms.Label();
            this.cboAño = new System.Windows.Forms.ComboBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.cboTipodeReporte = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 40);
            this.panel1.TabIndex = 8;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(728, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "LIQUIDAR INTERESES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnConsultar);
            this.panel2.Controls.Add(this.rptLiquidarIntereses);
            this.panel2.Controls.Add(this.lblTipodeReporte);
            this.panel2.Controls.Add(this.cboTrimestre);
            this.panel2.Controls.Add(this.lblTrimestre);
            this.panel2.Controls.Add(this.cboAño);
            this.panel2.Controls.Add(this.lblAño);
            this.panel2.Controls.Add(this.cboTipodeReporte);
            this.panel2.Location = new System.Drawing.Point(9, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(727, 408);
            this.panel2.TabIndex = 9;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(648, 8);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(64, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // rptLiquidarIntereses
            // 
            this.rptLiquidarIntereses.Location = new System.Drawing.Point(8, 40);
            this.rptLiquidarIntereses.Name = "rptLiquidarIntereses";
            this.rptLiquidarIntereses.Size = new System.Drawing.Size(712, 360);
            this.rptLiquidarIntereses.TabIndex = 15;
            // 
            // lblTipodeReporte
            // 
            this.lblTipodeReporte.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipodeReporte.Location = new System.Drawing.Point(8, 8);
            this.lblTipodeReporte.Name = "lblTipodeReporte";
            this.lblTipodeReporte.Size = new System.Drawing.Size(96, 16);
            this.lblTipodeReporte.TabIndex = 14;
            this.lblTipodeReporte.Text = "Tipo de Reporte";
            this.lblTipodeReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboTrimestre
            // 
            this.cboTrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrimestre.FormattingEnabled = true;
            this.cboTrimestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboTrimestre.Location = new System.Drawing.Point(592, 8);
            this.cboTrimestre.Name = "cboTrimestre";
            this.cboTrimestre.Size = new System.Drawing.Size(45, 21);
            this.cboTrimestre.TabIndex = 2;
            this.cboTrimestre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboTrimestre_KeyPress);
            // 
            // lblTrimestre
            // 
            this.lblTrimestre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrimestre.Location = new System.Drawing.Point(528, 8);
            this.lblTrimestre.Name = "lblTrimestre";
            this.lblTrimestre.Size = new System.Drawing.Size(64, 16);
            this.lblTrimestre.TabIndex = 12;
            this.lblTrimestre.Text = "Trimestre:";
            this.lblTrimestre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboAño
            // 
            this.cboAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAño.FormattingEnabled = true;
            this.cboAño.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015"});
            this.cboAño.Location = new System.Drawing.Point(456, 8);
            this.cboAño.Name = "cboAño";
            this.cboAño.Size = new System.Drawing.Size(56, 21);
            this.cboAño.TabIndex = 1;
            this.cboAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboAño_KeyPress);
            // 
            // lblAño
            // 
            this.lblAño.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(424, 8);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(32, 16);
            this.lblAño.TabIndex = 10;
            this.lblAño.Text = "Año:";
            this.lblAño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboTipodeReporte
            // 
            this.cboTipodeReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipodeReporte.FormattingEnabled = true;
            this.cboTipodeReporte.Items.AddRange(new object[] {
            "",
            "01-Calcular Intereses.",
            "02-Registrar Intereses.",
            "03-Consulta de datos anteriores."});
            this.cboTipodeReporte.Location = new System.Drawing.Point(104, 8);
            this.cboTipodeReporte.Name = "cboTipodeReporte";
            this.cboTipodeReporte.Size = new System.Drawing.Size(312, 21);
            this.cboTipodeReporte.TabIndex = 0;
            this.cboTipodeReporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboTipodeReporte_KeyPress);
            // 
            // FrmLiquidarIntereses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 475);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLiquidarIntereses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liquidar Intereses";
            this.Load += new System.EventHandler(this.FrmLiquidarIntereses_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboTipodeReporte;
        private System.Windows.Forms.Label lblTipodeReporte;
        private System.Windows.Forms.ComboBox cboTrimestre;
        private System.Windows.Forms.Label lblTrimestre;
        private System.Windows.Forms.ComboBox cboAño;
        private System.Windows.Forms.Label lblAño;
        private Microsoft.Reporting.WinForms.ReportViewer rptLiquidarIntereses;
        private System.Windows.Forms.Button btnConsultar;
    }
}