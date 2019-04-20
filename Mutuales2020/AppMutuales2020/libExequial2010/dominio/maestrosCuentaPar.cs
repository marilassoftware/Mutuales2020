using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class cuentaPar
    {
        public string strCodigoPar {get;set;}

        public string strDescripcion { get; set; }

        public bool bitRetencion {get;set;}

        public int intTope {get;set;}

        public double fltPorcentaje {get;set;}

        public bool bitEliminar { get; set; }

    }

    public partial class tblCuentasPare
    {
        List<tblCuentasCreditoParesDetalle> _lstCredito;
        public List<tblCuentasCreditoParesDetalle> lstCredito
        {
            get { return _lstCredito; }
            set { _lstCredito = value; }
        }

        List<tblCuentasDebitoParesDetalle> _lstDebito;
        public List<tblCuentasDebitoParesDetalle> lstDebito
        {
            get { return _lstDebito; }
            set { _lstDebito = value; }
        }

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
