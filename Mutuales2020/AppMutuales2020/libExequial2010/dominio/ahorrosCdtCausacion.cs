using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class ahorrosCdtCausacion
    {
        private int _intNumeroCdt;
        public int intNumeroCdt
        {
            get { return _intNumeroCdt; }
            set { _intNumeroCdt = value; }
        }

        private string _strFechaCausacion;
        public string strFechaCausacion
        {
            get { return _strFechaCausacion; }
            set { _strFechaCausacion = value; }
        }

        private int _intMonto;
        public int intMonto
        {
            get { return _intMonto; }
            set { _intMonto = value; }
        }
        private double _fltIntereses;
        public double fltIntereses
        {
            get { return _fltIntereses; }
            set { _fltIntereses = value; }
        }

        private int _intDias;
        public int intDias
        {
            get { return _intDias; }
            set { _intDias = value; }
        }

        private int _intDiario;
        public int intDiario
        {
            get { return _intDiario; }
            set { _intDiario = value; }
        }

        private double _fltPorcentaje;
        public double fltPorcentaje
        {
            get { return _fltPorcentaje; }
            set { _fltPorcentaje = value; }
        }

    }

    public partial class tblAhorrosCdtsCausacion
    {
        public tblLogdeActividade log { get; set; }

        public string strFormulario { get; set; }
    }
}
