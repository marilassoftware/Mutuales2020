using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class provedor
    {
        private string _strCodProvedor;
        public string strCodProvedor
        {
            get { return _strCodProvedor; }
            set { _strCodProvedor = value; }
        }

        private string _strEmpProvedor;
        public string strEmpProvedor
        {
            get { return _strEmpProvedor; }
            set { _strEmpProvedor = value; }
        }

        private string _strTelProvedor;
        public string strTelProvedor
        {
            get { return _strTelProvedor; }
            set { _strTelProvedor = value; }
        }

        private string _strDirProvedor;
        public string strDirProvedor
        {
            get { return _strDirProvedor; }
            set { _strDirProvedor = value; }
        }

        private string _strConProvedor;
        public string strConProvedor
        {
            get { return _strConProvedor; }
            set { _strConProvedor = value; }
        }

        private string _strMailProvedor;
        public string strMailProvedor
        {
            get { return _strMailProvedor; }
            set { _strMailProvedor = value; }
        }
    }

    public partial class tblProvedore
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
