namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fCreditosTipo
    {
        /// <summary> Inserta un tipo de credito. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo tipodecredito. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblCreditosTipo tobjTiposdeCredito)
        {
            return new blCreditosTipo().gmtdInsertar(tobjTiposdeCredito);
        }

        /// <summary> Modifica un tipo de credito. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo tipodecredito.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblCreditosTipo tobjTiposdeCredito)
        {
            return new blCreditosTipo().gmtdInsertar(tobjTiposdeCredito);
        }

        /// <summary> Consulta todos los tipos de credito registrados. </summary>
        /// <param name="tAplicacion"> Un objeto del tipo tipo de credito. </param>
        /// <returns> Un lista con todos los tipos de credito seleccionados. </returns>
        public IList<creditosTipo> gmtdConsultarTodos()
        {
            return new blCreditosTipo().gmtdConsultarTodos();
        }

        /// <summary> Elimina un tipo de credito de la base de datos. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo tipodecredito. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblCreditosTipo tobjTiposdeCredito)
        {
            return new blCreditosTipo().gmtdEliminar(tobjTiposdeCredito);
        }

    }
}
