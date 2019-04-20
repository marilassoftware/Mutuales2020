using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class cuentaCredito
    {
        /// <summary> Código de la cuenta. </summary>
        public string strCuenta {get;set;}

        /// <summary> Porcentaje de la cuenta en el par. </summary>
        public decimal decPorcentaje { get; set; }
    }

    /// <summary> Esta clase almacena las cuentas y el valor de cada cuenta </summary>
    public class cuentaValores
    {
        /// <summary> Código de la cuenta. </summary>
        public string strCuenta { get; set; }

        /// <summary> Valor de la cuenta. </summary>
        public decimal decValor { get; set; }
    }

}
