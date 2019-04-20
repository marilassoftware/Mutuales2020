namespace Mutuales2020.Ahorros
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using System;
    using System.Windows.Forms;

    public partial class FrmAhorradores : Form
    {
        public FrmAhorradores()
        {
            InitializeComponent();
        }

        #region metodos
        private static FrmAhorradores form = null;
        public static FrmAhorradores DefInstance
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new FrmAhorradores();
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

        /// <summary> Habilita o deshabilita los botones de acuerdo a las opciones en la base de datos. </summary>
        private void gmtdPermisosBotones()
        {
            Program.gmtdAsignarPermisos(ref btnGuardar, ref btnModificar, ref btnEliminar);
        }

        /// <summary> Carga la grid con datos si tiene permisos necesarios. </summary>
        private void pmtdCargarGrid()
        {
            if (propiedades.bitConsultar == true)
            {
                this.dgvAhorradores.DataSource = new blAhorrador().gmtdConsultarTodos();
            }
        }

        /// <summary> Limpia los texbox del formulario. </summary>
        private void pmtdLimpiarText()
        {
            this.txtCodigo.Text = "0";
            this.txtApellido1.Text = "";
            this.txtApellido2.Text = "";
            this.txtApellidoAut.Text = "";
            this.txtApellidoBeneficiario.Text = "";
            this.txtCedula.Text = "0";
            this.txtCedulaBeneficiario.Text = "";
            this.txtCedulaAut.Text = "";
            this.txtDireccion.Text = "";
            this.txtMail.Text = "";
            this.txtNombre.Text = "";
            this.txtNombreAut.Text = "";
            this.txtNombreBeneficiario.Text = "";
            this.txtTelefono.Text = "";
            this.cboBarrios.SelectedIndex = 0;
            this.cboEscolaridad.SelectedIndex = 0;
            this.cboOficios.SelectedIndex = 0;
            this.cboOrigen.SelectedIndex = 0;
            this.cboSexo.SelectedIndex = 0;
            this.cboTipo.SelectedIndex = 0;
            this.dtpIngreso.Value = DateTime.Now;
            this.dtpNacimiento.Value = DateTime.Now;
            this.chkAhorroEstudiantil.Checked = false;
            this.chkExcenta4xMil.Checked = false;
            this.dtmFechaExpedicion.Value = DateTime.Now;
            this.txtLugardeExpedicion.Text = "";
        }

        /// <summary> Habilita o deshabilita los controles de la aplicación. </summary>
        /// <param name="a"> Valor boleano que habilita o deshabilita los controles. </param>
        private void pmtdHabilitarText(bool a)
        {
            this.txtCodigo.Enabled = a;
            this.txtApellido1.Enabled = a;
            this.txtApellido2.Enabled = a;
            this.txtApellidoBeneficiario.Enabled = a;
            this.txtCedula.Enabled = a;
            this.txtCedulaBeneficiario.Enabled = a;
            this.txtDireccion.Enabled = a;
            this.txtMail.Enabled = a;
            this.txtNombre.Enabled = a;
            this.txtNombreBeneficiario.Enabled = a;
            this.txtTelefono.Enabled = a;
            this.cboBarrios.Enabled = a;
            this.cboEscolaridad.Enabled = a;
            this.cboOficios.Enabled = a;
            this.cboOrigen.Enabled = a;
            this.cboSexo.Enabled = a;
            this.cboTipo.Enabled = a;
            this.dtpIngreso.Enabled = a;
            this.dtpNacimiento.Enabled = a;
            this.chkExcenta4xMil.Enabled = a;
            this.chkAhorroEstudiantil.Enabled = a;
            this.dtmFechaExpedicion.Enabled = a;
            this.txtLugardeExpedicion.Enabled = a;
        }

        /// <summary> Crea un objeto del tipo aplicación de acuerdo a la información de los texbox. </summary>
        /// <returns> Un objeto del tipo aplicación. </returns>
        private tblAhorradore crearObj()
        {
            tblAhorradore ahorrador = new tblAhorradore();
            ahorrador.bitAhorroEstudiantil = this.chkAhorroEstudiantil.Checked;
            ahorrador.bitCobraCuatroxMil = this.chkExcenta4xMil.Checked;
            if (this.cboSexo.SelectedIndex == 0)
            {
                ahorrador.bitSexo = true;
            }
            else
            {
                ahorrador.bitSexo = false;
            }
            ahorrador.dtmFechaIng = this.dtpIngreso.Value;
            ahorrador.dtmFechaNac = this.dtpNacimiento.Value;
            ahorrador.intCodigoSoc = Convert.ToInt32(this.txtCodigo.Text);
            ahorrador.strApellido1Aho = this.txtApellido1.Text;
            ahorrador.strApellido2Aho = this.txtApellido2.Text;
            ahorrador.strApellidoBen = this.txtApellidoBeneficiario.Text;
            ahorrador.strCedulaAho = this.txtCedula.Text;
            ahorrador.strCedulaBen = this.txtCedulaBeneficiario.Text;
            ahorrador.strCodBarrio = this.cboBarrios.SelectedValue.ToString();
            ahorrador.strCodOficio = this.cboOficios.SelectedValue.ToString();
            ahorrador.strEscolaridad = this.cboEscolaridad.Text;
            ahorrador.strOrigen = this.cboOrigen.Text;
            ahorrador.strCorreo = this.txtMail.Text;
            ahorrador.strDireccion = this.txtDireccion.Text;
            ahorrador.strFormulario = this.Name;
            ahorrador.strNombreAho = this.txtNombre.Text;
            ahorrador.strNombreBen = this.txtNombreBeneficiario.Text;
            ahorrador.strTelefono = this.txtTelefono.Text;
            ahorrador.strTipoCed = this.cboTipo.Text;
            ahorrador.strCedulaAut = this.txtCedulaAut.Text;
            ahorrador.strNombreAut = this.txtNombreAut.Text;
            ahorrador.strApellidoAut = this.txtApellidoAut.Text;
            ahorrador.strLugarExpedicion = this.txtLugardeExpedicion.Text.Trim();
            ahorrador.dtmFechaExpedicion = this.dtmFechaExpedicion.Value;
            return ahorrador;
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
            this.gmtdPermisosBotones();
            this.pmtdCargarGrid();

            this.cboOficios.DataSource = new blOficio().gmtdConsultarTodos();
            this.cboBarrios.DataSource = new blBarrio().gmtdConsultarBarriosconMunicipios();

            if (this.cboOficios.Items.Count <= 0)
            {
                MessageBox.Show("Debe de ingresar los oficios para utilizar esta pantalla. ", "Ahorradores", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Debe de ingresar los barrios para utilizar esta pantalla. ", "Ahorradores", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.cboOrigen.SelectedIndex = 0;
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            this.pmtdLimpiarText();

            tblAhorradore ahorrador = new tblAhorradore();
            DataGridViewSelectedRowCollection rows = ((DataGridView)sender).SelectedRows;
            foreach (DataGridViewRow dato in rows)
            {
                ahorrador = new blAhorrador().gmtdConsultarDetalle(dato.Cells[1].Value.ToString());
            }

            if (ahorrador.strNombreAho != null)
            {
                this.txtCedula.Enabled = false;
                if (ahorrador.bitSexo == true)
                {
                    this.cboSexo.SelectedIndex = 0;
                }
                else
                {
                    this.cboSexo.SelectedIndex = 1;
                }

                this.txtCodigo.Text = ahorrador.intCodigoSoc.ToString();
                this.txtApellido1.Text = ahorrador.strApellido1Aho;
                this.txtApellido2.Text = ahorrador.strApellido2Aho;
                this.txtApellidoBeneficiario.Text = ahorrador.strApellidoBen;
                this.txtCedula.Text = ahorrador.strCedulaAho;
                this.txtCedulaBeneficiario.Text = ahorrador.strCedulaBen;
                this.txtDireccion.Text = ahorrador.strDireccion;
                this.txtMail.Text = ahorrador.strCorreo;
                this.txtNombre.Text = ahorrador.strNombreAho;
                this.txtNombreBeneficiario.Text = ahorrador.strNombreBen;
                this.txtTelefono.Text = ahorrador.strTelefono;
                this.cboBarrios.SelectedValue = ahorrador.strCodBarrio;
                this.cboEscolaridad.SelectedValue = ahorrador.strEscolaridad;
                this.cboOficios.SelectedValue = ahorrador.strCodOficio;
                this.cboOrigen.SelectedText = ahorrador.strOrigen;
                this.cboTipo.SelectedText = ahorrador.strTipoCed;
                this.dtpIngreso.Value = ahorrador.dtmFechaIng;
                this.dtpNacimiento.Value = ahorrador.dtmFechaNac;
                this.chkAhorroEstudiantil.Checked = ahorrador.bitAhorroEstudiantil;
                this.chkExcenta4xMil.Checked = Convert.ToBoolean(ahorrador.bitCobraCuatroxMil);
                this.txtCedulaAut.Text = ahorrador.strCedulaAut;
                this.txtNombreAut.Text = ahorrador.strNombreAut;
                this.txtApellidoAut.Text = ahorrador.strApellidoAut;
                this.txtLugardeExpedicion.Text = ahorrador.strLugarExpedicion;
                this.dtmFechaExpedicion.Value = Convert.ToDateTime(ahorrador.dtmFechaExpedicion);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.pmtdMensaje(new blAhorrador().gmtdInsertar(crearObj()), "Ahorradores");
            this.pmtdCargarGrid();
            this.pmtdHabilitarText(true);
            //this.pmtdLimpiarText();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.pmtdMensaje(new blAhorrador().gmtdEditar(crearObj()), "Ahorradores");
            this.pmtdCargarGrid();
            this.pmtdHabilitarText(true);
            this.pmtdLimpiarText();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Confirma que desea eliminar este registro? ", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlgResult == DialogResult.Yes)
            {
                this.pmtdMensaje(new blAhorrador().gmtdEliminar(crearObj()), "Ahorradores");
            }
            this.pmtdCargarGrid();
            this.pmtdLimpiarText();
            this.pmtdHabilitarText(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.pmtdLimpiarText();
            this.pmtdCargarGrid();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.dgvAhorradores.AutoGenerateColumns = false;
            this.dgvAhorradores.DataSource = new blAhorrador().gmtdFiltrar(crearObj());
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
                this.cboTipo.Focus();
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
                this.cboOrigen.Focus();
            }
        }

        private void cboOrigen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.chkAhorroEstudiantil.Focus();
            }
        }

        private void chkAhorroEstudiantil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.chkExcenta4xMil.Focus();
            }
        }

        private void txtCedulaBeneficiario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtNombreBeneficiario.Focus();
            }
        }

        private void txtNombreBeneficiario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtApellidoBeneficiario.Focus();
            }
        }

        private void txtApellidoBeneficiario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtCedulaAut.Focus();
            }
        }

        private void txtCedulaAut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtNombreAut.Focus();
            }
        }

        private void txtNombreAut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtNombreAut.Focus();
            }
        }

        private void txtApellidoAut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnGuardar.Focus();
            }
        }
        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (this.txtCodigo.Text.Trim() == "")
            {
                this.txtCodigo.Text = "0";
            }

            tblSocio socio = new blSocio().gmtdConsultar(Convert.ToInt32(this.txtCodigo.Text));

            if (socio.strCedulaSoc == null)
            {
                MessageBox.Show("Este código de socio no aparece registrado. ", "Agraciados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtCodigo.Text = "0";
            }
            else
            {
                this.txtCedula.Text = socio.strCedulaSoc;
                this.txtNombre.Text = socio.strNombreSoc;
                this.txtApellido1.Text = socio.strApellido1Soc;
                this.txtApellido2.Text = socio.strApellido2Soc;
                this.txtDireccion.Text = socio.strDireccion;
                this.txtTelefono.Text = socio.strTelefono;
                this.dtpNacimiento.Value = socio.dtmFechaNac;
            }

        }

        private void chkExcenta4xMil_KeyPress(object sender, KeyPressEventArgs e)
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
                this.txtCedulaBeneficiario.Focus();
            }
        }
    }
}
