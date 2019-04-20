using libMutuales2020.dominio;
using libMutuales2020.logica;
using Mutuales2020;
using System;
using System.Windows.Forms;

namespace Mutuales2020.Maestros
{
    public partial class frmBarrios : Form
    {
        public frmBarrios()
        {
            InitializeComponent();
        }

        #region metodos
        private static frmBarrios form = null;
        public static frmBarrios DefInstance
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new frmBarrios();
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

        /// <summary> Habilita o deshabilita los botones de acuerdo a las opciones en la base de  datos </summary>
        private void gmtdPermisosBotones()
        {
            Program.gmtdAsignarPermisos(ref btnGuardar, ref btnModificar, ref btnEliminar);
        }

        /// <summary> Carga la grid con datos si tiene permisos necesarios. </summary>
        private void pmtdCargarGrid()
        {
            if (propiedades.bitConsultar == true)
            {
                blBarrio blBar = new blBarrio();
                if(this.cboMunicipios.Text.Trim() != "")
                    this.dgv.DataSource = blBar.gmtdConsultarTodos(this.cboMunicipios.SelectedValue.ToString());
                else
                    this.dgv.DataSource = blBar.gmtdConsultarTodos();
            }
        }

        /// <summary> Limpia los texbox del formulario. </summary>
        private void pmtdLimpiarText()
        {
            this.txtCodigo.Text = "";
            this.txtDescripcion.Text = "";
        }

        /// <summary> Habilita o deshabilita los controles de la aplicación. </summary>
        private void pmtdHabilitarText(bool a)
        {
            this.txtCodigo.Enabled = a;
            this.txtDescripcion.Enabled = a;
        }

        /// <summary> Crea un objeto del tipo aplicación de acuerdo a la información de los texbox. </summary>
        /// <returns> Un objeto del tipo aplicación. </returns>
        private tblBarrio crearObj()
        {
            tblBarrio br = new tblBarrio();
            br.strCodBarrio = this.txtCodigo.Text;
            br.strCodMunicipio = this.cboMunicipios.SelectedValue.ToString();
            br.strNomBarrio = this.txtDescripcion.Text;
            br.strFormulario = this.Name;
            return br;
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

        private void Frm_Load(object sender, EventArgs e)
        {
            this.cboMunicipios.DataSource = new blMunicipio().gmtdConsultarTodos();

            if (this.cboMunicipios.Items.Count <= 0)
            {
                MessageBox.Show("Debe de ingresar municipios para utilizar esta pantalla. ", "Socios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.pmtdHabilitarText(false);
                this.btnCancelar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnGuardar.Enabled = false;
                this.btnModificar.Enabled = false;
                this.btnSalir.Enabled = false;
            }

            this.gmtdPermisosBotones();
            this.pmtdCargarGrid();
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Text = this.dgv.CurrentRow.Cells[0].Value.ToString();
            this.txtDescripcion.Text = this.dgv.CurrentRow.Cells[1].Value.ToString();
            this.cboMunicipios.Text = this.dgv.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            blBarrio blBar = new blBarrio();
            this.pmtdMensaje(blBar.gmtdInsertar(crearObj()), "Barrios");
            this.pmtdCargarGrid();
            this.pmtdLimpiarText();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            blBarrio blBar = new blBarrio();
            this.pmtdMensaje(blBar.gmtdEditar(crearObj()), "Barrios");
            this.pmtdCargarGrid();
            this.pmtdLimpiarText();
            this.pmtdHabilitarText(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Confirma que desea eliminar este registro? ", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlgResult == DialogResult.Yes)
                this.pmtdMensaje(new blBarrio().gmtdEliminar(crearObj()), "Barrios");
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
                this.cboMunicipios.Focus();
        }

        private void cboAplicaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.btnGuardar.Focus();
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            propiedades.strFormActivo = "Principal";
        }

        private void cboMunicipios_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pmtdCargarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.cboMunicipios.SelectedIndex.ToString());
        }

    }
}
