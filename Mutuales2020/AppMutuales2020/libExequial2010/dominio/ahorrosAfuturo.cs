using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class AhorroaFuturo
    {
        private string _strCuenta;
        public string strCuenta
        {
            get { return _strCuenta; }
            set { _strCuenta = value; }
        }

        private string _strNombreAho;
        public string strNombreAho
        {
            get { return _strNombreAho; }
            set { _strNombreAho = value; }
        }

        private string _strApellidoAho;
        public string strApellidoAho
        {
            get { return _strApellidoAho; }
            set { _strApellidoAho = value; }
        }

        private DateTime _dtmFechaCuenta;
        public DateTime dtmFechaCuenta
        {
            get { return _dtmFechaCuenta; }
            set { _dtmFechaCuenta = value; }
        }

        private string _strCedulaAho;
        public string strCedulaAho
        {
            get { return _strCedulaAho; }
            set { _strCedulaAho = value; }
        }

        private double _fltValorCuota;
        public double fltValorCuota
        {
            get { return _fltValorCuota; }
            set { _fltValorCuota = value; }
        }

        private double _fltIntereses;
        public double fltIntereses
        {
            get { return _fltIntereses; }
            set { _fltIntereses = value; }
        }

        private double _fltPremios;
        public double fltPremios
        {
            get { return _fltPremios; }
            set { _fltPremios = value; }
        }

        private bool _bitLiquidada;
        public bool bitLiquidada
        {
            get { return _bitLiquidada; }
            set { _bitLiquidada = value; }
        }

        private DateTime _dtmFechaLiquidada;
        public DateTime dtmFechaLiquidada
        {
            get { return _dtmFechaLiquidada; }
            set { _dtmFechaLiquidada = value; }
        }

        private int _intAño;
        public int intAno
        {
            get { return _intAño; }
            set { _intAño = value; }
        }

        private int _intCuotas;
        public int intCuotas
        {
            get { return _intCuotas; }
            set { _intCuotas = value; }
        }
    }

    public partial class tblAhorrosaFuturo
    {
        public tblLogdeActividade log { get; set; }

        public string strFormulario { get; set; }

        public List<tblAhorrosaFuturoDetalle> lstMeses { get; set; }

        /// <summary> Nombre del computador desde donde se hace la operacion. </summary>
        public string strComputador { get; set; }

        /// <summary> Usuario que realizo la operacion </summary>
        public string strUsuario { get; set; }
    }

    public class LiquidacionAhorroaFuturo
    {
        /// <summary> Almacena el número de la cuenta de ahorro a futuro. </summary>
        public string strCuenta { get; set; }

        /// <summary> Almacena el número de la cédula del ahorrador </summary>
        public string strCedulaAho { get; set; }

        /// <summary> Almacena el nombre del ahorrador. </summary>
        public string strAhorrador { get; set; }

        /// <summary> Numero de cuotas pagadas. </summary>
        public int intCuotasPagadas { get; set; }

        /// <summary> Numero de cuotas pagadas que debió pagar. </summary>
        public int intCuotasaPagar { get; set; }

        /// <summary> El porcentaje de cuotas pagadas con respecto a las que debio pagar. </summary>
        public decimal decPorcentajeCuotasPagadas { get; set; }

        /// <summary> Almacena el valor de los premios recaudados en la cuenta. </summary>
        public decimal decPremios { get; set; }

        /// <summary> Almacena el valor de los intereses recaudados por la cuenta. </summary>
        public decimal decIntereses { get; set; }

        /// <summary> Almacena el total quecaudado por la cuenta. </summary>
        public decimal decTotalRecaudado { get; set; }

        /// <summary> Almacena el valor del descuento de la liquidación. </summary>
        public decimal decDescuento { get; set; }

        /// <summary> Almacena el valor total de la liquidación. </summary>
        public decimal decTotalLiquidacion { get; set; }

        /// <summary> Guarda los datos del log. </summary>
        public tblLogdeActividade log { get; set; }

        /// <summary> Nombre del formulario desde donde se registro la operación. </summary>
        public string strFormulario { get; set; }

        /// <summary> Código del recibo de ingreso con el que se hizo la liquidacion. </summary>
        public int intCodigoIng { get; set; }

        /// <summary> Código del recibo de egreso con el que se hizo la liquidacion. </summary>
        public int intCodigoEgr { get; set; }

        /// <summary> Nombre del computador desde donde se hace la operacion. </summary>
        public string strComputador { get; set; }

        /// <summary> Usuario que realizo la operacion </summary>
        public string strUsuario { get; set; }
    }
}
