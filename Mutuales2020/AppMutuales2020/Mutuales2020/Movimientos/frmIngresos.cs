namespace Mutuales2020.Movimientos
{
    using libMutuales2020.dominio;
    using libMutuales2020.Facade;
    using libMutuales2020.logica;
    using Microsoft.Reporting.WinForms;
    using Mutuales2020.Personas;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    public partial class frmIngresos : Form
    {
        List<Agraciado> lstAgraciados = new List<Agraciado>();
        int intFilaSeleccionadaGridCuotasPrestamo = 0;
        List<otrosIngresos> lstListaOtrosIngreos = new List<otrosIngresos>();
        List<Deuda> lstDeudasUno = new List<Deuda>();
        List<Deuda> lstDeudasDos = new List<Deuda>();
        tblIngreso ingresoConsultado = new tblIngreso();
        bool bitEliminar = false;
        tblConfiguracione objConfiguracion;

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

        /// <summary> Pinta de color rojo las filas en donde al agraciado no se le ha actualizado los datos. </summary>
        public void pmtdPintarGridAgraciados()
        {
            for (int a = 0; a < this.dgvAgraciados.Rows.Count; a++)
            {
                if (Convert.ToBoolean(this.dgvAgraciados.Rows[a].Cells[2].Value) == false)
                {
                    DataGridViewCellStyle estilo = new DataGridViewCellStyle();
                    estilo.BackColor = Color.Red;
                    this.dgvAgraciados.Rows[a].Cells[0].Style = estilo;
                    this.dgvAgraciados.Rows[a].Cells[1].Style = estilo;
                }
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
            if (propiedades.bitConsultar == true)
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

        private void gmtdMostrarReciboTransacciones()
        {
            List<SqlParameter> lstParameters = new List<SqlParameter>();
            SqlParameter parametro = new SqlParameter("@intCodigoRec", SqlDbType.Int);
            parametro.Value = this.txtIngreso.Text;
            lstParameters.Add(parametro);
            parametro = new SqlParameter("@strTransaccion", SqlDbType.VarChar);
            parametro.Value = "Ahorro";
            lstParameters.Add(parametro);
            DataSet ds = new DataSet();
            ds = propiedades.ejecutarSp(lstParameters, "spImprimirReciboTransacciones");
            ReportDataSource datasource;
            datasource = new ReportDataSource("spImprimirReciboTransacciones_spImprimirReciboTransacciones", ds.Tables[0]);

            List<Microsoft.Reporting.WinForms.ReportParameter> lstParametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Recibo", this.txtIngreso.Text);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("nombreMutual", propiedades.strNombreMutual);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Telefono", propiedades.strNit);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Personeria", propiedades.strPersoneria);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("SaldoAnterior", this.txtAhorrado.Text);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Transaccion", "Ahorro");
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Acumula", this.txtNomServicio.Text);
            lstParametros.Add(parametroReporte);

            rptRecibos.Reset();
            rptRecibos.Visible = true;
            rptRecibos.Left = 0;
            rptRecibos.Top = 0;
            rptRecibos.Height = 312;
            rptRecibos.Width = 810;
            rptRecibos.ProcessingMode = ProcessingMode.Local;
            rptRecibos.LocalReport.DataSources.Clear();
            rptRecibos.LocalReport.DataSources.Add(datasource);
            rptRecibos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Movimientos.Reportes.rptTransacciones.rdlc";
            rptRecibos.LocalReport.SetParameters(lstParametros);
            rptRecibos.LocalReport.Refresh();

            this.rptRecibos.RefreshReport();
        }

        /// <summary> Ejecuta un store procedure de Sql. </summary>
        /// <param name="tlstParametros"> Lista de parametros para el sp. </param>
        /// <param name="tstrNombreSp">Nombre del sp. </param>
        /// <returns>Un dataset con los datos consultados. </returns>
        public DataSet ejecutarSp(List<SqlParameter> tlstParametros, string tstrNombreSp)
        {
            SqlConnection Conecction = new SqlConnection(propiedades.strConexionDatos);
            SqlCommand comando = new SqlCommand(tstrNombreSp, Conecction);
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandTimeout = 0;

            foreach (SqlParameter parametro in tlstParametros)
                comando.Parameters.Add(parametro);

            DataSet DataSet = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(DataSet);
            return DataSet;
        }

        private void gmtdMostrarReciboIngreso()
        {
            List<SqlParameter> lstParameters = new List<SqlParameter>();
            SqlParameter parametro = new SqlParameter("@intCodigoRec", SqlDbType.Int);
            parametro.Value = this.txtIngreso.Text;
            lstParameters.Add(parametro);
            DataSet ds = new DataSet();
            ds = propiedades.ejecutarSp(lstParameters, "spImprimirRecibosdeIngresos");
            //ds = this.ejecutarSp(lstParameters, "spImprimirRecibosdeIngresos");
            ReportDataSource datasource;
            datasource = new ReportDataSource("spImprimirRecibosdeIngresos_spImprimirRecibosdeIngresos", ds.Tables[0]);

            List<Microsoft.Reporting.WinForms.ReportParameter> lstParametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Recibo", this.txtIngreso.Text);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("nombreMutual", propiedades.strNombreMutual);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Telefono", propiedades.strNit);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Personeria", propiedades.strPersoneria);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Socio", this.txtCodigo.Text);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Plan", this.txtNomServicio.Text);
            lstParametros.Add(parametroReporte);

            rptRecibos.Reset();
            rptRecibos.Visible = true;
            rptRecibos.Left = 0;
            rptRecibos.Top = 0;
            rptRecibos.Height = 312;
            rptRecibos.Width = 810;
            rptRecibos.ProcessingMode = ProcessingMode.Local;
            rptRecibos.LocalReport.DataSources.Clear();
            rptRecibos.LocalReport.DataSources.Add(datasource);
            rptRecibos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Movimientos.Reportes.rptIngresos.rdlc";
            rptRecibos.LocalReport.SetParameters(lstParametros);
            rptRecibos.LocalReport.Refresh();

            this.rptRecibos.RefreshReport();
        }

        private void gmtdMostrarReciboIngreso20Julio()
        {
            List<SqlParameter> lstParameters = new List<SqlParameter>();
            SqlParameter parametro = new SqlParameter("@intCodigoRec", SqlDbType.Int);
            parametro.Value = this.txtIngreso.Text;
            lstParameters.Add(parametro);
            DataSet ds = new DataSet();
            ds = propiedades.ejecutarSp(lstParameters, "spImprimirRecibosdeIngresos20deJulio");

            ReportDataSource datasource;
            datasource = new ReportDataSource("spImprimirRecibosdeIngresos_spImprimirRecibosdeIngresos", ds.Tables[0]);

            List<Microsoft.Reporting.WinForms.ReportParameter> lstParametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Recibo", this.txtIngreso.Text);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("nombreMutual", propiedades.strNombreMutual);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Telefono", propiedades.strNit);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Personeria", propiedades.strPersoneria);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Socio", this.txtCodigo.Text);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Plan", this.txtNomServicio.Text);
            lstParametros.Add(parametroReporte);

            rptRecibos.Reset();
            rptRecibos.Visible = true;
            rptRecibos.Left = 0;
            rptRecibos.Top = 0;
            rptRecibos.Height = 312;
            rptRecibos.Width = 810;
            rptRecibos.ProcessingMode = ProcessingMode.Local;
            rptRecibos.LocalReport.DataSources.Clear();
            rptRecibos.LocalReport.DataSources.Add(datasource);
            rptRecibos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Movimientos.Reportes.rptIngresos20deJulio.rdlc";
            rptRecibos.LocalReport.SetParameters(lstParametros);
            rptRecibos.LocalReport.Refresh();

            this.rptRecibos.RefreshReport();
        }

        public frmIngresos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((this.txtCodigo.Text.Trim() == "" || this.txtCodigo.Text.Trim() == "0"
                && this.txtCedula.Text.Trim() == "0" || this.txtCedula.Text.Trim() == "")
                || this.txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe de ingresar el código del socio o el número de la cédula. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.chkCuotas.Checked == false && this.chkPrestamos.Checked == false 
                && this.chkAhorroalaVista.Checked == false && this.chkAhorrosEstudiantil.Checked == false
                && this.chkAhorrosNavideños.Checked == false && this.chkAhorrosaFuturo.Checked == false
                && this.chkAhorrosFijos.Checked == false && this.chkAhorrosNatilleraEscolar.Checked == false 
                && this.chkOtrosIngresos.Checked == false && this.chkAbonoaPrestamo.Checked == false
                && this.chkVentas.Checked == false && this.chkDeudas.Checked == false)
            {
                MessageBox.Show("Debe de seleccionar un tipo de recibo a realizar.");
                return;
            }

            tblIngreso ingreso = new tblIngreso();
            ingreso.dtmFechaAnu = Convert.ToDateTime("1/1/1900");
            ingreso.dtmFechaRec = new blConfiguracion().gmtdCapturarFechadelServidor();
            ingreso.strNombreIng = this.txtNombre.Text;
            ingreso.strApellidoIng = this.txtApellido.Text;
            ingreso.strCedulaIng = this.txtCedula.Text;
            ingreso.strFormulario = this.Name;
            ingreso.strLetras = new blConfiguracion().montoenLetras(this.txtGranTotal.Text);
            ingreso.decTotalIng = Convert.ToDecimal(this.txtGranTotal.Text);
            ingreso.strComputador = Environment.MachineName;
            ingreso.strUsuario = propiedades.strLogin;

            #region recibosCuotas
            if (this.chkCuotas.Checked)
            {
                if (this.txtCodServicio.Text.Trim() == "" || this.txtNomServicio.Text.Trim() == ""
                    || this.txtAño.Text.Trim() == "" || this.txtTipo.Text.Trim() == ""
                    || this.txtCuota.Text.Trim() == "" || this.txtAdultos.Text.Trim() == ""
                    || this.txtCuotaAdulto.Text.Trim() == "")
                {
                    MessageBox.Show("Faltan datos del socio por ingresar. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Convert.ToInt32(this.txtCantidad.Text) <= 0)
                {
                    MessageBox.Show("Debe de ingresar el número de cuotas a pagar. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                tblSocio socio = new tblSocio();
                socio.intCodigoSoc = Convert.ToInt16(this.txtCodigo.Text); ;

                tblIngresosCuota ingresoCuota = new tblIngresosCuota();
                ingresoCuota.decDescuento = Convert.ToDecimal(this.txtDescuento.Text);
                ingresoCuota.dtmFechaRes = this.dtpFechaRec.Value;
                ingresoCuota.intAdultos = Convert.ToInt32(this.txtAdultos.Text);
                ingresoCuota.intAño = Convert.ToInt32(this.txtAño.Text);
                ingresoCuota.intCantidad = Convert.ToInt32(this.txtCantidad.Text); 
                ingresoCuota.intCodigoSoc = Convert.ToInt32(this.txtCodigo.Text);
                ingresoCuota.intCuotaAdultos = Convert.ToInt32(this.txtCuotaAdulto.Text);
                ingresoCuota.intMesActual = Convert.ToInt32(this.txtMesActual.Text);
                ingresoCuota.intMesesCancelados = Convert.ToInt32(this.txtMesesPagados.Text) + Convert.ToInt32(this.txtCantidad.Text);
                if (this.txtTipo.Text.ToUpper() == "UNICO")
                {
                    ingresoCuota.intTotal = Convert.ToInt32(this.txtCuota.Text) * (Convert.ToInt32(this.txtCantidad.Text) + (this.dgvAgraciados.Rows.Count * Convert.ToInt32(this.txtCantidad.Text)));
                }
                else
                {
                    ingresoCuota.intTotal = Convert.ToInt32(this.txtCuota.Text) * Convert.ToInt32(this.txtCantidad.Text);
                }
                ingresoCuota.strCodServiciop = this.txtCodServicio.Text;
                if (objConfiguracion.intTipoCobro == 1)
                {
                    ingresoCuota.strMeses = this.pmtdMesesCancelados(Convert.ToInt16(this.txtMesesPagados.Text), ingresoCuota.intMesesCancelados);
                    ingresoCuota.strMesFinal = strUltimoMes + " de " + this.txtAño.Text;
                }
                else
                {
                    List<tblQuincena> lstQuincenas = new fConfiguracion().gmtdConsultarQuincenas(ingresoCuota.intAño);

                    ingresoCuota.strMeses = "";
                    ingresoCuota.strMesFinal = "Queda cancelado hasta " + lstQuincenas[ingresoCuota.intMesesCancelados - 1].dtmFechaQui.ToShortDateString();
                }
                ingresoCuota.socio = socio;

                ingreso.ingresoCuota = ingresoCuota;
                ingreso.bitCuota = true;
            }
            #endregion

            #region recibosPrestamos
            if (this.chkPrestamos.Checked == true)
            { 
                if(this.cboPrestamo.Text.Trim() == "")
                {
                    MessageBox.Show("Debe de escojer el credito al que le desea hacer el abono de cuotas. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.txtCuotasPendientes.Text.Trim() == "" || this.txtCuotasPendientes.Text.Trim() == "0")
                {
                    MessageBox.Show("Debe de escojer el credito al que le desea hacer el abono de cuotas. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.txtCuotasaPagar.Text.Trim() == "" || this.txtCuotasaPagar.Text.Trim() == "0")
                {
                    MessageBox.Show("Debe de ingresar el número de cuotas a pagar. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.dgvPrestamosCuotas.RowCount <= 0)
                {
                    MessageBox.Show("Debe ingresar el número de cuotas en la lista. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.dgvPrestamosCuotas.RowCount > 3)
                {
                    MessageBox.Show("No puede pagar mas de 3 cuotas por recibo. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                List<tblIngresosPrestamo> lstCuotas = new List<tblIngresosPrestamo>();

                for (int a = 0; a < this.dgvPrestamosCuotas.RowCount; a++)
                {
                    tblIngresosPrestamo cuota = new tblIngresosPrestamo();
                    cuota.decCapital = (decimal)this.dgvPrestamosCuotas[1, a].Value;
                    cuota.decCausado = (decimal)this.dgvPrestamosCuotas[5, a].Value;
                    cuota.decDebioPagar = (decimal)this.dgvPrestamosCuotas[7, a].Value;
                    cuota.decInteres = (decimal)this.dgvPrestamosCuotas[2, a].Value;
                    cuota.decMora = (decimal)this.dgvPrestamosCuotas[3, a].Value;
                    cuota.decPago = (decimal)this.dgvPrestamosCuotas[6, a].Value;
                    cuota.intCodigoPre = Convert.ToInt32(this.cboPrestamo.Text);
                    cuota.intCuota = Convert.ToInt32(this.dgvPrestamosCuotas[0, a].Value);
                    cuota.intMesesAtrasados = Convert.ToInt32(this.dgvPrestamosCuotas[4, a].Value);
                    lstCuotas.Add(cuota);
                }

                ingreso.bitPrestamo = true;
                ingreso.ingresoPrestamo = lstCuotas;
            }
            #endregion

            #region AhorrosalaVista
            if (this.chkAhorroalaVista.Checked == true)
            {
                if (Convert.ToDecimal(this.txtAhorrar.Text) <= 0)
                {
                    MessageBox.Show("Debe de ingresar el valor del ahorro. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                tblIngresosAhorro objIngresoAhorro = new tblIngresosAhorro();
                objIngresoAhorro.decAhorrado = Convert.ToDecimal(this.txtAhorrado.Text);
                objIngresoAhorro.decAhorro = Convert.ToDecimal(this.txtAhorrar.Text);
                objIngresoAhorro.decAcumula = objIngresoAhorro.decAhorrado + objIngresoAhorro.decAhorro;
                objIngresoAhorro.bitCobraCuatroxMil = this.chk4xMil.Checked;

                ingreso.bitAhorro = true;
                ingreso.ingresoAhorro = objIngresoAhorro;
            }
            #endregion

            #region AhorrosEstudiantiles
            if (this.chkAhorrosEstudiantil.Checked == true)
            {
                if (Convert.ToDecimal(this.txtAhorrarEstudiantil.Text) <= 0)
                {
                    MessageBox.Show("Debe de ingresar el valor del ahorro estudiantil. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                tblIngresosAhorrosEstudiantil ingresoAhorroEstudiantil = new tblIngresosAhorrosEstudiantil();
                ingresoAhorroEstudiantil.decAhorrado = Convert.ToDecimal(this.txtAhorradoEstudiantil.Text);
                ingresoAhorroEstudiantil.decAhorro = Convert.ToDecimal(this.txtAhorrarEstudiantil.Text);
                ingresoAhorroEstudiantil.decAcumula = ingresoAhorroEstudiantil.decAhorrado + ingresoAhorroEstudiantil.decAhorro;

                ingreso.bitAhorroEstudiante = true;
                ingreso.ingresoAhorroEstudiantil = ingresoAhorroEstudiantil;
            }
            #endregion

            #region AhorrosFijo
            if (this.chkAhorrosFijos.Checked == true)
            {
                if (Convert.ToDecimal(this.txtAhorrarFijo.Text) <= 0)
                {
                    MessageBox.Show("Debe de ingresar el valor del ahorro fijo. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                tblIngresosAhorrosFijo ingresoAhorroFijo = new tblIngresosAhorrosFijo();
                ingresoAhorroFijo.decAhorrado = Convert.ToDecimal(this.txtAhorradoFijo.Text);
                ingresoAhorroFijo.decAhorro = Convert.ToDecimal(this.txtAhorrarFijo.Text);
                ingresoAhorroFijo.decAcumula = ingresoAhorroFijo.decAhorrado + ingresoAhorroFijo.decAhorro;

                ingreso.bitAhorroFijo = true;
                ingreso.ingresoAhorroFijo = ingresoAhorroFijo;
            }
            #endregion

            #region AhorrosNavideños
            if (this.chkAhorrosNavideños.Checked == true)
            {

                if (this.txtCuotasNavideñas.Text.Trim() == "" || this.txtCuotasNavideñas.Text.Trim() == "0")
                {
                    MessageBox.Show("Debe de escojer el número de cuotas de ahorro navideño a pagar. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.txtTotalAhorroNavideño.Text.Trim() == "" || this.txtTotalAhorroNavideño.Text.Trim() == "0")
                {
                    MessageBox.Show("Debe de escojer el número de cuotas de ahorro navideño a pagar. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.dgvAhorrosNavideños.RowCount <= 0)
                {
                    MessageBox.Show("Debe de escojer el número de cuotas de ahorro navideño a pagar. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                List<tblIngresosAhorrosNavideno> lstIngresoNavideño = new List<tblIngresosAhorrosNavideno>();
                for (int a = 0; a < this.dgvAhorrosNavideños.RowCount; a++)
                {
                    tblIngresosAhorrosNavideno ingresoNavideño = new tblIngresosAhorrosNavideno();
                    ingresoNavideño.decValorCuo = (decimal)this.dgvAhorrosNavideños[2, a].Value;
                    ingresoNavideño.strCuenta = this.txtCuentaNavideño.Text;
                    ingresoNavideño.dtmFechaCuo = (DateTime)this.dgvAhorrosNavideños[1, a].Value;
                    ingresoNavideño.intCuotasPagadas = Convert.ToInt32(this.txtCuotasNavideñas.Text);
                    ingresoNavideño.intCuotasPendientes = Convert.ToInt32(this.txtPendientesNavideños.Text);
                    lstIngresoNavideño.Add(ingresoNavideño);

                }
                ingreso.bitAhorroNavideno = true;
                ingreso.ingresoAhorroNavideño = lstIngresoNavideño;

            }
            #endregion

            #region AhorrosNatilleraEscolar
            if (this.chkAhorrosNatilleraEscolar.Checked == true)
            {

                if (this.txtCuotasNatilleraEscolar.Text.Trim() == "" || this.txtCuotasNatilleraEscolar.Text.Trim() == "0")
                {
                    MessageBox.Show("Debe de escojer el número de cuotas de ahorro natillera escolar a pagar. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.txtTotalAhorroNatilleraEscolar.Text.Trim() == "" || this.txtTotalAhorroNatilleraEscolar.Text.Trim() == "0")
                {
                    MessageBox.Show("Debe de escojer el número de cuotas de ahorro natillera escolar a pagar. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.dgvAhorrosNatilleraEscolar.RowCount <= 0)
                {
                    MessageBox.Show("Debe de escojer el número de cuotas de ahorro natillera escolar a pagar. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                List<tblIngresosAhorrosNatilleraEscolar> lstIngresoNatilleraEscolar = new List<tblIngresosAhorrosNatilleraEscolar>();
                for (int a = 0; a < this.dgvAhorrosNatilleraEscolar.RowCount; a++)
                {
                    tblIngresosAhorrosNatilleraEscolar ingresoNatilleraEscolar = new tblIngresosAhorrosNatilleraEscolar();
                    ingresoNatilleraEscolar.decValorCuo = (decimal)this.dgvAhorrosNatilleraEscolar[2, a].Value;
                    ingresoNatilleraEscolar.strCuenta = this.txtCuentaNatilleraEscolar.Text;
                    ingresoNatilleraEscolar.dtmFechaCuo = (DateTime)this.dgvAhorrosNatilleraEscolar[1, a].Value;
                    ingresoNatilleraEscolar.intCuotasPagadas = Convert.ToInt32(this.txtCuotasNatilleraEscolar.Text);
                    ingresoNatilleraEscolar.intCuotasPendientes = Convert.ToInt32(this.txtPendientesNatilleraEscolar.Text);
                    lstIngresoNatilleraEscolar.Add(ingresoNatilleraEscolar);

                }
                ingreso.bitAhorroNatilleraEscolar = true;
                ingreso.ingresoAhorroNatilleraEscolar = lstIngresoNatilleraEscolar;

            }
            #endregion

            #region AhorrosaFuturo
            if (this.chkAhorrosaFuturo.Checked == true)
            {

                if (this.txtCuotasaFuturo.Text.Trim() == "" || this.txtCuotasaFuturo.Text.Trim() == "0")
                {
                    MessageBox.Show("Debe de escojer el número de cuotas de ahorro a futuro a pagar. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.txtTotalAhorroaFuturo.Text.Trim() == "" || this.txtTotalAhorroaFuturo.Text.Trim() == "0")
                {
                    MessageBox.Show("Debe de escojer el número de cuotas de ahorro a futuro a pagar. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.dgvAhorrosaFuturo.RowCount <= 0)
                {
                    MessageBox.Show("Debe de escojer el número de cuotas de ahorro a futuro a pagar. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                List<tblIngresosAhorrosaFuturo> lstIngresoaFuturo = new List<tblIngresosAhorrosaFuturo>();
                for (int a = 0; a < this.dgvAhorrosaFuturo.RowCount; a++)
                {
                    tblIngresosAhorrosaFuturo ingresoaFuturo = new tblIngresosAhorrosaFuturo();
                    ingresoaFuturo.decValorCuo = (decimal)this.dgvAhorrosaFuturo[2, a].Value;
                    ingresoaFuturo.strCuenta = this.txtCuentaaFuturo.Text;
                    ingresoaFuturo.dtmFechaCuo = (DateTime)this.dgvAhorrosaFuturo[1, a].Value;
                    ingresoaFuturo.intCuotasPagadas = Convert.ToInt32(this.txtCuotasaFuturo.Text);
                    ingresoaFuturo.intCuotaPendientes = Convert.ToInt32(this.txtPendientesaFuturo.Text);
                    lstIngresoaFuturo.Add(ingresoaFuturo);

                }
                ingreso.bitAhorroaFuturo = true;
                ingreso.ingresoAhorroaFuturo = lstIngresoaFuturo;

            }
            #endregion

            #region otrosIngresos
            if (this.chkOtrosIngresos.Checked == true)
            {
                if (this.dgvOtrosIngresos.Rows.Count <= 1)
                {
                    MessageBox.Show("Debe de ingresar al menos un registro en otros ingresos. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.txtTotalOtrosIngresos.Text.Trim() == "" || this.txtTotalOtrosIngresos.Text.Trim() == "0")
                {
                    MessageBox.Show("Debe de escojer el número de cuotas de ahorro navideño a pagar. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                List<tblIngresosOtrosIngreso> lstIngresoOtrosIngresos = new List<tblIngresosOtrosIngreso>();
                for (int a = 0; a < this.dgvOtrosIngresos.RowCount -1; a++)
                {
                    tblIngresosOtrosIngreso otrosIngresos = new tblIngresosOtrosIngreso();
                    otrosIngresos.decValor = Convert.ToDecimal(this.dgvOtrosIngresos[2, a].Value);
                    otrosIngresos.strCodOtrosIngresos = this.dgvOtrosIngresos[0, a].Value.ToString();
                    otrosIngresos.strDescripcion = this.dgvOtrosIngresos[1, a].Value.ToString();
                    lstIngresoOtrosIngresos.Add(otrosIngresos);

                }
                ingreso.bitOtro = true;
                ingreso.ingresoOtrosIngresos = lstIngresoOtrosIngresos;

            }
            #endregion

            #region abonoaPrestamos
            if (this.chkAbonoaPrestamo.Checked == true)
            {
                if (this.txtValoraAbonarPrestamo.Text.Trim() == "" || this.txtValoraAbonarPrestamo.Text.Trim() == "0")
                {
                    MessageBox.Show("Debe ingresat el valor del abono a préstamo. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.cboPrestamosAbono.Items.Count <= 0 || this.cboPrestamosAbono.Text.Trim() == "")
                {
                    MessageBox.Show("Debe separa hacerle el abono. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                tblIngresosPrestamosAbono prestamoAbono = new tblIngresosPrestamosAbono();
                prestamoAbono.intCodigoCre = Convert.ToInt16(this.cboPrestamosAbono.Text);
                prestamoAbono.decAbonoPrestamo = Convert.ToDecimal(this.txtValoraAbonarPrestamo.Text);

                ingreso.bitPrestamoAbono = true;
                ingreso.ingresoAbonoaPrestamo = prestamoAbono;
            }
            #endregion

            #region abonoaVenta
            if (this.chkVentas.Checked == true)
            {
                if (this.txtAbonaVenta.Text.Trim() == "" || this.txtAbonaVenta.Text.Trim() == "0")
                {
                    MessageBox.Show("Debe ingresat el valor del abono a venta. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.cboVenta.Items.Count <= 0 || this.cboVenta.Text.Trim() == "")
                {
                    MessageBox.Show("Debe separa hacerle el abono. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Convert.ToDecimal(this.txtAbonaVenta.Text) > Convert.ToDecimal(this.txtDebeVenta.Text))
                {
                    MessageBox.Show("El valor a abonar no puede ser mayor al a deudao.", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtAbonaVenta.Text = "0";
                    return;
                }

                tblIngresosVenta ingresoVenta = new tblIngresosVenta();
                ingresoVenta.decAbona = Convert.ToDecimal(this.txtAbonaVenta.Text);
                ingresoVenta.decAdeuda = Convert.ToDecimal(this.txtDebeVenta.Text) - Convert.ToDecimal(this.txtAbonaVenta.Text);
                ingresoVenta.intCodVenta = Convert.ToInt32(this.cboVenta.Text);

                ingreso.bitVenta = true;
                ingreso.ingresoAbonoaVenta = ingresoVenta;
            }
            #endregion

            #region abonoaDeuda
            if (this.chkDeudas.Checked == true)
            {
                if (this.txtAbonaDeuda.Text.Trim() == "" || this.txtAbonaDeuda.Text.Trim() == "0")
                {
                    MessageBox.Show("Debe ingresat el valor del abono a la deuda. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.cboDeudas.Items.Count <= 0 || this.cboDeudas.Text.Trim() == "")
                {
                    MessageBox.Show("Debe seleccionar la deuda. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Convert.ToDecimal(this.txtAbonaDeuda.Text) > Convert.ToDecimal(this.txtDebeDeuda.Text))
                {
                    MessageBox.Show("El valor a abonar no puede ser mayor al a deudao.", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtAbonaDeuda.Text = "0";
                    return;
                }

                tblIngresosDeuda ingresoDeuda = new tblIngresosDeuda();
                ingresoDeuda.decAbona = Convert.ToDecimal(this.txtAbonaDeuda.Text);
                ingresoDeuda.decDebe = Convert.ToDecimal(this.txtDebeDeuda.Text);
                ingresoDeuda.decQueda = ingresoDeuda.decDebe - ingresoDeuda.decAbona;
                ingresoDeuda.intCodDeu = Convert.ToInt32(this.cboDeudas.SelectedValue);
                ingresoDeuda.strCedula = this.txtCedula.Text;

                ingreso.bitDeuda = true;
                ingreso.ingresoAbonoaDeuda = new List<tblIngresosDeuda>();
                ingreso.ingresoAbonoaDeuda.Add(ingresoDeuda);

                if (this.txtAbonaDeuda1.Text.Trim() != "" || this.txtAbonaDeuda1.Text.Trim() != "0")
                {

                    if (this.cboDeudas1.Items.Count <= 0 || this.cboDeudas1.Text.Trim() == "")
                    {
                        MessageBox.Show("Debe seleccionar la deuda. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (Convert.ToDecimal(this.txtAbonaDeuda1.Text) > Convert.ToDecimal(this.txtDebeDeuda1.Text))
                    {
                        MessageBox.Show("El valor a abonar no puede ser mayor al a deudao.", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txtAbonaDeuda.Text = "0";
                        return;
                    }

                    //if (this.cboDeudas1.Text.Trim() == this.cboDeudas.Text.Trim() && this.cboDeudas.Items.Count > 1)
                    //{
                    //    MessageBox.Show("Las deudas a abonar deben de ser iguales. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return;
                    //}

                    if (Convert.ToDecimal(this.txtAbonaDeuda1.Text) > 0)
                    {
                        ingresoDeuda = new tblIngresosDeuda();
                        ingresoDeuda.decAbona = Convert.ToDecimal(this.txtAbonaDeuda1.Text);
                        ingresoDeuda.decDebe = Convert.ToDecimal(this.txtDebeDeuda1.Text);
                        ingresoDeuda.decQueda = ingresoDeuda.decDebe - ingresoDeuda.decAbona;
                        ingresoDeuda.intCodDeu = Convert.ToInt32(this.cboDeudas1.SelectedValue);
                        ingresoDeuda.strCedula = this.txtCedula.Text;
                        ingreso.ingresoAbonoaDeuda.Add(ingresoDeuda);
                    }
                }
            }
            #endregion

            string strResultado = new blRecibosIngresos().gmtdInsertar(ingreso);

            if (strResultado.Substring(0, 1) == "-")
            {
                this.pmtdMensaje(strResultado, "Ingresos");
            }
            else
            {
                int intInicio = strResultado.LastIndexOf("#");
                int intFinal = strResultado.LastIndexOf("re");
                this.txtIngreso.Text = strResultado.Substring(0, strResultado.LastIndexOf("+")).Trim();

                if (ingreso.bitAhorro && objConfiguracion.intTipoCobro == 1)
                {
                    this.gmtdMostrarReciboTransacciones();
                }
                else
                {
                    if (objConfiguracion.intTipoCobro == 1)
                    {
                        this.gmtdMostrarReciboIngreso();
                    }
                    else 
                    {
                        this.gmtdMostrarReciboIngreso20Julio();
                    }
                }
            }

            this.pmtdLimpiarControles();

            this.pmtdHabilitarControles(false);
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            this.pmtdLimpiarControles();
            this.pmtdHabilitarControles(false);
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                recibosDatos datos;
                if (this.txtCodigo.Text.Trim() == "")
                {
                    MessageBox.Show("El socio no esta registrado en el sistema.", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Convert.ToInt32(this.txtCodigo.Text) != 0)
                    {
                        datos = new blRecibosIngresos().gmtdConsultarDatos(Convert.ToInt32(this.txtCodigo.Text));
                        if (datos.datosSocio.strApellido1Soc != null)
                        {
                            this.txtCedula.Text = datos.strCedula;
                            this.txtNombre.Text = datos.datosSocio.strNombreSoc;
                            this.txtApellido.Text = datos.datosSocio.strApellido1Soc + " " + datos.datosSocio.strApellido2Soc;
                            this.txtMesesPagados.Text = datos.datosSocio.intMeses.ToString();
                            this.txtCodServicio.Text = datos.datosSocio.strCodServiciop;
                            this.txtNomServicio.Text = datos.datosSocio.servicio.strNombreSpr;
                            this.txtAño.Text = datos.datosSocio.intAño.ToString();

                            if (datos.datosSocio.servicio.bitUnicoSpr == true)
                            {
                                this.txtTipo.Text = "Unico";
                            }
                            else
                            {
                                this.txtTipo.Text = "Normal";
                            }

                            this.txtCuota.Text = datos.datosSocio.servicio.intValorCuotaSpr.ToString();
                            this.txtAdultos.Text = datos.datosSocio.intAdultosMayores.ToString();
                            this.txtCuotaAdulto.Text = datos.datosSocio.intValorCuotaAdultoMayor.ToString();
                            this.pmtdHabilitarControlesCuotasExequiales(true);

                            lstAgraciados = new blAgraciado().gmtdConsultar(datos.intCodigoSoc);

                            this.dgvAgraciados.AutoGenerateColumns = false;
                            this.dgvAgraciados.DataSource = lstAgraciados;
                            this.pmtdPintarGridAgraciados();

                            if (datos.datosSocio.bitActualizado == false)
                            {
                                this.txtNombre.BackColor = Color.Red;
                                this.txtApellido.BackColor = Color.Red;

                                personasaModificar objPersona = new personasaModificar();
                                objPersona.dtmFechaNacimeinto = datos.datosSocio.dtmFechaNac;
                                objPersona.intCodigoSoc = datos.datosSocio.intCodigoSoc;
                                objPersona.strApellido1 = datos.datosSocio.strApellido1Soc;
                                objPersona.strApellido2 = datos.datosSocio.strApellido2Soc;
                                objPersona.strCedula = datos.datosSocio.strCedulaSoc;
                                objPersona.strDireccion = datos.datosSocio.strDireccion;
                                objPersona.strNombre = datos.datosSocio.strNombreSoc;
                                objPersona.strProcedencia = "Socio";
                                objPersona.strTelefono = datos.datosSocio.strTelefono;

                                FrmActualizarDatos actualizar = new FrmActualizarDatos(objPersona);
                                actualizar.ShowDialog();

                                this.pmtdHabilitarControles(false);
                                this.pmtdLimpiarControles();
                                this.txtCodigo.Enabled = true;
                                this.rptRecibos.Visible = false;
                                bitEliminar = false;
                                this.txtCodigo.Text = objPersona.intCodigoSoc.ToString();
                                this.txtCodigo.Focus();

                                datos = new blRecibosIngresos().gmtdConsultarDatos(Convert.ToInt32(this.txtCodigo.Text));

                                this.txtCedula.Text = datos.strCedula;
                                this.txtNombre.Text = datos.datosSocio.strNombreSoc;
                                this.txtApellido.Text = datos.datosSocio.strApellido1Soc + " " + datos.datosSocio.strApellido2Soc;
                                this.txtMesesPagados.Text = datos.datosSocio.intMeses.ToString();
                                this.txtCodServicio.Text = datos.datosSocio.strCodServiciop;
                                this.txtNomServicio.Text = datos.datosSocio.servicio.strNombreSpr;
                                this.txtAño.Text = datos.datosSocio.intAño.ToString();

                                if (datos.datosSocio.servicio.bitUnicoSpr == true)
                                {
                                    this.txtTipo.Text = "Unico";
                                }
                                else
                                {
                                    this.txtTipo.Text = "Normal";
                                }

                                this.txtCuota.Text = datos.datosSocio.servicio.intValorCuotaSpr.ToString();
                                this.txtAdultos.Text = datos.datosSocio.intAdultosMayores.ToString();
                                this.txtCuotaAdulto.Text = datos.datosSocio.intValorCuotaAdultoMayor.ToString();
                                this.pmtdHabilitarControlesCuotasExequiales(true);

                                lstAgraciados = new blAgraciado().gmtdConsultar(datos.intCodigoSoc);

                                this.dgvAgraciados.AutoGenerateColumns = false;
                                this.dgvAgraciados.DataSource = lstAgraciados;
                                this.pmtdPintarGridAgraciados();

                            }

                            this.chkCuotas.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Debe de ingresar el código del socio a consultar.", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                        //Datos de las cuotas de préstamos.
                        List<tblCredito> lstCreditos = new blRecibosIngresosPrestamos().gmtdConsultaCreditosParaRecibo(this.txtCedula.Text);
                        if (lstCreditos.Count > 0)
                        {
                            this.chkPrestamos.Enabled = true;
                            this.chkAbonoaPrestamo.Enabled = true;
                        }

                        //Datos de los ahorros a la vista y estudiantil.
                        if (new blAhorrador().gmtdConsultarCedulaSocio(this.txtCedula.Text) == true)
                        {
                            this.pmtdHabilitarControlesAhorrosalaVista(true);
                            this.dgvAhorrosalaVista.AutoGenerateColumns = false;
                            this.dgvAhorrosalaVista.DataSource = new blRecibosIngresosAhorros().gmtdConsultarTransacciones(this.txtCedula.Text);
                            tblAhorradore objAhorrador = new blAhorrador().gmtdConsultar(this.txtCedula.Text);
                            this.txtAhorrado.Text = objAhorrador.decAhorrado.ToString();
                            this.chk4xMil.Checked = Convert.ToBoolean(objAhorrador.bitCobraCuatroxMil);

                            this.pmtdHabilitarControlesAhorrosEstudiantil(true);
                            this.dgvAhorrosEstudiantil.AutoGenerateColumns = false;
                            this.dgvAhorrosEstudiantil.DataSource = new blRecibosIngresosAhorros().gmtdConsultarTransaccionesEstudiantiles(this.txtCedula.Text);
                            this.txtAhorradoEstudiantil.Text = new blAhorrador().gmtdConsultar(this.txtCedula.Text).decAhorrosEstudiantes.ToString();

                            this.pmtdHabilitarControlesAhorrosFijo(true);
                            this.dgvAhorrosFijo.AutoGenerateColumns = false;
                            this.dgvAhorrosFijo.DataSource = new blRecibosIngresosAhorros().gmtdConsultarTransaccionesFijas(this.txtCedula.Text);
                            this.txtAhorradoFijo.Text = new blAhorrador().gmtdConsultar(this.txtCedula.Text).decAhorrosFijo.ToString();

                            List<cuotasPendientes> lstCuotasNavideñas = new List<cuotasPendientes>();

                            lstCuotasNavideñas = new blAhorrosNavideno().gmtdConsultarCuotasPendentes(this.txtCedula.Text, -1);

                            if (lstCuotasNavideñas.Count > 0)
                            {
                                this.txtPendientesNavideños.Text = lstCuotasNavideñas.Count.ToString();
                                this.txtCuentaNavideño.Text = lstCuotasNavideñas[0].strCuenta;
                                this.txtValorCuotaNavideño.Text = lstCuotasNavideñas[0].decValorCuota.ToString();
                                this.pmtdHabilitarControlesAhorrosNavideños(true);
                            }

                            List<cuotasPendientes> lstCuotasaFuturo = new List<cuotasPendientes>();

                            lstCuotasaFuturo = new blAhorrosaFuturo().gmtdConsultarCuotasPendentes(this.txtCedula.Text, -1);

                            if (lstCuotasaFuturo.Count > 0)
                            {
                                this.txtPendientesaFuturo.Text = lstCuotasaFuturo.Count.ToString();
                                this.txtCuentaaFuturo.Text = lstCuotasaFuturo[0].strCuenta;
                                this.txtValorCuotaaFuturo.Text = lstCuotasaFuturo[0].decValorCuota.ToString();
                                this.pmtdHabilitarControlesAhorrosaFuturo(true);
                            }
                        }


                        //Habilita los datos para los recibos de otros ingresos.
                        this.pmtdHabilitarControlesOtrosIngresos(true);
                        this.chkOtrosIngresos.Checked = false;

                        List<tblVenta> lstVentas = new blVentas().gmtdConsultarVentasxCedula(this.txtCedula.Text);

                        if (lstVentas.Count > 0)
                        {
                            this.pmtdHabilitarControlesAbonoaVentas(true);
                        }

                        lstDeudasUno = new blDeudas().gmtdConsultarDeudasxSocio(this.txtCedula.Text);
                        if (this.lstDeudasUno.Count > 0)
                        {
                            this.pmtdHabilitarControlesAbonoaDeuda(true);
                        }

                        if (objConfiguracion.intTipoCobro == 1)
                        {
                            this.pmtdConsultarEstadosdeCuenta(this.txtCedula.Text);
                        }
                    }
                    else
                    {
                        this.txtCodigo.Enabled = false;
                        this.txtCedula.Enabled = true;
                        this.txtCedula.Focus();
                    }
                }
            }
        }

        #region Botones
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.pmtdHabilitarControles(false);
            this.pmtdLimpiarControles();
            this.txtCodigo.Enabled = true;
            this.rptRecibos.Visible = false;
            bitEliminar = false;
            this.txtCodigo.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.pmtdHabilitarControles(false);
            this.pmtdLimpiarControles();
            this.txtCodigo.Enabled = false;
            this.rptRecibos.Visible = false;
            bitEliminar = false;
            this.btnNuevo.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.pmtdHabilitarControles(false);
            this.pmtdLimpiarControles();
            this.txtIngreso.Enabled = true;
            this.rptRecibos.Visible = false;
            bitEliminar = false;
            this.txtIngreso.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (bitEliminar == false)
            {
                bitEliminar = true;
                this.rptRecibos.Visible = false;
                this.txtIngreso.Enabled = true;
                this.txtIngreso.Focus();
            }
            else
            {
                if (this.btnAnulado.Visible == true)
                {
                    MessageBox.Show("No puede eliminar un recibo que ya esta eliminado. ", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (this.txtIngreso.Text == "0" || this.txtIngreso.Text == "")
                {
                    MessageBox.Show("Debe de ingresar el número de ingreso a eliminar. ", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (ingresoConsultado.strNombreIng == null)
                {
                    MessageBox.Show("Debe de consultar el ingreso a eliminar. ", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult dlgResult = MessageBox.Show("Confirma que desea eliminar este registro? ", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dlgResult == DialogResult.Yes)
                {
                    this.pmtdMensaje(new blRecibosIngresos().gmtdEliminar(ingresoConsultado), "Ingresos");
                }

                if (ingresoConsultado.bitAhorro)
                {
                    this.gmtdMostrarReciboTransacciones();
                }
                else
                {
                    this.gmtdMostrarReciboIngreso();
                }
                
                this.pmtdHabilitarControles(false);

                this.pmtdLimpiarControles();

                bitEliminar = false;
            }
        }
        #endregion

        #region eventrosControles

        #region CuotasExequiales
        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                FrmSocios socios = new FrmSocios();
                FrmSocios.strLLamada = "Ingreso";
                socios.ShowDialog();
                this.txtCodigo.Text = FrmSocios.strCodigoSeleccionado;
            }
        }

        private void txtCantidad_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtCantidad.Text.Trim() == "")
            {
                this.txtCantidad.Text = "0";
            }
            else
            {
                if ((Convert.ToInt32(this.txtCantidad.Text) + Convert.ToInt32(this.txtMesesPagados.Text)) > 12 && objConfiguracion.intTipoCobro == 1)
                {
                    this.txtCantidad.Text = "0";
                }

                if ((Convert.ToInt32(this.txtCantidad.Text) + Convert.ToInt32(this.txtMesesPagados.Text)) > 27 && objConfiguracion.intTipoCobro == 1)
                {
                    this.txtCantidad.Text = "0";
                }
            }

            this.pmtdCalcularTotalCuotas();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtDescuento.Focus();
            }
        }

        private void txtDescuento_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtDescuento.Text.Trim() == "")
            {
                this.txtDescuento.Text = "0";
            }

            this.pmtdCalcularTotalCuotas();
        }

        private void txtTotalCuotas_TextChanged(object sender, EventArgs e)
        {
            if (this.txtTotalCuotas.Text.Trim() == "")
            {
                this.txtTotalCuotas.Text = "0";
            }

            this.pmtdCalcularGranTotal();
        }

        private void chkCuotas_Click(object sender, EventArgs e)
        {
            if (this.chkCuotas.Checked == true)
            {
                this.txtCantidad.Focus();
            }
            else
            {
                this.txtCantidad.Text = "0";
                this.txtDescuento.Text = "0";
                this.txtTotalCuotas.Text = "0";
            }
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnGuardar.Focus();
            }
        }

        #endregion

        #region cuotasPrestamos

        private void cboPrestamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtCuotasaPagar.Focus();
        }

        private void cboPrestamo_Leave(object sender, EventArgs e)
        {
            this.txtCuotasPendientes.Text = "0";
            this.txtCuotasaPagar.Text = "0";

            List<tblCredito> lstCreditos = new blRecibosIngresosPrestamos().gmtdConsultaCreditosParaRecibo("-1");
            this.dgvPrestamosCuotas.AutoGenerateColumns = false;
            var query = from datos in lstCreditos
                        select datos.intCodigoCre;
            this.dgvPrestamosCuotas.DataSource = query.ToList();
            this.txtCuotasPendientes.Text = (new blRecibosIngresosPrestamos().gmtdConsultaNumerodeCuotasPendientesdeunCredito(Convert.ToInt16(this.cboPrestamo.Text))).ToString(); 
        }

        private void txtCuotasaPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnGuardar.Focus();
            }
        }

        private void chkPrestamos_Click(object sender, EventArgs e)
        {
            if (this.chkPrestamos.Checked == true)
            {
                List<tblCredito> lstCreditos = new blRecibosIngresosPrestamos().gmtdConsultaCreditosParaRecibo(this.txtCedula.Text);

                this.txtCuotasPendientes.Text = "0";
                this.txtCuotasaPagar.Text = "0";
                this.cboPrestamo.Enabled = true;
                this.txtValorCuota.Enabled = false;
                intFilaSeleccionadaGridCuotasPrestamo = 0;

                this.cboPrestamo.Items.Clear();
                for (int a = 0; a < lstCreditos.Count; a++)
                {
                    this.cboPrestamo.Items.Add(lstCreditos[a].intCodigoCre);
                }

                if (lstCreditos.Count > 0)
                {
                    if (lstCreditos.Count > 1)
                    {
                        MessageBox.Show("Esta persona tiene mas de un crédito activo.", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.cboPrestamo.SelectedIndex = 0;
                    this.txtCuotasaPagar.Enabled = true;
                    this.cboPrestamo.Focus();
                }
            }
            else
            {
                this.cboPrestamo.Enabled = false;
            }
        }

        private void txtCuotasaPagar_Leave(object sender, EventArgs e)
        {
            //if (Convert.ToInt16(this.txtCuotasaPagar.Text) > 3)
            //{
            //    MessageBox.Show("No se pueden pagar mas de 3 cuotas por recibo.", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.txtCuotasaPagar.Text = "0";
            //    return;
            //}

            if (Convert.ToInt16(this.txtCuotasaPagar.Text) > Convert.ToInt16(this.txtCuotasPendientes.Text))
            {
                MessageBox.Show("Las cuotas a pagar no puede ser mayor a la adeudadas.", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtCuotasaPagar.Text = "0";
                return;
            }

            List<recibosIngresosPrestamos> lstCuotasOrganizadas = new blCreditos().gmtdCalcularValordeCuotas(Convert.ToInt16(this.cboPrestamo.Text), Convert.ToInt16(this.txtCuotasaPagar.Text));

            this.dgvPrestamosCuotas.AutoGenerateColumns = false;
            this.dgvPrestamosCuotas.DataSource = new blCreditos().gmtdCalcularValordeCuotas(Convert.ToInt16(this.cboPrestamo.Text), Convert.ToInt16(this.txtCuotasaPagar.Text));

            this.pmtdCalcularSumadeCuotasdePrestamo();
        }

        private void dgvPrestamosCuotas_DoubleClick(object sender, EventArgs e)
        {
            this.txtValorCuota.Enabled = true;
            intFilaSeleccionadaGridCuotasPrestamo = this.dgvPrestamosCuotas.CurrentRow.Index;
            this.txtValorCuota.Text = this.dgvPrestamosCuotas.CurrentRow.Cells[6].Value.ToString();
            this.txtValorCuota.Focus();
        }

        private void txtValorCuota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnGuardar.Focus();
            }
        }

        private void txtValorCuota_Leave(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Desea modificar el valor de la cuota.", "Ingreso.", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlr == DialogResult.Yes)
            {
                double dblCapital = 0;
                double dblIntereses = 0;
                double dblMora = 0;
                double dblCausado = 0;

                double dblValorCuota = Convert.ToDouble(this.txtValorCuota.Text);
                double dblValorCapital = Convert.ToDouble(this.dgvPrestamosCuotas[1, intFilaSeleccionadaGridCuotasPrestamo].Value);
                double dblValorInteres = Convert.ToDouble(this.dgvPrestamosCuotas[2, intFilaSeleccionadaGridCuotasPrestamo].Value);
                double dblValorMora = Convert.ToDouble(this.dgvPrestamosCuotas[3, intFilaSeleccionadaGridCuotasPrestamo].Value);
                double dblValorCausado = Convert.ToDouble(this.dgvPrestamosCuotas[5, intFilaSeleccionadaGridCuotasPrestamo].Value);

                if (dblValorCuota > dblValorCapital)
                {
                    dblCapital = dblValorCapital;
                    dblValorCuota -= dblValorCapital;
                }
                else
                {
                    dblCapital = dblValorCuota;
                    dblIntereses = 0;
                    dblMora = 0;
                    dblCausado = 0;
                    dblValorCuota = 0;
                }

                if (dblValorCuota > dblValorCausado && dblValorCausado > 0)
                {
                    dblValorCuota -= dblValorCausado;
                    dblCausado = dblValorCausado;
                }
                else
                {
                    dblIntereses = 0;
                    dblMora = 0;
                    if (dblValorCausado > 0)
                    {
                        dblCausado = dblValorCuota;
                        dblValorCuota = 0;
                    }
                }

                if (dblValorCuota > dblValorInteres)
                {
                    dblValorCuota -= dblValorInteres;
                    dblIntereses = dblValorInteres;
                }
                else
                {
                    dblIntereses = dblValorCuota;
                    dblValorMora = 0;
                    dblValorCuota = 0;
                }

                if (dblValorCuota > 0)
                    dblMora = dblValorCuota;

                dblValorCuota = dblCapital + dblIntereses + dblMora + dblCausado;

                this.dgvPrestamosCuotas[1, intFilaSeleccionadaGridCuotasPrestamo].Value = dblCapital.ToString();
                this.dgvPrestamosCuotas[2, intFilaSeleccionadaGridCuotasPrestamo].Value = dblIntereses.ToString();
                this.dgvPrestamosCuotas[3, intFilaSeleccionadaGridCuotasPrestamo].Value = dblMora.ToString();
                this.dgvPrestamosCuotas[5, intFilaSeleccionadaGridCuotasPrestamo].Value = dblCausado.ToString();
                this.dgvPrestamosCuotas[6, intFilaSeleccionadaGridCuotasPrestamo].Value = this.txtValorCuota.Text;
                this.intFilaSeleccionadaGridCuotasPrestamo = -1;
            }
            this.txtValorCuota.Text = "0";
            this.txtValorCuota.Enabled = false;

            this.pmtdCalcularSumadeCuotasdePrestamo();
        }

        private void txtTotalPrestamos_TextChanged(object sender, EventArgs e)
        {
            if (this.txtTotalPrestamos.Text.Trim() == "")
                this.txtTotalPrestamos.Text = "0";

            this.pmtdCalcularGranTotal();
        }
        #endregion

        #region ahorroalaVista

        private void chkAhorroalaVista_Click(object sender, EventArgs e)
        {
            this.txtAhorrar.Text = "0";
            if (this.chkAhorroalaVista.Checked == true)
            {
                this.txtAhorrar.Enabled = true;
                this.txtAhorrar.Focus();
            }
            else
            {
                this.txtAhorrar.Enabled = false;
            }
        }

        private void txtAhorrar_TextChanged(object sender, EventArgs e)
        {
            if (this.txtAhorrar.Text.Trim() == "")
                this.txtAhorrar.Text = "0";

            this.pmtdCalcularGranTotal();
        }
        #endregion

        #region ahorroEstudiantil
        private void txtAhorrarEstudiantil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.btnGuardar.Focus();
        }

        private void chkAhorrosEstudiantil_Click(object sender, EventArgs e)
        {
            this.txtAhorrarEstudiantil.Text = "0";
            if (this.chkAhorrosEstudiantil.Checked == true)
            {
                this.txtAhorrarEstudiantil.Enabled = true;
                this.txtAhorrarEstudiantil.Focus();
            }
            else
                this.txtAhorrarEstudiantil.Enabled = false;
        }

        private void txtAhorrarEstudiantil_TextChanged(object sender, EventArgs e)
        {
            if (this.txtAhorrarEstudiantil.Text.Trim() == "")
                this.txtAhorrarEstudiantil.Text = "0";

            this.pmtdCalcularGranTotal();
        }
        #endregion

        #region ahorrosNavideños
        private void txtCuotasNavideñas_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(this.txtCuotasNavideñas.Text) > Convert.ToInt16(this.txtPendientesNavideños.Text))
            {
                MessageBox.Show("Las cuotas a pagar no puede ser mayor a la adeudadas.", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtCuotasNavideñas.Text = "0";
                this.txtTotalAhorroNavideño.Text = "0";

                List<cuotasPendientes> lstLimpiarCuotas = new blAhorrosNavideno().gmtdConsultarCuotasPendentes(this.txtCedula.Text, 0);

                this.dgvAhorrosNavideños.AutoGenerateColumns = false;
                this.dgvAhorrosNavideños.DataSource = lstLimpiarCuotas;
                return;
            }

            List<cuotasPendientes> lstCuotasOrganizadas = new blAhorrosNavideno().gmtdConsultarCuotasPendentes(this.txtCedula.Text, Convert.ToInt16(this.txtCuotasNavideñas.Text));

            this.dgvAhorrosNavideños.AutoGenerateColumns = false;
            this.dgvAhorrosNavideños.DataSource = lstCuotasOrganizadas;

            this.pmtdCalcularSumadeCuotasdeAhorroNavideño();
        }

        private void txtCuotasNavideñas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnGuardar.Focus();
            }
        }

        private void chkAhorrosNavideños_Click(object sender, EventArgs e)
        {
            this.txtCuotasNavideñas.Text = "0";
            List<cuotasPendientes> lstCuotasOrganizadas = new blAhorrosNavideno().gmtdConsultarCuotasPendentes(this.txtCedula.Text, 0);
            this.dgvAhorrosNavideños.AutoGenerateColumns = false;
            this.dgvAhorrosNavideños.DataSource = lstCuotasOrganizadas;

            if (this.chkAhorrosNavideños.Checked == true)
            {
                this.txtCuotasNavideñas.Enabled = true;
                this.txtCuotasNavideñas.Focus();
            }
            else
            {
                this.txtCuotasNavideñas.Enabled = false;
            }
        }

        private void txtTotalAhorroNavideño_TextChanged(object sender, EventArgs e)
        {
            if (this.txtTotalAhorroNavideño.Text.Trim() == "")
            {
                this.txtTotalAhorroNavideño.Text = "0";
            }

            this.pmtdCalcularGranTotal();
        }
        #endregion

        #region ahorrosaFuturo
        private void chkAhorrosaFuturo_Click(object sender, EventArgs e)
        {
            this.txtCuotasaFuturo.Text = "0";
            List<cuotasPendientes> lstCuotasOrganizadas = new blAhorrosaFuturo().gmtdConsultarCuotasPendentes(this.txtCedula.Text, 0);
            this.dgvAhorrosaFuturo.AutoGenerateColumns = false;
            this.dgvAhorrosaFuturo.DataSource = lstCuotasOrganizadas;

            if (this.chkAhorrosaFuturo.Checked == true)
            {
                this.txtCuotasaFuturo.Enabled = true;
                this.txtCuotasaFuturo.Focus();
            }
            else
                this.txtCuotasaFuturo.Enabled = false;
        }

        private void txtCuotasaFuturo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.btnGuardar.Focus();
        }

        private void txtCuotasaFuturo_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(this.txtCuotasaFuturo.Text) > Convert.ToInt16(this.txtPendientesaFuturo.Text))
            {
                MessageBox.Show("Las cuotas a pagar no puede ser mayor a las adeudadas.", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtCuotasaFuturo.Text = "0";
                this.txtTotalAhorroaFuturo.Text = "0";

                List<cuotasPendientes> lstLimpiarCuotas = new blAhorrosaFuturo().gmtdConsultarCuotasPendentes(this.txtCedula.Text, 0);

                this.dgvAhorrosaFuturo.AutoGenerateColumns = false;
                this.dgvAhorrosaFuturo.DataSource = lstLimpiarCuotas;
                return;
            }

            List<cuotasPendientes> lstCuotasOrganizadas = new blAhorrosaFuturo().gmtdConsultarCuotasPendentes(this.txtCedula.Text, Convert.ToInt16(this.txtCuotasaFuturo.Text));

            this.dgvAhorrosaFuturo.AutoGenerateColumns = false;
            this.dgvAhorrosaFuturo.DataSource = lstCuotasOrganizadas;

            this.pmtdCalcularSumadeCuotasdeAhorroaFuturo();
        }

        private void txtTotalAhorroaFuturo_TextChanged(object sender, EventArgs e)
        {
            if (this.txtTotalAhorroaFuturo.Text.Trim() == "")
                this.txtTotalAhorroaFuturo.Text = "0";

            this.pmtdCalcularGranTotal();
        }


        #endregion

        #region ahorrosFijos
        private void chkAhorrosFijos_Click(object sender, EventArgs e)
        {
            this.txtAhorrarFijo.Text = "0";
            if (this.chkAhorrosFijos.Checked == true)
            {
                this.txtAhorrarFijo.Enabled = true;
                this.txtAhorrarFijo.Focus();
            }
            else
            {
                this.txtAhorrarFijo.Enabled = false;
            }
        }

        private void txtAhorrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.btnGuardar.Focus();
        }

        private void txtAhorrarFijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.btnGuardar.Focus();
        }

        private void txtAhorrarFijo_TextChanged(object sender, EventArgs e)
        {
            if (this.txtAhorrarFijo.Text.Trim() == "")
                this.txtAhorrarFijo.Text = "0";

            this.pmtdCalcularGranTotal();
        }


        #endregion

        #region otrosIngresos
        private void cboOtrosIngresos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtDescripcionOtroIngreso.Focus();
        }

        private void txtDescripcionOtroIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtValorOtrosIngresos.Focus();
        }

        private void txtValorOtrosIngresos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.btnAgregarOtrosIngresos.Focus();
        }

        private void btnAgregarOtros_Click(object sender, EventArgs e)
        {
            if (this.cboOtrosIngresos.Items.Count <= 0)
            {
                MessageBox.Show("Debe de haber registros en la tabla de otros ingresos.", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.txtValorOtrosIngresos.Text.Trim() == "" || this.txtValorOtrosIngresos.Text.Trim() == "0")
            {
                MessageBox.Show("Debe de ingresar el valor del registro de otro ingreso.", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.dgvOtrosIngresos.Rows.Count >= 3)
            {
                MessageBox.Show("Solo puede ingresar 2 Items.", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] ventor = new string[3] { this.cboOtrosIngresos.SelectedValue.ToString(), this.txtDescripcionOtroIngreso.Text, this.txtValorOtrosIngresos.Text };
            this.dgvOtrosIngresos.Rows.Add(ventor);

            this.pmtdCalcularSumadeOtrosIngresos();

            this.cboOtrosIngresos.SelectedIndex = 0;
            this.txtDescripcionOtroIngreso.Text = "0";
            this.txtValorOtrosIngresos.Text = "0";
            this.cboOtrosIngresos.Focus();
        }

        private void txtTotalOtrosIngresos_TextChanged(object sender, EventArgs e)
        {
            if (this.txtTotalOtrosIngresos.Text.Trim() == "")
                this.txtTotalOtrosIngresos.Text = "0";

            this.pmtdCalcularGranTotal();
        }

        private void btnEliminarOtros_Click(object sender, EventArgs e)
        {
            if (this.dgvOtrosIngresos.Rows.Count > 1)
            {
                this.dgvOtrosIngresos.Rows.RemoveAt(this.dgvOtrosIngresos.CurrentRow.Index);
            }

            this.pmtdCalcularSumadeOtrosIngresos();
        }

        private void chkOtrosIngresos_Click(object sender, EventArgs e)
        {
            this.pmtdLimpiarControlesOtrosIngresos();

            if (this.chkOtrosIngresos.Checked == true)
            {
                this.cboOtrosIngresos.Focus();
            }
        }

        #endregion

        #region abonoaPrestamo
        private void chkAbonoaPrestamo_Click(object sender, EventArgs e)
        {
            if (this.chkAbonoaPrestamo.Checked == true)
            {
                List<tblCredito> lstCreditos = new blRecibosIngresosPrestamos().gmtdConsultaCreditosParaRecibo(this.txtCedula.Text);

                this.txtValoraAbonarPrestamo.Text = "0";
                this.cboPrestamosAbono.Enabled = true;
                this.txtValoraAbonarPrestamo.Enabled = false;

                this.cboPrestamosAbono.Items.Clear();
                for (int a = 0; a < lstCreditos.Count; a++)
                    this.cboPrestamosAbono.Items.Add(lstCreditos[a].intCodigoCre);

                if (lstCreditos.Count > 1)
                {
                    MessageBox.Show("Esta persona tiene mas de un crédito activo.", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.cboPrestamosAbono.SelectedIndex = 0;
                this.cboPrestamosAbono.Enabled = true;
                this.txtValoraAbonarPrestamo.Enabled = true;
                this.cboPrestamosAbono.Focus();
            }
            else
                this.cboPrestamosAbono.Enabled = false;
        }

        private void txtValoraAbonarPrestamo_TextChanged(object sender, EventArgs e)
        {
            if (this.txtValoraAbonarPrestamo.Text.Trim() == "")
                this.txtValoraAbonarPrestamo.Text = "0";

            this.pmtdCalcularGranTotal();
        }


        #endregion

        #region Ventas
        private void chkVentas_Click(object sender, EventArgs e)
        {
            if (this.chkVentas.Checked == true)
            {
                List<tblVenta> lstVentas = new blVentas().gmtdConsultarVentasxCedula(this.txtCedula.Text);
                this.txtDebeVenta.Text = "0";
                this.txtAbonaVenta.Text = "0";
                this.cboVenta.Enabled = true;
                this.txtAbonaVenta.Enabled = true;
                //this.cboVenta.Items.Clear();
                this.cboVenta.DataSource = lstVentas;
                if (lstVentas.Count > 1)
                {
                    MessageBox.Show("Esta persona tiene mas de una venta activa.", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.cboVenta.SelectedIndex = 0;
                }
                this.cboVenta.Focus();
            }
            else
            {
                this.cboVenta.Enabled = false;
                this.txtAbonaVenta.Enabled = false;
            }
        }

        private void cboVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtAbonaVenta.Focus();
            }
        }

        private void cboVenta_Leave(object sender, EventArgs e)
        {
            if (this.cboVenta.SelectedIndex >= 0)
            {
                this.txtDebeVenta.Text = this.cboVenta.SelectedValue.ToString();
            }
        }

        private void txtAbonaVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnGuardar.Focus();
            }
        }

        private void txtAbonaVenta_Leave(object sender, EventArgs e)
        {
            if (this.txtAbonaVenta.Text == "" || this.txtAbonaVenta.Text == "0")
            {
                MessageBox.Show("Debe de ingresar el valor del abono a la venta.", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtAbonaVenta.Text = "0";
                return;
            }

            if (Convert.ToDecimal(this.txtAbonaVenta.Text) > Convert.ToDecimal(this.txtDebeVenta.Text))
            {
                MessageBox.Show("El valor a abonar no puede ser mayor al a deudao.", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtAbonaVenta.Text = "0";
                return;
            }
        }

        private void txtAbonaVenta_TextChanged(object sender, EventArgs e)
        {
            if (this.txtAbonaVenta.Text.Trim() == "")
                this.txtAbonaVenta.Text = "0";

            this.pmtdCalcularGranTotal();
        }
        #endregion

        #region Deudas
        private void chkDeudas_Click(object sender, EventArgs e)
        {
            if (this.chkDeudas.Checked == true)
            {
                this.txtDebeDeuda.Text = "0";
                this.txtAbonaDeuda.Text = "0";
                this.cboDeudas.Enabled = true;
                this.txtAbonaDeuda.Enabled = true;

                this.cboDeudas.DataSource = lstDeudasUno;
                this.cboDeudas.SelectedIndex = 0;
                //this.cboDeudas.Focus();

                for (int a = 0; a < lstDeudasUno.Count; a++)
                {
                    lstDeudasDos.Add(lstDeudasUno[a]);
                }

                this.txtDebeDeuda1.Text = "0";
                this.txtAbonaDeuda1.Text = "0";
                this.cboDeudas1.Enabled = true;
                this.txtAbonaDeuda1.Enabled = true;

                this.cboDeudas1.DataSource = lstDeudasDos;
                this.cboDeudas1.SelectedIndex = 0;
                this.cboDeudas.Focus();

            }
            else
            {
                this.cboDeudas.Enabled = false;
                this.txtAbonaDeuda.Enabled = false;
                this.cboDeudas1.Enabled = false;
                this.txtAbonaDeuda1.Enabled = false;
            }
        }

        private void cboDeudas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtAbonaDeuda.Focus();
            }
        }

        private void cboDeudas_Leave(object sender, EventArgs e)
        {
            if (this.cboDeudas.SelectedIndex >= 0 && lstDeudasUno.Count > 0)
            {
                this.txtDebeDeuda.Text = lstDeudasUno[this.cboDeudas.SelectedIndex].decDebeDeu.ToString();
            }
        }

        private void txtAbonaDeuda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.btnGuardar.Focus();
        }

        private void txtAbonaDeuda_Leave(object sender, EventArgs e)
        {
            if (this.txtAbonaDeuda.Text == "" || this.txtAbonaDeuda.Text == "0")
            {
                MessageBox.Show("Debe de ingresar el valor del abono a la deuda.", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtAbonaDeuda.Text = "0";
                return;
            }

            if (Convert.ToDecimal(this.txtAbonaDeuda.Text) > Convert.ToDecimal(this.txtDebeDeuda.Text))
            {
                MessageBox.Show("El valor a abonar no puede ser mayor al adeudao.", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtAbonaDeuda.Text = "0";
                return;
            }
        }

        private void txtAbonaDeuda_TextChanged(object sender, EventArgs e)
        {
            if (this.txtAbonaDeuda.Text.Trim() == "")
                this.txtAbonaDeuda.Text = "0";

            this.pmtdCalcularGranTotal();
        }


        #endregion

        #endregion

        private void frmIngresos_Load(object sender, EventArgs e)
        {
            objConfiguracion = new fConfiguracion().gmtdConsultaConfiguracion();
            this.cboOtrosIngresos.DataSource = new blOtroIngreso().gmtdConsultarTodosxNombre();
            this.btnNuevo.Focus();
            this.gmtdPermisosBotones();
            this.rptRecibos.RefreshReport();
        }

        private void txtIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                ingresoConsultado = new blRecibosIngresos().gmtdConsultaIngreso(Convert.ToInt32(this.txtIngreso.Text));
                //this.pmtdLimpiarControles();
                if (ingresoConsultado.strNombreIng != null)
                {
                    ingresoConsultado.strFormulario = this.Name;
                    if (ingresoConsultado.bitAnulado == true)
                    {
                        this.btnAnulado.Visible = true;
                    }

                    this.txtIngreso.Text = ingresoConsultado.intCodigoIng.ToString();
                    this.txtCedula.Text = ingresoConsultado.strCedulaIng;
                    this.txtNombre.Text = ingresoConsultado.strNombreIng;
                    this.txtApellido.Text = ingresoConsultado.strApellidoIng;
                    this.txtGranTotal.Text = ingresoConsultado.decTotalIng.ToString();

                    if (ingresoConsultado.ingresoAbonoaDeuda != null)
                    {
                        for (int a = 0; a < ingresoConsultado.ingresoAbonoaDeuda.Count; a++)
                        {
                            if (a == 0)
                            {
                                this.txtDebeDeuda.Text = ingresoConsultado.ingresoAbonoaDeuda[0].decDebe.ToString();
                                this.txtAbonaDeuda.Text = ingresoConsultado.ingresoAbonoaDeuda[0].decAbona.ToString();
                            }
                            else
                            { 
                                this.txtDebeDeuda.Text = ingresoConsultado.ingresoAbonoaDeuda[0].decDebe.ToString();
                                this.txtAbonaDeuda.Text = ingresoConsultado.ingresoAbonoaDeuda[0].decAbona.ToString();
                            }
                        }
                        this.chkDeudas.Checked = true;
                    }

                    if (ingresoConsultado.ingresoAbonoaPrestamo != null)
                    {
                        this.txtValoraAbonarPrestamo.Text = ingresoConsultado.ingresoAbonoaPrestamo.decAbonoPrestamo.ToString();
                        this.chkAbonoaPrestamo.Checked = true;
                    }

                    if (ingresoConsultado.ingresoAbonoaVenta != null)
                    {
                        this.txtDebeVenta.Text = ingresoConsultado.ingresoAbonoaVenta.decAdeuda.ToString();
                        this.txtAbonaVenta.Text = ingresoConsultado.ingresoAbonoaVenta.decAbona.ToString();
                        this.chkVentas.Checked = true;
                    }

                    if (ingresoConsultado.ingresoAhorro != null)
                    {
                        this.txtAhorrado.Text = ingresoConsultado.ingresoAhorro.decAhorrado.ToString();
                        this.txtAhorrar.Text = ingresoConsultado.ingresoAhorro.decAhorro.ToString();
                        this.chk4xMil.Checked = Convert.ToBoolean(ingresoConsultado.ingresoAhorro.bitCobraCuatroxMil);
                        this.chkAhorroalaVista.Checked = true;
                    }

                    if (ingresoConsultado.ingresoAhorroaFuturo != null)
                    {
                        List<cuotasPendientes> lstCuotasOrganizadas = new List<cuotasPendientes>();

                        for (int a = 0; a < ingresoConsultado.ingresoAhorroaFuturo.Count; a++)
                        {
                            cuotasPendientes cuota = new cuotasPendientes();
                            cuota.decValorCuota = ingresoConsultado.ingresoAhorroaFuturo[a].decValorCuo;
                            cuota.intCuota = a + 1;
                            cuota.strCuenta = ingresoConsultado.ingresoAhorroaFuturo[a].strCuenta;
                            lstCuotasOrganizadas.Add(cuota);
                        }
                        this.dgvAhorrosaFuturo.AutoGenerateColumns = false;
                        this.dgvAhorrosaFuturo.DataSource = lstCuotasOrganizadas;
                    }

                    if (ingresoConsultado.ingresoAhorroEstudiantil != null)
                    {
                        this.txtAhorradoEstudiantil.Text = ingresoConsultado.ingresoAhorroEstudiantil.decAhorrado.ToString();
                        this.txtAhorrarEstudiantil.Text = ingresoConsultado.ingresoAhorroEstudiantil.decAhorro.ToString();
                        this.chkAhorrosEstudiantil.Checked = true;
                    }

                    if (ingresoConsultado.ingresoAhorroFijo != null)
                    {
                        this.txtAhorradoFijo.Text = ingresoConsultado.ingresoAhorroFijo.decAhorrado.ToString();
                        this.txtAhorrarFijo.Text = ingresoConsultado.ingresoAhorroFijo.decAhorro.ToString();
                        this.chkAhorrosFijos.Checked = true;
                    }

                    if (ingresoConsultado.ingresoAhorroNavideño != null)
                    {
                        List<cuotasPendientes> lstCuotasOrganizadas = new List<cuotasPendientes>();

                        for (int a = 0; a < ingresoConsultado.ingresoAhorroNavideño.Count; a++)
                        {
                            cuotasPendientes cuota = new cuotasPendientes();
                            cuota.decValorCuota = ingresoConsultado.ingresoAhorroNavideño[a].decValorCuo;
                            cuota.intCuota = a + 1;
                            cuota.strCuenta = ingresoConsultado.ingresoAhorroNavideño[a].strCuenta;
                            lstCuotasOrganizadas.Add(cuota);
                        }

                        this.dgvAhorrosNavideños.AutoGenerateColumns = false;
                        this.dgvAhorrosNavideños.DataSource = lstCuotasOrganizadas;

                        this.pmtdCalcularSumadeCuotasdeAhorroNavideño();
                    }

                    if (ingresoConsultado.ingresoCuota != null)
                    {
                        this.txtCodigo.Text = ingresoConsultado.ingresoCuota.intCodigoSoc.ToString();
                        this.txtCodServicio.Text = ingresoConsultado.ingresoCuota.strCodServiciop;
                        this.txtNomServicio.Text = "";
                        this.txtAño.Text = ingresoConsultado.ingresoCuota.intAño.ToString();
                        this.txtTipo.Text = "";
                        this.txtCuota.Text = (ingresoConsultado.ingresoCuota.intTotal + ingresoConsultado.ingresoCuota.decDescuento).ToString();
                        this.txtAdultos.Text = ingresoConsultado.ingresoCuota.intAdultos.ToString();
                        this.txtCuotaAdulto.Text = ingresoConsultado.ingresoCuota.intCuotaAdultos.ToString();
                        this.txtCantidad.Text = ingresoConsultado.ingresoCuota.intCantidad.ToString();
                        this.txtDescuento.Text = ingresoConsultado.ingresoCuota.decDescuento.ToString();
                        this.txtMesActual.Text = ingresoConsultado.ingresoCuota.intMesActual.ToString();
                        this.txtMesesPagados.Text = ingresoConsultado.ingresoCuota.intMesesCancelados.ToString();
                        this.txtTotalCuotas.Text = ingresoConsultado.ingresoCuota.intTotal.ToString();
                        this.chkCuotas.Checked = true;
                    }

                    if (ingresoConsultado.ingresoOtrosIngresos != null)
                    {
                        this.dgvOtrosIngresos.Rows.Clear();

                        for (int a = 0; a < ingresoConsultado.ingresoOtrosIngresos.Count; a++)
                        {
                            string[] ventor = new string[3] { ingresoConsultado.ingresoOtrosIngresos[a].strCodOtrosIngresos, ingresoConsultado.ingresoOtrosIngresos[a].strDescripcion, ingresoConsultado.ingresoOtrosIngresos[a].decValor.ToString() };
                            this.dgvOtrosIngresos.Rows.Add(ventor);
                        }
                        this.pmtdCalcularSumadeOtrosIngresos();
                    }

                    if (ingresoConsultado.ingresoPrestamo != null)
                    {
                        List<recibosIngresosPrestamos> lstCuotasOrganizadas = new List<recibosIngresosPrestamos>();

                        for (int a = 0; a < ingresoConsultado.ingresoPrestamo.Count; a++)
                        {
                            recibosIngresosPrestamos prestamo = new recibosIngresosPrestamos();
                            prestamo.decCapital = ingresoConsultado.ingresoPrestamo[a].decCapital;
                            prestamo.decCausado = ingresoConsultado.ingresoPrestamo[a].decCausado;
                            prestamo.decIntereses = ingresoConsultado.ingresoPrestamo[a].decInteres;
                            prestamo.decInteresesMora = ingresoConsultado.ingresoPrestamo[a].decMora;
                            prestamo.decValorCuota = ingresoConsultado.ingresoPrestamo[a].decPago;
                            prestamo.intMesesAtrasados = ingresoConsultado.ingresoPrestamo[a].intMesesAtrasados;
                            lstCuotasOrganizadas.Add(prestamo);
                        }
                        this.dgvPrestamosCuotas.AutoGenerateColumns = false;
                        this.dgvPrestamosCuotas.DataSource = lstCuotasOrganizadas;

                        this.pmtdCalcularSumadeCuotasdePrestamo();
                    }

                    //intTipoCobro = 1 es para los cobros mensuales.
                    if (ingresoConsultado.bitAhorro && objConfiguracion.intTipoCobro == 1)
                    {
                        this.gmtdMostrarReciboTransacciones();
                    }
                    else
                    {
                        if (objConfiguracion.intTipoCobro == 1)
                        {
                            this.gmtdMostrarReciboIngreso();
                        }
                        else
                        {
                            this.gmtdMostrarReciboIngreso20Julio();
                        }
                    }

                    if (bitEliminar == true)
                    {
                        this.btnEliminar.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Este código no aparece registrado. ", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtIngreso.Text = "0";
                    return;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            propiedades.strFormActivo = "Principal";
            this.Dispose();
        }

        private void txtIngreso_Leave(object sender, EventArgs e)
        {
            if (this.txtIngreso.Text.Trim() == "")
            {
                this.txtIngreso.Text = "0";
            }

            txtIngreso.Enabled = false;
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (this.txtCodigo.Text.Trim() == "")
            {
                this.txtCodigo.Text = "0";
            }
            this.txtCodigo.Enabled = false;
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            this.txtCedula.Enabled = false;
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (this.txtCantidad.Text.Trim() == "")
            {
                this.txtCantidad.Text = "0";
            }

            this.dtpFechaRec.Value = Convert.ToDateTime("01/01/1900");

            int intMesesPagados = Convert.ToInt32(this.txtMesesPagados.Text);

            int intCantidad = Convert.ToInt32(this.txtCantidad.Text);

            int intCuotas = intMesesPagados + intCantidad;

            int intMes = DateTime.Now.Month;

            int intMesesdeAtraso = intMes - intMesesPagados;

            tblConfiguracione configuracion = new blConfiguracion().gmtdConsultaConfiguracion();

            if(intCuotas >= intMes && intMesesdeAtraso >= configuracion.intAtrasados)
            {
                this.dtpFechaRec.Value = DateTime.Now.AddDays(Convert.ToDouble(configuracion.intDiasReceso));
            }

            if (intCuotas > 12 && objConfiguracion.intTipoCobro == 1)
            {
                MessageBox.Show("El número de cuotas pagas en un año no debe de exceder las 12, por favor corrija la cantidad a pagar. ", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtCantidad.Text = "0";
            }

            if (intCuotas > 27 && objConfiguracion.intTipoCobro == 2)
            {
                MessageBox.Show("El número de quincenas pagas en un año no debe de exceder las 27, por favor corrija la cantidad a pagar. ", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtCantidad.Text = "0";
            }

            if (this.txtAdultos.Text.Trim() != "" && this.txtAdultos.Text.Trim() != "0"
                && this.txtCuotaAdulto.Text.Trim() != "" && this.txtCuotaAdulto.Text.Trim() != "0"
                && Convert.ToInt32(this.txtCantidad.Text) > 0)
            {
                decimal decValor = (Convert.ToInt32(this.txtAdultos.Text) * Convert.ToInt32(this.txtCuotaAdulto.Text)) * Convert.ToInt32(this.txtCantidad.Text);
                string[] ventor = new string[3] {"9999", this.txtCantidad.Text +  " Cuota(s) de adulto mayor para el socio " + this.txtCodigo.Text, decValor.ToString("##00") };
                this.dgvOtrosIngresos.Rows.Add(ventor);
                this.chkOtrosIngresos.Checked = true;
                this.pmtdCalcularSumadeOtrosIngresos();
            }
        }

        private void txtDescuento_Leave(object sender, EventArgs e)
        {
            if (this.txtDescuento.Text.Trim() == "")
            {
                this.txtDescuento.Text = "0";
            }
        }

        private void txtAhorrar_Leave(object sender, EventArgs e)
        {
            if (this.txtAhorrar.Text.Trim() == "")
            {
                this.txtAhorrar.Text = "0";
            }
        }

        private void txtAhorrarEstudiantil_Leave(object sender, EventArgs e)
        {
            if (this.txtAhorrarEstudiantil.Text.Trim() == "")
            {
                this.txtAhorrarEstudiantil.Text = "0";
            }
        }

        private void txtAhorrarFijo_Leave(object sender, EventArgs e)
        {
            if (this.txtAhorrarFijo.Text.Trim() == "")
            {
                this.txtAhorrarFijo.Text = "0";
            }
        }

        private void txtValorOtrosIngresos_Leave(object sender, EventArgs e)
        {
            if (this.txtValorOtrosIngresos.Text.Trim() == "")
            {
                this.txtValorOtrosIngresos.Text = "0";
            }
        }

        private void txtValoraAbonarPrestamo_Leave(object sender, EventArgs e)
        {
            if (this.txtValoraAbonarPrestamo.Text.Trim() == "")
            {
                this.txtValoraAbonarPrestamo.Text = "0";
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                //Datos de las cuotas de préstamos.
                List<tblCredito> lstCreditos = new blRecibosIngresosPrestamos().gmtdConsultaCreditosParaRecibo(this.txtCedula.Text);
                if (lstCreditos.Count > 0)
                {
                    this.txtNombre.Text = lstCreditos[0].strNombrePre;
                    this.txtApellido.Text = lstCreditos[0].strApellido1Pre + " " + lstCreditos[0].strApellido2Pre;
                    this.chkPrestamos.Enabled = true;
                    this.chkAbonoaPrestamo.Enabled = true;
                }

                //Datos de los ahorros a la vista y estudiantil.
                if (new blAhorrador().gmtdConsultarCedulaSocio(this.txtCedula.Text))
                {
                    if (this.txtNombre.Text.Trim() == "")
                    {
                        tblAhorradore ahorrador = new blAhorrador().gmtdConsultar(this.txtCedula.Text);
                        this.txtNombre.Text = ahorrador.strNombreAho;
                        this.txtApellido.Text = ahorrador.strApellido1Aho + " " + ahorrador.strApellido2Aho;
                    }

                    this.pmtdHabilitarControlesAhorrosalaVista(true);
                    this.dgvAhorrosalaVista.AutoGenerateColumns = false;
                    this.dgvAhorrosalaVista.DataSource = new blRecibosIngresosAhorros().gmtdConsultarTransacciones(this.txtCedula.Text);
                    tblAhorradore objAhorrador = new blAhorrador().gmtdConsultar(this.txtCedula.Text);
                    this.txtAhorrado.Text = objAhorrador.decAhorrado.ToString();
                    this.chk4xMil.Checked = Convert.ToBoolean(objAhorrador.bitCobraCuatroxMil);

                    this.pmtdHabilitarControlesAhorrosEstudiantil(true);
                    this.dgvAhorrosEstudiantil.AutoGenerateColumns = false;
                    this.dgvAhorrosEstudiantil.DataSource = new blRecibosIngresosAhorros().gmtdConsultarTransaccionesEstudiantiles(this.txtCedula.Text);
                    this.txtAhorradoEstudiantil.Text = new blAhorrador().gmtdConsultar(this.txtCedula.Text).decAhorrosEstudiantes.ToString();

                    this.pmtdHabilitarControlesAhorrosFijo(true);
                    this.dgvAhorrosFijo.AutoGenerateColumns = false;
                    this.dgvAhorrosFijo.DataSource = new blRecibosIngresosAhorros().gmtdConsultarTransaccionesFijas(this.txtCedula.Text);
                    this.txtAhorradoFijo.Text = new blAhorrador().gmtdConsultar(this.txtCedula.Text).decAhorrosFijo.ToString();

                    List<cuotasPendientes> lstCuotasNavideñas = new List<cuotasPendientes>();

                    lstCuotasNavideñas = new blAhorrosNavideno().gmtdConsultarCuotasPendentes(this.txtCedula.Text, -1);

                    if (lstCuotasNavideñas.Count > 0)
                    {
                        this.txtPendientesNavideños.Text = lstCuotasNavideñas.Count.ToString();
                        this.txtCuentaNavideño.Text = lstCuotasNavideñas[0].strCuenta;
                        this.txtValorCuotaNavideño.Text = lstCuotasNavideñas[0].decValorCuota.ToString();
                        this.pmtdHabilitarControlesAhorrosNavideños(true);
                    }

                    List<cuotasPendientes> lstCuotasaFuturo = new List<cuotasPendientes>();

                    lstCuotasaFuturo = new blAhorrosaFuturo().gmtdConsultarCuotasPendentes(this.txtCedula.Text, -1);

                    if (lstCuotasaFuturo.Count > 0)
                    {
                        this.txtPendientesaFuturo.Text = lstCuotasaFuturo.Count.ToString();
                        this.txtCuentaaFuturo.Text = lstCuotasaFuturo[0].strCuenta;
                        this.txtValorCuotaaFuturo.Text = lstCuotasaFuturo[0].decValorCuota.ToString();
                        this.pmtdHabilitarControlesAhorrosaFuturo(true);
                    }

                    List<cuotasPendientesNatilleEscolar> lstCuotasNatilleraEscolar = new List<cuotasPendientesNatilleEscolar>();

                    lstCuotasNatilleraEscolar = new blAhorrosNatilleraEscolar().gmtdConsultarCuotasPendentes(this.txtCedula.Text, -1);

                    if (lstCuotasNatilleraEscolar.Count > 0)
                    {
                        this.txtPendientesNatilleraEscolar.Text = lstCuotasNatilleraEscolar.Count.ToString();
                        this.txtCuentaNatilleraEscolar.Text = lstCuotasNatilleraEscolar[0].strCuenta;
                        this.txtValorCuotaNatilleraEscolar.Text = lstCuotasNatilleraEscolar[0].decValorCuota.ToString();
                        this.pmtdHabilitarControlesAhorrosNatilleraEscolar(true);
                    }
                }

                List<tblVenta> lstVentas = new blVentas().gmtdConsultarVentasxCedula(this.txtCedula.Text);
                if (lstVentas.Count > 0)
                {
                    if (this.txtNombre.Text.Trim() == "")
                    {
                        this.txtNombre.Text = lstVentas[0].strNombreCliente;
                    }

                    this.pmtdHabilitarControlesAbonoaVentas(true);
                }

                //Habilita los datos para los recibos de otros ingresos.
                this.pmtdHabilitarControlesOtrosIngresos(true);
                this.chkOtrosIngresos.Checked = false;

                if (this.txtNombre.Text.Trim() == "")
                {
                    tblCliente cliente = new blCliente().gmtdConsultar(this.txtCedula.Text);
                    if (cliente.strContacto != null)
                    {
                        this.txtNombre.Text = cliente.strContacto;
                    }
                }

                lstDeudasUno = new blDeudas().gmtdConsultarDeudasxSocio(this.txtCedula.Text);
                if (this.lstDeudasUno.Count > 0)
                {
                    this.pmtdHabilitarControlesAbonoaDeuda(true);
                }

                this.pmtdConsultarEstadosdeCuenta(this.txtCedula.Text);
            }
        }

        private void dgvPrestamosCuotas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 5)
            {
                this.dgvPrestamosCuotas[e.ColumnIndex, e.RowIndex].Value = Convert.ToDecimal(this.dgvPrestamosCuotas[1, e.RowIndex].Value) + Convert.ToDecimal(this.dgvPrestamosCuotas[2, e.RowIndex].Value) + Convert.ToDecimal(this.dgvPrestamosCuotas[3, e.RowIndex].Value) + Convert.ToDecimal(this.dgvPrestamosCuotas[5, e.RowIndex].Value);
            }
        }

        private void dgvAgraciados_DoubleClick(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(this.dgvAgraciados.Rows[this.dgvAgraciados.CurrentRow.Index].Cells[2].Value) == false)
            {
                var query = from ben in lstAgraciados
                            where ben.strCedulaAgra == this.dgvAgraciados.Rows[this.dgvAgraciados.CurrentRow.Index].Cells[0].Value.ToString()
                            select ben;

                if (query.ToList().Count > 0)
                {
                    Agraciado agraciado = query.ToList()[0];

                    personasaModificar objPersona = new personasaModificar();
                    objPersona.dtmFechaNacimeinto = agraciado.dtmFechaNac;
                    objPersona.intCodigoSoc = agraciado.intCodigoSoc;
                    objPersona.strApellido1 = agraciado.strApellido1;
                    objPersona.strApellido2 = agraciado.strApellido2;
                    objPersona.strCedula = agraciado.strCedulaAgra;
                    objPersona.strDireccion = agraciado.strDireccion;
                    objPersona.strNombre = agraciado.strNombreAgra;
                    objPersona.strProcedencia = "Agraciado";
                    objPersona.strTelefono = agraciado.strTelefono;

                    FrmActualizarDatos actualizar = new FrmActualizarDatos(objPersona);
                    actualizar.ShowDialog();

                    lstAgraciados = new blAgraciado().gmtdConsultar(objPersona.intCodigoSoc);

                    this.dgvAgraciados.AutoGenerateColumns = false;
                    this.dgvAgraciados.DataSource = lstAgraciados;
                    this.pmtdPintarGridAgraciados();
                }
            }
        }

        private void btnAnulado_Click(object sender, EventArgs e)
        {
            this.tabAbonoaPrestamo.ForeColor = Color.AliceBlue;
        }

        private void cboDeudas1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtAbonaDeuda1.Focus();
            }
        }

        private void cboDeudas1_Leave(object sender, EventArgs e)
        {
            this.txtDebeDeuda1.Text = lstDeudasUno[this.cboDeudas1.SelectedIndex].decDebeDeu.ToString();
        }

        private void txtAbonaDeuda1_TextChanged(object sender, EventArgs e)
        {
            if (this.txtAbonaDeuda1.Text.Trim() == "")
            {
                this.txtAbonaDeuda1.Text = "0";
            }
            this.pmtdCalcularGranTotal();
        }

        private void txtCuotasNatilleraEscolar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnGuardar.Focus();
            }
        }

        private void txtCuotasNatilleraEscolar_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(this.txtCuotasNatilleraEscolar.Text) > Convert.ToInt16(this.txtPendientesNatilleraEscolar.Text))
            {
                MessageBox.Show("Las cuotas a pagar no puede ser mayor a la adeudadas.", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtCuotasNatilleraEscolar.Text = "0";
                this.txtTotalAhorroNatilleraEscolar.Text = "0";

                List<cuotasPendientesNatilleEscolar> lstLimpiarCuotas = new blAhorrosNatilleraEscolar().gmtdConsultarCuotasPendentes(this.txtCedula.Text, 0);

                this.dgvAhorrosNatilleraEscolar.AutoGenerateColumns = false;
                this.dgvAhorrosNatilleraEscolar.DataSource = lstLimpiarCuotas;
                return;
            }

            List<cuotasPendientesNatilleEscolar> lstCuotasOrganizadas = new blAhorrosNatilleraEscolar().gmtdConsultarCuotasPendentes(this.txtCedula.Text, Convert.ToInt16(this.txtCuotasNatilleraEscolar.Text));

            this.dgvAhorrosNatilleraEscolar.AutoGenerateColumns = false;
            this.dgvAhorrosNatilleraEscolar.DataSource = lstCuotasOrganizadas;

            this.pmtdCalcularSumadeCuotasdeAhorroNatilleraEscolar();
        }

        private void txtTotalAhorroNatilleraEscolar_TextChanged(object sender, EventArgs e)
        {
            if (this.txtTotalAhorroNatilleraEscolar.Text.Trim() == "")
            {
                this.txtTotalAhorroNatilleraEscolar.Text = "0";
            }

            this.pmtdCalcularGranTotal();
        }

        private void chkAhorrosNatilleraEscolar_Click(object sender, EventArgs e)
        {
            this.txtCuotasNatilleraEscolar.Text = "0";
            List<cuotasPendientesNatilleEscolar> lstCuotasOrganizadas = new blAhorrosNatilleraEscolar().gmtdConsultarCuotasPendentes(this.txtCedula.Text, 0);
            this.dgvAhorrosNatilleraEscolar.AutoGenerateColumns = false;
            this.dgvAhorrosNatilleraEscolar.DataSource = lstCuotasOrganizadas;

            if (this.chkAhorrosNatilleraEscolar.Checked == true)
            {
                this.txtCuotasNatilleraEscolar.Enabled = true;
                this.txtCuotasNatilleraEscolar.Focus();
            }
            else
            {
                this.txtCuotasNatilleraEscolar.Enabled = false;
            }
        }
    }
}

