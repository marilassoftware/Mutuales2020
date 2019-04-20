using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class creditosClasificacion
    {
        /// <summary> Código de la clasificación de credito. </summary>
        public string strCodigoCla {get;set;}

        /// <summary> Nombre de la clasificación de credito. </summary>
        public string strNombreCla { get; set; }

        /// <summary> Porcentaje de la provisión para créditos de la clasificación. </summary>
        public decimal decValorProvisionCla { get; set; }

        /// <summary> Código del tipo de credito de la clasificación. </summary>
        public string strCodigoTcr { get; set; }

        /// <summary> Dia inicial: Los créditos cuya morosidad en días sea desde este campo. </summary>
        public int intDesdeCla { get; set; }

        /// <summary> Dia final: Los créditos cuya morosidad en días sea hasta este campo. </summary>
        public int intHastaCla { get; set; }

        /// <summary> Indica si esta clasificación se suma al Indice de Cartera Morosa. </summary>
        public bool bitSumarICM { get; set; }

        public bool bitCausarInteresesCla { get; set; }

        public bool bitInteresporDiasCla { get; set; }
    }

    public partial class tblCreditosClasificacion
    {
        public tblLogdeActividade log {get;set;}

        public string strFormulario {get;set;}
    }
}
