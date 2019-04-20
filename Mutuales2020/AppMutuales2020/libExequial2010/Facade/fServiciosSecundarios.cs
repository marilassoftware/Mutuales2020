namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fSecundarios
    {
        /// <summary> Inserta un servicio secundario. </summary>
        /// <param name="tobjServicio"> Un objeto del tipo tblServiciosSecundario. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblServiciosSecundario tobjServicio)
        {
            return new blSecundarios().gmtdInsertar(tobjServicio);
        }

        /// <summary> Modifica un servicio secundario. </summary>
        /// <param name="tobjServicio"> Un objeto del tipo tblServiciosSecundario.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblServiciosSecundario tobjServicio)
        {
            return new blSecundarios().gmtdEditar(tobjServicio);
        }

        /// <summary> Consulta todos los servicios secundarios. </summary>
        /// <returns> Un lista con todos los servicios secundarios seleccionados. </returns>
        public IList<Secundarios> gmtdConsultarTodos()
        {
            return new blSecundarios().gmtdConsultarTodos();
        }

        /// <summary> Consulta un determinado servicio secundario. </summary>
        /// <param name="tstrCodigo"> El código de servicio secundario a consultar. </param>
        /// <returns> Un servicio secundario consultado. </returns>
        public tblServiciosSecundario gmtdConsultar(string tstrCodigo)
        {
            return new blSecundarios().gmtdConsultar(tstrCodigo);
        }

        /// <summary> Elimina un servicio secundario de la base de datos. </summary>
        /// <param name="tobjServicio"> Un objeto del tipo tblServiciosSecundario. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblServiciosSecundario tobjServicio)
        {
            return new blSecundarios().gmtdEliminar(tobjServicio);
        }
    }
}
