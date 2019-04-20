namespace Mutuales2020.Ahorros
{
    partial class FrmAhorradores
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
            this.dgvAhorradores = new System.Windows.Forms.DataGridView();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.txtLugardeExpedicion = new Texto.Texto();
            this.lblLugardeExpedicion = new System.Windows.Forms.Label();
            this.dtmFechaExpedicion = new System.Windows.Forms.DateTimePicker();
            this.lblFechadeExpedicion = new System.Windows.Forms.Label();
            this.chkExcenta4xMil = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtApellidoAut = new Texto.Texto();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreAut = new Texto.Texto();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCedulaAut = new Texto.Texto();
            this.label3 = new System.Windows.Forms.Label();
            this.chkAhorroEstudiantil = new System.Windows.Forms.CheckBox();
            this.cboOrigen = new System.Windows.Forms.ComboBox();
            this.grpBeneficiarios = new System.Windows.Forms.GroupBox();
            this.txtApellidoBeneficiario = new Texto.Texto();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtNombreBeneficiario = new Texto.Texto();
            this.lblNombreBeneficiario = new System.Windows.Forms.Label();
            this.txtCedulaBeneficiario = new Texto.Texto();
            this.lblCedulaBeneficiario = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
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
            this.txtCedula = new Texto.Texto();
            this.txtCodigo = new Texto.Texto();
            this.lblCédula = new System.Windows.Forms.Label();
            this.lblSocio = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAhorradores)).BeginInit();
            this.pnlControles.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpBeneficiarios.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(4, 560);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 55);
            this.panel1.TabIndex = 7;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(512, 3);
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
            this.btnModificar.Location = new System.Drawing.Point(207, 3);
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
            this.btnSalir.Location = new System.Drawing.Point(617, 3);
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
            this.btnCancelar.Location = new System.Drawing.Point(407, 3);
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
            this.btnEliminar.Location = new System.Drawing.Point(302, 3);
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
            this.btnGuardar.Location = new System.Drawing.Point(102, 3);
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
            this.pnlTitulo.Size = new System.Drawing.Size(820, 57);
            this.pnlTitulo.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(1, 1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(814, 54);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "AHORRADORES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvAhorradores
            // 
            this.dgvAhorradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAhorradores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grupo,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvAhorradores.Location = new System.Drawing.Point(7, 295);
            this.dgvAhorradores.Name = "dgvAhorradores";
            this.dgvAhorradores.ReadOnly = true;
            this.dgvAhorradores.Size = new System.Drawing.Size(805, 182);
            this.dgvAhorradores.TabIndex = 8;
            this.dgvAhorradores.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            // 
            // Grupo
            // 
            this.Grupo.DataPropertyName = "intCodigoSoc";
            this.Grupo.HeaderText = "Socio";
            this.Grupo.Name = "Grupo";
            this.Grupo.ReadOnly = true;
            this.Grupo.Width = 80;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "strCedulaAho";
            this.Column1.HeaderText = "Cédula";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "strNombreAho";
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "strApellidoAho";
            this.Column3.HeaderText = "Apellido";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 180;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "strTelefono";
            this.Column4.HeaderText = "Teléfono";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 75;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "strDireccion";
            this.Column5.HeaderText = "Dirección";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // pnlControles
            // 
            this.pnlControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControles.Controls.Add(this.txtLugardeExpedicion);
            this.pnlControles.Controls.Add(this.lblLugardeExpedicion);
            this.pnlControles.Controls.Add(this.dtmFechaExpedicion);
            this.pnlControles.Controls.Add(this.lblFechadeExpedicion);
            this.pnlControles.Controls.Add(this.chkExcenta4xMil);
            this.pnlControles.Controls.Add(this.groupBox1);
            this.pnlControles.Controls.Add(this.chkAhorroEstudiantil);
            this.pnlControles.Controls.Add(this.cboOrigen);
            this.pnlControles.Controls.Add(this.grpBeneficiarios);
            this.pnlControles.Controls.Add(this.lblOrigen);
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
            this.pnlControles.Controls.Add(this.txtCedula);
            this.pnlControles.Controls.Add(this.txtCodigo);
            this.pnlControles.Controls.Add(this.lblCédula);
            this.pnlControles.Controls.Add(this.lblSocio);
            this.pnlControles.Controls.Add(this.dgvAhorradores);
            this.pnlControles.Location = new System.Drawing.Point(4, 67);
            this.pnlControles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(820, 489);
            this.pnlControles.TabIndex = 6;
            // 
            // txtLugardeExpedicion
            // 
            this.txtLugardeExpedicion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugardeExpedicion.Location = new System.Drawing.Point(350, 133);
            this.txtLugardeExpedicion.MaxLength = 60;
            this.txtLugardeExpedicion.Name = "txtLugardeExpedicion";
            this.txtLugardeExpedicion.Size = new System.Drawing.Size(222, 21);
            this.txtLugardeExpedicion.TabIndex = 83;
            this.txtLugardeExpedicion.Tipo = Texto.Texto.Opciones.Texto;
            this.txtLugardeExpedicion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLugardeExpedicion_KeyPress);
            // 
            // lblLugardeExpedicion
            // 
            this.lblLugardeExpedicion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugardeExpedicion.Location = new System.Drawing.Point(226, 133);
            this.lblLugardeExpedicion.Name = "lblLugardeExpedicion";
            this.lblLugardeExpedicion.Size = new System.Drawing.Size(130, 20);
            this.lblLugardeExpedicion.TabIndex = 84;
            this.lblLugardeExpedicion.Text = "Lugar de expedición:";
            this.lblLugardeExpedicion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtmFechaExpedicion
            // 
            this.dtmFechaExpedicion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmFechaExpedicion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFechaExpedicion.Location = new System.Drawing.Point(130, 131);
            this.dtmFechaExpedicion.Name = "dtmFechaExpedicion";
            this.dtmFechaExpedicion.Size = new System.Drawing.Size(83, 21);
            this.dtmFechaExpedicion.TabIndex = 81;
            this.dtmFechaExpedicion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtmFechaExpedicion_KeyPress);
            // 
            // lblFechadeExpedicion
            // 
            this.lblFechadeExpedicion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechadeExpedicion.Location = new System.Drawing.Point(7, 130);
            this.lblFechadeExpedicion.Name = "lblFechadeExpedicion";
            this.lblFechadeExpedicion.Size = new System.Drawing.Size(123, 22);
            this.lblFechadeExpedicion.TabIndex = 82;
            this.lblFechadeExpedicion.Text = "Fecha de expedición";
            this.lblFechadeExpedicion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkExcenta4xMil
            // 
            this.chkExcenta4xMil.AutoSize = true;
            this.chkExcenta4xMil.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExcenta4xMil.Location = new System.Drawing.Point(631, 104);
            this.chkExcenta4xMil.Name = "chkExcenta4xMil";
            this.chkExcenta4xMil.Size = new System.Drawing.Size(127, 19);
            this.chkExcenta4xMil.TabIndex = 80;
            this.chkExcenta4xMil.Text = "Se le Cobra 4 x Mil";
            this.chkExcenta4xMil.UseVisualStyleBackColor = true;
            this.chkExcenta4xMil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chkExcenta4xMil_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtApellidoAut);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombreAut);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCedulaAut);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 59);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Autorizado para retirar dinero";
            // 
            // txtApellidoAut
            // 
            this.txtApellidoAut.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoAut.Location = new System.Drawing.Point(449, 19);
            this.txtApellidoAut.MaxLength = 25;
            this.txtApellidoAut.Name = "txtApellidoAut";
            this.txtApellidoAut.Size = new System.Drawing.Size(172, 21);
            this.txtApellidoAut.TabIndex = 22;
            this.txtApellidoAut.Tipo = Texto.Texto.Opciones.Texto;
            this.txtApellidoAut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoAut_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 52;
            this.label1.Text = "Apellidos*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombreAut
            // 
            this.txtNombreAut.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAut.Location = new System.Drawing.Point(209, 19);
            this.txtNombreAut.MaxLength = 25;
            this.txtNombreAut.Name = "txtNombreAut";
            this.txtNombreAut.Size = new System.Drawing.Size(172, 21);
            this.txtNombreAut.TabIndex = 21;
            this.txtNombreAut.Tipo = Texto.Texto.Opciones.Texto;
            this.txtNombreAut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreAut_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nombre*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCedulaAut
            // 
            this.txtCedulaAut.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaAut.Location = new System.Drawing.Point(60, 21);
            this.txtCedulaAut.MaxLength = 12;
            this.txtCedulaAut.Name = "txtCedulaAut";
            this.txtCedulaAut.Size = new System.Drawing.Size(84, 21);
            this.txtCedulaAut.TabIndex = 20;
            this.txtCedulaAut.Text = "0";
            this.txtCedulaAut.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtCedulaAut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaAut_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 45;
            this.label3.Text = "Cédula*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkAhorroEstudiantil
            // 
            this.chkAhorroEstudiantil.AutoSize = true;
            this.chkAhorroEstudiantil.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAhorroEstudiantil.Location = new System.Drawing.Point(502, 104);
            this.chkAhorroEstudiantil.Name = "chkAhorroEstudiantil";
            this.chkAhorroEstudiantil.Size = new System.Drawing.Size(113, 19);
            this.chkAhorroEstudiantil.TabIndex = 16;
            this.chkAhorroEstudiantil.Text = "Ahorro Especial";
            this.chkAhorroEstudiantil.UseVisualStyleBackColor = true;
            this.chkAhorroEstudiantil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chkAhorroEstudiantil_KeyPress);
            // 
            // cboOrigen
            // 
            this.cboOrigen.DisplayMember = "strNomBarrio";
            this.cboOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrigen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOrigen.FormattingEnabled = true;
            this.cboOrigen.Items.AddRange(new object[] {
            "Socio",
            "Agraciado"});
            this.cboOrigen.Location = new System.Drawing.Point(356, 101);
            this.cboOrigen.Name = "cboOrigen";
            this.cboOrigen.Size = new System.Drawing.Size(127, 23);
            this.cboOrigen.TabIndex = 15;
            this.cboOrigen.ValueMember = "strCodBarrio";
            this.cboOrigen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboOrigen_KeyPress);
            // 
            // grpBeneficiarios
            // 
            this.grpBeneficiarios.Controls.Add(this.txtApellidoBeneficiario);
            this.grpBeneficiarios.Controls.Add(this.lblApellidos);
            this.grpBeneficiarios.Controls.Add(this.txtNombreBeneficiario);
            this.grpBeneficiarios.Controls.Add(this.lblNombreBeneficiario);
            this.grpBeneficiarios.Controls.Add(this.txtCedulaBeneficiario);
            this.grpBeneficiarios.Controls.Add(this.lblCedulaBeneficiario);
            this.grpBeneficiarios.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBeneficiarios.Location = new System.Drawing.Point(10, 161);
            this.grpBeneficiarios.Name = "grpBeneficiarios";
            this.grpBeneficiarios.Size = new System.Drawing.Size(791, 59);
            this.grpBeneficiarios.TabIndex = 75;
            this.grpBeneficiarios.TabStop = false;
            this.grpBeneficiarios.Text = "Beneficiarios";
            // 
            // txtApellidoBeneficiario
            // 
            this.txtApellidoBeneficiario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoBeneficiario.Location = new System.Drawing.Point(449, 19);
            this.txtApellidoBeneficiario.MaxLength = 25;
            this.txtApellidoBeneficiario.Name = "txtApellidoBeneficiario";
            this.txtApellidoBeneficiario.Size = new System.Drawing.Size(172, 21);
            this.txtApellidoBeneficiario.TabIndex = 19;
            this.txtApellidoBeneficiario.Tipo = Texto.Texto.Opciones.Texto;
            this.txtApellidoBeneficiario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoBeneficiario_KeyPress);
            // 
            // lblApellidos
            // 
            this.lblApellidos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(387, 21);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(66, 22);
            this.lblApellidos.TabIndex = 52;
            this.lblApellidos.Text = "Apellidos*";
            this.lblApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombreBeneficiario
            // 
            this.txtNombreBeneficiario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreBeneficiario.Location = new System.Drawing.Point(209, 19);
            this.txtNombreBeneficiario.MaxLength = 25;
            this.txtNombreBeneficiario.Name = "txtNombreBeneficiario";
            this.txtNombreBeneficiario.Size = new System.Drawing.Size(172, 21);
            this.txtNombreBeneficiario.TabIndex = 18;
            this.txtNombreBeneficiario.Tipo = Texto.Texto.Opciones.Texto;
            this.txtNombreBeneficiario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreBeneficiario_KeyPress);
            // 
            // lblNombreBeneficiario
            // 
            this.lblNombreBeneficiario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreBeneficiario.Location = new System.Drawing.Point(150, 21);
            this.lblNombreBeneficiario.Name = "lblNombreBeneficiario";
            this.lblNombreBeneficiario.Size = new System.Drawing.Size(65, 22);
            this.lblNombreBeneficiario.TabIndex = 50;
            this.lblNombreBeneficiario.Text = "Nombre*";
            this.lblNombreBeneficiario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCedulaBeneficiario
            // 
            this.txtCedulaBeneficiario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaBeneficiario.Location = new System.Drawing.Point(60, 21);
            this.txtCedulaBeneficiario.MaxLength = 12;
            this.txtCedulaBeneficiario.Name = "txtCedulaBeneficiario";
            this.txtCedulaBeneficiario.Size = new System.Drawing.Size(84, 21);
            this.txtCedulaBeneficiario.TabIndex = 17;
            this.txtCedulaBeneficiario.Text = "0";
            this.txtCedulaBeneficiario.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtCedulaBeneficiario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaBeneficiario_KeyPress);
            // 
            // lblCedulaBeneficiario
            // 
            this.lblCedulaBeneficiario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaBeneficiario.Location = new System.Drawing.Point(10, 19);
            this.lblCedulaBeneficiario.Name = "lblCedulaBeneficiario";
            this.lblCedulaBeneficiario.Size = new System.Drawing.Size(53, 22);
            this.lblCedulaBeneficiario.TabIndex = 45;
            this.lblCedulaBeneficiario.Text = "Cédula*";
            this.lblCedulaBeneficiario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrigen
            // 
            this.lblOrigen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.Location = new System.Drawing.Point(299, 99);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(50, 22);
            this.lblOrigen.TabIndex = 74;
            this.lblOrigen.Text = "Origen*";
            this.lblOrigen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(60, 101);
            this.txtMail.MaxLength = 60;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(222, 21);
            this.txtMail.TabIndex = 14;
            this.txtMail.Tipo = Texto.Texto.Opciones.Texto;
            this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMail_KeyPress);
            // 
            // lblMail
            // 
            this.lblMail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(7, 101);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(48, 20);
            this.lblMail.TabIndex = 70;
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
            "Primaria",
            "Secundaria",
            "Tecnica",
            "Tecnologa",
            "Universitaria"});
            this.cboEscolaridad.Location = new System.Drawing.Point(674, 69);
            this.cboEscolaridad.Name = "cboEscolaridad";
            this.cboEscolaridad.Size = new System.Drawing.Size(127, 23);
            this.cboEscolaridad.TabIndex = 13;
            this.cboEscolaridad.ValueMember = "strCodigoApp";
            this.cboEscolaridad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboEscolaridad_KeyPress);
            // 
            // lblEscolaridad
            // 
            this.lblEscolaridad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolaridad.Location = new System.Drawing.Point(596, 70);
            this.lblEscolaridad.Name = "lblEscolaridad";
            this.lblEscolaridad.Size = new System.Drawing.Size(84, 22);
            this.lblEscolaridad.TabIndex = 67;
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
            this.cboSexo.Location = new System.Drawing.Point(65, 72);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(89, 23);
            this.cboSexo.TabIndex = 10;
            this.cboSexo.ValueMember = "strCodigoApp";
            this.cboSexo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboSexo_KeyPress);
            // 
            // lblSexo
            // 
            this.lblSexo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(7, 70);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(44, 22);
            this.lblSexo.TabIndex = 65;
            this.lblSexo.Text = "Sexo*";
            this.lblSexo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboOficios
            // 
            this.cboOficios.DisplayMember = "strNomOficio";
            this.cboOficios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOficios.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOficios.FormattingEnabled = true;
            this.cboOficios.Location = new System.Drawing.Point(436, 70);
            this.cboOficios.Name = "cboOficios";
            this.cboOficios.Size = new System.Drawing.Size(149, 23);
            this.cboOficios.TabIndex = 12;
            this.cboOficios.ValueMember = "strCodOficio";
            this.cboOficios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboOficios_KeyPress);
            // 
            // lblOficios
            // 
            this.lblOficios.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOficios.Location = new System.Drawing.Point(391, 68);
            this.lblOficios.Name = "lblOficios";
            this.lblOficios.Size = new System.Drawing.Size(47, 22);
            this.lblOficios.TabIndex = 63;
            this.lblOficios.Text = "Oficio*";
            this.lblOficios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboBarrios
            // 
            this.cboBarrios.DisplayMember = "strNomBarrio";
            this.cboBarrios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarrios.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBarrios.FormattingEnabled = true;
            this.cboBarrios.Location = new System.Drawing.Point(219, 70);
            this.cboBarrios.Name = "cboBarrios";
            this.cboBarrios.Size = new System.Drawing.Size(163, 23);
            this.cboBarrios.TabIndex = 11;
            this.cboBarrios.ValueMember = "strCodBarrio";
            this.cboBarrios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboBarrios_KeyPress);
            // 
            // lblBarrio
            // 
            this.lblBarrio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.Location = new System.Drawing.Point(173, 68);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(47, 22);
            this.lblBarrio.TabIndex = 61;
            this.lblBarrio.Text = "Barrio*";
            this.lblBarrio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(718, 39);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(83, 21);
            this.dtpNacimiento.TabIndex = 9;
            this.dtpNacimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpNacimiento_KeyPress);
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacimiento.Location = new System.Drawing.Point(632, 37);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(80, 22);
            this.lblNacimiento.TabIndex = 59;
            this.lblNacimiento.Text = "Nacimiento*";
            this.lblNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIngreso.Location = new System.Drawing.Point(542, 38);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(83, 21);
            this.dtpIngreso.TabIndex = 8;
            this.dtpIngreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpIngreso_KeyPress);
            // 
            // lblIngreso
            // 
            this.lblIngreso.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.Location = new System.Drawing.Point(472, 37);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(64, 22);
            this.lblIngreso.TabIndex = 57;
            this.lblIngreso.Text = "Ingreso*";
            this.lblIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(370, 40);
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
            this.lblTelefono.Location = new System.Drawing.Point(299, 40);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(69, 22);
            this.lblTelefono.TabIndex = 55;
            this.lblTelefono.Text = "Teléfono*";
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(70, 43);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(226, 21);
            this.txtDireccion.TabIndex = 6;
            this.txtDireccion.Tipo = Texto.Texto.Opciones.Texto;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(7, 38);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(66, 22);
            this.lblDireccion.TabIndex = 54;
            this.lblDireccion.Text = "Dirección*";
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtApellido2
            // 
            this.txtApellido2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtApellido2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido2.Location = new System.Drawing.Point(722, 9);
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
            this.lblApellido2.Location = new System.Drawing.Point(660, 8);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(66, 22);
            this.lblApellido2.TabIndex = 51;
            this.lblApellido2.Text = "Apellido 2º";
            this.lblApellido2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtApellido1
            // 
            this.txtApellido1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtApellido1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido1.Location = new System.Drawing.Point(566, 11);
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
            this.lblApellido1.Location = new System.Drawing.Point(499, 6);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(76, 22);
            this.lblApellido1.TabIndex = 49;
            this.lblApellido1.Text = "Apellido 1º*";
            this.lblApellido1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNombre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(390, 10);
            this.txtNombre.MaxLength = 25;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(110, 21);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Tipo = Texto.Texto.Opciones.Texto;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(335, 7);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 22);
            this.lblNombre.TabIndex = 48;
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
            this.cboTipo.Location = new System.Drawing.Point(280, 7);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(52, 23);
            this.cboTipo.TabIndex = 2;
            this.cboTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboTipo_KeyPress);
            // 
            // lblTipo
            // 
            this.lblTipo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(245, 8);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(36, 22);
            this.lblTipo.TabIndex = 46;
            this.lblTipo.Text = "Tipo*";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCedula.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(145, 11);
            this.txtCedula.MaxLength = 12;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(101, 21);
            this.txtCedula.TabIndex = 1;
            this.txtCedula.Text = "0";
            this.txtCedula.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(50, 9);
            this.txtCodigo.MaxLength = 4;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(47, 21);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = "0";
            this.txtCodigo.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblCédula
            // 
            this.lblCédula.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCédula.Location = new System.Drawing.Point(98, 10);
            this.lblCédula.Name = "lblCédula";
            this.lblCédula.Size = new System.Drawing.Size(59, 22);
            this.lblCédula.TabIndex = 42;
            this.lblCédula.Text = "Cédula*";
            this.lblCédula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSocio
            // 
            this.lblSocio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocio.Location = new System.Drawing.Point(7, 9);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(56, 22);
            this.lblSocio.TabIndex = 41;
            this.lblSocio.Text = "Socio*";
            this.lblSocio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmAhorradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 620);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlControles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAhorradores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de ahorradores";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAhorradores)).EndInit();
            this.pnlControles.ResumeLayout(false);
            this.pnlControles.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBeneficiarios.ResumeLayout(false);
            this.grpBeneficiarios.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvAhorradores;
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
        private System.Windows.Forms.Label lblCédula;
        private System.Windows.Forms.Label lblSocio;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.GroupBox grpBeneficiarios;
        private Texto.Texto txtCedulaBeneficiario;
        private System.Windows.Forms.Label lblCedulaBeneficiario;
        private Texto.Texto txtNombreBeneficiario;
        private System.Windows.Forms.Label lblNombreBeneficiario;
        private Texto.Texto txtApellidoBeneficiario;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.ComboBox cboOrigen;
        private System.Windows.Forms.CheckBox chkAhorroEstudiantil;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox1;
        private Texto.Texto txtApellidoAut;
        private System.Windows.Forms.Label label1;
        private Texto.Texto txtNombreAut;
        private System.Windows.Forms.Label label2;
        private Texto.Texto txtCedulaAut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkExcenta4xMil;
        private Texto.Texto txtLugardeExpedicion;
        private System.Windows.Forms.Label lblLugardeExpedicion;
        private System.Windows.Forms.DateTimePicker dtmFechaExpedicion;
        private System.Windows.Forms.Label lblFechadeExpedicion;
    }
}

