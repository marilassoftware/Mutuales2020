namespace Mutuales2020.Servicios
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using Mutuales2020;
    using System;
    using System.Windows.Forms;

    public partial class FrmServiciosPrimarios : Form
    {
        public FrmServiciosPrimarios()
        {
            InitializeComponent();
        }

        #region metodos
        private static FrmServiciosPrimarios form = null;
        public static FrmServiciosPrimarios DefInstance
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new FrmServiciosPrimarios();
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
                blPrimarios blPri = new blPrimarios();
                this.dgv.DataSource = blPri.gmtdConsultarTodos();
            }
        }

        /// <summary>
        /// Limpia los texbox del formulario.
        /// </summary>
        private void pmtdLimpiarText()
        {
            this.txtCodigo.Text = "";
            this.txtDescripcion.Text = "";
            this.txtAno.Text = "0";
            this.txtCuota.Text = "0";
            this.txtValor.Text = "0";
            this.chkUnico.Checked = false;
            this.cboPares.SelectedIndex = 0;
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
        private tblServiciosPrimario crearObj()
        {
            tblServiciosPrimario primario = new tblServiciosPrimario();
            primario.bitUnicoSpr = this.chkUnico.Checked;
            primario.intAñoSpr = Convert.ToInt32(this.txtAno.Text);
            primario.intValorCuotaSpr = Convert.ToInt32(this.txtCuota.Text);
            primario.intValorSpr = Convert.ToInt32(this.txtValor.Text);
            primario.strCodigoPar = this.cboPares.SelectedValue.ToString();
            primario.strCodSpr = this.txtCodigo.Text;
            primario.strNombreSpr = this.txtDescripcion.Text;
            primario.strFormulario = this.Name;  
            return primario;
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
            this.cboPares.DataSource = new blCuentaPar().gmtdConsultarTodos();

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

        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            this.txtCodigo.Enabled = false;
            
            this.txtCodigo.Text = this.dgv.CurrentRow.Cells[0].Value.ToString();
            this.txtDescripcion.Text = this.dgv.CurrentRow.Cells[1].Value.ToString();
            this.txtValor.Text = this.dgv.CurrentRow.Cells[2].Value.ToString();
            this.txtCuota.Text = this.dgv.CurrentRow.Cells[3].Value.ToString();
            this.txtAno.Text = this.dgv.CurrentRow.Cells[4].Value.ToString();
            this.chkUnico.Checked = Convert.ToBoolean(this.dgv.CurrentRow.Cells[5].Value);
            this.cboPares.SelectedValue = this.dgv.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.pmtdMensaje(new blPrimarios().gmtdInsertar(crearObj()), "Primarios");
            this.pmtdCargarGrid();
            this.pmtdLimpiarText();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.pmtdMensaje(new blPrimarios().gmtdEditar(crearObj()), "Primarios");
            this.pmtdCargarGrid();
            this.pmtdLimpiarText();
            this.pmtdHabilitarText(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Confirma que desea eliminar este registro? ", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlgResult == DialogResult.Yes)
                this.pmtdMensaje(new blPrimarios().gmtdEliminar(crearObj()), "Primarios");
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
                this.txtValor.Focus();  
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtCuota.Focus();
            }
        }

        private void txtCuota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtAno.Focus();
            }
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.chkUnico.Focus();
            }
        }

        private void chkUnico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.cboPares.Focus();
            }
        }

        private void cboAplicaciones_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCuota_Validated(object sender, EventArgs e)
        {
            if (this.txtCuota.Text.Trim() == "")
                this.txtCuota.Text = "0";
        }

        private void txtValor_Validated(object sender, EventArgs e)
        {
            if (this.txtValor.Text.Trim() == "")
                this.txtValor.Text = "0";
        }

        private void txtAno_Validated(object sender, EventArgs e)
        {
            if (this.txtAno.Text.Trim() == "")
                this.txtAno.Text = "0";

        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (this.txtValor.Text.Trim() == "")
                this.txtValor.Text = "0";
        }

        private void txtCuota_Leave(object sender, EventArgs e)
        {
            if (this.txtCuota.Text.Trim() == "")
                this.txtCuota.Text = "0";
        }

        private void txtAno_Leave(object sender, EventArgs e)
        {
            if (this.txtAno.Text.Trim() == "")
                this.txtAno.Text = "0";
        }

    }
}
