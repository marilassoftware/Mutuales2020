using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libMutuales2020.dao;

namespace libMutuales2020.logica
{
    public class blAhorrosIntereses
    {
        /// <summary> Consulta si ya hay intereses registrados a un determinado año y trimestre en ahorradores ordinarios. </summary>
        /// <param name="tintAño"> Año a consultar. </param>
        /// <param name="tintMes"> Trimestre a consultar. </param>
        /// <returns> Un valor que indica si ya aparece o no registros para ese año y trimestre. </returns>
        public bool gmtdConsultarAñoyTrimestreAhorrosOrdinarios(int tintAño, int tintMes)
        {
            return new daoAhorrosIntereses().gmtdConsultarAñoyTrimestreAhorrosOrdinarios(tintAño, tintMes);
        }

        /// <summary> Consulta si ya hay intereses registrados a un determinado año y trimestre en ahorradores estudiantiles. </summary>
        /// <param name="tintAño"> Año a consultar. </param>
        /// <param name="tintMes"> Trimestre a consultar. </param>
        /// <returns> Un valor que indica si ya aparece o no registros para ese año y trimestre. </returns>
        public bool gmtdConsultarAñoyTrimestreAhorrosEstudiantiles(int tintAño, int tintMes)
        {
            return new daoAhorrosIntereses().gmtdConsultarAñoyTrimestreAhorrosEstudiantiles(tintAño, tintMes);
        }

    }
}
