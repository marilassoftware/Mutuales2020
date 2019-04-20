using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class Compra
    {
        private int _intCodCompra;
        public int intCodCompra
        {
            get { return _intCodCompra; }
            set { _intCodCompra = value; }
        }

        private DateTime _dtmFechaCom;
        public DateTime dtmFechaCom
        {
            get { return _dtmFechaCom; }
            set { _dtmFechaCom = value; }
        }

        private bool _bitAnuladoCom;
        public bool bitAnuladoCom
        {
            get { return _bitAnuladoCom; }
            set { _bitAnuladoCom = value; }
        }

        private DateTime _dtmFechaAnuCom;
        public DateTime dtmFechaAnuCom
        {
            get { return _dtmFechaAnuCom; }
            set { _dtmFechaAnuCom = value; }
        }

        private string _strCodProvedor;
        public string strCodProvedor
        {
            get { return _strCodProvedor; }
            set { _strCodProvedor = value; }
        }

        private string _strNomProvedor;
        public string strNomProvedor
        {
            get { return _strNomProvedor; }
            set { _strNomProvedor = value; }
        }

        private double _fltTotalCom;
        public double fltTotalCom
        {
            get { return _fltTotalCom; }
            set { _fltTotalCom = value; }
        }

        private double _fltDebeCom;
        public double fltDebeCom
        {
            get { return _fltDebeCom; }
            set { _fltDebeCom = value; }
        }

    
    }

    public partial class tblCompra
    {
        public tblLogdeActividade log {get;set;}

        public string strFormulario {get;set;}

        public List<tblComprasDetalle> lstDetalle {get;set;}
    }
}
