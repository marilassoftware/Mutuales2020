using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public partial class recibosIngresosPrestamos
    {
        /// <summary> Numero de la cuota del prestamo. </summary>
        public int intCuota { get; set; }

        /// <summary> Valor del capital que se paga en la cuota. </summary>
        public decimal decCapital { get; set; }

        /// <summary> Valor de los intereses en la cuota. </summary>
        public decimal decIntereses { get; set; }

        /// <summary> Valor de los intereses de mora en la cuota. </summary>
        public decimal decInteresesMora { get; set; }

        /// <summary> Meses atrsados. </summary>
        public int intMesesAtrasados { get; set; }

        /// <summary> Valor causado del préstamo. </summary>
        public decimal decCausado { get; set; }

        /// <summary> Valor a pagar por la cuota. </summary>
        public decimal decValorCuota { get; set; }

        /// <summary> Fecha de la cuota. </summary>
        public DateTime dtmFechaCuo { get; set; }

    }

    public partial class tblIngresosPrestamo
    {
        /// <summary> Codigo del par para capital </summary>
        public string strParCapital { get; set; }

        /// <summary> Codigo del par para interes </summary>
        public string strParInteres { get; set; }

        /// <summary> Codigo del par para Mora </summary>
        public string strParMora { get; set; }

    }
}
