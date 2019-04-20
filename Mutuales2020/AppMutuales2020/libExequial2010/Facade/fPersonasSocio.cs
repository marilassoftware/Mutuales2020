namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fPersonasSocio
    {
        /// <summary> Inserta un socio. </summary>
        /// <param name="tobjSocio"> Un objeto del tipo socio. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblSocio tobjSocio)
        {
            return new blSocio().gmtdInsertar(tobjSocio);
        }

        /// <summary> Modifica un socio. </summary>
        /// <param name="tobjSocio"> Un objeto del tipo socio.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblSocio tobjSocio)
        {
            return new blSocio().gmtdEditar(tobjSocio);
        }

        /// <summary> Modifica los datos del socio solicitados por la aseguradora. </summary>
        /// <param name="tobjSocio"> Un objeto del tipo persona a modificar.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdActualizarDato(personasaModificar tobjPersona)
        {
            return new blSocio().gmtdActualizarDato(tobjPersona);
        }

        /// <summary> Modifica una la cédula de un socio. </summary>
        /// <param name="tobjAgraciado"> Número de cédula que desea modificar. </param>
        /// <param name="tobjAgraciado"> Número de cédula a modificar. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditarCeduladeSocio(string tstrCedulaaModificar, string tstrCambiarpor)
        {
            return new blSocio().gmtdEditarCeduladeSocio(tstrCedulaaModificar, tstrCambiarpor);
        }

        /// <summary> Consulta todos los socios registrados. </summary>
        /// <returns> Un lista con todos los socios seleccionados. </returns>
        public IList<Socio> gmtdConsultarTodos()
        {
            return new blSocio().gmtdConsultarTodos();
        }

        /// <summary> Consulta si un número de cedula ya aparece registrado. </summary>
        /// <param name="tstrCedulaSocio"> Cédula del socio a consultar. </param>
        /// <returns> Un valor que indica si se encontro o no la cédula del socio. </returns>
        public bool gmtdConsultarCedulaSocio(string tstrCedulaSocio)
        {
            return new blSocio().gmtdConsultarCedulaSocio(tstrCedulaSocio);
        }

        /// <summary> Consulta los socios registrados con un determinado barrio. </summary>
        /// <param name="tstrCodigoBar"> Còdigo del barrio para seleccionar los socios. </param>
        /// <returns> Lista de los socios consultados. </returns>
        public List<tblSocio> gmtdConsultarSociosxBarrio(string tstrCodigoBar)
        {
            return new blSocio().gmtdConsultarSociosxBarrio(tstrCodigoBar);
        }

        /// <summary> Consulta si un número de cedula ya aparece registrado como socio, Agraciado o Fallecido. </summary>
        /// <param name="tstrCedulaSocio"> Cédula a consultar. </param>
        /// <returns> Un valor que indica si se encontro o no la cédula del socio. </returns>
        public bool gmtdConsultarCeduladeSocioAgraciadoFallecido(string tstrCedulaaEvaluar)
        {
            return new blSocio().gmtdConsultarCeduladeSocioAgraciadoFallecido(tstrCedulaaEvaluar);
        }

        /// <summary> Consulta los datos de un determinado socio. </summary>
        /// <param name="tintSocio"> El código del socio a consultar </param>
        /// <returns> Los datos de socio consultado. </returns>
        public tblSocio gmtdConsultarDetalle(int tintSocio)
        {
            return new blSocio().gmtdConsultarDetalle(tintSocio);
        }

        /// <summary> Consulta los datos de un determinado socio x su número de cédula. </summary>
        /// <param name="tintSocio"> El número de cédula del socio a consultar. </param>
        /// <returns> Los datos de socio consultado. </returns>
        public tblSocio gmtdConsultarDetalle(string tstrCedulaSocio)
        {
            return new blSocio().gmtdConsultarDetalle(tstrCedulaSocio);
        }

        /// <summary>Selecciona los socios registrados cuya informacíón coicida con los campos de la clausula where. </summary>
        /// <param name="tobjSocio"> El objeto socio con los datos para filtrar </param>
        /// <returns> Un lista con los socios seleccionados. </returns>
        public IList<Socio> gmtdFiltrar(tblSocio tobjSocio)
        {
            return new blSocio().gmtdFiltrar(tobjSocio);
        }

        /// <summary> Consulta un determinado socio. </summary>
        /// <param name="tintCodSocio">el código del socio a consultar.</param>
        /// <returns> un objeto del tipo tblSocio. </returns>
        public tblSocio gmtdConsultar(int tintCodigoSoc)
        {
            return new blSocio().gmtdConsultar(tintCodigoSoc);
        }

        /// <summary> Consulta un determinado socio. </summary>
        /// <param name="tintCodSocio">el número de la cédula del socio.</param>
        /// <returns> un objeto del tipo tblSocio. </returns>
        public tblSocio gmtdConsultar(string tstrCedula)
        {
            return new blSocio().gmtdConsultar(tstrCedula);
        }

        /// <summary> Elimina un socio de la base de datos. </summary>
        /// <param name="tobjSocio"> Un objeto del tipo tblSocio. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblSocio tobjSocio)
        {
            return new blSocio().gmtdEliminar(tobjSocio);
        }

        /// <summary> Cambia el socio con el que esta registrado un determinado agraciado. </summary>
        /// <param name="tintSocioActual"> Codigo del socio que actualmente tiene registrado el agraciado. </param>
        /// <param name="tstrCedulaAgra"> Cédula del agraciado que se va a cambiar de socio. </param>
        /// <param name="tintSocioNuvo"> Código del socio al que se va a cambiar el agraciado. </param>
        /// <returns> Un mensaje que indica si se registro o no la cédula. </returns>
        public string gmtdCambiarAgraciadodeSocio(int tintSocioActual, string tstrCedulaAgra, int tintSocioNuevo)
        {
            return new blSocio().gmtdCambiarAgraciadodeSocio(tintSocioActual, tstrCedulaAgra, tintSocioNuevo);
        }

        /// <summary> Cambia un agraciado socio y el socio a agraciado. </summary>
        /// <param name="tobjAgraciado"> Agraciado que se va a registrar. </param>
        /// <param name="tobjSocio"> Socio que se va a acatualizar. </param>
        /// <param name="tstrCedulaAgra"> Cedula del agraciado que se va a eliminar. </param>
        /// <returns> Un mensaje indicando si se ejecuto o no la aoperación. </returns>
        public string gmtdCambiarAgraciadoaSocio(int tintCodigoSocio, string tstrCedulaAgra)
        {
            return new blSocio().gmtdCambiarAgraciadoaSocio(tintCodigoSocio, tstrCedulaAgra);
        }

        /// <summary> Habilita un asociado que se encuentre deshabilitado. </summary>
        /// <param name="tstrCedulaAgra"> Cédula del socio a habilitar. </param>
        /// <returns> Un mensaje indicando si se ejecuto o no la operación. </returns>
        public string gmtdHabilitarAnulado(string tstrCedulaSoc)
        {
            return new blSocio().gmtdHabilitarAnulado(tstrCedulaSoc);
        }

        /// <summary> Registra los cambios de nuevo año. </summary>
        /// <param name="tobjSocio"> Un objeto del tipo socio. </param>
        /// <param name="tobjNuevoAño"> Un objeto del tipo nuevo año. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdNuevoAño(tblSocio tobjSocio, tblLogNuevoAño tobjNuevoAño)
        {
            return new blSocio().gmtdNuevoAño(tobjSocio, tobjNuevoAño);
        }
    }
}
