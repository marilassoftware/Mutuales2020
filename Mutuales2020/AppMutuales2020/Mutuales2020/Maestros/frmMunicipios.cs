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
    public partial class frmMunicipios : Form
    {
        public frmMunicipios()
        {
            InitializeComponent();
        }

        #region metodos
        private static frmMunicipios form = null;
        public static frmMunicipios DefInstance
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new frmMunicipios();
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
                blMunicipio blMcp = new blMunicipio();
                this.dgvMunicipios.DataSource = blMcp.gmtdConsultarTodos();
            }
        }

        /// <summary>
        /// Limpia los texbox del formulario.
        /// </summary>
        private void pmtdLimpiarText()
        {
            this.txtCodigo.Text = "";
            this.txtDescripcion.Text = "";
        }

        /// <summary>
        /// Habilita o deshabilita los controles de la aplicación.
        /// </summary>
        /// <param name="a"></param>
        private void pmtdHabilitarText(bool a)
        {
            this.txtCodigo.Enabled = a;
            this.txtDescripcion.Enabled = a;
        }

        /// <summary>
        /// Crea un objeto del tipo aplicación de acuerdo a la información de los texbox.
        /// </summary>
        /// <returns> Un objeto del tipo aplicación. </returns>
        private tblMunicipio crearObj()
        {
            tblMunicipio municipio = new tblMunicipio();
            municipio.strCodMunicipio = this.txtCodigo.Text;
            municipio.strNomMunicipio = this.txtDescripcion.Text;
            municipio.strFormulario = this.Name;  
            return municipio; 
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

        private void frmMunicipios_Load(object sender, EventArgs e)
        {
            this.gmtdPermisosBotones();
            this.pmtdCargarGrid();
        }

        private void dgvMunicipios_DoubleClick(object sender, EventArgs e)
        {
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Text = this.dgvMunicipios.CurrentRow.Cells[0].Value.ToString();
            this.txtDescripcion.Text = this.dgvMunicipios.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            blMunicipio blMcp = new blMunicipio();
            this.pmtdMensaje(blMcp.gmtdInsertar(crearObj()), "Municipios");
            this.pmtdCargarGrid();
            this.pmtdLimpiarText();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            blMunicipio blMcp = new blMunicipio();
            this.pmtdMensaje(blMcp.gmtdEditar(crearObj()), "Municipios");
            this.pmtdCargarGrid();
            this.pmtdLimpiarText();
            this.pmtdHabilitarText(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Confirma que desea eliminar este registro? ", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlgResult == DialogResult.Yes)
                this.pmtdMensaje(new blMunicipio().gmtdEliminar(crearObj()), "Municipios");
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
                this.txtDescripcion.Focus();
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnGuardar.Focus();
            }
        }

        private void frmMunicipios_FormClosed(object sender, FormClosedEventArgs e)
        {
            propiedades.strFormActivo = "Principal";
        }


    }
}
