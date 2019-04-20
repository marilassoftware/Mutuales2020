using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public partial class tblIngresosPrestamosAbono
    {
        /// <summary> Codigo del par de la deuda. </summary>
        public string strCodigoPar { get; set; }

        /// <summary> Indica si el monto de un abono a prestamo se le va a debitar al valor que adeuda el prestamo. </summary>
        public bool bitDeducirAbonodelMonto { get; set; }
    }
}
