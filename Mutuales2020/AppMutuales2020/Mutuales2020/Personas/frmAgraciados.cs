namespace Mutuales2020.Personas
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using System;
    using System.Windows.Forms;

    public partial class FrmAgraciados : Form
    {
        public FrmAgraciados()
        {
            InitializeComponent();
        }

        #region metodos
        private static FrmAgraciados form = null;
        public static FrmAgraciados DefInstance
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new FrmAgraciados();
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
                blAgraciado blAgra = new blAgraciado();
                this.dgvAgraciados.AutoGenerateColumns = false;
                this.dgvAgraciados.DataSource = blAgra.gmtdConsultarTodos();
            }
        }

        /// <summary>
        /// Limpia los texbox del formulario.
        /// </summary>
        private void pmtdLimpiarText()
        {
            this.txtCodigo.Text = "0";
            this.txtCedula.Text = "0";
            this.cboTipo.SelectedIndex = 0;
            this.txtNombre.Text = "";
            this.txtApellido1.Text = "";
            this.txtApellido2.Text = "";
            this.txtDireccion.Text = "";
            this.txtTelefono.Text = "";
            this.dtpIngreso.Value = DateTime.Now.Date;
            this.dtpNacimiento.Value = DateTime.Now.Date;
            this.cboBarrios.SelectedIndex = 0;
            this.cboOficios.SelectedIndex = 0;
            this.cboSexo.SelectedIndex = 0;
            this.cboEscolaridad.SelectedIndex = 0;
            this.cboParentesco.SelectedIndex = 0;
            this.txtMail.Text = "";
            this.txtLugardeExpedicion.Text = "";
            this.dtmFechaExpedicion.Value = DateTime.Now;
        }

        /// <summary>
        /// Habilita o deshabilita los controles de la aplicación.
        /// </summary>
        /// <param name="a"></param>
        private void pmtdHabilitarText(bool a)
        {
            this.txtCodigo.Enabled = a;
            this.txtCedula.Enabled = a;
            this.cboTipo.Enabled = a;
            this.txtNombre.Enabled = a;
            this.txtApellido1.Enabled = a;
            this.txtApellido2.Enabled = a;
            this.txtDireccion.Enabled = a;
            this.txtTelefono.Enabled = a;
            this.dtpIngreso.Enabled = a;
            this.dtpNacimiento.Enabled = a;
            this.cboBarrios.Enabled = a;
            this.cboOficios.Enabled = a;
            this.cboSexo.Enabled = a;
            this.cboEscolaridad.Enabled = a;
            this.cboParentesco.Enabled = a;
            this.txtMail.Enabled = a;
        }

        /// <summary>
        /// Crea un objeto del tipo aplicación de acuerdo a la información de los texbox.
        /// </summary>
        /// <returns> Un objeto del tipo aplicación. </returns>
        private tblAgraciado crearObj()
        {
            tblAgraciado agraciado = new tblAgraciado();
            if (this.cboSexo.SelectedIndex == 0)
                agraciado.bitSexo = true;
            else
                agraciado.bitSexo = false;
            agraciado.dtmFechaIng = this.dtpIngreso.Value;
            agraciado.dtmFechaNac = this.dtpNacimiento.Value;
            agraciado.intCodigoSoc = Convert.ToInt32(this.txtCodigo.Text);
            agraciado.strApellido1Agra = this.txtApellido1.Text;
            agraciado.strApellido2Agra = this.txtApellido2.Text;
            agraciado.strCedulaAgra = this.txtCedula.Text;
            agraciado.strCodBarrio = this.cboBarrios.SelectedValue.ToString();
            agraciado.strCodOficio = this.cboOficios.SelectedValue.ToString();
            agraciado.strCorreo = this.txtMail.Text;
            agraciado.strDireccion = this.txtDireccion.Text;
            agraciado.strEscolaridad = this.cboEscolaridad.Text;
            agraciado.strNombreAgra = this.txtNombre.Text;
            agraciado.strTelefono = this.txtTelefono.Text;
            agraciado.strTipoCed = this.cboTipo.Text;
            agraciado.strFormulario = this.Name;
            agraciado.strParentesco = this.cboParentesco.Text;
            agraciado.bitActualizado = true;
            agraciado.dtmFechaExpedicion = this.dtmFechaExpedicion.Value;
            agraciado.strLugarExpedicion = this.txtLugardeExpedicion.Text;
            return agraciado;
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

        private void Frm_Load(object sender, EventArgs e)
        {
            this.gmtdPermisosBotones();
            this.pmtdCargarGrid();

            this.cboOficios.DataSource = new blOficio().gmtdConsultarTodos();
            this.cboBarrios.DataSource = new blBarrio().gmtdConsultarBarriosconMunicipios();

            if (this.cboOficios.Items.Count <= 0)
            {
                MessageBox.Show("Debe de ingresar oficios para utilizar esta pantalla. ", "Socios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.pmtdHabilitarText(false);
                this.btnCancelar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnFiltrar.Enabled = false;
                this.btnGuardar.Enabled = false;
                this.btnModificar.Enabled = false;
                this.btnSalir.Enabled = false;
            }

            if (this.cboBarrios.Items.Count <= 0)
            {
                MessageBox.Show("Debe de ingresar barrios para utilizar esta pantalla. ", "Socios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.pmtdHabilitarText(false);
                this.btnCancelar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnFiltrar.Enabled = false;
                this.btnGuardar.Enabled = false;
                this.btnModificar.Enabled = false;
                this.btnSalir.Enabled = false;
            }


            this.cboEscolaridad.SelectedIndex = 0;
            this.cboParentesco.SelectedIndex = 0;
            this.cboTipo.SelectedIndex = 0;
            this.cboSexo.SelectedIndex = 0;

        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            tblAgraciado agraciado = new tblAgraciado();
            DataGridViewSelectedRowCollection rows = ((DataGridView)sender).SelectedRows;
            foreach (DataGridViewRow dato in rows)
            {
                agraciado = new blAgraciado().gmtdConsultarDetalle(dato.Cells[1].Value.ToString());
            }

            if (agraciado.strNombreAgra != null)
            {
                this.txtCedula.Enabled = false;
                if (agraciado.bitSexo == true)
                    this.cboSexo.SelectedIndex = 0;
                else
                    this.cboSexo.SelectedIndex = 1;

                this.dtpIngreso.Value = agraciado.dtmFechaIng;
                this.dtpNacimiento.Value = agraciado.dtmFechaNac;
                this.txtCodigo.Text = agraciado.intCodigoSoc.ToString();
                this.txtApellido1.Text = agraciado.strApellido1Agra;
                this.txtApellido2.Text = agraciado.strApellido2Agra;
                this.txtCedula.Text = agraciado.strCedulaAgra;
                this.cboBarrios.SelectedValue = agraciado.strCodBarrio;
                this.cboOficios.SelectedValue = agraciado.strCodOficio;
                this.txtMail.Text = agraciado.strCorreo;
                this.txtDireccion.Text = agraciado.strDireccion;
                this.cboEscolaridad.Text = agraciado.strEscolaridad;
                this.txtNombre.Text = agraciado.strNombreAgra;
                this.txtTelefono.Text = agraciado.strTelefono;
                this.cboTipo.Text = agraciado.strTipoCed;
                this.cboParentesco.Text = agraciado.strParentesco;
                this.txtCedula.Enabled = false;
                this.txtCodigo.Enabled = false;
                this.txtLugardeExpedicion.Text = agraciado.strLugarExpedicion;
                this.dtmFechaExpedicion.Value = Convert.ToDateTime(agraciado.dtmFechaExpedicion);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string strRespuesta = new blAgraciado().gmtdInsertar(crearObj());
            this.pmtdMensaje(strRespuesta, "Agraciados");
            this.pmtdCargarGrid();
            if (strRespuesta.Substring(0, 1) != "-")
            {
                this.pmtdLimpiarText();
                this.pmtdHabilitarText(true);
                this.pmtdCargarGrid();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string strRespuesta = new blAgraciado().gmtdEditar(crearObj());
            this.pmtdMensaje(strRespuesta, "Agraciados");
            this.pmtdCargarGrid();
            if (strRespuesta.Substring(0, 1) != "-")
            {
                this.pmtdLimpiarText();
                this.pmtdHabilitarText(true);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Confirma que desea eliminar este registro? ", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlgResult == DialogResult.Yes)
            {
                this.pmtdMensaje(new blAgraciado().gmtdEliminar(crearObj()), "Agraciados");
            }
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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            blAgraciado blAgra = new blAgraciado();
            this.dgvAgraciados.AutoGenerateColumns = false;
            this.dgvAgraciados.DataSource = blAgra.gmtdFiltrar(crearObj());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            propiedades.strFormActivo = "Principal";
            this.Dispose();
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            propiedades.strFormActivo = "Principal";
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtCedula.Focus();
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtNombre.Focus();
            }
        }

        private void cboTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtNombre.Focus();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtApellido1.Focus();
            }
        }

        private void txtApellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtApellido2.Focus();
            }
        }

        private void txtApellido2_KeyPress(object sender, KeyPressEventArgs e)
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
                this.txtTelefono.Focus();
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.dtpIngreso.Focus();
            }
        }

        private void dtpIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.dtpNacimiento.Focus();
            }
        }

        private void dtpNacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.cboSexo.Focus();
            }
        }

        private void cboSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.cboBarrios.Focus();
            }
        }

        private void cboBarrios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.cboOficios.Focus();
            }
        }

        private void cboOficios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.cboEscolaridad.Focus();
            }
        }

        private void cboEscolaridad_KeyPress(object sender, KeyPressEventArgs e)
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
                this.cboParentesco.Focus();
            }
        }

        private void cboParentesco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.dtmFechaExpedicion.Focus();
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (this.txtCodigo.Text.Trim() == "")
            {
                this.txtCodigo.Text = "0";
            }

            if (new blSocio().gmtdConsultar(Convert.ToInt32(this.txtCodigo.Text)).strCedulaSoc == null)
            {
                MessageBox.Show("Este código de socio no aparece registrado. ", "Agraciados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtCodigo.Text = "0";
            }
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if (this.txtCedula.Text.Trim() == "")
            {
                this.txtCedula.Text = "0";
            }
            else
            {
                if (new blSocio().gmtdConsultarCeduladeSocioAgraciadoFallecido(this.txtCedula.Text))
                {
                    MessageBox.Show("Este número de cédula ya aparece registrado como socio, agraciado ó fallecido. ", "Socio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtCedula.Text = "0";
                }
            }
        }

        private void dtmFechaExpedicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtLugardeExpedicion.Focus();
            }
        }

        private void txtLugardeExpedicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnGuardar.Focus();
            }
        }

    }
}
