namespace Mutuales2020.Ahorros
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using System;
    using System.Windows.Forms;

    public partial class frmAhorrosNavideño : Form
    {
        public frmAhorrosNavideño()
        {
            InitializeComponent();
        }

        #region metodos
        private static frmAhorrosNavideño form = null;
        public static frmAhorrosNavideño DefInstance
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new frmAhorrosNavideño();
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
                this.dgvAhorrosNavideños.AutoGenerateColumns = false;
                this.dgvAhorrosNavideños.DataSource = new blAhorrosNavideno().gmtdConsultarTodos();
            }
        }

        /// <summary>
        /// Limpia los texbox del formulario.
        /// </summary>
        private void pmtdLimpiarText()
        {
            this.txtCuenta.Text = "";
            this.dtpFechaCuenta.Value = DateTime.Now;
            this.txtCedulaAho.Text = "0";
            this.txtNomAhorrador.Text = "";
            this.txtValor.Text = "0";
            this.txtAño.Text = "0";
            this.txtCuotas.Text = "0";
        }

        /// <summary>
        /// Habilita o deshabilita los controles de la aplicación.
        /// </summary>
        /// <param name="a"></param>
        private void pmtdHabilitarText(bool a)
        {
            this.txtCuenta.Enabled = a;
            this.dtpFechaCuenta.Enabled = a;
            this.txtCedulaAho.Enabled = a;
            this.txtValor.Enabled = a;
            this.txtAño.Enabled = a;
        }

        /// <summary>
        /// Crea un objeto del tipo aplicación de acuerdo a la información de los texbox.
        /// </summary>
        /// <returns> Un objeto del tipo aplicación. </returns>
        private tblAhorrosNavideno crearObj()
        {
            tblAhorrosNavideno ahorros = new tblAhorrosNavideno();
            ahorros.bitAnulado = false;
            ahorros.bitLiquidada = false;
            ahorros.dtmAnulado = Convert.ToDateTime("1900-01-01");
            ahorros.dtmFechaCuenta = DateTime.Now;
            ahorros.dtmFechaLiquidada = Convert.ToDateTime("1900-01-01");
            ahorros.fltIntereses = 0;
            ahorros.fltPremios = 0;
            ahorros.fltValorCuota = Convert.ToDouble(this.txtValor.Text);
            ahorros.intAno = Convert.ToInt32(txtAño.Text);
            ahorros.intCuotas = Convert.ToInt32(this.txtCuotas.Text);
            ahorros.intPagadas = 0;
            ahorros.strCuenta = this.txtCuenta.Text;
            ahorros.strFormulario = this.Name;
            ahorros.strComputador = Environment.MachineName;
            ahorros.strUsuario = propiedades.strLogin;

            if (this.txtNomAhorrador.Text == "")
                ahorros.strCedulaAho = null;
            else
                ahorros.strCedulaAho = this.txtCedulaAho.Text;
            return ahorros;
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

        private void frmAhorrosNavideño_Load(object sender, EventArgs e)
        {
            this.gmtdPermisosBotones();
            this.pmtdCargarGrid();
            this.txtCuotas.Text = "52";
        }

        private void dgvAhorrosNavideños_DoubleClick(object sender, EventArgs e)
        {
            this.txtCuenta.Enabled = false;
            this.txtCuenta.Text = this.dgvAhorrosNavideños.CurrentRow.Cells[0].Value.ToString();
            this.dtpFechaCuenta.Value = Convert.ToDateTime(this.dgvAhorrosNavideños.CurrentRow.Cells[4].Value);
            this.txtCedulaAho.Text = this.dgvAhorrosNavideños.CurrentRow.Cells[1].Value.ToString();
            this.txtNomAhorrador.Text = this.dgvAhorrosNavideños.CurrentRow.Cells[2].Value.ToString() + " " + this.dgvAhorrosNavideños.CurrentRow.Cells[3].Value.ToString();
            this.txtValor.Text = this.dgvAhorrosNavideños.CurrentRow.Cells[5].Value.ToString();
            this.txtAño.Text = this.dgvAhorrosNavideños.CurrentRow.Cells[6].Value.ToString();
            this.txtCuotas.Text = this.dgvAhorrosNavideños.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.pmtdMensaje(new blAhorrosNavideno().gmtdInsertar(crearObj()), "Ahorros Navideños");
            this.pmtdCargarGrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Confirma que desea eliminar este registro? ", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlgResult == DialogResult.Yes)
            {
                this.pmtdMensaje(new blAhorrosNavideno().gmtdEliminar(crearObj()), "Ahorros Navideños");
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            propiedades.strFormActivo = "Principal";
            this.Dispose();
        }

        private void frmAhorrosNavideño_FormClosed(object sender, FormClosedEventArgs e)
        {
            propiedades.strFormActivo = "Principal";
        }

        private void txtCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.dtpFechaCuenta.Focus();
            }
        }

        private void dtpFechaCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtCedulaAho.Focus();
            }
        }

        private void txtCedulaAho_KeyPress(object sender, KeyPressEventArgs e)
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
                this.txtAño.Focus();
            }
        }

        private void txtAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtCuotas.Focus();
            }
        }

        private void txtCuotas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnGuardar.Focus();
            }
        }

        private void txtCedulaAho_Leave(object sender, EventArgs e)
        {
            if (this.txtCedulaAho.Text.Trim() == "")
            {
                this.txtCedulaAho.Text = "0";
            }

            tblAhorradore ahorrador = new blAhorrador().gmtdConsultar(this.txtCedulaAho.Text);

            if (ahorrador.strNombreAho == null)
            {
                this.txtNomAhorrador.Text = "";
            }
            else
            {
                this.txtNomAhorrador.Text = ahorrador.strNombreAho + " " + ahorrador.strApellido1Aho + " " + ahorrador.strApellido2Aho;
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (this.txtValor.Text.Trim() == "")
            {
                this.txtValor.Text = "0";
            }
        }

        private void txtAño_Leave(object sender, EventArgs e)
        {
            if (this.txtAño.Text.Trim() == "")
            {
                this.txtAño.Text = "0";
            }
        }

        private void txtCuotas_Leave(object sender, EventArgs e)
        {
            if (this.txtCuotas.Text.Trim() == "")
            {
                this.txtCuotas.Text = "0";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
