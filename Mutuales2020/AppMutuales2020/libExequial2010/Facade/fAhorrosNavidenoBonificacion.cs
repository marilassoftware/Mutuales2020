namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fAhorrosNavidenoBonificacion
    {
        /// <summary> Inserta una bonificación de ahorro Navideño. </summary>
        /// <param name="tobjAhorroaFuturoBonificacion"> Un objeto del tipo tblAhorrosNavidenoBonificacion. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblAhorrosNavidenoBonificacion tobjAhorroNavidenoBonificacion)
        {
            return new blAhorrosNavidenoBonificacion().gmtdInsertar(tobjAhorroNavidenoBonificacion);
        }

        /// <summary> Consulta todos las bonificaciones registradas. </summary>
        /// <returns> Un lista con todos las bonificaciones seleccionadas. </returns>
        public IList<tblAhorrosNavidenoBonificacion> gmtdConsultarTodos()
        {
            return new blAhorrosNavidenoBonificacion().gmtdConsultarTodos();
        }

        /// <summary> Consulta una determinada bonificación. </summary>
        /// <param name="tstrCuenta">el código de la bonificación a consultar.</param>
        /// <returns> un objeto del tipo tblAhorrosaFuturo. </returns>
        public tblAhorrosNavidenoBonificacion gmtdConsultar(int tintBonificacion)
        {
            return new blAhorrosNavidenoBonificacion().gmtdConsultar(tintBonificacion);
        }

        /// <summary> Consulta las bonificaciones premio de una determinada cuenta. </summary>
        /// <param name="tstrCuenta">el código de la cuenta a la que se le van a consultar las bonificaciones. </param>
        /// <returns> un objeto del tipo tblAhorrosaFuturo. </returns>
        public IList<tblAhorrosNavidenoBonificacion> gmtdConsultarBonificacionesPremioxCuenta(string tstrCuenta)
        {
            return new blAhorrosNavidenoBonificacion().gmtdConsultarBonificacionesPremioxCuenta(tstrCuenta);
        }

        /// <summary> Consulta las bonificaciones de intereses de una determinada cuenta. </summary>
        /// <param name="tstrCuenta">el código de la cuenta a la que se le van a consultar las bonificaciones. </param>
        /// <returns> un objeto del tipo tblAhorrosaFuturo. </returns>
        public IList<tblAhorrosNavidenoBonificacion> gmtdConsultarBonificacionesInteresesxCuenta(string tstrCuenta)
        {
            return new blAhorrosNavidenoBonificacion().gmtdConsultarBonificacionesInteresesxCuenta(tstrCuenta);
        }

        /// <summary> Elimina una bonificación de premios de una cuenta. </summary>
        /// <param name="tobjAhorrosaFuturoBonificacion"> Un objeto del tipo tblAhorrosaFuturo. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminarBonificacion(tblAhorrosNavidenoBonificacion tobjAhorrosNavidenoBonificacion)
        {
            return new blAhorrosNavidenoBonificacion().gmtdEliminarBonificacion(tobjAhorrosNavidenoBonificacion);
        }

    }
}
