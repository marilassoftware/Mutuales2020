using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libMutuales2020.dominio;
using libMutuales2020.dao;

namespace libMutuales2020.logica
{
    public class blAhorroNatilleraEscolarIntereses
    {
        public string gmtdInsertar(List<tblAhorrosNatilleraEscolarBonificacion> tobjAhorroNatilleraEscolarBonificacion)
        {
            string strResultado = "";
            foreach (tblAhorrosNatilleraEscolarBonificacion interes in tobjAhorroNatilleraEscolarBonificacion)
            {
                interes.log = metodos.gmtdLog("Ingresa intereses ahorro natillera escolar. " + interes.strCuenta, interes.strFormulario);
                strResultado = new daoAhorrosNatilleraEscolarBonificacion().gmtdInsertar(interes);
                if (strResultado.Substring(0, 1) == "-")
                {
                    strResultado = "- Ocurrio un error grave al tratar de guardar los intereses. No continue con la operación. ";
                    break;
                }
            }
            return strResultado;
        }
    }
}
