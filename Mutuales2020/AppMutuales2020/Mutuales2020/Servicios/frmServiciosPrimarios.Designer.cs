namespace Mutuales2020.Servicios
{
    partial class FrmServiciosPrimarios
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
            this.cboPares = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lblPar = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.chkUnico = new System.Windows.Forms.CheckBox();
            this.txtAno = new Texto.Texto();
            this.lblAño = new System.Windows.Forms.Label();
            this.txtCuota = new Texto.Texto();
            this.lblCuota = new System.Windows.Forms.Label();
            this.txtValor = new Texto.Texto();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.strCodSpr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strNombreSpr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intValorSpr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intValorCuotaSpr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intAñoSpr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitUnicoSpr = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.strCodigoPar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(4, 353);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 55);
            this.panel1.TabIndex = 7;
            // 
            // btnModificar
            // 
            this.btnModificar.ImageIndex = 0;
            this.btnModificar.Location = new System.Drawing.Point(207, 3);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(89, 47);
            this.btnModificar.TabIndex = 8;
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
            this.btnSalir.TabIndex = 11;
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
            this.btnCancelar.TabIndex = 10;
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
            this.btnEliminar.TabIndex = 9;
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
            this.btnGuardar.TabIndex = 7;
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
            this.pnlTitulo.Size = new System.Drawing.Size(684, 57);
            this.pnlTitulo.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(1, 1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(682, 54);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SERVICIOS PRIMARIOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboPares
            // 
            this.cboPares.DisplayMember = "strDescripcion";
            this.cboPares.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPares.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPares.FormattingEnabled = true;
            this.cboPares.Location = new System.Drawing.Point(232, 43);
            this.cboPares.Name = "cboPares";
            this.cboPares.Size = new System.Drawing.Size(213, 23);
            this.cboPares.TabIndex = 6;
            this.cboPares.ValueMember = "strCodigoPar";
            this.cboPares.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboAplicaciones_KeyPress);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.strCodSpr,
            this.strNombreSpr,
            this.intValorSpr,
            this.intValorCuotaSpr,
            this.intAñoSpr,
            this.bitUnicoSpr,
            this.strCodigoPar});
            this.dgv.Location = new System.Drawing.Point(11, 81);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(664, 197);
            this.dgv.TabIndex = 7;
            this.dgv.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            // 
            // lblPar
            // 
            this.lblPar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPar.Location = new System.Drawing.Point(204, 41);
            this.lblPar.Name = "lblPar";
            this.lblPar.Size = new System.Drawing.Size(30, 22);
            this.lblPar.TabIndex = 4;
            this.lblPar.Text = "Par";
            this.lblPar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(196, 12);
            this.txtDescripcion.MaxLength = 30;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(209, 21);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // pnlControles
            // 
            this.pnlControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControles.Controls.Add(this.chkUnico);
            this.pnlControles.Controls.Add(this.txtAno);
            this.pnlControles.Controls.Add(this.lblAño);
            this.pnlControles.Controls.Add(this.txtCuota);
            this.pnlControles.Controls.Add(this.lblCuota);
            this.pnlControles.Controls.Add(this.txtValor);
            this.pnlControles.Controls.Add(this.lblValor);
            this.pnlControles.Controls.Add(this.dgv);
            this.pnlControles.Controls.Add(this.cboPares);
            this.pnlControles.Controls.Add(this.lblPar);
            this.pnlControles.Controls.Add(this.txtDescripcion);
            this.pnlControles.Controls.Add(this.lblDescripcion);
            this.pnlControles.Controls.Add(this.txtCodigo);
            this.pnlControles.Controls.Add(this.lblCodigo);
            this.pnlControles.Location = new System.Drawing.Point(4, 67);
            this.pnlControles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(684, 283);
            this.pnlControles.TabIndex = 6;
            // 
            // chkUnico
            // 
            this.chkUnico.AutoSize = true;
            this.chkUnico.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUnico.Location = new System.Drawing.Point(144, 45);
            this.chkUnico.Name = "chkUnico";
            this.chkUnico.Size = new System.Drawing.Size(58, 19);
            this.chkUnico.TabIndex = 5;
            this.chkUnico.Text = "Único";
            this.chkUnico.UseVisualStyleBackColor = true;
            this.chkUnico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chkUnico_KeyPress);
            // 
            // txtAno
            // 
            this.txtAno.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.Location = new System.Drawing.Point(48, 44);
            this.txtAno.MaxLength = 4;
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(89, 21);
            this.txtAno.TabIndex = 4;
            this.txtAno.Text = "0";
            this.txtAno.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAno_KeyPress);
            this.txtAno.Leave += new System.EventHandler(this.txtAno_Leave);
            this.txtAno.Validated += new System.EventHandler(this.txtAno_Validated);
            // 
            // lblAño
            // 
            this.lblAño.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(13, 41);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(34, 22);
            this.lblAño.TabIndex = 13;
            this.lblAño.Text = "Año*";
            this.lblAño.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCuota
            // 
            this.txtCuota.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuota.Location = new System.Drawing.Point(584, 12);
            this.txtCuota.MaxLength = 7;
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(89, 21);
            this.txtCuota.TabIndex = 3;
            this.txtCuota.Text = "0";
            this.txtCuota.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtCuota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuota_KeyPress);
            this.txtCuota.Leave += new System.EventHandler(this.txtCuota_Leave);
            this.txtCuota.Validated += new System.EventHandler(this.txtCuota_Validated);
            // 
            // lblCuota
            // 
            this.lblCuota.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuota.Location = new System.Drawing.Point(542, 9);
            this.lblCuota.Name = "lblCuota";
            this.lblCuota.Size = new System.Drawing.Size(49, 22);
            this.lblCuota.TabIndex = 11;
            this.lblCuota.Text = "Cuota*";
            this.lblCuota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(451, 12);
            this.txtValor.MaxLength = 8;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(89, 21);
            this.txtValor.TabIndex = 2;
            this.txtValor.Text = "0";
            this.txtValor.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            this.txtValor.Validated += new System.EventHandler(this.txtValor_Validated);
            // 
            // lblValor
            // 
            this.lblValor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(411, 9);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(50, 22);
            this.lblValor.TabIndex = 9;
            this.lblValor.Text = "Valor*";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(119, 9);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 22);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción*";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(57, 12);
            this.txtCodigo.MaxLength = 30;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(65, 21);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(8, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(60, 22);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código*";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // strCodSpr
            // 
            this.strCodSpr.DataPropertyName = "strCodSpr";
            this.strCodSpr.HeaderText = "Código";
            this.strCodSpr.Name = "strCodSpr";
            this.strCodSpr.ReadOnly = true;
            this.strCodSpr.Width = 70;
            // 
            // strNombreSpr
            // 
            this.strNombreSpr.DataPropertyName = "strNombreSpr";
            this.strNombreSpr.HeaderText = "Nombre";
            this.strNombreSpr.Name = "strNombreSpr";
            this.strNombreSpr.ReadOnly = true;
            this.strNombreSpr.Width = 180;
            // 
            // intValorSpr
            // 
            this.intValorSpr.DataPropertyName = "intValorSpr";
            this.intValorSpr.HeaderText = "Valor";
            this.intValorSpr.Name = "intValorSpr";
            this.intValorSpr.ReadOnly = true;
            this.intValorSpr.Width = 70;
            // 
            // intValorCuotaSpr
            // 
            this.intValorCuotaSpr.DataPropertyName = "intValorCuotaSpr";
            this.intValorCuotaSpr.HeaderText = "Cuota";
            this.intValorCuotaSpr.Name = "intValorCuotaSpr";
            this.intValorCuotaSpr.ReadOnly = true;
            this.intValorCuotaSpr.Width = 70;
            // 
            // intAñoSpr
            // 
            this.intAñoSpr.DataPropertyName = "intAñoSpr";
            this.intAñoSpr.HeaderText = "Año";
            this.intAñoSpr.Name = "intAñoSpr";
            this.intAñoSpr.ReadOnly = true;
            this.intAñoSpr.Width = 45;
            // 
            // bitUnicoSpr
            // 
            this.bitUnicoSpr.DataPropertyName = "bitUnicoSpr";
            this.bitUnicoSpr.HeaderText = "Único";
            this.bitUnicoSpr.Name = "bitUnicoSpr";
            this.bitUnicoSpr.ReadOnly = true;
            this.bitUnicoSpr.Width = 50;
            // 
            // strCodigoPar
            // 
            this.strCodigoPar.DataPropertyName = "strCodigoPar";
            this.strCodigoPar.HeaderText = "Par";
            this.strCodigoPar.Name = "strCodigoPar";
            this.strCodigoPar.ReadOnly = true;
            this.strCodigoPar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.strCodigoPar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.strCodigoPar.Width = 115;
            // 
            // FrmServiciosPrimarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 410);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlControles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmServiciosPrimarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion de servicios primarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Load);
            this.panel1.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lblPar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.CheckBox chkUnico;
        private Texto.Texto txtAno;
        private System.Windows.Forms.Label lblAño;
        private Texto.Texto txtCuota;
        private System.Windows.Forms.Label lblCuota;
        private Texto.Texto txtValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCodSpr;
        private System.Windows.Forms.DataGridViewTextBoxColumn strNombreSpr;
        private System.Windows.Forms.DataGridViewTextBoxColumn intValorSpr;
        private System.Windows.Forms.DataGridViewTextBoxColumn intValorCuotaSpr;
        private System.Windows.Forms.DataGridViewTextBoxColumn intAñoSpr;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bitUnicoSpr;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCodigoPar;
    }
}

