using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public partial class tblEgreso
    {
        /// <summary> Log de transaccion </summary>
        public tblLogdeActividade log {get;set;}

        /// <summary> Nombre del formulario </summary>
        public string strFormulario {get;set;}

        /// <summary> Almacena la información de un recibo de egresos. </summary>
        public List<tblEgresosEgreso> egresoEgreso { get; set; }

        /// <summary> Almacena la información de un retiro de ahorros a la vista. </summary>
        public tblEgresosAhorro egresoAhorroalaVista { get; set; }

        /// <summary> Almacena la información de un retiro de ahorros a la vista. </summary>
        public tblEgresosAhorrosFijo egresoAhorroFijo { get; set; }

        /// <summary> Almacena la información de un retiro de ahorros a la vista. </summary>
        public tblEgresosAhorrosEstudiante egresoAhorroEstudiantil { get; set; }

        /// <summary> Almacena la información de los intereses de un ahorrador. </summary>
        public tblEgresosInterese egresoIntereses { get; set; }

        /// <summary> Almacena la información de los intereses de un ahorrador. </summary>
        public tblEgresosPrestamosAbono egresoAbonoaPrestamo { get; set; }

        /// <summary> Almacena la información de un ingreso. </summary>
        public tblIngreso objIngreso { get; set; }

        /// <summary> Almacena la información de la liquidación de un ahorro navideño. </summary>
        public tblEgresosAhorrosNavidenoLiquidacion objAhorroNavidenoLiquidacion { get; set; }
         
        public tblEgresosAhorrosNatilleraEscolarLiquidacion objEgresosAhorrosNatilleraEscolarLiquidacion { get; set; }

        public tblEgresosAhorrosaFuturoLiquidacion objEgresosAhorrosaFuturoLiquidacion { get; set; }

        public tblEgresosAhorrosCdtLiquidacion objEgresosAhorrosCdtLiquidacion { get; set; }

    }
}