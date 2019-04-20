using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class barrio
    {
        private string _strCodBarrio;
        public string strCodBarrio
        {
            get { return _strCodBarrio; }
            set { _strCodBarrio = value; }
        }

        private string _strNomBarrio;
        public string strNomBarrio
        {
            get { return _strNomBarrio; }
            set { _strNomBarrio = value; }
        }

        private string _strNomMunicipio;
        public string strNomMunicipio
        {
            get { return _strNomMunicipio; }
            set { _strNomMunicipio = value; }
        }
    }

    public partial class tblBarrio
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
