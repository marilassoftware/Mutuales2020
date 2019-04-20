using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public partial class tblIngreso
    {
        /// <summary> Log de actividades </summary>
        public tblLogdeActividade log { get; set; }

        /// <summary> Nombre del formulario </summary>
        public string strFormulario { get; set; }

        /// <summary> Almacena la información de un recibo de cuotas exequiales. </summary>
        public tblIngresosCuota ingresoCuota { get; set; }

        /// <summary> Almacena los datos de la cuotas a pagar de un prestamo. </summary>
        public List<tblIngresosPrestamo> ingresoPrestamo { get; set; }

        /// <summary> Almacena los datos de un recibo de ingreso de ahorro a la vista. </summary>
        public tblIngresosAhorro ingresoAhorro { get; set; }

        /// <summary> Almacena los datos de un recibo de ingreso de ahorro estudiantil. </summary>
        public tblIngresosAhorrosEstudiantil ingresoAhorroEstudiantil { get; set; }

        /// <summary> Almacena los datos de un recibo de ingreso de ahorro navideño. </summary>
        public List<tblIngresosAhorrosaFuturo> ingresoAhorroaFuturo { get; set; }

        /// <summary> Almacena los datos de un recibo de ingreso de ahorro a futuro. </summary>
        public List<tblIngresosAhorrosNavideno> ingresoAhorroNavideño { get; set; }

        /// <summary> Almacena los datos de un recibo de ingreso de ahorro a futuro. </summary>
        public List<tblIngresosAhorrosNatilleraEscolar> ingresoAhorroNatilleraEscolar { get; set; }

        /// <summary> Almacena los datos de un recibo de ingreso de ahorro Fijo. </summary>
        public tblIngresosAhorrosFijo ingresoAhorroFijo { get; set; }

        /// <summary> Almacena los datos de un recibo de otros ingresos. </summary>
        public List<tblIngresosOtrosIngreso> ingresoOtrosIngresos { get; set; }

        /// <summary> Almacena los datos de abono a prestamo. </summary>
        public tblIngresosPrestamosAbono ingresoAbonoaPrestamo { get; set; }

        /// <summary> Almacena los datos de abono a venta. </summary>
        public tblIngresosVenta ingresoAbonoaVenta { get; set; }

        /// <summary> Almacena los datos de abono a deuda. </summary>
        public List<tblIngresosDeuda> ingresoAbonoaDeuda { get; set; }

        /// <summary> Almacena los datos de abono a Ahorro Cdt. </summary>
        public tblIngresosAhorrosCdt ingresoAhorroCdt { get; set; }

        public tblIngresosAhorrosNavidenosMulta objIngresosAhorrosNavidenosMulta { get; set; }

        public tblIngresosAhorrosaFuturoMulta objIngresosAhorrosaFuturoMulta { get; set; }

        public tblIngresosAhorrosCdtMulta objIngresosAhorrosCdtMulta { get; set; }

        public tblIngresosAhorrosCdt objIngresosAhorrosCdt { get; set; }

        public tblAhorrosCdt objAhorroCdt { get; set; }

    }

    public class otrosIngresos
    {
        public string strCodigoOtro { get; set; }
        public string strDescripcion { get; set; }
        public decimal decValor { get; set; }
    }

    public class abonoaPrestamo
    {
        /// <summary> Código del préstamo al que se le va hacer el abono. </summary>
        public int intPrestamo { get; set; }
        /// <summary> Valor del abono a prestamo. </summary>
        public decimal decValor { get; set; }
    }
}
