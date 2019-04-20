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
    public class blAhorrosNavideno
    {
        /// <summary> Inserta una cuenta de ahorro navideño. </summary>
        /// <param name="tobjAhorroaFuturo"> Un objeto del tipo ahorro navideño. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblAhorrosNavideno tobjAhorroNavideno)
        {
            if (tobjAhorroNavideno.fltValorCuota == 0)
            {
                return "- Debe de ingresar el valor de la cuota. ";
            }

            if (tobjAhorroNavideno.intAno == 0)
            {
                return "- Debe de ingresar el año al que pertenece la cuenta. ";
            }

            if (tobjAhorroNavideno.strCedulaAho == null)
            {
                return "- Debe de ingresar la cédula del ahorrador para la cuenta. ";
            }

            if (tobjAhorroNavideno.strCuenta == null)
            {
                return "- Debe de ingresar el número de la cuenta. ";
            }

            if (tobjAhorroNavideno.strCuenta.Length != 8)
            {
                return "- El número de la cuenta debe de ser de 4 digitos. ";
            }

            tobjAhorroNavideno.bitAnulado = false;
            tobjAhorroNavideno.dtmAnulado = Convert.ToDateTime("1900/01/01");

            tobjAhorroNavideno.log = metodos.gmtdLog("Ingresa el ahorro Navideño.  " + tobjAhorroNavideno.strCuenta, tobjAhorroNavideno.strFormulario);

            tblAhorrosNavideno aho = new daoAhorrosNavideno().gmtdConsultarxCuentayAño(tobjAhorroNavideno.strCuenta, tobjAhorroNavideno.intAno);

            if (aho.strCuenta == null)
            {
                string strCuenta = tobjAhorroNavideno.strCuenta;

                List<tblSemana> lstSemanas = new blSemana().gmtdConsultarSemanasxAñoxTipo(tobjAhorroNavideno.intAno, "Ahorro Navideño");

                List<tblAhorrosNavidenoDetalle> lstahorroDetalle = new List<tblAhorrosNavidenoDetalle>();
                foreach (tblSemana semana in lstSemanas)
                {
                    tblAhorrosNavidenoDetalle ahorroDetalle = new tblAhorrosNavidenoDetalle();
                    ahorroDetalle.bitPagada = false;
                    ahorroDetalle.dtmFechaCuota = semana.dtmFechaSem;
                    ahorroDetalle.dtmFechaPago = Convert.ToDateTime("1900/01/01");
                    ahorroDetalle.strCuenta = strCuenta;
                    lstahorroDetalle.Add(ahorroDetalle);
                }
                tobjAhorroNavideno.lstMeses = lstahorroDetalle;
                return new daoAhorrosNavideno().gmtdInsertar(tobjAhorroNavideno);
            }
            else
            {
                return "Esta cuenta ya aparece registrada. ";
            }
        }

        /// <summary> Consulta todos los cuentas registradas. </summary>
        /// <returns> Un lista con todos las cuentas seleccionadas. </returns>
        public IList<AhorroNavideno> gmtdConsultarTodos()
        {
            return new daoAhorrosNavideno().gmtdConsultarTodos();
        }

        /// <summary> Consulta una determinada cuenta. </summary>
        /// <param name="tstrCuenta">el código de la cuenta consultar.</param>
        /// <returns> un objeto del tipo tblAhorrosNavideño. </returns>
        public tblAhorrosNavideno gmtdConsultar(string tstrCuenta)
        {
            return new daoAhorrosNavideno().gmtdConsultar(tstrCuenta);
        }

        /// <summary> Elimina una cuenta de ahorro Navideño. </summary>
        /// <param name="tobjAhorrosaFuturo"> Un objeto del tipo tblAhorrosNavideño. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblAhorrosNavideno tobjAhorrosNavideno)
        {
            if (tobjAhorrosNavideno.strCuenta == null || tobjAhorrosNavideno.strCuenta == "")
                return "Debe de ingresar el número de cuenta a eliminar. ";

            tblAhorrosNavidenoDetalle ahorro = new daoAhorrosNavideno().gmtdConsultarDetalle(tobjAhorrosNavideno.strCuenta);

            if (ahorro.strCuenta != null)
                return "No se puede eliminar por que tiene al menos una cuota paga. ";

            tobjAhorrosNavideno.log = metodos.gmtdLog("Elimina el ahorro navideño.  " + tobjAhorrosNavideno.strCuenta, tobjAhorrosNavideno.strFormulario);

            return new daoAhorrosNavideno().gmtdEliminar(tobjAhorrosNavideno);
        }

        /// <summary> Consulta los datos de la liquidación de una cuenta de ahorro Navideño. </summary>
        /// <param name="tstrCuenta"> Cuenta de la que se desea conocer los datos de liquidación. </param>
        /// <returns> Un objeto con los datos de la liquidacion. </returns>
        public LiquidacionAhorroNavideno gmtdCalcularLiquidacionAhorroNavideno(string tstrCuenta)
        {
            int intAño = 0;
            if(new daoAhorrosNavideno().gmtdConsultarCuentaActiva(tstrCuenta).strCuenta != null)
            {
                intAño = new daoAhorrosNavideno().gmtdConsultarCuentaActiva(tstrCuenta).intAno;
            }

            LiquidacionAhorroNavideno liquidacion = new daoAhorrosNavideno().gmtdCalcularLiquidacionAhorroNavideno(tstrCuenta, intAño);

            liquidacion.decPorcentajeCuotasPagadas = ((liquidacion.intCuotasPagadas * 100) / 52);

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
                    if (liquidacion.decPorcentajeCuotasPagadas > 50 && liquidacion.decPorcentajeCuotasPagadas < 100)
                    {
                        liquidacion.decDescuento = (liquidacion.decTotalRecaudado * Convert.ToDecimal(0.05));
                    }
                    else
                    {
                        liquidacion.decDescuento = (liquidacion.decTotalRecaudado * Convert.ToDecimal(0.1));
                    }
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
        public string gmtdLiquidarAhorroNavideno(LiquidacionAhorroNavideno tobjLiquidacion, string pstrUsuario, string pstrMaquina)
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

            tobjLiquidacion.strCedulaAho = new blAhorrosNavideno().gmtdConsultar(tobjLiquidacion.strCuenta).strCedulaAho;

            return new daoAhorrosNavideno().gmtdLiquidarAhorroNavideno(tobjLiquidacion, pstrUsuario, pstrMaquina);
        }

        /// <summary> Consultas las cuotas a pagar de un ahorro navideño. </summary>
        /// <param name="tstrCedula"> Cédula del ahorrador a consultarle las cuotas pendientes. </param>
        /// <returns> </returns>
        public List<cuotasPendientes> gmtdConsultarCuotasPendentes(string tstrCedula, int tintCuotasaSeleccionar)
        {
            List<cuotasPendientes> lstCuotas = new daoAhorrosNavideno().gmtdConsultarCuotasPendintes(tstrCedula);
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

        /// <summary> Elimina la liquidación de una cuenta de ahorro navideño. </summary>
        /// <param name="tobjCuentaLiquidad"> Un objeto con el código de la cuenta a eliminar. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEliminarLiquidaciondeCuenta(LiquidacionAhorroNavideno tobjCuentaLiquidada)
        {
            if (new daoAhorrosNavideno().gmtdConsultarCuentaLiquidada(tobjCuentaLiquidada.strCuenta).strCuenta == null)
                return "- No se puede eliminar la liquidación de cuenta por que no aparece liquidada. ";

            LiquidacionAhorroNavideno consulta = new daoAhorrosNavideno().gmtdConsultarCuentaLiquidada(tobjCuentaLiquidada.strCuenta);

            tobjCuentaLiquidada.intCodigoEgr = consulta.intCodigoEgr;
            tobjCuentaLiquidada.intCodigoIng = consulta.intCodigoIng;

            tobjCuentaLiquidada.log = metodos.gmtdLog("Elimina la liquidación de ahorro Navideño.  " + tobjCuentaLiquidada.strCuenta, tobjCuentaLiquidada.strFormulario);

            return new daoAhorrosNavideno().gmtdEliminarLiquidaciondeCuenta(tobjCuentaLiquidada);

        }

    }
}
