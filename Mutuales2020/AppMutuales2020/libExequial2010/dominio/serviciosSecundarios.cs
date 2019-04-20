using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class Secundarios
    {
        private string _strCodSse;
        public string strCodSse
        {
            get { return _strCodSse; }
            set { _strCodSse = value; }
        }

        private string _strNombreSse;
        public string strNombreSse
        {
            get { return _strNombreSse; }
            set { _strNombreSse = value; }
        }

        private int _intValorSse;
        public int intValorSse
        {
            get { return _intValorSse; }
            set { _intValorSse = value; }
        }

        private string _strCodigoPar;
        public string strCodigoPar
        {
            get { return _strCodigoPar; }
            set { _strCodigoPar = value; }
        }
    }

    public partial class tblServiciosSecundario
    {
        public tblLogdeActividade log {get;set;}

        public string strFormulario {get;set;}
    }
}
