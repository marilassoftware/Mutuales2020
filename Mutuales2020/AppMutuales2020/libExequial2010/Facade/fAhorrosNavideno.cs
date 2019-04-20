namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fAhorrosNavideno
    {
        /// <summary> Inserta una cuenta de ahorro navideño. </summary>
        /// <param name="tobjAhorroaFuturo"> Un objeto del tipo ahorro navideño. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblAhorrosNavideno tobjAhorroNavideno)
        {
            return new blAhorrosNavideno().gmtdInsertar(tobjAhorroNavideno);
        }

        /// <summary> Consulta todos los cuentas registradas. </summary>
        /// <returns> Un lista con todos las cuentas seleccionadas. </returns>
        public IList<AhorroNavideno> gmtdConsultarTodos()
        {
            return new blAhorrosNavideno().gmtdConsultarTodos();
        }

        /// <summary> Consulta una determinada cuenta. </summary>
        /// <param name="tstrCuenta">el código de la cuenta consultar.</param>
        /// <returns> un objeto del tipo tblAhorrosNavideño. </returns>
        public tblAhorrosNavideno gmtdConsultar(string tstrCuenta)
        {
            return new blAhorrosNavideno().gmtdConsultar(tstrCuenta);
        }

        /// <summary> Elimina una cuenta de ahorro Navideño. </summary>
        /// <param name="tobjAhorrosaFuturo"> Un objeto del tipo tblAhorrosNavideño. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblAhorrosNavideno tobjAhorrosNavideno)
        {
            return new blAhorrosNavideno().gmtdEliminar(tobjAhorrosNavideno);
        }

        /// <summary> Consulta los datos de la liquidación de una cuenta de ahorro Navideño. </summary>
        /// <param name="tstrCuenta"> Cuenta de la que se desea conocer los datos de liquidación. </param>
        /// <returns> Un objeto con los datos de la liquidacion. </returns>
        public LiquidacionAhorroNavideno gmtdCalcularLiquidacionAhorroNavideno(string tstrCuenta)
        {
            return new blAhorrosNavideno().gmtdCalcularLiquidacionAhorroNavideno(tstrCuenta);
        }

        /// <summary> Registra la liquidación de una cuenta de ahorro Navideño. </summary>
        /// <param name="tstrCuenta"> Cuenta de ahorro navideño a liquidar. </param>
        /// <returns> Un string que indica si se registro o no la liquidación. </returns>
        public string gmtdLiquidarAhorroNavideno(LiquidacionAhorroNavideno tobjLiquidacion, string pstrUsuario, string pstrMaquina)
        {
            return new blAhorrosNavideno().gmtdLiquidarAhorroNavideno(tobjLiquidacion, pstrUsuario, pstrMaquina);
        }

        /// <summary> Consultas las cuotas a pagar de un ahorro navideño. </summary>
        /// <param name="tstrCedula"> Cédula del ahorrador a consultarle las cuotas pendientes. </param>
        /// <returns> </returns>
        public List<cuotasPendientes> gmtdConsultarCuotasPendentes(string tstrCedula, int tintCuotasaSeleccionar)
        {
            return new blAhorrosNavideno().gmtdConsultarCuotasPendentes(tstrCedula, tintCuotasaSeleccionar);
        }

        /// <summary> Elimina la liquidación de una cuenta de ahorro navideño. </summary>
        /// <param name="tobjCuentaLiquidad"> Un objeto con el código de la cuenta a eliminar. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEliminarLiquidaciondeCuenta(LiquidacionAhorroNavideno tobjCuentaLiquidada)
        {
            return new blAhorrosNavideno().gmtdEliminarLiquidaciondeCuenta(tobjCuentaLiquidada);

        }
    }
}
