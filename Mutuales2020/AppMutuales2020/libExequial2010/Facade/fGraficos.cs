namespace libMutuales2020.Facade
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fGraficos
    {
        /// <summary> Ejecuta un sp que deshabilita los socio (Recesa) </summary>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public Dictionary<string, int> gmtdConsultaSociosporEdades()
        {
            return new blGraficos().gmtdConsultaSociosporEdades();
        }
    }
}
