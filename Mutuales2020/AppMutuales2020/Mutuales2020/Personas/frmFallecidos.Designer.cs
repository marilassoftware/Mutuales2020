namespace Mutuales2020.Personas
{
    partial class FrmFallecidos
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
            this.dgvFallecidos = new System.Windows.Forms.DataGridView();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Appl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strApellidoFal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strApellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strNotaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strFolio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intAños = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intPagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strProcedencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitHecho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strComentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtmFechaFal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtmFechaNuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCedulaAgra = new Texto.Texto();
            this.lblCedulaAgra = new System.Windows.Forms.Label();
            this.txtComentario = new Texto.Texto();
            this.dgvAgraciados = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblComentario = new System.Windows.Forms.Label();
            this.chkHecho = new System.Windows.Forms.CheckBox();
            this.txtPagado = new Texto.Texto();
            this.lblPagado = new System.Windows.Forms.Label();
            this.txtSocio = new Texto.Texto();
            this.lblSocio = new System.Windows.Forms.Label();
            this.txtAños = new Texto.Texto();
            this.lblAños = new System.Windows.Forms.Label();
            this.dtpAnuncio = new System.Windows.Forms.DateTimePicker();
            this.lblAnuncio = new System.Windows.Forms.Label();
            this.dtpFallecido = new System.Windows.Forms.DateTimePicker();
            this.lblFallecido = new System.Windows.Forms.Label();
            this.txtNotaria = new Texto.Texto();
            this.lblNotaria = new System.Windows.Forms.Label();
            this.txtFolio = new Texto.Texto();
            this.lblFolio = new System.Windows.Forms.Label();
            this.txtApellido2 = new Texto.Texto();
            this.lblApellido2 = new System.Windows.Forms.Label();
            this.txtApellido1 = new Texto.Texto();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.txtNombre = new Texto.Texto();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtCedula = new Texto.Texto();
            this.txtProcedencia = new Texto.Texto();
            this.lblCédula = new System.Windows.Forms.Label();
            this.lblProcedencia = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFallecidos)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(4, 413);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 55);
            this.panel1.TabIndex = 7;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(513, 3);
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
            this.btnModificar.Location = new System.Drawing.Point(208, 3);
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
            this.btnSalir.Location = new System.Drawing.Point(618, 4);
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
            this.btnCancelar.Location = new System.Drawing.Point(408, 3);
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
            this.btnEliminar.Location = new System.Drawing.Point(303, 3);
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
            this.btnGuardar.Location = new System.Drawing.Point(103, 3);
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
            this.pnlTitulo.Size = new System.Drawing.Size(821, 57);
            this.pnlTitulo.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(1, 1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(815, 54);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "FALLECIDOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvFallecidos
            // 
            this.dgvFallecidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFallecidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grupo,
            this.Nombre,
            this.Appl,
            this.strApellidoFal,
            this.strApellido2,
            this.strNotaria,
            this.strFolio,
            this.intAños,
            this.intPagado,
            this.strProcedencia,
            this.bitHecho,
            this.strComentario,
            this.dtmFechaFal,
            this.dtmFechaNuc});
            this.dgvFallecidos.Location = new System.Drawing.Point(7, 196);
            this.dgvFallecidos.Name = "dgvFallecidos";
            this.dgvFallecidos.ReadOnly = true;
            this.dgvFallecidos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFallecidos.Size = new System.Drawing.Size(805, 139);
            this.dgvFallecidos.TabIndex = 8;
            this.dgvFallecidos.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            // 
            // Grupo
            // 
            this.Grupo.DataPropertyName = "intCodigoSoc";
            this.Grupo.HeaderText = "Socio";
            this.Grupo.Name = "Grupo";
            this.Grupo.ReadOnly = true;
            this.Grupo.Width = 60;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "strCedulaFal";
            this.Nombre.HeaderText = "Cédula";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 80;
            // 
            // Appl
            // 
            this.Appl.DataPropertyName = "strNombreFal";
            this.Appl.HeaderText = "Nombre";
            this.Appl.Name = "Appl";
            this.Appl.ReadOnly = true;
            this.Appl.Width = 200;
            // 
            // strApellidoFal
            // 
            this.strApellidoFal.DataPropertyName = "strApellido1Fal";
            this.strApellidoFal.HeaderText = "Apellido1";
            this.strApellidoFal.Name = "strApellidoFal";
            this.strApellidoFal.ReadOnly = true;
            // 
            // strApellido2
            // 
            this.strApellido2.DataPropertyName = "strApellido2Fal";
            this.strApellido2.HeaderText = "Apellido2";
            this.strApellido2.Name = "strApellido2";
            this.strApellido2.ReadOnly = true;
            // 
            // strNotaria
            // 
            this.strNotaria.DataPropertyName = "strNotaria";
            this.strNotaria.HeaderText = "Notaria";
            this.strNotaria.Name = "strNotaria";
            this.strNotaria.ReadOnly = true;
            this.strNotaria.Width = 120;
            // 
            // strFolio
            // 
            this.strFolio.DataPropertyName = "strFolio";
            this.strFolio.HeaderText = "Folio";
            this.strFolio.Name = "strFolio";
            this.strFolio.ReadOnly = true;
            // 
            // intAños
            // 
            this.intAños.DataPropertyName = "intAños";
            this.intAños.HeaderText = "Años";
            this.intAños.Name = "intAños";
            this.intAños.ReadOnly = true;
            // 
            // intPagado
            // 
            this.intPagado.DataPropertyName = "intPagado";
            this.intPagado.HeaderText = "Pagado";
            this.intPagado.Name = "intPagado";
            this.intPagado.ReadOnly = true;
            // 
            // strProcedencia
            // 
            this.strProcedencia.DataPropertyName = "strProcedencia";
            this.strProcedencia.HeaderText = "Procedencia";
            this.strProcedencia.Name = "strProcedencia";
            this.strProcedencia.ReadOnly = true;
            // 
            // bitHecho
            // 
            this.bitHecho.DataPropertyName = "bitHecho";
            this.bitHecho.HeaderText = "Hecho";
            this.bitHecho.Name = "bitHecho";
            this.bitHecho.ReadOnly = true;
            // 
            // strComentario
            // 
            this.strComentario.DataPropertyName = "strComentario";
            this.strComentario.HeaderText = "Comentario";
            this.strComentario.Name = "strComentario";
            this.strComentario.ReadOnly = true;
            // 
            // dtmFechaFal
            // 
            this.dtmFechaFal.DataPropertyName = "dtmFechaFal";
            this.dtmFechaFal.HeaderText = "Fallecido";
            this.dtmFechaFal.Name = "dtmFechaFal";
            this.dtmFechaFal.ReadOnly = true;
            // 
            // dtmFechaNuc
            // 
            this.dtmFechaNuc.DataPropertyName = "dtmFechaNuc";
            this.dtmFechaNuc.HeaderText = "Anuncio";
            this.dtmFechaNuc.Name = "dtmFechaNuc";
            this.dtmFechaNuc.ReadOnly = true;
            // 
            // pnlControles
            // 
            this.pnlControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControles.Controls.Add(this.label1);
            this.pnlControles.Controls.Add(this.txtCedulaAgra);
            this.pnlControles.Controls.Add(this.lblCedulaAgra);
            this.pnlControles.Controls.Add(this.txtComentario);
            this.pnlControles.Controls.Add(this.dgvAgraciados);
            this.pnlControles.Controls.Add(this.lblComentario);
            this.pnlControles.Controls.Add(this.chkHecho);
            this.pnlControles.Controls.Add(this.txtPagado);
            this.pnlControles.Controls.Add(this.lblPagado);
            this.pnlControles.Controls.Add(this.txtSocio);
            this.pnlControles.Controls.Add(this.lblSocio);
            this.pnlControles.Controls.Add(this.txtAños);
            this.pnlControles.Controls.Add(this.lblAños);
            this.pnlControles.Controls.Add(this.dtpAnuncio);
            this.pnlControles.Controls.Add(this.lblAnuncio);
            this.pnlControles.Controls.Add(this.dtpFallecido);
            this.pnlControles.Controls.Add(this.lblFallecido);
            this.pnlControles.Controls.Add(this.txtNotaria);
            this.pnlControles.Controls.Add(this.lblNotaria);
            this.pnlControles.Controls.Add(this.txtFolio);
            this.pnlControles.Controls.Add(this.lblFolio);
            this.pnlControles.Controls.Add(this.txtApellido2);
            this.pnlControles.Controls.Add(this.lblApellido2);
            this.pnlControles.Controls.Add(this.txtApellido1);
            this.pnlControles.Controls.Add(this.lblApellido1);
            this.pnlControles.Controls.Add(this.txtNombre);
            this.pnlControles.Controls.Add(this.lblNombre);
            this.pnlControles.Controls.Add(this.cboTipo);
            this.pnlControles.Controls.Add(this.lblTipo);
            this.pnlControles.Controls.Add(this.txtCedula);
            this.pnlControles.Controls.Add(this.txtProcedencia);
            this.pnlControles.Controls.Add(this.lblCédula);
            this.pnlControles.Controls.Add(this.lblProcedencia);
            this.pnlControles.Controls.Add(this.dgvFallecidos);
            this.pnlControles.Location = new System.Drawing.Point(4, 67);
            this.pnlControles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(821, 342);
            this.pnlControles.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 81;
            this.label1.Text = "Posibles responsables";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCedulaAgra
            // 
            this.txtCedulaAgra.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaAgra.Location = new System.Drawing.Point(566, 63);
            this.txtCedulaAgra.MaxLength = 25;
            this.txtCedulaAgra.Name = "txtCedulaAgra";
            this.txtCedulaAgra.Size = new System.Drawing.Size(113, 21);
            this.txtCedulaAgra.TabIndex = 14;
            this.txtCedulaAgra.Tipo = Texto.Texto.Opciones.Texto;
            this.txtCedulaAgra.Visible = false;
            // 
            // lblCedulaAgra
            // 
            this.lblCedulaAgra.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedulaAgra.Location = new System.Drawing.Point(490, 61);
            this.lblCedulaAgra.Name = "lblCedulaAgra";
            this.lblCedulaAgra.Size = new System.Drawing.Size(86, 22);
            this.lblCedulaAgra.TabIndex = 80;
            this.lblCedulaAgra.Text = "Agraciado*";
            this.lblCedulaAgra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCedulaAgra.Visible = false;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(386, 106);
            this.txtComentario.MaxLength = 255;
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(426, 86);
            this.txtComentario.TabIndex = 15;
            this.txtComentario.Tipo = Texto.Texto.Opciones.Texto;
            this.txtComentario.TextChanged += new System.EventHandler(this.txtComentario_TextChanged);
            this.txtComentario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComentario_KeyPress);
            // 
            // dgvAgraciados
            // 
            this.dgvAgraciados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgraciados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvAgraciados.Location = new System.Drawing.Point(7, 106);
            this.dgvAgraciados.Name = "dgvAgraciados";
            this.dgvAgraciados.ReadOnly = true;
            this.dgvAgraciados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAgraciados.Size = new System.Drawing.Size(373, 86);
            this.dgvAgraciados.TabIndex = 77;
            this.dgvAgraciados.DoubleClick += new System.EventHandler(this.dgvAgraciados_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "strCedulaAgra";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cédula";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "strNombreAgra";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "strApellidoAgra";
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // lblComentario
            // 
            this.lblComentario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.Location = new System.Drawing.Point(385, 85);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(88, 22);
            this.lblComentario.TabIndex = 76;
            this.lblComentario.Text = "Comentario*";
            this.lblComentario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkHecho
            // 
            this.chkHecho.AutoSize = true;
            this.chkHecho.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHecho.Location = new System.Drawing.Point(422, 62);
            this.chkHecho.Name = "chkHecho";
            this.chkHecho.Size = new System.Drawing.Size(62, 19);
            this.chkHecho.TabIndex = 13;
            this.chkHecho.Text = "Hecho";
            this.chkHecho.UseVisualStyleBackColor = true;
            this.chkHecho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chkHecho_KeyPress);
            // 
            // txtPagado
            // 
            this.txtPagado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagado.Location = new System.Drawing.Point(63, 61);
            this.txtPagado.MaxLength = 50;
            this.txtPagado.Name = "txtPagado";
            this.txtPagado.Size = new System.Drawing.Size(71, 21);
            this.txtPagado.TabIndex = 10;
            this.txtPagado.Text = "0";
            this.txtPagado.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtPagado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagado_KeyPress);
            // 
            // lblPagado
            // 
            this.lblPagado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagado.Location = new System.Drawing.Point(10, 58);
            this.lblPagado.Name = "lblPagado";
            this.lblPagado.Size = new System.Drawing.Size(67, 22);
            this.lblPagado.TabIndex = 74;
            this.lblPagado.Text = "Pagado*";
            this.lblPagado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSocio
            // 
            this.txtSocio.Enabled = false;
            this.txtSocio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSocio.Location = new System.Drawing.Point(740, 36);
            this.txtSocio.MaxLength = 50;
            this.txtSocio.Name = "txtSocio";
            this.txtSocio.Size = new System.Drawing.Size(46, 21);
            this.txtSocio.TabIndex = 9;
            this.txtSocio.Text = "0";
            this.txtSocio.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtSocio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSocio_KeyPress);
            // 
            // lblSocio
            // 
            this.lblSocio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocio.Location = new System.Drawing.Point(696, 33);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(43, 22);
            this.lblSocio.TabIndex = 72;
            this.lblSocio.Text = "Socio*";
            this.lblSocio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAños
            // 
            this.txtAños.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAños.Location = new System.Drawing.Point(362, 61);
            this.txtAños.MaxLength = 60;
            this.txtAños.Name = "txtAños";
            this.txtAños.Size = new System.Drawing.Size(54, 21);
            this.txtAños.TabIndex = 12;
            this.txtAños.Text = "0";
            this.txtAños.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtAños.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAños_KeyPress);
            // 
            // lblAños
            // 
            this.lblAños.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAños.Location = new System.Drawing.Point(322, 62);
            this.lblAños.Name = "lblAños";
            this.lblAños.Size = new System.Drawing.Size(46, 22);
            this.lblAños.TabIndex = 70;
            this.lblAños.Text = "Años*";
            this.lblAños.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpAnuncio
            // 
            this.dtpAnuncio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAnuncio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAnuncio.Location = new System.Drawing.Point(607, 35);
            this.dtpAnuncio.Name = "dtpAnuncio";
            this.dtpAnuncio.Size = new System.Drawing.Size(83, 21);
            this.dtpAnuncio.TabIndex = 8;
            this.dtpAnuncio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpAnuncio_KeyPress);
            // 
            // lblAnuncio
            // 
            this.lblAnuncio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnuncio.Location = new System.Drawing.Point(546, 32);
            this.lblAnuncio.Name = "lblAnuncio";
            this.lblAnuncio.Size = new System.Drawing.Size(60, 22);
            this.lblAnuncio.TabIndex = 59;
            this.lblAnuncio.Text = "Anuncio*";
            this.lblAnuncio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFallecido
            // 
            this.dtpFallecido.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFallecido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFallecido.Location = new System.Drawing.Point(457, 35);
            this.dtpFallecido.Name = "dtpFallecido";
            this.dtpFallecido.Size = new System.Drawing.Size(83, 21);
            this.dtpFallecido.TabIndex = 7;
            this.dtpFallecido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFallecido_KeyPress);
            // 
            // lblFallecido
            // 
            this.lblFallecido.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFallecido.Location = new System.Drawing.Point(388, 33);
            this.lblFallecido.Name = "lblFallecido";
            this.lblFallecido.Size = new System.Drawing.Size(62, 22);
            this.lblFallecido.TabIndex = 57;
            this.lblFallecido.Text = "Fallecido*";
            this.lblFallecido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNotaria
            // 
            this.txtNotaria.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotaria.Location = new System.Drawing.Point(236, 35);
            this.txtNotaria.MaxLength = 15;
            this.txtNotaria.Name = "txtNotaria";
            this.txtNotaria.Size = new System.Drawing.Size(152, 21);
            this.txtNotaria.TabIndex = 6;
            this.txtNotaria.Tipo = Texto.Texto.Opciones.Texto;
            this.txtNotaria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNotaria_KeyPress);
            // 
            // lblNotaria
            // 
            this.lblNotaria.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaria.Location = new System.Drawing.Point(182, 32);
            this.lblNotaria.Name = "lblNotaria";
            this.lblNotaria.Size = new System.Drawing.Size(59, 22);
            this.lblNotaria.TabIndex = 55;
            this.lblNotaria.Text = "Notaria*";
            this.lblNotaria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFolio
            // 
            this.txtFolio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolio.Location = new System.Drawing.Point(57, 35);
            this.txtFolio.MaxLength = 50;
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(126, 21);
            this.txtFolio.TabIndex = 5;
            this.txtFolio.Tipo = Texto.Texto.Opciones.Texto;
            this.txtFolio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolio_KeyPress);
            // 
            // lblFolio
            // 
            this.lblFolio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.Location = new System.Drawing.Point(8, 32);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(43, 22);
            this.lblFolio.TabIndex = 54;
            this.lblFolio.Text = "Folio*";
            this.lblFolio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtApellido2
            // 
            this.txtApellido2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtApellido2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido2.Location = new System.Drawing.Point(716, 6);
            this.txtApellido2.MaxLength = 15;
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(94, 21);
            this.txtApellido2.TabIndex = 4;
            this.txtApellido2.Tipo = Texto.Texto.Opciones.Texto;
            this.txtApellido2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido2_KeyPress);
            // 
            // lblApellido2
            // 
            this.lblApellido2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido2.Location = new System.Drawing.Point(646, 4);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(79, 22);
            this.lblApellido2.TabIndex = 51;
            this.lblApellido2.Text = "Apellido 2º*";
            this.lblApellido2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtApellido1
            // 
            this.txtApellido1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtApellido1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido1.Location = new System.Drawing.Point(548, 6);
            this.txtApellido1.MaxLength = 15;
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(94, 21);
            this.txtApellido1.TabIndex = 3;
            this.txtApellido1.Tipo = Texto.Texto.Opciones.Texto;
            this.txtApellido1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido1_KeyPress);
            // 
            // lblApellido1
            // 
            this.lblApellido1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido1.Location = new System.Drawing.Point(479, 4);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(79, 22);
            this.lblApellido1.TabIndex = 49;
            this.lblApellido1.Text = "Apellido 1º*";
            this.lblApellido1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNombre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(300, 6);
            this.txtNombre.MaxLength = 25;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(177, 21);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Tipo = Texto.Texto.Opciones.Texto;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(245, 4);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 22);
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
            this.cboTipo.Location = new System.Drawing.Point(191, 6);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(54, 23);
            this.cboTipo.TabIndex = 1;
            this.cboTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboTipo_KeyPress);
            // 
            // lblTipo
            // 
            this.lblTipo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(155, 4);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 22);
            this.lblTipo.TabIndex = 46;
            this.lblTipo.Text = "Tipo*";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCedula.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(57, 6);
            this.txtCedula.MaxLength = 12;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(96, 21);
            this.txtCedula.TabIndex = 0;
            this.txtCedula.Text = "0";
            this.txtCedula.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtCedula.Leave += new System.EventHandler(this.txtCedula_Leave);
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // txtProcedencia
            // 
            this.txtProcedencia.Enabled = false;
            this.txtProcedencia.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcedencia.Location = new System.Drawing.Point(223, 61);
            this.txtProcedencia.MaxLength = 4;
            this.txtProcedencia.Name = "txtProcedencia";
            this.txtProcedencia.Size = new System.Drawing.Size(93, 21);
            this.txtProcedencia.TabIndex = 11;
            this.txtProcedencia.Tipo = Texto.Texto.Opciones.Texto;
            this.txtProcedencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProcedencia_KeyPress);
            // 
            // lblCédula
            // 
            this.lblCédula.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCédula.Location = new System.Drawing.Point(6, 4);
            this.lblCédula.Name = "lblCédula";
            this.lblCédula.Size = new System.Drawing.Size(55, 22);
            this.lblCédula.TabIndex = 42;
            this.lblCédula.Text = "Cédula*";
            this.lblCédula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProcedencia
            // 
            this.lblProcedencia.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcedencia.Location = new System.Drawing.Point(134, 58);
            this.lblProcedencia.Name = "lblProcedencia";
            this.lblProcedencia.Size = new System.Drawing.Size(83, 22);
            this.lblProcedencia.TabIndex = 41;
            this.lblProcedencia.Text = "Procedencia*";
            this.lblProcedencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmFallecidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 468);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlControles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFallecidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion de fallecidos";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFallecidos)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvFallecidos;
        private System.Windows.Forms.Panel pnlControles;
        private Texto.Texto txtAños;
        private System.Windows.Forms.Label lblAños;
        private System.Windows.Forms.DateTimePicker dtpAnuncio;
        private System.Windows.Forms.Label lblAnuncio;
        private System.Windows.Forms.DateTimePicker dtpFallecido;
        private System.Windows.Forms.Label lblFallecido;
        private Texto.Texto txtNotaria;
        private System.Windows.Forms.Label lblNotaria;
        private Texto.Texto txtFolio;
        private System.Windows.Forms.Label lblFolio;
        private Texto.Texto txtApellido2;
        private System.Windows.Forms.Label lblApellido2;
        private Texto.Texto txtApellido1;
        private System.Windows.Forms.Label lblApellido1;
        private Texto.Texto txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblTipo;
        private Texto.Texto txtCedula;
        private System.Windows.Forms.Label lblCédula;
        private Texto.Texto txtProcedencia;
        private System.Windows.Forms.Label lblProcedencia;
        private Texto.Texto txtComentario;
        private System.Windows.Forms.DataGridView dgvAgraciados;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.CheckBox chkHecho;
        private Texto.Texto txtPagado;
        private System.Windows.Forms.Label lblPagado;
        private Texto.Texto txtSocio;
        private System.Windows.Forms.Label lblSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Texto.Texto txtCedulaAgra;
        private System.Windows.Forms.Label lblCedulaAgra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Appl;
        private System.Windows.Forms.DataGridViewTextBoxColumn strApellidoFal;
        private System.Windows.Forms.DataGridViewTextBoxColumn strApellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn strNotaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn strFolio;
        private System.Windows.Forms.DataGridViewTextBoxColumn intAños;
        private System.Windows.Forms.DataGridViewTextBoxColumn intPagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn strProcedencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitHecho;
        private System.Windows.Forms.DataGridViewTextBoxColumn strComentario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtmFechaFal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtmFechaNuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrar;
    }
}

