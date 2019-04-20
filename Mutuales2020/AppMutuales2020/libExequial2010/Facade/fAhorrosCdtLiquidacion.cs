namespace libMutuales2020.Facade
{
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fAhorrosCdtLiquidacion
    {
        /// <summary> Inserta una liquidacion de cdt. </summary>
        /// <param name="tobjAhorroaFuturo"> Un objeto del tipo liquidacion cdt. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblAhorrosCdtsLiquidacion tobjAhorroCdtLiquidacion)
        {
            return new blAhorrosCdtLiquidacion().gmtdInsertar(tobjAhorroCdtLiquidacion);
        }

        public tblAhorrosCdtsLiquidacion gmtdCalcularLiquidacion(int tintCdt)
        {
            return new blAhorrosCdtLiquidacion().gmtdCalcularLiquidacion(tintCdt);
        }

    }
}
