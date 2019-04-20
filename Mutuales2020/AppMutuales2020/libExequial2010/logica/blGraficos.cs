namespace libMutuales2020.logica
{
    using System.Collections.Generic;
    using libMutuales2020.dao;

    public class blGraficos
    {
        /// <summary> Ejecuta un sp que deshabilita los socio (Recesa) </summary>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public Dictionary<string, int> gmtdConsultaSociosporEdades()
        {
            return new daoGraficos().gmtdConsultaSociosporEdades();
        }
    }
}
