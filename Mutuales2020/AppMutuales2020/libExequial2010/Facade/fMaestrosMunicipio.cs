namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    
    [DataObject(true)]
    public class fMunicipio
    {
        /// <summary> Inserta un municipio. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo municipio. </param>
        /// <returns> un string indicando si se ejecuto o no satisfactoriamente el metodo. </returns>
        public string gmtdInsertar(tblMunicipio tobjMunicipio)
        {
            return new blMunicipio().gmtdInsertar(tobjMunicipio);
        }

        /// <summary> Modifica un municipio. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo municipio.</param>
        /// <returns> Un string indicando si se ejecuto o no el metodo. </returns>
        public string gmtdEditar(tblMunicipio tobjMunicipio)
        {
            return new blMunicipio().gmtdEditar(tobjMunicipio);
        }

        /// <summary> Consulta todos los municipios registrados. </summary>
        /// <param name="tAplicacion"> Un objeto del tipo municipio. </param>
        /// <returns> Un lista con todos los municipios seleccionados. </returns>
        public List<municipio> gmtdConsultarTodos()
        {
            return new blMunicipio().gmtdConsultarTodos();
        }

        /// <summary> Elimina un municipio de la base de datos. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo munipio. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblMunicipio tobjMunicipio)
        {
            return new blMunicipio().gmtdEliminar(tobjMunicipio);
        }

    }
}
