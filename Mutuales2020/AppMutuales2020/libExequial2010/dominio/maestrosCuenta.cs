using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class cuenta
    {
        /// <summary> Número de la cuenta. </summary>
        public string strCuenta {get;set;}

        /// <summary> Descripción de la cuenta. </summary>
        public string strDescripcion {get;set;}

        /// <summary> Cédula de la persona que hace la operación. </summary>
        public string strCedula { get; set; }

        /// <summary> Nombre de la persona que hace la operación. </summary>
        public string strNombre { get; set; }

    }

    public partial class tblCuenta
    {
        public tblLogdeActividade log {get;set;}

        public string strFormulario {get;set;}
    }
}
