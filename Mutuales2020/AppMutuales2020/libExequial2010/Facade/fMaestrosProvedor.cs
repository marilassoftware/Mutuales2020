namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fMaestrosProvedor
    {
        /// <summary> Inserta un provedor </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo tblProvedor. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblProvedore tobjProvedor)
        {
            return new blProvedor().gmtdInsertar(tobjProvedor);
        }

        /// <summary> Modifica un provedor. </summary>
        /// <param name="tobjProvedor"> Un objeto del tipo tblProvedor. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblProvedore tobjProvedor)
        {
            return new blProvedor().gmtdEditar(tobjProvedor);
        }

        /// <summary> Consulta todos los provedores registrados. </summary>
        /// <returns> Un lista con todos los provedores registrados. </returns>
        public IList<provedor> gmtdConsultarTodos()
        {
            return new blProvedor().gmtdConsultarTodos();
        }

        /// <summary> Elimina un provedor. </summary>
        /// <param name="tobjProvedor"> Un objeto del tipo provedor. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblProvedore tobjProvedor)
        {
            return new blProvedor().gmtdEliminar(tobjProvedor);
        }
    }
}
