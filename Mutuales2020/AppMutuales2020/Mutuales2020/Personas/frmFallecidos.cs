using System;
using System.Collections.Generic;
namespace Mutuales2020.Personas
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using System.Windows.Forms;
    public partial class FrmFallecidos : Form
    {
        string strAgraciado = "";

        public FrmFallecidos()
        {
            InitializeComponent();
        }

        #region metodos
        private static FrmFallecidos form = null;
        public static FrmFallecidos DefInstance
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new FrmFallecidos();
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
                blFallecidos blFal = new blFallecidos();

                this.dgvFallecidos.AutoGenerateColumns = false;
                this.dgvFallecidos.DataSource = null;
                this.dgvFallecidos.DataSource = blFal.gmtdConsultarTodosTbl();
                this.dgvFallecidos.Refresh();

            }
        }

        /// <summary>
        /// Limpia los texbox del formulario.
        /// </summary>
        private void pmtdLimpiarText()
        {
            this.txtCedula.Text = "";
            this.txtNombre.Text = "";
            this.txtApellido1.Text = "";
            this.txtApellido2.Text = "";
            this.txtFolio.Text = "";
            this.txtNotaria.Text = "";
            this.txtSocio.Text = "0";
            this.txtPagado.Text = "0";
            this.txtProcedencia.Text = "";
            this.txtAños.Text = "0";
            this.txtComentario.Text = "";
            this.cboTipo.SelectedIndex = 0;
            this.chkHecho.Checked = false;
            this.dtpFallecido.Value = DateTime.Now;
            this.dtpAnuncio.Value = DateTime.Now;
            this.dgvAgraciados.DataSource = new List<Agraciado>();
            this.dgvFallecidos.DataSource = new List<tblFallecido>();
            strAgraciado = "";
        }

        /// <summary>
        /// Habilita o deshabilita los controles de la aplicación.
        /// </summary>
        /// <param name="a"></param>
        private void pmtdHabilitarText(bool a)
        {
            this.txtCedula.Enabled = a;
            this.txtNombre.Enabled = a;
            this.txtApellido1.Enabled = a;
            this.txtApellido2.Enabled = a;
            this.txtFolio.Enabled = a;
            this.txtNotaria.Enabled = a;
            this.txtPagado.Enabled = a;
            this.txtAños.Enabled = a;
            this.txtComentario.Enabled = a;
            this.cboTipo.Enabled = a;
            this.chkHecho.Enabled = a;
            this.dtpFallecido.Enabled = a;
            this.dtpAnuncio.Enabled = a;
        }

        /// <summary> Crea un objeto del tipo aplicación de acuerdo a la información de los texbox. </summary>
        /// <returns> Un objeto del tipo aplicación. </returns>
        private tblFallecido crearObj()
        {
            tblFallecido fallecido = new tblFallecido();
            fallecido.bitAnulado = false;
            fallecido.bitHecho = this.chkHecho.Checked;
            fallecido.dtmFechaAnu = Convert.ToDateTime("1900/01/01");
            fallecido.dtmFechaFal = this.dtpFallecido.Value;
            fallecido.dtmFechaNuc = this.dtpAnuncio.Value;
            fallecido.intAños = Convert.ToInt32(this.txtAños.Text);
            fallecido.strAgraciado = strAgraciado;
            fallecido.strApellido1Fal = this.txtApellido1.Text;
            fallecido.strApellido2Fal = this.txtApellido2.Text;
            fallecido.intCodigoSoc = Convert.ToInt32(this.txtSocio.Text);
            fallecido.strCedulaFal = this.txtCedula.Text;
            fallecido.strComentario = this.txtComentario.Text.Trim();
            fallecido.strFolio = this.txtFolio.Text;
            fallecido.strNombreFal = this.txtNombre.Text;
            fallecido.strNotaria = this.txtNotaria.Text;
            fallecido.strFormulario = this.Name;
            fallecido.strProcedencia = this.txtProcedencia.Text;
            fallecido.strTipoCed = this.cboTipo.Text;
            fallecido.intPagado = Convert.ToInt32(this.txtPagado.Text);
            return fallecido;
        }

        private string gmtdAgraciadoSeleccionado()
        {
            if (this.dgvAgraciados.RowCount > 1)
                return this.dgvAgraciados[0, this.dgvAgraciados.CurrentRow.Index].Value.ToString();
            else
                return "";
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
            this.cboTipo.SelectedIndex = 0;
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            this.txtCedula.Enabled = false;
            this.txtSocio.Text = this.dgvFallecidos.CurrentRow.Cells[0].Value.ToString();
            this.txtCedula.Text = this.dgvFallecidos.CurrentRow.Cells[1].Value.ToString();
            this.txtNombre.Text = this.dgvFallecidos.CurrentRow.Cells[2].Value.ToString();
            this.txtApellido1.Text = this.dgvFallecidos.CurrentRow.Cells[3].Value.ToString();
            this.txtApellido2.Text = this.dgvFallecidos.CurrentRow.Cells[4].Value.ToString();
            this.txtNotaria.Text = this.dgvFallecidos.CurrentRow.Cells[5].Value.ToString();
            this.txtFolio.Text = this.dgvFallecidos.CurrentRow.Cells[6].Value.ToString();
            this.txtAños.Text = this.dgvFallecidos.CurrentRow.Cells[7].Value.ToString();
            this.txtPagado.Text = this.dgvFallecidos.CurrentRow.Cells[8].Value.ToString();
            this.txtProcedencia.Text = this.dgvFallecidos.CurrentRow.Cells[9].Value.ToString();
            this.chkHecho.Checked = Convert.ToBoolean(this.dgvFallecidos.CurrentRow.Cells[10].Value);
            this.txtComentario.Text = this.dgvFallecidos.CurrentRow.Cells[11].Value.ToString();
            this.dtpFallecido.Value = Convert.ToDateTime(this.dgvFallecidos.CurrentRow.Cells[12].Value);
            this.dtpAnuncio.Value = Convert.ToDateTime(this.dgvFallecidos.CurrentRow.Cells[13].Value);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            blFallecidos blFal = new blFallecidos();
            string strRespuesta = blFal.gmtdInsertar(crearObj());
            this.pmtdMensaje(strRespuesta, "Fallecidos");
            if (strRespuesta.Substring(0, 1) != "-")
            {
                this.pmtdLimpiarText();
                this.pmtdHabilitarText(true);
                this.pmtdCargarGrid();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.pmtdMensaje(new blFallecidos().gmtdEditar(crearObj()), "Fallecidos");
            this.pmtdLimpiarText();
            this.pmtdCargarGrid();
            this.pmtdHabilitarText(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Confirma que desea eliminar este registro? ", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlgResult == DialogResult.Yes)
            {
                this.pmtdMensaje(new blFallecidos().gmtdEliminar(crearObj()), "Fallecidos");
            }

            this.pmtdLimpiarText();
            this.pmtdCargarGrid();
            this.pmtdHabilitarText(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.pmtdCargarGrid();
            this.pmtdLimpiarText();
            this.pmtdHabilitarText(true);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            propiedades.strFormActivo = "Principal";
            this.Dispose();
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.cboTipo.Focus();
        }

        private void cboTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtNombre.Focus();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtApellido1.Focus();
        }

        private void txtApellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtApellido2.Focus();
        }

        private void txtApellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtFolio.Focus();
        }

        private void txtFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtNotaria.Focus();
        }

        private void txtNotaria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.dtpFallecido.Focus();
        }

        private void dtpFallecido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.dtpAnuncio.Focus();
        }

        private void dtpAnuncio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtPagado.Focus();
        }

        private void txtSocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtPagado.Focus();
        }

        private void txtPagado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtAños.Focus();
        }

        private void txtProcedencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtAños.Focus();
        }

        private void txtAños_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.chkHecho.Focus();
        }

        private void chkHecho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtComentario.Focus();
        }

        private void txtComentario_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if (this.txtCedula.Text.Trim() == "")
            {
                this.txtCedula.Text = "0";
            }

            this.txtProcedencia.Text = new blFallecidos().gmtdBuscarCedula(this.txtCedula.Text);
            if (this.txtProcedencia.Text == "Socio")
            {
                tblSocio socio = new blSocio().gmtdConsultarDetalle(this.txtCedula.Text);
                this.txtSocio.Text = socio.intCodigoSoc.ToString();
                this.txtNombre.Text = socio.strNombreSoc;
                this.txtApellido1.Text = socio.strApellido1Soc;
                this.txtApellido2.Text = socio.strApellido2Soc;
                this.dgvAgraciados.AutoGenerateColumns = false;
                this.dgvAgraciados.DataSource = new blAgraciado().gmtdConsultar(Convert.ToInt32(this.txtSocio.Text));
            }
            else
            {
                if (this.txtProcedencia.Text == "Agraciado")
                {
                    tblAgraciado objAgraciado = new blAgraciado().gmtdConsultarDetalle(this.txtCedula.Text);
                    this.txtSocio.Text = objAgraciado.intCodigoSoc.ToString();
                    this.txtNombre.Text = objAgraciado.strNombreAgra;
                    this.txtApellido1.Text = objAgraciado.strApellido1Agra;
                    this.txtApellido2.Text = objAgraciado.strApellido2Agra;
                    this.dgvAgraciados.AutoGenerateColumns = false;
                    this.dgvAgraciados.DataSource = new blAgraciado().gmtdConsultar(Convert.ToInt32(-1));
                }
            }
        }

        private void txtComentario_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvAgraciados_DoubleClick(object sender, EventArgs e)
        {
            strAgraciado = dgvAgraciados.CurrentRow.Cells[0].Value.ToString();

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            blFallecidos blFal = new blFallecidos();
            this.dgvFallecidos.AutoGenerateColumns = false;
            this.dgvFallecidos.DataSource = blFal.gmtdFiltrar(crearObj());
        }

    }
}
