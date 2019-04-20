namespace winExequial2010.Servicios
{
    partial class FrmCompras
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
            this.cboProveedores = new System.Windows.Forms.ComboBox();
            this.dgvDetalleCompras = new System.Windows.Forms.DataGridView();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Appl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAplicacion = new System.Windows.Forms.Label();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.txtGanancia = new Texto.Texto();
            this.lblGanancia = new System.Windows.Forms.Label();
            this.txtValorCompra = new Texto.Texto();
            this.lblValorCompra = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtValorVenta = new Texto.Texto();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new Texto.Texto();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtValorActual = new Texto.Texto();
            this.lblValorActual = new System.Windows.Forms.Label();
            this.txtDisponibilidad = new Texto.Texto();
            this.lblDisponibilidad = new System.Windows.Forms.Label();
            this.cboNombreProducto = new System.Windows.Forms.ComboBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtTotal = new Texto.Texto();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompras)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(4, 340);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 55);
            this.panel1.TabIndex = 7;
            // 
            // btnModificar
            // 
            this.btnModificar.ImageIndex = 0;
            this.btnModificar.Location = new System.Drawing.Point(683, 3);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(89, 47);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(488, 3);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 47);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(383, 3);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 47);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(278, 3);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 47);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageIndex = 0;
            this.btnGuardar.Location = new System.Drawing.Point(173, 4);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 47);
            this.btnGuardar.TabIndex = 13;
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
            this.pnlTitulo.Size = new System.Drawing.Size(791, 45);
            this.pnlTitulo.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(1, 1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(789, 39);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "COMPRAS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboProveedores
            // 
            this.cboProveedores.DisplayMember = "strContacto";
            this.cboProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProveedores.Font = new System.Drawing.Font("Arial", 9F);
            this.cboProveedores.FormattingEnabled = true;
            this.cboProveedores.Location = new System.Drawing.Point(204, 9);
            this.cboProveedores.Name = "cboProveedores";
            this.cboProveedores.Size = new System.Drawing.Size(240, 23);
            this.cboProveedores.TabIndex = 1;
            this.cboProveedores.ValueMember = "strCodigoCli";
            this.cboProveedores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboProveedores_KeyPress);
            // 
            // dgvDetalleCompras
            // 
            this.dgvDetalleCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grupo,
            this.Nombre,
            this.Appl,
            this.Compra,
            this.Venta,
            this.Cantidad});
            this.dgvDetalleCompras.Location = new System.Drawing.Point(11, 99);
            this.dgvDetalleCompras.Name = "dgvDetalleCompras";
            this.dgvDetalleCompras.ReadOnly = true;
            this.dgvDetalleCompras.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDetalleCompras.Size = new System.Drawing.Size(771, 179);
            this.dgvDetalleCompras.TabIndex = 17;
            // 
            // Grupo
            // 
            this.Grupo.DataPropertyName = "intCodCompra";
            this.Grupo.HeaderText = "Compra";
            this.Grupo.Name = "Grupo";
            this.Grupo.ReadOnly = true;
            this.Grupo.Width = 70;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "strCodProducto";
            this.Nombre.HeaderText = "Código";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Visible = false;
            this.Nombre.Width = 373;
            // 
            // Appl
            // 
            this.Appl.DataPropertyName = "strNomProducto";
            this.Appl.HeaderText = "Producto";
            this.Appl.Name = "Appl";
            this.Appl.ReadOnly = true;
            this.Appl.Width = 250;
            // 
            // Compra
            // 
            this.Compra.DataPropertyName = "fltValorCompra";
            this.Compra.HeaderText = "Valor de Compra";
            this.Compra.Name = "Compra";
            this.Compra.ReadOnly = true;
            this.Compra.Width = 150;
            // 
            // Venta
            // 
            this.Venta.DataPropertyName = "fltValorVenta";
            this.Venta.HeaderText = "Valor de Venta";
            this.Venta.Name = "Venta";
            this.Venta.ReadOnly = true;
            this.Venta.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "intCantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // lblAplicacion
            // 
            this.lblAplicacion.Font = new System.Drawing.Font("Arial", 9F);
            this.lblAplicacion.Location = new System.Drawing.Point(458, 9);
            this.lblAplicacion.Name = "lblAplicacion";
            this.lblAplicacion.Size = new System.Drawing.Size(48, 22);
            this.lblAplicacion.TabIndex = 4;
            this.lblAplicacion.Text = "Total";
            this.lblAplicacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlControles
            // 
            this.pnlControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControles.Controls.Add(this.txtGanancia);
            this.pnlControles.Controls.Add(this.lblGanancia);
            this.pnlControles.Controls.Add(this.txtValorCompra);
            this.pnlControles.Controls.Add(this.lblValorCompra);
            this.pnlControles.Controls.Add(this.btnBorrar);
            this.pnlControles.Controls.Add(this.btnAgregar);
            this.pnlControles.Controls.Add(this.txtValorVenta);
            this.pnlControles.Controls.Add(this.label1);
            this.pnlControles.Controls.Add(this.txtCantidad);
            this.pnlControles.Controls.Add(this.lblCantidad);
            this.pnlControles.Controls.Add(this.txtValorActual);
            this.pnlControles.Controls.Add(this.lblValorActual);
            this.pnlControles.Controls.Add(this.txtDisponibilidad);
            this.pnlControles.Controls.Add(this.lblDisponibilidad);
            this.pnlControles.Controls.Add(this.cboNombreProducto);
            this.pnlControles.Controls.Add(this.lblNombreProducto);
            this.pnlControles.Controls.Add(this.txtProducto);
            this.pnlControles.Controls.Add(this.lblProducto);
            this.pnlControles.Controls.Add(this.txtTotal);
            this.pnlControles.Controls.Add(this.dgvDetalleCompras);
            this.pnlControles.Controls.Add(this.cboProveedores);
            this.pnlControles.Controls.Add(this.lblAplicacion);
            this.pnlControles.Controls.Add(this.lblProveedor);
            this.pnlControles.Controls.Add(this.txtCodigo);
            this.pnlControles.Controls.Add(this.lblCodigo);
            this.pnlControles.Location = new System.Drawing.Point(4, 54);
            this.pnlControles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(791, 283);
            this.pnlControles.TabIndex = 6;
            // 
            // txtGanancia
            // 
            this.txtGanancia.Enabled = false;
            this.txtGanancia.Font = new System.Drawing.Font("Arial", 9F);
            this.txtGanancia.Location = new System.Drawing.Point(72, 70);
            this.txtGanancia.Name = "txtGanancia";
            this.txtGanancia.Size = new System.Drawing.Size(50, 21);
            this.txtGanancia.TabIndex = 7;
            this.txtGanancia.Text = "0";
            this.txtGanancia.Tipo = Texto.Texto.Opciones.Numerico;
            // 
            // lblGanancia
            // 
            this.lblGanancia.Font = new System.Drawing.Font("Arial", 9F);
            this.lblGanancia.Location = new System.Drawing.Point(8, 70);
            this.lblGanancia.Name = "lblGanancia";
            this.lblGanancia.Size = new System.Drawing.Size(72, 22);
            this.lblGanancia.TabIndex = 26;
            this.lblGanancia.Text = "Ganancia*";
            this.lblGanancia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Font = new System.Drawing.Font("Arial", 9F);
            this.txtValorCompra.Location = new System.Drawing.Point(346, 70);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(71, 21);
            this.txtValorCompra.TabIndex = 9;
            this.txtValorCompra.Text = "0";
            this.txtValorCompra.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtValorCompra.Leave += new System.EventHandler(this.txtValorCompra_Leave);
            this.txtValorCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorCompra_KeyPress);
            // 
            // lblValorCompra
            // 
            this.lblValorCompra.Font = new System.Drawing.Font("Arial", 9F);
            this.lblValorCompra.Location = new System.Drawing.Point(264, 69);
            this.lblValorCompra.Name = "lblValorCompra";
            this.lblValorCompra.Size = new System.Drawing.Size(90, 22);
            this.lblValorCompra.TabIndex = 24;
            this.lblValorCompra.Text = "Valor compra*";
            this.lblValorCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Arial", 9F);
            this.btnBorrar.Location = new System.Drawing.Point(653, 70);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 9F);
            this.btnAgregar.Location = new System.Drawing.Point(572, 70);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtValorVenta
            // 
            this.txtValorVenta.Font = new System.Drawing.Font("Arial", 9F);
            this.txtValorVenta.Location = new System.Drawing.Point(492, 70);
            this.txtValorVenta.Name = "txtValorVenta";
            this.txtValorVenta.Size = new System.Drawing.Size(71, 21);
            this.txtValorVenta.TabIndex = 10;
            this.txtValorVenta.Text = "0";
            this.txtValorVenta.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtValorVenta.Leave += new System.EventHandler(this.txtValorVenta_Leave);
            this.txtValorVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorVenta_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9F);
            this.label1.Location = new System.Drawing.Point(419, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Valor venta*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Arial", 9F);
            this.txtCantidad.Location = new System.Drawing.Point(202, 70);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(50, 21);
            this.txtCantidad.TabIndex = 8;
            this.txtCantidad.Text = "0";
            this.txtCantidad.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.Font = new System.Drawing.Font("Arial", 9F);
            this.lblCantidad.Location = new System.Drawing.Point(139, 70);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(62, 22);
            this.lblCantidad.TabIndex = 18;
            this.lblCantidad.Text = "Cantidad*";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtValorActual
            // 
            this.txtValorActual.Enabled = false;
            this.txtValorActual.Font = new System.Drawing.Font("Arial", 9F);
            this.txtValorActual.Location = new System.Drawing.Point(703, 40);
            this.txtValorActual.Name = "txtValorActual";
            this.txtValorActual.Size = new System.Drawing.Size(82, 21);
            this.txtValorActual.TabIndex = 6;
            this.txtValorActual.Text = "0";
            this.txtValorActual.Tipo = Texto.Texto.Opciones.Numerico;
            // 
            // lblValorActual
            // 
            this.lblValorActual.Font = new System.Drawing.Font("Arial", 9F);
            this.lblValorActual.Location = new System.Drawing.Point(629, 40);
            this.lblValorActual.Name = "lblValorActual";
            this.lblValorActual.Size = new System.Drawing.Size(79, 22);
            this.lblValorActual.TabIndex = 16;
            this.lblValorActual.Text = "Valor actual*";
            this.lblValorActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDisponibilidad
            // 
            this.txtDisponibilidad.Enabled = false;
            this.txtDisponibilidad.Font = new System.Drawing.Font("Arial", 9F);
            this.txtDisponibilidad.Location = new System.Drawing.Point(593, 40);
            this.txtDisponibilidad.Name = "txtDisponibilidad";
            this.txtDisponibilidad.Size = new System.Drawing.Size(34, 21);
            this.txtDisponibilidad.TabIndex = 5;
            this.txtDisponibilidad.Text = "0";
            this.txtDisponibilidad.Tipo = Texto.Texto.Opciones.Numerico;
            // 
            // lblDisponibilidad
            // 
            this.lblDisponibilidad.Font = new System.Drawing.Font("Arial", 9F);
            this.lblDisponibilidad.Location = new System.Drawing.Point(504, 40);
            this.lblDisponibilidad.Name = "lblDisponibilidad";
            this.lblDisponibilidad.Size = new System.Drawing.Size(99, 22);
            this.lblDisponibilidad.TabIndex = 14;
            this.lblDisponibilidad.Text = "Disponibilidad*";
            this.lblDisponibilidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboNombreProducto
            // 
            this.cboNombreProducto.DisplayMember = "strDesProducto";
            this.cboNombreProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNombreProducto.Font = new System.Drawing.Font("Arial", 9F);
            this.cboNombreProducto.FormattingEnabled = true;
            this.cboNombreProducto.Location = new System.Drawing.Point(270, 40);
            this.cboNombreProducto.Name = "cboNombreProducto";
            this.cboNombreProducto.Size = new System.Drawing.Size(231, 23);
            this.cboNombreProducto.TabIndex = 4;
            this.cboNombreProducto.ValueMember = "strCodProducto";
            this.cboNombreProducto.Leave += new System.EventHandler(this.cboNombreProducto_Leave);
            this.cboNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboNombreProducto_KeyPress);
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.Font = new System.Drawing.Font("Arial", 9F);
            this.lblNombreProducto.Location = new System.Drawing.Point(216, 40);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(58, 22);
            this.lblNombreProducto.TabIndex = 12;
            this.lblNombreProducto.Text = "Nombre*";
            this.lblNombreProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Arial", 9F);
            this.txtProducto.Location = new System.Drawing.Point(69, 40);
            this.txtProducto.MaxLength = 30;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(142, 21);
            this.txtProducto.TabIndex = 3;
            this.txtProducto.Leave += new System.EventHandler(this.txtProducto_Leave);
            this.txtProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProducto_KeyPress);
            // 
            // lblProducto
            // 
            this.lblProducto.Font = new System.Drawing.Font("Arial", 9F);
            this.lblProducto.Location = new System.Drawing.Point(8, 40);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(61, 22);
            this.lblProducto.TabIndex = 10;
            this.lblProducto.Text = "Producto*";
            this.lblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Arial", 9F);
            this.txtTotal.Location = new System.Drawing.Point(494, 10);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 21);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.Text = "0";
            this.txtTotal.Tipo = Texto.Texto.Opciones.Numerico;
            // 
            // lblProveedor
            // 
            this.lblProveedor.Font = new System.Drawing.Font("Arial", 9F);
            this.lblProveedor.Location = new System.Drawing.Point(134, 9);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(73, 22);
            this.lblProveedor.TabIndex = 2;
            this.lblProveedor.Text = "Proveedor*";
            this.lblProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 9F);
            this.txtCodigo.Location = new System.Drawing.Point(58, 9);
            this.txtCodigo.MaxLength = 30;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(71, 21);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = "0";
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 9F);
            this.lblCodigo.Location = new System.Drawing.Point(8, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(61, 22);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Factura*";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 398);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlControles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de compras";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompras)).EndInit();
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
        private System.Windows.Forms.ComboBox cboProveedores;
        private System.Windows.Forms.DataGridView dgvDetalleCompras;
        private System.Windows.Forms.Label lblAplicacion;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private Texto.Texto txtTotal;
        private Texto.Texto txtDisponibilidad;
        private System.Windows.Forms.Label lblDisponibilidad;
        private System.Windows.Forms.ComboBox cboNombreProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblProducto;
        private Texto.Texto txtValorActual;
        private System.Windows.Forms.Label lblValorActual;
        private Texto.Texto txtValorVenta;
        private System.Windows.Forms.Label label1;
        private Texto.Texto txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAgregar;
        private Texto.Texto txtValorCompra;
        private System.Windows.Forms.Label lblValorCompra;
        private Texto.Texto txtGanancia;
        private System.Windows.Forms.Label lblGanancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Appl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}

