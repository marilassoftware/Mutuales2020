using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class Socio
    {
        public int intCodigoSoc {get;set;}

        public string strCedulaSoc {get;set;}

        public string strNombreSoc {get;set;}

        public string strApellidoSoc {get;set;}

        public string strTelefono {get;set;}

        public string strDireccion {get;set;}

        public string strPlan {get;set;}
    }

    public partial class tblSocio
    {
        /// <summary> Log de actividades </summary>
        public tblLogdeActividade log {get;set;}

        /// <summary> Código del formulario </summary>
        public string strFormulario {get; set;}

        /// <summary> servicio primario del socio. </summary>
        public tblServiciosPrimario servicio { get; set; }

        /// <summary> Valor de la cuota del adulto mayor. </summary>
        public int intValorCuotaAdultoMayor { get; set; }
    }
}
