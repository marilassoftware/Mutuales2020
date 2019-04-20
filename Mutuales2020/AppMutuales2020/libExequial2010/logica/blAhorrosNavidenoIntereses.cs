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
    public class blAhorrosNavidenoIntereses
    {
        public string gmtdInsertar(List<tblAhorrosNavidenoBonificacion> tobjAhorroBonificacion)
        {
            string strResultado = "";

            foreach (tblAhorrosNavidenoBonificacion interes in tobjAhorroBonificacion)
            {
                interes.log = metodos.gmtdLog("Ingresa un interes de ahorro navideño.  " + interes.strCuenta, interes.strFormulario);
                strResultado = new daoAhorrosNavidenoBonificacion().gmtdInsertar(interes);

                if (strResultado.Substring(0, 1) == "-")
                {
                    strResultado = "Ocurrio un error grave al tratar de guardar los intereses.";
                    break;
                }

            }
            return strResultado;
        }
    }
}
