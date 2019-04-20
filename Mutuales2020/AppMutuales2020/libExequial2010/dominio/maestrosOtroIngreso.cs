using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class otroIngreso
    {
        private string _strCodOtrosIngresos;
        public string strCodOtrosIngresos
        {
            get { return _strCodOtrosIngresos; }
            set { _strCodOtrosIngresos = value; }
        }

        private string _strNomOtrosIngresos;
        public string strNomOtrosIngresos
        {
            get { return _strNomOtrosIngresos; }
            set { _strNomOtrosIngresos = value; }
        }

        private string _strCodigoPar;
        public string strCodigoPar
        {
            get { return _strCodigoPar; }
            set { _strCodigoPar = value; }
        }
    }

    public partial class tblOtrosIngreso
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
