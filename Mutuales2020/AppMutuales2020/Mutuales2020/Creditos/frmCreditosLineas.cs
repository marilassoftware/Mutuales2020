namespace Mutuales2020.Creditos
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using System;
    using System.Windows.Forms;
    public partial class frmCreditosLineas : Form
    {
        public frmCreditosLineas()
        {
            InitializeComponent();
        }

        #region metodos
        private static frmCreditosLineas form = null;
        public static frmCreditosLineas DefInstance
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new frmCreditosLineas();
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

        /// <summary> Habilita o deshabilita los botones de acuerdo a las opciones en la base de datos </summary>
        private void gmtdPermisosBotones()
        {
            Program.gmtdAsignarPermisos(ref btnGuardar, ref btnModificar, ref btnEliminar);
        }

        /// <summary> Carga la grid con datos si tiene permisos necesarios. </summary>
        private void pmtdCargarGrid()
        {
            if (propiedades.bitConsultar == true)
            {
                blCreditosLinea blTcr = new blCreditosLinea();
                this.dgvDatos.DataSource = blTcr.gmtdConsultarTodos();
            }
        }

        /// <summary> Limpia los texbox del formulario. </summary>
        private void pmtdLimpiarText()
        {
            this.txtCodigo.Text = "";
            this.txtDescripcion.Text = "";
            this.cboTiposdeCredito.SelectedIndex = 0;
        }

        /// <summary> Habilita o deshabilita los controles de la aplicación. </summary>
        private void pmtdHabilitarText(bool a)
        {
            this.txtCodigo.Enabled = a;
            this.txtDescripcion.Enabled = a;
            this.cboTiposdeCredito.Enabled = a;
        }

        /// <summary> Crea un objeto del tipo aplicación de acuerdo a la información de los texbox. </summary>
        /// <returns> Un objeto del tipo aplicación. </returns>
        private tblCreditosLinea crearObj()
        {
            tblCreditosLinea Tcr = new tblCreditosLinea();
            Tcr.strCodigoTcr = this.cboTiposdeCredito.SelectedValue.ToString();
            Tcr.strNomLineadeCredito = this.txtDescripcion.Text;
            Tcr.strCodLineadeCredito = this.txtCodigo.Text;
            Tcr.strFormulario = this.Name;
            Tcr.strParCapital = this.cboParCapital.SelectedValue.ToString();
            Tcr.strParInteres = this.cboParIntereses.SelectedValue.ToString();
            Tcr.strParMora = this.cboParMora.SelectedValue.ToString();
            return Tcr;
        }

        /// <summary> De acuerdo al string devuelto por un metodo elabora un mensaje. </summary>
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

        private void frmLineasdeCredito_Load(object sender, EventArgs e)
        {
            this.gmtdPermisosBotones();
            this.pmtdCargarGrid();
            this.cboTiposdeCredito.DataSource = new blCreditosTipo().gmtdConsultarTodos();

            this.cboParCapital.DataSource = new blCuentaPar().gmtdConsultarTodos();
            this.cboParIntereses.DataSource = new blCuentaPar().gmtdConsultarTodos();
            this.cboParMora.DataSource = new blCuentaPar().gmtdConsultarTodos();

            if (this.cboTiposdeCredito.Items.Count <= 0)
            {
                MessageBox.Show("Debe de ingresar tipos de credito para utilizar esta pantalla. ", "Socios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.pmtdHabilitarText(false);
                this.btnCancelar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnGuardar.Enabled = false;
                this.btnModificar.Enabled = false;
                this.btnSalir.Enabled = false;
            }

        }

        private void dgvDatos_DoubleClick(object sender, EventArgs e)
        {
            tblCreditosLinea lineas = new blCreditosLinea().gmtdConsultar(this.dgvDatos.CurrentRow.Cells[0].Value.ToString()); 

            this.txtCodigo.Enabled = false;
            this.txtCodigo.Text = lineas.strCodLineadeCredito;
            this.txtDescripcion.Text = lineas.strNomLineadeCredito;
            this.cboTiposdeCredito.SelectedValue = lineas.strCodigoTcr;
            this.cboParCapital.SelectedValue = lineas.strParCapital;
            this.cboParIntereses.SelectedValue = lineas.strParInteres;
            this.cboParMora.SelectedValue = lineas.strParMora;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.pmtdMensaje(new blCreditosLinea().gmtdInsertar(crearObj()), "Lineas de Credito");
            this.pmtdCargarGrid();
            this.pmtdLimpiarText();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.pmtdMensaje(new blCreditosLinea().gmtdEditar(crearObj()), "Lineas de Credito");
            this.pmtdCargarGrid();
            this.pmtdLimpiarText();
            this.pmtdHabilitarText(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Confirma que desea eliminar este registro? ", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlgResult == DialogResult.Yes)
                this.pmtdMensaje(new blCreditosLinea().gmtdEliminar(crearObj()), "Lineas de Credito");
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

        private void frmLineasdeCredito_FormClosed(object sender, FormClosedEventArgs e)
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
                this.cboTiposdeCredito.Focus();
        }

        private void cboTiposdeCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.btnGuardar.Focus();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

    }
}
