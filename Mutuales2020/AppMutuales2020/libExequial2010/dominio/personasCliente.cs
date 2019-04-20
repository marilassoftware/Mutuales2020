using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class Cliente
    {
        private string _strCodigoCli;
        public string strCodigoCli
        {
            get { return _strCodigoCli; }
            set { _strCodigoCli = value; }
        }

        private string _strContacto;
        public string strContacto
        {
            get { return _strContacto; }
            set { _strContacto = value; }
        }

        private string _strEmpresa;
        public string strEmpresa
        {
            get { return _strEmpresa; }
            set { _strEmpresa = value; }
        }

        private string _strTelefono;
        public string strTelefono
        {
            get { return _strTelefono; }
            set { _strTelefono = value; }
        }

        private string _strCelular;
        public string strCelular
        {
            get { return _strCelular; }
            set { _strCelular = value; }
        }
    }

    public partial class tblCliente
    {
        public tblLogdeActividade log{get;set;}

        public string strFormulario{get;set;}

        public string strLetras { get; set; }

        public string strComputador { get; set; }
    }
}
