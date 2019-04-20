using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.Drawing;

namespace winExequial2010.Movimientos
{
    public partial class frmIngresos
    {
        string strUltimoMes = "";
        private static frmIngresos form = null;
        public static frmIngresos DefInstance
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new frmIngresos();
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

        #region Metodos

        /// <summary> Calculas las inciales de un determinado Mes. </summary>
        /// <param name="tintMes"> Número del mes al que se le van a calcular las iniciales. </param>
        /// <returns> Iniciales del mes. </returns>
        private string pmtdInicialesMes(int tintMes)
        {
            string strValor = "";
            switch (tintMes)
            { 
                case 1:
                    strValor = "Enero";
                    break;
                case 2:
                    strValor = "Febrero";
                    break;
                case 3:
                    strValor = "Marzo";
                    break;
                case 4:
                    strValor = "Abril";
                    break;
                case 5:
                    strValor = "Mayo";
                    break;
                case 6:
                    strValor = "Junio";
                    break;
                case 7:
                    strValor = "Julio";
                    break;
                case 8:
                    strValor = "Agosto";
                    break;
                case 9:
                    strValor = "Septiembre";
                    break;
                case 10:
                    strValor = "Octubre";
                    break;
                case 11:
                    strValor = "Noviembre";
                    break;
                case 12:
                    strValor = "Diciembre";
                    break;
            }

            return strValor;
        }

        /// <summary> Calcula en letras los meses pagados </summary>
        /// <param name="tintMesActual"> Meses actual. </param>
        /// <param name="tintMesesPagados"> Meses pagados. </param>
        /// <returns> Los meses pagados en letras. </returns>
        private string pmtdMesesCancelados(int tintMesActual, int tintMesesPagados)
        {
            string strMeses = "";
            for (int a = tintMesActual + 1; a <= tintMesesPagados; a++)
            {
                strUltimoMes = pmtdInicialesMes(a);
                strMeses = strMeses + strUltimoMes.Substring(0, 3) + ", ";
            }
            strMeses = strMeses.Substring(0, strMeses.Length - 2);
            return strMeses;
        }

        /// <summary> Habilita o deshabilita los botones de acuerdo a las opciones en la base de datos. </summary>
        private void gmtdPermisosBotones()
        {
            Program.gmtdAsignarPermisos(ref btnGuardar, ref btnNuevo, ref btnEliminar);
        }

        /// <summary> Carga la grid con los beneficiario.</summary>
        private void pmtdCargarGridBeneficiarios()
        {
            if (propiedadesExequial2010.bitConsultar == true)
                this.dgvAgraciados.DataSource = new blAhorrador().gmtdConsultarTodos();
        }

        /// <summary> Calcula el gran total del recibo. </summary>
        private void pmtdCalcularGranTotal()
        {
            this.txtGranTotal.Text = (Convert.ToDecimal(this.txtTotalCuotas.Text) + Convert.ToDecimal(this.txtTotalPrestamos.Text) + Convert.ToDecimal(this.txtAhorrar.Text) + Convert.ToDecimal(this.txtAhorrarEstudiantil.Text) + Convert.ToDecimal(this.txtTotalAhorroNavideño.Text) + Convert.ToDecimal(this.txtTotalAhorroNatilleraEscolar.Text) + Convert.ToDecimal(this.txtTotalAhorroaFuturo.Text) + Convert.ToDecimal(this.txtAhorrarFijo.Text) + Convert.ToDecimal(this.txtTotalOtrosIngresos.Text) + Convert.ToDecimal(this.txtValoraAbonarPrestamo.Text) + Convert.ToDecimal(this.txtAbonaVenta.Text) + Convert.ToDecimal(this.txtAbonaDeuda.Text) + Convert.ToDecimal(this.txtAbonaDeuda1.Text)).ToString("#,#00.00");
        }

        /// <summary> Calcula el total del recibo de cuotas. </summary>
        private void pmtdCalcularTotalCuotas()
        {
            int intCantidad = Convert.ToInt32(this.txtCantidad.Text);
            int intDescuento = Convert.ToInt32(this.txtDescuento.Text);
            int intCuota = Convert.ToInt32(this.txtCuota.Text);
            int intTotal = 0;

            if (this.txtTipo.Text == "Normal")
            {
                intTotal = (intCantidad * intCuota) - intDescuento;
            }
            else
            {
                intTotal = ((intCantidad * intCuota) * (this.dgvAgraciados.RowCount + 1)) - intDescuento;
            }

            if (intTotal < 1)
            {
                this.txtCantidad.Text = "0";
                this.txtDescuento.Text = "0";
                this.txtTotalCuotas.Text = "0";
            }
            else
            {
                this.txtTotalCuotas.Text = intTotal.ToString();
                //if (Convert.ToInt32(this.txtAdultos.Text) > 0 && this.bitGuardando == false)
                //{
                //    this.cboIngresos.Text = "Adulto Mayor";
                //    this.txtDescripcion.Text = "Paga " + this.txtCantidad.Text + " cuota(s) de " + this.txtAdultos.Text + " Adultos mayores ";
                //    this.txtValorOtros.Text = Convert.ToString((Convert.ToInt32(this.txtAdultos.Text) * Convert.ToInt32(this.txtCuotaAdulto.Text)) * Convert.ToInt32(this.txtCantidad.Text));
                //    this.chkOtros.Checked = true;
                //    this.pAgregarOtros();
                //}
            }

        }

        /// <summary> Suma las cuotas de préstamos. </summary>
        private void pmtdCalcularSumadeCuotasdePrestamo()
        {
            decimal decValorCuotas = 0;
            for (int a = 0; a < this.dgvPrestamosCuotas.Rows.Count; a++)
            {
                decValorCuotas += (decimal)this.dgvPrestamosCuotas[6, a].Value;
            }

            this.txtTotalPrestamos.Text = decValorCuotas.ToString("#,#00.00");
        }

        /// <summary> Suma las cuotas de ahorro navideño. </summary>
        private void pmtdCalcularSumadeCuotasdeAhorroNavideño()
        {
            decimal decValorCuotas = 0;
            for (int a = 0; a < this.dgvAhorrosNavideños.Rows.Count; a++)
            {
                decValorCuotas += (decimal)this.dgvAhorrosNavideños[2, a].Value;
            }

            this.txtTotalAhorroNavideño.Text = decValorCuotas.ToString("#,#00.00");
        }

        /// <summary> Suma las cuotas de ahorro navideño. </summary>
        private void pmtdCalcularSumadeCuotasdeAhorroNatilleraEscolar()
        {
            decimal decValorCuotas = 0;
            for (int a = 0; a < this.dgvAhorrosNatilleraEscolar.Rows.Count; a++)
            {
                decValorCuotas += (decimal)this.dgvAhorrosNatilleraEscolar[2, a].Value;
            }

            this.txtTotalAhorroNatilleraEscolar.Text = decValorCuotas.ToString("#,#00.00");
        }

        /// <summary> Suma las cuotas de ahorro a futuro. </summary>
        private void pmtdCalcularSumadeCuotasdeAhorroaFuturo()
        {
            decimal decValorCuotas = 0;
            for (int a = 0; a < this.dgvAhorrosaFuturo.Rows.Count; a++)
            {
                decValorCuotas += (decimal)this.dgvAhorrosaFuturo[2, a].Value;
            }

            this.txtTotalAhorroaFuturo.Text = decValorCuotas.ToString("#,#00.00");
        }

        /// <summary> Suma las cuotas de otros ingresos. </summary>
        private void pmtdCalcularSumadeOtrosIngresos()
        {
            decimal decValorCuotas = 0;
            for (int a = 0; a < this.dgvOtrosIngresos.Rows.Count; a++)
            {
                decValorCuotas += Convert.ToDecimal(this.dgvOtrosIngresos[2, a].Value);
            }

            this.txtTotalOtrosIngresos.Text = decValorCuotas.ToString("#,#00.00");
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

        /// <summary> Consulta las deudas de una determinada persona. </summary>
        /// <param name="tstrCedula"> El número de la cédula de la persona a la que se le va a consultar las deudas. </param>
        private void pmtdConsultarEstadosdeCuenta(string tstrCedula)
        {
            List<tblEstadodeCuenta> lstEstados = new blRecibosIngresos().gmtdSumarDeudasxPersona(tstrCedula);
            if (lstEstados.Count > 0)
            {
                string strMensaje = "Esta persona tiene pendiente las siguientes deudas con la mutual. \n \n";

                foreach (tblEstadodeCuenta estado in lstEstados)
                {
                    strMensaje += estado.strDescripcion + Convert.ToDecimal(estado.intValor).ToString("#,#00.00") + "\n";
                }

                MessageBox.Show(strMensaje, "Deudas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        #endregion

        #region limpiarControles

        /// <summary> Agrupa la limpieza de todos los controles. </summary>
        private void pmtdLimpiarControles()
        {
            this.pmtdLimpiarControlesPrincipal();
            this.pmtdLimpiarControlesCuotasExequiales();
            this.pmtdLimpiarControlesCuotasPrestamos();
            this.pmtdLimpiarControlesAhorrosalaVista();
            this.pmtdLimpiarControlesAhorrosEstudiantil();
            this.pmtdLimpiarControlesAhorrosNavideño();
            this.pmtdLimpiarControlesAhorrosNatilleraEscolar();
            this.pmtdLimpiarControlesAhorrosaFuturo();
            this.pmtdLimpiarControlesAhorrosFijo();
            this.pmtdLimpiarControlesOtrosIngresos();
            this.pmtdLimpiarControlesAbonoPrestamos();
            this.pmtdLimpiarControlesAbonoaVenta();
            this.pmtdLimpiarControlesAbonoaDeuda();
        }

        /// <summary> Limpia los controles del encabezado del formulario. </summary>
        private void pmtdLimpiarControlesPrincipal()
        {
            this.txtIngreso.Text = "0";
            this.txtCodigo.Text = "0";
            this.txtCedula.Text = "0";
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.txtMesActual.Text = DateTime.Now.Month.ToString();
            this.txtMesesPagados.Text = "0";
            this.txtGranTotal.Text = "0";
            this.txtNombre.BackColor = Color.White;
            this.txtApellido.BackColor = Color.White;
            //this.rptRecibos.Visible = false;
        }

        /// <summary> Limpia los controles de las cuotas exequiales. </summary>
        private void pmtdLimpiarControlesCuotasExequiales()
        {
            this.txtCodServicio.Text = "";
            this.txtNomServicio.Text = "";
            this.txtAño.Text = "0";
            this.txtCuota.Text = "0";
            this.txtTipo.Text = "0";
            this.txtAdultos.Text = "0";
            this.txtCuotaAdulto.Text = "0";
            this.txtCantidad.Text = "0";
            this.txtDescuento.Text = "0";
            this.txtTotalCuotas.Text = "0";
            this.chkCuotas.Checked = false;
            this.dgvAgraciados.AutoGenerateColumns = false;
            this.dgvAgraciados.DataSource = new blAgraciado().gmtdConsultar(0);
            this.dtpFechaRec.Value = Convert.ToDateTime("1900/01/01");
        }

        /// <summary> Limpia los controles de las cuotas de los pr[estamos. </summary>
        private void pmtdLimpiarControlesCuotasPrestamos()
        {
            this.cboPrestamo.Items.Clear();
            this.txtCuotasPendientes.Text = "0";
            this.txtCuotasaPagar.Text = "0";
            this.txtTotalPrestamos.Text = "0";
            this.chkPrestamos.Checked = false;
            List<tblCredito> lstCreditos = new blRecibosIngresosPrestamos().gmtdConsultaCreditosParaRecibo("-1");
            this.dgvPrestamosCuotas.AutoGenerateColumns = false;
            var query = from dato in lstCreditos
                        select dato.intCodigoCre;
            this.dgvPrestamosCuotas.DataSource = query.ToList();
        }

        /// <summary> Limpia los controles de la de ahorros a la vista. </summary>
        private void pmtdLimpiarControlesAhorrosalaVista()
        {
            this.chkAhorroalaVista.Checked = false;
            this.chk4xMil.Checked = false;
            this.txtAhorrado.Text = "0";
            this.txtAhorrar.Text = "0";
            this.dgvAhorrosalaVista.AutoGenerateColumns = false;
            this.dgvAhorrosalaVista.DataSource = new blRecibosIngresosAhorros().gmtdConsultarTransacciones("-1");
        }

        /// <summary> Limpia los controles de la de ahorros estudiantil. </summary>
        private void pmtdLimpiarControlesAhorrosEstudiantil()
        {
            this.chkAhorrosEstudiantil.Checked = false;
            this.txtAhorradoEstudiantil.Text = "0";
            this.txtAhorrarEstudiantil.Text = "0";
            this.dgvAhorrosEstudiantil.AutoGenerateColumns = false;
            this.dgvAhorrosEstudiantil.DataSource = new blRecibosIngresosAhorros().gmtdConsultarTransaccionesEstudiantiles("-1");
        }

        /// <summary> Limpia los controles de la de ahorros navideño. </summary>
        private void pmtdLimpiarControlesAhorrosNavideño()
        {
            this.chkAhorrosNavideños.Checked = false;
            this.txtPendientesNavideños.Text = "0";
            this.txtValorCuotaNavideño.Text = "0";
            this.txtCuotasNavideñas.Text = "0";
            this.txtTotalAhorroNavideño.Text = "0";
            this.dgvAhorrosNavideños.AutoGenerateColumns = false;
            this.dgvAhorrosNavideños.DataSource = new blAhorrosNavideno().gmtdConsultarCuotasPendentes("-1", 0);
        }

        /// <summary> Limpia los controles de la de ahorros navideño. </summary>
        private void pmtdLimpiarControlesAhorrosNatilleraEscolar()
        {
            this.chkAhorrosNatilleraEscolar.Checked = false;
            this.txtPendientesNatilleraEscolar.Text = "0";
            this.txtValorCuotaNatilleraEscolar.Text = "0";
            this.txtCuotasNatilleraEscolar.Text = "0";
            this.txtTotalAhorroNatilleraEscolar.Text = "0";
            this.dgvAhorrosNatilleraEscolar.AutoGenerateColumns = false;
            this.dgvAhorrosNatilleraEscolar.DataSource = new blAhorrosNatilleraEscolar().gmtdConsultarCuotasPendentes("-1", 0);
        }

        /// <summary> Limpia los controles de la de ahorros a futuro. </summary>
        private void pmtdLimpiarControlesAhorrosaFuturo()
        {
            this.chkAhorrosaFuturo.Checked = false;
            this.txtPendientesaFuturo.Text = "0";
            this.txtValorCuotaaFuturo.Text = "0";
            this.txtCuotasaFuturo.Text = "0";
            this.txtTotalAhorroaFuturo.Text = "0";
            this.dgvAhorrosaFuturo.AutoGenerateColumns = false;
            this.dgvAhorrosaFuturo.DataSource = new blAhorrosNavideno().gmtdConsultarCuotasPendentes("-1", 0);
        }

        /// <summary> Limpia los controles de la de ahorros a la vista. </summary>
        private void pmtdLimpiarControlesAhorrosFijo()
        {
            this.chkAhorrosFijos.Checked = false;
            this.txtAhorradoFijo.Text = "0";
            this.txtAhorrarFijo.Text = "0";
            this.dgvAhorrosFijo.AutoGenerateColumns = false;
            this.dgvAhorrosFijo.DataSource = new blRecibosIngresosAhorros().gmtdConsultarTransaccionesFijas("-1");
        }

        /// <summary> Limpia los controles de otros ingresos. </summary>
        private void pmtdLimpiarControlesOtrosIngresos()
        {
            this.dgvOtrosIngresos.Rows.Clear();

            this.cboOtrosIngresos.SelectedIndex = 0;
            this.txtDescripcionOtroIngreso.Text = "";
            this.txtValorOtrosIngresos.Text = "0";
            this.txtTotalOtrosIngresos.Text = "0";
        }

        /// <summary> Limpia los controles de l0s abonos a préstamo. </summary>
        private void pmtdLimpiarControlesAbonoPrestamos()
        {
            this.cboPrestamosAbono.Items.Clear();
            this.txtValoraAbonarPrestamo.Text = "0";
            this.chkAbonoaPrestamo.Checked = false;
        }

        /// <summary> Limpia los controles de los abonos a venta. </summary>
        private void pmtdLimpiarControlesAbonoaVenta()
        {
            this.txtDebeVenta.Text = "0";
            this.txtAbonaVenta.Text = "0";
            this.chkVentas.Checked = false;
        }

        /// <summary> Limpia los controles de los abonos a venta. </summary>
        private void pmtdLimpiarControlesAbonoaDeuda()
        {
            this.txtDebeDeuda.Text = "0";
            this.txtAbonaDeuda.Text = "0";
            this.txtDebeDeuda1.Text = "0";
            this.txtAbonaDeuda1.Text = "0";
            this.chkDeudas.Checked = false;
        }

        #endregion       2

        #region habilitarControles

        private void pmtdHabilitarControles(bool bitA)
        {
            this.pmtdHabilitarControlesPrincipal(bitA);
            this.pmtdHabilitarControlesCuotasExequiales(bitA);
            this.pmtdHabilitarControlesCuotasPrestamos(bitA);
            this.pmtdHabilitarControlesAhorrosalaVista(bitA);
            this.pmtdHabilitarControlesAhorrosEstudiantil(bitA);
            this.pmtdHabilitarControlesAhorrosNavideños(bitA);
            this.pmtdHabilitarControlesAhorrosaFuturo(bitA);
            this.pmtdHabilitarControlesAhorrosFijo(bitA);
            this.pmtdHabilitarControlesOtrosIngresos(bitA);
            this.pmtdHabilitarControlesAbonoaPrestamos(bitA);
            this.pmtdHabilitarControlesAbonoaVentas(bitA);
            this.pmtdHabilitarControlesAbonoaDeuda(bitA);
        }

        /// <summary> Habilita los controles modificables del encabezado del formulario. </summary>
        /// <param name="bitA"> Un valor boleano que habilitara o deshabilitara los controles. </param>
        private void pmtdHabilitarControlesPrincipal(bool bitA)
        {
            this.txtIngreso.Enabled = bitA;
            //this.txtCodigo.Enabled = bitA;
            this.txtCedula.Enabled = bitA;
        }

        /// <summary> Habilita los controles modificables de las cuotas exequiales. </summary>
        /// <param name="bitA"> Un valor boleano que habilitara o deshabilitara los controles. </param>
        private void pmtdHabilitarControlesCuotasExequiales(bool bitA)
        {
            this.txtCantidad.Enabled = bitA;
            this.txtDescuento.Enabled = bitA;
            this.chkCuotas.Enabled = bitA;
            this.dtpFechaRec.Enabled = bitA;
        }

        /// <summary> Habilita los controles de las cuotas de prestamos. </summary>
        /// <param name="bitA"> Un valor boleano que habilitara o deshabilitara los controles. </param>
        private void pmtdHabilitarControlesCuotasPrestamos(bool bitA)
        {
            this.cboPrestamo.Enabled = bitA;
            this.txtCuotasaPagar.Enabled = bitA;
            this.txtTotalPrestamos.Enabled = bitA;
            this.chkPrestamos.Enabled = bitA;
        }

        /// <summary> Habilita o deshabilita los controles de los recibos de ahorro a la vista. </summary>
        /// <param name="bitA"> Valor que indica si se habilita o deshabilita los controles. </param>
        private void pmtdHabilitarControlesAhorrosalaVista(bool bitA)
        {
            this.txtAhorrar.Enabled = bitA;
            this.chkAhorroalaVista.Enabled = bitA;
        }

        /// <summary> Habilita o deshabilita los controles de los recibos de ahorro estudiantil. </summary>
        /// <param name="bitA"> Valor que indica si se habilita o deshabilita los controles. </param>
        private void pmtdHabilitarControlesAhorrosEstudiantil(bool bitA)
        {
            this.txtAhorrarEstudiantil.Enabled = bitA;
            this.chkAhorrosEstudiantil.Enabled = bitA;
        }

        /// <summary> Habilita o deshabilita los controles de los recibos de ahorro navideño. </summary>
        /// <param name="bitA"> Valor que indica si se habilita o deshabilita los controles. </param>
        private void pmtdHabilitarControlesAhorrosNavideños(bool bitA)
        {
            this.txtCuotasNavideñas.Enabled = bitA;
            this.chkAhorrosNavideños.Enabled = bitA;
        }

        /// <summary> Habilita o deshabilita los controles de los recibos de ahorro a futuro. </summary>
        /// <param name="bitA"> Valor que indica si se habilita o deshabilita los controles. </param>
        private void pmtdHabilitarControlesAhorrosaFuturo(bool bitA)
        {
            this.txtCuotasaFuturo.Enabled = bitA;
            this.chkAhorrosaFuturo.Enabled = bitA;
        }

        /// <summary> Habilita o deshabilita los controles de los recibos de ahorro a futuro. </summary>
        /// <param name="bitA"> Valor que indica si se habilita o deshabilita los controles. </param>
        private void pmtdHabilitarControlesAhorrosNatilleraEscolar(bool bitA)
        {
            this.txtCuotasNatilleraEscolar.Enabled = bitA;
            this.chkAhorrosNatilleraEscolar.Enabled = bitA;
        }

        /// <summary> Habilita o deshabilita los controles de los recibos de ahorro Fijo. </summary>
        /// <param name="bitA"> Valor que indica si se habilita o deshabilita los controles. </param>
        private void pmtdHabilitarControlesAhorrosFijo(bool bitA)
        {
            this.txtAhorrarFijo.Enabled = bitA;
            this.chkAhorrosFijos.Enabled = bitA;
        }

        /// <summary> Habilita o deshabilita los controles de los recibos de Otros Ingresos. </summary>
        /// <param name="bitA"> Valor que indica si se habilita o deshabilita los controles. </param>
        private void pmtdHabilitarControlesOtrosIngresos(bool bitA)
        {
            this.chkOtrosIngresos.Enabled = bitA;
            this.cboOtrosIngresos.Enabled = bitA;
            this.txtDescripcionOtroIngreso.Enabled = bitA;
            this.txtValorOtrosIngresos.Enabled = bitA;
            this.txtTotalOtrosIngresos.Enabled = bitA;
            this.btnAgregarOtrosIngresos.Enabled = bitA;
            this.btnEliminarOtrosIngresos.Enabled = bitA;
        }

        /// <summary> Habilita los controles de los abono a prestamo. </summary>
        /// <param name="bitA"> Un valor boleano que habilitara o deshabilitara los controles. </param>
        private void pmtdHabilitarControlesAbonoaPrestamos(bool bitA)
        {
            this.cboPrestamosAbono.Enabled = bitA;
            this.txtValoraAbonarPrestamo.Enabled = bitA;
            this.chkAbonoaPrestamo.Enabled = bitA;
        }

        /// <summary> Habilita los controles de los abono a venta. </summary>
        /// <param name="bitA"> Un valor boleano que habilitara o deshabilitara los controles. </param>
        private void pmtdHabilitarControlesAbonoaVentas(bool bitA)
        {
            this.cboVenta.Enabled = bitA;
            this.txtAbonaVenta.Enabled = bitA;
            this.chkVentas.Enabled = bitA;
        }

        /// <summary> Habilita los controles de los abono a deuda. </summary>
        /// <param name="bitA"> Un valor boleano que habilitara o deshabilitara los controles. </param>
        private void pmtdHabilitarControlesAbonoaDeuda(bool bitA)
        {
            this.cboDeudas.Enabled = bitA;
            this.txtAbonaDeuda.Enabled = bitA;
            this.chkDeudas.Enabled = bitA;
            this.cboDeudas1.Enabled = bitA;
            this.txtAbonaDeuda1.Enabled = bitA;
            this.chkDeudas.Enabled = bitA;
        }
        #endregion

        #region Objetos

        #endregion

        #region propiedades

        #endregion

    }
}
