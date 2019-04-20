namespace Mutuales2020.Ahorros
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using System;
    using System.Windows.Forms;

    public partial class FrmAhorrosaFuturoLiquidacion : Form
    {
        LiquidacionAhorroaFuturo liquidacion;

        public FrmAhorrosaFuturoLiquidacion()
        {
            InitializeComponent();
        }

        #region metodos
        private static FrmAhorrosaFuturoLiquidacion form = null;
        public static FrmAhorrosaFuturoLiquidacion DefInstance
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new FrmAhorrosaFuturoLiquidacion();
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
        /// Limpia los texbox del formulario.
        /// </summary>
        private void pmtdLimpiarText()
        {
            this.txtCuenta.Text = "0";
            this.txtAhorrador.Text = "";
            this.txtCuotasPagadas.Text = "0";
            this.txtPorcentajeCuotasPagadas.Text = "0";
            this.txtCuotasaPagar.Text = "0";
            this.txtIntereses.Text = "0";
            this.txtPremios.Text = "0";
            this.txtTotalRecaudado.Text = "0";
            this.txtDescuento.Text = "0";
            this.txtTotalLiquidacion.Text = "0";
        }

        /// <summary>
        /// Habilita o deshabilita los controles de la aplicación.
        /// </summary>
        /// <param name="a"></param>
        private void pmtdHabilitarText(bool a)
        {
            this.txtCuenta.Enabled = a;
            this.txtAhorrador.Enabled = a;
            this.txtCuotasPagadas.Enabled = a;
            this.txtPorcentajeCuotasPagadas.Enabled = a;
            this.txtCuotasaPagar.Enabled = a;
            this.txtIntereses.Enabled = a;
            this.txtPremios.Enabled = a;
            this.txtTotalRecaudado.Enabled = a;
            this.txtDescuento.Enabled = a;
            this.txtTotalLiquidacion.Enabled = a;
        }

        /// <summary> Crea un objeto del tipo aplicación de acuerdo a la información de los texbox. </summary>
        /// <returns> Un objeto del tipo aplicación. </returns>
        private LiquidacionAhorroaFuturo crearObj()
        {
            LiquidacionAhorroaFuturo ahorroaFuturo = new LiquidacionAhorroaFuturo();
            ahorroaFuturo.decDescuento = Convert.ToDecimal(this.txtDescuento.Text);
            ahorroaFuturo.decIntereses = Convert.ToDecimal(this.txtIntereses.Text);
            ahorroaFuturo.decPorcentajeCuotasPagadas = Convert.ToDecimal(this.txtPorcentajeCuotasPagadas.Text);
            ahorroaFuturo.decPremios = Convert.ToDecimal(this.txtPremios.Text);
            ahorroaFuturo.decTotalLiquidacion = Convert.ToDecimal(this.txtTotalLiquidacion.Text);
            ahorroaFuturo.decTotalRecaudado = Convert.ToDecimal(this.txtTotalRecaudado.Text);
            ahorroaFuturo.intCuotasaPagar = Convert.ToInt32(this.txtCuotasaPagar.Text);
            ahorroaFuturo.intCuotasPagadas = Convert.ToInt32(this.txtCuotasPagadas.Text);
            ahorroaFuturo.strAhorrador = this.txtAhorrador.Text;
            ahorroaFuturo.strCuenta = this.txtCuenta.Text;
            ahorroaFuturo.strFormulario = this.Name;
            return ahorroaFuturo;
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
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            liquidacion.strFormulario = this.Name;
            this.pmtdMensaje(new blAhorrosaFuturo().gmtdLiquidarAhorroaFuturo(liquidacion), "Ahorro a Futuro");
            //this.pmtdMensaje(new blAhorrosaFuturo().gmtdLiquidarAhorroaFuturo(crearObj()), "Ahorro a Futuro");
            this.pmtdLimpiarText();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Confirma que desea eliminar este registro? ", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlgResult == DialogResult.Yes)
                this.pmtdMensaje(new blAhorrosaFuturo().gmtdEliminarLiquidaciondeCuenta(crearObj()), "Ahorro a Futuro");
            this.pmtdLimpiarText();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.pmtdLimpiarText();
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
                this.txtAhorrador.Focus();
            }
        }

        private void btnCalcularLiquidacion_Click(object sender, EventArgs e)
        {
            if (this.txtCuenta.Text == null || this.txtCuenta.Text.Trim() == "" || this.txtCuenta.Text == "0")
            {
                MessageBox.Show("Debe de digitar el número de la cuenta a liquidar. ", "Liquidar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tblAhorrosaFuturo ahorro = new blAhorrosaFuturo().gmtdConsultar(this.txtCuenta.Text);

            if (ahorro.strCuenta == null)
            {
                MessageBox.Show("No se puede liquidar una cuenta que no existe. ", "Liquidar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ahorro.bitAnulado == true)
            {
                MessageBox.Show("No se puede liquidar una cuenta anulada. ", "Liquidar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ahorro.bitLiquidada == true)
            {
                MessageBox.Show("No se puede liquidar una cuenta liquidada. ", "Liquidar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            liquidacion = new blAhorrosaFuturo().gmtdCalcularLiquidacionAhorroaFuturo(this.txtCuenta.Text);

            liquidacion.strComputador = Environment.MachineName;
            liquidacion.strUsuario = propiedades.strLogin;

            this.txtAhorrador.Text = liquidacion.strAhorrador;
            this.txtCuotasPagadas.Text = liquidacion.intCuotasPagadas.ToString();
            this.txtPorcentajeCuotasPagadas.Text = liquidacion.decPorcentajeCuotasPagadas.ToString();
            this.txtCuotasaPagar.Text = "12";
            this.txtIntereses.Text = liquidacion.decIntereses.ToString();
            this.txtPremios.Text = liquidacion.decPremios.ToString();
            this.txtTotalRecaudado.Text = liquidacion.decTotalRecaudado.ToString();
            this.txtDescuento.Text = liquidacion.decDescuento.ToString();
            this.txtTotalLiquidacion.Text = liquidacion.decTotalLiquidacion.ToString();

        }

        private void txtCuenta_Enter(object sender, EventArgs e)
        {
            this.pmtdLimpiarText();
        }

    }
}
