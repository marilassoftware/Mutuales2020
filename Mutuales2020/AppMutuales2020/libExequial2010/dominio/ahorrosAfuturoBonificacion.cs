using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class AhorrosaFuturoBonificacion
    {
        private int _intCodigoBonificacion;
        public int intCodigoBonificacion
        {
            get { return _intCodigoBonificacion; }
            set { _intCodigoBonificacion = value; }
        }

        private string _strCuenta;
        public string strCuenta
        {
            get { return _strCuenta; }
            set { _strCuenta = value; }
        }

        private DateTime _dtmFechaSorteo;
        public DateTime dtmFechaSorteo
        {
            get { return _dtmFechaSorteo; }
            set { _dtmFechaSorteo = value; }
        }

        private double _fltValor;
        public double fltValor
        {
            get { return _fltValor; }
            set { _fltValor = value; }
        }

        private bool _bitIntereses;
        public bool bitIntereses
        {
            get { return _bitIntereses; }
            set { _bitIntereses = value; }
        }

        private bool _bitPremios;
        public bool bitPremios
        {
            get { return _bitPremios; }
            set { _bitPremios = value; }
        }
    }


    public partial class tblAhorrosaFuturoBonificacion
    {
        public tblLogdeActividade log {get;set;}

        public string strFormulario {get;set;}
    }
}
