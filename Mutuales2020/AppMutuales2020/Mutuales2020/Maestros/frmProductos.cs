using libMutuales2020.dominio;
using libMutuales2020.logica;
using Mutuales2020;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace Mutuales2020.Maestros
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        #region metodos
        private static frmProductos form = null;
        public static frmProductos DefInstance
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new frmProductos();
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
            if (propiedades.bitConsultar == true)
            {
                blProducto blPro = new blProducto();
                this.dgv.DataSource = blPro.gmtdConsultarTodos();
            }
        }

        /// <summary>
        /// Limpia los texbox del formulario.
        /// </summary>
        private void pmtdLimpiarText()
        {
            this.txtCodigo.Text = "";
            this.txtDescripcion.Text = "";
            this.txtCantidad.Text = "0";
            this.txtCompra.Text = "0";
            this.txtIva.Text = "0";
            this.txtMargen.Text = "0";
            this.txtMaximo.Text = "0";
            this.txtMinimo.Text = "0";
            this.txtVenta.Text = "0";
        }

        /// <summary>
        /// Habilita o deshabilita los controles de la aplicación.
        /// </summary>
        /// <param name="a"></param>
        private void pmtdHabilitarText(bool a)
        {
            this.txtCodigo.Enabled = a;
            this.txtDescripcion.Enabled = a;
            this.txtCompra.Enabled = a;
            this.txtIva.Enabled = a;
            this.txtMargen.Enabled = a;
            this.txtMaximo.Enabled = a;
            this.txtMinimo.Enabled = a;
            this.txtVenta.Enabled = a;
        }

        /// <summary>
        /// Crea un objeto del tipo aplicación de acuerdo a la información de los texbox.
        /// </summary>
        /// <returns> Un objeto del tipo aplicación. </returns>
        private tblProducto crearObj()
        {
            tblProducto product = new tblProducto();
            product.fltIva = Convert.ToDouble(this.txtIva.Text);
            product.fltMargendeGanancia = Convert.ToDouble(this.txtMargen.Text);
            product.intCantidad = Convert.ToInt32(this.txtCantidad.Text);
            product.intMaxProducto = Convert.ToInt32(this.txtMaximo.Text);
            product.intMinProducto = Convert.ToInt32(this.txtMinimo.Text);
            product.intValCompra = Convert.ToInt32(this.txtCompra.Text);
            product.intValUnitario = Convert.ToInt32(this.txtVenta.Text);
            product.strCodProducto = this.txtCodigo.Text;
            product.strDesProducto = this.txtDescripcion.Text;
            product.strFormulario = this.Name;
            return product;
        }

        /// <summary>
        /// De acuerdo al string devuelto por un metodo elabora un mensaje.
        /// </summary>
        /// <param name="tstrMensaje"> string que devuelve el objeto. </param>
        /// <param name="tstrFormulario"> formulario desde el que se esta mandando
        /// a contruir el mensaje</param>
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

        private void Frm_Load(object sender, EventArgs e)
        {
            this.gmtdPermisosBotones();
            this.pmtdCargarGrid();
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Text = this.dgv.CurrentRow.Cells[0].Value.ToString();
            this.txtDescripcion.Text = this.dgv.CurrentRow.Cells[1].Value.ToString();
            this.txtMinimo.Text = this.dgv.CurrentRow.Cells[2].Value.ToString();
            this.txtMaximo.Text = this.dgv.CurrentRow.Cells[3].Value.ToString();
            this.txtCompra.Text = this.dgv.CurrentRow.Cells[4].Value.ToString();
            this.txtVenta.Text = this.dgv.CurrentRow.Cells[5].Value.ToString();
            this.txtCantidad.Text = this.dgv.CurrentRow.Cells[6].Value.ToString();
            this.txtMargen.Text = this.dgv.CurrentRow.Cells[7].Value.ToString();
            this.txtIva.Text = this.dgv.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.pmtdMensaje(new blProducto().gmtdInsertar(crearObj()), "Productos");
            this.pmtdCargarGrid();
            this.pmtdLimpiarText();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.pmtdMensaje(new blProducto().gmtdEditar(crearObj()), "Productos");
            this.pmtdCargarGrid();
            this.pmtdLimpiarText();
            this.pmtdHabilitarText(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Confirma que desea eliminar este registro? ", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlgResult == DialogResult.Yes)
                this.pmtdMensaje(new blProducto().gmtdEliminar(crearObj()), "Productos");
            this.pmtdCargarGrid();
            this.pmtdLimpiarText();
            this.pmtdHabilitarText(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.pmtdLimpiarText();
            this.pmtdCargarGrid();
            this.pmtdHabilitarText(true);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            propiedades.strFormActivo = "Principal";
            this.Dispose();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtDescripcion.Focus();
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtMinimo.Focus();
        }

        private void txtMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtMaximo.Focus();
        }

        private void txtMaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtCompra.Focus();
        }

        private void txtCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtMargen.Focus();
        }

        private void txtVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtIva.Focus();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtMargen.Focus();
        }

        private void txtMargen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtVenta.Focus();
        }

        private void txtIva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.btnGuardar.Focus();
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            propiedades.strFormActivo = "Principal";
        }

        private void txtMinimo_Leave(object sender, EventArgs e)
        {
            if (this.txtMinimo.Text.Trim() == "")
                this.txtMinimo.Text = "0";
        }

        private void txtMaximo_Leave(object sender, EventArgs e)
        {
            if (this.txtMaximo.Text.Trim() == "")
                this.txtMaximo.Text = "0";
        }

        private void txtCompra_Leave(object sender, EventArgs e)
        {
            if (this.txtCompra.Text.Trim() == "")
                this.txtCompra.Text = "0";
        }

        private void txtVenta_Leave(object sender, EventArgs e)
        {
            if (this.txtVenta.Text.Trim() == "")
                this.txtVenta.Text = "0";
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (this.txtCantidad.Text.Trim() == "")
                this.txtCantidad.Text = "0";
        }

        private void txtMargen_Leave(object sender, EventArgs e)
        {
            if (this.txtMargen.Text.Trim() == "")
                this.txtMargen.Text = "0";

            this.txtVenta.Text = (Convert.ToDecimal(this.txtCompra.Text) + (Convert.ToDecimal(this.txtCompra.Text) * (Convert.ToDecimal(this.txtMargen.Text) / 100))).ToString("##00");
        }

        private void txtIva_Leave(object sender, EventArgs e)
        {
            if (this.txtIva.Text.Trim() == "")
                this.txtIva.Text = "0";
        }

    }
}
