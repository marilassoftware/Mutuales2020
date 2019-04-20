
using System;
namespace libMutuales2020.dominio
{
    public class Fallecido
    {
        /// <summary> Almacena el código del socio al que pertenecia el fallecido. </summary>
        public int intCodigoSoc  { get; set; }

        /// <summary> Almacena el número de cédula del socio al que pertenecia el fallecido. </summary>
        public string strCedulaFal { get; set; }

        /// <summary> Almacena el apellido 1 del fallecido. </summary>
        public string strApellido1Fal { get; set; }

        /// <summary> Almacena el apellido 2 del fallecido. </summary>
        public string strApellido2Fal { get; set; }

        /// <summary> Almacena el nombre del fallecido. </summary>
        public string strNombreFal { get; set; }

        /// <summary> Almacena el apellido completo del fallecido. </summary>
        public string strApellidoFal { get; set; }

        /// <summary> Almacena el nombre de la noraria donde se registro el fallecido. </summary>
        public string strNotaria { get; set; }

        /// <summary> Almacena el nombre del folio donde se registro el fallecido. </summary>
        public string strFolio { get; set; }

        public int intAños { get; set; }

        public int intPagado { get; set; }

        public string strProcedencia { get; set; }

        public string strComentario { get; set; }

        public DateTime dtmFechaFal { get; set; }

        public DateTime dtmFechaNuc { get; set; }
    }

    public partial class tblFallecido
    {
        public tblLogdeActividade log{get;set;}

        public string strFormulario{get;set;}

        public string strAgraciado{get;set;}

        public tblAgraciado agraciado{get;set;}

    }
}
