namespace Mutuales2020.Ahorros
{
    partial class FrmAhorrosaFuturoBonificacion
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
            this.ArrayOfAhorrosInteresesaFuturoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtValor = new Texto.Texto();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.txtBonificacion = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.rdbPremios = new System.Windows.Forms.RadioButton();
            this.rdbIntereses = new System.Windows.Forms.RadioButton();
            this.lblValor = new System.Windows.Forms.Label();
            this.dgvAhorrosaFuturoBonificacion = new System.Windows.Forms.DataGridView();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cédula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ArrayOfAhorrosInteresesaFuturoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAhorrosaFuturoBonificacion)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Location = new System.Drawing.Point(4, 353);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 55);
            this.panel1.TabIndex = 10;
            // 
            // btnModificar
            // 
            this.btnModificar.ImageIndex = 0;
            this.btnModificar.Location = new System.Drawing.Point(167, 4);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(89, 47);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(472, 4);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 47);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(367, 4);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 47);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(262, 4);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 47);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageIndex = 0;
            this.btnGuardar.Location = new System.Drawing.Point(62, 4);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 47);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(332, 10);
            this.txtValor.MaxLength = 12;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(79, 21);
            this.txtValor.TabIndex = 3;
            this.txtValor.Text = "0";
            this.txtValor.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // pnlControles
            // 
            this.pnlControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControles.Controls.Add(this.txtBonificacion);
            this.pnlControles.Controls.Add(this.dtpFecha);
            this.pnlControles.Controls.Add(this.lblFecha);
            this.pnlControles.Controls.Add(this.rdbPremios);
            this.pnlControles.Controls.Add(this.rdbIntereses);
            this.pnlControles.Controls.Add(this.txtValor);
            this.pnlControles.Controls.Add(this.lblValor);
            this.pnlControles.Controls.Add(this.dgvAhorrosaFuturoBonificacion);
            this.pnlControles.Controls.Add(this.txtCuenta);
            this.pnlControles.Controls.Add(this.lblCuenta);
            this.pnlControles.Location = new System.Drawing.Point(4, 67);
            this.pnlControles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(644, 283);
            this.pnlControles.TabIndex = 9;
            // 
            // txtBonificacion
            // 
            this.txtBonificacion.Location = new System.Drawing.Point(574, 9);
            this.txtBonificacion.MaxLength = 4;
            this.txtBonificacion.Name = "txtBonificacion";
            this.txtBonificacion.Size = new System.Drawing.Size(61, 20);
            this.txtBonificacion.TabIndex = 5;
            this.txtBonificacion.Text = "0";
            this.txtBonificacion.Visible = false;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(473, 10);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(84, 21);
            this.dtpFecha.TabIndex = 4;
            this.dtpFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFecha_KeyPress);
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(415, 8);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 22);
            this.lblFecha.TabIndex = 20;
            this.lblFecha.Text = "Fecha*";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdbPremios
            // 
            this.rdbPremios.AutoSize = true;
            this.rdbPremios.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPremios.Location = new System.Drawing.Point(212, 9);
            this.rdbPremios.Name = "rdbPremios";
            this.rdbPremios.Size = new System.Drawing.Size(72, 19);
            this.rdbPremios.TabIndex = 2;
            this.rdbPremios.TabStop = true;
            this.rdbPremios.Text = "Premios";
            this.rdbPremios.UseVisualStyleBackColor = true;
            this.rdbPremios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rdbPremios_KeyPress);
            // 
            // rdbIntereses
            // 
            this.rdbIntereses.AutoSize = true;
            this.rdbIntereses.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbIntereses.Location = new System.Drawing.Point(136, 9);
            this.rdbIntereses.Name = "rdbIntereses";
            this.rdbIntereses.Size = new System.Drawing.Size(77, 19);
            this.rdbIntereses.TabIndex = 1;
            this.rdbIntereses.TabStop = true;
            this.rdbIntereses.Text = "Intereses";
            this.rdbIntereses.UseVisualStyleBackColor = true;
            this.rdbIntereses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rdbIntereses_KeyPress);
            // 
            // lblValor
            // 
            this.lblValor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(284, 9);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(43, 22);
            this.lblValor.TabIndex = 13;
            this.lblValor.Text = "Valor*";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvAhorrosaFuturoBonificacion
            // 
            this.dgvAhorrosaFuturoBonificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAhorrosaFuturoBonificacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuenta,
            this.Cédula,
            this.Nombre,
            this.Apellido,
            this.Fecha,
            this.Valor});
            this.dgvAhorrosaFuturoBonificacion.Location = new System.Drawing.Point(11, 36);
            this.dgvAhorrosaFuturoBonificacion.Name = "dgvAhorrosaFuturoBonificacion";
            this.dgvAhorrosaFuturoBonificacion.ReadOnly = true;
            this.dgvAhorrosaFuturoBonificacion.Size = new System.Drawing.Size(624, 242);
            this.dgvAhorrosaFuturoBonificacion.TabIndex = 8;
            this.dgvAhorrosaFuturoBonificacion.DoubleClick += new System.EventHandler(this.dgvAhorrosaFuturoBonificacion_DoubleClick);
            // 
            // Cuenta
            // 
            this.Cuenta.DataPropertyName = "intCodigoBonificacion";
            this.Cuenta.HeaderText = "Bonificación";
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.ReadOnly = true;
            // 
            // Cédula
            // 
            this.Cédula.DataPropertyName = "strCuenta";
            this.Cédula.HeaderText = "Cuenta";
            this.Cédula.Name = "Cédula";
            this.Cédula.ReadOnly = true;
            this.Cédula.Width = 80;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "dtmFechaSorteo";
            this.Nombre.HeaderText = "Fecha";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "fltValor";
            this.Apellido.HeaderText = "Valor";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 120;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "bitIntereses";
            this.Fecha.HeaderText = "Interés";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 90;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "bitPremios";
            this.Valor.HeaderText = "Premio";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 75;
            // 
            // txtCuenta
            // 
            this.txtCuenta.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuenta.Location = new System.Drawing.Point(67, 10);
            this.txtCuenta.MaxLength = 4;
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(61, 21);
            this.txtCuenta.TabIndex = 0;
            this.txtCuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuenta_KeyPress);
            // 
            // lblCuenta
            // 
            this.lblCuenta.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuenta.Location = new System.Drawing.Point(8, 9);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(54, 22);
            this.lblCuenta.TabIndex = 0;
            this.lblCuenta.Text = "Cuenta*";
            this.lblCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Location = new System.Drawing.Point(4, 4);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(644, 57);
            this.pnlTitulo.TabIndex = 8;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(1, 1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(634, 54);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "BONIFICACIONES AHORRO A FUTURO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAhorrosaFuturoBonificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 410);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlControles);
            this.Controls.Add(this.pnlTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAhorrosaFuturoBonificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de bonificaciones de ahorro a futuro";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ArrayOfAhorrosInteresesaFuturoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlControles.ResumeLayout(false);
            this.pnlControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAhorrosaFuturoBonificacion)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private Texto.Texto txtValor;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.RadioButton rdbPremios;
        private System.Windows.Forms.RadioButton rdbIntereses;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.DataGridView dgvAhorrosaFuturoBonificacion;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtBonificacion;
        private System.Windows.Forms.BindingSource BindingSource;
        private System.Windows.Forms.BindingSource ArrayOfAhorrosInteresesaFuturoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cédula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;

    }
}

