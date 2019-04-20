namespace Mutuales2020.Servicios
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using System;
    using System.Windows.Forms;

    public partial class FrmDeudas : Form
    {

        bool bitCliente = false;

        public FrmDeudas()
        {
            InitializeComponent();
        }

        #region metodos
        private static FrmDeudas form = null;
        public static FrmDeudas DefInstance
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new FrmDeudas();
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
                blDeudas blDeu = new blDeudas();
                this.dgvDeudas.AutoGenerateColumns = false;
                this.dgvDeudas.DataSource = blDeu.gmtdConsultarTodos();
            }
        }

        /// <summary>
        /// Limpia los texbox del formulario.
        /// </summary>
        private void pmtdLimpiarText()
        {
            this.txtCodigo.Text = "0";
            this.txtValor.Text = "0";
            this.txtCedula.Text = "0";
            this.txtNombre.Text = "";
            this.cboServicios.SelectedIndex = 0;
            this.optGlobal.Checked = false;
            this.optParticular.Checked = true;
            this.cboPares.SelectedIndex = 0;

        }

        /// <summary>
        /// Habilita o deshabilita los controles de la aplicación.
        /// </summary>
        /// <param name="a"></param>
        private void pmtdHabilitarText(bool a)
        {
            this.txtCodigo.Enabled = a;
            this.txtValor.Enabled = a;
            this.txtCedula.Enabled = a;
            this.cboServicios.Enabled = a;
            //this.optGlobal.Enabled = a;
            this.optParticular.Enabled = a;
            this.cboPares.Enabled = a;
        }

        /// <summary>
        /// Crea un objeto del tipo aplicación de acuerdo a la información de los texbox.
        /// </summary>
        /// <returns> Un objeto del tipo aplicación. </returns>
        private tblDeuda crearObj()
        {
            tblDeuda deuda = new tblDeuda();
            deuda.bitGlobalDeu = this.optGlobal.Checked;
            deuda.decAbonaDeu = 0;
            deuda.intCodDeu = Convert.ToInt32(this.txtCodigo.Text);
            deuda.strCedula = this.txtCedula.Text;
            deuda.decDebeDeu = Convert.ToInt32(this.txtValor.Text);
            deuda.strCodigoPar = this.cboPares.SelectedValue.ToString();
            deuda.strCodSse = this.cboServicios.SelectedValue.ToString();
            deuda.bitCliente = bitCliente;
            deuda.strNombrePer = this.txtNombre.Text.Trim();
            deuda.strFormulario = this.Name;
            return deuda;
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
            this.cboServicios.DataSource = new blSecundarios().gmtdConsultarTodos();
            this.cboPares.DataSource = new blCuentaPar().gmtdConsultarTodos();

            if (this.cboServicios.Items.Count <= 0)
            {
                MessageBox.Show("Debe de ingresar servicios globales para utilizar esta pantalla. ", "Socios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.pmtdHabilitarText(false);
                this.btnCancelar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnGuardar.Enabled = false;
                this.btnModificar.Enabled = false;
                this.btnSalir.Enabled = false;
            }
            else
                this.cboServicios.SelectedIndex = 0;

            if (this.cboPares.Items.Count <= 0)
            {
                MessageBox.Show("Debe de ingresar pares para utilizar esta pantalla. ", "Socios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.pmtdHabilitarText(false);
                this.btnCancelar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnGuardar.Enabled = false;
                this.btnModificar.Enabled = false;
                this.btnSalir.Enabled = false;
            }
            else
                this.cboPares.SelectedIndex = 0;
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            tblDeuda deuda = new tblDeuda();
            DataGridViewSelectedRowCollection rows = ((DataGridView)sender).SelectedRows;
            foreach (DataGridViewRow dato in rows)
            {
                deuda = new blDeudas().gmtdConsultar(Convert.ToInt32(dato.Cells[0].Value));
            }
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Text = deuda.intCodDeu.ToString();
            this.cboServicios.SelectedValue = deuda.strCodSse;
            this.txtValor.Text = deuda.decDebeDeu.ToString("####");
            if (deuda.bitGlobalDeu == true)
                this.optGlobal.Checked = true;
            else
                this.optParticular.Checked = true;
            this.txtCedula.Text = deuda.strCedula;
            this.cboPares.SelectedValue = deuda.strCodigoPar;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.pmtdMensaje(new blDeudas().gmtdInsertar(crearObj()), "Deudas");
            this.pmtdCargarGrid();
            this.pmtdLimpiarText();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Confirma que desea eliminar este registro? ", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlgResult == DialogResult.Yes)
                this.pmtdMensaje(new blDeudas().gmtdEliminar(crearObj()), "Deudas");
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
                this.cboServicios.Focus();
        }

        private void cboServicios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtValor.Focus();
        }

        private void optGlobal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.btnGuardar.Focus();
        }

        private void txtSocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.btnGuardar.Focus();
        }

        private void cboPares_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.btnGuardar.Focus();
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (this.txtValor.Text.Trim() == "")
                this.txtValor.Text = "0";
        }

        private void txtSocio_Leave(object sender, EventArgs e)
        {
            if (this.txtCedula.Text.Trim() == "")
                this.txtCedula.Text = string.Empty;

            tblSocio socio = new blSocio().gmtdConsultar(this.txtCedula.Text);
            if (socio.strApellido1Soc != null)
            {
                this.txtNombre.Text = socio.strNombreSoc + " " + socio.strApellido1Soc + " " + socio.strApellido2Soc;
                bitCliente = false;
            }
            else if (new blCliente().gmtdConsultar(this.txtCedula.Text).strContacto != null)
            {
                this.txtNombre.Text = new blCliente().gmtdConsultar(this.txtCedula.Text).strContacto;
                bitCliente = true;
            }
            else
            {
                MessageBox.Show("Esta cèdula no apare registrada ni como socia ni como cliente.", "Cédula no valida");
                bitCliente = false;
            }

        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.optParticular.Focus();
        }

        private void optParticular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtCedula.Focus();
        }

        private void cboServicios_Leave(object sender, EventArgs e)
        {
           this.txtValor.Text = new blSecundarios().gmtdConsultar(this.cboServicios.SelectedValue.ToString()).intValorSse.ToString();
        }

    }
}
