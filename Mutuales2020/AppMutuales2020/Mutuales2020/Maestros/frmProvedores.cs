
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
    public partial class frmProvedores : Form
    {
        public frmProvedores()
        {
            InitializeComponent();
        }

        #region metodos
        private static frmProvedores form = null;
        public static frmProvedores DefInstance
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new frmProvedores();
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
                blProvedor blPro = new blProvedor();
                this.dgv.DataSource = blPro.gmtdConsultarTodos();
            }
        }

        /// <summary>
        /// Limpia los texbox del formulario.
        /// </summary>
        private void pmtdLimpiarText()
        {
            this.txtCodigo.Text = "";
            this.txtEmpresa.Text = "";
            this.txtContacto.Text = "";
            this.txtDireccion.Text = "";
            this.txtTelefono.Text = "";
            this.txtMail.Text = "";
        }

        /// <summary>
        /// Habilita o deshabilita los controles de la aplicación.
        /// </summary>
        /// <param name="a"></param>
        private void pmtdHabilitarText(bool a)
        {
            this.txtCodigo.Enabled = a;
            this.txtEmpresa.Enabled = a;
            this.txtContacto.Enabled = a;
            this.txtDireccion.Enabled = a;
            this.txtTelefono.Enabled = a;
            this.txtMail.Enabled = a;
        }

        /// <summary>
        /// Crea un objeto del tipo aplicación de acuerdo a la información de los texbox.
        /// </summary>
        /// <returns> Un objeto del tipo aplicación. </returns>
        private tblProvedore crearObj()
        {
            tblProvedore proveedor = new tblProvedore();
            proveedor.strCodProvedor = this.txtCodigo.Text.Trim();
            proveedor.strConProvedor = this.txtContacto.Text;
            proveedor.strDirProvedor = this.txtDireccion.Text;
            proveedor.strTelProvedor = this.txtTelefono.Text;
            proveedor.strMailProvedor = this.txtMail.Text;
            proveedor.strEmpProvedor = this.txtEmpresa.Text;   
            proveedor.strFormulario = this.Name;
            return proveedor;
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
            this.txtEmpresa.Text = this.dgv.CurrentRow.Cells[1].Value.ToString();
            this.txtTelefono.Text = this.dgv.CurrentRow.Cells[2].Value.ToString();
            this.txtDireccion.Text = this.dgv.CurrentRow.Cells[3].Value.ToString();
            this.txtContacto.Text = this.dgv.CurrentRow.Cells[4].Value.ToString();
            this.txtMail.Text = this.dgv.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.pmtdMensaje(new blProvedor().gmtdInsertar(crearObj()), "Productos");
            this.pmtdCargarGrid();
            this.pmtdLimpiarText();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.pmtdMensaje(new blProvedor().gmtdEditar(crearObj()), "Productos");
            this.pmtdCargarGrid();
            this.pmtdLimpiarText();
            this.pmtdHabilitarText(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Confirma que desea eliminar este registro? ", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlgResult == DialogResult.Yes)
                this.pmtdMensaje(new blProvedor().gmtdEliminar(crearObj()), "Productos");
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
            {
                this.txtEmpresa.Focus();
            }
        }

        private void txtEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtContacto.Focus();
            }
        }

        private void txtContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtTelefono.Focus();
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtDireccion.Focus();
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtMail.Focus();
            }
        }

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnGuardar.Focus();
            }
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            propiedades.strFormActivo = "Principal";
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
