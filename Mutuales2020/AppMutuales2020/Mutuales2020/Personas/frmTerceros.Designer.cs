namespace Mutuales2020.Personas
{
    partial class FrmTerceros
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
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.txtCelular = new Texto.Texto();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtMail = new Texto.Texto();
            this.lblMail = new System.Windows.Forms.Label();
            this.cboTipoTercero = new System.Windows.Forms.ComboBox();
            this.lblTipoTercero = new System.Windows.Forms.Label();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.txtTelefono = new Texto.Texto();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDireccion = new Texto.Texto();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtContacto = new Texto.Texto();
            this.lblContacto = new System.Windows.Forms.Label();
            this.txtEmpresa = new Texto.Texto();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtCodigo = new Texto.Texto();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Appl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.pnlControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnFiltrar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Location = new System.Drawing.Point(4, 351);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 55);
            this.panel1.TabIndex = 7;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(501, 4);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(99, 47);
            this.btnFiltrar.TabIndex = 14;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.ImageIndex = 0;
            this.btnModificar.Location = new System.Drawing.Point(196, 3);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(89, 47);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(606, 4);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 47);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(396, 3);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 47);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(291, 3);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 47);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageIndex = 0;
            this.btnGuardar.Location = new System.Drawing.Point(91, 3);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 47);
            this.btnGuardar.TabIndex = 10;
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
            this.pnlTitulo.Size = new System.Drawing.Size(820, 36);
            this.pnlTitulo.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(1, 1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(818, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "TERCEROS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Contacto,
            this.Appl,
            this.Telefono,
            this.Celular});
            this.dgvClientes.Location = new System.Drawing.Point(7, 106);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(805, 183);
            this.dgvClientes.TabIndex = 8;
            this.dgvClientes.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            // 
            // pnlControles
            // 
            this.pnlControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControles.Controls.Add(this.txtCelular);
            this.pnlControles.Controls.Add(this.lblCelular);
            this.pnlControles.Controls.Add(this.txtMail);
            this.pnlControles.Controls.Add(this.lblMail);
            this.pnlControles.Controls.Add(this.cboTipoTercero);
            this.pnlControles.Controls.Add(this.lblTipoTercero);
            this.pnlControles.Controls.Add(this.dtpIngreso);
            this.pnlControles.Controls.Add(this.lblIngreso);
            this.pnlControles.Controls.Add(this.txtTelefono);
            this.pnlControles.Controls.Add(this.lblTelefono);
            this.pnlControles.Controls.Add(this.txtDireccion);
            this.pnlControles.Controls.Add(this.lblDireccion);
            this.pnlControles.Controls.Add(this.txtContacto);
            this.pnlControles.Controls.Add(this.lblContacto);
            this.pnlControles.Controls.Add(this.txtEmpresa);
            this.pnlControles.Controls.Add(this.lblEmpresa);
            this.pnlControles.Controls.Add(this.cboTipo);
            this.pnlControles.Controls.Add(this.lblTipo);
            this.pnlControles.Controls.Add(this.txtCodigo);
            this.pnlControles.Controls.Add(this.lblCodigo);
            this.pnlControles.Controls.Add(this.dgvClientes);
            this.pnlControles.Location = new System.Drawing.Point(4, 43);
            this.pnlControles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(820, 303);
            this.pnlControles.TabIndex = 6;
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(467, 40);
            this.txtCelular.MaxLength = 15;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(115, 21);
            this.txtCelular.TabIndex = 6;
            this.txtCelular.Text = "0";
            this.txtCelular.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // lblCelular
            // 
            this.lblCelular.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(416, 38);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(50, 22);
            this.lblCelular.TabIndex = 73;
            this.lblCelular.Text = "Celular";
            this.lblCelular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(299, 73);
            this.txtMail.MaxLength = 60;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(201, 21);
            this.txtMail.TabIndex = 9;
            this.txtMail.Tipo = Texto.Texto.Opciones.Texto;
            this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMail_KeyPress);
            // 
            // lblMail
            // 
            this.lblMail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(248, 70);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(50, 22);
            this.lblMail.TabIndex = 70;
            this.lblMail.Text = "Correo*";
            this.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboTipoTercero
            // 
            this.cboTipoTercero.DisplayMember = "strCodigoApp";
            this.cboTipoTercero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoTercero.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoTercero.FormattingEnabled = true;
            this.cboTipoTercero.Items.AddRange(new object[] {
            "Cliente",
            "Proveedor",
            "Empleado"});
            this.cboTipoTercero.Location = new System.Drawing.Point(104, 72);
            this.cboTipoTercero.Name = "cboTipoTercero";
            this.cboTipoTercero.Size = new System.Drawing.Size(138, 23);
            this.cboTipoTercero.TabIndex = 8;
            this.cboTipoTercero.ValueMember = "strCodigoApp";
            this.cboTipoTercero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboTipoTercero_KeyPress);
            // 
            // lblTipoTercero
            // 
            this.lblTipoTercero.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoTercero.Location = new System.Drawing.Point(7, 70);
            this.lblTipoTercero.Name = "lblTipoTercero";
            this.lblTipoTercero.Size = new System.Drawing.Size(100, 22);
            this.lblTipoTercero.TabIndex = 67;
            this.lblTipoTercero.Text = "Tipo de tercero*";
            this.lblTipoTercero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIngreso.Location = new System.Drawing.Point(637, 40);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(83, 21);
            this.dtpIngreso.TabIndex = 7;
            this.dtpIngreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpIngreso_KeyPress);
            // 
            // lblIngreso
            // 
            this.lblIngreso.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.Location = new System.Drawing.Point(586, 38);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(56, 22);
            this.lblIngreso.TabIndex = 57;
            this.lblIngreso.Text = "Ingreso*";
            this.lblIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(319, 40);
            this.txtTelefono.MaxLength = 15;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(96, 21);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.Tipo = Texto.Texto.Opciones.Texto;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(262, 38);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(69, 22);
            this.lblTelefono.TabIndex = 55;
            this.lblTelefono.Text = "Teléfono*";
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(77, 40);
            this.txtDireccion.MaxLength = 60;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(192, 21);
            this.txtDireccion.TabIndex = 4;
            this.txtDireccion.Tipo = Texto.Texto.Opciones.Texto;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(7, 39);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(66, 22);
            this.lblDireccion.TabIndex = 54;
            this.lblDireccion.Text = "Dirección*";
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtContacto
            // 
            this.txtContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtContacto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContacto.Location = new System.Drawing.Point(606, 12);
            this.txtContacto.MaxLength = 50;
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(206, 21);
            this.txtContacto.TabIndex = 3;
            this.txtContacto.Tipo = Texto.Texto.Opciones.Texto;
            this.txtContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContacto_KeyPress);
            // 
            // lblContacto
            // 
            this.lblContacto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacto.Location = new System.Drawing.Point(543, 10);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(66, 22);
            this.lblContacto.TabIndex = 49;
            this.lblContacto.Text = "Contacto*";
            this.lblContacto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEmpresa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpresa.Location = new System.Drawing.Point(337, 12);
            this.txtEmpresa.MaxLength = 50;
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(209, 21);
            this.txtEmpresa.TabIndex = 2;
            this.txtEmpresa.Tipo = Texto.Texto.Opciones.Texto;
            this.txtEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpresa_KeyPress);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(279, 11);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(67, 22);
            this.lblEmpresa.TabIndex = 48;
            this.lblEmpresa.Text = "Empresa*";
            this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "C.C.",
            "T.I.",
            "C.E.",
            "Pas.",
            "Nit.",
            "NUI.",
            "Otro."});
            this.cboTipo.Location = new System.Drawing.Point(206, 12);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(66, 23);
            this.cboTipo.TabIndex = 1;
            this.cboTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboTipo_KeyPress);
            // 
            // lblTipo
            // 
            this.lblTipo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(173, 10);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 22);
            this.lblTipo.TabIndex = 46;
            this.lblTipo.Text = "Tipo*";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(79, 12);
            this.txtCodigo.MaxLength = 15;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(94, 21);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = "0";
            this.txtCodigo.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(7, 10);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(76, 22);
            this.lblCodigo.TabIndex = 41;
            this.lblCodigo.Text = "Documento*";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "strCodigoCli";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Contacto
            // 
            this.Contacto.DataPropertyName = "strContacto";
            this.Contacto.HeaderText = "Contacto";
            this.Contacto.Name = "Contacto";
            this.Contacto.ReadOnly = true;
            this.Contacto.Width = 225;
            // 
            // Appl
            // 
            this.Appl.DataPropertyName = "strEmpresa";
            this.Appl.HeaderText = "Empresa";
            this.Appl.Name = "Appl";
            this.Appl.ReadOnly = true;
            this.Appl.Width = 230;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "strTelefono";
            this.Telefono.HeaderText = "Télefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 95;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "strCelular";
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Width = 95;
            // 
            // FrmTerceros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlControles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTerceros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de terceros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Load);
            this.panel1.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Panel pnlControles;
        private Texto.Texto txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.ComboBox cboTipoTercero;
        private System.Windows.Forms.Label lblTipoTercero;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.Label lblIngreso;
        private Texto.Texto txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private Texto.Texto txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private Texto.Texto txtContacto;
        private System.Windows.Forms.Label lblContacto;
        private Texto.Texto txtEmpresa;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblTipo;
        private Texto.Texto txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private Texto.Texto txtCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Appl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
    }
}

