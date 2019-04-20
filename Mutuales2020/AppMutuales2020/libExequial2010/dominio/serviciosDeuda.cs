using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class Deuda
    {
        public int intCodDeu {get; set;}

        public string strCedula {get; set;}

        public string strCodigoPar {get; set;}

        public string strCodSse {get; set;}

        public bool bitGlobalDeu {get; set;}

        public decimal decAbonaDeu {get; set;}

        public decimal decDebeDeu {get; set;}

        /// <summary> Bombre del servidcio de la deuda. </summary>
        public string strNombreDeuda { get; set; }

    }

    public partial class tblDeuda
    {
        public tblLogdeActividade log {get;set;}

        public string strFormulario {get;set;}

        public string strNombrePer { get; set; }
    }
}
