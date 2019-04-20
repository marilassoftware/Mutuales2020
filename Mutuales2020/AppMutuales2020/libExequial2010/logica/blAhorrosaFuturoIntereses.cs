using System.Collections.Generic;
using System.ComponentModel;
using libMutuales2020.dao;
using libMutuales2020.dominio;

namespace libMutuales2020.logica
{
    [DataObject(true)]
    public class blAhorrosaFuturoIntereses
    {
        public string gmtdInsertar(List<tblAhorrosaFuturoBonificacion> tobjAhorroBonificacion)
        {
            string strResultado = "";

            foreach (tblAhorrosaFuturoBonificacion interes in tobjAhorroBonificacion)
            {
                tblLogdeActividade log = new tblLogdeActividade();
                interes.log = metodos.gmtdLog("Ingresa interes de ahorro a futuro " + interes.strCuenta, "frmAhorrosaFuturoIntereses");
                strResultado = new daoAhorrosaFuturoBonificacion().gmtdInsertar(interes);

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
