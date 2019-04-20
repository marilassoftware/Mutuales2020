namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fAhorrosaFuturoBonificacion
    {
        /// <summary> Inserta una bonificación de ahorro a futuro. </summary>
        /// <param name="tobjAhorroaFuturoBonificacion"> Un objeto del tipo tblAhorrosaFuturoBonificacion. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblAhorrosaFuturoBonificacion tobjAhorroaFuturoBonificacion)
        {
            return new blAhorrosaFuturoBonificacion().gmtdInsertar(tobjAhorroaFuturoBonificacion);
        }

        /// <summary> Consulta todos las bonificaciones registradas. </summary>
        /// <returns> Un lista con todos las bonificaciones seleccionadas. </returns>
        public IList<tblAhorrosaFuturoBonificacion> gmtdConsultarTodos()
        {
            return new blAhorrosaFuturoBonificacion().gmtdConsultarTodos();
        }

        /// <summary> Consulta una determinada bonificación. </summary>
        /// <param name="tstrCuenta">el código de la bonificación a consultar.</param>
        /// <returns> un objeto del tipo tblAhorrosaFuturo. </returns>
        public tblAhorrosaFuturoBonificacion gmtdConsultar(int tintBonificacion)
        {
            return new blAhorrosaFuturoBonificacion().gmtdConsultar(tintBonificacion);
        }

        /// <summary> Consulta las bonificaciones premio de una determinada cuenta. </summary>
        /// <param name="tstrCuenta">el código de la cuenta a la que se le van a consultar las bonificaciones. </param>
        /// <returns> un objeto del tipo tblAhorrosaFuturo. </returns>
        public IList<tblAhorrosaFuturoBonificacion> gmtdConsultarBonificacionesPremioxCuenta(string tstrCuenta)
        {
            return new blAhorrosaFuturoBonificacion().gmtdConsultarBonificacionesPremioxCuenta(tstrCuenta);
        }

        /// <summary> Consulta las bonificaciones de intereses de una determinada cuenta. </summary>
        /// <param name="tstrCuenta">el código de la cuenta a la que se le van a consultar las bonificaciones. </param>
        /// <returns> un objeto del tipo tblAhorrosaFuturo. </returns>
        public IList<tblAhorrosaFuturoBonificacion> gmtdConsultarBonificacionesInteresesxCuenta(string tstrCuenta)
        {
            return new blAhorrosaFuturoBonificacion().gmtdConsultarBonificacionesInteresesxCuenta(tstrCuenta);
        }

        /// <summary> Elimina una bonificación de premios de una cuenta. </summary>
        /// <param name="tobjAhorrosaFuturoBonificacion"> Un objeto del tipo tblAhorrosaFuturo. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminarBonificacion(tblAhorrosaFuturoBonificacion tobjAhorrosaFuturoBonificacion)
        {
            return new blAhorrosaFuturoBonificacion().gmtdEliminarBonificacion(tobjAhorrosaFuturoBonificacion);
        }

    }
}
