namespace Mutuales2020.Creditos
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using System;
    using System.Windows.Forms;

    public partial class frmCreditosClasificacion : Form
    {
        public frmCreditosClasificacion()
        {
            InitializeComponent();
        }

        #region metodos
        private static frmCreditosClasificacion form = null;
        public static frmCreditosClasificacion DefInstance
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new frmCreditosClasificacion();
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

        /// <summary> Habilita o deshabilita los botones de acuerdo a las 
        /// opciones en la base de datos </summary>
        private void gmtdPermisosBotones()
        {
            Program.gmtdAsignarPermisos(ref btnGuardar, ref btnModificar, ref btnEliminar);
        }

        /// <summary> Carga la grid con datos si tiene permisos necesarios. </summary>
        private void pmtdCargarGrid()
        {
            if (propiedades.bitConsultar == true)
            {
                blCreditosClasificacion blTcr = new blCreditosClasificacion();
                this.dgvDatos.DataSource = blTcr.gmtdConsultarTodos();
            }
        }

        /// <summary> Limpia los texbox del formulario. </summary>
        private void pmtdLimpiarText()
        {
            this.txtCodigo.Text = "";
            this.txtNombre.Text = "";
            this.txtProvision.Text = "0";
            this.cboTiposdeCredito.SelectedIndex = 0;
            this.txtDiasEntre.Text = "0";
            this.txtDiasHasta.Text = "0";
            this.chkCausarIntereses.Checked = false;
            this.chkInteresporDias.Checked = false;
            this.chkSumarICM.Checked = false;
        }

        /// <summary> Habilita o deshabilita los controles de la aplicación. </summary>
        private void pmtdHabilitarText(bool a)
        {
            this.txtCodigo.Enabled = a;
            this.txtNombre.Enabled = a;
            this.txtProvision.Enabled = a;
            this.cboTiposdeCredito.Enabled = a;
            this.txtDiasEntre.Enabled = a;
            this.txtDiasHasta.Enabled = a;
            this.chkCausarIntereses.Enabled = a;
            this.chkInteresporDias.Enabled = a;
            this.chkSumarICM.Enabled = a;
        }

        /// <summary> Crea un objeto del tipo aplicación de acuerdo a la información de los texbox. </summary>
        /// <returns> Un objeto del tipo aplicación. </returns>
        private tblCreditosClasificacion crearObj()
        {
            tblCreditosClasificacion creditoClasificacion = new tblCreditosClasificacion();
            creditoClasificacion.bitCausarInteresesCla = this.chkCausarIntereses.Checked;
            creditoClasificacion.bitInteresporDiasCla = this.chkInteresporDias.Checked;
            creditoClasificacion.bitSumarICM = this.chkSumarICM.Checked;
            creditoClasificacion.decValorProvisionCla = Convert.ToDecimal(this.txtProvision.Text);
            creditoClasificacion.intDesdeCla = Convert.ToInt32(this.txtDiasEntre.Text);
            creditoClasificacion.intHastaCla = Convert.ToInt32(this.txtDiasHasta.Text);
            creditoClasificacion.strCodigoCla = this.txtCodigo.Text;
            creditoClasificacion.strNombreCla = this.txtNombre.Text;
            creditoClasificacion.strCodigoTcr = this.cboTiposdeCredito.SelectedValue.ToString();
            creditoClasificacion.strFormulario = this.Name;
            return creditoClasificacion;
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

        private void frmCreditosClasificacion_Load(object sender, EventArgs e)
        {
            this.gmtdPermisosBotones();
            this.pmtdCargarGrid();
            this.cboTiposdeCredito.DataSource = new blCreditosTipo().gmtdConsultarTodos();

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
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Text = this.dgvDatos.CurrentRow.Cells[0].Value.ToString();
            this.txtNombre.Text = this.dgvDatos.CurrentRow.Cells[1].Value.ToString();
            this.txtProvision.Text = this.dgvDatos.CurrentRow.Cells[2].Value.ToString();
            this.cboTiposdeCredito.SelectedValue = this.dgvDatos.CurrentRow.Cells[3].Value.ToString();
            this.txtDiasEntre.Text = this.dgvDatos.CurrentRow.Cells[4].Value.ToString();
            this.txtDiasHasta.Text = this.dgvDatos.CurrentRow.Cells[5].Value.ToString();
            this.chkCausarIntereses.Checked = Convert.ToBoolean(this.dgvDatos.CurrentRow.Cells[6].Value);
            this.chkInteresporDias.Checked = Convert.ToBoolean(this.dgvDatos.CurrentRow.Cells[7].Value);
            this.chkSumarICM.Checked = Convert.ToBoolean(this.dgvDatos.CurrentRow.Cells[8].Value);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.pmtdMensaje(new blCreditosClasificacion().gmtdInsertar(crearObj()), "Clasificación de Credito");
            this.pmtdCargarGrid();
            this.pmtdLimpiarText();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.pmtdMensaje(new blCreditosClasificacion().gmtdEditar(crearObj()), "Clasificación de Credito");
            this.pmtdCargarGrid();
            this.pmtdLimpiarText();
            this.pmtdHabilitarText(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Confirma que desea eliminar este registro? ", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlgResult == DialogResult.Yes)
                this.pmtdMensaje(new blCreditosClasificacion().gmtdEliminar(crearObj()), "Clasificación de Credito");
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

        private void frmCreditosClasificacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            propiedades.strFormActivo = "Principal";
            this.Dispose();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtNombre.Focus();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtProvision.Focus();
        }

        private void txtProvision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.cboTiposdeCredito.Focus();
        }

        private void cboTiposdeCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtDiasEntre.Focus();
        }

        private void txtDiasEntre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtDiasHasta.Focus();
        }

        private void txtDiasHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.chkSumarICM.Focus();
        }

        private void chkSumarICM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.chkCausarIntereses.Focus();
        }

        private void chkCausarIntereses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.chkInteresporDias.Focus();
        }

        private void chkInteresporDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.btnGuardar.Focus();
        }

        private void txtProvision_Leave(object sender, EventArgs e)
        {
            if (this.txtProvision.Text.Trim() == "")
                this.txtProvision.Text = "0";

        }

        private void txtDiasEntre_Leave(object sender, EventArgs e)
        {
            if (this.txtDiasEntre.Text.Trim() == "")
                this.txtDiasEntre.Text = "0";

        }

        private void txtDiasHasta_Leave(object sender, EventArgs e)
        {
            if (this.txtDiasHasta.Text.Trim() == "")
                this.txtDiasHasta.Text = "0";

        }

    }
}
