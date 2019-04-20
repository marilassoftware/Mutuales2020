namespace Mutuales2020.Utilidades
{
    partial class frmRecaudosaFecha
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
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.dtmFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.dtmFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rptRecaudoFecha = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.Location = new System.Drawing.Point(512, 8);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(104, 24);
            this.btnEjecutar.TabIndex = 3;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Items.AddRange(new object[] {
            "01-Ingresos",
            "02-Egresos"});
            this.cboTipo.Location = new System.Drawing.Point(400, 8);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(96, 21);
            this.cboTipo.TabIndex = 2;
            // 
            // lblTipo
            // 
            this.lblTipo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(360, 8);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(33, 16);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo";
            // 
            // dtmFechaFinal
            // 
            this.dtmFechaFinal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFechaFinal.Location = new System.Drawing.Point(264, 8);
            this.dtmFechaFinal.Name = "dtmFechaFinal";
            this.dtmFechaFinal.Size = new System.Drawing.Size(88, 21);
            this.dtmFechaFinal.TabIndex = 1;
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinal.Location = new System.Drawing.Point(184, 8);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(80, 16);
            this.lblFechaFinal.TabIndex = 2;
            this.lblFechaFinal.Text = "Fecha Final";
            // 
            // dtmFechaInicial
            // 
            this.dtmFechaInicial.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFechaInicial.Location = new System.Drawing.Point(90, 8);
            this.dtmFechaInicial.Name = "dtmFechaInicial";
            this.dtmFechaInicial.Size = new System.Drawing.Size(88, 21);
            this.dtmFechaInicial.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 32);
            this.panel1.TabIndex = 15;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(4, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(701, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "RECAUDOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicial.Location = new System.Drawing.Point(8, 8);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(81, 16);
            this.lblFechaInicial.TabIndex = 0;
            this.lblFechaInicial.Text = "Fecha Inicial";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rptRecaudoFecha);
            this.panel2.Controls.Add(this.btnEjecutar);
            this.panel2.Controls.Add(this.cboTipo);
            this.panel2.Controls.Add(this.lblTipo);
            this.panel2.Controls.Add(this.dtmFechaFinal);
            this.panel2.Controls.Add(this.lblFechaFinal);
            this.panel2.Controls.Add(this.dtmFechaInicial);
            this.panel2.Controls.Add(this.lblFechaInicial);
            this.panel2.Location = new System.Drawing.Point(5, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 352);
            this.panel2.TabIndex = 16;
            // 
            // rptRecaudoFecha
            // 
            this.rptRecaudoFecha.Location = new System.Drawing.Point(6, 40);
            this.rptRecaudoFecha.Name = "rptRecaudoFecha";
            this.rptRecaudoFecha.Size = new System.Drawing.Size(698, 303);
            this.rptRecaudoFecha.TabIndex = 8;
            // 
            // frmRecaudosaFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 399);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRecaudosaFecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recaudos a Fecha";
            this.Load += new System.EventHandler(this.frmRecaudosaFecha_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.DateTimePicker dtmFechaFinal;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.DateTimePicker dtmFechaInicial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer rptRecaudoFecha;
    }
}