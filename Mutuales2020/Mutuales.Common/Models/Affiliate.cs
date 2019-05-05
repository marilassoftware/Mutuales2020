using System;

namespace Mutuales.Common.Models
{
    public class Affiliate
    {
        public Int32 id { get; set; }

        public Int32 intCodigoSoc { get; set; }

        public String strCedulaAfi { get; set; }

        public String strNombreAfi { get; set; }

        public String strApellido1Afi { get; set; }

        public String strApellido2Afi { get; set; }

        public String strPlanAfi { get; set; }

        public Int32 intAnoAfi { get; set; }

        public Int32 intMesAfi { get; set; }

        public DateTime dtmFechaActualizacion { get; set; }

        public String strCodigoMut { get; set; }
    }
}
