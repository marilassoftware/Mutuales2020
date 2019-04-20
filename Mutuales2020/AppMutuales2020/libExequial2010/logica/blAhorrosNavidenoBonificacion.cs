using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libMutuales2020.dominio;
using libMutuales2020.dao;
using System.ComponentModel;

namespace libMutuales2020.logica
{
    [DataObject(true)]
    public class blAhorrosNavidenoBonificacion
    {
        /// <summary> Inserta una bonificación de ahorro Navideño. </summary>
        /// <param name="tobjAhorroaFuturoBonificacion"> Un objeto del tipo tblAhorrosNavidenoBonificacion. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblAhorrosNavidenoBonificacion tobjAhorroNavidenoBonificacion)
        {
            if (tobjAhorroNavidenoBonificacion.bitIntereses == false && tobjAhorroNavidenoBonificacion.bitPremios == false)
                return "- Debe de escojer si la bonificacion es por intereses o premios. ";

            if (tobjAhorroNavidenoBonificacion.dtmFechaSorteo == null)
                return "- Debe de ingresar la fecha de la bonificación. ";

            if (tobjAhorroNavidenoBonificacion.fltValor == 0)
                return "- Debe de ingresar el valor de la bonificación. ";

            if (tobjAhorroNavidenoBonificacion.strCuenta == null || tobjAhorroNavidenoBonificacion.strCuenta == "")
                return "- Debe de ingresar la cuenta de la bonificación. ";

            tblAhorrosNavideno ahorro = new daoAhorrosNavideno().gmtdConsultar(tobjAhorroNavidenoBonificacion.strCuenta);
            if (ahorro.strCuenta == null)
                return "- Debe de ingresar una cuenta valida para la bonificación. ";

            if (ahorro.bitAnulado == true)
                return "- No se puede registrar bonificaciones a una cuenta anulada. ";

            if (ahorro.bitLiquidada == true)
                return "- No se puede registrar bonificaciones a una cuenta liquidada. ";


            tobjAhorroNavidenoBonificacion.bitAnulado = false;
            tobjAhorroNavidenoBonificacion.dtmFechaAnulado = Convert.ToDateTime("1900/01/01");

            tobjAhorroNavidenoBonificacion.log = metodos.gmtdLog("Ingresa la bonificación a futuro. " + tobjAhorroNavidenoBonificacion.strCuenta, tobjAhorroNavidenoBonificacion.strFormulario);

            return new daoAhorrosNavidenoBonificacion().gmtdInsertar(tobjAhorroNavidenoBonificacion);
        }

        /// <summary> Consulta todos las bonificaciones registradas. </summary>
        /// <returns> Un lista con todos las bonificaciones seleccionadas. </returns>
        public IList<tblAhorrosNavidenoBonificacion> gmtdConsultarTodos()
        {
            return new daoAhorrosNavidenoBonificacion().gmtdConsultarTodos();
        }

        /// <summary> Consulta una determinada bonificación. </summary>
        /// <param name="tstrCuenta">el código de la bonificación a consultar.</param>
        /// <returns> un objeto del tipo tblAhorrosaFuturo. </returns>
        public tblAhorrosNavidenoBonificacion gmtdConsultar(int tintBonificacion)
        {
            return new daoAhorrosNavidenoBonificacion().gmtdConsultar(tintBonificacion);
        }

        /// <summary> Consulta las bonificaciones premio de una determinada cuenta. </summary>
        /// <param name="tstrCuenta">el código de la cuenta a la que se le van a consultar las bonificaciones. </param>
        /// <returns> un objeto del tipo tblAhorrosaFuturo. </returns>
        public IList<tblAhorrosNavidenoBonificacion> gmtdConsultarBonificacionesPremioxCuenta(string tstrCuenta)
        {
            return new daoAhorrosNavidenoBonificacion().gmtdConsultarBonificacionesPremioxCuenta(tstrCuenta);
        }

        /// <summary> Consulta las bonificaciones de intereses de una determinada cuenta. </summary>
        /// <param name="tstrCuenta">el código de la cuenta a la que se le van a consultar las bonificaciones. </param>
        /// <returns> un objeto del tipo tblAhorrosaFuturo. </returns>
        public IList<tblAhorrosNavidenoBonificacion> gmtdConsultarBonificacionesInteresesxCuenta(string tstrCuenta)
        {
            return new daoAhorrosNavidenoBonificacion().gmtdConsultarBonificacionesInteresesxCuenta(tstrCuenta);
        }

        /// <summary> Elimina una bonificación de premios de una cuenta. </summary>
        /// <param name="tobjAhorrosaFuturoBonificacion"> Un objeto del tipo tblAhorrosaFuturo. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminarBonificacion(tblAhorrosNavidenoBonificacion tobjAhorrosNavidenoBonificacion)
        {
            if ( tobjAhorrosNavidenoBonificacion.intCodigoBonificacion == 0)
                return "- Debe de ingresar la cuenta de bonificación a eliminar. ";

            tobjAhorrosNavidenoBonificacion.log = metodos.gmtdLog("Elimina la bonificación a futuro. " + tobjAhorrosNavidenoBonificacion.intCodigoBonificacion.ToString(), tobjAhorrosNavidenoBonificacion.strFormulario);

            if(tobjAhorrosNavidenoBonificacion.bitPremios)
                return new daoAhorrosNavidenoBonificacion().gmtdEliminarBonificacionPremio(tobjAhorrosNavidenoBonificacion);
            else
                return new daoAhorrosNavidenoBonificacion().gmtdEliminarBonificacionInteres(tobjAhorrosNavidenoBonificacion);
        }

    }
}
