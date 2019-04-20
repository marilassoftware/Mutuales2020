namespace Mutuales2020.Utilidades
{
    partial class FrmLiquidarAhorros
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rptLiquidarAhorros = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.txtPorcentaje = new Texto.Texto();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.txtBanco = new Texto.Texto();
            this.lblBanco = new System.Windows.Forms.Label();
            this.txtAhorrado = new Texto.Texto();
            this.lblAhorrado = new System.Windows.Forms.Label();
            this.spConsultaLiquidarAhorrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spConsultaLiquidarAhorrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 40);
            this.panel1.TabIndex = 10;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(784, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "LIQUIDAR AHORROS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rptLiquidarAhorros);
            this.panel2.Controls.Add(this.btnEjecutar);
            this.panel2.Controls.Add(this.txtPorcentaje);
            this.panel2.Controls.Add(this.lblPorcentaje);
            this.panel2.Controls.Add(this.txtBanco);
            this.panel2.Controls.Add(this.lblBanco);
            this.panel2.Controls.Add(this.txtAhorrado);
            this.panel2.Controls.Add(this.lblAhorrado);
            this.panel2.Location = new System.Drawing.Point(4, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 360);
            this.panel2.TabIndex = 11;
            // 
            // rptLiquidarAhorros
            // 
            reportDataSource5.Name = "spConsultaLiquidarAhorros_spConsultaLiquidarAhorros";
            reportDataSource5.Value = this.spConsultaLiquidarAhorrosBindingSource;
            this.rptLiquidarAhorros.LocalReport.DataSources.Add(reportDataSource5);
            this.rptLiquidarAhorros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Utilidades.Reportes.rptLiquidarAhorros.rdlc";
            this.rptLiquidarAhorros.Location = new System.Drawing.Point(8, 48);
            this.rptLiquidarAhorros.Name = "rptLiquidarAhorros";
            this.rptLiquidarAhorros.Size = new System.Drawing.Size(768, 304);
            this.rptLiquidarAhorros.TabIndex = 11;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(472, 8);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 1;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Enabled = false;
            this.txtPorcentaje.Location = new System.Drawing.Point(408, 10);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(48, 20);
            this.txtPorcentaje.TabIndex = 9;
            this.txtPorcentaje.Text = "0";
            this.txtPorcentaje.Tipo = Texto.Texto.Opciones.Numerico;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.Location = new System.Drawing.Point(336, 8);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(72, 24);
            this.lblPorcentaje.TabIndex = 8;
            this.lblPorcentaje.Text = "Porcentaje";
            this.lblPorcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(224, 10);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(96, 20);
            this.txtBanco.TabIndex = 0;
            this.txtBanco.Text = "0";
            this.txtBanco.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtBanco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBanco_KeyPress);
            this.txtBanco.Leave += new System.EventHandler(this.txtBanco_Leave);
            // 
            // lblBanco
            // 
            this.lblBanco.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanco.Location = new System.Drawing.Point(176, 8);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(48, 24);
            this.lblBanco.TabIndex = 6;
            this.lblBanco.Text = "Banco";
            this.lblBanco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAhorrado
            // 
            this.txtAhorrado.Enabled = false;
            this.txtAhorrado.Location = new System.Drawing.Point(72, 8);
            this.txtAhorrado.Name = "txtAhorrado";
            this.txtAhorrado.Size = new System.Drawing.Size(96, 20);
            this.txtAhorrado.TabIndex = 5;
            this.txtAhorrado.Text = "0";
            this.txtAhorrado.Tipo = Texto.Texto.Opciones.Numerico;
            // 
            // lblAhorrado
            // 
            this.lblAhorrado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAhorrado.Location = new System.Drawing.Point(8, 6);
            this.lblAhorrado.Name = "lblAhorrado";
            this.lblAhorrado.Size = new System.Drawing.Size(64, 24);
            this.lblAhorrado.TabIndex = 4;
            this.lblAhorrado.Text = "Ahorrado";
            this.lblAhorrado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmLiquidarAhorros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLiquidarAhorros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liquidar Ahorros";
            this.Load += new System.EventHandler(this.FrmLiquidarAhorros_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spConsultaLiquidarAhorrosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource spConsultaLiquidarAhorrosBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer rptLiquidarAhorros;
        private System.Windows.Forms.Button btnEjecutar;
        private Texto.Texto txtPorcentaje;
        private System.Windows.Forms.Label lblPorcentaje;
        private Texto.Texto txtBanco;
        private System.Windows.Forms.Label lblBanco;
        private Texto.Texto txtAhorrado;
        private System.Windows.Forms.Label lblAhorrado;
    }
}