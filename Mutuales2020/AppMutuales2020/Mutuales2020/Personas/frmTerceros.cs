namespace Mutuales2020.Personas
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using System;
    using System.Windows.Forms;

    public partial class FrmTerceros : Form
    {
        public FrmTerceros()
        {
            InitializeComponent();
        }

        #region metodos
        private static FrmTerceros form = null;
        public static FrmTerceros DefInstance
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new FrmTerceros();
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
                blCliente blCli = new blCliente();
                this.dgvClientes.DataSource = blCli.gmtdConsultarTodos();
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
            this.txtCelular.Text = "0";
            this.txtMail.Text = "";
            this.cboTipo.SelectedIndex = 0;
            this.cboTipoTercero.SelectedIndex = 0;
            this.dtpIngreso.Value = DateTime.Now;
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
            this.txtCelular.Enabled = a;
            this.txtMail.Enabled = a;
            this.cboTipo.Enabled = a;
            this.cboTipoTercero.Enabled = a;
            this.dtpIngreso.Enabled = a;
        }

        /// <summary>
        /// Crea un objeto del tipo aplicación de acuerdo a la información de los texbox.
        /// </summary>
        /// <returns> Un objeto del tipo aplicación. </returns>
        private tblCliente crearObj()
        {
            tblCliente cliente = new tblCliente();
            cliente.dtmFechaIng = this.dtpIngreso.Value;
            cliente.strCelular = this.txtCelular.Text;
            cliente.strCodigoCli = this.txtCodigo.Text;
            cliente.strContacto = this.txtContacto.Text;
            cliente.strCorreo = this.txtMail.Text;
            cliente.strDireccion = this.txtDireccion.Text;
            cliente.strEmpresa = this.txtEmpresa.Text;
            cliente.strFormulario = this.Name;
            cliente.strTelefono = this.txtTelefono.Text;
            cliente.strTipoCliente = this.cboTipoTercero.Text;
            cliente.strTipoDoc = this.cboTipo.Text;
            return cliente;
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
            this.pmtdLimpiarText();
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            tblCliente cliente = new tblCliente();
            DataGridViewSelectedRowCollection rows = ((DataGridView)sender).SelectedRows;
            foreach (DataGridViewRow dato in rows)
            {
                cliente = new blCliente().gmtdConsultarDetalle(dato.Cells[0].Value.ToString());
            }

            if (cliente.strContacto != null)
            {
                this.txtCodigo.Enabled = false;
                this.txtCodigo.Text = cliente.strCodigoCli;
                this.txtEmpresa.Text = cliente.strEmpresa;
                this.txtContacto.Text = cliente.strContacto;
                this.txtDireccion.Text = cliente.strDireccion;
                this.txtTelefono.Text = cliente.strTelefono;
                this.txtCelular.Text = cliente.strCelular;
                this.txtMail.Text = cliente.strCorreo;
                this.cboTipo.SelectedText = cliente.strTipoDoc;
                this.cboTipoTercero.Text = cliente.strTipoCliente;
                this.dtpIngreso.Value = cliente.dtmFechaIng;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string strRespuesta = new blCliente().gmtdInsertar(crearObj());
            this.pmtdMensaje(strRespuesta, "Clientes");
            this.pmtdCargarGrid();
            if (strRespuesta.Substring(0, 1) != "-")
            {
                this.pmtdLimpiarText();
                this.pmtdHabilitarText(true);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string strRespuesta = new blCliente().gmtdEditar(crearObj());
            this.pmtdMensaje(strRespuesta, "Clientes");
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
                this.pmtdMensaje(new blCliente().gmtdEliminar(crearObj()), "Clientes");
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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.dgvClientes.DataSource = new blCliente().gmtdFiltrar(crearObj());
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            propiedades.strFormActivo = "Principal";
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
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
                this.txtCelular.Focus();
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
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
                this.cboTipoTercero.Focus();
            }
        }

        private void cboTipoTercero_KeyPress(object sender, KeyPressEventArgs e)
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

    }
}
