using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class ahorrosCdtLiquidacion
    {
        private int _intNumeroCdt;
        public int intNumeroCdt
        {
            get { return _intNumeroCdt; }
            set { _intNumeroCdt = value; }
        }

        private double _fltRetencionLiquidacionCdt;
        public double fltRetencionLiquidacionCdt
        {
            get { return _fltRetencionLiquidacionCdt; }
            set { _fltRetencionLiquidacionCdt = value; }
        }

        private double _fltBrutoLiquidacionCdt;
        public double fltBrutoLiquidacionCdt
        {
            get { return _fltBrutoLiquidacionCdt; }
            set { _fltBrutoLiquidacionCdt = value; }
        }

        private double _fltNetoLiquidacionCdt;
        public double fltNetoLiquidacionCdt
        {
            get { return _fltNetoLiquidacionCdt; }
            set { _fltNetoLiquidacionCdt = value; }
        }

        private DateTime _dtmFechaLiquidacionCdt;
        public DateTime dtmFechaLiquidacionCdt
        {
            get { return _dtmFechaLiquidacionCdt; }
            set { _dtmFechaLiquidacionCdt = value; }
        }

        private DateTime _dtmFechaAnuladaLiquidacionCdt;
        public DateTime dtmFechaAnuladaLiquidacionCdt
        {
            get { return _dtmFechaAnuladaLiquidacionCdt; }
            set { _dtmFechaAnuladaLiquidacionCdt = value; }
        }

        private bool _bitAnuladaCdt;
        public bool bitAnuladaCdt
        {
            get { return _bitAnuladaCdt; }
            set { _bitAnuladaCdt = value; }
        }
    }

    public partial class tblAhorrosCdtsLiquidacion
    {
        public tblLogdeActividade log { get; set; }

        public string strFormulario { get; set; }

        /// <summary> Almacena el apellido del ahorrador </summary>
        public string strApellidoAho { get; set; }

        /// <summary> Almacena el nombre del ahorrador </summary>
        public string strNombreAho { get; set; }

        /// <summary> Almacena el número de la cédula del ahorrador. </summary>
        public string strCedulaAho { get; set; }
    }
}
