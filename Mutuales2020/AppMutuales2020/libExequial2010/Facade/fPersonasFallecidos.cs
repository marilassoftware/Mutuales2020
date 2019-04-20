
namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.logica;
    using libMutuales2020.dominio;

    [DataObject(true)]
    public class fFallecidos
    {
        /// <summary> Inserta un fallecido. </summary>
        /// <param name="tobjFallecido"> Un objeto del tipo agraciado. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblFallecido tobjFallecido)
        {
            return new blFallecidos().gmtdInsertar(tobjFallecido);
        }

        /// <summary> Modifica un Fallecido. </summary>
        /// <param name="tobjFallecido"> Un objeto del tipo Fallecido.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblFallecido tobjFallecido)
        {
            return new blFallecidos().gmtdEditar(tobjFallecido);
        }

        /// <summary> Consulta todos los fallecidos registrados. </summary>
        /// <returns> Un lista con todos los fallecidos seleccionados. </returns>
        public List<Fallecido> gmtdConsultarTodos()
        {
            return new blFallecidos().gmtdConsultarTodos();
        }

        /// <summary> Consulta todos los fallecidos registrados. </summary>
        /// <returns> Un lista con todos los fallecidos seleccionados. </returns>
        public IList<tblFallecido> gmtdConsultarTodosTbl()
        {
            return new blFallecidos().gmtdConsultarTodosTbl();
        }

        /// <summary>Selecciona los socios registrados cuya informacíón coicida con los
        /// campos de la clausula where. </summary>
        /// <param name="tobjSocio"> El objeto socio con los datos para filtrar </param>
        /// <returns> Un lista con los socios seleccionados. </returns>
        public IList<Fallecido> gmtdFiltrar(tblFallecido tobjFallecido)
        {
            return new blFallecidos().gmtdFiltrar(tobjFallecido);
        }

        /// <summary> Consulta los fallecidos registrados en un rango de fecha </summary>
        /// <param name="tdtmFechaIni"> Fecha inicial.</param>
        /// <param name="tdtmFechaFin"> Fecha Final. </param>
        /// <returns> El listado de los fallecidos seleccionados. </returns>
        public List<tblFallecido> gmtdConsultarFallecidosentreFechas(DateTime tdtmFechaIni, DateTime tdtmFechaFin)
        {
            return new blFallecidos().gmtdConsultarFallecidosentreFechas(tdtmFechaIni, tdtmFechaFin);
        }

        /// <summary> Elimina un fallecido de la base de datos. </summary>
        /// <param name="tobjFallecido"> Un objeto del tipo tblAgraciado. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblFallecido tobjFallecido)
        {
            return new blFallecidos().gmtdEliminar(tobjFallecido);
        }

        /// <summary> Consulta si una cedula esta registrada como socio, agraciado o si es particular. </summary>
        /// <param name="tstrCedulaFal"> El número de cédula a evaluar. </param>
        /// <returns> Un string con la procedencia de la cédula. </returns>
        public string gmtdBuscarCedula(string tstrCedulaFal)
        {
            return new blFallecidos().gmtdBuscarCedula(tstrCedulaFal);
        }

        /// <summary> Consulta el código de un socio a partir del número de la cédula. </summary>
        /// <param name="tstrCedulaSocio"> Cédula del socio a consultar. </param>
        /// <returns> El código del socio o -1 si no aparece registrada la cédula. </returns>
        public Int32 gmtdConsultarCodigoSocio(string tstrCedulaSocio)
        {
            return new blFallecidos().gmtdConsultarCodigoSocio(tstrCedulaSocio);
        }

        /// <summary> Consulta los agraciados registrados a un determinado socio. </summary>
        /// <param name="tintCodigoSocio"> Código del socio a consultar. </param>
        /// <returns> El listado de los agraciados seleccionados. </returns>
        public List<Agraciado> gmtdConsultar(int tintCodigoSocio)
        {
            return new blFallecidos().gmtdConsultar(tintCodigoSocio);
        }
    }
}
