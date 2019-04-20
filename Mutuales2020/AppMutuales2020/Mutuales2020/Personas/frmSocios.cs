namespace Mutuales2020.Personas
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using System;
    using System.Windows.Forms;

    public partial class FrmSocios : Form
    {
        public FrmSocios()
        {
            InitializeComponent();
        }

        #region metodos
        private static FrmSocios form = null;
        public static FrmSocios DefInstance
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new FrmSocios();
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
                blSocio blSoc = new blSocio();
                this.dgvSocios.AutoGenerateColumns = false;
                this.dgvSocios.DataSource = blSoc.gmtdConsultarTodos();
            }
        }

        /// <summary> Limpia los texbox del formulario. </summary>
        private void pmtdLimpiarText()
        {
            this.txtCodigo.Text = "0";
            this.txtCedula.Text = "0";
            this.cboTipo.SelectedIndex = 0;
            this.txtNombre.Text = "";
            this.txtApellido1.Text = "";
            this.txtApellido2.Text = "";
            this.txtDireccion.Text = "";
            this.txtTelefono.Text = "0";
            this.dtpIngreso.Value = DateTime.Now.Date;
            this.dtpNacimiento.Value = DateTime.Now.Date;
            this.txtContrato.Text = "0";
            this.cboServicios.SelectedIndex = 0;
            this.cboBarrios.SelectedIndex = 0;
            this.cboOficios.SelectedIndex = 0;
            this.cboActivar.SelectedIndex = 0;
            this.cboSexo.SelectedIndex = 0;
            this.cboEscolaridad.SelectedIndex = 0;
            this.txtMail.Text = "";
            this.txtAdulto.Text = "0";
            this.chkAhorrador.Checked = false;
            this.chkNatilleraEscolar.Checked = false;
            this.txtLugardeExpedicion.Text = "";
            this.dtmFechaExpedicion.Value = DateTime.Now;
        }

        /// <summary> Habilita o deshabilita los controles de la aplicación. </summary>
        /// <param name="a"> Indica si se va a habilitar o deshabilitar los controles. </param>
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
            this.txtContrato.Enabled = a;
            this.cboServicios.Enabled = a;
            this.cboBarrios.Enabled = a;
            this.cboOficios.Enabled = a;
            this.cboActivar.Enabled = a;
            this.cboSexo.Enabled = a;
            this.cboEscolaridad.Enabled = a;
            this.txtMail.Enabled = a;
            this.txtAdulto.Enabled = a;
            this.chkAhorrador.Enabled = a;
            this.chkNatilleraEscolar.Enabled = a;
            this.txtLugardeExpedicion.Enabled = a;
            this.dtmFechaExpedicion.Enabled = a;
        }

        /// <summary> Crea un objeto del tipo aplicación de acuerdo a la información de los texbox. </summary>
        /// <returns> Un objeto del tipo aplicación. </returns>
        private tblSocio crearObj()
        {
            tblSocio socio = new tblSocio();
            if (this.cboActivar.SelectedIndex == 0)
            {
                socio.bitActivo = true;
            }
            else
            {
                socio.bitActivo = false;
            }
            if (this.cboSexo.SelectedIndex == 0)
            {
                socio.bitSexo = true;
            }
            else
            {
                socio.bitSexo = false;
            }
            socio.dtmFechaIng = this.dtpIngreso.Value;
            socio.dtmFechaNac = this.dtpNacimiento.Value;
            socio.intAdultosMayores = Convert.ToInt32(this.txtAdulto.Text);
            socio.intAgraciados = 0;
            socio.intAño = this.dtpIngreso.Value.Year;
            socio.intCodigoSoc = Convert.ToInt32(this.txtCodigo.Text);
            socio.intContrato = Convert.ToInt32(this.txtContrato.Text);
            socio.intMeses = this.dtpIngreso.Value.Month - 1;
            socio.strApellido1Soc = this.txtApellido1.Text;
            socio.strApellido2Soc = this.txtApellido2.Text;
            socio.strCedulaSoc = this.txtCedula.Text;
            socio.strCodBarrio = this.cboBarrios.SelectedValue.ToString();
            socio.strCodOficio = this.cboOficios.SelectedValue.ToString();
            socio.strCodServiciop = this.cboServicios.SelectedValue.ToString();
            socio.strCorreo = this.txtMail.Text;
            socio.strDireccion = this.txtDireccion.Text;
            socio.strEscolaridad = this.cboEscolaridad.Text;
            socio.strNombreSoc = this.txtNombre.Text;
            socio.strTelefono = this.txtTelefono.Text;
            socio.strTipoCed = this.cboTipo.Text;
            socio.strFormulario = this.Name;
            socio.bitAhorrador = this.chkAhorrador.Checked;
            socio.bitActualizado = true;
            socio.bitEsAhorradordeNatilleraEscolar = this.chkNatilleraEscolar.Checked;
            socio.strCedulaSubsidio = this.txtCedulaSubsidio.Text.Trim();
            socio.strNombreSubsidio = this.txtNombreSubsidio.Text.Trim();
            socio.strApellidoSubsidio = this.txtApellidoSubsidio.Text.Trim();
            socio.strLugarExpedicion = this.txtLugardeExpedicion.Text.Trim();
            socio.dtmFechaExpedicion = this.dtmFechaExpedicion.Value;
            return socio;
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

        /// <summary> Almacena menú si la pantalla se llamo desde el menú o Ingreso si se llamo desde la pantalla de ingreoso. </summary>
        public static string strLLamada { get; set; }

        /// <summary> Almacena el código seleccionado en la grid para mostrar en la pantalla de ingresos. </summary>
        public static string strCodigoSeleccionado { get; set; }

        private void Frm_Load(object sender, EventArgs e)
        {
            this.gmtdPermisosBotones();
            this.pmtdCargarGrid();

            this.cboServicios.DataSource = new blPrimarios().gmtdConsultarTodos();
            this.cboOficios.DataSource = new blOficio().gmtdConsultarTodos();
            this.cboBarrios.DataSource = new blBarrio().gmtdConsultarBarriosconMunicipios();

            if (this.cboServicios.Items.Count <= 0)
            {
                MessageBox.Show("Debe de ingresar servicios primarios para utilizar esta pantalla. ", "Socios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.pmtdHabilitarText(false);
                this.btnCancelar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnFiltrar.Enabled = false;
                this.btnGuardar.Enabled = false;
                this.btnModificar.Enabled = false;
                this.btnSalir.Enabled = false;
            }

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
            this.cboTipo.SelectedIndex = 0;
            this.cboSexo.SelectedIndex = 0;
            this.cboActivar.SelectedIndex = 0;

        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            tblSocio socio = new tblSocio(); 
            DataGridViewSelectedRowCollection rows = ((DataGridView)sender).SelectedRows;
            foreach (DataGridViewRow dato in rows)
            {
                socio = new blSocio().gmtdConsultarDetalle(Convert.ToInt32(dato.Cells[0].Value));
                FrmSocios.strCodigoSeleccionado = dato.Cells[0].Value.ToString();
            }

            if (FrmSocios.strLLamada == "Menu")
            {
                if (socio.strNombreSoc != null)
                {
                    this.txtCodigo.Enabled = false;
                    this.txtCedula.Enabled = false;

                    if (socio.bitActivo == true)
                    {
                        this.cboActivar.SelectedIndex = 0;
                    }
                    else
                    {
                        this.cboActivar.SelectedIndex = 1;
                    }

                    if (socio.bitSexo == true)
                    {
                        this.cboSexo.SelectedIndex = 0;
                    }
                    else
                    {
                        this.cboSexo.SelectedIndex = 1;
                    }

                    this.dtpIngreso.Value = socio.dtmFechaIng;
                    this.dtpNacimiento.Value = socio.dtmFechaNac;
                    this.txtAdulto.Text = socio.intAdultosMayores.ToString();
                    this.txtCodigo.Text = socio.intCodigoSoc.ToString();
                    this.txtContrato.Text = socio.intContrato.ToString();
                    this.txtApellido1.Text = socio.strApellido1Soc;
                    this.txtApellido2.Text = socio.strApellido2Soc;
                    this.txtCedula.Text = socio.strCedulaSoc;
                    this.cboBarrios.SelectedValue = socio.strCodBarrio;
                    this.cboOficios.SelectedValue = socio.strCodOficio;
                    this.cboServicios.SelectedValue = socio.strCodServiciop;
                    this.txtMail.Text = socio.strCorreo;
                    this.txtDireccion.Text = socio.strDireccion;
                    this.cboEscolaridad.Text = socio.strEscolaridad;
                    this.txtNombre.Text = socio.strNombreSoc;
                    this.txtTelefono.Text = socio.strTelefono;
                    this.cboTipo.Text = socio.strTipoCed;
                    this.chkAhorrador.Checked = (bool)socio.bitAhorrador;
                    this.txtApellidoSubsidio.Text = socio.strApellidoSubsidio;
                    this.txtCedulaSubsidio.Text = socio.strCedulaSubsidio;
                    this.txtNombreSubsidio.Text = socio.strNombreSubsidio;
                    this.chkNatilleraEscolar.Checked = (bool)socio.bitEsAhorradordeNatilleraEscolar;
                    this.dtmFechaExpedicion.Value = Convert.ToDateTime(socio.dtmFechaExpedicion);
                    this.txtLugardeExpedicion.Text = socio.strLugarExpedicion;
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string strRespuesta = new blSocio().gmtdInsertar(crearObj());
            this.pmtdMensaje(strRespuesta, "Socios");
            this.pmtdCargarGrid();
            if (strRespuesta.Substring(0, 1) != "-")
            {
                this.pmtdLimpiarText();
                this.pmtdHabilitarText(true);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string strRespuesta = new blSocio().gmtdEditar(crearObj());
            this.pmtdMensaje(strRespuesta, "Socios");
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
                this.pmtdMensaje(new blSocio().gmtdEliminar(crearObj()), "Socios");
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
                this.txtContrato.Focus();
            }
        }

        private void txtContrato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.cboServicios.Focus();
            }
        }

        private void cboServicios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.cboActivar.Focus();
            }
        }

        private void cboActivar_KeyPress(object sender, KeyPressEventArgs e)
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
                this.cboSexo.Focus();
            }
        }

        private void cboSexo_KeyPress(object sender, KeyPressEventArgs e)
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
                this.txtAdulto.Focus();
            }
        }

        private void txtAdulto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.chkAhorrador.Focus();
            }
        }

        private void chkAhorrador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.chkNatilleraEscolar.Focus();
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (this.txtCodigo.Text.Trim() == "")
            {
                this.txtCodigo.Text = "0";
            }

            blSocio blSoc = new blSocio();
            this.dgvSocios.AutoGenerateColumns = false;
            this.dgvSocios.DataSource = blSoc.gmtdFiltrar(crearObj());
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (this.txtCodigo.Text.Trim() == "")
            {
                this.txtCodigo.Text = "0";
            }
            else
            {
                if (new blSocio().gmtdConsultar(Convert.ToInt32(this.txtCodigo.Text)).strNombreSoc != null)
                {
                    MessageBox.Show("Este código ya aparece registrado. ", "Socio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtCodigo.Text = "0";
                }
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

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (this.txtTelefono.Text.Trim() == "")
            {
                this.txtTelefono.Text = "0";
            }
        }

        private void txtContrato_Leave(object sender, EventArgs e)
        {
            if (this.txtContrato.Text.Trim() == "")
            {
                this.txtContrato.Text = "0";
            }
        }

        private void txtAdulto_Leave(object sender, EventArgs e)
        {
            if (this.txtAdulto.Text.Trim() == "")
            {
                this.txtAdulto.Text = "0";
            }
        }

        private void txtCedulaSubsidio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtNombreSubsidio.Focus();
            }
        }

        private void txtNombreSubsidio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtApellidoSubsidio.Focus();
            }
        }

        private void txtApellidoSubsidio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnGuardar.Focus();
            }
        }

        private void chkNatilleraEscolar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.dtmFechaExpedicion.Focus();
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
                this.txtCedulaSubsidio.Focus();
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
