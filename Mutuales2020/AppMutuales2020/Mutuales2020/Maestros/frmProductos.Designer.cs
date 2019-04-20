namespace Mutuales2020.Maestros
{
    partial class frmProductos
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.strCodProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strDesProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intMinProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intMaxProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intValCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intValUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fltMargendeGanancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fltIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.txtIva = new Texto.Texto();
            this.lblIva = new System.Windows.Forms.Label();
            this.txtMargen = new Texto.Texto();
            this.lblMargen = new System.Windows.Forms.Label();
            this.txtCantidad = new Texto.Texto();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtVenta = new Texto.Texto();
            this.lblVenta = new System.Windows.Forms.Label();
            this.txtCompra = new Texto.Texto();
            this.lblCompra = new System.Windows.Forms.Label();
            this.txtMaximo = new Texto.Texto();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.txtMinimo = new Texto.Texto();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
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
            this.btnModificar.Location = new System.Drawing.Point(185, 3);
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
            this.btnSalir.Location = new System.Drawing.Point(490, 3);
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
            this.btnCancelar.Location = new System.Drawing.Point(385, 3);
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
            this.btnEliminar.Location = new System.Drawing.Point(280, 3);
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
            this.btnGuardar.Location = new System.Drawing.Point(80, 3);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 47);
            this.btnGuardar.TabIndex = 9;
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
            this.lblTitulo.Text = "PRODUCTOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.strCodProducto,
            this.strDesProducto,
            this.intMinProducto,
            this.intMaxProducto,
            this.intValCompra,
            this.intValUnitario,
            this.intCantidad,
            this.fltMargendeGanancia,
            this.fltIva});
            this.dgv.Location = new System.Drawing.Point(11, 65);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(657, 213);
            this.dgv.TabIndex = 8;
            this.dgv.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            // 
            // strCodProducto
            // 
            this.strCodProducto.DataPropertyName = "strCodProducto";
            this.strCodProducto.HeaderText = "Código";
            this.strCodProducto.Name = "strCodProducto";
            this.strCodProducto.ReadOnly = true;
            this.strCodProducto.Width = 90;
            // 
            // strDesProducto
            // 
            this.strDesProducto.DataPropertyName = "strDesProducto";
            this.strDesProducto.HeaderText = "Descripción";
            this.strDesProducto.Name = "strDesProducto";
            this.strDesProducto.ReadOnly = true;
            this.strDesProducto.Width = 140;
            // 
            // intMinProducto
            // 
            this.intMinProducto.DataPropertyName = "intMinProducto";
            this.intMinProducto.HeaderText = "Mínimo";
            this.intMinProducto.Name = "intMinProducto";
            this.intMinProducto.ReadOnly = true;
            this.intMinProducto.Width = 50;
            // 
            // intMaxProducto
            // 
            this.intMaxProducto.DataPropertyName = "intMaxProducto";
            this.intMaxProducto.HeaderText = "Máximo";
            this.intMaxProducto.Name = "intMaxProducto";
            this.intMaxProducto.ReadOnly = true;
            this.intMaxProducto.Width = 50;
            // 
            // intValCompra
            // 
            this.intValCompra.DataPropertyName = "intValCompra";
            this.intValCompra.HeaderText = "Compra";
            this.intValCompra.Name = "intValCompra";
            this.intValCompra.ReadOnly = true;
            this.intValCompra.Width = 60;
            // 
            // intValUnitario
            // 
            this.intValUnitario.DataPropertyName = "intValUnitario";
            this.intValUnitario.HeaderText = "Venta";
            this.intValUnitario.Name = "intValUnitario";
            this.intValUnitario.ReadOnly = true;
            this.intValUnitario.Width = 60;
            // 
            // intCantidad
            // 
            this.intCantidad.DataPropertyName = "intCantidad";
            this.intCantidad.HeaderText = "Cant";
            this.intCantidad.Name = "intCantidad";
            this.intCantidad.ReadOnly = true;
            this.intCantidad.Width = 40;
            // 
            // fltMargendeGanancia
            // 
            this.fltMargendeGanancia.DataPropertyName = "fltMargendeGanancia";
            this.fltMargendeGanancia.HeaderText = "Ganancia %";
            this.fltMargendeGanancia.Name = "fltMargendeGanancia";
            this.fltMargendeGanancia.ReadOnly = true;
            this.fltMargendeGanancia.Width = 70;
            // 
            // fltIva
            // 
            this.fltIva.DataPropertyName = "fltIva";
            this.fltIva.HeaderText = "Iva";
            this.fltIva.Name = "fltIva";
            this.fltIva.ReadOnly = true;
            this.fltIva.Width = 40;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(243, 10);
            this.txtDescripcion.MaxLength = 30;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(199, 21);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // pnlControles
            // 
            this.pnlControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControles.Controls.Add(this.txtIva);
            this.pnlControles.Controls.Add(this.lblIva);
            this.pnlControles.Controls.Add(this.txtMargen);
            this.pnlControles.Controls.Add(this.lblMargen);
            this.pnlControles.Controls.Add(this.txtCantidad);
            this.pnlControles.Controls.Add(this.lblCantidad);
            this.pnlControles.Controls.Add(this.txtVenta);
            this.pnlControles.Controls.Add(this.lblVenta);
            this.pnlControles.Controls.Add(this.txtCompra);
            this.pnlControles.Controls.Add(this.lblCompra);
            this.pnlControles.Controls.Add(this.txtMaximo);
            this.pnlControles.Controls.Add(this.lblMaximo);
            this.pnlControles.Controls.Add(this.txtMinimo);
            this.pnlControles.Controls.Add(this.lblMinimo);
            this.pnlControles.Controls.Add(this.dgv);
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
            // txtIva
            // 
            this.txtIva.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.Location = new System.Drawing.Point(540, 34);
            this.txtIva.MaxLength = 11;
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(59, 21);
            this.txtIva.TabIndex = 8;
            this.txtIva.Text = "0";
            this.txtIva.Tipo = Texto.Texto.Opciones.Decimal;
            this.txtIva.Leave += new System.EventHandler(this.txtIva_Leave);
            this.txtIva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIva_KeyPress);
            // 
            // lblIva
            // 
            this.lblIva.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.Location = new System.Drawing.Point(516, 34);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(34, 22);
            this.lblIva.TabIndex = 21;
            this.lblIva.Text = "Iva";
            this.lblIva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMargen
            // 
            this.txtMargen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMargen.Location = new System.Drawing.Point(211, 34);
            this.txtMargen.MaxLength = 12;
            this.txtMargen.Name = "txtMargen";
            this.txtMargen.Size = new System.Drawing.Size(59, 21);
            this.txtMargen.TabIndex = 5;
            this.txtMargen.Text = "0";
            this.txtMargen.Tipo = Texto.Texto.Opciones.Decimal;
            this.txtMargen.Leave += new System.EventHandler(this.txtMargen_Leave);
            this.txtMargen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMargen_KeyPress);
            // 
            // lblMargen
            // 
            this.lblMargen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMargen.Location = new System.Drawing.Point(129, 34);
            this.lblMargen.Name = "lblMargen";
            this.lblMargen.Size = new System.Drawing.Size(86, 22);
            this.lblMargen.TabIndex = 19;
            this.lblMargen.Text = "Ganancia %*";
            this.lblMargen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(450, 34);
            this.txtCantidad.MaxLength = 8;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(59, 21);
            this.txtCantidad.TabIndex = 7;
            this.txtCantidad.Text = "0";
            this.txtCantidad.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(388, 34);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(67, 22);
            this.lblCantidad.TabIndex = 17;
            this.lblCantidad.Text = "Cantidad*";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtVenta
            // 
            this.txtVenta.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenta.Location = new System.Drawing.Point(321, 34);
            this.txtVenta.MaxLength = 12;
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Size = new System.Drawing.Size(59, 21);
            this.txtVenta.TabIndex = 6;
            this.txtVenta.Text = "0";
            this.txtVenta.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtVenta.Leave += new System.EventHandler(this.txtVenta_Leave);
            this.txtVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVenta_KeyPress);
            // 
            // lblVenta
            // 
            this.lblVenta.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenta.Location = new System.Drawing.Point(277, 34);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(48, 22);
            this.lblVenta.TabIndex = 15;
            this.lblVenta.Text = "Venta*";
            this.lblVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCompra
            // 
            this.txtCompra.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompra.Location = new System.Drawing.Point(64, 34);
            this.txtCompra.MaxLength = 12;
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.Size = new System.Drawing.Size(59, 21);
            this.txtCompra.TabIndex = 4;
            this.txtCompra.Text = "0";
            this.txtCompra.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtCompra.Leave += new System.EventHandler(this.txtCompra_Leave);
            this.txtCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCompra_KeyPress);
            // 
            // lblCompra
            // 
            this.lblCompra.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompra.Location = new System.Drawing.Point(8, 34);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(58, 22);
            this.lblCompra.TabIndex = 13;
            this.lblCompra.Text = "Compra*";
            this.lblCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaximo
            // 
            this.txtMaximo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaximo.Location = new System.Drawing.Point(614, 10);
            this.txtMaximo.MaxLength = 8;
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(59, 21);
            this.txtMaximo.TabIndex = 3;
            this.txtMaximo.Text = "0";
            this.txtMaximo.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtMaximo.Leave += new System.EventHandler(this.txtMaximo_Leave);
            this.txtMaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaximo_KeyPress);
            // 
            // lblMaximo
            // 
            this.lblMaximo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximo.Location = new System.Drawing.Point(560, 9);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(58, 22);
            this.lblMaximo.TabIndex = 11;
            this.lblMaximo.Text = "Máximo*";
            this.lblMaximo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMinimo
            // 
            this.txtMinimo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinimo.Location = new System.Drawing.Point(499, 10);
            this.txtMinimo.MaxLength = 8;
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(59, 21);
            this.txtMinimo.TabIndex = 2;
            this.txtMinimo.Text = "0";
            this.txtMinimo.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtMinimo.Leave += new System.EventHandler(this.txtMinimo_Leave);
            this.txtMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinimo_KeyPress);
            // 
            // lblMinimo
            // 
            this.lblMinimo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimo.Location = new System.Drawing.Point(448, 9);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(54, 22);
            this.lblMinimo.TabIndex = 9;
            this.lblMinimo.Text = "Mínimo*";
            this.lblMinimo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(163, 9);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(90, 22);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción*";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(60, 10);
            this.txtCodigo.MaxLength = 30;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(108, 21);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(8, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(58, 22);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código*";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 410);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlControles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de productos";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_FormClosed);
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
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblMinimo;
        private Texto.Texto txtMinimo;
        private Texto.Texto txtVenta;
        private System.Windows.Forms.Label lblVenta;
        private Texto.Texto txtCompra;
        private System.Windows.Forms.Label lblCompra;
        private Texto.Texto txtMaximo;
        private System.Windows.Forms.Label lblMaximo;
        private Texto.Texto txtIva;
        private System.Windows.Forms.Label lblIva;
        private Texto.Texto txtMargen;
        private System.Windows.Forms.Label lblMargen;
        private Texto.Texto txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCodProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn strDesProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn intMinProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn intMaxProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn intValCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn intValUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn intCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn fltMargendeGanancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn fltIva;
    }
}

