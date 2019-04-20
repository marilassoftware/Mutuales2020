using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class producto
    {
        private string _strCodProducto;
        public string strCodProducto
        {
            get { return _strCodProducto; }
            set { _strCodProducto = value; }
        }

        private string _strDesProducto;
        public string strDesProducto
        {
            get { return _strDesProducto; }
            set { _strDesProducto = value; }
        }

        private int _intMinProducto;
        public int intMinProducto
        {
            get { return _intMinProducto; }
            set { _intMinProducto = value; }
        }

        private int _intMaxProducto;
        public int intMaxProducto
        {
            get { return _intMaxProducto; }
            set { _intMaxProducto = value; }
        }

        private int _intValCompra;
        public int intValCompra
        {
            get { return _intValCompra; }
            set { _intValCompra = value; }
        }

        private int _intValUnitario;
        public int intValUnitario
        {
            get { return _intValUnitario; }
            set { _intValUnitario = value; }
        }

        private int _intCantidad;
        public int intCantidad
        {
            get { return _intCantidad; }
            set { _intCantidad = value; }
        }

        private double _fltMargendeGanancia;
        public double fltMargendeGanancia
        {
            get { return _fltMargendeGanancia; }
            set { _fltMargendeGanancia = value; }
        }

        private double _fltIva;
        public double fltIva
        {
            get { return _fltIva; }
            set { _fltIva = value; }
        }

        public decimal decTotal { get; set; }
        public int disponible { get; set; }
        public decimal decValVenta { get; set; }
    }

    public partial class tblProducto
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
