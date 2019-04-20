using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class otroEgreso
    {
        private string _strCodOtrosEgresos;
        public string strCodOtrosEgresos
        {
            get { return _strCodOtrosEgresos; }
            set { _strCodOtrosEgresos = value; }
        }

        private string _strNomOtrosEgresos;
        public string strNomOtrosEgresos
        {
            get { return _strNomOtrosEgresos; }
            set { _strNomOtrosEgresos = value; }
        }

        private string _strCodigoPar;
        public string strCodigoPar
        {
            get { return _strCodigoPar; }
            set { _strCodigoPar = value; }
        }
    }

    public partial class tblOtrosEgreso
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
