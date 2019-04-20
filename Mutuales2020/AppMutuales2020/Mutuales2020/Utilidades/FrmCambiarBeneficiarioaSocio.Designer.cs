namespace Mutuales2020.Utilidades
{
    partial class FrmCambiarBeneficiarioaSocio
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
            this.dgvAgraciados = new System.Windows.Forms.DataGridView();
            this.strCedulaAgra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strNombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEjecutarCambio = new System.Windows.Forms.Button();
            this.btnBuscarAgraciados = new System.Windows.Forms.Button();
            this.txtSocioActual = new Texto.Texto();
            this.lblSocioActual = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgraciados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 40);
            this.panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(8, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(456, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CAMBIAR BENEFICIARIO A SOCIO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvAgraciados);
            this.panel2.Controls.Add(this.btnEjecutarCambio);
            this.panel2.Controls.Add(this.btnBuscarAgraciados);
            this.panel2.Controls.Add(this.txtSocioActual);
            this.panel2.Controls.Add(this.lblSocioActual);
            this.panel2.Location = new System.Drawing.Point(8, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 248);
            this.panel2.TabIndex = 1;
            // 
            // dgvAgraciados
            // 
            this.dgvAgraciados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgraciados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.strCedulaAgra,
            this.strNombreCompleto});
            this.dgvAgraciados.Location = new System.Drawing.Point(8, 40);
            this.dgvAgraciados.Name = "dgvAgraciados";
            this.dgvAgraciados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAgraciados.Size = new System.Drawing.Size(464, 192);
            this.dgvAgraciados.TabIndex = 12;
            this.dgvAgraciados.Click += new System.EventHandler(this.dgvAgraciados_Click);
            this.dgvAgraciados.DoubleClick += new System.EventHandler(this.dgvAgraciados_DoubleClick);
            // 
            // strCedulaAgra
            // 
            this.strCedulaAgra.DataPropertyName = "strCedulaAgra";
            this.strCedulaAgra.HeaderText = "Cédula";
            this.strCedulaAgra.Name = "strCedulaAgra";
            this.strCedulaAgra.Width = 120;
            // 
            // strNombreCompleto
            // 
            this.strNombreCompleto.DataPropertyName = "strNombreCompleto";
            this.strNombreCompleto.HeaderText = "Nombre";
            this.strNombreCompleto.Name = "strNombreCompleto";
            this.strNombreCompleto.Width = 300;
            // 
            // btnEjecutarCambio
            // 
            this.btnEjecutarCambio.Location = new System.Drawing.Point(232, 8);
            this.btnEjecutarCambio.Name = "btnEjecutarCambio";
            this.btnEjecutarCambio.Size = new System.Drawing.Size(112, 23);
            this.btnEjecutarCambio.TabIndex = 2;
            this.btnEjecutarCambio.Text = "Ejecutar Cambio";
            this.btnEjecutarCambio.UseVisualStyleBackColor = true;
            this.btnEjecutarCambio.Click += new System.EventHandler(this.btnEjecutarCambio_Click);
            // 
            // btnBuscarAgraciados
            // 
            this.btnBuscarAgraciados.Location = new System.Drawing.Point(112, 8);
            this.btnBuscarAgraciados.Name = "btnBuscarAgraciados";
            this.btnBuscarAgraciados.Size = new System.Drawing.Size(112, 23);
            this.btnBuscarAgraciados.TabIndex = 1;
            this.btnBuscarAgraciados.Text = "Buscar Agraciados";
            this.btnBuscarAgraciados.UseVisualStyleBackColor = true;
            this.btnBuscarAgraciados.Click += new System.EventHandler(this.btnBuscarAgraciados_Click);
            // 
            // txtSocioActual
            // 
            this.txtSocioActual.Location = new System.Drawing.Point(56, 8);
            this.txtSocioActual.Name = "txtSocioActual";
            this.txtSocioActual.Size = new System.Drawing.Size(48, 20);
            this.txtSocioActual.TabIndex = 0;
            this.txtSocioActual.Text = "0";
            this.txtSocioActual.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtSocioActual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSocioActual_KeyPress);
            this.txtSocioActual.Leave += new System.EventHandler(this.txtSocioActual_Leave);
            // 
            // lblSocioActual
            // 
            this.lblSocioActual.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocioActual.Location = new System.Drawing.Point(8, 8);
            this.lblSocioActual.Name = "lblSocioActual";
            this.lblSocioActual.Size = new System.Drawing.Size(48, 16);
            this.lblSocioActual.TabIndex = 9;
            this.lblSocioActual.Text = "Socio *";
            this.lblSocioActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmCambiarBeneficiarioaSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 317);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCambiarBeneficiarioaSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Beneficiario a Socio";
            this.Load += new System.EventHandler(this.FrmCambiarBeneficiarioaSocio_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgraciados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private Texto.Texto txtSocioActual;
        private System.Windows.Forms.Label lblSocioActual;
        private System.Windows.Forms.Button btnEjecutarCambio;
        private System.Windows.Forms.Button btnBuscarAgraciados;
        private System.Windows.Forms.DataGridView dgvAgraciados;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCedulaAgra;
        private System.Windows.Forms.DataGridViewTextBoxColumn strNombreCompleto;
    }
}