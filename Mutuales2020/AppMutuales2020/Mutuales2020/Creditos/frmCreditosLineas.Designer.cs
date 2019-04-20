namespace Mutuales2020.Creditos
{
    partial class frmCreditosLineas
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
            this.lblCredito = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lCodigo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboParMora = new System.Windows.Forms.ComboBox();
            this.lblMora = new System.Windows.Forms.Label();
            this.cboParIntereses = new System.Windows.Forms.ComboBox();
            this.lblParInteres = new System.Windows.Forms.Label();
            this.cboParCapital = new System.Windows.Forms.ComboBox();
            this.lblParCapital = new System.Windows.Forms.Label();
            this.cboTiposdeCredito = new System.Windows.Forms.ComboBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCredito
            // 
            this.lblCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredito.Location = new System.Drawing.Point(459, 16);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(56, 16);
            this.lblCredito.TabIndex = 6;
            this.lblCredito.Text = "Crédito*";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(188, 16);
            this.txtDescripcion.MaxLength = 25;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(265, 20);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(128, 16);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(73, 16);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 40);
            this.panel1.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(-1, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(699, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "LÍNEAS DE CRÉDITO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(59, 16);
            this.txtCodigo.MaxLength = 4;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(61, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lCodigo
            // 
            this.lCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCodigo.Location = new System.Drawing.Point(7, 16);
            this.lCodigo.Name = "lCodigo";
            this.lCodigo.Size = new System.Drawing.Size(56, 16);
            this.lCodigo.TabIndex = 2;
            this.lCodigo.Text = "Código";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cboParMora);
            this.panel2.Controls.Add(this.lblMora);
            this.panel2.Controls.Add(this.cboParIntereses);
            this.panel2.Controls.Add(this.lblParInteres);
            this.panel2.Controls.Add(this.cboParCapital);
            this.panel2.Controls.Add(this.lblParCapital);
            this.panel2.Controls.Add(this.cboTiposdeCredito);
            this.panel2.Controls.Add(this.dgvDatos);
            this.panel2.Controls.Add(this.lblCredito);
            this.panel2.Controls.Add(this.txtDescripcion);
            this.panel2.Controls.Add(this.lblDescripcion);
            this.panel2.Controls.Add(this.txtCodigo);
            this.panel2.Controls.Add(this.lCodigo);
            this.panel2.Location = new System.Drawing.Point(4, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(706, 228);
            this.panel2.TabIndex = 7;
            // 
            // cboParMora
            // 
            this.cboParMora.DisplayMember = "strDescripcion";
            this.cboParMora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParMora.Location = new System.Drawing.Point(543, 42);
            this.cboParMora.Name = "cboParMora";
            this.cboParMora.Size = new System.Drawing.Size(157, 21);
            this.cboParMora.TabIndex = 5;
            this.cboParMora.ValueMember = "strCodigoPar";
            // 
            // lblMora
            // 
            this.lblMora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMora.Location = new System.Drawing.Point(478, 45);
            this.lblMora.Name = "lblMora";
            this.lblMora.Size = new System.Drawing.Size(63, 16);
            this.lblMora.TabIndex = 13;
            this.lblMora.Text = "Par Mora";
            // 
            // cboParIntereses
            // 
            this.cboParIntereses.DisplayMember = "strDescripcion";
            this.cboParIntereses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParIntereses.Location = new System.Drawing.Point(315, 40);
            this.cboParIntereses.Name = "cboParIntereses";
            this.cboParIntereses.Size = new System.Drawing.Size(157, 21);
            this.cboParIntereses.TabIndex = 4;
            this.cboParIntereses.ValueMember = "strCodigoPar";
            // 
            // lblParInteres
            // 
            this.lblParInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParInteres.Location = new System.Drawing.Point(243, 43);
            this.lblParInteres.Name = "lblParInteres";
            this.lblParInteres.Size = new System.Drawing.Size(75, 16);
            this.lblParInteres.TabIndex = 11;
            this.lblParInteres.Text = "Par Interes";
            // 
            // cboParCapital
            // 
            this.cboParCapital.DisplayMember = "strDescripcion";
            this.cboParCapital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParCapital.Location = new System.Drawing.Point(81, 42);
            this.cboParCapital.Name = "cboParCapital";
            this.cboParCapital.Size = new System.Drawing.Size(157, 21);
            this.cboParCapital.TabIndex = 3;
            this.cboParCapital.ValueMember = "strCodigoPar";
            // 
            // lblParCapital
            // 
            this.lblParCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParCapital.Location = new System.Drawing.Point(7, 45);
            this.lblParCapital.Name = "lblParCapital";
            this.lblParCapital.Size = new System.Drawing.Size(75, 16);
            this.lblParCapital.TabIndex = 9;
            this.lblParCapital.Text = "Par Capital";
            // 
            // cboTiposdeCredito
            // 
            this.cboTiposdeCredito.DisplayMember = "strDescripcionTcr";
            this.cboTiposdeCredito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTiposdeCredito.Location = new System.Drawing.Point(512, 15);
            this.cboTiposdeCredito.Name = "cboTiposdeCredito";
            this.cboTiposdeCredito.Size = new System.Drawing.Size(157, 21);
            this.cboTiposdeCredito.TabIndex = 2;
            this.cboTiposdeCredito.ValueMember = "strCodigoTcr";
            this.cboTiposdeCredito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboTiposdeCredito_KeyPress);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.TipoCredito});
            this.dgvDatos.Location = new System.Drawing.Point(10, 69);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(688, 154);
            this.dgvDatos.TabIndex = 7;
            this.dgvDatos.DoubleClick += new System.EventHandler(this.dgvDatos_DoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "strCodigoLin";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "strNomLineadeCredito";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 300;
            // 
            // TipoCredito
            // 
            this.TipoCredito.DataPropertyName = "strCodigoTcr";
            this.TipoCredito.HeaderText = "Tipo de crédito";
            this.TipoCredito.Name = "TipoCredito";
            this.TipoCredito.ReadOnly = true;
            this.TipoCredito.Width = 200;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnModificar);
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Location = new System.Drawing.Point(4, 284);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(706, 55);
            this.panel3.TabIndex = 8;
            // 
            // btnModificar
            // 
            this.btnModificar.ImageIndex = 0;
            this.btnModificar.Location = new System.Drawing.Point(207, 3);
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
            this.btnSalir.Location = new System.Drawing.Point(512, 3);
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
            this.btnCancelar.Location = new System.Drawing.Point(407, 3);
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
            this.btnEliminar.Location = new System.Drawing.Point(302, 3);
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
            this.btnGuardar.Location = new System.Drawing.Point(102, 3);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 47);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmCreditosLineas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 345);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreditosLineas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar líneas de crédito";
            this.Load += new System.EventHandler(this.frmLineasdeCredito_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLineasdeCredito_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCredito;
        public System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lCodigo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.ComboBox cboTiposdeCredito;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCredito;
        private System.Windows.Forms.Label lblParCapital;
        private System.Windows.Forms.ComboBox cboParIntereses;
        private System.Windows.Forms.Label lblParInteres;
        private System.Windows.Forms.ComboBox cboParCapital;
        private System.Windows.Forms.ComboBox cboParMora;
        private System.Windows.Forms.Label lblMora;
    }
}