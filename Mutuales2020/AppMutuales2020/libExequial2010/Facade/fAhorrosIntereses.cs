namespace libMutuales2020.Facade
{
    using System.ComponentModel;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fAhorrosIntereses
    {
        /// <summary> Consulta si ya hay intereses registrados a un determinado año y trimestre en ahorradores ordinarios. </summary>
        /// <param name="tintAño"> Año a consultar. </param>
        /// <param name="tintMes"> Trimestre a consultar. </param>
        /// <returns> Un valor que indica si ya aparece o no registros para ese año y trimestre. </returns>
        public bool gmtdConsultarAñoyTrimestreAhorrosOrdinarios(int tintAño, int tintMes)
        {
            return new blAhorrosIntereses().gmtdConsultarAñoyTrimestreAhorrosOrdinarios(tintAño, tintMes);
        }

        /// <summary> Consulta si ya hay intereses registrados a un determinado año y trimestre en ahorradores estudiantiles. </summary>
        /// <param name="tintAño"> Año a consultar. </param>
        /// <param name="tintMes"> Trimestre a consultar. </param>
        /// <returns> Un valor que indica si ya aparece o no registros para ese año y trimestre. </returns>
        public bool gmtdConsultarAñoyTrimestreAhorrosEstudiantiles(int tintAño, int tintMes)
        {
            return new blAhorrosIntereses().gmtdConsultarAñoyTrimestreAhorrosEstudiantiles(tintAño, tintMes);
        }

    }
}
