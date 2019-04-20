using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class ahorrosCdt
    {
        /// <summary> Almacena el número del Cdt. </summary>
        public int intNumeroCdt { get; set; }

        /// <summary> Almacena el número de la Cédula del ahorrador del cdt. </summary>
        public string strCedulaAho { get; set; }

        /// <summary> Almacena el nombre del ahorrador. </summary>
        public string strNombreAho { get; set; }

        /// <summary> Almacena el porcentaje de interes del cdt. </summary>
        public decimal decInteresesCdt { get; set; }

        /// <summary> Almacena la fecha de inicio del cdt. </summary>
        public DateTime dtmFechaIniCdt { get; set; }

        /// <summary> Almacena la fecha final del cdt. </summary>
        public DateTime dtmFechaFinCdt { get; set; }

        /// <summary> Almacena el monto del Cdt. </summary>
        public decimal decMontoCdt { get; set; }

        /// <summary> Almacena un valor que indica si el Cdt esta anulado. </summary>
        public bool bitAnuladoCdt { get; set; }

        /// <summary> Almacena un valor que indica si el Cdt esta liquidado. </summary>
        public bool bitLiquidadoCdt { get; set; }

        /// <summary> Almacena un número de meses del Cdt. </summary>
        public int intMesesCdt { get; set; }

        /// <summary> Almacena el interes mensual del Cdt. </summary>
        public decimal decInteresMensualCdt { get; set; }

        /// <summary> Almacena un valor con el año y mes concatenados. </summary>
        public int intAnoMes { get; set; }

        /// <summary> Almacena un valor que indica si el Cdt esta se paga por anticipado o no. </summary>
        public bool bitAnticipadoCdt { get; set; }

    }

    public partial class tblAhorrosCdt
    {
        public tblLogdeActividade log {get;set;}

        public string strFormulario {get;set;}
    }
}
