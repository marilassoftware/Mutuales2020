namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fAhorrosaFuturo
    {
        /// <summary> Inserta una cuenta de ahorro a futuro. </summary>
        /// <param name="tobjAhorroaFuturo"> Un objeto del tipo ahorro a futuro. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblAhorrosaFuturo tobjAhorroaFuturo)
        {
            return new blAhorrosaFuturo().gmtdInsertar(tobjAhorroaFuturo);
        }

        /// <summary> Consulta todos los cuentas registradas. </summary>
        /// <returns> Un lista con todos las cuentas seleccionadas. </returns>
        public IList<AhorroaFuturo> gmtdConsultarTodos()
        {
            return new blAhorrosaFuturo().gmtdConsultarTodos();
        }

        /// <summary> Consulta una determinada cuenta. </summary>
        /// <param name="tstrCuenta">el código de la cuenta consultar.</param>
        /// <returns> un objeto del tipo tblAhorrosaFuturo. </returns>
        public tblAhorrosaFuturo gmtdConsultar(string tstrCuenta)
        {
            return new blAhorrosaFuturo().gmtdConsultar(tstrCuenta);
        }

        /// <summary> Elimina una cuenta de ahorro a futuro. </summary>
        /// <param name="tobjAhorrosaFuturo"> Un objeto del tipo tblAhorrosaFuturo. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblAhorrosaFuturo tobjAhorrosaFuturo)
        {
            return new blAhorrosaFuturo().gmtdEliminar(tobjAhorrosaFuturo);
        }

        /// <summary> Consulta los datos de la liquidación de una cuenta de ahorro a futuro. </summary>
        /// <param name="tstrCuenta"> Cuenta de la que se desea conocer los datos de liquidación. </param>
        /// <returns> Un objeto con los datos de la liquidacion. </returns>
        public LiquidacionAhorroaFuturo gmtdCalcularLiquidacionAhorroaFuturo(string tstrCuenta)
        {
            return new blAhorrosaFuturo().gmtdCalcularLiquidacionAhorroaFuturo(tstrCuenta);
        }

        /// <summary> Registra la liquidación de una cuenta de ahorro a futuro. </summary>
        /// <param name="tstrCuenta"> Cuenta de ahorro a futuro a liquidar. </param>
        /// <returns> Un string que indica si se registro o no la liquidación. </returns>
        public string gmtdLiquidarAhorroaFuturo(LiquidacionAhorroaFuturo tobjLiquidacion)
        {
            return new blAhorrosaFuturo().gmtdLiquidarAhorroaFuturo(tobjLiquidacion);
        }

        /// <summary> Consultas las cuotas a pagar de un ahorro a futuro. </summary>
        /// <param name="tstrCedula"> Cédula del ahorrador a consultarle las cuotas pendientes. </param>
        /// <returns> </returns>
        public List<cuotasPendientes> gmtdConsultarCuotasPendentes(string tstrCedula, int tintCuotasaSeleccionar)
        {
            return new blAhorrosaFuturo().gmtdConsultarCuotasPendentes(tstrCedula, tintCuotasaSeleccionar);
        }

        /// <summary> Elimina la liquidación de una cuenta de ahorro a futuro. </summary>
        /// <param name="tobjCuentaLiquidad"> Un objeto con el código de la cuenta a aliminar. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEliminarLiquidaciondeCuenta(LiquidacionAhorroaFuturo tobjCuentaLiquidada)
        {
            return new blAhorrosaFuturo().gmtdEliminarLiquidaciondeCuenta(tobjCuentaLiquidada);
        }

    }
}
