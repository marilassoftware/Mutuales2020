namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fCreditosLinea
    {
        /// <summary> Inserta una linea de credito. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo tblCreditosLinea. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblCreditosLinea tobjLineasdeCredito)
        {
            return new blCreditosLinea().gmtdInsertar(tobjLineasdeCredito);
        }

        /// <summary> Modifica una linea de credito. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo tblCreditosLinea.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblCreditosLinea tobjLineasdeCredito)
        {
            return new blCreditosLinea().gmtdEditar(tobjLineasdeCredito);
        }

        /// <summary> Consulta todos las lineas de credito registrados. </summary>
        /// <returns> Un lista con todos los tipos de credito seleccionados. </returns>
        public IList<creditosLinea> gmtdConsultarTodos()
        {
            return new blCreditosLinea().gmtdConsultarTodos();
        }

        /// <summary> Consulta todos las lineas de credito registrados. </summary>
        /// <returns> Un lista con todos los tipos de credito seleccionados. </returns>
        public tblCreditosLinea gmtdConsultar(string tstrCodLinea)
        {
            return new blCreditosLinea().gmtdConsultar(tstrCodLinea);
        }

        /// <summary> Consulta el valor de interes de un tipo de crédito. </summary>
        /// <param name="tstrCodLinea"> Codigo de la linea de crédito.</param>
        /// <param name="tstrFecuenciadePago"> Frecuencia en la que se va a pagar el crédito.</param>
        /// <returns> El porcentaje del crédito. </returns>
        public decimal gmtdConsultarValordeInteres(string tstrCodLinea, propiedades.FrecuenciaPago tstrFecuenciadePago)
        {
            return new blCreditosLinea().gmtdConsultarValordeInteres(tstrCodLinea, tstrFecuenciadePago);
        }

        /// <summary> Elimina un tipo de credito de la base de datos. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo tipodecredito. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblCreditosLinea tobjLineadeCredito)
        {
            return new blCreditosLinea().gmtdEliminar(tobjLineadeCredito);
        }
    }
}
