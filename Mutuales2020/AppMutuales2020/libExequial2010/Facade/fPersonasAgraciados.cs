namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fAgraciados
    {
        /// <summary> Inserta un Agraciado. </summary>
        /// <param name="tobjAgraciado"> Un objeto del tipo agraciado. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblAgraciado tobjAgraciado)
        {
            return new blAgraciado().gmtdInsertar(tobjAgraciado);
        }

        /// <summary> Modifica un Agraciado. </summary>
        /// <param name="tobjAgraciado"> Un objeto del tipo Agraciado.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblAgraciado tobjAgraciado)
        {
            return new blAgraciado().gmtdEditar(tobjAgraciado);
        }

        /// <summary> Modifica los datos del agraciado solicitados por la aseguradora. </summary>
        /// <param name="tobjSocio"> Un objeto del tipo persona a modificar.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdActualizarDato(personasaModificar tobjPersona)
        {

            return new blAgraciado().gmtdActualizarDato(tobjPersona);
        }

        /// <summary> Modifica un la cédula de un agraciado. </summary>
        /// <param name="tobjAgraciado"> Número de cédula que desea modificar. </param>
        /// <param name="tobjAgraciado"> Número de cédula a modificar. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditarCeduladeAgraciado(string tstrCedulaaModificar, string tstrCambiarpor)
        {
            return new blAgraciado().gmtdEditarCeduladeAgraciado(tstrCedulaaModificar, tstrCambiarpor);
        }

        /// <summary> Consulta los agraciados registrados con un determinado barrio. </summary>
        /// <param name="tstrCodigoBar"> Còdigo del barrio para seleccionar los agraciados. </param>
        /// <returns> Lista de los agraciados consultados. </returns>
        public List<tblAgraciado> gmtdConsultarAgraciadosxBarrio(string tstrCodigoBar)
        {
            return new blAgraciado().gmtdConsultarAgraciadosxBarrio(tstrCodigoBar);
        }

        /// <summary> Consulta los datos de un determinado agraciado. </summary>
        /// <param name="tintSocio"> El código del socio a consultar </param>
        /// <returns> Los datos de agraciado consultado. </returns>
        public tblAgraciado gmtdConsultarDetalle(string tstrCedulaAgra)
        {
            return new blAgraciado().gmtdConsultarDetalle(tstrCedulaAgra);
        }

        /// <summary> Consulta todos los agraciados registrados. </summary>
        /// <returns> Un lista con todos los agraciados seleccionados. </returns>
        public IList<Agraciado> gmtdConsultarTodos()
        {
            return new blAgraciado().gmtdConsultarTodos();
        }

        /// <summary> Elimina un agraciado de la base de datos. </summary>
        /// <param name="tobjAgraciado"> Un objeto del tipo tblAgraciado. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblAgraciado tobjAgraciado)
        {
            return new blAgraciado().gmtdEliminar(tobjAgraciado);
        }

        /// <summary>Selecciona los socios registrados cuya informacíón coicida con los campos de la clausula where. </summary>
        /// <param name="tobjSocio"> El objeto socio con los datos para filtrar </param>
        /// <returns> Un lista con los socios seleccionados. </returns>
        public IList<Agraciado> gmtdFiltrar(tblAgraciado tobjAgraciado)
        {
            return new blAgraciado().gmtdFiltrar(tobjAgraciado);
        }

        /// <summary> Consulta los agraciados registrados a un determinado socio. </summary>
        /// <param name="tintCodigoSocio"> Código del socio a consultar. </param>
        /// <returns> El listado de los agraciados seleccionados. </returns>
        public List<Agraciado> gmtdConsultar(int tintCodigoSocio)
        {
            return new blAgraciado().gmtdConsultar(tintCodigoSocio);
        }

        /// <summary> Consulta un determinado agraciado. </summary>
        /// <param name="tstrCedAgraciado">la cédula del agraciado a consultar.</param>
        /// <returns> un objeto del tipo tblAgraciado. </returns>
        public tblAgraciado gmtdConsultar(string tstrCedAgraciado)
        {
            return new blAgraciado().gmtdConsultar(tstrCedAgraciado);
        }

        /// <summary> Habilita un agraciado que se encuentre deshabilitado. </summary>
        /// <param name="tstrCedulaAgra"> Cédula del agraciado a habilitar. </param>
        /// <returns> Un mensaje indicando si se ejecuto o no la operación. </returns>
        public string gmtdHabilitarAnulado(string tstrCedulaAgra)
        {
            return new blAgraciado().gmtdHabilitarAnulado(tstrCedulaAgra);
        }
    }
}
