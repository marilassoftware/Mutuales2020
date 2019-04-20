namespace Mutuales2020.Personas
{
    partial class FrmAgraciados
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
            this.pnlControles = new System.Windows.Forms.Panel();
            this.txtLugardeExpedicion = new Texto.Texto();
            this.lblLugardeExpedicion = new System.Windows.Forms.Label();
            this.dtmFechaExpedicion = new System.Windows.Forms.DateTimePicker();
            this.lblFechadeExpedicion = new System.Windows.Forms.Label();
            this.cboParentesco = new System.Windows.Forms.ComboBox();
            this.txtCedula = new Texto.Texto();
            this.lblParentesco = new System.Windows.Forms.Label();
            this.lblCédula = new System.Windows.Forms.Label();
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
            this.txtCodigo = new Texto.Texto();
            this.dgvAgraciados = new System.Windows.Forms.DataGridView();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.intCodigoSoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strCedulaSoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strNombreSoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strApellidoSoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strParentesco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.pnlControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgraciados)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(4, 457);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 55);
            this.panel1.TabIndex = 7;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(495, 4);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(99, 47);
            this.btnFiltrar.TabIndex = 20;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.ImageIndex = 0;
            this.btnModificar.Location = new System.Drawing.Point(191, 3);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(89, 47);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(600, 3);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 47);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(391, 3);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 47);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(286, 3);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 47);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageIndex = 0;
            this.btnGuardar.Location = new System.Drawing.Point(86, 3);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 47);
            this.btnGuardar.TabIndex = 16;
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
            this.pnlTitulo.Size = new System.Drawing.Size(822, 57);
            this.pnlTitulo.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(-2, 1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(819, 54);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "BENEFICIARIO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlControles
            // 
            this.pnlControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControles.Controls.Add(this.txtLugardeExpedicion);
            this.pnlControles.Controls.Add(this.lblLugardeExpedicion);
            this.pnlControles.Controls.Add(this.dtmFechaExpedicion);
            this.pnlControles.Controls.Add(this.lblFechadeExpedicion);
            this.pnlControles.Controls.Add(this.cboParentesco);
            this.pnlControles.Controls.Add(this.txtCedula);
            this.pnlControles.Controls.Add(this.lblParentesco);
            this.pnlControles.Controls.Add(this.lblCédula);
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
            this.pnlControles.Controls.Add(this.txtCodigo);
            this.pnlControles.Controls.Add(this.dgvAgraciados);
            this.pnlControles.Controls.Add(this.lblCodigo);
            this.pnlControles.Location = new System.Drawing.Point(3, 65);
            this.pnlControles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(823, 390);
            this.pnlControles.TabIndex = 8;
            // 
            // txtLugardeExpedicion
            // 
            this.txtLugardeExpedicion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugardeExpedicion.Location = new System.Drawing.Point(354, 130);
            this.txtLugardeExpedicion.MaxLength = 60;
            this.txtLugardeExpedicion.Name = "txtLugardeExpedicion";
            this.txtLugardeExpedicion.Size = new System.Drawing.Size(222, 21);
            this.txtLugardeExpedicion.TabIndex = 87;
            this.txtLugardeExpedicion.Tipo = Texto.Texto.Opciones.Texto;
            this.txtLugardeExpedicion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLugardeExpedicion_KeyPress);
            // 
            // lblLugardeExpedicion
            // 
            this.lblLugardeExpedicion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugardeExpedicion.Location = new System.Drawing.Point(230, 130);
            this.lblLugardeExpedicion.Name = "lblLugardeExpedicion";
            this.lblLugardeExpedicion.Size = new System.Drawing.Size(130, 20);
            this.lblLugardeExpedicion.TabIndex = 88;
            this.lblLugardeExpedicion.Text = "Lugar de expedición:";
            this.lblLugardeExpedicion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtmFechaExpedicion
            // 
            this.dtmFechaExpedicion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmFechaExpedicion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFechaExpedicion.Location = new System.Drawing.Point(134, 128);
            this.dtmFechaExpedicion.Name = "dtmFechaExpedicion";
            this.dtmFechaExpedicion.Size = new System.Drawing.Size(83, 21);
            this.dtmFechaExpedicion.TabIndex = 85;
            this.dtmFechaExpedicion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtmFechaExpedicion_KeyPress);
            // 
            // lblFechadeExpedicion
            // 
            this.lblFechadeExpedicion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechadeExpedicion.Location = new System.Drawing.Point(8, 127);
            this.lblFechadeExpedicion.Name = "lblFechadeExpedicion";
            this.lblFechadeExpedicion.Size = new System.Drawing.Size(130, 22);
            this.lblFechadeExpedicion.TabIndex = 86;
            this.lblFechadeExpedicion.Text = "Fecha de expedición";
            this.lblFechadeExpedicion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboParentesco
            // 
            this.cboParentesco.DisplayMember = "strNomBarrio";
            this.cboParentesco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParentesco.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboParentesco.FormattingEnabled = true;
            this.cboParentesco.Items.AddRange(new object[] {
            "Madre",
            "Padre",
            "Abuelo(a)",
            "Ahijado(a)",
            "Compañero(a)",
            "Cuñado(a)",
            "Esposo(a)",
            "Hermanastro(a)",
            "Hermano(a)",
            "Hijastro(a)",
            "Hijo(a)",
            "Nieto(a)",
            "Nuera",
            "Primo(a)",
            "Sobrino(a)",
            "Suegro(a)",
            "Tio(a)",
            "Yerno",
            "Otro"});
            this.cboParentesco.Location = new System.Drawing.Point(353, 97);
            this.cboParentesco.Name = "cboParentesco";
            this.cboParentesco.Size = new System.Drawing.Size(127, 23);
            this.cboParentesco.TabIndex = 15;
            this.cboParentesco.ValueMember = "strCodBarrio";
            this.cboParentesco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboParentesco_KeyPress);
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCedula.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(242, 11);
            this.txtCedula.MaxLength = 12;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(84, 21);
            this.txtCedula.TabIndex = 2;
            this.txtCedula.Text = "0";
            this.txtCedula.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            this.txtCedula.Leave += new System.EventHandler(this.txtCedula_Leave);
            // 
            // lblParentesco
            // 
            this.lblParentesco.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParentesco.Location = new System.Drawing.Point(273, 95);
            this.lblParentesco.Name = "lblParentesco";
            this.lblParentesco.Size = new System.Drawing.Size(77, 22);
            this.lblParentesco.TabIndex = 39;
            this.lblParentesco.Text = "Parentesco*";
            this.lblParentesco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCédula
            // 
            this.lblCédula.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCédula.Location = new System.Drawing.Point(194, 9);
            this.lblCédula.Name = "lblCédula";
            this.lblCédula.Size = new System.Drawing.Size(55, 22);
            this.lblCédula.TabIndex = 2;
            this.lblCédula.Text = "Cédula*";
            this.lblCédula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(66, 100);
            this.txtMail.MaxLength = 60;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(201, 21);
            this.txtMail.TabIndex = 14;
            this.txtMail.Tipo = Texto.Texto.Opciones.Texto;
            this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMail_KeyPress);
            // 
            // lblMail
            // 
            this.lblMail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(7, 97);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(50, 22);
            this.lblMail.TabIndex = 38;
            this.lblMail.Text = "Correo";
            this.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboEscolaridad
            // 
            this.cboEscolaridad.DisplayMember = "strCodigoApp";
            this.cboEscolaridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEscolaridad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cboEscolaridad.Location = new System.Drawing.Point(678, 68);
            this.cboEscolaridad.Name = "cboEscolaridad";
            this.cboEscolaridad.Size = new System.Drawing.Size(134, 23);
            this.cboEscolaridad.TabIndex = 13;
            this.cboEscolaridad.ValueMember = "strCodigoApp";
            this.cboEscolaridad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboEscolaridad_KeyPress);
            // 
            // lblEscolaridad
            // 
            this.lblEscolaridad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolaridad.Location = new System.Drawing.Point(600, 65);
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
            this.cboSexo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cboSexo.Location = new System.Drawing.Point(58, 67);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(100, 23);
            this.cboSexo.TabIndex = 10;
            this.cboSexo.ValueMember = "strCodigoApp";
            this.cboSexo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboSexo_KeyPress);
            // 
            // lblSexo
            // 
            this.lblSexo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(8, 68);
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
            this.cboOficios.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOficios.FormattingEnabled = true;
            this.cboOficios.Location = new System.Drawing.Point(434, 68);
            this.cboOficios.Name = "cboOficios";
            this.cboOficios.Size = new System.Drawing.Size(161, 23);
            this.cboOficios.TabIndex = 12;
            this.cboOficios.ValueMember = "strCodOficio";
            this.cboOficios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboOficios_KeyPress);
            // 
            // lblOficios
            // 
            this.lblOficios.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOficios.Location = new System.Drawing.Point(392, 64);
            this.lblOficios.Name = "lblOficios";
            this.lblOficios.Size = new System.Drawing.Size(57, 22);
            this.lblOficios.TabIndex = 31;
            this.lblOficios.Text = "Oficio*";
            this.lblOficios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboBarrios
            // 
            this.cboBarrios.DisplayMember = "strNomBarrio";
            this.cboBarrios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarrios.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBarrios.FormattingEnabled = true;
            this.cboBarrios.Location = new System.Drawing.Point(211, 68);
            this.cboBarrios.Name = "cboBarrios";
            this.cboBarrios.Size = new System.Drawing.Size(175, 23);
            this.cboBarrios.TabIndex = 11;
            this.cboBarrios.ValueMember = "strCodBarrio";
            this.cboBarrios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboBarrios_KeyPress);
            // 
            // lblBarrio
            // 
            this.lblBarrio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.Location = new System.Drawing.Point(167, 66);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(48, 22);
            this.lblBarrio.TabIndex = 29;
            this.lblBarrio.Text = "Barrio*";
            this.lblBarrio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(726, 38);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(83, 21);
            this.dtpNacimiento.TabIndex = 9;
            this.dtpNacimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpNacimiento_KeyPress);
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacimiento.Location = new System.Drawing.Point(646, 39);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(79, 22);
            this.lblNacimiento.TabIndex = 24;
            this.lblNacimiento.Text = "Nacimiento*";
            this.lblNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIngreso.Location = new System.Drawing.Point(543, 42);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(83, 21);
            this.dtpIngreso.TabIndex = 8;
            this.dtpIngreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpIngreso_KeyPress);
            // 
            // lblIngreso
            // 
            this.lblIngreso.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.Location = new System.Drawing.Point(486, 40);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(63, 22);
            this.lblIngreso.TabIndex = 22;
            this.lblIngreso.Text = "Ingreso*";
            this.lblIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(384, 41);
            this.txtTelefono.MaxLength = 15;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(96, 21);
            this.txtTelefono.TabIndex = 7;
            this.txtTelefono.Tipo = Texto.Texto.Opciones.Texto;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(322, 40);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(69, 22);
            this.lblTelefono.TabIndex = 20;
            this.lblTelefono.Text = "Teléfono*";
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(73, 40);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(243, 21);
            this.txtDireccion.TabIndex = 6;
            this.txtDireccion.Tipo = Texto.Texto.Opciones.Texto;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(7, 37);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(78, 22);
            this.lblDireccion.TabIndex = 19;
            this.lblDireccion.Text = "Dirección*";
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtApellido2
            // 
            this.txtApellido2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtApellido2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido2.Location = new System.Drawing.Point(720, 11);
            this.txtApellido2.MaxLength = 15;
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(94, 21);
            this.txtApellido2.TabIndex = 5;
            this.txtApellido2.Tipo = Texto.Texto.Opciones.Texto;
            this.txtApellido2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido2_KeyPress);
            // 
            // lblApellido2
            // 
            this.lblApellido2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido2.Location = new System.Drawing.Point(657, 9);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(76, 22);
            this.lblApellido2.TabIndex = 16;
            this.lblApellido2.Text = "Apellido 2º";
            this.lblApellido2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtApellido1
            // 
            this.txtApellido1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtApellido1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido1.Location = new System.Drawing.Point(563, 11);
            this.txtApellido1.MaxLength = 15;
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(94, 21);
            this.txtApellido1.TabIndex = 4;
            this.txtApellido1.Tipo = Texto.Texto.Opciones.Texto;
            this.txtApellido1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido1_KeyPress);
            // 
            // lblApellido1
            // 
            this.lblApellido1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido1.Location = new System.Drawing.Point(496, 9);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(72, 22);
            this.lblApellido1.TabIndex = 14;
            this.lblApellido1.Text = "Apellido 1º*";
            this.lblApellido1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNombre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(383, 11);
            this.txtNombre.MaxLength = 25;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(113, 21);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Tipo = Texto.Texto.Opciones.Texto;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(325, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 22);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre*";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            "NUI.",
            "Otro."});
            this.cboTipo.Location = new System.Drawing.Point(127, 11);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(66, 23);
            this.cboTipo.TabIndex = 1;
            this.cboTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboTipo_KeyPress);
            // 
            // lblTipo
            // 
            this.lblTipo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(95, 9);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 22);
            this.lblTipo.TabIndex = 11;
            this.lblTipo.Text = "Tipo*";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(58, 11);
            this.txtCodigo.MaxLength = 4;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(37, 21);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = "0";
            this.txtCodigo.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // dgvAgraciados
            // 
            this.dgvAgraciados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgraciados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intCodigoSoc,
            this.strCedulaSoc,
            this.strNombreSoc,
            this.strApellidoSoc,
            this.strTelefono,
            this.strDireccion,
            this.strParentesco});
            this.dgvAgraciados.Location = new System.Drawing.Point(11, 157);
            this.dgvAgraciados.Name = "dgvAgraciados";
            this.dgvAgraciados.ReadOnly = true;
            this.dgvAgraciados.Size = new System.Drawing.Size(801, 228);
            this.dgvAgraciados.TabIndex = 8;
            this.dgvAgraciados.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(7, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 22);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código*";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.strCedulaSoc.DataPropertyName = "strCedulaAgra";
            this.strCedulaSoc.HeaderText = "Cédula";
            this.strCedulaSoc.Name = "strCedulaSoc";
            this.strCedulaSoc.ReadOnly = true;
            this.strCedulaSoc.Width = 80;
            // 
            // strNombreSoc
            // 
            this.strNombreSoc.DataPropertyName = "strNombreAgra";
            this.strNombreSoc.HeaderText = "Nombre";
            this.strNombreSoc.Name = "strNombreSoc";
            this.strNombreSoc.ReadOnly = true;
            this.strNombreSoc.Width = 120;
            // 
            // strApellidoSoc
            // 
            this.strApellidoSoc.DataPropertyName = "strApellidoAgra";
            this.strApellidoSoc.HeaderText = "Apellido";
            this.strApellidoSoc.Name = "strApellidoSoc";
            this.strApellidoSoc.ReadOnly = true;
            this.strApellidoSoc.Width = 120;
            // 
            // strTelefono
            // 
            this.strTelefono.DataPropertyName = "strTelefono";
            this.strTelefono.HeaderText = "Teléfono";
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
            // strParentesco
            // 
            this.strParentesco.DataPropertyName = "strParentesco";
            this.strParentesco.HeaderText = "Parentesco";
            this.strParentesco.Name = "strParentesco";
            this.strParentesco.ReadOnly = true;
            this.strParentesco.Width = 110;
            // 
            // FrmAgraciados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 521);
            this.Controls.Add(this.pnlControles);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAgraciados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de agraciados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Load);
            this.panel1.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlControles.ResumeLayout(false);
            this.pnlControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgraciados)).EndInit();
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
        private System.Windows.Forms.Panel pnlControles;
        private Texto.Texto txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.ComboBox cboEscolaridad;
        private System.Windows.Forms.Label lblEscolaridad;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cboOficios;
        private System.Windows.Forms.Label lblOficios;
        private System.Windows.Forms.ComboBox cboBarrios;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.Label lblIngreso;
        private Texto.Texto txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private Texto.Texto txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private Texto.Texto txtApellido2;
        private System.Windows.Forms.Label lblApellido2;
        private Texto.Texto txtApellido1;
        private System.Windows.Forms.Label lblApellido1;
        private Texto.Texto txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblTipo;
        private Texto.Texto txtCedula;
        private Texto.Texto txtCodigo;
        private System.Windows.Forms.DataGridView dgvAgraciados;
        private System.Windows.Forms.Label lblCédula;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cboParentesco;
        private System.Windows.Forms.Label lblParentesco;
        private Texto.Texto txtLugardeExpedicion;
        private System.Windows.Forms.Label lblLugardeExpedicion;
        private System.Windows.Forms.DateTimePicker dtmFechaExpedicion;
        private System.Windows.Forms.Label lblFechadeExpedicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn intCodigoSoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCedulaSoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn strNombreSoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn strApellidoSoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn strTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn strDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn strParentesco;
    }
}

