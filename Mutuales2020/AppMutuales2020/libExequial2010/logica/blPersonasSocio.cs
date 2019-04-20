namespace libMutuales2020.logica
{
    using System;
    using System.Collections.Generic;
    using libMutuales2020.dao;
    using libMutuales2020.dominio;

    public class blSocio
    {
        /// <summary> Inserta un socio. </summary>
        /// <param name="tobjSocio"> Un objeto del tipo socio. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblSocio tobjSocio)
        {
            if(tobjSocio.intCodigoSoc == 0)
                return "- Debe de ingresar el código del socio.";

            if(tobjSocio.strApellido1Soc == null)
                return "- Debe de ingresar el apellido del socio. ";

            if (tobjSocio.strCedulaSoc == null)
                return "- Debe de ingresar la cédula del socio. ";

            if (tobjSocio.strCodBarrio == null)
                return "- Debe de ingresar el código del barrio. ";

            if (tobjSocio.strCodOficio == null)
                return "- Debe de ingresar el código del oficio. ";

            if (tobjSocio.strCodServiciop == null)
                return "- Debe de ingresar el código del servicio. ";

            if (tobjSocio.strCorreo == null)
                return "- Debe de ingresar el mail del socio. ";

            if (tobjSocio.strDireccion == null)
                return "- Debe de ingresar la dirección del socio. ";

            if (tobjSocio.strEscolaridad == null)
                return "- Debe de ingresar la escolaridad del socio. ";

            if (tobjSocio.strNombreSoc == null)
                return "- Debe de ingresar el nombre del socio. ";

            if (tobjSocio.strTelefono == null)
                return "- Debe de ingresar el Teléfono del socio. ";

            if (tobjSocio.strTipoCed == null)
                return "- Debe de ingresar el tipo de cedula del socio. ";

            if (tobjSocio.strTipoCed == null)
                return "- Debe de ingresar el tipo de cedula del socio. ";

            if (tobjSocio.dtmFechaIng >= DateTime.Now)
                return "- La fecha de ingreso no puede ser mayor a la actual. ";

            if (tobjSocio.dtmFechaNac >= DateTime.Now)
                return "- La fecha de nacimiento no puede ser mayor a la actual. ";

            if (tobjSocio.dtmFechaNac >= tobjSocio.dtmFechaIng)
                return "- La fecha de nacimiento no puede ser mayor a la fecha de ingreso. ";

            tblSocio soc = new daoSocio().gmtdConsultar(tobjSocio.intCodigoSoc);

            if (soc.intCodigoSoc == 0)
            {
                if (this.gmtdConsultarCedulaSocio(tobjSocio.strCedulaSoc) == false)
                {
                    if (this.gmtdConsultarCeduladeSocioAgraciadoFallecido(tobjSocio.strCedulaSoc) == false)
                    {
                        tobjSocio.bitAnulado = false;
                        tobjSocio.dtmFecAnulado = Convert.ToDateTime("01/01/1900");
                        tobjSocio.dtmFechaUlt = Convert.ToDateTime("01/01/1900");
                        tobjSocio.log = metodos.gmtdLog("Ingresa el socio " + tobjSocio.intCodigoSoc, tobjSocio.strFormulario);
                        return new daoSocio().gmtdInsertar(tobjSocio);
                    }
                    else
                        return "- El número cédula ya aparece ingresada como agraciada o como fallecida.";

                }
                else
                    return "- El número cédula ya aparece ingresada.";
            }
            else
                return "- Este registro ya aparece ingresado.";
        }

        /// <summary> Modifica un socio. </summary>
        /// <param name="tobjSocio"> Un objeto del tipo socio.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblSocio tobjSocio)
        {
            if (tobjSocio.intCodigoSoc == 0)
                return "- Debe de ingresar el código del socio.";

            if (tobjSocio.strApellido1Soc == null)
                return "- Debe de ingresar el apellido del socio. ";

            if (tobjSocio.strCedulaSoc == null)
                return "- Debe de ingresar la cédula del socio. ";

            if (tobjSocio.strCodBarrio == null)
                return "- Debe de ingresar el código del barrio. ";

            if (tobjSocio.strCodOficio == null)
                return "- Debe de ingresar el código del oficio. ";

            if (tobjSocio.strCodServiciop == null)
                return "- Debe de ingresar el código del servicio. ";

            if (tobjSocio.strCorreo == null)
                return "- Debe de ingresar el mail del socio. ";

            if (tobjSocio.strDireccion == null)
                return "- Debe de ingresar la dirección del socio. ";

            if (tobjSocio.strEscolaridad == null)
                return "- Debe de ingresar la escolaridad del socio. ";

            if (tobjSocio.strNombreSoc == null)
                return "- Debe de ingresar el nombre del socio. ";

            if (tobjSocio.strTelefono == null)
                return "- Debe de ingresar el Teléfono del socio. ";

            if (tobjSocio.strTipoCed == null)
                return "- Debe de ingresar el tipo de cedula del socio. ";

            if (tobjSocio.strTipoCed == null)
                return "- Debe de ingresar el tipo de cedula del socio. ";

            if (tobjSocio.dtmFechaIng >= DateTime.Now)
                return "- La fecha de ingreso no puede ser mayor a la actual. ";

            if (tobjSocio.dtmFechaNac >= DateTime.Now)
                return "- La fecha de nacimiento no puede ser mayor a la actual. ";

            if (tobjSocio.dtmFechaNac >= tobjSocio.dtmFechaIng)
                return "- La fecha de nacimiento no puede ser mayor a la fecha de ingreso. ";

            tblSocio soc = new daoSocio().gmtdConsultar(tobjSocio.intCodigoSoc);

            if (soc.intCodigoSoc == 0)
                return "- Este registro no aparece ingresado.";
            else
            {
                tobjSocio.log = metodos.gmtdLog("Modifica el socio " + tobjSocio.intCodigoSoc, tobjSocio.strFormulario);
                return new daoSocio().gmtdEditar(tobjSocio);
            }
        }

        /// <summary> Modifica los datos del socio solicitados por la aseguradora. </summary>
        /// <param name="tobjSocio"> Un objeto del tipo persona a modificar.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdActualizarDato(personasaModificar tobjPersona)
        {

            if (tobjPersona.dtmFechaNacimeinto == null || tobjPersona.dtmFechaNacimeinto == Convert.ToDateTime("1900-01-01"))
                return "- Debe de ingresar la fecha de nacimiento. ";

            if (tobjPersona.intCodigoSoc == 0)
                return "- Debe de ingresar el código del socio.";

            if (tobjPersona.strApellido1 == null)
                return "- Debe de ingresar el apellido del socio. ";

            if (tobjPersona.strCedula == null)
                return "- Debe de ingresar la cédula del socio. ";

            if (tobjPersona.strDireccion == null)
                return "- Debe de ingresar la dirección del socio. ";

            if (tobjPersona.strTelefono == null)
                return "- Debe de ingresar el Teléfono del socio. ";

            if (tobjPersona.strNombre == null)
                return "- Debe de ingresar el nombre del socio. ";

            tobjPersona.log = metodos.gmtdLog("Modifica el socio para aseguradora " + tobjPersona.intCodigoSoc, "FrmIngresos");

            return new daoSocio().gmtdActualizarDato(tobjPersona);
        }

        /// <summary> Modifica una la cédula de un socio. </summary>
        /// <param name="tobjAgraciado"> Número de cédula que desea modificar. </param>
        /// <param name="tobjAgraciado"> Número de cédula a modificar. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditarCeduladeSocio(string tstrCedulaaModificar, string tstrCambiarpor)
        {
            return new daoSocio().gmtdEditarCeduladeSocio(tstrCedulaaModificar, tstrCambiarpor);
        }

        /// <summary> Consulta todos los socios registrados. </summary>
        /// <returns> Un lista con todos los socios seleccionados. </returns>
        public IList<Socio> gmtdConsultarTodos()
        {
            return new daoSocio().gmtdConsultarTodos();  
        }

        /// <summary> Consulta si un número de cedula ya aparece registrado. </summary>
        /// <param name="tstrCedulaSocio"> Cédula del socio a consultar. </param>
        /// <returns> Un valor que indica si se encontro o no la cédula del socio. </returns>
        public bool gmtdConsultarCedulaSocio(string tstrCedulaSocio)
        {
            return new daoSocio().gmtdConsultarCedulaSocio(tstrCedulaSocio);   
        }

        /// <summary> Consulta los socios registrados con un determinado barrio. </summary>
        /// <param name="tstrCodigoBar"> Còdigo del barrio para seleccionar los socios. </param>
        /// <returns> Lista de los socios consultados. </returns>
        public List<tblSocio> gmtdConsultarSociosxBarrio(string tstrCodigoBar)
        {
            return new daoSocio().gmtdConsultarSociosxBarrio(tstrCodigoBar);
        }

        /// <summary> Consulta si un número de cedula ya aparece registrado como socio, Agraciado o Fallecido. </summary>
        /// <param name="tstrCedulaSocio"> Cédula a consultar. </param>
        /// <returns> Un valor que indica si se encontro o no la cédula del socio. </returns>
        public bool gmtdConsultarCeduladeSocioAgraciadoFallecido(string tstrCedulaaEvaluar)
        {
            return new daoSocio().gmtdConsultarCeduladeSocioAgraciadoFallecido(tstrCedulaaEvaluar);
        }

        /// <summary> Consulta los datos de un determinado socio. </summary>
        /// <param name="tintSocio"> El código del socio a consultar </param>
        /// <returns> Los datos de socio consultado. </returns>
        public tblSocio gmtdConsultarDetalle(int tintSocio)
        {
            return new daoSocio().gmtdConsultarDetalle(tintSocio);    
        }

        /// <summary> Consulta los datos de un determinado socio x su número de cédula. </summary>
        /// <param name="tintSocio"> El número de cédula del socio a consultar. </param>
        /// <returns> Los datos de socio consultado. </returns>
        public tblSocio gmtdConsultarDetalle(string tstrCedulaSocio)
        {
            return new daoSocio().gmtdConsultarDetalle(tstrCedulaSocio);
        }

        /// <summary>Selecciona los socios registrados cuya informacíón coicida con los campos de la clausula where. </summary>
        /// <param name="tobjSocio"> El objeto socio con los datos para filtrar </param>
        /// <returns> Un lista con los socios seleccionados. </returns>
        public IList<Socio> gmtdFiltrar(tblSocio tobjSocio)
        {
            if (tobjSocio.strCedulaSoc == "0")
                tobjSocio.strCedulaSoc = "";

            return new daoSocio().gmtdFiltrar(tobjSocio);   
        }

        /// <summary> Consulta un determinado socio. </summary>
        /// <param name="tintCodSocio">el código del socio a consultar.</param>
        /// <returns> un objeto del tipo tblSocio. </returns>
        public tblSocio gmtdConsultar(int tintCodigoSoc)
        {
            return new daoSocio().gmtdConsultar(tintCodigoSoc);
        }

        /// <summary> Consulta un determinado socio. </summary>
        /// <param name="tintCodSocio">el número de la cédula del socio.</param>
        /// <returns> un objeto del tipo tblSocio. </returns>
        public tblSocio gmtdConsultar(string tstrCedula)
        {
            return new daoSocio().gmtdConsultar(tstrCedula);
        }

        /// <summary> Elimina un socio de la base de datos. </summary>
        /// <param name="tobjSocio"> Un objeto del tipo tblSocio. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblSocio tobjSocio)
        {
            if (tobjSocio.intCodigoSoc == 0)
                return "- Debe de ingresar el código del socio a eliminar.";

            tblSocio soc = new daoSocio().gmtdConsultar(tobjSocio.intCodigoSoc);

            if (soc.intCodigoSoc == 0)
                return "- Este registro no aparece ingresado.";
            else
            {
                tobjSocio.log = metodos.gmtdLog("Elimina el socio " + tobjSocio.intCodigoSoc, tobjSocio.strFormulario);
                return new daoSocio().gmtdEliminar(tobjSocio);
            }
        }

        /// <summary> Cambia el socio con el que esta registrado un determinado agraciado. </summary>
        /// <param name="tintSocioActual"> Codigo del socio que actualmente tiene registrado el agraciado. </param>
        /// <param name="tstrCedulaAgra"> Cédula del agraciado que se va a cambiar de socio. </param>
        /// <param name="tintSocioNuvo"> Código del socio al que se va a cambiar el agraciado. </param>
        /// <returns> Un mensaje que indica si se registro o no la cédula. </returns>
        public string gmtdCambiarAgraciadodeSocio(int tintSocioActual, string tstrCedulaAgra, int tintSocioNuevo)
        {
            return new daoSocio().gmtdCambiarAgraciadodeSocio(tintSocioActual, tstrCedulaAgra, tintSocioNuevo);
        }

        /// <summary> Cambia un agraciado socio y el socio a agraciado. </summary>
        /// <param name="tobjAgraciado"> Agraciado que se va a registrar. </param>
        /// <param name="tobjSocio"> Socio que se va a acatualizar. </param>
        /// <param name="tstrCedulaAgra"> Cedula del agraciado que se va a eliminar. </param>
        /// <returns> Un mensaje indicando si se ejecuto o no la aoperación. </returns>
        public string gmtdCambiarAgraciadoaSocio(int tintCodigoSocio, string tstrCedulaAgra)
        {
            if (tintCodigoSocio <= 0)
                return "- Debe de ingresar el código del socio.";

            if(tstrCedulaAgra == null || tstrCedulaAgra == "")
                return "- Debe de seleccionar el agraciado.";

            tblSocio socio = new blSocio().gmtdConsultar(tintCodigoSocio);

            if(socio.bitAnulado == true)
                return "- Este socio esta anulado.";

            if (socio.strApellido1Soc == null)
                return "- Este socio no aparece registrado.";

            tblAgraciado agraciado = new blAgraciado().gmtdConsultarDetalle(tstrCedulaAgra);

            if (agraciado.bitAnulado == true)
                return "- Este agraciado esta anulado.";

            if (agraciado.strApellido1Agra == null)
                return "- Este agraciado no aparece registrado.";

            tblAgraciado agraciadoNuevo = new tblAgraciado();
            agraciadoNuevo.bitAnulado = false;
            agraciadoNuevo.bitSexo = socio.bitSexo;
            agraciadoNuevo.dtmFecAnulado = socio.dtmFecAnulado;
            agraciadoNuevo.dtmFechaIng = socio.dtmFechaIng;
            agraciadoNuevo.dtmFechaNac = socio.dtmFechaNac;
            agraciadoNuevo.intCodigoSoc = socio.intCodigoSoc;
            agraciadoNuevo.strApellido1Agra = socio.strApellido1Soc;
            agraciadoNuevo.strApellido2Agra = socio.strApellido2Soc;
            agraciadoNuevo.strNombreAgra = socio.strNombreSoc;
            agraciadoNuevo.strCedulaAgra = socio.strCedulaSoc;
            agraciadoNuevo.strCodBarrio = socio.strCodBarrio;
            agraciadoNuevo.strCodOficio = socio.strCodOficio;
            agraciadoNuevo.strCorreo = socio.strCorreo;
            agraciadoNuevo.strDireccion = socio.strDireccion;
            agraciadoNuevo.strEscolaridad = socio.strEscolaridad;
            agraciadoNuevo.strParentesco = agraciado.strParentesco;
            agraciadoNuevo.strTelefono = socio.strTelefono;
            agraciadoNuevo.strTipoCed = socio.strTipoCed;
            agraciadoNuevo.bitActualizado = false;

            socio.bitSexo = agraciado.bitSexo;
            socio.dtmFecAnulado = agraciado.dtmFecAnulado;
            socio.dtmFechaIng = agraciado.dtmFechaIng;
            socio.dtmFechaNac = agraciado.dtmFechaNac;
            socio.strApellido1Soc = agraciado.strApellido1Agra;
            socio.strApellido2Soc = agraciado.strApellido2Agra;
            socio.strNombreSoc = agraciado.strNombreAgra;
            socio.strCedulaSoc = agraciado.strCedulaAgra;
            socio.strCodBarrio = agraciado.strCodBarrio;
            socio.strCodOficio = agraciado.strCodOficio;
            socio.strCorreo = agraciado.strCorreo;
            socio.strDireccion = agraciado.strDireccion;
            socio.strEscolaridad = agraciado.strEscolaridad;
            socio.strTelefono = agraciado.strTelefono;
            socio.bitActualizado = false;

            return new daoSocio().gmtdCambiarAgraciadoaSocio(agraciadoNuevo, socio, tstrCedulaAgra);

        }

        /// <summary> Habilita un asociado que se encuentre deshabilitado. </summary>
        /// <param name="tstrCedulaAgra"> Cédula del socio a habilitar. </param>
        /// <returns> Un mensaje indicando si se ejecuto o no la operación. </returns>
        public string gmtdHabilitarAnulado(string tstrCodigoSoc)
        {
            tblSocio objSocio = this.gmtdConsultar(tstrCodigoSoc);

            if (objSocio.strNombreSoc != null)
            {
                return new daoSocio().gmtdHabilitarAnulado(objSocio.intCodigoSoc);
            }
            else
            {
                return "- Ocurrió un error al Actualizar el registro";
            }
        }

        /// <summary> Registra los cambios de nuevo año. </summary>
        /// <param name="tobjSocio"> Un objeto del tipo socio. </param>
        /// <param name="tobjNuevoAño"> Un objeto del tipo nuevo año. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdNuevoAño(tblSocio tobjSocio, tblLogNuevoAño tobjNuevoAño)
        {
            return new daoSocio().gmtdNuevoAño(tobjSocio, tobjNuevoAño);
        }
    }
}