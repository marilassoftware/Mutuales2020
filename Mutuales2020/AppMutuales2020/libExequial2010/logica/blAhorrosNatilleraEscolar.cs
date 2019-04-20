using System;
using System.Collections.Generic;
using libMutuales2020.dao;
using libMutuales2020.dominio;

namespace libMutuales2020.logica
{
    public class blAhorrosNatilleraEscolar
    {
        /// <summary> Inserta una cuenta de ahorro navideño. </summary>
        /// <param name="tobjAhorroaFuturo"> Un objeto del tipo ahorro navideño. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblAhorrosNatilleraEscolar tobjAhorroNatilleraEscolar)
        {
            if (tobjAhorroNatilleraEscolar.fltValorCuota == 0)
            {
                return "- Debe de ingresar el valor de la cuota. ";
            }

            if (tobjAhorroNatilleraEscolar.intAno == 0)
            {
                return "- Debe de ingresar el año al que pertenece la cuenta. ";
            }

            if (tobjAhorroNatilleraEscolar.strCedulaAho == null)
            {
                return "- Debe de ingresar la cédula del ahorrador para la cuenta. ";
            }

            if (tobjAhorroNatilleraEscolar.strCuenta == null)
            {
                return "- Debe de ingresar el número de la cuenta. ";
            }

            if (tobjAhorroNatilleraEscolar.strCuenta.Length != 8)
            {
                return "- El número de la cuenta debe de ser de 4 digitos. ";
            }

            tobjAhorroNatilleraEscolar.bitAnulado = false;
            tobjAhorroNatilleraEscolar.dtmAnulado = Convert.ToDateTime("1900/01/01");

            tobjAhorroNatilleraEscolar.log = metodos.gmtdLog("Ingresa el ahorro Navideño.  " + tobjAhorroNatilleraEscolar.strCuenta, tobjAhorroNatilleraEscolar.strFormulario);

            tblAhorrosNatilleraEscolar aho = new daoAhorrosNatilleraEscolar().gmtdConsultarxCuentayAño(tobjAhorroNatilleraEscolar.strCuenta, tobjAhorroNatilleraEscolar.intAno);

            if (aho.strCuenta == null)
            {
                string strCuenta = tobjAhorroNatilleraEscolar.strCuenta;

                List<tblSemana> lstSemanas = new blSemana().gmtdConsultarSemanasxAñoxTipo(tobjAhorroNatilleraEscolar.intAno, "Natillera Escolar");

                List<tblAhorrosNatilleraEscolarDetalle> lstAhorroDetalle = new List<tblAhorrosNatilleraEscolarDetalle>();
                foreach (tblSemana semana in lstSemanas)
                {
                    tblAhorrosNatilleraEscolarDetalle ahorroDetalle = new tblAhorrosNatilleraEscolarDetalle();
                    ahorroDetalle.bitPagada = false;
                    ahorroDetalle.dtmFechaCuota = semana.dtmFechaSem;
                    ahorroDetalle.dtmFechaPago = Convert.ToDateTime("1900/01/01");
                    ahorroDetalle.strCuenta = strCuenta;
                    lstAhorroDetalle.Add(ahorroDetalle);
                }

                tobjAhorroNatilleraEscolar.intCuotas = lstSemanas.Count;
                tobjAhorroNatilleraEscolar.lstMeses = lstAhorroDetalle;
                return new daoAhorrosNatilleraEscolar().gmtdInsertar(tobjAhorroNatilleraEscolar);
            }
            else
            {
                return "Esta cuenta ya aparece registrada. ";
            }
        }

        /// <summary> Consulta todos los cuentas registradas. </summary>
        /// <returns> Un lista con todos las cuentas seleccionadas. </returns>
        public IList<AhorroNatilleraEscolar> gmtdConsultarTodos()
        {
            return new daoAhorrosNatilleraEscolar().gmtdConsultarTodos();
        }

        /// <summary> Consulta una determinada cuenta. </summary>
        /// <param name="tstrCuenta">el código de la cuenta consultar.</param>
        /// <returns> un objeto del tipo tblAhorrosNavideño. </returns>
        public tblAhorrosNatilleraEscolar gmtdConsultar(string tstrCuenta)
        {
            return new daoAhorrosNatilleraEscolar().gmtdConsultar(tstrCuenta);
        }

        /// <summary> Elimina una cuenta de ahorro Navideño. </summary>
        /// <param name="tobjAhorrosaFuturo"> Un objeto del tipo tblAhorrosNavideño. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblAhorrosNatilleraEscolar tobjAhorrosNavideno)
        {
            if (tobjAhorrosNavideno.strCuenta == null || tobjAhorrosNavideno.strCuenta == "")
            {
                return "Debe de ingresar el número de cuenta a eliminar. ";
            }

            tblAhorrosNatilleraEscolarDetalle ahorro = new daoAhorrosNatilleraEscolar().gmtdConsultarDetalle(tobjAhorrosNavideno.strCuenta);

            if (ahorro.strCuenta != null)
            {
                return "No se puede eliminar por que tiene al menos una cuota paga. ";
            }

            tobjAhorrosNavideno.log = metodos.gmtdLog("Elimina el ahorro navideño.  " + tobjAhorrosNavideno.strCuenta, tobjAhorrosNavideno.strFormulario);

            return new daoAhorrosNatilleraEscolar().gmtdEliminar(tobjAhorrosNavideno);
        }

        /// <summary> Consulta los datos de la liquidación de una cuenta de ahorro Navideño. </summary>
        /// <param name="tstrCuenta"> Cuenta de la que se desea conocer los datos de liquidación. </param>
        /// <returns> Un objeto con los datos de la liquidacion. </returns>
        public LiquidacionAhorroNatilleraEscolar gmtdCalcularLiquidacionAhorroNatilleraEscolar(string tstrCuenta)
        {
            int intAño = 0;
            if (new daoAhorrosNatilleraEscolar().gmtdConsultarCuentaActiva(tstrCuenta).strCuenta != null)
            {
                intAño = new daoAhorrosNatilleraEscolar().gmtdConsultarCuentaActiva(tstrCuenta).intAno;
            }

            LiquidacionAhorroNatilleraEscolar liquidacion = new daoAhorrosNatilleraEscolar().gmtdCalcularLiquidacionAhorroNatilleraEscolar(tstrCuenta, intAño);

            liquidacion.decPorcentajeCuotasPagadas = ((liquidacion.intCuotasPagadas * 100) / 38);

            if (liquidacion.decPorcentajeCuotasPagadas >= 100)
            {
                liquidacion.decDescuento = 0;
            }
            else
            {
                if (liquidacion.bitAplicarMulta)
                {
                    liquidacion.decIntereses = 0;
                    liquidacion.decPremios = 0;
                    //if (liquidacion.decPorcentajeCuotasPagadas > 50 && liquidacion.decPorcentajeCuotasPagadas < 100)
                    //{
                    //    liquidacion.decDescuento = (liquidacion.decTotalRecaudado * Convert.ToDecimal(0.05));
                    //}
                    //else
                    //{
                    //    liquidacion.decDescuento = (liquidacion.decTotalRecaudado * Convert.ToDecimal(0.1));
                    //}
                    liquidacion.decDescuento = 0;
                }
                else
                {
                    liquidacion.decDescuento = 0;
                }
            }

            liquidacion.decTotalLiquidacion = liquidacion.decIntereses + liquidacion.decPremios + liquidacion.decTotalRecaudado - liquidacion.decDescuento;

            return liquidacion;
        }

        /// <summary> Registra la liquidación de una cuenta de ahorro Navideño. </summary>
        /// <param name="tstrCuenta"> Cuenta de ahorro navideño a liquidar. </param>
        /// <param name="pstrUsuario"> Usuario que hizo la liquidación. </param>
        /// <param name="pstrMaquina"> Maquina desde la quie se hizo la operación. </param>
        /// <returns> Un string que indica si se registro o no la liquidación. </returns>
        public string gmtdLiquidarAhorroNatilleraEscolar(LiquidacionAhorroNatilleraEscolar tobjLiquidacion, string pstrUsuario, string pstrMaquina)
        {
            if (tobjLiquidacion.strCuenta == null || tobjLiquidacion.strCuenta.Trim() == "")
            {
                return "- Debe de ingresar la cuenta que desea liquidar. ";
            }

            if (tobjLiquidacion.decTotalRecaudado <= 0
                || tobjLiquidacion.intCuotasPagadas <= 0
                || tobjLiquidacion.decTotalLiquidacion <= 0
                || tobjLiquidacion.decPorcentajeCuotasPagadas <= 0
                || tobjLiquidacion.strAhorrador == null
                || tobjLiquidacion.strAhorrador == "")
            {
                if (tobjLiquidacion.strAhorrador != "")
                {
                    return "- No se han hecho abonos para liquidar esta cuenta. ";
                }
                else
                {
                    return "- Faltan datos para registrar la liquidación. ";
                }
            }

            tobjLiquidacion.log = metodos.gmtdLog("Registra la liquidación de ahorro Navideño.  " + tobjLiquidacion.strCuenta, "FrmAhorrosNavideñoLiquidacion");

            tobjLiquidacion.strCedulaAho = new blAhorrosNatilleraEscolar().gmtdConsultar(tobjLiquidacion.strCuenta).strCedulaAho;

            return new daoAhorrosNatilleraEscolar().gmtdLiquidarAhorroNatilleraEscolar(tobjLiquidacion, pstrUsuario, pstrMaquina);
        }

        /// <summary> Consultas las cuotas a pagar de un ahorro navideño. </summary>
        /// <param name="tstrCedula"> Cédula del ahorrador a consultarle las cuotas pendientes. </param>
        /// <returns> </returns>
        public List<cuotasPendientesNatilleEscolar> gmtdConsultarCuotasPendentes(string tstrCedula, int tintCuotasaSeleccionar)
        {
            List<cuotasPendientesNatilleEscolar> lstCuotas = new daoAhorrosNatilleraEscolar().gmtdConsultarCuotasPendintes(tstrCedula);
            List<cuotasPendientesNatilleEscolar> lstCuotasSeleccionadas = new List<cuotasPendientesNatilleEscolar>();

            if (tintCuotasaSeleccionar != -1)
            {
                for (int a = 0; a < tintCuotasaSeleccionar; a++)
                {
                    lstCuotasSeleccionadas.Add(lstCuotas[a]);
                }

                return lstCuotasSeleccionadas;
            }
            else
            {
                return lstCuotas;
            }
        }

        /// <summary> Elimina la liquidación de una cuenta de ahorro navideño. </summary>
        /// <param name="tobjCuentaLiquidad"> Un objeto con el código de la cuenta a eliminar. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEliminarLiquidaciondeCuenta(LiquidacionAhorroNatilleraEscolar tobjCuentaLiquidada)
        {
            if (new daoAhorrosNatilleraEscolar().gmtdConsultarCuentaLiquidada(tobjCuentaLiquidada.strCuenta).strCuenta == null)
            {
                return "- No se puede eliminar la liquidación de cuenta por que no aparece liquidada. ";
            }

            LiquidacionAhorroNatilleraEscolar consulta = new daoAhorrosNatilleraEscolar().gmtdConsultarCuentaLiquidada(tobjCuentaLiquidada.strCuenta);

            tobjCuentaLiquidada.intCodigoEgr = consulta.intCodigoEgr;
            tobjCuentaLiquidada.intCodigoIng = consulta.intCodigoIng;

            tobjCuentaLiquidada.log = metodos.gmtdLog("Elimina la liquidación de ahorro Navideño.  " + tobjCuentaLiquidada.strCuenta, tobjCuentaLiquidada.strFormulario);

            return new daoAhorrosNatilleraEscolar().gmtdEliminarLiquidaciondeCuenta(tobjCuentaLiquidada);

        }
    }

}
