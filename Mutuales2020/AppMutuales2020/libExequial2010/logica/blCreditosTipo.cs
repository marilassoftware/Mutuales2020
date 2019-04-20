using System;
using System.Collections.Generic;
using System.ComponentModel;
using libMutuales2020.dao;
using libMutuales2020.dominio;

namespace libMutuales2020.logica
{
    [DataObject(true)]
    public class blCreditosTipo
    {
        /// <summary> Inserta un tipo de credito. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo tipodecredito. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblCreditosTipo tobjTiposdeCredito)
        {
            if (tobjTiposdeCredito.strCodigoTcr == "")
                return "- Debe de ingresar el código del tipo de credito.";

            if (tobjTiposdeCredito.strDescripcionTcr == "")
                return "- Debe de ingresar el nombre del tipo de credito.";

            if (tobjTiposdeCredito.decTasaEfectivaAnualBasicaTcr == 0)
                return "- Datos incompletos, por favor ingreselos todos.";

            if (tobjTiposdeCredito.decTasaEfectivaAnualUsuraTcr == 0)
                return "- Datos incompletos, por favor ingreselos todos.";

            if (tobjTiposdeCredito.decTasaNominalAnualBasicaDecadalTcr == 0)
                return "- Datos incompletos, por favor ingreselos todos.";

            if (tobjTiposdeCredito.decTasaNominalAnualBasicaMensualTcr == 0)
                return "- Datos incompletos, por favor ingreselos todos.";

            if (tobjTiposdeCredito.decTasaNominalAnualBasicaQuincenalTcr == 0)
                return "- Datos incompletos, por favor ingreselos todos.";

            if (tobjTiposdeCredito.decTasaNominalAnualBasicaSemanalTcr == 0)
                return "- Datos incompletos, por favor ingreselos todos.";

            if (tobjTiposdeCredito.decTasaNominalAnualBasicaTcr == 0)
                return "- Datos incompletos, por favor ingreselos todos.";

            if (tobjTiposdeCredito.decTasaNominalAnualUsuraDecadalTcr == 0)
                return "- Datos incompletos, por favor ingreselos todos.";

            if (tobjTiposdeCredito.decTasaNominalAnualUsuraMensualTcr == 0)
                return "- Datos incompletos, por favor ingreselos todos.";

            if (tobjTiposdeCredito.decTasaNominalAnualUsuraQuincenalTcr == 0)
                return "- Datos incompletos, por favor ingreselos todos.";

            if (tobjTiposdeCredito.decTasaNominalAnualUsuraSemanalTcr == 0)
                return "- Datos incompletos, por favor ingreselos todos.";

            if (tobjTiposdeCredito.decTasaNominalAnualUsuraTcr == 0)
                return "- Datos incompletos, por favor ingreselos todos.";

            tblCreditosTipo tip = new daoCreditosTipo().gmtdConsultar(tobjTiposdeCredito.strCodigoTcr);

            if (tip.strCodigoTcr == null)
            {
                tobjTiposdeCredito.log = metodos.gmtdLog("Ingresa el tipo de credito " + tobjTiposdeCredito.strCodigoTcr, tobjTiposdeCredito.strFormulario);
                return new daoCreditosTipo().gmtdInsertar(tobjTiposdeCredito);
            }
            else
                return "- Este registro ya aparece ingresado.";
        }

        /// <summary> Modifica un tipo de credito. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo tipodecredito.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblCreditosTipo tobjTiposdeCredito)
        {
            if (tobjTiposdeCredito.strCodigoTcr == "")
                return "- Debe de ingresar el código del tipo de credito.";

            if (tobjTiposdeCredito.strDescripcionTcr == "")
                return "- Debe de ingresar el nombre del tipo de credito.";

            if (tobjTiposdeCredito.decTasaEfectivaAnualBasicaTcr == 0)
                return "- Datos incompletos, por favor ingreselos todos.";

            if (tobjTiposdeCredito.decTasaEfectivaAnualUsuraTcr == 0)
                return "- Datos incompletos, por favor ingreselos todos.";

            if (tobjTiposdeCredito.decTasaNominalAnualBasicaDecadalTcr == 0)
                return "- Datos incompletos, por favor ingreselos todos.";

            if (tobjTiposdeCredito.decTasaNominalAnualBasicaMensualTcr == 0)
                return "- Datos incompletos, por favor ingreselos todos.";

            if (tobjTiposdeCredito.decTasaNominalAnualBasicaQuincenalTcr == 0)
                return "- Datos incompletos, por favor ingreselos todos.";

            if (tobjTiposdeCredito.decTasaNominalAnualBasicaSemanalTcr == 0)
                return "- Datos incompletos, por favor ingreselos todos.";

            if (tobjTiposdeCredito.decTasaNominalAnualBasicaTcr == 0)
                return "- Datos incompletos, por favor ingreselos todos.";

            if (tobjTiposdeCredito.decTasaNominalAnualUsuraDecadalTcr == 0)
                return "- Datos incompletos, por favor ingreselos todos.";

            if (tobjTiposdeCredito.decTasaNominalAnualUsuraMensualTcr == 0)
                return "- Datos incompletos, por favor ingreselos todos.";

            if (tobjTiposdeCredito.decTasaNominalAnualUsuraQuincenalTcr == 0)
                return "- Datos incompletos, por favor ingreselos todos.";

            if (tobjTiposdeCredito.decTasaNominalAnualUsuraSemanalTcr == 0)
                return "- Datos incompletos, por favor ingreselos todos.";

            if (tobjTiposdeCredito.decTasaNominalAnualUsuraTcr == 0)
                return "- Datos incompletos, por favor ingreselos todos.";

            tblCreditosTipo tip = new daoCreditosTipo().gmtdConsultar(tobjTiposdeCredito.strCodigoTcr);

            if (tip.strCodigoTcr == null)
                return "- Este registro no aparece ingresado.";
            else
            {
                tobjTiposdeCredito.log = metodos.gmtdLog("Edito el tipo de credito " + tobjTiposdeCredito.strCodigoTcr, tobjTiposdeCredito.strFormulario);
                return new daoCreditosTipo().gmtdEditar(tobjTiposdeCredito);
            }
        }

        /// <summary> Consulta todos los tipos de credito registrados. </summary>
        /// <param name="tAplicacion"> Un objeto del tipo tipo de credito. </param>
        /// <returns> Un lista con todos los tipos de credito seleccionados. </returns>
        public IList<creditosTipo> gmtdConsultarTodos()
        {
            return new daoCreditosTipo().gmtdConsultarTodos();
        }

        /// <summary> Elimina un tipo de credito de la base de datos. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo tipodecredito. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblCreditosTipo tobjTiposdeCredito)
        {
            if (tobjTiposdeCredito.strCodigoTcr == "")
                return "- Debe de ingresar el código del tipo de credito.";

            List<creditosLinea> linea = (List<creditosLinea>)new daoCreditosLinea().gmtdConsultarLineasxTipodeCredito(tobjTiposdeCredito.strCodigoTcr);

            if (linea.Count > 0)
                return "- No se puede eliminar el tipo por que tiene lineas registradas.";


            tblCreditosTipo tip = new daoCreditosTipo().gmtdConsultar(tobjTiposdeCredito.strCodigoTcr);

            if (tip.strCodigoTcr == null)
                return "- Este registro no aparece ingresado.";
            else
            {
                tobjTiposdeCredito.log = metodos.gmtdLog("Elimino el tipo de credito " + tobjTiposdeCredito.strCodigoTcr, tobjTiposdeCredito.strFormulario);
                return new daoCreditosTipo().gmtdEliminar(tobjTiposdeCredito);
            }
        }

    }
}
