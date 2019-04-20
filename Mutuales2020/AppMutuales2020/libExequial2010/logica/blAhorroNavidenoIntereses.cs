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
    public class blAhorroNavidenoIntereses
    {
        public string gmtdInsertar(List<tblAhorrosNavidenoBonificacion> tobjAhorroBonificacion)
        {
            string strResultado = "";
            foreach (tblAhorrosNavidenoBonificacion interes in tobjAhorroBonificacion)
            {
                strResultado = new daoAhorrosNavidenoBonificacion().gmtdInsertar(interes);
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
