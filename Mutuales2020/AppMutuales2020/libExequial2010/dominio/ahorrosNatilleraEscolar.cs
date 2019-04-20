using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class AhorroNatilleraEscolar
    {
        public string strCuenta {get;set;}

        public string strNombreAho {get;set;}

        public string strApellidoAho {get;set;}

        public DateTime dtmFechaCuenta {get;set;}

        public string strCedulaAho {get;set;}

        public double fltValorCuota {get;set;}

        public double fltIntereses {get;set;}

        public double fltPremios {get;set;}

        public bool bitLiquidada {get;set;}

        public DateTime dtmFechaLiquidada {get;set;}

        public int intAno {get;set;}

        public int intCuotas {get;set;}
    }

    public class cuotasPendientesNatilleEscolar
    {
        /// <summary> Numero de la cuota. </summary>
        public int intCuota { get; set; }

        /// <summary> Fecha en la que se debe de pagar la cuota. </summary>
        public DateTime dtmFechaCuota { get; set; }

        /// <summary> Valor de la cuota a pagar. </summary>
        public decimal decValorCuota { get; set; }

        /// <summary> Número de la cuenta del ahorro navideño. </summary>
        public string strCuenta { get; set; }
    }

    public partial class tblAhorrosNatilleraEscolar
    {
        public tblLogdeActividade log { get; set; }

        public string strFormulario { get; set; }

        public List<tblAhorrosNatilleraEscolarDetalle> lstMeses { get; set; }

        /// <summary> Nombre del computador desde donde se hace la operacion. </summary>
        public string strComputador { get; set; }

        /// <summary> Usuario que realizo la operacion </summary>
        public string strUsuario { get; set; }
    }

    public class LiquidacionAhorroNatilleraEscolar
    {
        /// <summary> Almacena el número de la cuenta de ahorro navideño. </summary>
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

        /// <summary> Almacena el nombre del computador desde donde se realizo. </summary>
        public string strComputador { get; set; }

        /// <summary> Usuario que realizo la operacion. </summary>
        public string strUsuario { get; set; }

        /// <summary> Determina si se le aplica la deduccion a una cuenta por el no pago completo de las cuotas. </summary>
        public bool bitAplicarMulta { get; set; }

    }
}
