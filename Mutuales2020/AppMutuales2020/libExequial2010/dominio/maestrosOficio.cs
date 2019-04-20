using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class oficio
    {
        private string _strCodOficio;
        public string strCodOficio
        {
            get { return _strCodOficio; }
            set { _strCodOficio = value; }
        }

        private string _strNomOficio;
        public string strNomOficio
        {
            get { return _strNomOficio; }
            set { _strNomOficio = value; }
        }

    }

    public partial class tblOficio
    {
        private tblLogdeActividade _log;
        public tblLogdeActividade log
        {
            get {return _log;}
            set {_log = value;}
        }

        string _strFormulario;
        public string strFormulario
        {
            get { return _strFormulario; }
            set { _strFormulario = value; }
        }
    }
}
