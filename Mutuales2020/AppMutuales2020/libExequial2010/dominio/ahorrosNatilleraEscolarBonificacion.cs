using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class AhorrosNatilleraEscolarBonificacion
    {
        public int intCodigoBonificacion {get;set;}

        public string strCuenta {get;set;}

        public DateTime dtmFechaSorteo {get;set;}

        public double fltValor {get;set;}

        public bool bitIntereses {get;set;}

        public bool bitPremios {get;set;}
    }

    public partial class tblAhorrosNatilleraEscolarBonificacion
    {
        public tblLogdeActividade log { get; set; }

        public string strFormulario { get; set; }

    }
}
