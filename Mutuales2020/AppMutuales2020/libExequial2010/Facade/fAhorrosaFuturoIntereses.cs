namespace libMutuales2020.Facade
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fAhorrosaFuturoIntereses
    {
        public string gmtdInsertar(List<tblAhorrosaFuturoBonificacion> tobjAhorroBonificacion)
        {
            return new blAhorrosaFuturoIntereses().gmtdInsertar(tobjAhorroBonificacion);
        }
    }
}
