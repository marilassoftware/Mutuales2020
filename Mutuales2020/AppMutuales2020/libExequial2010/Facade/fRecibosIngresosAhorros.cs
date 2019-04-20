namespace libMutuales2020.Facade
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fRecibosIngresosAhorros
    {
        /// <summary> Consulta las transacciones de un determinado ahorrador. </summary>
        /// <param name="tstrCedulaAho"> Cédula del ahorrador al que se le va a consultar las transacciones. </param>
        /// <returns> Lista de transacciones seleccionadas. </returns>
        public List<tblAhorrosTransaccione> gmtdConsultarTransacciones(string tstrCedulaAho)
        {
            return new blRecibosIngresosAhorros().gmtdConsultarTransacciones(tstrCedulaAho);
        }

        /// <summary> Consulta las transacciones estudiantiles de un determinado ahorrador. </summary>
        /// <param name="tstrCedulaAho"> Cédula del ahorrador al que se le va a consultar las transacciones. </param>
        /// <returns> Lista de transacciones seleccionadas. </returns>
        public List<tblAhorrosTransaccionesEstudiantil> gmtdConsultarTransaccionesEstudiantiles(string tstrCedulaAho)
        {
            return new blRecibosIngresosAhorros().gmtdConsultarTransaccionesEstudiantiles(tstrCedulaAho);
        }

        /// <summary> Consulta las transacciones fijas de un determinado ahorrador. </summary>
        /// <param name="tstrCedulaAho"> Cédula del ahorrador al que se le va a consultar las transacciones fijas. </param>
        /// <returns> Lista de transacciones seleccionadas. </returns>
        public List<tblAhorrosTransaccionesFijo> gmtdConsultarTransaccionesFijas(string tstrCedulaAho)
        {
            return new blRecibosIngresosAhorros().gmtdConsultarTransaccionesFijas(tstrCedulaAho);
        }

    }
}
