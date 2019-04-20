namespace Mutuales2020.Maestros
{
    partial class frmTiposdeCredito
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
            this.dgvTiposdeCredito = new System.Windows.Forms.DataGridView();
            this.strCodigoTcr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strDescripcionTcr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decTasaEfectivaAnualBasicaTcr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decTasaNominalAnualBasicaTcr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decTasaNominalAnualBasicaSemanalTcr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decTasaNominalAnualBasicaDecadalTcr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decTasaNominalAnualBasicaQuincenalTcr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decTasaNominalAnualBasicaMensualTcr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decTasaEfectivaAnualUsuraTcr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decTasaNominalAnualUsuraTcr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decTasaNominalAnualUsuraSemanalTcr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decTasaNominalAnualUsuraDecadalTcr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decTasaNominalAnualUsuraQuincenalTcr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decTasaNominalAnualUsuraMensualTcr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.txtTnum = new Texto.Texto();
            this.txtTnuq = new Texto.Texto();
            this.txtTnud = new Texto.Texto();
            this.txtTnus = new Texto.Texto();
            this.lblTenu = new System.Windows.Forms.Label();
            this.lblTnum = new System.Windows.Forms.Label();
            this.lblTnuq = new System.Windows.Forms.Label();
            this.lblTnud = new System.Windows.Forms.Label();
            this.lblTnus = new System.Windows.Forms.Label();
            this.txtTenu = new Texto.Texto();
            this.txtTeau = new Texto.Texto();
            this.lblTeau = new System.Windows.Forms.Label();
            this.txtTnbm = new Texto.Texto();
            this.txtTnbq = new Texto.Texto();
            this.txtTnbd = new Texto.Texto();
            this.txtTnbs = new Texto.Texto();
            this.lblTenb = new System.Windows.Forms.Label();
            this.lblTnbm = new System.Windows.Forms.Label();
            this.lblTnbq = new System.Windows.Forms.Label();
            this.lblTnbd = new System.Windows.Forms.Label();
            this.lblTnbs = new System.Windows.Forms.Label();
            this.txtTenb = new Texto.Texto();
            this.txtTeab = new Texto.Texto();
            this.lblTeab = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposdeCredito)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(4, 400);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 55);
            this.panel1.TabIndex = 7;
            // 
            // btnModificar
            // 
            this.btnModificar.ImageIndex = 0;
            this.btnModificar.Location = new System.Drawing.Point(249, 3);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(89, 47);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(554, 3);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 47);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(449, 3);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 47);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(344, 3);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 47);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageIndex = 0;
            this.btnGuardar.Location = new System.Drawing.Point(144, 3);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 47);
            this.btnGuardar.TabIndex = 4;
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
            this.pnlTitulo.Size = new System.Drawing.Size(813, 57);
            this.pnlTitulo.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(1, 1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(807, 54);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "TIPOS DE CRÉDITO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTiposdeCredito
            // 
            this.dgvTiposdeCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiposdeCredito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.strCodigoTcr,
            this.strDescripcionTcr,
            this.decTasaEfectivaAnualBasicaTcr,
            this.decTasaNominalAnualBasicaTcr,
            this.decTasaNominalAnualBasicaSemanalTcr,
            this.decTasaNominalAnualBasicaDecadalTcr,
            this.decTasaNominalAnualBasicaQuincenalTcr,
            this.decTasaNominalAnualBasicaMensualTcr,
            this.decTasaEfectivaAnualUsuraTcr,
            this.decTasaNominalAnualUsuraTcr,
            this.decTasaNominalAnualUsuraSemanalTcr,
            this.decTasaNominalAnualUsuraDecadalTcr,
            this.decTasaNominalAnualUsuraQuincenalTcr,
            this.decTasaNominalAnualUsuraMensualTcr});
            this.dgvTiposdeCredito.Location = new System.Drawing.Point(11, 202);
            this.dgvTiposdeCredito.Name = "dgvTiposdeCredito";
            this.dgvTiposdeCredito.ReadOnly = true;
            this.dgvTiposdeCredito.Size = new System.Drawing.Size(803, 118);
            this.dgvTiposdeCredito.TabIndex = 8;
            this.dgvTiposdeCredito.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            // 
            // strCodigoTcr
            // 
            this.strCodigoTcr.DataPropertyName = "strCodigoTcr";
            this.strCodigoTcr.HeaderText = "Código";
            this.strCodigoTcr.Name = "strCodigoTcr";
            this.strCodigoTcr.ReadOnly = true;
            this.strCodigoTcr.Width = 60;
            // 
            // strDescripcionTcr
            // 
            this.strDescripcionTcr.DataPropertyName = "strDescripcionTcr";
            this.strDescripcionTcr.HeaderText = "Nombre";
            this.strDescripcionTcr.Name = "strDescripcionTcr";
            this.strDescripcionTcr.ReadOnly = true;
            this.strDescripcionTcr.Width = 90;
            // 
            // decTasaEfectivaAnualBasicaTcr
            // 
            this.decTasaEfectivaAnualBasicaTcr.DataPropertyName = "decTasaEfectivaAnualBasicaTcr";
            this.decTasaEfectivaAnualBasicaTcr.HeaderText = "Teabt";
            this.decTasaEfectivaAnualBasicaTcr.Name = "decTasaEfectivaAnualBasicaTcr";
            this.decTasaEfectivaAnualBasicaTcr.ReadOnly = true;
            this.decTasaEfectivaAnualBasicaTcr.Width = 50;
            // 
            // decTasaNominalAnualBasicaTcr
            // 
            this.decTasaNominalAnualBasicaTcr.DataPropertyName = "decTasaNominalAnualBasicaTcr";
            this.decTasaNominalAnualBasicaTcr.HeaderText = "Tnabt";
            this.decTasaNominalAnualBasicaTcr.Name = "decTasaNominalAnualBasicaTcr";
            this.decTasaNominalAnualBasicaTcr.ReadOnly = true;
            this.decTasaNominalAnualBasicaTcr.Width = 50;
            // 
            // decTasaNominalAnualBasicaSemanalTcr
            // 
            this.decTasaNominalAnualBasicaSemanalTcr.DataPropertyName = "decTasaNominalAnualBasicaSemanalTcr";
            this.decTasaNominalAnualBasicaSemanalTcr.HeaderText = "Tnabst";
            this.decTasaNominalAnualBasicaSemanalTcr.Name = "decTasaNominalAnualBasicaSemanalTcr";
            this.decTasaNominalAnualBasicaSemanalTcr.ReadOnly = true;
            this.decTasaNominalAnualBasicaSemanalTcr.Width = 50;
            // 
            // decTasaNominalAnualBasicaDecadalTcr
            // 
            this.decTasaNominalAnualBasicaDecadalTcr.DataPropertyName = "decTasaNominalAnualBasicaDecadalTcr";
            this.decTasaNominalAnualBasicaDecadalTcr.HeaderText = "Tnabdt";
            this.decTasaNominalAnualBasicaDecadalTcr.Name = "decTasaNominalAnualBasicaDecadalTcr";
            this.decTasaNominalAnualBasicaDecadalTcr.ReadOnly = true;
            this.decTasaNominalAnualBasicaDecadalTcr.Width = 50;
            // 
            // decTasaNominalAnualBasicaQuincenalTcr
            // 
            this.decTasaNominalAnualBasicaQuincenalTcr.DataPropertyName = "decTasaNominalAnualBasicaQuincenalTcr";
            this.decTasaNominalAnualBasicaQuincenalTcr.HeaderText = "Tnabqt";
            this.decTasaNominalAnualBasicaQuincenalTcr.Name = "decTasaNominalAnualBasicaQuincenalTcr";
            this.decTasaNominalAnualBasicaQuincenalTcr.ReadOnly = true;
            this.decTasaNominalAnualBasicaQuincenalTcr.Width = 50;
            // 
            // decTasaNominalAnualBasicaMensualTcr
            // 
            this.decTasaNominalAnualBasicaMensualTcr.DataPropertyName = "decTasaNominalAnualBasicaMensualTcr";
            this.decTasaNominalAnualBasicaMensualTcr.HeaderText = "Tnabmt";
            this.decTasaNominalAnualBasicaMensualTcr.Name = "decTasaNominalAnualBasicaMensualTcr";
            this.decTasaNominalAnualBasicaMensualTcr.ReadOnly = true;
            this.decTasaNominalAnualBasicaMensualTcr.Width = 50;
            // 
            // decTasaEfectivaAnualUsuraTcr
            // 
            this.decTasaEfectivaAnualUsuraTcr.DataPropertyName = "decTasaEfectivaAnualUsuraTcr";
            this.decTasaEfectivaAnualUsuraTcr.HeaderText = "Teaut";
            this.decTasaEfectivaAnualUsuraTcr.Name = "decTasaEfectivaAnualUsuraTcr";
            this.decTasaEfectivaAnualUsuraTcr.ReadOnly = true;
            this.decTasaEfectivaAnualUsuraTcr.Width = 50;
            // 
            // decTasaNominalAnualUsuraTcr
            // 
            this.decTasaNominalAnualUsuraTcr.DataPropertyName = "decTasaNominalAnualUsuraTcr";
            this.decTasaNominalAnualUsuraTcr.HeaderText = "Tnaut";
            this.decTasaNominalAnualUsuraTcr.Name = "decTasaNominalAnualUsuraTcr";
            this.decTasaNominalAnualUsuraTcr.ReadOnly = true;
            this.decTasaNominalAnualUsuraTcr.Width = 50;
            // 
            // decTasaNominalAnualUsuraSemanalTcr
            // 
            this.decTasaNominalAnualUsuraSemanalTcr.DataPropertyName = "decTasaNominalAnualUsuraSemanalTcr";
            this.decTasaNominalAnualUsuraSemanalTcr.HeaderText = "Tnaust";
            this.decTasaNominalAnualUsuraSemanalTcr.Name = "decTasaNominalAnualUsuraSemanalTcr";
            this.decTasaNominalAnualUsuraSemanalTcr.ReadOnly = true;
            this.decTasaNominalAnualUsuraSemanalTcr.Width = 50;
            // 
            // decTasaNominalAnualUsuraDecadalTcr
            // 
            this.decTasaNominalAnualUsuraDecadalTcr.DataPropertyName = "decTasaNominalAnualUsuraDecadalTcr";
            this.decTasaNominalAnualUsuraDecadalTcr.HeaderText = "Tnaudt";
            this.decTasaNominalAnualUsuraDecadalTcr.Name = "decTasaNominalAnualUsuraDecadalTcr";
            this.decTasaNominalAnualUsuraDecadalTcr.ReadOnly = true;
            this.decTasaNominalAnualUsuraDecadalTcr.Width = 50;
            // 
            // decTasaNominalAnualUsuraQuincenalTcr
            // 
            this.decTasaNominalAnualUsuraQuincenalTcr.DataPropertyName = "decTasaNominalAnualUsuraQuincenalTcr";
            this.decTasaNominalAnualUsuraQuincenalTcr.HeaderText = "Tnauqt";
            this.decTasaNominalAnualUsuraQuincenalTcr.Name = "decTasaNominalAnualUsuraQuincenalTcr";
            this.decTasaNominalAnualUsuraQuincenalTcr.ReadOnly = true;
            this.decTasaNominalAnualUsuraQuincenalTcr.Width = 50;
            // 
            // decTasaNominalAnualUsuraMensualTcr
            // 
            this.decTasaNominalAnualUsuraMensualTcr.DataPropertyName = "decTasaNominalAnualUsuraMensualTcr";
            this.decTasaNominalAnualUsuraMensualTcr.HeaderText = "Tnaumt";
            this.decTasaNominalAnualUsuraMensualTcr.Name = "decTasaNominalAnualUsuraMensualTcr";
            this.decTasaNominalAnualUsuraMensualTcr.ReadOnly = true;
            this.decTasaNominalAnualUsuraMensualTcr.Width = 50;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(448, 9);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(351, 21);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // pnlControles
            // 
            this.pnlControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControles.Controls.Add(this.txtTnum);
            this.pnlControles.Controls.Add(this.txtTnuq);
            this.pnlControles.Controls.Add(this.txtTnud);
            this.pnlControles.Controls.Add(this.txtTnus);
            this.pnlControles.Controls.Add(this.lblTenu);
            this.pnlControles.Controls.Add(this.lblTnum);
            this.pnlControles.Controls.Add(this.lblTnuq);
            this.pnlControles.Controls.Add(this.lblTnud);
            this.pnlControles.Controls.Add(this.lblTnus);
            this.pnlControles.Controls.Add(this.txtTenu);
            this.pnlControles.Controls.Add(this.txtTeau);
            this.pnlControles.Controls.Add(this.lblTeau);
            this.pnlControles.Controls.Add(this.txtTnbm);
            this.pnlControles.Controls.Add(this.txtTnbq);
            this.pnlControles.Controls.Add(this.txtTnbd);
            this.pnlControles.Controls.Add(this.txtTnbs);
            this.pnlControles.Controls.Add(this.lblTenb);
            this.pnlControles.Controls.Add(this.lblTnbm);
            this.pnlControles.Controls.Add(this.lblTnbq);
            this.pnlControles.Controls.Add(this.lblTnbd);
            this.pnlControles.Controls.Add(this.lblTnbs);
            this.pnlControles.Controls.Add(this.txtTenb);
            this.pnlControles.Controls.Add(this.txtTeab);
            this.pnlControles.Controls.Add(this.lblTeab);
            this.pnlControles.Controls.Add(this.dgvTiposdeCredito);
            this.pnlControles.Controls.Add(this.txtDescripcion);
            this.pnlControles.Controls.Add(this.lblDescripcion);
            this.pnlControles.Controls.Add(this.txtCodigo);
            this.pnlControles.Controls.Add(this.lblCodigo);
            this.pnlControles.Location = new System.Drawing.Point(4, 67);
            this.pnlControles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(813, 329);
            this.pnlControles.TabIndex = 6;
            // 
            // txtTnum
            // 
            this.txtTnum.Enabled = false;
            this.txtTnum.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTnum.Location = new System.Drawing.Point(743, 163);
            this.txtTnum.Name = "txtTnum";
            this.txtTnum.Size = new System.Drawing.Size(56, 21);
            this.txtTnum.TabIndex = 33;
            this.txtTnum.Text = "0";
            this.txtTnum.Tipo = Texto.Texto.Opciones.Decimal;
            // 
            // txtTnuq
            // 
            this.txtTnuq.Enabled = false;
            this.txtTnuq.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTnuq.Location = new System.Drawing.Point(743, 137);
            this.txtTnuq.Name = "txtTnuq";
            this.txtTnuq.Size = new System.Drawing.Size(56, 21);
            this.txtTnuq.TabIndex = 32;
            this.txtTnuq.Text = "0";
            this.txtTnuq.Tipo = Texto.Texto.Opciones.Decimal;
            // 
            // txtTnud
            // 
            this.txtTnud.Enabled = false;
            this.txtTnud.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTnud.Location = new System.Drawing.Point(743, 111);
            this.txtTnud.Name = "txtTnud";
            this.txtTnud.Size = new System.Drawing.Size(56, 21);
            this.txtTnud.TabIndex = 31;
            this.txtTnud.Text = "0";
            this.txtTnud.Tipo = Texto.Texto.Opciones.Decimal;
            // 
            // txtTnus
            // 
            this.txtTnus.Enabled = false;
            this.txtTnus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTnus.Location = new System.Drawing.Point(743, 85);
            this.txtTnus.Name = "txtTnus";
            this.txtTnus.Size = new System.Drawing.Size(56, 21);
            this.txtTnus.TabIndex = 30;
            this.txtTnus.Text = "0";
            this.txtTnus.Tipo = Texto.Texto.Opciones.Decimal;
            // 
            // lblTenu
            // 
            this.lblTenu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenu.Location = new System.Drawing.Point(547, 59);
            this.lblTenu.Name = "lblTenu";
            this.lblTenu.Size = new System.Drawing.Size(178, 22);
            this.lblTenu.TabIndex = 29;
            this.lblTenu.Text = "Tasa efectiva nominal usura";
            this.lblTenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTnum
            // 
            this.lblTnum.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTnum.Location = new System.Drawing.Point(547, 163);
            this.lblTnum.Name = "lblTnum";
            this.lblTnum.Size = new System.Drawing.Size(181, 22);
            this.lblTnum.TabIndex = 28;
            this.lblTnum.Text = "Tasa nominal usura mensual";
            this.lblTnum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTnuq
            // 
            this.lblTnuq.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTnuq.Location = new System.Drawing.Point(547, 137);
            this.lblTnuq.Name = "lblTnuq";
            this.lblTnuq.Size = new System.Drawing.Size(181, 22);
            this.lblTnuq.TabIndex = 27;
            this.lblTnuq.Text = "Tasa nominal usura quincenal";
            this.lblTnuq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTnud
            // 
            this.lblTnud.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTnud.Location = new System.Drawing.Point(547, 111);
            this.lblTnud.Name = "lblTnud";
            this.lblTnud.Size = new System.Drawing.Size(181, 22);
            this.lblTnud.TabIndex = 26;
            this.lblTnud.Text = "Tasa nominal usura decadal";
            this.lblTnud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTnus
            // 
            this.lblTnus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTnus.Location = new System.Drawing.Point(547, 85);
            this.lblTnus.Name = "lblTnus";
            this.lblTnus.Size = new System.Drawing.Size(181, 22);
            this.lblTnus.TabIndex = 25;
            this.lblTnus.Text = "Tasa nominal usura semanal";
            this.lblTnus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenu
            // 
            this.txtTenu.Enabled = false;
            this.txtTenu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenu.Location = new System.Drawing.Point(743, 59);
            this.txtTenu.Name = "txtTenu";
            this.txtTenu.Size = new System.Drawing.Size(56, 21);
            this.txtTenu.TabIndex = 24;
            this.txtTenu.Text = "0";
            this.txtTenu.Tipo = Texto.Texto.Opciones.Decimal;
            // 
            // txtTeau
            // 
            this.txtTeau.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeau.Location = new System.Drawing.Point(743, 31);
            this.txtTeau.Name = "txtTeau";
            this.txtTeau.Size = new System.Drawing.Size(56, 21);
            this.txtTeau.TabIndex = 3;
            this.txtTeau.Text = "0";
            this.txtTeau.Tipo = Texto.Texto.Opciones.Decimal;
            this.txtTeau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTeau_KeyPress);
            // 
            // lblTeau
            // 
            this.lblTeau.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeau.Location = new System.Drawing.Point(544, 31);
            this.lblTeau.Name = "lblTeau";
            this.lblTeau.Size = new System.Drawing.Size(172, 22);
            this.lblTeau.TabIndex = 22;
            this.lblTeau.Text = "Tasa efectiva anual usura*";
            this.lblTeau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTnbm
            // 
            this.txtTnbm.Enabled = false;
            this.txtTnbm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTnbm.Location = new System.Drawing.Point(204, 165);
            this.txtTnbm.Name = "txtTnbm";
            this.txtTnbm.Size = new System.Drawing.Size(56, 21);
            this.txtTnbm.TabIndex = 21;
            this.txtTnbm.Text = "0";
            this.txtTnbm.Tipo = Texto.Texto.Opciones.Decimal;
            // 
            // txtTnbq
            // 
            this.txtTnbq.Enabled = false;
            this.txtTnbq.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTnbq.Location = new System.Drawing.Point(204, 139);
            this.txtTnbq.Name = "txtTnbq";
            this.txtTnbq.Size = new System.Drawing.Size(56, 21);
            this.txtTnbq.TabIndex = 20;
            this.txtTnbq.Text = "0";
            this.txtTnbq.Tipo = Texto.Texto.Opciones.Decimal;
            // 
            // txtTnbd
            // 
            this.txtTnbd.Enabled = false;
            this.txtTnbd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTnbd.Location = new System.Drawing.Point(204, 113);
            this.txtTnbd.Name = "txtTnbd";
            this.txtTnbd.Size = new System.Drawing.Size(56, 21);
            this.txtTnbd.TabIndex = 19;
            this.txtTnbd.Text = "0";
            this.txtTnbd.Tipo = Texto.Texto.Opciones.Decimal;
            // 
            // txtTnbs
            // 
            this.txtTnbs.Enabled = false;
            this.txtTnbs.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTnbs.Location = new System.Drawing.Point(204, 87);
            this.txtTnbs.Name = "txtTnbs";
            this.txtTnbs.Size = new System.Drawing.Size(56, 21);
            this.txtTnbs.TabIndex = 18;
            this.txtTnbs.Text = "0";
            this.txtTnbs.Tipo = Texto.Texto.Opciones.Decimal;
            // 
            // lblTenb
            // 
            this.lblTenb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenb.Location = new System.Drawing.Point(12, 61);
            this.lblTenb.Name = "lblTenb";
            this.lblTenb.Size = new System.Drawing.Size(169, 22);
            this.lblTenb.TabIndex = 17;
            this.lblTenb.Text = "Tasa efectiva nominal básica";
            this.lblTenb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTnbm
            // 
            this.lblTnbm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTnbm.Location = new System.Drawing.Point(12, 165);
            this.lblTnbm.Name = "lblTnbm";
            this.lblTnbm.Size = new System.Drawing.Size(191, 22);
            this.lblTnbm.TabIndex = 16;
            this.lblTnbm.Text = "Tasa nominal básica mensual";
            this.lblTnbm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTnbq
            // 
            this.lblTnbq.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTnbq.Location = new System.Drawing.Point(12, 139);
            this.lblTnbq.Name = "lblTnbq";
            this.lblTnbq.Size = new System.Drawing.Size(191, 22);
            this.lblTnbq.TabIndex = 15;
            this.lblTnbq.Text = "Tasa nominal básica quincenal";
            this.lblTnbq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTnbd
            // 
            this.lblTnbd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTnbd.Location = new System.Drawing.Point(12, 113);
            this.lblTnbd.Name = "lblTnbd";
            this.lblTnbd.Size = new System.Drawing.Size(179, 22);
            this.lblTnbd.TabIndex = 14;
            this.lblTnbd.Text = "Tasa nominal básica decadal";
            this.lblTnbd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTnbs
            // 
            this.lblTnbs.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTnbs.Location = new System.Drawing.Point(12, 87);
            this.lblTnbs.Name = "lblTnbs";
            this.lblTnbs.Size = new System.Drawing.Size(179, 22);
            this.lblTnbs.TabIndex = 13;
            this.lblTnbs.Text = "Tasa nominal básica semanal";
            this.lblTnbs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenb
            // 
            this.txtTenb.Enabled = false;
            this.txtTenb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenb.Location = new System.Drawing.Point(204, 61);
            this.txtTenb.Name = "txtTenb";
            this.txtTenb.Size = new System.Drawing.Size(56, 21);
            this.txtTenb.TabIndex = 12;
            this.txtTenb.Text = "0";
            this.txtTenb.Tipo = Texto.Texto.Opciones.Decimal;
            // 
            // txtTeab
            // 
            this.txtTeab.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeab.Location = new System.Drawing.Point(204, 33);
            this.txtTeab.Name = "txtTeab";
            this.txtTeab.Size = new System.Drawing.Size(56, 21);
            this.txtTeab.TabIndex = 2;
            this.txtTeab.Text = "0";
            this.txtTeab.Tipo = Texto.Texto.Opciones.Decimal;
            this.txtTeab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTeab_KeyPress);
            // 
            // lblTeab
            // 
            this.lblTeab.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeab.Location = new System.Drawing.Point(12, 33);
            this.lblTeab.Name = "lblTeab";
            this.lblTeab.Size = new System.Drawing.Size(169, 22);
            this.lblTeab.TabIndex = 9;
            this.lblTeab.Text = "Tasa efectiva anual básica*";
            this.lblTeab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(353, 9);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 22);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción*";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(73, 9);
            this.txtCodigo.MaxLength = 30;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(285, 21);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(8, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 22);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código*";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmTiposdeCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlControles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTiposdeCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de los tipos de crédito";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposdeCredito)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvTiposdeCredito;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTeab;
        private Texto.Texto txtTeab;
        private System.Windows.Forms.Label lblTnbd;
        private System.Windows.Forms.Label lblTnbs;
        private Texto.Texto txtTenb;
        private Texto.Texto txtTnbm;
        private Texto.Texto txtTnbq;
        private Texto.Texto txtTnbd;
        private Texto.Texto txtTnbs;
        private System.Windows.Forms.Label lblTenb;
        private System.Windows.Forms.Label lblTnbm;
        private System.Windows.Forms.Label lblTnbq;
        private Texto.Texto txtTnum;
        private Texto.Texto txtTnuq;
        private Texto.Texto txtTnud;
        private Texto.Texto txtTnus;
        private System.Windows.Forms.Label lblTenu;
        private System.Windows.Forms.Label lblTnum;
        private System.Windows.Forms.Label lblTnuq;
        private System.Windows.Forms.Label lblTnud;
        private System.Windows.Forms.Label lblTnus;
        private Texto.Texto txtTenu;
        private Texto.Texto txtTeau;
        private System.Windows.Forms.Label lblTeau;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCodigoTcr;
        private System.Windows.Forms.DataGridViewTextBoxColumn strDescripcionTcr;
        private System.Windows.Forms.DataGridViewTextBoxColumn decTasaEfectivaAnualBasicaTcr;
        private System.Windows.Forms.DataGridViewTextBoxColumn decTasaNominalAnualBasicaTcr;
        private System.Windows.Forms.DataGridViewTextBoxColumn decTasaNominalAnualBasicaSemanalTcr;
        private System.Windows.Forms.DataGridViewTextBoxColumn decTasaNominalAnualBasicaDecadalTcr;
        private System.Windows.Forms.DataGridViewTextBoxColumn decTasaNominalAnualBasicaQuincenalTcr;
        private System.Windows.Forms.DataGridViewTextBoxColumn decTasaNominalAnualBasicaMensualTcr;
        private System.Windows.Forms.DataGridViewTextBoxColumn decTasaEfectivaAnualUsuraTcr;
        private System.Windows.Forms.DataGridViewTextBoxColumn decTasaNominalAnualUsuraTcr;
        private System.Windows.Forms.DataGridViewTextBoxColumn decTasaNominalAnualUsuraSemanalTcr;
        private System.Windows.Forms.DataGridViewTextBoxColumn decTasaNominalAnualUsuraDecadalTcr;
        private System.Windows.Forms.DataGridViewTextBoxColumn decTasaNominalAnualUsuraQuincenalTcr;
        private System.Windows.Forms.DataGridViewTextBoxColumn decTasaNominalAnualUsuraMensualTcr;
    }
}

