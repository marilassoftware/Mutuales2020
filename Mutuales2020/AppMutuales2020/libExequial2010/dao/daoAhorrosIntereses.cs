using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libMutuales2020.dominio;

namespace libMutuales2020.dao
{
    public class daoAhorrosIntereses
    {
        /// <summary> Consulta si ya hay intereses registrados a un determinado año y trimestre en ahorradores ordinarios. </summary>
        /// <param name="tintAño"> Año a consultar. </param>
        /// <param name="tintMes"> Trimestre a consultar. </param>
        /// <returns> Un valor que indica si ya aparece o no registros para ese año y trimestre. </returns>
        public bool gmtdConsultarAñoyTrimestreAhorrosOrdinarios(int tintAño, int tintMes)
        {
            using (dbExequial2010DataContext intereses = new dbExequial2010DataContext())
            {
                var query = from interes in intereses.tblAhorrosInteresesHistoricos
                            where interes.intAño == tintAño && interes.intTrimestre == tintMes
                            select interes;

                if (query.ToList().Count > 0)
                    return true;
                else
                    return false;
            }

        }

        /// <summary> Consulta si ya hay intereses registrados a un determinado año y trimestre en ahorradores estudiantiles. </summary>
        /// <param name="tintAño"> Año a consultar. </param>
        /// <param name="tintMes"> Trimestre a consultar. </param>
        /// <returns> Un valor que indica si ya aparece o no registros para ese año y trimestre. </returns>
        public bool gmtdConsultarAñoyTrimestreAhorrosEstudiantiles(int tintAño, int tintMes)
        {
            using (dbExequial2010DataContext intereses = new dbExequial2010DataContext())
            {
                var query = from interes in intereses.tblAhorrosInteresesHistoricoEstudiantils
                            where interes.intAño == tintAño && interes.intTrimestre == tintMes
                            select interes;

                if (query.ToList().Count > 0)
                    return true;
                else
                    return false;
            }

        }

    }
}


