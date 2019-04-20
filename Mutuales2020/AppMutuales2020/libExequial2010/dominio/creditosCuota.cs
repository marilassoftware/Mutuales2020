using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class creditosCuota
    {
        /// <summary> Código del préstamo al que pertenece la cuota. </summary>
        public int intCodigoCre { get; set; }

        /// <summary> Número de la cuota. </summary>
        public int intCuota { get; set; }

        /// <summary> Fecha y código del recibo con el que se pago la cuota. </summary>
        public string strDatosdePago { get; set; }

        /// <summary> Fecha en la que se debe de pagar la cuota. </summary>
        public DateTime dtmFechaCuo { get; set; }

        /// <summary> Valor de la cuota. </summary>
        public decimal decValorCuo { get; set; }

        /// <summary> Capital del crédito dentro de la cuota. </summary>
        public decimal decCapital { get; set; }

        /// <summary> Capital del crédito dentro de la cuota. </summary>
        public decimal decIntereses { get; set; }

        /// <summary> Saldo en capital que se queda debiendo del préstamo al momento de pagarla. </summary>
        public decimal decSaldoCapital { get; set; }

        /// <summary> Indica si la cuota se pago o no. </summary>
        public bool bitPagada { get; set; }
		
    }
}
