namespace Mutuales2020.Servicios
{
    partial class FrmDeudas
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cboPares = new System.Windows.Forms.ComboBox();
            this.dgvDeudas = new System.Windows.Forms.DataGridView();
            this.lblPar = new System.Windows.Forms.Label();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new Texto.Texto();
            this.lblCedula = new System.Windows.Forms.Label();
            this.optParticular = new System.Windows.Forms.RadioButton();
            this.optGlobal = new System.Windows.Forms.RadioButton();
            this.txtValor = new Texto.Texto();
            this.lblValor = new System.Windows.Forms.Label();
            this.cboServicios = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new Texto.Texto();
            this.lblServicio = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudas)).BeginInit();
            this.pnlControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Location = new System.Drawing.Point(4, 335);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 55);
            this.panel1.TabIndex = 7;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(461, 4);
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
            this.btnCancelar.Location = new System.Drawing.Point(356, 4);
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
            this.btnEliminar.Location = new System.Drawing.Point(251, 4);
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
            this.btnGuardar.Location = new System.Drawing.Point(147, 3);
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
            this.btnModificar.Location = new System.Drawing.Point(552, -24);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(89, 47);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitulo.Controls.Add(this.btnModificar);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Location = new System.Drawing.Point(4, 4);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(684, 41);
            this.pnlTitulo.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(1, 1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(682, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "DEUDAS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboPares
            // 
            this.cboPares.DisplayMember = "strDescripcion";
            this.cboPares.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPares.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPares.FormattingEnabled = true;
            this.cboPares.Location = new System.Drawing.Point(417, 42);
            this.cboPares.Name = "cboPares";
            this.cboPares.Size = new System.Drawing.Size(238, 23);
            this.cboPares.TabIndex = 7;
            this.cboPares.ValueMember = "strCodigoPar";
            this.cboPares.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboPares_KeyPress);
            // 
            // dgvDeudas
            // 
            this.dgvDeudas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeudas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvDeudas.Location = new System.Drawing.Point(11, 70);
            this.dgvDeudas.Name = "dgvDeudas";
            this.dgvDeudas.ReadOnly = true;
            this.dgvDeudas.Size = new System.Drawing.Size(657, 208);
            this.dgvDeudas.TabIndex = 8;
            this.dgvDeudas.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            // 
            // lblPar
            // 
            this.lblPar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPar.Location = new System.Drawing.Point(383, 41);
            this.lblPar.Name = "lblPar";
            this.lblPar.Size = new System.Drawing.Size(28, 22);
            this.lblPar.TabIndex = 4;
            this.lblPar.Text = "Par";
            this.lblPar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlControles
            // 
            this.pnlControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControles.Controls.Add(this.txtNombre);
            this.pnlControles.Controls.Add(this.txtCedula);
            this.pnlControles.Controls.Add(this.lblCedula);
            this.pnlControles.Controls.Add(this.optParticular);
            this.pnlControles.Controls.Add(this.optGlobal);
            this.pnlControles.Controls.Add(this.txtValor);
            this.pnlControles.Controls.Add(this.lblValor);
            this.pnlControles.Controls.Add(this.cboServicios);
            this.pnlControles.Controls.Add(this.txtCodigo);
            this.pnlControles.Controls.Add(this.dgvDeudas);
            this.pnlControles.Controls.Add(this.cboPares);
            this.pnlControles.Controls.Add(this.lblPar);
            this.pnlControles.Controls.Add(this.lblServicio);
            this.pnlControles.Controls.Add(this.lblCodigo);
            this.pnlControles.Location = new System.Drawing.Point(4, 49);
            this.pnlControles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(684, 283);
            this.pnlControles.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(147, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(230, 21);
            this.txtNombre.TabIndex = 6;
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(60, 42);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(80, 21);
            this.txtCedula.TabIndex = 5;
            this.txtCedula.Text = "0";
            this.txtCedula.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtCedula.Leave += new System.EventHandler(this.txtSocio_Leave);
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSocio_KeyPress);
            // 
            // lblCedula
            // 
            this.lblCedula.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(7, 42);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(52, 22);
            this.lblCedula.TabIndex = 15;
            this.lblCedula.Text = "Cédula*";
            this.lblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // optParticular
            // 
            this.optParticular.AutoSize = true;
            this.optParticular.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optParticular.Location = new System.Drawing.Point(512, 11);
            this.optParticular.Name = "optParticular";
            this.optParticular.Size = new System.Drawing.Size(77, 19);
            this.optParticular.TabIndex = 3;
            this.optParticular.TabStop = true;
            this.optParticular.Text = "Particular";
            this.optParticular.UseVisualStyleBackColor = true;
            this.optParticular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.optParticular_KeyPress);
            // 
            // optGlobal
            // 
            this.optGlobal.AutoSize = true;
            this.optGlobal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optGlobal.Location = new System.Drawing.Point(595, 11);
            this.optGlobal.Name = "optGlobal";
            this.optGlobal.Size = new System.Drawing.Size(61, 19);
            this.optGlobal.TabIndex = 4;
            this.optGlobal.TabStop = true;
            this.optGlobal.Text = "Global";
            this.optGlobal.UseVisualStyleBackColor = true;
            this.optGlobal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.optGlobal_KeyPress);
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(427, 9);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(79, 21);
            this.txtValor.TabIndex = 2;
            this.txtValor.Text = "0";
            this.txtValor.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // lblValor
            // 
            this.lblValor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(386, 9);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 22);
            this.lblValor.TabIndex = 11;
            this.lblValor.Text = "Valor*";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboServicios
            // 
            this.cboServicios.DisplayMember = "strNombreSse";
            this.cboServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServicios.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboServicios.FormattingEnabled = true;
            this.cboServicios.Location = new System.Drawing.Point(189, 9);
            this.cboServicios.Name = "cboServicios";
            this.cboServicios.Size = new System.Drawing.Size(188, 23);
            this.cboServicios.TabIndex = 1;
            this.cboServicios.ValueMember = "strCodSse";
            this.cboServicios.Leave += new System.EventHandler(this.cboServicios_Leave);
            this.cboServicios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboServicios_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(55, 9);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(79, 21);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = "0";
            this.txtCodigo.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblServicio
            // 
            this.lblServicio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.Location = new System.Drawing.Point(135, 9);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(66, 22);
            this.lblServicio.TabIndex = 2;
            this.lblServicio.Text = "Servicio*";
            this.lblServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(7, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 22);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código*";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "intCodDeu";
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 95;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "strCedula";
            this.Column2.HeaderText = "Cédula";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "strCodigoPar";
            this.Column3.HeaderText = "Par";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "strCodSse";
            this.Column4.HeaderText = "Servicio";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "bitGlobalDeu";
            this.Column5.HeaderText = "Global";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "decDebeDeu";
            this.Column6.HeaderText = "Debe";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // FrmDeudas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 396);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlControles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDeudas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion de deudas";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeudas)).EndInit();
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
        private System.Windows.Forms.ComboBox cboPares;
        private System.Windows.Forms.DataGridView dgvDeudas;
        private System.Windows.Forms.Label lblPar;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.Label lblCodigo;
        private Texto.Texto txtCodigo;
        private Texto.Texto txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ComboBox cboServicios;
        private Texto.Texto txtCedula;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.RadioButton optParticular;
        private System.Windows.Forms.RadioButton optGlobal;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

