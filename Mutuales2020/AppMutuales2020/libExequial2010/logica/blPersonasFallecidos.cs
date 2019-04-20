namespace libMutuales2020.logica
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dao;
    using libMutuales2020.dominio;

    [DataObject(true)]
    public class blFallecidos
    {
        /// <summary> Inserta un fallecido. </summary>
        /// <param name="tobjFallecido"> Un objeto del tipo agraciado. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblFallecido tobjFallecido)
        {
            if (tobjFallecido.intAños == 0)
            {
                return "- Debe de ingresar la edad del fallecido. ";
            }

            if (tobjFallecido.intPagado == 0)
            {
                return "- Debe de ingresar el valor pagado por el servicio. ";
            }

            if (tobjFallecido.strApellido1Fal.Trim() == "")
            {
                return "- Debe de ingresar el apellido del fallecido. ";
            }

            if (tobjFallecido.strCedulaFal.Trim() == "")
            {
                return "- Debe de ingresar la cedula del fallecido. ";
            }

            if (tobjFallecido.strComentario.Trim() == "")
            {
                return "- Debe de ingresar el comentario del fallecido. ";
            }

            if (tobjFallecido.strFolio.Trim() == "")
            {
                return "- Debe de ingresar el número del folio del fallecido. ";
            }

            if (tobjFallecido.strNombreFal.Trim() == "")
            {
                return "- Debe de ingresar el nombre del fallecido del fallecido. ";
            }

            if (tobjFallecido.strNotaria.Trim() == "")
            {
                return "- Debe de ingresar la notaria del fallecido. ";
            }

            if (tobjFallecido.strProcedencia.Trim() == "")
            {
                return "- Debe de ingresar la Procedencia del fallecido. ";
            }

            if (tobjFallecido.strTipoCed.Trim() == "")
            {
                return "- Debe de ingresar el tipo de cédula del fallecido. ";
            }

            if (tobjFallecido.strProcedencia.Trim() == "Socio")
            {

                tobjFallecido.agraciado = new blAgraciado().gmtdConsultarDetalle(tobjFallecido.strAgraciado);

                if (tobjFallecido.strAgraciado == "")
                {
                    if (this.gmtdConsultar(tobjFallecido.intCodigoSoc).Count > 0)
                    {
                        return "- Debe de seleccionar el agraciado que quedará como socio.";
                    }
                    else
                    {
                        tobjFallecido.agraciado = new tblAgraciado();
                    }
                }
            }

            tblFallecido fal = new daoFallecido().gmtdConsultar(tobjFallecido.strCedulaFal);

            if (fal.strCedulaFal == null)
            {
                tobjFallecido.log = metodos.gmtdLog("Ingresa el Fallecido " + tobjFallecido.strCedulaFal, tobjFallecido.strFormulario);
                tobjFallecido.bitAnulado = false;
                tobjFallecido.dtmFechaAnu = Convert.ToDateTime("1900/01/01");
                return new daoFallecido().gmtdInsertar(tobjFallecido);
            }
            else
            {
                return "- Este Fallecido ya aparece ingresado.";
            }
        }

        /// <summary> Modifica un Fallecido. </summary>
        /// <param name="tobjFallecido"> Un objeto del tipo Fallecido.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblFallecido tobjFallecido)
        {
            if (tobjFallecido.strApellido1Fal.Trim() == "")
            {
                return "- Debe de ingresar el apellido del fallecido. ";
            }

            if (tobjFallecido.intAños == 0)
            {
                return "- Debe de ingresar la edad del fallecido. ";
            }

            if (tobjFallecido.intPagado == 0)
            {
                return "- Debe de ingresar el valor pagado por el servicio. ";
            }

            if (tobjFallecido.strCedulaFal.Trim() == "")
            {
                return "- Debe de ingresar la cedula del fallecido. ";
            }

            if (tobjFallecido.strComentario.Trim() == "")
            {
                return "- Debe de ingresar el comentario del fallecido. ";
            }

            if (tobjFallecido.strFolio.Trim() == "")
            {
                return "- Debe de ingresar el número del folio del fallecido. ";
            }

            if (tobjFallecido.strNombreFal.Trim() == "")
            {
                return "- Debe de ingresar el nombre del fallecido del fallecido. ";
            }

            if (tobjFallecido.strNotaria.Trim() == "")
            {
                return "- Debe de ingresar la notaria del fallecido. ";
            }

            if (tobjFallecido.strProcedencia.Trim() == "")
            {
                return "- Debe de ingresar la Procedencia del fallecido. ";
            }

            if (tobjFallecido.strTipoCed.Trim() == "")
            {
                return "- Debe de ingresar el tipo de cédula del fallecido. ";
            }

            tblFallecido fal = new daoFallecido().gmtdConsultar(tobjFallecido.strCedulaFal);

            if (fal.strCedulaFal == null)
            {
                return "- Este Fallecido no aparece ingresado.";
            }
            else
            {
                tobjFallecido.log = metodos.gmtdLog("Edito el Fallecido " + tobjFallecido.strCedulaFal, tobjFallecido.strFormulario);
                return new daoFallecido().gmtdEditar(tobjFallecido);
            }
        }

        /// <summary> Consulta todos los fallecidos registrados. </summary>
        /// <returns> Un lista con todos los fallecidos seleccionados. </returns>
        public List<Fallecido> gmtdConsultarTodos()
        {
            return new daoFallecido().gmtdConsultarTodos();
        }

        /// <summary> Consulta todos los fallecidos registrados. </summary>
        /// <returns> Un lista con todos los fallecidos seleccionados. </returns>
        public IList<tblFallecido> gmtdConsultarTodosTbl()
        {
            return new daoFallecido().gmtdConsultarTodosTbl();
        }

        /// <summary>Selecciona los socios registrados cuya informacíón coicida con los
        /// campos de la clausula where. </summary>
        /// <param name="tobjSocio"> El objeto socio con los datos para filtrar </param>
        /// <returns> Un lista con los socios seleccionados. </returns>
        public IList<Fallecido> gmtdFiltrar(tblFallecido tobjFallecido)
        {
            if (tobjFallecido.strCedulaFal == "0")
            {
                tobjFallecido.strCedulaFal = "";
            }

            return new daoFallecido().gmtdFiltrar(tobjFallecido);
        }

        /// <summary> Consulta los fallecidos registrados en un rango de fecha </summary>
        /// <param name="tdtmFechaIni"> Fecha inicial.</param>
        /// <param name="tdtmFechaFin"> Fecha Final. </param>
        /// <returns> El listado de los fallecidos seleccionados. </returns>
        public List<tblFallecido> gmtdConsultarFallecidosentreFechas(DateTime tdtmFechaIni, DateTime tdtmFechaFin)
        {
            tdtmFechaIni = Convert.ToDateTime(tdtmFechaIni.Year.ToString() + "-" + tdtmFechaIni.Month.ToString() + "-" + tdtmFechaIni.Day.ToString() + " " + "00:00:00");
            tdtmFechaFin = Convert.ToDateTime(tdtmFechaFin.Year.ToString() + "-" + tdtmFechaFin.Month.ToString() + "-" + tdtmFechaFin.Day.ToString() + " " + "23:59:59");
            return new daoFallecido().gmtdConsultarFallecidosentreFechas(tdtmFechaIni, tdtmFechaFin);
        }

        /// <summary> Elimina un fallecido de la base de datos. </summary>
        /// <param name="tobjFallecido"> Un objeto del tipo tblAgraciado. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblFallecido tobjFallecido)
        {
            if (tobjFallecido.strCedulaFal.Trim() == "")
            {
                return "- Debe de ingresar la cedula del fallecido a eliminar . ";
            }

            tblFallecido agr = new daoFallecido().gmtdConsultar(tobjFallecido.strCedulaFal);

            if (agr.strCedulaFal == null)
            {
                return "- Este registro no aparece ingresado.";
            }
            else
            {
                tobjFallecido.intCodigoFal = agr.intCodigoFal;
                tobjFallecido.log = metodos.gmtdLog("Elimina el Fallecido " + tobjFallecido.strCedulaFal, tobjFallecido.strFormulario);
                return new daoFallecido().gmtdEliminar(tobjFallecido);
            }
        }

        /// <summary> Consulta si una cedula esta registrada como socio, agraciado o si es particular. </summary>
        /// <param name="tstrCedulaFal"> El número de cédula a evaluar. </param>
        /// <returns> Un string con la procedencia de la cédula. </returns>
        public string gmtdBuscarCedula(string tstrCedulaFal)
        {
            return new daoFallecido().gmtdBuscarCedula(tstrCedulaFal);
        }

        /// <summary> Consulta el código de un socio a partir del número de la cédula. </summary>
        /// <param name="tstrCedulaSocio"> Cédula del socio a consultar. </param>
        /// <returns> El código del socio o -1 si no aparece registrada la cédula. </returns>
        public Int32 gmtdConsultarCodigoSocio(string tstrCedulaSocio)
        {
            return new daoFallecido().gmtdConsultarCodigoSocio(tstrCedulaSocio);
        }

        /// <summary> Consulta los agraciados registrados a un determinado socio. </summary>
        /// <param name="tintCodigoSocio"> Código del socio a consultar. </param>
        /// <returns> El listado de los agraciados seleccionados. </returns>
        public List<Agraciado> gmtdConsultar(int tintCodigoSocio)
        {
            return new daoAgraciado().gmtdConsultar(tintCodigoSocio);
        }
    }
}
