using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class creditoss
    {
        /// <summary> Código del prestamo. </summary>
        public int intCodigoPre { get; set; }
        /// <summary> Valor de lo que se debe del prestamo. </summary>
        public decimal decValorDebePre { get; set; }
    }

    public partial class tblCredito
    {
        public tblLogdeActividade log {get;set;}

        /// <summary> Nombre del formulario. </summary>
        public string strFormulario {get; set;}

        /// <summary> Indica 1 si el tipo de garantia es Codeudores, 2 si es ahorros y 3 si propiedad. </summary>
        public int intTipoGarantia { get; set; }

        /// <summary> Almacena el valor del respaldo en ahorros para la aprobaci[on de un credito. </summary>
        public decimal decAhorrado { get; set; }

        /// <summary> Almacena el nombre de la linea del credito. </summary>
        public string strNombreLinea { get; set; }

        /// <summary> Almacena el nombre de l usuario que ejecuta la operación </summary>
        public string strUsuario { get; set; }

        /// <summary> Computador desde donde se ejecuto la operación </summary>
        public string strComputador { get; set; }
    }
}

