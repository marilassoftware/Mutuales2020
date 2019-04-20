using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class creditosLinea
    {
        /// <summary> Codigo de la linea de crédito. </summary>
        public string strCodigoLin { get; set; }

        /// <summary> Nombre de la linea de crédito. </summary>
        public string strNomLineadeCredito { get; set; }

        /// <summary> Tipo de crédito al que pertenece la linea de crédito. </summary>
        public string strCodigoTcr { get; set; }

    }

    public partial class tblCreditosLinea
    {
        public tblLogdeActividade log {get;set;}

        public string strFormulario {get;set;}
    }
}
