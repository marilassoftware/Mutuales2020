using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using libMutuales2020.dominio;
using libMutuales2020.dao;

namespace libMutuales2020.logica
{
    [DataObject(true)]
    public class blAhorrosaFuturo
    {
        /// <summary> Inserta una cuenta de ahorro a futuro. </summary>
        /// <param name="tobjAhorroaFuturo"> Un objeto del tipo ahorro a futuro. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblAhorrosaFuturo tobjAhorroaFuturo)
        {
            if (tobjAhorroaFuturo.fltValorCuota == 0)
                return "- Debe de ingresar el valor de la cuota. ";

            if (tobjAhorroaFuturo.intAno == 0)
                return "- Debe de ingresar el año al que pertenece la cuenta. ";

            if (tobjAhorroaFuturo.strCedulaAho == null)
                return "- Debe de ingresar la cédula del ahorrador para la cuenta. ";

            if (tobjAhorroaFuturo.strCuenta == null)
                return "- Debe de ingresar el número de la cuenta. ";

            if (tobjAhorroaFuturo.strCuenta.Length != 4)
                return "- El número de la cuenta debe de ser de 4 digitos. ";

            tobjAhorroaFuturo.bitAnulado = false;
            tobjAhorroaFuturo.dtmAnulado = Convert.ToDateTime("1900/01/01");

            tobjAhorroaFuturo.log = metodos.gmtdLog("Ingresa el ahorro a futuro.  " + tobjAhorroaFuturo.strCuenta, tobjAhorroaFuturo.strFormulario);

            DateTime dtmFechaCuota = tobjAhorroaFuturo.dtmFechaCuenta;

            tblAhorrosaFuturo aho = new daoAhorrosaFuturo().gmtdConsultar(tobjAhorroaFuturo.strCuenta);

            if (aho.strCuenta == null)
            {
                for (int a = 0; a < 12; a++)
                {
                    tblAhorrosaFuturoDetalle ahorroDetalle = new tblAhorrosaFuturoDetalle();
                    ahorroDetalle.bitPagada = false;
                    ahorroDetalle.dtmFechaCuota = dtmFechaCuota;
                    ahorroDetalle.dtmFechaPago = Convert.ToDateTime("1900/01/01");
                    ahorroDetalle.strCuenta = tobjAhorroaFuturo.strCuenta;
                    tobjAhorroaFuturo.tblAhorrosaFuturoDetalles.Add(ahorroDetalle);

                    dtmFechaCuota = dtmFechaCuota.AddMonths(1);
                }

                return new daoAhorrosaFuturo().gmtdInsertar(tobjAhorroaFuturo);
            }
            else
                return "- Esta cuenta ya aparece registrada. ";
        }

        /// <summary> Consulta todos los cuentas registradas. </summary>
        /// <returns> Un lista con todos las cuentas seleccionadas. </returns>
        public IList<AhorroaFuturo> gmtdConsultarTodos()
        {
            return new daoAhorrosaFuturo().gmtdConsultarTodos();
        }

        /// <summary> Consulta una determinada cuenta. </summary>
        /// <param name="tstrCuenta">el código de la cuenta consultar.</param>
        /// <returns> un objeto del tipo tblAhorrosaFuturo. </returns>
        public tblAhorrosaFuturo gmtdConsultar(string tstrCuenta)
        {
            return new daoAhorrosaFuturo().gmtdConsultar(tstrCuenta);
        }

        /// <summary> Elimina una cuenta de ahorro a futuro. </summary>
        /// <param name="tobjAhorrosaFuturo"> Un objeto del tipo tblAhorrosaFuturo. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblAhorrosaFuturo tobjAhorrosaFuturo)
        {
            if (tobjAhorrosaFuturo.strCuenta == null || tobjAhorrosaFuturo.strCuenta == "")
                return "Debe de ingresar el número de cuenta a eliminar. ";

            tblAhorrosaFuturoDetalle ahorro = new daoAhorrosaFuturo().gmtdConsultarDeatlle(tobjAhorrosaFuturo.strCuenta);

            if (ahorro.strCuenta != null)
                return "No se puede eliminar por que tiene al menos una cuota paga. ";

            tobjAhorrosaFuturo.log = metodos.gmtdLog("Elimina el ahorro a futuro.  " + tobjAhorrosaFuturo.strCuenta, tobjAhorrosaFuturo.strFormulario);

            return new daoAhorrosaFuturo().gmtdEliminar(tobjAhorrosaFuturo);
        }

        /// <summary> Consulta los datos de la liquidación de una cuenta de ahorro a futuro. </summary>
        /// <param name="tstrCuenta"> Cuenta de la que se desea conocer los datos de liquidación. </param>
        /// <returns> Un objeto con los datos de la liquidacion. </returns>
        public LiquidacionAhorroaFuturo gmtdCalcularLiquidacionAhorroaFuturo(string tstrCuenta)
        {
            LiquidacionAhorroaFuturo liquidacion = new daoAhorrosaFuturo().gmtdCalcularLiquidacionAhorroaFuturo(tstrCuenta);

            liquidacion.decPorcentajeCuotasPagadas = ((liquidacion.intCuotasPagadas * 100) / 12);
            
            if (liquidacion.decPorcentajeCuotasPagadas >= 100)
                liquidacion.decDescuento = 0;
            else
            {
                liquidacion.decIntereses = 0;
                liquidacion.decPremios = 0;
                if (liquidacion.decPorcentajeCuotasPagadas > 50 && liquidacion.decPorcentajeCuotasPagadas < 100)
                    liquidacion.decDescuento = (liquidacion.decTotalRecaudado * Convert.ToDecimal(0.05));
                else
                    liquidacion.decDescuento = (liquidacion.decTotalRecaudado * Convert.ToDecimal(0.1));

            }

            liquidacion.decTotalLiquidacion = liquidacion.decIntereses + liquidacion.decPremios +liquidacion.decTotalRecaudado - liquidacion.decDescuento;

            return liquidacion;
        }

        /// <summary> Registra la liquidación de una cuenta de ahorro a futuro. </summary>
        /// <param name="tstrCuenta"> Cuenta de ahorro a futuro a liquidar. </param>
        /// <returns> Un string que indica si se registro o no la liquidación. </returns>
        public string gmtdLiquidarAhorroaFuturo(LiquidacionAhorroaFuturo tobjLiquidacion)
        {
            if (tobjLiquidacion.strCuenta == null || tobjLiquidacion.strCuenta.Trim() == "")
                return "- Debe de ingresar la cuenta que desea liquidar. ";
            
            if (tobjLiquidacion.decTotalRecaudado <= 0
                || tobjLiquidacion.intCuotasPagadas <= 0
                || tobjLiquidacion.decTotalLiquidacion <=0
                || tobjLiquidacion.decPorcentajeCuotasPagadas <= 0
                || tobjLiquidacion.strAhorrador == null
                || tobjLiquidacion.strAhorrador == "")
                if (tobjLiquidacion.strAhorrador != "")
                    return "- No se han hecho abonos para liquidar esta cuenta. ";
                else
                    return "- Faltan datos para registrar la liquidación. ";

            tobjLiquidacion.log = metodos.gmtdLog("Registra la liquidación de ahorro a futuro.  " + tobjLiquidacion.strCuenta, tobjLiquidacion.strFormulario);


            return new daoAhorrosaFuturo().gmtdLiquidarAhorroaFuturo(tobjLiquidacion);
        }

        /// <summary> Consultas las cuotas a pagar de un ahorro a futuro. </summary>
        /// <param name="tstrCedula"> Cédula del ahorrador a consultarle las cuotas pendientes. </param>
        /// <returns> </returns>
        public List<cuotasPendientes> gmtdConsultarCuotasPendentes(string tstrCedula, int tintCuotasaSeleccionar)
        {
            List<cuotasPendientes> lstCuotas = new daoAhorrosaFuturo().gmtdConsultarCuotasPendentes(tstrCedula);
            List<cuotasPendientes> lstCuotasSeleccionadas = new List<cuotasPendientes>();

            if (tintCuotasaSeleccionar != -1)
            {
                for (int a = 0; a < tintCuotasaSeleccionar; a++)
                    lstCuotasSeleccionadas.Add(lstCuotas[a]);

                return lstCuotasSeleccionadas;
            }
            else
                return lstCuotas;
        }

        /// <summary> Elimina la liquidación de una cuenta de ahorro a futuro. </summary>
        /// <param name="tobjCuentaLiquidad"> Un objeto con el código de la cuenta a aliminar. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEliminarLiquidaciondeCuenta(LiquidacionAhorroaFuturo tobjCuentaLiquidada)
        {
            if (new daoAhorrosaFuturo().gmtdConsultarCuentaLiquidada(tobjCuentaLiquidada.strCuenta).strCuenta == null)
                return "- No se puede eliminar la cuenta por que no aparece liquidada. ";

            LiquidacionAhorroaFuturo consulta = new daoAhorrosaFuturo().gmtdConsultarCuentaLiquidada(tobjCuentaLiquidada.strCuenta);

            tobjCuentaLiquidada.intCodigoEgr = consulta.intCodigoEgr;
            tobjCuentaLiquidada.intCodigoIng = consulta.intCodigoIng;

            tobjCuentaLiquidada.log = metodos.gmtdLog("Elimina la liquidación de ahorro a futuro.  " + tobjCuentaLiquidada.strCuenta, tobjCuentaLiquidada.strFormulario);

            return new daoAhorrosaFuturo().gmtdEliminarLiquidaciondeCuenta(tobjCuentaLiquidada);

        }

    }
}
