﻿namespace Mutuales2020.Ahorros
{
    partial class FrmAhorrosaFuturo
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvAhorrosaFuturo = new System.Windows.Forms.DataGridView();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cédula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Años = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNomAhorrador = new System.Windows.Forms.TextBox();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.txtCuotas = new Texto.Texto();
            this.lblCuotas = new System.Windows.Forms.Label();
            this.txtAño = new Texto.Texto();
            this.lblAño = new System.Windows.Forms.Label();
            this.txtValor = new Texto.Texto();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtCedulaAho = new Texto.Texto();
            this.lblAhorrador = new System.Windows.Forms.Label();
            this.dtpFechaCuenta = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAhorrosaFuturo)).BeginInit();
            this.pnlControles.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(710, 55);
            this.panel1.TabIndex = 7;
            // 
            // btnModificar
            // 
            this.btnModificar.ImageIndex = 0;
            this.btnModificar.Location = new System.Drawing.Point(207, 3);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(89, 47);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(512, 3);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 47);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(407, 3);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 47);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(302, 3);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 47);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageIndex = 0;
            this.btnGuardar.Location = new System.Drawing.Point(102, 3);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 47);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Location = new System.Drawing.Point(4, 4);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(710, 57);
            this.pnlTitulo.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(1, 1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(708, 54);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "AHORROS A FUTURO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvAhorrosaFuturo
            // 
            this.dgvAhorrosaFuturo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAhorrosaFuturo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuenta,
            this.Cédula,
            this.Nombre,
            this.Apellido,
            this.Fecha,
            this.Valor,
            this.Años,
            this.Cuotas});
            this.dgvAhorrosaFuturo.Location = new System.Drawing.Point(11, 65);
            this.dgvAhorrosaFuturo.Name = "dgvAhorrosaFuturo";
            this.dgvAhorrosaFuturo.ReadOnly = true;
            this.dgvAhorrosaFuturo.Size = new System.Drawing.Size(694, 213);
            this.dgvAhorrosaFuturo.TabIndex = 8;
            this.dgvAhorrosaFuturo.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            // 
            // Cuenta
            // 
            this.Cuenta.DataPropertyName = "strCuenta";
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.ReadOnly = true;
            this.Cuenta.Width = 60;
            // 
            // Cédula
            // 
            this.Cédula.DataPropertyName = "strCedulaAho";
            this.Cédula.HeaderText = "Cédula";
            this.Cédula.Name = "Cédula";
            this.Cédula.ReadOnly = true;
            this.Cédula.Width = 70;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "strNombreAho";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 120;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "strApellidoAho";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 120;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "dtmFechaCuenta";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 90;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "fltValorCuota";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 75;
            // 
            // Años
            // 
            this.Años.DataPropertyName = "intAno";
            this.Años.HeaderText = "Año";
            this.Años.Name = "Años";
            this.Años.ReadOnly = true;
            this.Años.Width = 50;
            // 
            // Cuotas
            // 
            this.Cuotas.DataPropertyName = "intCuotas";
            this.Cuotas.HeaderText = "Cuotas";
            this.Cuotas.Name = "Cuotas";
            this.Cuotas.ReadOnly = true;
            this.Cuotas.Width = 50;
            // 
            // txtNomAhorrador
            // 
            this.txtNomAhorrador.Enabled = false;
            this.txtNomAhorrador.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomAhorrador.Location = new System.Drawing.Point(465, 10);
            this.txtNomAhorrador.MaxLength = 100;
            this.txtNomAhorrador.Name = "txtNomAhorrador";
            this.txtNomAhorrador.Size = new System.Drawing.Size(232, 21);
            this.txtNomAhorrador.TabIndex = 3;
            // 
            // pnlControles
            // 
            this.pnlControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControles.Controls.Add(this.txtCuotas);
            this.pnlControles.Controls.Add(this.lblCuotas);
            this.pnlControles.Controls.Add(this.txtAño);
            this.pnlControles.Controls.Add(this.lblAño);
            this.pnlControles.Controls.Add(this.txtValor);
            this.pnlControles.Controls.Add(this.lblValor);
            this.pnlControles.Controls.Add(this.txtCedulaAho);
            this.pnlControles.Controls.Add(this.lblAhorrador);
            this.pnlControles.Controls.Add(this.dtpFechaCuenta);
            this.pnlControles.Controls.Add(this.lblFecha);
            this.pnlControles.Controls.Add(this.dgvAhorrosaFuturo);
            this.pnlControles.Controls.Add(this.txtNomAhorrador);
            this.pnlControles.Controls.Add(this.txtCuenta);
            this.pnlControles.Controls.Add(this.lblCuenta);
            this.pnlControles.Location = new System.Drawing.Point(4, 67);
            this.pnlControles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(710, 283);
            this.pnlControles.TabIndex = 6;
            // 
            // txtCuotas
            // 
            this.txtCuotas.Enabled = false;
            this.txtCuotas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuotas.Location = new System.Drawing.Point(302, 38);
            this.txtCuotas.MaxLength = 2;
            this.txtCuotas.Name = "txtCuotas";
            this.txtCuotas.Size = new System.Drawing.Size(37, 21);
            this.txtCuotas.TabIndex = 5;
            this.txtCuotas.Text = "0";
            this.txtCuotas.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtCuotas.Leave += new System.EventHandler(this.txtCuotas_Leave);
            this.txtCuotas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuotas_KeyPress);
            // 
            // lblCuotas
            // 
            this.lblCuotas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuotas.Location = new System.Drawing.Point(248, 38);
            this.lblCuotas.Name = "lblCuotas";
            this.lblCuotas.Size = new System.Drawing.Size(62, 22);
            this.lblCuotas.TabIndex = 17;
            this.lblCuotas.Text = "Cuotas*";
            this.lblCuotas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAño
            // 
            this.txtAño.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAño.Location = new System.Drawing.Point(172, 38);
            this.txtAño.MaxLength = 4;
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(69, 21);
            this.txtAño.TabIndex = 4;
            this.txtAño.Text = "0";
            this.txtAño.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtAño.Leave += new System.EventHandler(this.txtAño_Leave);
            this.txtAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAño_KeyPress);
            // 
            // lblAño
            // 
            this.lblAño.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(135, 36);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(47, 22);
            this.lblAño.TabIndex = 15;
            this.lblAño.Text = "Año*";
            this.lblAño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(60, 37);
            this.txtValor.MaxLength = 12;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(69, 21);
            this.txtValor.TabIndex = 3;
            this.txtValor.Text = "0";
            this.txtValor.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // lblValor
            // 
            this.lblValor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(8, 36);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 22);
            this.lblValor.TabIndex = 13;
            this.lblValor.Text = "Valor*";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCedulaAho
            // 
            this.txtCedulaAho.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaAho.Location = new System.Drawing.Point(385, 10);
            this.txtCedulaAho.MaxLength = 12;
            this.txtCedulaAho.Name = "txtCedulaAho";
            this.txtCedulaAho.Size = new System.Drawing.Size(74, 21);
            this.txtCedulaAho.TabIndex = 2;
            this.txtCedulaAho.Text = "0";
            this.txtCedulaAho.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtCedulaAho.Leave += new System.EventHandler(this.txtCedulaAho_Leave);
            this.txtCedulaAho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaAho_KeyPress);
            // 
            // lblAhorrador
            // 
            this.lblAhorrador.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAhorrador.Location = new System.Drawing.Point(312, 9);
            this.lblAhorrador.Name = "lblAhorrador";
            this.lblAhorrador.Size = new System.Drawing.Size(67, 22);
            this.lblAhorrador.TabIndex = 11;
            this.lblAhorrador.Text = "Ahorrador*";
            this.lblAhorrador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFechaCuenta
            // 
            this.dtpFechaCuenta.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCuenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCuenta.Location = new System.Drawing.Point(224, 10);
            this.dtpFechaCuenta.Name = "dtpFechaCuenta";
            this.dtpFechaCuenta.Size = new System.Drawing.Size(86, 21);
            this.dtpFechaCuenta.TabIndex = 1;
            this.dtpFechaCuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaCuenta_KeyPress);
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(127, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(99, 22);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha Apertura*";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCuenta
            // 
            this.txtCuenta.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuenta.Location = new System.Drawing.Point(62, 10);
            this.txtCuenta.MaxLength = 4;
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(61, 21);
            this.txtCuenta.TabIndex = 0;
            this.txtCuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblCuenta
            // 
            this.lblCuenta.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuenta.Location = new System.Drawing.Point(8, 9);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(59, 22);
            this.lblCuenta.TabIndex = 0;
            this.lblCuenta.Text = "Cuenta*";
            this.lblCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmAhorrosaFuturo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 410);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlControles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAhorrosaFuturo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de ahorros a futuro";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAhorrosaFuturo)).EndInit();
            this.pnlControles.ResumeLayout(false);
            this.pnlControles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvAhorrosaFuturo;
        private System.Windows.Forms.TextBox txtNomAhorrador;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label lblCuenta;
        private Texto.Texto txtCedulaAho;
        private System.Windows.Forms.Label lblAhorrador;
        private System.Windows.Forms.DateTimePicker dtpFechaCuenta;
        private System.Windows.Forms.Label lblFecha;
        private Texto.Texto txtAño;
        private System.Windows.Forms.Label lblAño;
        private Texto.Texto txtValor;
        private System.Windows.Forms.Label lblValor;
        private Texto.Texto txtCuotas;
        private System.Windows.Forms.Label lblCuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cédula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Años;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuotas;
    }
}
