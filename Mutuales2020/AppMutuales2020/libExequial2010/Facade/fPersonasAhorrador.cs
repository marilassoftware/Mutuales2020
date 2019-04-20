namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fAhorrador
    {
        /// <summary> Inserta un ahorrador. </summary>
        /// <param name="tobjSocio"> Un objeto del tipo ahorrador. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblAhorradore tobjAhorrador)
        {
            return new blAhorrador().gmtdInsertar(tobjAhorrador);
        }

        /// <summary> Modifica un ahorrador. </summary>
        /// <param name="tobjSocio"> Un objeto del tipo ahorrador.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblAhorradore tobjAhorrador)
        {
            return new blAhorrador().gmtdEditar(tobjAhorrador);
        }

        /// <summary> Consulta todos los ahorradores registrados. </summary>
        /// <returns> Un lista con todos los ahorradores seleccionados. </returns>
        public IList<Ahorrador> gmtdConsultarTodos()
        {
            return new blAhorrador().gmtdConsultarTodos();
        }

        /// <summary> Consulta si un número de cedula ya aparece registrado. </summary>
        /// <param name="tstrCedulaSocio"> Cédula del ahorrador a consultar. </param>
        /// <returns> Un valor que indica si se encontro o no la cédula del ahorrador. </returns>
        public bool gmtdConsultarCedulaSocio(string tstrCedulaAhorrador)
        {
            return new blAhorrador().gmtdConsultarCedulaSocio(tstrCedulaAhorrador);
        }

        /// <summary>Consulta los datos de un determinado ahorrador. </summary>
        /// <param name="tstrCedulaAho"> El código del socio a consultar </param>
        /// <returns> Los datos de socio consultado. </returns>
        public tblAhorradore gmtdConsultarDetalle(string tstrCedulaAho)
        {
            return new blAhorrador().gmtdConsultarDetalle(tstrCedulaAho);
        }

        /// <summary>Selecciona los ahorradores registrados cuya informacíón coicida con los campos de la clausula where. </summary>
        /// <param name="tobjAhorrador"> El objeto ahorrador con los datos para filtrar </param>
        /// <returns> Un lista con los ahorradores seleccionados. </returns>
        public IList<Ahorrador> gmtdFiltrar(tblAhorradore tobjAhorrador)
        {
            return new blAhorrador().gmtdFiltrar(tobjAhorrador);
        }

        /// <summary> Consulta un determinado ahorrador. </summary>
        /// <param name="tstrCedulaAho">la cédula del ahorrador a consultar.</param>
        /// <returns> un objeto del tipo tblAhorradore. </returns>
        public tblAhorradore gmtdConsultar(string tstrCedulaAho)
        {
            return new blAhorrador().gmtdConsultar(tstrCedulaAho);
        }

        /// <summary> Consulta los ahorradores registrados con un determinado barrio. </summary>
        /// <param name="tstrCodigoBar"> Còdigo del barrio para seleccionar los ahorradores. </param>
        /// <returns> Lista de los ahorradores consultados. </returns>
        public List<tblAhorradore> gmtdConsultarAhorradoresxBarrio(string tstrCodigoBar)
        {
            return new blAhorrador().gmtdConsultarAhorradoresxBarrio(tstrCodigoBar);
        }

        /// <summary> Elimina un ahorrador de la base de datos. </summary>
        /// <param name="tobjSocio"> Un objeto del tipo tblAhorradore. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblAhorradore tobjAhorrador)
        {
            return new blAhorrador().gmtdEliminar(tobjAhorrador);
        }

        /// <summary> Suma el valor de los ahorros de los ahorradores registrados. </summary>
        /// <returns> el valor de los ahorros de los ahorradores registrados</returns>
        public decimal gmtdSumarAhorros()
        {
            return new blAhorrador().gmtdSumarAhorros();
        }

        /// <summary> Registra los intereses de fin de año de los ahorradores. </summary>
        /// <param name="tdecPorcentaje"> Porcentaje de intereses que se le van a dar a los ahorros. </param>
        /// <returns> Un mensaje que indica si se ejecuto o no la operación </returns>
        public string gmtdActualizarIntereses(string tstrPorcentaje)
        {
            return new blAhorrador().gmtdActualizarIntereses(tstrPorcentaje);
        }

        /// <summary> Consulta el total de cada uno de los tipos de ahorro de la mutual. </summary>
        /// <returns> Un objeto que muestra los valores ahorrados de cada tipo de ahorro. </returns>
        public ahorrorosRegistrados gmtdConsultarTotalesdeAhorros()
        {
            return new blAhorrador().gmtdConsultarTotalesdeAhorros();
        }

        /// <summary> Cambia el número de cedula de un ahorrador.</summary>
        /// <param name="tstrCedulaAct"> Número de cédula actual del ahorrador.</param>
        /// <param name="tstrCedulaNue"> Número de cédula nuevo del ahorrador.</param>
        /// <returns> Un valor que indica si se modifico o no la cédula. </returns>
        public string gmtdCambiarCedulaAhorrador(string tstrCedulaAct, string tstrCedulaNue, string tstrCadena)
        {
            return new blAhorrador().gmtdCambiarCedulaAhorrador(tstrCedulaAct, tstrCedulaNue, tstrCadena);
        }
    }
}
