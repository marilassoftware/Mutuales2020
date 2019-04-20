using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public partial class personasaModificar
    {
        /// <summary> Código del socio. </summary>
        public int intCodigoSoc { get; set; }

        /// <summary> Numero de la cèdula. </summary>
        public string strCedula { get; set; }

        /// <summary> Nombre de la persona. </summary>
        public string strNombre { get; set; }

        /// <summary> Apellido 1 de la persona.  </summary>
        public string strApellido1 { get; set; }

        /// <summary> Apellido 2 de la persona. </summary>
        public string strApellido2 { get; set; }

        /// <summary> Fecha de nacimiento. </summary>
        public DateTime dtmFechaNacimeinto { get; set; }

        /// <summary> Telefono de la persona. </summary>
        public string strTelefono { get; set; }

        /// <summary> Direccion de la persona. </summary>
        public string strDireccion { get; set; }

        /// <summary> Almacena la procedencia del dato a modificar Socio o Agraciado </summary>
        public string strProcedencia { get; set; }

        public tblLogdeActividade log { get; set; }

    }
}
