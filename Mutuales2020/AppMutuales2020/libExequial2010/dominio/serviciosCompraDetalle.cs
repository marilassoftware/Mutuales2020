using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class CompraDetalle
    {
        private int _intCodCompra;
        public int intCodCompra
        {
            get { return _intCodCompra; }
            set { _intCodCompra = value; }
        }

        private string _strCodProducto;
        public string strCodProducto
        {
            get { return _strCodProducto; }
            set { _strCodProducto = value; }
        }

        private string _strNomProducto;
        public string strNomProducto
        {
            get { return _strNomProducto; }
            set { _strNomProducto = value; }
        }

        private double _fltValorCompra;
        public double fltValorCompra
        {
            get { return _fltValorCompra; }
            set { _fltValorCompra = value; }
        }

        private double _fltValorVenta;
        public double fltValorVenta
        {
            get { return _fltValorVenta; }
            set { _fltValorVenta = value; }
        }

        private int _intCantidad;
        public int intCantidad
        {
            get { return _intCantidad; }
            set { _intCantidad = value; }
        }

        private double _fltTotal;
        public double fltTotal
        {
            get { return _fltTotal; }
            set { _fltTotal = value; }
        }

    }
}
