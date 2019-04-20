using System;
using System.Collections.Generic;
using System.ComponentModel;
using libMutuales2020.dao;
using libMutuales2020.dominio;

namespace libMutuales2020.logica
{
    [DataObject(true)]
    public class blCreditosLinea
    {
        /// <summary> Inserta una linea de credito. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo tblCreditosLinea. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblCreditosLinea tobjLineasdeCredito)
        {
            if (tobjLineasdeCredito.strCodigoTcr == "" || tobjLineasdeCredito.strCodigoTcr == "0")
                return "- Debe de ingresar el código del tipo de credito.";

            if (tobjLineasdeCredito.strNomLineadeCredito == "")
                return "- Debe de ingresar el nombre del tipo de credito.";

            if (tobjLineasdeCredito.strCodLineadeCredito == "")
                return "- Datos incompletos, por favor ingreselos todos.";

            tblCreditosLinea tip = new daoCreditosLinea().gmtdConsultar(tobjLineasdeCredito.strCodLineadeCredito);

            if (tip.strCodLineadeCredito == null)
            {
                tobjLineasdeCredito.log = metodos.gmtdLog("Ingresa la linea de credito " + tobjLineasdeCredito.strCodigoTcr, tobjLineasdeCredito.strFormulario);
                return new daoCreditosLinea().gmtdInsertar(tobjLineasdeCredito);
            }
            else
                return "- Este registro ya aparece ingresado.";
        }

        /// <summary> Modifica una linea de credito. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo tblCreditosLinea.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblCreditosLinea tobjLineasdeCredito)
        {
            if (tobjLineasdeCredito.strCodigoTcr == "" || tobjLineasdeCredito.strCodigoTcr == "0")
                return "- Debe de ingresar el código del tipo de credito.";

            if (tobjLineasdeCredito.strNomLineadeCredito == "")
                return "- Debe de ingresar el nombre de la linea de credito.";

            if (tobjLineasdeCredito.strCodLineadeCredito == "")
                return "- Debe de ingresar el código de la linea de credito.";

            tblCreditosLinea tip = new daoCreditosLinea().gmtdConsultar(tobjLineasdeCredito.strCodigoTcr);

            if (tip.strCodigoTcr == null)
                return "- Este registro no aparece ingresado.";
            else
            {
                tobjLineasdeCredito.log = metodos.gmtdLog("Edito la linea de credito " + tobjLineasdeCredito.strCodigoTcr, tobjLineasdeCredito.strFormulario);
                return new daoCreditosLinea().gmtdEditar(tobjLineasdeCredito);
            }
        }

        /// <summary> Consulta todos las lineas de credito registrados. </summary>
        /// <returns> Un lista con todos los tipos de credito seleccionados. </returns>
        public IList<creditosLinea> gmtdConsultarTodos()
        {
            return new daoCreditosLinea().gmtdConsultarTodos();
        }

        /// <summary> Consulta todos las lineas de credito registrados. </summary>
        /// <returns> Un lista con todos los tipos de credito seleccionados. </returns>
        public tblCreditosLinea gmtdConsultar(string tstrCodLinea)
        {
            return new daoCreditosLinea().gmtdConsultar(tstrCodLinea);
        }

        /// <summary> Consulta el valor de interes de un tipo de crédito. </summary>
        /// <param name="tstrCodLinea"> Codigo de la linea de crédito.</param>
        /// <param name="tstrFecuenciadePago"> Frecuencia en la que se va a pagar el crédito.</param>
        /// <returns> El porcentaje del crédito. </returns>
        public decimal gmtdConsultarValordeInteres(string tstrCodLinea, propiedades.FrecuenciaPago tstrFecuenciadePago)
        {
            return new daoCreditosLinea().gmtdConsultarValordeInteres(tstrCodLinea,  tstrFecuenciadePago);
        }

        /// <summary> Elimina un tipo de credito de la base de datos. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo tipodecredito. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblCreditosLinea tobjLineadeCredito)
        {
            if (tobjLineadeCredito.strCodLineadeCredito == "")
            {
                return "- Debe de ingresar el código de la linea de credito.";
            }

            tblCreditosLinea tip = new daoCreditosLinea().gmtdConsultar(tobjLineadeCredito.strCodigoTcr);

            if (tip.strCodigoTcr == null)
                return "- Este registro no aparece ingresado.";
            else
            {
                tobjLineadeCredito.log = metodos.gmtdLog("Elimino la linea de credito " + tobjLineadeCredito.strCodigoTcr, tobjLineadeCredito.strFormulario);
                return new daoCreditosLinea().gmtdEliminar(tobjLineadeCredito);
            }
        }

    }
}
