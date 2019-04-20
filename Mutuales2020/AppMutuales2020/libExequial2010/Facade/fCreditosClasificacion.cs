namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fCreditosClasificacion
    {
        /// <summary> Inserta un tipo de clasificacion. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo clasificación. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblCreditosClasificacion tobjClasificaciondeCredito)
        {
            return new blCreditosClasificacion().gmtdInsertar(tobjClasificaciondeCredito);
        }

        /// <summary> Modifica una clasificación de credito. </summary>
        /// <param name="tobjTiposdeCredito"> Un objeto del tipo tblCreditosClasificacion.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblCreditosClasificacion tobjClasificaciondeCredito)
        {
            return new blCreditosClasificacion().gmtdEditar(tobjClasificaciondeCredito);
        }

        /// <summary> Consulta todas las clasificaciones de creditos. </summary>
        /// <returns> Un lista con todas las clasificaciones de crédito. </returns>
        public IList<creditosClasificacion> gmtdConsultarTodos()
        {
            return new blCreditosClasificacion().gmtdConsultarTodos();
        }

        /// <summary> Consulta una determinada clasificacion de credito. </summary>
        /// <param name="tobjClasificaciondeCredito">el código de la clasificación de crédito.</param>
        /// <returns> un objeto del tipo tblCreditosClasificacion. </returns>
        public tblCreditosClasificacion gmtdConsultar(string tobjClasificaciondeCredito)
        {
            return new blCreditosClasificacion().gmtdConsultar(tobjClasificaciondeCredito);
        }

        /// <summary> Elimina una clasificación de credito. </summary>
        /// <param name="tobjClasificaciondeCredito"> Un objeto del tipo tblCreditosClasificacion. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblCreditosClasificacion tobjClasificaciondeCredito)
        {
            return new blCreditosClasificacion().gmtdEliminar(tobjClasificaciondeCredito);
        }

    }
}
