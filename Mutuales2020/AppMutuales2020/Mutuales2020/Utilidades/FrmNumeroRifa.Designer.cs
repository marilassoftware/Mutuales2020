namespace Mutuales2020.Utilidades
{
    partial class FrmNumeroRifa
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
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblNumeroRifa = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEjecutarAutomaticamente = new System.Windows.Forms.Button();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.txtNumeroRifa = new System.Windows.Forms.TextBox();
            this.lblNúmero = new System.Windows.Forms.Label();
            this.chkSocio = new System.Windows.Forms.CheckBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.txtSocio = new System.Windows.Forms.TextBox();
            this.lblSocio = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitulo.Controls.Add(this.lblNumeroRifa);
            this.pnlTitulo.Location = new System.Drawing.Point(8, 8);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(400, 32);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblNumeroRifa
            // 
            this.lblNumeroRifa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroRifa.Location = new System.Drawing.Point(0, 0);
            this.lblNumeroRifa.Name = "lblNumeroRifa";
            this.lblNumeroRifa.Size = new System.Drawing.Size(392, 32);
            this.lblNumeroRifa.TabIndex = 0;
            this.lblNumeroRifa.Text = "NÚMERO DE RIFA";
            this.lblNumeroRifa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnEjecutarAutomaticamente);
            this.panel2.Controls.Add(this.btnEjecutar);
            this.panel2.Controls.Add(this.txtNumeroRifa);
            this.panel2.Controls.Add(this.lblNúmero);
            this.panel2.Controls.Add(this.chkSocio);
            this.panel2.Controls.Add(this.txtMes);
            this.panel2.Controls.Add(this.lblMes);
            this.panel2.Controls.Add(this.txtAño);
            this.panel2.Controls.Add(this.lblAño);
            this.panel2.Controls.Add(this.txtSocio);
            this.panel2.Controls.Add(this.lblSocio);
            this.panel2.Location = new System.Drawing.Point(8, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 80);
            this.panel2.TabIndex = 2;
            // 
            // btnEjecutarAutomaticamente
            // 
            this.btnEjecutarAutomaticamente.Location = new System.Drawing.Point(208, 40);
            this.btnEjecutarAutomaticamente.Name = "btnEjecutarAutomaticamente";
            this.btnEjecutarAutomaticamente.Size = new System.Drawing.Size(184, 23);
            this.btnEjecutarAutomaticamente.TabIndex = 6;
            this.btnEjecutarAutomaticamente.Text = "Generar automaticamente (Socios)";
            this.btnEjecutarAutomaticamente.UseVisualStyleBackColor = true;
            this.btnEjecutarAutomaticamente.Click += new System.EventHandler(this.btnEjecutarAutomaticamente_Click);
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(120, 40);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 5;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // txtNumeroRifa
            // 
            this.txtNumeroRifa.Enabled = false;
            this.txtNumeroRifa.Location = new System.Drawing.Point(64, 40);
            this.txtNumeroRifa.Name = "txtNumeroRifa";
            this.txtNumeroRifa.Size = new System.Drawing.Size(40, 20);
            this.txtNumeroRifa.TabIndex = 4;
            // 
            // lblNúmero
            // 
            this.lblNúmero.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNúmero.Location = new System.Drawing.Point(8, 40);
            this.lblNúmero.Name = "lblNúmero";
            this.lblNúmero.Size = new System.Drawing.Size(72, 16);
            this.lblNúmero.TabIndex = 22;
            this.lblNúmero.Text = "Número";
            this.lblNúmero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkSocio
            // 
            this.chkSocio.AutoSize = true;
            this.chkSocio.Location = new System.Drawing.Point(250, 8);
            this.chkSocio.Name = "chkSocio";
            this.chkSocio.Size = new System.Drawing.Size(53, 17);
            this.chkSocio.TabIndex = 3;
            this.chkSocio.Text = "Socio";
            this.chkSocio.UseVisualStyleBackColor = true;
            // 
            // txtMes
            // 
            this.txtMes.Enabled = false;
            this.txtMes.Location = new System.Drawing.Point(203, 8);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(40, 20);
            this.txtMes.TabIndex = 2;
            // 
            // lblMes
            // 
            this.lblMes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(171, 8);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(40, 16);
            this.lblMes.TabIndex = 19;
            this.lblMes.Text = "Mes";
            this.lblMes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAño
            // 
            this.txtAño.Enabled = false;
            this.txtAño.Location = new System.Drawing.Point(122, 8);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(40, 20);
            this.txtAño.TabIndex = 1;
            // 
            // lblAño
            // 
            this.lblAño.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(92, 8);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(40, 16);
            this.lblAño.TabIndex = 17;
            this.lblAño.Text = "Año";
            this.lblAño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSocio
            // 
            this.txtSocio.Location = new System.Drawing.Point(46, 8);
            this.txtSocio.Name = "txtSocio";
            this.txtSocio.Size = new System.Drawing.Size(40, 20);
            this.txtSocio.TabIndex = 0;
            this.txtSocio.Enter += new System.EventHandler(this.txtSocio_Enter);
            // 
            // lblSocio
            // 
            this.lblSocio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocio.Location = new System.Drawing.Point(8, 8);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(40, 16);
            this.lblSocio.TabIndex = 15;
            this.lblSocio.Text = "Socio";
            this.lblSocio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmNumeroRifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 136);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNumeroRifa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numero Rifa";
            this.Load += new System.EventHandler(this.FrmNumeroRifa_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblNumeroRifa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.TextBox txtSocio;
        private System.Windows.Forms.Label lblSocio;
        private System.Windows.Forms.Button btnEjecutarAutomaticamente;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.TextBox txtNumeroRifa;
        private System.Windows.Forms.Label lblNúmero;
        private System.Windows.Forms.CheckBox chkSocio;
    }
}