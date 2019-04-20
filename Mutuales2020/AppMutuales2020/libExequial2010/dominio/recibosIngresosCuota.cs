using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public partial class tblIngresosCuota
    {
        /// <summary> El log de actividades. </summary>
        public tblLogdeActividade log {get;set;}

        /// <summary> Nombre del formulario </summary>
        public string strFormulario {get;set;}

        /// <summary> Almacena los datos del socio. </summary>
        public tblSocio socio { get; set; }

        /// <summary> Código del par. </summary>
        public string strCodigoPar { get; set; }

        /// <summary> Almacena los registros para indicar cuando se pago una cuota exequial </summary>
        public List<tblSociosPagosCuota> fechasCuotas { get; set; }

    }
}
