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
    public class blAhorrosaFuturoBonificacion
    {
        /// <summary> Inserta una bonificación de ahorro a futuro. </summary>
        /// <param name="tobjAhorroaFuturoBonificacion"> Un objeto del tipo tblAhorrosaFuturoBonificacion. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblAhorrosaFuturoBonificacion tobjAhorroaFuturoBonificacion)
        {
            if (tobjAhorroaFuturoBonificacion.bitIntereses == false && tobjAhorroaFuturoBonificacion.bitPremios == false)
                return "- Debe de escojer si la bonificacion es por intereses o premios. ";

            if (tobjAhorroaFuturoBonificacion.dtmFechaSorteo == null)
                return "- Debe de ingresar la fecha de la bonificación. ";

            if (tobjAhorroaFuturoBonificacion.fltValor == 0)
                return "- Debe de ingresar el valor de la bonificación. ";

            if (tobjAhorroaFuturoBonificacion.strCuenta == null || tobjAhorroaFuturoBonificacion.strCuenta == "")
                return "- Debe de ingresar la cuenta de la bonificación. ";

            tblAhorrosaFuturo ahorro = new daoAhorrosaFuturo().gmtdConsultar(tobjAhorroaFuturoBonificacion.strCuenta);
            if (ahorro.strCuenta == null)
                return "- Debe de ingresar una cuenta valida para la bonificación. ";

            if (ahorro.bitAnulado == true)
                return "- No se puede registrar bonificaciones a una cuenta anulada. ";

            if (ahorro.bitLiquidada == true)
                return "- No se puede registrar bonificaciones a una cuenta liquidada. ";

            tobjAhorroaFuturoBonificacion.bitAnulado = false;
            tobjAhorroaFuturoBonificacion.dtmFechaAnulado = Convert.ToDateTime("1900/01/01");

            tobjAhorroaFuturoBonificacion.log = metodos.gmtdLog("Ingresa la bonificación a futuro. " + tobjAhorroaFuturoBonificacion.strCuenta, tobjAhorroaFuturoBonificacion.strFormulario);

            return new daoAhorrosaFuturoBonificacion().gmtdInsertar(tobjAhorroaFuturoBonificacion);
        }

        /// <summary> Consulta todos las bonificaciones registradas. </summary>
        /// <returns> Un lista con todos las bonificaciones seleccionadas. </returns>
        public IList<tblAhorrosaFuturoBonificacion> gmtdConsultarTodos()
        {
            return new daoAhorrosaFuturoBonificacion().gmtdConsultarTodos();
        }

        /// <summary> Consulta una determinada bonificación. </summary>
        /// <param name="tstrCuenta">el código de la bonificación a consultar.</param>
        /// <returns> un objeto del tipo tblAhorrosaFuturo. </returns>
        public tblAhorrosaFuturoBonificacion gmtdConsultar(int tintBonificacion)
        {
            return new daoAhorrosaFuturoBonificacion().gmtdConsultar(tintBonificacion);
        }

        /// <summary> Consulta las bonificaciones premio de una determinada cuenta. </summary>
        /// <param name="tstrCuenta">el código de la cuenta a la que se le van a consultar las bonificaciones. </param>
        /// <returns> un objeto del tipo tblAhorrosaFuturo. </returns>
        public IList<tblAhorrosaFuturoBonificacion> gmtdConsultarBonificacionesPremioxCuenta(string tstrCuenta)
        {
            return new daoAhorrosaFuturoBonificacion().gmtdConsultarBonificacionesPremioxCuenta(tstrCuenta);
        }

        /// <summary> Consulta las bonificaciones de intereses de una determinada cuenta. </summary>
        /// <param name="tstrCuenta">el código de la cuenta a la que se le van a consultar las bonificaciones. </param>
        /// <returns> un objeto del tipo tblAhorrosaFuturo. </returns>
        public IList<tblAhorrosaFuturoBonificacion> gmtdConsultarBonificacionesInteresesxCuenta(string tstrCuenta)
        {
            return new daoAhorrosaFuturoBonificacion().gmtdConsultarBonificacionesInteresesxCuenta(tstrCuenta);
        }

        /// <summary> Elimina una bonificación de premios de una cuenta. </summary>
        /// <param name="tobjAhorrosaFuturoBonificacion"> Un objeto del tipo tblAhorrosaFuturo. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminarBonificacion(tblAhorrosaFuturoBonificacion tobjAhorrosaFuturoBonificacion)
        {
            if ( tobjAhorrosaFuturoBonificacion.intCodigoBonificacion == 0)
                return "- Debe de ingresar la cuenta de bonificación a eliminar. ";

            tobjAhorrosaFuturoBonificacion.log = metodos.gmtdLog("Elimina la bonificación a futuro. " + tobjAhorrosaFuturoBonificacion.intCodigoBonificacion.ToString(), tobjAhorrosaFuturoBonificacion.strFormulario);

            if(tobjAhorrosaFuturoBonificacion.bitPremios)
                return new daoAhorrosaFuturoBonificacion().gmtdEliminarBonificacionPremio(tobjAhorrosaFuturoBonificacion);
            else
                return new daoAhorrosaFuturoBonificacion().gmtdEliminarBonificacionInteres(tobjAhorrosaFuturoBonificacion);
        }

    }
}
