namespace libMutuales2020.logica
{
    using System;
    using System.Collections.Generic;
    using libMutuales2020.dao;
    using libMutuales2020.dominio;

    public class blAgraciado
    {
        /// <summary> Inserta un Agraciado. </summary>
        /// <param name="tobjAgraciado"> Un objeto del tipo agraciado. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblAgraciado tobjAgraciado)
        {
            if (tobjAgraciado.intCodigoSoc == 0)
                return "- Debe de ingresar el código del Agraciado. ";

            if (tobjAgraciado.strCedulaAgra.Trim() == "")
                return "- Debe de ingresar la cédula del Agraciado. ";

            if (tobjAgraciado.strNombreAgra.Trim() == "")
                return "- Debe de ingresar el nombre del Agraciado. ";

            if (tobjAgraciado.strApellido1Agra.Trim() == "")
                return "- Debe de ingresar el apellido del Agraciado. ";

            if (tobjAgraciado.strDireccion.Trim() == "")
                return "- Debe de ingresar la direccion del Agraciado. ";

            if (tobjAgraciado.strTelefono.Trim() == "")
                return "- Debe de ingresar el teléfono del agraciado. ";

            if (tobjAgraciado.strTelefono.Trim() == "")
                return "- Debe de ingresar el teléfono del agraciado. ";

            if (tobjAgraciado.dtmFechaIng == null)
                return "- Debe de ingresar el barrio del Agraciado. ";

            if (tobjAgraciado.dtmFechaIng >= DateTime.Now)
                return "- La fecha de ingreso no puede ser mayor a la actual. ";

            if (tobjAgraciado.dtmFechaNac == null)
                return "- Debe de ingresar el barrio del Agraciado. ";

            if (tobjAgraciado.dtmFechaNac >= DateTime.Now)
                return "- La fecha de nacimiento no puede ser mayor a la actual. ";

            if (tobjAgraciado.strCodBarrio.Trim() == "")
                return "- Debe de ingresar el barrio del Agraciado. ";

            if (tobjAgraciado.strCodOficio.Trim() == "")
                return "- Debe de ingresar el oficio del Agraciado. ";

            if (tobjAgraciado.strEscolaridad.Trim() == "")
                return "- Debe de ingresar la escolaridad del Agraciado. ";

            if (tobjAgraciado.strParentesco.Trim() == "")
                return "- Debe de ingresar el parentesco del Agraciado con el agraciado. ";

            if (tobjAgraciado.strTipoCed.Trim() == "")
                return "- Debe de ingresar el tipo de cédula del agraciado. ";

            if (new blSocio().gmtdConsultar(tobjAgraciado.intCodigoSoc).strCedulaSoc == null)
                return "- El código de socio no aparece registrado. ";

            tblAgraciado agr = new daoAgraciado().gmtdConsultar(tobjAgraciado.strCedulaAgra);

            if (agr.strCedulaAgra == null)
            {
                if (new blSocio().gmtdConsultarCeduladeSocioAgraciadoFallecido(tobjAgraciado.strCedulaAgra) == false)
                {
                    tobjAgraciado.log = metodos.gmtdLog("Ingresa el Agraciado " + tobjAgraciado.strCedulaAgra, tobjAgraciado.strFormulario);
                    tobjAgraciado.bitAnulado = false;
                    tobjAgraciado.dtmFecAnulado = Convert.ToDateTime("1900/01/01");
                    return new daoAgraciado().gmtdInsertar(tobjAgraciado);
                }
                else
                    return "- Esta cédula ya aparece registrada como socio o fallecido.";

            }
            else
                return "- Este registro ya aparece ingresado.";
        }

        /// <summary> Modifica un Agraciado. </summary>
        /// <param name="tobjAgraciado"> Un objeto del tipo Agraciado.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblAgraciado tobjAgraciado)
        {
            if (tobjAgraciado.intCodigoSoc == 0)
                return "- Debe de ingresar el código del socio. ";

            if (tobjAgraciado.strApellido1Agra.Trim() == "")
                return "- Debe de ingresar el apellido del agraciado. ";

            if (tobjAgraciado.strCodBarrio.Trim() == "")
                return "- Debe de ingresar el barrio del agraciado. ";

            if (tobjAgraciado.strCodOficio.Trim() == "")
                return "- Debe de ingresar el oficio del agraciado. ";

            if (tobjAgraciado.strCedulaAgra.Trim() == "")
                return "- Debe de ingresar la cédula del agraciado. ";

            if (tobjAgraciado.strDireccion.Trim() == "")
                return "- Debe de ingresar la direccion del agraciado. ";

            if (tobjAgraciado.strEscolaridad.Trim() == "")
                return "- Debe de ingresar la escolaridad del agraciado. ";

            if (tobjAgraciado.strNombreAgra.Trim() == "")
                return "- Debe de ingresar el nombre del agraciado. ";

            if (tobjAgraciado.strParentesco.Trim() == "")
                return "- Debe de ingresar el parentesco del socio con el agraciado. ";

            if (tobjAgraciado.strTelefono.Trim() == "")
                return "- Debe de ingresar el teléfono del agraciado. ";

            if (tobjAgraciado.strTipoCed.Trim() == "")
                return "- Debe de ingresar el tipo de cédula del agraciado. ";

            if (tobjAgraciado.dtmFechaIng == null)
                return "- Debe de ingresar el barrio del Agraciado. ";

            if (tobjAgraciado.dtmFechaIng >= DateTime.Now)
                return "- La fecha de ingreso no puede ser mayor a la actual. ";

            if (tobjAgraciado.dtmFechaNac == null)
                return "- Debe de ingresar el barrio del Agraciado. ";

            if (tobjAgraciado.dtmFechaNac >= DateTime.Now)
                return "- La fecha de nacimiento no puede ser mayor a la actual. ";

            tblAgraciado agr = new daoAgraciado().gmtdConsultar(tobjAgraciado.strCedulaAgra);

            if (agr.strCedulaAgra == null)
                return "- Este registro ya aparece ingresado.";
            else
            {
                tobjAgraciado.log = metodos.gmtdLog("Modifica el Agraciado " + tobjAgraciado.strCedulaAgra, tobjAgraciado.strFormulario);
                return new daoAgraciado().gmtdEditar(tobjAgraciado);
            }
        }

        /// <summary> Modifica los datos del agraciado solicitados por la aseguradora. </summary>
        /// <param name="tobjSocio"> Un objeto del tipo persona a modificar.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdActualizarDato(personasaModificar tobjPersona)
        {

            if (tobjPersona.dtmFechaNacimeinto == null || tobjPersona.dtmFechaNacimeinto == Convert.ToDateTime("1900-01-01"))
                return "- Debe de ingresar la fecha de nacimiento. ";

            if (tobjPersona.intCodigoSoc == 0)
                return "- Debe de ingresar el código del agraciado.";

            if (tobjPersona.strApellido1 == null)
                return "- Debe de ingresar el apellido del agraciado. ";

            if (tobjPersona.strCedula == null)
                return "- Debe de ingresar la cédula del agraciado. ";

            if (tobjPersona.strDireccion == null)
                return "- Debe de ingresar la dirección del agraciado. ";

            if (tobjPersona.strTelefono == null)
                return "- Debe de ingresar el Teléfono del agraciado. ";

            if (tobjPersona.strNombre == null)
                return "- Debe de ingresar el nombre del agraciado. ";

            tobjPersona.log = metodos.gmtdLog("Modifica el agraciado para aseguradora " + tobjPersona.intCodigoSoc, "FrmIngresos");

            return new daoAgraciado().gmtdActualizarDato(tobjPersona);
        }

        /// <summary> Modifica un la cédula de un agraciado. </summary>
        /// <param name="tobjAgraciado"> Número de cédula que desea modificar. </param>
        /// <param name="tobjAgraciado"> Número de cédula a modificar. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditarCeduladeAgraciado(string tstrCedulaaModificar, string tstrCambiarpor)
        {
            string strResultado = "";
            tblAgraciado agraciadoNuevo = new tblAgraciado();
            tblAgraciado agraciadoConsultado = new daoAgraciado().gmtdConsultarDetalle(tstrCedulaaModificar);
            agraciadoNuevo = agraciadoConsultado;
            agraciadoNuevo.dtmFecAnulado = Convert.ToDateTime("1/1/1900");
            if (new daoAgraciado().gmtdEliminarFisicamenteunAgraciado(agraciadoConsultado))
            {
                agraciadoNuevo.strCedulaAgra = tstrCambiarpor;
                agraciadoNuevo.dtmFecAnulado = Convert.ToDateTime("1/1/1900");
                agraciadoNuevo.bitActualizado = false;
                strResultado = new daoAgraciado().gmtdInsertarxModificaciondeCedula(agraciadoConsultado);
            }
            else
                strResultado = "- No se pudo realizar la operación. ";

            return strResultado;
        }

        /// <summary> Consulta los agraciados registrados con un determinado barrio. </summary>
        /// <param name="tstrCodigoBar"> Còdigo del barrio para seleccionar los agraciados. </param>
        /// <returns> Lista de los agraciados consultados. </returns>
        public List<tblAgraciado> gmtdConsultarAgraciadosxBarrio(string tstrCodigoBar)
        {
            return new daoAgraciado().gmtdConsultarAgraciadosxBarrio(tstrCodigoBar);
        }

        /// <summary> Consulta los datos de un determinado agraciado. </summary>
        /// <param name="tintSocio"> El código del socio a consultar </param>
        /// <returns> Los datos de agraciado consultado. </returns>
        public tblAgraciado gmtdConsultarDetalle(string tstrCedulaAgra)
        {
            return new daoAgraciado().gmtdConsultarDetalle(tstrCedulaAgra);   
        }

        /// <summary> Consulta todos los agraciados registrados. </summary>
        /// <returns> Un lista con todos los agraciados seleccionados. </returns>
        public IList<Agraciado> gmtdConsultarTodos()
        {
            return new daoAgraciado().gmtdConsultarTodos();  
        }

        /// <summary> Elimina un agraciado de la base de datos. </summary>
        /// <param name="tobjAgraciado"> Un objeto del tipo tblAgraciado. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblAgraciado tobjAgraciado)
        {
            if (tobjAgraciado.strCedulaAgra.Trim() == "")
            {
                return "- Debe de ingresar la cédula del agraciado. ";
            }

            if (new blCreditos().gmtdConsultarCreditosxPersona(tobjAgraciado.strCedulaAgra).Count > 0)
            {
                return "- No se puede eliminar el agraciado por que aparece como deudor o codeudor de un crédito. ";
            }

            tblAgraciado agr = new daoAgraciado().gmtdConsultar(tobjAgraciado.strCedulaAgra);

            if (agr.strCedulaAgra == null)
            {
                return "- Este registro no aparece ingresado.";
            }
            else
            {
                tobjAgraciado.intCodigoAgr = agr.intCodigoAgr;
                tobjAgraciado.log = metodos.gmtdLog("Elimina el Agraciado " + tobjAgraciado.strCedulaAgra, tobjAgraciado.strFormulario);
                return new daoAgraciado().gmtdEliminar(tobjAgraciado);
            }
        }

        /// <summary>Selecciona los socios registrados cuya informacíón coicida con los campos de la clausula where. </summary>
        /// <param name="tobjSocio"> El objeto socio con los datos para filtrar </param>
        /// <returns> Un lista con los socios seleccionados. </returns>
        public IList<Agraciado> gmtdFiltrar(tblAgraciado tobjAgraciado)
        {
            if (tobjAgraciado.strCedulaAgra == "0")
            {
                tobjAgraciado.strCedulaAgra = "";
            }

            return new daoAgraciado().gmtdFiltrar(tobjAgraciado);  
        }

        /// <summary> Consulta los agraciados registrados a un determinado socio. </summary>
        /// <param name="tintCodigoSocio"> Código del socio a consultar. </param>
        /// <returns> El listado de los agraciados seleccionados. </returns>
        public List<Agraciado> gmtdConsultar(int tintCodigoSocio)
        {
            return new daoAgraciado().gmtdConsultar(tintCodigoSocio);
        }

        /// <summary> Consulta un determinado agraciado. </summary>
        /// <param name="tstrCedAgraciado">la cédula del agraciado a consultar.</param>
        /// <returns> un objeto del tipo tblAgraciado. </returns>
        public tblAgraciado gmtdConsultar(string tstrCedAgraciado)
        {
            return new daoAgraciado().gmtdConsultar(tstrCedAgraciado);
        }

        public tblAgraciado gmtdConsultarAnulado(string tstrCedAgraciado)
        {
            return new daoAgraciado().gmtdConsultarAnulado(tstrCedAgraciado);
        }

        /// <summary> Habilita un agraciado que se encuentre deshabilitado. </summary>
        /// <param name="tstrCedulaAgra"> Cédula del agraciado a habilitar. </param>
        /// <returns> Un mensaje indicando si se ejecuto o no la operación. </returns>
        public string gmtdHabilitarAnulado(string tstrCedulaAgra)
        {
            return new daoAgraciado().gmtdHabilitarAnulado(tstrCedulaAgra);
        }
    }
}
