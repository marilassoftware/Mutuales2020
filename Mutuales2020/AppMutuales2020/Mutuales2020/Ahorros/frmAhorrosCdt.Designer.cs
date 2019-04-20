namespace Mutuales2020.Ahorros
{
    partial class frmAhorrosCdt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtMeses = new Texto.Texto();
            this.lblmeses = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLiquidar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.chkAnticipado = new System.Windows.Forms.CheckBox();
            this.txtMonto = new Texto.Texto();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtIntereses = new Texto.Texto();
            this.lblIntereses = new System.Windows.Forms.Label();
            this.txtCedulaAho = new Texto.Texto();
            this.lblAhorrador = new System.Windows.Forms.Label();
            this.dtpFechaCuenta = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dgvAhorrosCdt = new System.Windows.Forms.DataGridView();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cédula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Años = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuotas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtNomAhorrador = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rptRecibos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.pnlControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAhorrosCdt)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMeses
            // 
            this.txtMeses.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeses.Location = new System.Drawing.Point(69, 38);
            this.txtMeses.MaxLength = 2;
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(37, 21);
            this.txtMeses.TabIndex = 4;
            this.txtMeses.Text = "0";
            this.txtMeses.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtMeses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMeses_KeyPress);
            this.txtMeses.Leave += new System.EventHandler(this.txtMeses_Leave);
            // 
            // lblmeses
            // 
            this.lblmeses.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmeses.Location = new System.Drawing.Point(14, 35);
            this.lblmeses.Name = "lblmeses";
            this.lblmeses.Size = new System.Drawing.Size(49, 22);
            this.lblmeses.TabIndex = 17;
            this.lblmeses.Text = "Meses*";
            this.lblmeses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLiquidar);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Location = new System.Drawing.Point(3, 353);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 55);
            this.panel1.TabIndex = 10;
            // 
            // btnLiquidar
            // 
            this.btnLiquidar.Location = new System.Drawing.Point(338, 4);
            this.btnLiquidar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLiquidar.Name = "btnLiquidar";
            this.btnLiquidar.Size = new System.Drawing.Size(99, 47);
            this.btnLiquidar.TabIndex = 10;
            this.btnLiquidar.Text = "Liquidar";
            this.btnLiquidar.UseVisualStyleBackColor = true;
            this.btnLiquidar.Click += new System.EventHandler(this.btnLiquidar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(548, 4);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 47);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(443, 4);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 47);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(233, 4);
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
            this.btnGuardar.Location = new System.Drawing.Point(128, 4);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 47);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.ImageIndex = 0;
            this.btnModificar.Location = new System.Drawing.Point(3, 4);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(89, 47);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Visible = false;
            // 
            // pnlControles
            // 
            this.pnlControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControles.Controls.Add(this.rptRecibos);
            this.pnlControles.Controls.Add(this.chkAnticipado);
            this.pnlControles.Controls.Add(this.txtMonto);
            this.pnlControles.Controls.Add(this.lblMonto);
            this.pnlControles.Controls.Add(this.txtIntereses);
            this.pnlControles.Controls.Add(this.lblIntereses);
            this.pnlControles.Controls.Add(this.txtMeses);
            this.pnlControles.Controls.Add(this.lblmeses);
            this.pnlControles.Controls.Add(this.txtCedulaAho);
            this.pnlControles.Controls.Add(this.lblAhorrador);
            this.pnlControles.Controls.Add(this.dtpFechaCuenta);
            this.pnlControles.Controls.Add(this.lblFecha);
            this.pnlControles.Controls.Add(this.dgvAhorrosCdt);
            this.pnlControles.Controls.Add(this.txtNomAhorrador);
            this.pnlControles.Controls.Add(this.txtCodigo);
            this.pnlControles.Controls.Add(this.lblCodigo);
            this.pnlControles.Location = new System.Drawing.Point(3, 67);
            this.pnlControles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(823, 283);
            this.pnlControles.TabIndex = 9;
            // 
            // chkAnticipado
            // 
            this.chkAnticipado.AutoSize = true;
            this.chkAnticipado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAnticipado.Location = new System.Drawing.Point(392, 40);
            this.chkAnticipado.Name = "chkAnticipado";
            this.chkAnticipado.Size = new System.Drawing.Size(123, 19);
            this.chkAnticipado.TabIndex = 7;
            this.chkAnticipado.Text = "Interés Anticipado";
            this.chkAnticipado.UseVisualStyleBackColor = true;
            this.chkAnticipado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chkAnticipado_KeyPress);
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(265, 36);
            this.txtMonto.MaxLength = 9;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(121, 21);
            this.txtMonto.TabIndex = 6;
            this.txtMonto.Text = "0";
            this.txtMonto.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            this.txtMonto.Leave += new System.EventHandler(this.txtMonto_Leave);
            // 
            // lblMonto
            // 
            this.lblMonto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(216, 36);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(52, 22);
            this.lblMonto.TabIndex = 21;
            this.lblMonto.Text = "Monto*";
            this.lblMonto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIntereses
            // 
            this.txtIntereses.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntereses.Location = new System.Drawing.Point(172, 38);
            this.txtIntereses.MaxLength = 5;
            this.txtIntereses.Name = "txtIntereses";
            this.txtIntereses.Size = new System.Drawing.Size(37, 21);
            this.txtIntereses.TabIndex = 5;
            this.txtIntereses.Text = "0";
            this.txtIntereses.Tipo = Texto.Texto.Opciones.Decimal;
            this.txtIntereses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIntereses_KeyPress);
            this.txtIntereses.Leave += new System.EventHandler(this.txtIntereses_Leave);
            // 
            // lblIntereses
            // 
            this.lblIntereses.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntereses.Location = new System.Drawing.Point(118, 36);
            this.lblIntereses.Name = "lblIntereses";
            this.lblIntereses.Size = new System.Drawing.Size(57, 22);
            this.lblIntereses.TabIndex = 19;
            this.lblIntereses.Text = "Interes*";
            this.lblIntereses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCedulaAho
            // 
            this.txtCedulaAho.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaAho.Location = new System.Drawing.Point(390, 9);
            this.txtCedulaAho.MaxLength = 12;
            this.txtCedulaAho.Name = "txtCedulaAho";
            this.txtCedulaAho.Size = new System.Drawing.Size(74, 21);
            this.txtCedulaAho.TabIndex = 2;
            this.txtCedulaAho.Text = "0";
            this.txtCedulaAho.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtCedulaAho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaAho_KeyPress);
            this.txtCedulaAho.Leave += new System.EventHandler(this.txtCedulaAho_Leave);
            // 
            // lblAhorrador
            // 
            this.lblAhorrador.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAhorrador.Location = new System.Drawing.Point(325, 9);
            this.lblAhorrador.Name = "lblAhorrador";
            this.lblAhorrador.Size = new System.Drawing.Size(68, 22);
            this.lblAhorrador.TabIndex = 11;
            this.lblAhorrador.Text = "Ahorrador*";
            this.lblAhorrador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFechaCuenta
            // 
            this.dtpFechaCuenta.Enabled = false;
            this.dtpFechaCuenta.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCuenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCuenta.Location = new System.Drawing.Point(223, 10);
            this.dtpFechaCuenta.Name = "dtpFechaCuenta";
            this.dtpFechaCuenta.Size = new System.Drawing.Size(95, 21);
            this.dtpFechaCuenta.TabIndex = 1;
            this.dtpFechaCuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaCuenta_KeyPress);
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(127, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(97, 22);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha Apertura*";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvAhorrosCdt
            // 
            this.dgvAhorrosCdt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAhorrosCdt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuenta,
            this.Cédula,
            this.Nombre,
            this.Apellido,
            this.Fecha,
            this.Valor,
            this.Años,
            this.Meses,
            this.Cuotas});
            this.dgvAhorrosCdt.Location = new System.Drawing.Point(11, 65);
            this.dgvAhorrosCdt.Name = "dgvAhorrosCdt";
            this.dgvAhorrosCdt.ReadOnly = true;
            this.dgvAhorrosCdt.Size = new System.Drawing.Size(805, 213);
            this.dgvAhorrosCdt.TabIndex = 8;
            this.dgvAhorrosCdt.DoubleClick += new System.EventHandler(this.dgvAhorrosCdt_DoubleClick);
            // 
            // Cuenta
            // 
            this.Cuenta.DataPropertyName = "intNumeroCdt";
            this.Cuenta.HeaderText = "Cdt";
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
            this.Nombre.Width = 140;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "decInteresesCdt";
            this.Apellido.HeaderText = "Interés";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 50;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "dtmFechaIniCdt";
            this.Fecha.HeaderText = "Fecha Inicial";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "dtmFechaFinCdt";
            this.Valor.HeaderText = "Fecha Final";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Años
            // 
            this.Años.DataPropertyName = "decMontoCdt";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Años.DefaultCellStyle = dataGridViewCellStyle1;
            this.Años.HeaderText = "Monto";
            this.Años.Name = "Años";
            this.Años.ReadOnly = true;
            this.Años.Width = 75;
            // 
            // Meses
            // 
            this.Meses.DataPropertyName = "intMesesCdt";
            this.Meses.HeaderText = "Meses";
            this.Meses.Name = "Meses";
            this.Meses.ReadOnly = true;
            this.Meses.Width = 55;
            // 
            // Cuotas
            // 
            this.Cuotas.DataPropertyName = "bitAnticipadoCdt";
            this.Cuotas.HeaderText = "Anticipado";
            this.Cuotas.Name = "Cuotas";
            this.Cuotas.ReadOnly = true;
            this.Cuotas.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cuotas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Cuotas.Width = 60;
            // 
            // txtNomAhorrador
            // 
            this.txtNomAhorrador.Enabled = false;
            this.txtNomAhorrador.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomAhorrador.Location = new System.Drawing.Point(502, 10);
            this.txtNomAhorrador.MaxLength = 100;
            this.txtNomAhorrador.Name = "txtNomAhorrador";
            this.txtNomAhorrador.Size = new System.Drawing.Size(314, 21);
            this.txtNomAhorrador.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(63, 10);
            this.txtCodigo.MaxLength = 4;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(61, 21);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = "0";
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(8, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(62, 22);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código*";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Controls.Add(this.btnModificar);
            this.pnlTitulo.Location = new System.Drawing.Point(3, 4);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(823, 57);
            this.pnlTitulo.TabIndex = 8;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(1, 1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(821, 54);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CDT";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rptRecibos
            // 
            this.rptRecibos.Location = new System.Drawing.Point(11, 228);
            this.rptRecibos.Name = "rptRecibos";
            this.rptRecibos.Size = new System.Drawing.Size(805, 50);
            this.rptRecibos.TabIndex = 66;
            this.rptRecibos.Visible = false;
            // 
            // frmAhorrosCdt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 412);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlControles);
            this.Controls.Add(this.pnlTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAhorrosCdt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ahorros Cdt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAhorrosCdt_FormClosed);
            this.Load += new System.EventHandler(this.frmAhorrosCdt_Load);
            this.panel1.ResumeLayout(false);
            this.pnlControles.ResumeLayout(false);
            this.pnlControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAhorrosCdt)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Texto.Texto txtMeses;
        private System.Windows.Forms.Label lblmeses;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnlControles;
        private Texto.Texto txtCedulaAho;
        private System.Windows.Forms.Label lblAhorrador;
        private System.Windows.Forms.DateTimePicker dtpFechaCuenta;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridView dgvAhorrosCdt;
        private System.Windows.Forms.TextBox txtNomAhorrador;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private Texto.Texto txtIntereses;
        private System.Windows.Forms.Label lblIntereses;
        private System.Windows.Forms.Button btnLiquidar;
        private Texto.Texto txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.CheckBox chkAnticipado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cédula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Años;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meses;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Cuotas;
        private Microsoft.Reporting.WinForms.ReportViewer rptRecibos;
    }
}