namespace libMutuales2020.logica
{
    using System;
    using System.Collections.Generic;
    using libMutuales2020.dao;
    using libMutuales2020.dominio;

    public class blAhorrador
    {
        /// <summary> Inserta un ahorrador. </summary>
        /// <param name="tobjSocio"> Un objeto del tipo ahorrador. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblAhorradore tobjAhorrador)
        {
            if (tobjAhorrador.strCedulaAho == "" || tobjAhorrador.strCedulaAho == "0")
            {
                return "- Debe de ingresar la cédula del ahorrador. ";
            }

            if (tobjAhorrador.intCodigoSoc.ToString().Trim() == "" || tobjAhorrador.intCodigoSoc.ToString().Trim() == "0")
            {
                return "- Debe de ingresar el código del socio al que pertenece el ahorrador. ";
            }

            if (tobjAhorrador.strCedulaAho == "")
            {
                return "- Debe de ingresar la cédula del ahorrador. ";
            }

            if (tobjAhorrador.intCodigoSoc.ToString().Trim() == "")
            {
                return "- Debe de ingresar el código del socio al que pertenece el ahorrador. ";
            }

            if (tobjAhorrador.dtmFechaIng == null)
            {
                return "- Debe de ingresar la fecha de ingreso.";
            }

            if (tobjAhorrador.dtmFechaIng >= DateTime.Now)
            {
                return "- La fecha de ingreso no puede ser mayor a la actual. ";
            }

            if (tobjAhorrador.dtmFechaNac == null)
            {
                return "- Debe de ingresar la fecha de nacimiento. ";
            }

            if (tobjAhorrador.dtmFechaNac >= DateTime.Now)
            {
                return "- La fecha de nacimiento no puede ser mayor a la actual. ";
            }

            if (tobjAhorrador.strApellido1Aho == "")
            {
                return "- Debe de ingresar el apellido del ahorrador. ";
            }

            if (tobjAhorrador.strApellidoBen == "")
            {
                return "- Debe de ingresar el apellido del beneficiario. ";
            }

            if (tobjAhorrador.strCedulaAho == "")
            {
                return "- Debe de ingresar la cédula del ahorrador. ";
            }

            if (tobjAhorrador.strCedulaBen == "" || tobjAhorrador.strCedulaBen == "0")
            {
                return "- Debe de ingresar la cédula del beneficiario. ";
            }

            if (tobjAhorrador.strCodBarrio == "")
            {
                return "- Debe de ingresar el barrio. ";
            }

            if (tobjAhorrador.strCodOficio == "")
            {
                return "- Debe de ingresar el oficio. ";
            }

            if (tobjAhorrador.strNombreAho == "")
            {
                return "- Debe de ingresar el nombre del ahorrador. ";
            }

            if (tobjAhorrador.strNombreBen == "")
            {
                return "- Debe de ingresar el nombre del beneficiario. ";
            }

            if (tobjAhorrador.strOrigen == "")
            {
                return "- Debe de ingresar el Origen. ";
            }

            if (tobjAhorrador.strTelefono == "")
            {
                return "- Debe de ingresar el número del télefono. ";
            }

            if (tobjAhorrador.strDireccion == "")
            {
                return "- Debe de ingresar la direccion del ahorrador. ";
            }

            if (tobjAhorrador.strTipoCed == "")
            {
                return "- Debe de ingresar el tipo de cedula del ahorrador. ";
            }

            if (new blSocio().gmtdConsultar(tobjAhorrador.intCodigoSoc).strNombreSoc == null)
            {
                return "- Debe de ingresar un código de socio valido. ";
            }

            tblAhorradore aho = new daoAhorrador().gmtdConsultar(tobjAhorrador.strCedulaAho);

            if (aho.strCedulaAho == null)
            {
                tobjAhorrador.bitAnulado = false;
                tobjAhorrador.dtmFecAnulado = Convert.ToDateTime("01/01/1900");
                tobjAhorrador.log = metodos.gmtdLog("Ingresa el ahorrador " + tobjAhorrador.strCedulaAho, tobjAhorrador.strFormulario);
                return new daoAhorrador().gmtdInsertar(tobjAhorrador);
            }
            else
            {
                return "- Este registro ya aparece ingresado.";
            }
        }

        /// <summary> Modifica un ahorrador. </summary>
        /// <param name="tobjSocio"> Un objeto del tipo ahorrador.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblAhorradore tobjAhorrador)
        {
            if (tobjAhorrador.strCedulaAho == "" || tobjAhorrador.strCedulaAho == "0")
            {
                return "- Debe de ingresar la cédula del ahorrador. ";
            }

            if (tobjAhorrador.intCodigoSoc.ToString().Trim() == "" || tobjAhorrador.intCodigoSoc.ToString().Trim() == "0")
            {
                return "- Debe de ingresar el código del socio al que pertenece el ahorrador. ";
            }

            if (tobjAhorrador.dtmFechaIng == null)
            {
                return "- Debe de ingresar la fecha de ingreso.";
            }

            if (tobjAhorrador.dtmFechaIng >= DateTime.Now)
            {
                return "- La fecha de ingreso no puede ser mayor a la actual. ";
            }

            if (tobjAhorrador.dtmFechaNac == null)
            {
                return "- Debe de ingresar la fecha de nacimiento. ";
            }

            if (tobjAhorrador.dtmFechaNac >= DateTime.Now)
            {
                return "- La fecha de nacimiento no puede ser mayor a la actual. ";
            }

            if (tobjAhorrador.strApellido1Aho == "")
            {
                return "- Debe de ingresar el apellido del ahorrador. ";
            }

            if (tobjAhorrador.strApellidoBen == "")
            {
                return "- Debe de ingresar el apellido del beneficiario. ";
            }

            if (tobjAhorrador.strCedulaAho == "")
            {
                return "- Debe de ingresar la cédula del ahorrador. ";
            }

            if (tobjAhorrador.strCedulaBen == "" || tobjAhorrador.strCedulaBen == "0")
            {
                return "- Debe de ingresar la cédula del beneficiario. ";
            }

            if (tobjAhorrador.strCodBarrio == "")
            {
                return "- Debe de ingresar el barrio. ";
            }

            if (tobjAhorrador.strCodOficio == "")
            {
                return "- Debe de ingresar el oficio. ";
            }

            if (tobjAhorrador.strNombreAho == "")
            {
                return "- Debe de ingresar el nombre del ahorrador. ";
            }

            if (tobjAhorrador.strNombreBen == "")
            {
                return "- Debe de ingresar el nombre del beneficiario. ";
            }

            if (tobjAhorrador.strOrigen == "")
            {
                return "- Debe de ingresar el Origen. ";
            }

            if (tobjAhorrador.strTelefono == "")
            {
                return "- Debe de ingresar el número del télefono. ";
            }

            if (tobjAhorrador.strDireccion == "")
            {
                return "- Debe de ingresar la direccion del ahorrador. ";
            }

            if (tobjAhorrador.strTipoCed == "")
            {
                return "- Debe de ingresar el tipo de cedula del ahorrador. ";
            }

            tblAhorradore aho = new daoAhorrador().gmtdConsultar(tobjAhorrador.strCedulaAho);

            if (aho.strCedulaAho == null)
            {
                return "- Este registro no aparece ingresado.";
            }
            else
            {
                tobjAhorrador.log = metodos.gmtdLog("Modifica el ahorrador " + tobjAhorrador.strCedulaAho, tobjAhorrador.strFormulario);
                return new daoAhorrador().gmtdEditar(tobjAhorrador);
            }
        }

        /// <summary> Consulta todos los ahorradores registrados. </summary>
        /// <returns> Un lista con todos los ahorradores seleccionados. </returns>
        public IList<Ahorrador> gmtdConsultarTodos()
        {
            return new daoAhorrador().gmtdConsultarTodos();
        }

        /// <summary> Consulta si un número de cedula ya aparece registrado. </summary>
        /// <param name="tstrCedulaSocio"> Cédula del ahorrador a consultar. </param>
        /// <returns> Un valor que indica si se encontro o no la cédula del ahorrador. </returns>
        public bool gmtdConsultarCedulaSocio(string tstrCedulaAhorrador)
        {
            return new daoAhorrador().gmtdConsultarCedulaAhorrador(tstrCedulaAhorrador);
        }

        /// <summary>Consulta los datos de un determinado ahorrador. </summary>
        /// <param name="tstrCedulaAho"> El código del socio a consultar </param>
        /// <returns> Los datos de socio consultado. </returns>
        public tblAhorradore gmtdConsultarDetalle(string tstrCedulaAho)
        {
            return new daoAhorrador().gmtdConsultarDetalle(tstrCedulaAho);
        }

        /// <summary>Selecciona los ahorradores registrados cuya informacíón coicida con los campos de la clausula where. </summary>
        /// <param name="tobjAhorrador"> El objeto ahorrador con los datos para filtrar </param>
        /// <returns> Un lista con los ahorradores seleccionados. </returns>
        public IList<Ahorrador> gmtdFiltrar(tblAhorradore tobjAhorrador)
        {
            if (tobjAhorrador.strCedulaAho == "0")
                tobjAhorrador.strCedulaAho = "";

            return new daoAhorrador().gmtdFiltrar(tobjAhorrador);
        }

        /// <summary> Consulta un determinado ahorrador. </summary>
        /// <param name="tstrCedulaAho">la cédula del ahorrador a consultar.</param>
        /// <returns> un objeto del tipo tblAhorradore. </returns>
        public tblAhorradore gmtdConsultar(string tstrCedulaAho)
        {
            return new daoAhorrador().gmtdConsultar(tstrCedulaAho);
        }

        /// <summary> Consulta los ahorradores registrados con un determinado barrio. </summary>
        /// <param name="tstrCodigoBar"> Còdigo del barrio para seleccionar los ahorradores. </param>
        /// <returns> Lista de los ahorradores consultados. </returns>
        public List<tblAhorradore> gmtdConsultarAhorradoresxBarrio(string tstrCodigoBar)
        {
            return new daoAhorrador().gmtdConsultarAhorradoresxBarrio(tstrCodigoBar);
        }

        /// <summary> Elimina un ahorrador de la base de datos. </summary>
        /// <param name="tobjSocio"> Un objeto del tipo tblAhorradore. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblAhorradore tobjAhorrador)
        {
            if (tobjAhorrador.strCedulaAho == "0")
            {
                return "- Debe de ingresar el código del ahorrador a eliminar.";
            }

            tblAhorradore aho = new daoAhorrador().gmtdConsultar(tobjAhorrador.strCedulaAho);

            if (aho.strCedulaAho == null)
            {
                return "- Este registro no aparece ingresado.";
            }
            else
            {
                if (aho.decAhorrado > 0)
                {
                    return "- No puede eliminar un ahorrorrador que tiene ahorros.";
                }
                else
                {
                    if (aho.decAhorrosEstudiantes > 0)
                    {
                        return "- No puede eliminar un ahorrorrador que tiene ahorros estudiantiles.";
                    }
                    else
                    {
                        if (aho.decAhorrosFijo > 0)
                        {
                            return "- No puede eliminar un ahorrorrador que tiene ahorros fijos.";
                        }
                        else
                        {
                            tobjAhorrador.log = metodos.gmtdLog("Elimina el ahorrador " + tobjAhorrador.strCedulaAho, tobjAhorrador.strFormulario);
                            return new daoAhorrador().gmtdEliminar(tobjAhorrador);
                        }
                    }
                }
            }
        }

        /// <summary> Suma el valor de los ahorros de los ahorradores registrados. </summary>
        /// <returns> el valor de los ahorros de los ahorradores registrados</returns>
        public decimal gmtdSumarAhorros()
        {
            return new daoAhorrador().gmtdSumarAhorros();
        }

        /// <summary> Registra los intereses de fin de año de los ahorradores. </summary>
        /// <param name="tdecPorcentaje"> Porcentaje de intereses que se le van a dar a los ahorros. </param>
        /// <returns> Un mensaje que indica si se ejecuto o no la operación </returns>
        public string gmtdActualizarIntereses(string tstrPorcentaje)
        {
            return new daoAhorrador().gmtdActualizarIntereses(tstrPorcentaje);
        }

        /// <summary> Consulta el total de cada uno de los tipos de ahorro de la mutual. </summary>
        /// <returns> Un objeto que muestra los valores ahorrados de cada tipo de ahorro. </returns>
        public ahorrorosRegistrados gmtdConsultarTotalesdeAhorros()
        {
            return new daoAhorrador().gmtdConsultarTotalesdeAhorros();
        }

        /// <summary> Cambia el número de cedula de un ahorrador.</summary>
        /// <param name="tstrCedulaAct"> Número de cédula actual del ahorrador.</param>
        /// <param name="tstrCedulaNue"> Número de cédula nuevo del ahorrador.</param>
        /// <returns> Un valor que indica si se modifico o no la cédula. </returns>
        public string gmtdCambiarCedulaAhorrador(string tstrCedulaAct, string tstrCedulaNue, string tstrCadena)
        {
            return new daoAhorrador().gmtdCambiarCedulaAhorrador(tstrCedulaAct, tstrCedulaNue, tstrCadena);
        }

    }
}