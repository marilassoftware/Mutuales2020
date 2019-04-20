namespace Mutuales2020.Personas
{
    partial class FrmSocios
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
            this.cboServicios = new System.Windows.Forms.ComboBox();
            this.dgvSocios = new System.Windows.Forms.DataGridView();
            this.intCodigoSoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strCedulaSoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strNombreSoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strApellidoSoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblServicio = new System.Windows.Forms.Label();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.txtLugardeExpedicion = new Texto.Texto();
            this.lblLugardeExpedicion = new System.Windows.Forms.Label();
            this.dtmFechaExpedicion = new System.Windows.Forms.DateTimePicker();
            this.lblFechadeExpedicion = new System.Windows.Forms.Label();
            this.chkNatilleraEscolar = new System.Windows.Forms.CheckBox();
            this.grpSubsidio = new System.Windows.Forms.GroupBox();
            this.txtApellidoSubsidio = new Texto.Texto();
            this.lblApellidoSubsidio = new System.Windows.Forms.Label();
            this.txtNombreSubsidio = new Texto.Texto();
            this.lblNombreSubsidio = new System.Windows.Forms.Label();
            this.txtCedulaSubsidio = new Texto.Texto();
            this.lblCedulaSubsidio = new System.Windows.Forms.Label();
            this.chkAhorrador = new System.Windows.Forms.CheckBox();
            this.txtAdulto = new Texto.Texto();
            this.lblAdultos = new System.Windows.Forms.Label();
            this.txtMail = new Texto.Texto();
            this.lblMail = new System.Windows.Forms.Label();
            this.cboEscolaridad = new System.Windows.Forms.ComboBox();
            this.lblEscolaridad = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cboOficios = new System.Windows.Forms.ComboBox();
            this.lblOficios = new System.Windows.Forms.Label();
            this.cboBarrios = new System.Windows.Forms.ComboBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.cboActivar = new System.Windows.Forms.ComboBox();
            this.lblActivar = new System.Windows.Forms.Label();
            this.txtContrato = new Texto.Texto();
            this.lblContrato = new System.Windows.Forms.Label();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.txtTelefono = new Texto.Texto();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDireccion = new Texto.Texto();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtApellido2 = new Texto.Texto();
            this.lblApellido2 = new System.Windows.Forms.Label();
            this.txtApellido1 = new Texto.Texto();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.txtNombre = new Texto.Texto();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtCedula = new Texto.Texto();
            this.txtCodigo = new Texto.Texto();
            this.lblCédula = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).BeginInit();
            this.pnlControles.SuspendLayout();
            this.grpSubsidio.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(4, 484);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 55);
            this.panel1.TabIndex = 7;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(504, 2);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(99, 47);
            this.btnFiltrar.TabIndex = 27;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.ImageIndex = 0;
            this.btnModificar.Location = new System.Drawing.Point(201, 3);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(89, 47);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(608, 3);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 47);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(401, 3);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 47);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(296, 3);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 47);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageIndex = 0;
            this.btnGuardar.Location = new System.Drawing.Point(96, 3);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 47);
            this.btnGuardar.TabIndex = 23;
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
            this.pnlTitulo.Size = new System.Drawing.Size(849, 36);
            this.pnlTitulo.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(1, 1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(842, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "AFILIADOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // cboServicios
            // 
            this.cboServicios.DisplayMember = "strNombreSpr";
            this.cboServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServicios.Font = new System.Drawing.Font("Arial", 9F);
            this.cboServicios.FormattingEnabled = true;
            this.cboServicios.Location = new System.Drawing.Point(60, 68);
            this.cboServicios.Name = "cboServicios";
            this.cboServicios.Size = new System.Drawing.Size(127, 23);
            this.cboServicios.TabIndex = 11;
            this.cboServicios.ValueMember = "strCodSpr";
            this.cboServicios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboServicios_KeyPress);
            // 
            // dgvSocios
            // 
            this.dgvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intCodigoSoc,
            this.strCedulaSoc,
            this.strNombreSoc,
            this.strApellidoSoc,
            this.strTelefono,
            this.strDireccion,
            this.strPlan});
            this.dgvSocios.Location = new System.Drawing.Point(10, 220);
            this.dgvSocios.Name = "dgvSocios";
            this.dgvSocios.ReadOnly = true;
            this.dgvSocios.Size = new System.Drawing.Size(832, 208);
            this.dgvSocios.TabIndex = 8;
            this.dgvSocios.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            // 
            // intCodigoSoc
            // 
            this.intCodigoSoc.DataPropertyName = "intCodigoSoc";
            this.intCodigoSoc.HeaderText = "Código";
            this.intCodigoSoc.Name = "intCodigoSoc";
            this.intCodigoSoc.ReadOnly = true;
            this.intCodigoSoc.Width = 60;
            // 
            // strCedulaSoc
            // 
            this.strCedulaSoc.DataPropertyName = "strCedulaSoc";
            this.strCedulaSoc.HeaderText = "Cédula";
            this.strCedulaSoc.Name = "strCedulaSoc";
            this.strCedulaSoc.ReadOnly = true;
            this.strCedulaSoc.Width = 80;
            // 
            // strNombreSoc
            // 
            this.strNombreSoc.DataPropertyName = "strNombreSoc";
            this.strNombreSoc.HeaderText = "Nombre";
            this.strNombreSoc.Name = "strNombreSoc";
            this.strNombreSoc.ReadOnly = true;
            this.strNombreSoc.Width = 120;
            // 
            // strApellidoSoc
            // 
            this.strApellidoSoc.DataPropertyName = "strApellidoSoc";
            this.strApellidoSoc.HeaderText = "Apellido";
            this.strApellidoSoc.Name = "strApellidoSoc";
            this.strApellidoSoc.ReadOnly = true;
            this.strApellidoSoc.Width = 120;
            // 
            // strTelefono
            // 
            this.strTelefono.DataPropertyName = "strTelefono";
            this.strTelefono.HeaderText = "Télefono";
            this.strTelefono.Name = "strTelefono";
            this.strTelefono.ReadOnly = true;
            this.strTelefono.Width = 80;
            // 
            // strDireccion
            // 
            this.strDireccion.DataPropertyName = "strDireccion";
            this.strDireccion.HeaderText = "Dirección";
            this.strDireccion.Name = "strDireccion";
            this.strDireccion.ReadOnly = true;
            this.strDireccion.Width = 170;
            // 
            // strPlan
            // 
            this.strPlan.DataPropertyName = "strPlan";
            this.strPlan.HeaderText = "Plan";
            this.strPlan.Name = "strPlan";
            this.strPlan.ReadOnly = true;
            this.strPlan.Width = 110;
            // 
            // lblServicio
            // 
            this.lblServicio.Font = new System.Drawing.Font("Arial", 9F);
            this.lblServicio.Location = new System.Drawing.Point(8, 66);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(66, 22);
            this.lblServicio.TabIndex = 4;
            this.lblServicio.Text = "Servicio*";
            this.lblServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlControles
            // 
            this.pnlControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControles.Controls.Add(this.txtLugardeExpedicion);
            this.pnlControles.Controls.Add(this.lblLugardeExpedicion);
            this.pnlControles.Controls.Add(this.dtmFechaExpedicion);
            this.pnlControles.Controls.Add(this.lblFechadeExpedicion);
            this.pnlControles.Controls.Add(this.chkNatilleraEscolar);
            this.pnlControles.Controls.Add(this.grpSubsidio);
            this.pnlControles.Controls.Add(this.chkAhorrador);
            this.pnlControles.Controls.Add(this.txtAdulto);
            this.pnlControles.Controls.Add(this.lblAdultos);
            this.pnlControles.Controls.Add(this.txtMail);
            this.pnlControles.Controls.Add(this.lblMail);
            this.pnlControles.Controls.Add(this.cboEscolaridad);
            this.pnlControles.Controls.Add(this.lblEscolaridad);
            this.pnlControles.Controls.Add(this.cboSexo);
            this.pnlControles.Controls.Add(this.lblSexo);
            this.pnlControles.Controls.Add(this.cboOficios);
            this.pnlControles.Controls.Add(this.lblOficios);
            this.pnlControles.Controls.Add(this.cboBarrios);
            this.pnlControles.Controls.Add(this.lblBarrio);
            this.pnlControles.Controls.Add(this.cboActivar);
            this.pnlControles.Controls.Add(this.lblActivar);
            this.pnlControles.Controls.Add(this.txtContrato);
            this.pnlControles.Controls.Add(this.lblContrato);
            this.pnlControles.Controls.Add(this.dtpNacimiento);
            this.pnlControles.Controls.Add(this.lblNacimiento);
            this.pnlControles.Controls.Add(this.dtpIngreso);
            this.pnlControles.Controls.Add(this.lblIngreso);
            this.pnlControles.Controls.Add(this.txtTelefono);
            this.pnlControles.Controls.Add(this.lblTelefono);
            this.pnlControles.Controls.Add(this.txtDireccion);
            this.pnlControles.Controls.Add(this.lblDireccion);
            this.pnlControles.Controls.Add(this.txtApellido2);
            this.pnlControles.Controls.Add(this.lblApellido2);
            this.pnlControles.Controls.Add(this.txtApellido1);
            this.pnlControles.Controls.Add(this.lblApellido1);
            this.pnlControles.Controls.Add(this.txtNombre);
            this.pnlControles.Controls.Add(this.lblNombre);
            this.pnlControles.Controls.Add(this.cboTipo);
            this.pnlControles.Controls.Add(this.lblTipo);
            this.pnlControles.Controls.Add(this.txtCedula);
            this.pnlControles.Controls.Add(this.txtCodigo);
            this.pnlControles.Controls.Add(this.dgvSocios);
            this.pnlControles.Controls.Add(this.cboServicios);
            this.pnlControles.Controls.Add(this.lblServicio);
            this.pnlControles.Controls.Add(this.lblCédula);
            this.pnlControles.Controls.Add(this.lblCodigo);
            this.pnlControles.Location = new System.Drawing.Point(4, 44);
            this.pnlControles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(849, 437);
            this.pnlControles.TabIndex = 6;
            // 
            // txtLugardeExpedicion
            // 
            this.txtLugardeExpedicion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugardeExpedicion.Location = new System.Drawing.Point(354, 137);
            this.txtLugardeExpedicion.MaxLength = 60;
            this.txtLugardeExpedicion.Name = "txtLugardeExpedicion";
            this.txtLugardeExpedicion.Size = new System.Drawing.Size(222, 21);
            this.txtLugardeExpedicion.TabIndex = 91;
            this.txtLugardeExpedicion.Tipo = Texto.Texto.Opciones.Texto;
            this.txtLugardeExpedicion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLugardeExpedicion_KeyPress);
            // 
            // lblLugardeExpedicion
            // 
            this.lblLugardeExpedicion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugardeExpedicion.Location = new System.Drawing.Point(230, 137);
            this.lblLugardeExpedicion.Name = "lblLugardeExpedicion";
            this.lblLugardeExpedicion.Size = new System.Drawing.Size(130, 20);
            this.lblLugardeExpedicion.TabIndex = 92;
            this.lblLugardeExpedicion.Text = "Lugar de expedición:";
            this.lblLugardeExpedicion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtmFechaExpedicion
            // 
            this.dtmFechaExpedicion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmFechaExpedicion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFechaExpedicion.Location = new System.Drawing.Point(134, 135);
            this.dtmFechaExpedicion.Name = "dtmFechaExpedicion";
            this.dtmFechaExpedicion.Size = new System.Drawing.Size(83, 21);
            this.dtmFechaExpedicion.TabIndex = 89;
            this.dtmFechaExpedicion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtmFechaExpedicion_KeyPress);
            // 
            // lblFechadeExpedicion
            // 
            this.lblFechadeExpedicion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechadeExpedicion.Location = new System.Drawing.Point(10, 134);
            this.lblFechadeExpedicion.Name = "lblFechadeExpedicion";
            this.lblFechadeExpedicion.Size = new System.Drawing.Size(121, 22);
            this.lblFechadeExpedicion.TabIndex = 90;
            this.lblFechadeExpedicion.Text = "Fecha de expedición";
            this.lblFechadeExpedicion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkNatilleraEscolar
            // 
            this.chkNatilleraEscolar.AutoSize = true;
            this.chkNatilleraEscolar.Font = new System.Drawing.Font("Arial", 9F);
            this.chkNatilleraEscolar.Location = new System.Drawing.Point(666, 102);
            this.chkNatilleraEscolar.Name = "chkNatilleraEscolar";
            this.chkNatilleraEscolar.Size = new System.Drawing.Size(116, 19);
            this.chkNatilleraEscolar.TabIndex = 42;
            this.chkNatilleraEscolar.Text = "Natillera escolar";
            this.chkNatilleraEscolar.UseVisualStyleBackColor = true;
            this.chkNatilleraEscolar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chkNatilleraEscolar_KeyPress);
            // 
            // grpSubsidio
            // 
            this.grpSubsidio.Controls.Add(this.txtApellidoSubsidio);
            this.grpSubsidio.Controls.Add(this.lblApellidoSubsidio);
            this.grpSubsidio.Controls.Add(this.txtNombreSubsidio);
            this.grpSubsidio.Controls.Add(this.lblNombreSubsidio);
            this.grpSubsidio.Controls.Add(this.txtCedulaSubsidio);
            this.grpSubsidio.Controls.Add(this.lblCedulaSubsidio);
            this.grpSubsidio.Location = new System.Drawing.Point(10, 162);
            this.grpSubsidio.Name = "grpSubsidio";
            this.grpSubsidio.Size = new System.Drawing.Size(720, 52);
            this.grpSubsidio.TabIndex = 41;
            this.grpSubsidio.TabStop = false;
            this.grpSubsidio.Text = "Auxilio Funerario";
            // 
            // txtApellidoSubsidio
            // 
            this.txtApellidoSubsidio.Font = new System.Drawing.Font("Arial", 9F);
            this.txtApellidoSubsidio.Location = new System.Drawing.Point(517, 16);
            this.txtApellidoSubsidio.MaxLength = 30;
            this.txtApellidoSubsidio.Name = "txtApellidoSubsidio";
            this.txtApellidoSubsidio.Size = new System.Drawing.Size(191, 21);
            this.txtApellidoSubsidio.TabIndex = 22;
            this.txtApellidoSubsidio.Tipo = Texto.Texto.Opciones.Texto;
            this.txtApellidoSubsidio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoSubsidio_KeyPress);
            // 
            // lblApellidoSubsidio
            // 
            this.lblApellidoSubsidio.Font = new System.Drawing.Font("Arial", 9F);
            this.lblApellidoSubsidio.Location = new System.Drawing.Point(457, 15);
            this.lblApellidoSubsidio.Name = "lblApellidoSubsidio";
            this.lblApellidoSubsidio.Size = new System.Drawing.Size(64, 22);
            this.lblApellidoSubsidio.TabIndex = 24;
            this.lblApellidoSubsidio.Text = "Apellido";
            this.lblApellidoSubsidio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombreSubsidio
            // 
            this.txtNombreSubsidio.Font = new System.Drawing.Font("Arial", 9F);
            this.txtNombreSubsidio.Location = new System.Drawing.Point(254, 17);
            this.txtNombreSubsidio.MaxLength = 30;
            this.txtNombreSubsidio.Name = "txtNombreSubsidio";
            this.txtNombreSubsidio.Size = new System.Drawing.Size(191, 21);
            this.txtNombreSubsidio.TabIndex = 21;
            this.txtNombreSubsidio.Tipo = Texto.Texto.Opciones.Texto;
            this.txtNombreSubsidio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreSubsidio_KeyPress);
            // 
            // lblNombreSubsidio
            // 
            this.lblNombreSubsidio.Font = new System.Drawing.Font("Arial", 9F);
            this.lblNombreSubsidio.Location = new System.Drawing.Point(194, 16);
            this.lblNombreSubsidio.Name = "lblNombreSubsidio";
            this.lblNombreSubsidio.Size = new System.Drawing.Size(52, 22);
            this.lblNombreSubsidio.TabIndex = 22;
            this.lblNombreSubsidio.Text = "Nombre";
            this.lblNombreSubsidio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCedulaSubsidio
            // 
            this.txtCedulaSubsidio.Font = new System.Drawing.Font("Arial", 9F);
            this.txtCedulaSubsidio.Location = new System.Drawing.Point(60, 17);
            this.txtCedulaSubsidio.MaxLength = 12;
            this.txtCedulaSubsidio.Name = "txtCedulaSubsidio";
            this.txtCedulaSubsidio.Size = new System.Drawing.Size(124, 21);
            this.txtCedulaSubsidio.TabIndex = 20;
            this.txtCedulaSubsidio.Text = "0";
            this.txtCedulaSubsidio.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtCedulaSubsidio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaSubsidio_KeyPress);
            // 
            // lblCedulaSubsidio
            // 
            this.lblCedulaSubsidio.Font = new System.Drawing.Font("Arial", 9F);
            this.lblCedulaSubsidio.Location = new System.Drawing.Point(11, 16);
            this.lblCedulaSubsidio.Name = "lblCedulaSubsidio";
            this.lblCedulaSubsidio.Size = new System.Drawing.Size(52, 22);
            this.lblCedulaSubsidio.TabIndex = 20;
            this.lblCedulaSubsidio.Text = "Cédula";
            this.lblCedulaSubsidio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkAhorrador
            // 
            this.chkAhorrador.AutoSize = true;
            this.chkAhorrador.Font = new System.Drawing.Font("Arial", 9F);
            this.chkAhorrador.Location = new System.Drawing.Point(576, 102);
            this.chkAhorrador.Name = "chkAhorrador";
            this.chkAhorrador.Size = new System.Drawing.Size(80, 19);
            this.chkAhorrador.TabIndex = 19;
            this.chkAhorrador.Text = "Ahorrador";
            this.chkAhorrador.UseVisualStyleBackColor = true;
            this.chkAhorrador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chkAhorrador_KeyPress);
            // 
            // txtAdulto
            // 
            this.txtAdulto.Font = new System.Drawing.Font("Arial", 9F);
            this.txtAdulto.Location = new System.Drawing.Point(514, 100);
            this.txtAdulto.MaxLength = 2;
            this.txtAdulto.Name = "txtAdulto";
            this.txtAdulto.Size = new System.Drawing.Size(56, 21);
            this.txtAdulto.TabIndex = 18;
            this.txtAdulto.Text = "0";
            this.txtAdulto.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtAdulto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdulto_KeyPress);
            this.txtAdulto.Leave += new System.EventHandler(this.txtAdulto_Leave);
            // 
            // lblAdultos
            // 
            this.lblAdultos.Font = new System.Drawing.Font("Arial", 9F);
            this.lblAdultos.Location = new System.Drawing.Point(471, 102);
            this.lblAdultos.Name = "lblAdultos";
            this.lblAdultos.Size = new System.Drawing.Size(42, 22);
            this.lblAdultos.TabIndex = 40;
            this.lblAdultos.Text = "Adultos";
            this.lblAdultos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Arial", 9F);
            this.txtMail.Location = new System.Drawing.Point(265, 100);
            this.txtMail.MaxLength = 60;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(201, 21);
            this.txtMail.TabIndex = 17;
            this.txtMail.Tipo = Texto.Texto.Opciones.Texto;
            this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMail_KeyPress);
            // 
            // lblMail
            // 
            this.lblMail.Font = new System.Drawing.Font("Arial", 9F);
            this.lblMail.Location = new System.Drawing.Point(218, 99);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(57, 22);
            this.lblMail.TabIndex = 38;
            this.lblMail.Text = "Correo";
            this.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboEscolaridad
            // 
            this.cboEscolaridad.DisplayMember = "strCodigoApp";
            this.cboEscolaridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEscolaridad.Font = new System.Drawing.Font("Arial", 9F);
            this.cboEscolaridad.FormattingEnabled = true;
            this.cboEscolaridad.Items.AddRange(new object[] {
            "Jardin",
            "Preescolar",
            "Primaria incompleta",
            "Primaria completa",
            "Secundaria incompleta",
            "Secundaria completa",
            "Técnico",
            "Tecnológo",
            "Universitario",
            "Ninguno"});
            this.cboEscolaridad.Location = new System.Drawing.Point(84, 99);
            this.cboEscolaridad.Name = "cboEscolaridad";
            this.cboEscolaridad.Size = new System.Drawing.Size(127, 23);
            this.cboEscolaridad.TabIndex = 16;
            this.cboEscolaridad.ValueMember = "strCodigoApp";
            this.cboEscolaridad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboEscolaridad_KeyPress);
            // 
            // lblEscolaridad
            // 
            this.lblEscolaridad.Font = new System.Drawing.Font("Arial", 9F);
            this.lblEscolaridad.Location = new System.Drawing.Point(8, 100);
            this.lblEscolaridad.Name = "lblEscolaridad";
            this.lblEscolaridad.Size = new System.Drawing.Size(80, 22);
            this.lblEscolaridad.TabIndex = 35;
            this.lblEscolaridad.Text = "Escolaridad*";
            this.lblEscolaridad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboSexo
            // 
            this.cboSexo.DisplayMember = "strCodigoApp";
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.Font = new System.Drawing.Font("Arial", 9F);
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cboSexo.Location = new System.Drawing.Point(737, 68);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(106, 23);
            this.cboSexo.TabIndex = 15;
            this.cboSexo.ValueMember = "strCodigoApp";
            this.cboSexo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboSexo_KeyPress);
            // 
            // lblSexo
            // 
            this.lblSexo.Font = new System.Drawing.Font("Arial", 9F);
            this.lblSexo.Location = new System.Drawing.Point(697, 66);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(49, 22);
            this.lblSexo.TabIndex = 33;
            this.lblSexo.Text = "Sexo*";
            this.lblSexo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboOficios
            // 
            this.cboOficios.DisplayMember = "strNomOficio";
            this.cboOficios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOficios.Font = new System.Drawing.Font("Arial", 9F);
            this.cboOficios.FormattingEnabled = true;
            this.cboOficios.Location = new System.Drawing.Point(574, 68);
            this.cboOficios.Name = "cboOficios";
            this.cboOficios.Size = new System.Drawing.Size(121, 23);
            this.cboOficios.TabIndex = 14;
            this.cboOficios.ValueMember = "strCodOficio";
            this.cboOficios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboOficios_KeyPress);
            // 
            // lblOficios
            // 
            this.lblOficios.Font = new System.Drawing.Font("Arial", 9F);
            this.lblOficios.Location = new System.Drawing.Point(525, 66);
            this.lblOficios.Name = "lblOficios";
            this.lblOficios.Size = new System.Drawing.Size(62, 22);
            this.lblOficios.TabIndex = 31;
            this.lblOficios.Text = "Oficios*";
            this.lblOficios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboBarrios
            // 
            this.cboBarrios.DisplayMember = "strNomBarrio";
            this.cboBarrios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarrios.Font = new System.Drawing.Font("Arial", 9F);
            this.cboBarrios.FormattingEnabled = true;
            this.cboBarrios.Location = new System.Drawing.Point(367, 68);
            this.cboBarrios.Name = "cboBarrios";
            this.cboBarrios.Size = new System.Drawing.Size(152, 23);
            this.cboBarrios.TabIndex = 13;
            this.cboBarrios.ValueMember = "strCodBarrio";
            this.cboBarrios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboBarrios_KeyPress);
            // 
            // lblBarrio
            // 
            this.lblBarrio.Font = new System.Drawing.Font("Arial", 9F);
            this.lblBarrio.Location = new System.Drawing.Point(324, 66);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(45, 22);
            this.lblBarrio.TabIndex = 29;
            this.lblBarrio.Text = "Barrio*";
            this.lblBarrio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboActivar
            // 
            this.cboActivar.DisplayMember = "strCodigoApp";
            this.cboActivar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActivar.Font = new System.Drawing.Font("Arial", 9F);
            this.cboActivar.FormattingEnabled = true;
            this.cboActivar.Items.AddRange(new object[] {
            "Activar",
            "DesActivar"});
            this.cboActivar.Location = new System.Drawing.Point(237, 69);
            this.cboActivar.Name = "cboActivar";
            this.cboActivar.Size = new System.Drawing.Size(85, 23);
            this.cboActivar.TabIndex = 12;
            this.cboActivar.ValueMember = "strCodigoApp";
            this.cboActivar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboActivar_KeyPress);
            // 
            // lblActivar
            // 
            this.lblActivar.Font = new System.Drawing.Font("Arial", 9F);
            this.lblActivar.Location = new System.Drawing.Point(190, 68);
            this.lblActivar.Name = "lblActivar";
            this.lblActivar.Size = new System.Drawing.Size(50, 22);
            this.lblActivar.TabIndex = 27;
            this.lblActivar.Text = "Activar*";
            this.lblActivar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtContrato
            // 
            this.txtContrato.Font = new System.Drawing.Font("Arial", 9F);
            this.txtContrato.Location = new System.Drawing.Point(781, 38);
            this.txtContrato.MaxLength = 4;
            this.txtContrato.Name = "txtContrato";
            this.txtContrato.Size = new System.Drawing.Size(63, 21);
            this.txtContrato.TabIndex = 10;
            this.txtContrato.Text = "0";
            this.txtContrato.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtContrato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContrato_KeyPress);
            this.txtContrato.Leave += new System.EventHandler(this.txtContrato_Leave);
            // 
            // lblContrato
            // 
            this.lblContrato.Font = new System.Drawing.Font("Arial", 9F);
            this.lblContrato.Location = new System.Drawing.Point(722, 37);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(70, 22);
            this.lblContrato.TabIndex = 26;
            this.lblContrato.Text = "Contrato";
            this.lblContrato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Font = new System.Drawing.Font("Arial", 9F);
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(635, 40);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(83, 21);
            this.dtpNacimiento.TabIndex = 9;
            this.dtpNacimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpNacimiento_KeyPress);
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.Font = new System.Drawing.Font("Arial", 9F);
            this.lblNacimiento.Location = new System.Drawing.Point(555, 37);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(81, 22);
            this.lblNacimiento.TabIndex = 24;
            this.lblNacimiento.Text = "Nacimiento*";
            this.lblNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Font = new System.Drawing.Font("Arial", 9F);
            this.dtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIngreso.Location = new System.Drawing.Point(470, 40);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(83, 21);
            this.dtpIngreso.TabIndex = 8;
            this.dtpIngreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpIngreso_KeyPress);
            // 
            // lblIngreso
            // 
            this.lblIngreso.Font = new System.Drawing.Font("Arial", 9F);
            this.lblIngreso.Location = new System.Drawing.Point(419, 37);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(60, 22);
            this.lblIngreso.TabIndex = 22;
            this.lblIngreso.Text = "Ingreso*";
            this.lblIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Arial", 9F);
            this.txtTelefono.Location = new System.Drawing.Point(319, 40);
            this.txtTelefono.MaxLength = 15;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(96, 21);
            this.txtTelefono.TabIndex = 7;
            this.txtTelefono.Text = "0";
            this.txtTelefono.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
            // 
            // lblTelefono
            // 
            this.lblTelefono.Font = new System.Drawing.Font("Arial", 9F);
            this.lblTelefono.Location = new System.Drawing.Point(260, 37);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(68, 22);
            this.lblTelefono.TabIndex = 20;
            this.lblTelefono.Text = "Teléfono";
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Arial", 9F);
            this.txtDireccion.Location = new System.Drawing.Point(71, 40);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(191, 21);
            this.txtDireccion.TabIndex = 6;
            this.txtDireccion.Tipo = Texto.Texto.Opciones.Texto;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.Font = new System.Drawing.Font("Arial", 9F);
            this.lblDireccion.Location = new System.Drawing.Point(7, 37);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(81, 22);
            this.lblDireccion.TabIndex = 19;
            this.lblDireccion.Text = "Dirección";
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtApellido2
            // 
            this.txtApellido2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtApellido2.Font = new System.Drawing.Font("Arial", 9F);
            this.txtApellido2.Location = new System.Drawing.Point(750, 11);
            this.txtApellido2.MaxLength = 15;
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(94, 21);
            this.txtApellido2.TabIndex = 5;
            this.txtApellido2.Tipo = Texto.Texto.Opciones.Texto;
            this.txtApellido2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido2_KeyPress);
            // 
            // lblApellido2
            // 
            this.lblApellido2.Font = new System.Drawing.Font("Arial", 9F);
            this.lblApellido2.Location = new System.Drawing.Point(684, 9);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(71, 22);
            this.lblApellido2.TabIndex = 16;
            this.lblApellido2.Text = "Apellido 2º";
            this.lblApellido2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtApellido1
            // 
            this.txtApellido1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtApellido1.Font = new System.Drawing.Font("Arial", 9F);
            this.txtApellido1.Location = new System.Drawing.Point(587, 11);
            this.txtApellido1.MaxLength = 15;
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(94, 21);
            this.txtApellido1.TabIndex = 4;
            this.txtApellido1.Tipo = Texto.Texto.Opciones.Texto;
            this.txtApellido1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido1_KeyPress);
            // 
            // lblApellido1
            // 
            this.lblApellido1.Font = new System.Drawing.Font("Arial", 9F);
            this.lblApellido1.Location = new System.Drawing.Point(517, 12);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(81, 22);
            this.lblApellido1.TabIndex = 14;
            this.lblApellido1.Text = "Apellido 1º*";
            this.lblApellido1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNombre.Font = new System.Drawing.Font("Arial", 9F);
            this.txtNombre.Location = new System.Drawing.Point(387, 11);
            this.txtNombre.MaxLength = 25;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(130, 21);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Tipo = Texto.Texto.Opciones.Texto;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Arial", 9F);
            this.lblNombre.Location = new System.Drawing.Point(334, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 22);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre*";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Arial", 9F);
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "C.C.",
            "T.I.",
            "C.E.",
            "Pas.",
            "NUI.",
            "Otro."});
            this.cboTipo.Location = new System.Drawing.Point(141, 11);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(57, 23);
            this.cboTipo.TabIndex = 1;
            this.cboTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboTipo_KeyPress);
            // 
            // lblTipo
            // 
            this.lblTipo.Font = new System.Drawing.Font("Arial", 9F);
            this.lblTipo.Location = new System.Drawing.Point(107, 12);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(57, 22);
            this.lblTipo.TabIndex = 11;
            this.lblTipo.Text = "Tipo*";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCedula.Font = new System.Drawing.Font("Arial", 9F);
            this.txtCedula.Location = new System.Drawing.Point(251, 13);
            this.txtCedula.MaxLength = 12;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(83, 21);
            this.txtCedula.TabIndex = 2;
            this.txtCedula.Text = "0";
            this.txtCedula.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            this.txtCedula.Leave += new System.EventHandler(this.txtCedula_Leave);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 9F);
            this.txtCodigo.Location = new System.Drawing.Point(57, 11);
            this.txtCodigo.MaxLength = 4;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(46, 21);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = "0";
            this.txtCodigo.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // lblCédula
            // 
            this.lblCédula.Font = new System.Drawing.Font("Arial", 9F);
            this.lblCédula.Location = new System.Drawing.Point(201, 11);
            this.lblCédula.Name = "lblCédula";
            this.lblCédula.Size = new System.Drawing.Size(56, 22);
            this.lblCédula.TabIndex = 2;
            this.lblCédula.Text = "Cédula*";
            this.lblCédula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 9F);
            this.lblCodigo.Location = new System.Drawing.Point(8, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(55, 22);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código*";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 543);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlControles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSocios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de socios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Load);
            this.panel1.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).EndInit();
            this.pnlControles.ResumeLayout(false);
            this.pnlControles.PerformLayout();
            this.grpSubsidio.ResumeLayout(false);
            this.grpSubsidio.PerformLayout();
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
        private System.Windows.Forms.ComboBox cboServicios;
        private System.Windows.Forms.DataGridView dgvSocios;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Label lblCédula;
        private System.Windows.Forms.Label lblCodigo;
        private Texto.Texto txtCodigo;
        private Texto.Texto txtCedula;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblTipo;
        private Texto.Texto txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private Texto.Texto txtApellido1;
        private System.Windows.Forms.Label lblApellido1;
        private Texto.Texto txtApellido2;
        private System.Windows.Forms.Label lblApellido2;
        private Texto.Texto txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private Texto.Texto txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblContrato;
        private Texto.Texto txtContrato;
        private System.Windows.Forms.ComboBox cboActivar;
        private System.Windows.Forms.Label lblActivar;
        private System.Windows.Forms.ComboBox cboBarrios;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cboOficios;
        private System.Windows.Forms.Label lblOficios;
        private System.Windows.Forms.ComboBox cboEscolaridad;
        private System.Windows.Forms.Label lblEscolaridad;
        private Texto.Texto txtMail;
        private System.Windows.Forms.Label lblMail;
        private Texto.Texto txtAdulto;
        private System.Windows.Forms.Label lblAdultos;
        private System.Windows.Forms.DataGridViewTextBoxColumn intCodigoSoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCedulaSoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn strNombreSoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn strApellidoSoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn strTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn strDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn strPlan;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.CheckBox chkAhorrador;
        private System.Windows.Forms.GroupBox grpSubsidio;
        private Texto.Texto txtNombreSubsidio;
        private System.Windows.Forms.Label lblNombreSubsidio;
        private Texto.Texto txtCedulaSubsidio;
        private System.Windows.Forms.Label lblCedulaSubsidio;
        private Texto.Texto txtApellidoSubsidio;
        private System.Windows.Forms.Label lblApellidoSubsidio;
        private System.Windows.Forms.CheckBox chkNatilleraEscolar;
        private Texto.Texto txtLugardeExpedicion;
        private System.Windows.Forms.Label lblLugardeExpedicion;
        private System.Windows.Forms.DateTimePicker dtmFechaExpedicion;
        private System.Windows.Forms.Label lblFechadeExpedicion;
    }
}

