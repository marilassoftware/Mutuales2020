using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class recibosDatos
    {
        /// <summary> Código del socio. </summary>
        public int intCodigoSoc { get; set; }

        /// <summary> Número de la cédula de la persona a la que se le va hacer el recibo. </summary>
        public string strCedula { get; set; }

        /// <summary> Datos del socio al hacerle el recibo. </summary>
        public tblSocio datosSocio { get; set; }

        /// <summary> Código del par </summary>
        public string strCodigoPar { get; set; }
    }
}
