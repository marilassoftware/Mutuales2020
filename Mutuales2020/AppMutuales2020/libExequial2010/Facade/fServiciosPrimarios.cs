namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fPrimarios
    {
        /// <summary> Inserta un servicio primario. </summary>
        /// <param name="tobjServicio"> Un objeto del tipo tblServiciosPrimario. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblServiciosPrimario tobjServicio)
        {
            return new blPrimarios().gmtdInsertar(tobjServicio);
        }

        /// <summary> Modifica un servicio primario. </summary>
        /// <param name="tobjServicioPrimario"> Un objeto del tipo tblServiciosPrimario.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblServiciosPrimario tobjServicio)
        {
            return new blPrimarios().gmtdEditar(tobjServicio);
        }

        /// <summary> Consulta todos los servicios primarios. </summary>
        /// <returns> Un lista con todos los servicios primarios seleccionados. </returns>
        public IList<Primarios> gmtdConsultarTodos()
        {
            return new blPrimarios().gmtdConsultarTodos();
        }

        /// <summary> Consulta un determinado servicio primario. </summary>
        /// <param name="tstrCodigo"> El código de servicio primario a consultar. </param>
        /// <returns> Un servicio primario consultado. </returns>
        public tblServiciosPrimario gmtdConsultar(string tstrCodigo)
        {
            return new blPrimarios().gmtdConsultar(tstrCodigo);
        }

        /// <summary> Elimina un servicio primario de la base de datos. </summary>
        /// <param name="tobjPrimarios"> Un objeto del tipo tblServiciosPrimarios. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblServiciosPrimario tobjServicio)
        {
            return new blPrimarios().gmtdEliminar(tobjServicio);
        }
    }
}
