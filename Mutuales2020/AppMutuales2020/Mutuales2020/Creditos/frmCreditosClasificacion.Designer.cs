namespace Mutuales2020.Creditos
{
    partial class frmCreditosClasificacion
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDiasHasta = new Texto.Texto();
            this.txtDiasEntre = new Texto.Texto();
            this.txtProvision = new Texto.Texto();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaIncial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumaCartera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interesd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkInteresporDias = new System.Windows.Forms.CheckBox();
            this.chkCausarIntereses = new System.Windows.Forms.CheckBox();
            this.chkSumarICM = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDiasMayores = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblProvision = new System.Windows.Forms.Label();
            this.cboTiposdeCredito = new System.Windows.Forms.ComboBox();
            this.lblServicio = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lCodigo = new System.Windows.Forms.Label();
            this.lblTipodeCredito = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCredito = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtDiasHasta);
            this.panel2.Controls.Add(this.txtDiasEntre);
            this.panel2.Controls.Add(this.txtProvision);
            this.panel2.Controls.Add(this.dgvDatos);
            this.panel2.Controls.Add(this.chkInteresporDias);
            this.panel2.Controls.Add(this.chkCausarIntereses);
            this.panel2.Controls.Add(this.chkSumarICM);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblDiasMayores);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.lblProvision);
            this.panel2.Controls.Add(this.cboTiposdeCredito);
            this.panel2.Controls.Add(this.lblServicio);
            this.panel2.Controls.Add(this.txtCodigo);
            this.panel2.Controls.Add(this.lCodigo);
            this.panel2.Controls.Add(this.lblTipodeCredito);
            this.panel2.Location = new System.Drawing.Point(4, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 261);
            this.panel2.TabIndex = 30;
            // 
            // txtDiasHasta
            // 
            this.txtDiasHasta.Location = new System.Drawing.Point(181, 43);
            this.txtDiasHasta.Name = "txtDiasHasta";
            this.txtDiasHasta.Size = new System.Drawing.Size(42, 20);
            this.txtDiasHasta.TabIndex = 5;
            this.txtDiasHasta.Text = "0";
            this.txtDiasHasta.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtDiasHasta.Leave += new System.EventHandler(this.txtDiasHasta_Leave);
            this.txtDiasHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiasHasta_KeyPress);
            // 
            // txtDiasEntre
            // 
            this.txtDiasEntre.Location = new System.Drawing.Point(66, 43);
            this.txtDiasEntre.Name = "txtDiasEntre";
            this.txtDiasEntre.Size = new System.Drawing.Size(42, 20);
            this.txtDiasEntre.TabIndex = 4;
            this.txtDiasEntre.Text = "0";
            this.txtDiasEntre.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtDiasEntre.Leave += new System.EventHandler(this.txtDiasEntre_Leave);
            this.txtDiasEntre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiasEntre_KeyPress);
            // 
            // txtProvision
            // 
            this.txtProvision.Location = new System.Drawing.Point(397, 16);
            this.txtProvision.Name = "txtProvision";
            this.txtProvision.Size = new System.Drawing.Size(42, 20);
            this.txtProvision.TabIndex = 2;
            this.txtProvision.Text = "0";
            this.txtProvision.Tipo = Texto.Texto.Opciones.Decimal;
            this.txtProvision.Leave += new System.EventHandler(this.txtProvision_Leave);
            this.txtProvision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProvision_KeyPress);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Provision,
            this.TipoCredito,
            this.diaIncial,
            this.diaFinal,
            this.SumaCartera,
            this.Interes,
            this.Interesd});
            this.dgvDatos.Location = new System.Drawing.Point(12, 98);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(661, 150);
            this.dgvDatos.TabIndex = 32;
            this.dgvDatos.DoubleClick += new System.EventHandler(this.dgvDatos_DoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "strCodigoCla";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "strNombreCla";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 70;
            // 
            // Provision
            // 
            this.Provision.DataPropertyName = "decValorProvisionCla";
            this.Provision.HeaderText = "Provisión";
            this.Provision.Name = "Provision";
            this.Provision.ReadOnly = true;
            this.Provision.Width = 60;
            // 
            // TipoCredito
            // 
            this.TipoCredito.DataPropertyName = "strCodigoTcr";
            this.TipoCredito.HeaderText = "Tipo de Credito";
            this.TipoCredito.Name = "TipoCredito";
            this.TipoCredito.ReadOnly = true;
            this.TipoCredito.Width = 104;
            // 
            // diaIncial
            // 
            this.diaIncial.DataPropertyName = "intDesdeCla";
            this.diaIncial.HeaderText = "Dia Entre";
            this.diaIncial.Name = "diaIncial";
            this.diaIncial.ReadOnly = true;
            this.diaIncial.Width = 80;
            // 
            // diaFinal
            // 
            this.diaFinal.DataPropertyName = "intHastaCla";
            this.diaFinal.HeaderText = "y Entre";
            this.diaFinal.Name = "diaFinal";
            this.diaFinal.ReadOnly = true;
            this.diaFinal.Width = 50;
            // 
            // SumaCartera
            // 
            this.SumaCartera.DataPropertyName = "bitSumarICM";
            this.SumaCartera.HeaderText = "S. Cartera";
            this.SumaCartera.Name = "SumaCartera";
            this.SumaCartera.ReadOnly = true;
            this.SumaCartera.Width = 60;
            // 
            // Interes
            // 
            this.Interes.DataPropertyName = "bitCausarInteresesCla";
            this.Interes.HeaderText = "Interes";
            this.Interes.Name = "Interes";
            this.Interes.ReadOnly = true;
            this.Interes.Width = 50;
            // 
            // Interesd
            // 
            this.Interesd.DataPropertyName = "bitInteresporDiasCla";
            this.Interesd.HeaderText = "Interes Día";
            this.Interesd.Name = "Interesd";
            this.Interesd.ReadOnly = true;
            this.Interesd.Width = 85;
            // 
            // chkInteresporDias
            // 
            this.chkInteresporDias.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInteresporDias.Location = new System.Drawing.Point(12, 68);
            this.chkInteresporDias.Name = "chkInteresporDias";
            this.chkInteresporDias.Size = new System.Drawing.Size(136, 24);
            this.chkInteresporDias.TabIndex = 8;
            this.chkInteresporDias.Text = "Intereses por Dias";
            this.chkInteresporDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chkInteresporDias_KeyPress);
            // 
            // chkCausarIntereses
            // 
            this.chkCausarIntereses.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCausarIntereses.Location = new System.Drawing.Point(512, 43);
            this.chkCausarIntereses.Name = "chkCausarIntereses";
            this.chkCausarIntereses.Size = new System.Drawing.Size(128, 24);
            this.chkCausarIntereses.TabIndex = 7;
            this.chkCausarIntereses.Text = "Causar intereses";
            this.chkCausarIntereses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chkCausarIntereses_KeyPress);
            // 
            // chkSumarICM
            // 
            this.chkSumarICM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSumarICM.Location = new System.Drawing.Point(250, 43);
            this.chkSumarICM.Name = "chkSumarICM";
            this.chkSumarICM.Size = new System.Drawing.Size(256, 24);
            this.chkSumarICM.TabIndex = 6;
            this.chkSumarICM.Text = "Sumar en el índice de cartera morosa";
            this.chkSumarICM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chkSumarICM_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Hasta";
            // 
            // lblDiasMayores
            // 
            this.lblDiasMayores.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasMayores.Location = new System.Drawing.Point(9, 43);
            this.lblDiasMayores.Name = "lblDiasMayores";
            this.lblDiasMayores.Size = new System.Drawing.Size(72, 16);
            this.lblDiasMayores.TabIndex = 25;
            this.lblDiasMayores.Text = "Desde";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(175, 16);
            this.txtNombre.MaxLength = 60;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(152, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblProvision
            // 
            this.lblProvision.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvision.Location = new System.Drawing.Point(334, 16);
            this.lblProvision.Name = "lblProvision";
            this.lblProvision.Size = new System.Drawing.Size(64, 16);
            this.lblProvision.TabIndex = 14;
            this.lblProvision.Text = "Provisión";
            // 
            // cboTiposdeCredito
            // 
            this.cboTiposdeCredito.DisplayMember = "strDescripcionTcr";
            this.cboTiposdeCredito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTiposdeCredito.Items.AddRange(new object[] {
            "fg"});
            this.cboTiposdeCredito.Location = new System.Drawing.Point(545, 17);
            this.cboTiposdeCredito.Name = "cboTiposdeCredito";
            this.cboTiposdeCredito.Size = new System.Drawing.Size(128, 21);
            this.cboTiposdeCredito.TabIndex = 3;
            this.cboTiposdeCredito.ValueMember = "strCodigoTcr";
            this.cboTiposdeCredito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboTiposdeCredito_KeyPress);
            // 
            // lblServicio
            // 
            this.lblServicio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.Location = new System.Drawing.Point(119, 16);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(56, 16);
            this.lblServicio.TabIndex = 4;
            this.lblServicio.Text = "Nombre";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(59, 16);
            this.txtCodigo.MaxLength = 20;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(54, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lCodigo
            // 
            this.lCodigo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCodigo.Location = new System.Drawing.Point(7, 16);
            this.lCodigo.Name = "lCodigo";
            this.lCodigo.Size = new System.Drawing.Size(56, 16);
            this.lCodigo.TabIndex = 2;
            this.lCodigo.Text = "Código";
            // 
            // lblTipodeCredito
            // 
            this.lblTipodeCredito.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipodeCredito.Location = new System.Drawing.Point(443, 17);
            this.lblTipodeCredito.Name = "lblTipodeCredito";
            this.lblTipodeCredito.Size = new System.Drawing.Size(96, 16);
            this.lblTipodeCredito.TabIndex = 19;
            this.lblTipodeCredito.Text = "Tipo de crédito";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(8, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(668, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CLASIFICACIÓN DE CRÉDITOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValor
            // 
            this.lblValor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(332, 69);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(40, 16);
            this.lblValor.TabIndex = 32;
            this.lblValor.Text = "Valor";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 40);
            this.panel1.TabIndex = 29;
            // 
            // lblCredito
            // 
            this.lblCredito.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredito.Location = new System.Drawing.Point(316, 69);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(48, 16);
            this.lblCredito.TabIndex = 31;
            this.lblCredito.Text = "Credito";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnModificar);
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Location = new System.Drawing.Point(4, 321);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(684, 55);
            this.panel3.TabIndex = 33;
            // 
            // btnModificar
            // 
            this.btnModificar.ImageIndex = 0;
            this.btnModificar.Location = new System.Drawing.Point(207, 3);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(89, 47);
            this.btnModificar.TabIndex = 10;
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
            this.btnSalir.TabIndex = 13;
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
            this.btnCancelar.TabIndex = 12;
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
            this.btnEliminar.TabIndex = 11;
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
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmCreditosClasificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 381);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCredito);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreditosClasificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración clasificación de crédito";
            this.Load += new System.EventHandler(this.frmCreditosClasificacion_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCreditosClasificacion_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkInteresporDias;
        private System.Windows.Forms.CheckBox chkCausarIntereses;
        private System.Windows.Forms.CheckBox chkSumarICM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDiasMayores;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblProvision;
        public System.Windows.Forms.ComboBox cboTiposdeCredito;
        private System.Windows.Forms.Label lblServicio;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lCodigo;
        private System.Windows.Forms.Label lblTipodeCredito;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private Texto.Texto txtDiasHasta;
        private Texto.Texto txtDiasEntre;
        private Texto.Texto txtProvision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provision;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaIncial;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumaCartera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interesd;
    }
}