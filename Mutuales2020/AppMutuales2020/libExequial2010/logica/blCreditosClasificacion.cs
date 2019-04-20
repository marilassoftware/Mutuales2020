using System;
using System.Collections.Generic;
using System.ComponentModel;
using libMutuales2020.dao;
using libMutuales2020.dominio;

namespace libMutuales2020.logica
{
    [DataObject(true)]
    public class blCreditosClasificacion
    {
        /// <summary> Inserta un tipo de clasificacion. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo clasificación. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblCreditosClasificacion tobjClasificaciondeCredito)
        {
            if (tobjClasificaciondeCredito.strCodigoTcr == "" || tobjClasificaciondeCredito.strCodigoTcr == null)
                return "- Debe de ingresar el código del tipo de credito.";

            if (tobjClasificaciondeCredito.decValorProvisionCla == 0)
                return "- Debe de ingresar el valor de provisión de cartera.";

            if (tobjClasificaciondeCredito.intDesdeCla == 0)
                return "- Debe de ingresar el día desde donde empieza esta clasificación.";

            if (tobjClasificaciondeCredito.intHastaCla == 0)
                return "- Debe de ingresar el día donde termina esta clasificación.";

            if (tobjClasificaciondeCredito.strCodigoCla == "" || tobjClasificaciondeCredito.strCodigoCla == null)
                return "- Debe de ingresar el código de la clasificación.";

            if (tobjClasificaciondeCredito.strNombreCla == "" || tobjClasificaciondeCredito.strNombreCla == null)
                return "- Debe de ingresar el nombre de la clasificación.";

            tblCreditosClasificacion tip = new daoCreditosClasificacion().gmtdConsultar(tobjClasificaciondeCredito.strCodigoCla);

            if (tip.strCodigoCla == null)
            {
                tobjClasificaciondeCredito.log = metodos.gmtdLog("Ingresa la clasificación de credito " + tobjClasificaciondeCredito.strCodigoCla, tobjClasificaciondeCredito.strFormulario);
                return new daoCreditosClasificacion().gmtdInsertar(tobjClasificaciondeCredito);
            }
            else
                return "- Este registro ya aparece ingresado.";
        }

        /// <summary> Modifica una clasificación de credito. </summary>
        /// <param name="tobjTiposdeCredito"> Un objeto del tipo tblCreditosClasificacion.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblCreditosClasificacion tobjClasificaciondeCredito)
        {
            if (tobjClasificaciondeCredito.strCodigoTcr == "" || tobjClasificaciondeCredito.strCodigoTcr == null)
                return "- Debe de ingresar el código del tipo de credito.";

            if (tobjClasificaciondeCredito.decValorProvisionCla == 0)
                return "- Debe de ingresar el valor de provisión de cartera.";

            if (tobjClasificaciondeCredito.intDesdeCla == 0)
                return "- Debe de ingresar el día desde donde empieza esta clasificación.";

            if (tobjClasificaciondeCredito.intHastaCla == 0)
                return "- Debe de ingresar el día donde termina esta clasificación.";

            if (tobjClasificaciondeCredito.strCodigoCla == "" || tobjClasificaciondeCredito.strCodigoCla == null)
                return "- Debe de ingresar el código de la clasificación.";

            if (tobjClasificaciondeCredito.strNombreCla == "" || tobjClasificaciondeCredito.strNombreCla == null)
                return "- Debe de ingresar el nombre de la clasificación.";

            tblCreditosClasificacion tip = new daoCreditosClasificacion().gmtdConsultar(tobjClasificaciondeCredito.strCodigoCla);

            if (tip.strCodigoCla == null)
                return "- Este registro no aparece ingresado.";
            else
            {
                tobjClasificaciondeCredito.log = metodos.gmtdLog("Edito la clasificación de credito " + tobjClasificaciondeCredito.strCodigoTcr, tobjClasificaciondeCredito.strFormulario);
                return new daoCreditosClasificacion().gmtdEditar(tobjClasificaciondeCredito);
            }
        }

        /// <summary> Consulta todas las clasificaciones de creditos. </summary>
        /// <returns> Un lista con todas las clasificaciones de crédito. </returns>
        public IList<creditosClasificacion> gmtdConsultarTodos()
        {
            return new daoCreditosClasificacion().gmtdConsultarTodos();
        }

        /// <summary> Consulta una determinada clasificacion de credito. </summary>
        /// <param name="tobjClasificaciondeCredito">el código de la clasificación de crédito.</param>
        /// <returns> un objeto del tipo tblCreditosClasificacion. </returns>
        public tblCreditosClasificacion gmtdConsultar(string tobjClasificaciondeCredito)
        {
            return new daoCreditosClasificacion().gmtdConsultar(tobjClasificaciondeCredito);
        }

        /// <summary> Elimina una clasificación de credito. </summary>
        /// <param name="tobjClasificaciondeCredito"> Un objeto del tipo tblCreditosClasificacion. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblCreditosClasificacion tobjClasificaciondeCredito)
        {
            if (tobjClasificaciondeCredito.strCodigoCla == "" || tobjClasificaciondeCredito.strCodigoCla == null)
                return "- Debe de ingresar el código de la clasificación de credito.";

            tblCreditosClasificacion tip = new daoCreditosClasificacion().gmtdConsultar(tobjClasificaciondeCredito.strCodigoCla);

            if (tip.strCodigoCla == null)
                return "- Este registro no aparece ingresado.";
            else
            {
                tobjClasificaciondeCredito.log = metodos.gmtdLog("Elimino la clasificación de credito " + tobjClasificaciondeCredito.strCodigoCla, tobjClasificaciondeCredito.strFormulario);
                return new daoCreditosClasificacion().gmtdEliminar(tobjClasificaciondeCredito);
            }
        }

    }
}
