using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class Agraciado
    {
        public int intCodigoSoc {get;set;}

        public string strCedulaAgra {get;set;}

        public string strNombreAgra {get;set;}

        public string strApellidoAgra {get;set;}

        public string strTelefono {get;set;}

        public string strDireccion{get;set;}

        public string strParentesco {get;set;}

        /// <summary> Almacena el nombre y los apellidos de un determinado agraciado. </summary>
        public string strNombreCompleto { get; set; }

        /// <summary> Indica si se le actualizo o no la la informacion al agraciado </summary>
        public bool bitActualizado { get; set; }

        /// <summary> Fecha de nacimiento del agraciado </summary>
        public DateTime dtmFechaNac { get; set; }

        /// <summary> Apellido 1 del agraciado </summary>
        public string strApellido1 { get; set; }

        /// <summary> Apellido 2 del agraciado </summary>
        public string strApellido2 { get; set; }
    }

    public partial class tblAgraciado
    {
        public tblLogdeActividade log { get; set; }

        public string strFormulario{get;set;}
    }
}