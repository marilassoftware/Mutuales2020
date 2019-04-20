using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class municipio
    {
        string _strCodMunicipio;
        public string strCodMunicipio
        {
            get { return _strCodMunicipio; }
            set { _strCodMunicipio = value; }
        }

        string _strNomMunicipio;
        public string strNomMunicipio
        {
            get { return _strNomMunicipio; }
            set { _strNomMunicipio = value; }
        }
    }

    public partial class tblMunicipio
    {
        private tblLogdeActividade _log;
        public tblLogdeActividade log
        {
            get { return _log; }
            set { _log = value; }
        }

        string _strFormulario;
        public string strFormulario
        {
            get { return _strFormulario; }
            set { _strFormulario = value; }
        }
    }
}
