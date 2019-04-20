namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fBarrio
    {
        /// <summary> Inserta un barrio. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo barrio. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblBarrio tobjBarrio)
        {
            return new blBarrio().gmtdInsertar(tobjBarrio);
        }

        /// <summary> Modifica un barrio. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo barrio.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblBarrio tobjBarrio)
        {
            return new blBarrio().gmtdEditar(tobjBarrio);
        }

        /// <summary> Consulta todos los barrios registrados. </summary>
        /// <param name="tAplicacion"> Un objeto del tipo barrio. </param>
        /// <returns> Un lista con todos los municipios seleccionados. </returns>
        public IList<barrio> gmtdConsultarTodos(string tstrCodMunicipio)
        {
            return new blBarrio().gmtdConsultarTodos(tstrCodMunicipio);
        }

        /// <summary> Consulta todos los barrios registrados. </summary>
        /// <returns> Un lista con todos los barrios seleccionados. </returns>
        public IList<barrio> gmtdConsultarTodos()
        {
            return new blBarrio().gmtdConsultarTodos();
        }

        /// <summary> Consulta todos los barrios registrados. </summary>
        /// <returns> Un lista con todos los barrios seleccionados. </returns>
        public IList<barrio> gmtdConsultarBarriosconMunicipios()
        {
            return new blBarrio().gmtdConsultarBarriosconMunicipios();
        }

        /// <summary> Seleccionar todos los barrios registrados. </summary>
        /// <returns> Un lista con los barrios registrados. </returns>
        public IList<tblBarrio> gmtdConsultar()
        {
            return new blBarrio().gmtdConsultar();
        }

        /// <summary> Elimina un barrio de la base de datos. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo tblBarrio. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblBarrio tobjBarrio)
        {
            return new blBarrio().gmtdEliminar(tobjBarrio);
        }
    }
}
