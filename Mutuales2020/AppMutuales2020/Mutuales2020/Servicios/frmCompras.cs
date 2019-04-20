using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using libExequial2010.dominio;
using libExequial2010.logica;

namespace winExequial2010.Servicios
{
    public partial class FrmCompras : Form
    {
        List<CompraDetalle> lstCompraDetalle = new blCompras().gmtdConsultarDetalle(-1);

        public FrmCompras()
        {
            InitializeComponent();
        }

        #region metodos
        private static FrmCompras form = null;
        public static FrmCompras DefInstance
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new FrmCompras();
                }
                else
                {
                    form.BringToFront();
                }
                return form;
            }
            set
            {
                form = value;
            }
        }

        /// <summary>
        /// Habilita o deshabilita los botones de acuerdo a las opciones en la base de 
        /// datos
        /// </summary>
        private void gmtdPermisosBotones()
        {
            Program.gmtdAsignarPermisos(ref btnGuardar, ref btnModificar, ref btnEliminar);
        }

        /// <summary>
        /// Carga la grid con datos si tiene permisos necesarios.
        /// </summary>
        private void pmtdCargarGrid()
        {
            if (propiedadesExequial2010.bitConsultar == true)
            {
                blCompras blCom = new blCompras();
                this.dgvDetalleCompras.DataSource = blCom.gmtdConsultarTodos();
            }
        }

        /// <summary>
        /// Limpia los texbox del formulario.
        /// </summary>
        private void pmtdLimpiarText()
        {
            this.txtCodigo.Text = "0";
            this.cboProveedores.SelectedIndex = 0;
            this.txtTotal.Text = "0";
            this.txtProducto.Text = "";
            this.cboNombreProducto.SelectedIndex = 0;
            this.txtDisponibilidad.Text = "0";
            this.txtValorActual.Text = "0";
            this.txtValorCompra.Text = "0";
            this.txtValorVenta.Text = "0";
            this.txtCantidad.Text = "0";
            this.txtGanancia.Text = "0";
            this.lstCompraDetalle.Clear();
            this.dgvDetalleCompras.DataSource = null;
        }

        /// <summary>
        /// Habilita o deshabilita los controles de la aplicación.
        /// </summary>
        /// <param name="a"></param>
        private void pmtdHabilitarText(bool a)
        {
            this.txtCodigo.Enabled = a;
            this.cboProveedores.Enabled = a;
            this.txtProducto.Enabled = a;
            this.cboNombreProducto.Enabled = a;
            this.txtValorCompra.Enabled = a;
            this.txtValorVenta.Enabled = a;
            this.txtCantidad.Enabled = a;
        }

        /// <summary>
        /// Crea un objeto del tipo aplicación de acuerdo a la información de los texbox.
        /// </summary>
        /// <returns> Un objeto del tipo aplicación. </returns>
        private tblCompra crearObj()
        {
            List<tblComprasDetalle> lstDetalle = new List<tblComprasDetalle>();
            tblCompra compra = new tblCompra();

            if (this.dgvDetalleCompras.RowCount >=1)
            {
                foreach (DataGridViewRow row in this.dgvDetalleCompras.Rows)
                {
                    tblComprasDetalle cd = new tblComprasDetalle();
                    cd.fltValorCompra = Convert.ToDouble(row.Cells[3].Value);
                    cd.fltValorVenta = Convert.ToDouble(row.Cells[4].Value);
                    cd.intCantidad = Convert.ToInt32(row.Cells[5].Value);
                    cd.fltTotal = cd.fltValorCompra * cd.intCantidad;
                    cd.strCodProducto = row.Cells[1].Value.ToString();
                    lstDetalle.Add(cd);
                }

                compra.intCodCompra = Convert.ToInt32(this.txtCodigo.Text);
                compra.dtmFechaCom = DateTime.Now;
                compra.fltDebeCom = Convert.ToDouble(this.txtTotal.Text);
                compra.fltTotalCom = Convert.ToDouble(this.txtTotal.Text);
                compra.strCodProvedor = this.cboProveedores.SelectedValue.ToString();
                compra.strFormulario = this.Name;
                compra.lstDetalle = lstDetalle;
            }
            return compra;
        }

        /// <summary> De acuerdo al string devuelto por un metodo elabora un mensaje. </summary>
        /// <param name="tstrMensaje"> string que devuelve el objeto. </param>
        /// <param name="tstrFormulario"> formulario desde el que se esta mandando a contruir el mensaje</param>
        /// <returns> un mensaje </returns>
        private DialogResult pmtdMensaje(string tstrMensaje, string tstrFormulario)
        {
            DialogResult mensaje;
            if (tstrMensaje.Substring(0, 1) == "-")
            {
                mensaje = MessageBox.Show(tstrMensaje.Substring(2, tstrMensaje.Length - 2), tstrFormulario, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mensaje = MessageBox.Show(tstrMensaje, tstrFormulario, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return mensaje;
        }
        #endregion

        private void cboNombreProducto_Leave(object sender, EventArgs e)
        {
            if (this.cboNombreProducto.SelectedIndex >= 0)
                this.txtProducto.Text = this.cboNombreProducto.SelectedValue.ToString();
            else
                this.txtProducto.Text = "0";

            this.txtDisponibilidad.Text = "0";
            this.txtValorActual.Text = "0";
            this.txtGanancia.Text = "0";

            tblProducto producto = new tblProducto();
            producto = new blProducto().gmtdConsultar(this.txtProducto.Text);
            this.txtProducto.Text = this.txtProducto.Text;
            this.txtDisponibilidad.Text = producto.intCantidad.ToString();
            this.txtValorActual.Text = producto.intValUnitario.ToString();
            this.txtGanancia.Text = producto.fltMargendeGanancia.ToString();
        }

        private void txtProducto_Leave(object sender, EventArgs e)
        {
            this.txtDisponibilidad.Text = "0";
            this.txtValorActual.Text = "0";
            this.txtGanancia.Text = "0";

            tblProducto producto = new tblProducto();
            producto = new blProducto().gmtdConsultar(this.txtProducto.Text);
            this.cboNombreProducto.SelectedValue = this.txtProducto.Text;
            this.txtDisponibilidad.Text = producto.intCantidad.ToString();
            this.txtValorActual.Text = producto.intValUnitario.ToString();
            this.txtGanancia.Text = producto.fltMargendeGanancia.ToString();
        }

        private void txtValorCompra_Leave(object sender, EventArgs e)
        {
            if (this.txtValorCompra.Text.Trim() == "")
                this.txtValorCompra.Text = "0";

            this.txtValorVenta.Text = (((Convert.ToDecimal(this.txtGanancia.Text) / 100) * Convert.ToDecimal(this.txtValorCompra.Text)) + Convert.ToDecimal(this.txtValorCompra.Text)).ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.txtProducto.Text.Trim() != "0"
                && this.txtProducto.Text.Trim() != "0"
                && this.cboNombreProducto.SelectedIndex >= 0
                && this.txtGanancia.Text.Trim() != ""
                && this.txtGanancia.Text.Trim() != "0")
            {

                var query =
                    from cd in this.lstCompraDetalle
                    where cd.strCodProducto == this.txtProducto.Text
                    select cd;

                if (query.ToList().Count <= 0)
                {
                    CompraDetalle compraDetalle = new CompraDetalle();
                    compraDetalle.fltTotal = Convert.ToDouble(this.txtValorCompra.Text) * Convert.ToDouble(this.txtCantidad.Text);
                    compraDetalle.fltValorCompra = Convert.ToDouble(this.txtValorCompra.Text);
                    compraDetalle.fltValorVenta = Convert.ToDouble(this.txtValorVenta.Text);
                    compraDetalle.intCantidad = Convert.ToInt32(this.txtCantidad.Text);
                    compraDetalle.intCodCompra = 0;
                    compraDetalle.strCodProducto = this.cboNombreProducto.SelectedValue.ToString();
                    compraDetalle.strNomProducto = this.cboNombreProducto.Text;
                    this.lstCompraDetalle.Add(compraDetalle);
                    this.dgvDetalleCompras.AutoGenerateColumns = false;
                    this.dgvDetalleCompras.DataSource = null;
                    this.dgvDetalleCompras.DataSource = lstCompraDetalle;

                    this.txtTotal.Text = Convert.ToString(Convert.ToDecimal(this.txtTotal.Text) + (Convert.ToDecimal(compraDetalle.fltValorCompra) * Convert.ToDecimal(compraDetalle.intCantidad)));
                }
                else
                    MessageBox.Show("Ya aparece este producto registrado en la grid. ", "Agregar ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Debe de seleccionar un producto valido. ", "Agregar ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.txtValorActual.Text = "0";
            this.txtValorCompra.Text = "0";
            this.txtValorVenta.Text = "0";
            this.txtCantidad.Text = "0";
            this.txtDisponibilidad.Text = "0";
            this.txtProducto.Text = "";
            this.cboNombreProducto.SelectedIndex = 0;
            this.txtProducto.Focus();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.lstCompraDetalle.Count > 0)
            {
                if (this.dgvDetalleCompras.CurrentRow.Index >= 0)
                {
                    this.lstCompraDetalle.RemoveAt(this.dgvDetalleCompras.CurrentRow.Index);
                    this.dgvDetalleCompras.DataSource = null;
                    this.dgvDetalleCompras.DataSource = lstCompraDetalle;

                    decimal decSuma = 0;

                    for (int a = 0; a < this.lstCompraDetalle.Count; a++)
                    { 
                        decSuma += Convert.ToDecimal(lstCompraDetalle[a].fltTotal);
                    }

                    this.txtTotal.Text = decSuma.ToString();
                }
            }
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            this.gmtdPermisosBotones();
            //this.pmtdCargarGrid();
            this.cboNombreProducto.DataSource = new blProducto().gmtdConsultarTodos();
            this.cboProveedores.DataSource = new blCliente().gmtdConsultarTipoCliente("Proveedor");

            if (this.cboNombreProducto.Items.Count <= 0)
            {
                MessageBox.Show("Debe de ingresar productos para utilizar esta pantalla. ", "Socios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.pmtdHabilitarText(false);
                this.btnCancelar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnGuardar.Enabled = false;
                this.btnModificar.Enabled = false;
                this.btnSalir.Enabled = false;
            }

            if (this.cboProveedores.Items.Count <= 0)
            {
                MessageBox.Show("Debe de ingresar proveedores para utilizar esta pantalla. ", "Socios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.pmtdHabilitarText(false);
                this.btnCancelar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnGuardar.Enabled = false;
                this.btnModificar.Enabled = false;
                this.btnSalir.Enabled = false;
            }

            this.dgvDetalleCompras.AutoGenerateColumns = false;
            this.dgvDetalleCompras.DataSource = null;
            this.dgvDetalleCompras.DataSource = lstCompraDetalle;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.pmtdMensaje(new blCompras().gmtdInsertar(crearObj()), "Compras");
            this.pmtdCargarGrid();
            this.pmtdLimpiarText();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta opcion no esta habilitada en esta pantalla. ");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.txtCodigo.Text.Trim() == "" || this.txtCodigo.Text.Trim() == "0")
            {
                MessageBox.Show("Debe de ingresar un código de compra a eliminar. ", "Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tblCompra compra = new blCompras().gmtdConsultar(Convert.ToInt16(this.txtCodigo.Text));
            if (compra.strCodProvedor != null)
            {
                this.cboProveedores.SelectedValue = compra.strCodProvedor;
                this.txtTotal.Text = compra.fltTotalCom.ToString();
                this.dgvDetalleCompras.AutoGenerateColumns = false;
                this.dgvDetalleCompras.DataSource = new blCompras().gmtdConsultarDetalle(Convert.ToInt16(this.txtCodigo.Text));

            }
            else
            {
                MessageBox.Show("La compra no aparece registrada. ", "Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dlgResult = MessageBox.Show("Confirma que desea eliminar este registro? ", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlgResult == DialogResult.Yes)
                this.pmtdMensaje(new blCompras().gmtdEliminar(crearObj()), "Compras");
            this.pmtdCargarGrid();
            this.pmtdLimpiarText();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.pmtdLimpiarText();
            this.pmtdCargarGrid();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            propiedadesExequial2010.strFormActivo = "Principal";
            this.Dispose();
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            propiedadesExequial2010.strFormActivo = "Principal";
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.cboProveedores.Focus();
            }
        }

        private void cboProveedores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtProducto.Focus();
            }
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.cboNombreProducto.Focus();
            }
        }

        private void cboNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtCantidad.Focus();
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtValorCompra.Focus();
            }
        }

        private void txtValorCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtValorVenta.Focus();
            }
        }

        private void txtValorVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnAgregar.Focus();
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (this.txtCantidad.Text.Trim() == "")
                this.txtCantidad.Text = "0";
        }

        private void txtValorVenta_Leave(object sender, EventArgs e)
        {
            if (this.txtValorVenta.Text.Trim() == "")
                this.txtValorVenta.Text = "0";
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (this.txtCodigo.Text.Trim() == "")
                this.txtCodigo.Text = "0";
        }

    }
}
