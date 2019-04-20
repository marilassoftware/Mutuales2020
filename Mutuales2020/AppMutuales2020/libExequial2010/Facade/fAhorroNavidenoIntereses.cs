namespace libMutuales2020.Facade
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fAhorroNavidenoIntereses
    {
        public string gmtdInsertar(List<tblAhorrosNavidenoBonificacion> tobjAhorroBonificacion)
        {
            return new blAhorroNavidenoIntereses().gmtdInsertar(tobjAhorroBonificacion);
        }
    }
}
