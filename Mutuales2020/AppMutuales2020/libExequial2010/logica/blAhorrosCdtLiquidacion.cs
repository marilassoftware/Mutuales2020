using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libMutuales2020.dao;
using libMutuales2020.dominio;
using System.ComponentModel;


namespace libMutuales2020.logica
{
    [DataObject(true)]
    public class blAhorrosCdtLiquidacion
    {
        /// <summary> Inserta una liquidacion de cdt. </summary>
        /// <param name="tobjAhorroaFuturo"> Un objeto del tipo liquidacion cdt. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblAhorrosCdtsLiquidacion tobjAhorroCdtLiquidacion)
        {
            if (tobjAhorroCdtLiquidacion.intNumeroCdt == 0)
            {
                return "- Debe de ingresar el código del Cdt a Liquidar.";
            }

            if (tobjAhorroCdtLiquidacion.decBrutoLiquidacion == 0)
            {
                return "- Debe de ingresar el valor bruto de la liquidacion del Cdt a Liquidar.";
            }

            tobjAhorroCdtLiquidacion.dtmFechaLiquidacionCdt = new blConfiguracion().gmtdCapturarFechadelServidor();
            tobjAhorroCdtLiquidacion.dtmFechaAnulada = Convert.ToDateTime("1/1/1900");
            tobjAhorroCdtLiquidacion.bitAnuladaCdt = false;

            tobjAhorroCdtLiquidacion.log = metodos.gmtdLog("Ingresa la liquidacion de cdt.  " + tobjAhorroCdtLiquidacion.intNumeroCdt.ToString(), tobjAhorroCdtLiquidacion.strFormulario);

            tblAhorradore ahorrador = new blAhorrador().gmtdConsultar(new blAhorrosCdt().gmtdConsultar(tobjAhorroCdtLiquidacion.intNumeroCdt).strCedulaAho);
            tobjAhorroCdtLiquidacion.strApellidoAho = ahorrador.strApellido1Aho + " " + ahorrador.strApellido2Aho;
            tobjAhorroCdtLiquidacion.strNombreAho = ahorrador.strNombreAho;
            tobjAhorroCdtLiquidacion.strCedulaAho = ahorrador.strCedulaAho;

            return new daoAhorrosCdtLiquidacion().gmtdInsertar(tobjAhorroCdtLiquidacion);
        }

        public tblAhorrosCdtsLiquidacion gmtdCalcularLiquidacion(int tintCdt)
        { 
            blAhorrosCdtCausacion causacion = new blAhorrosCdtCausacion();
            tblAhorrosCdt Cdt = new blAhorrosCdt().gmtdConsultarCdt(tintCdt);
            tblConfiguracione configuracion = new blConfiguracion().gmtdConsultaConfiguracion();
            Int32 intMontoDiarioRetencion = (Int32)configuracion.intMontoDiarioParaRetenciondeCdt;
            decimal decPorcentajeRetencionDiario = (Int32)configuracion.fltPorcentajeparaRetencionenCdt;

            //if (!new blAhorrosCdtCausacion().gmtdConsultarExistenciaCausacionCdt(tintCdt))
            //{
            //    if (!causacion.gmtdInsertarCausacionIndividual(tintCdt))
            //        return new tblAhorrosCdtsLiquidacion();
            //}

            decimal decInteresCdt = new blAhorrosCdtCausacion().gmtdSumarCausacion(tintCdt);

            decimal decValorInteresEstipulado = ((Cdt.decMontoCdt * (Cdt.decInteresesCdt / 100) / 12) * Cdt.intMesesCdt);

            decimal decValorDiarioIntereses = decInteresCdt / (propiedades.diferenciaEntreFechas(Cdt.dtmFechaIniCdt, DateTime.Now, propiedades.DiferenciasFecha.Dias));

            if (DateTime.Now >= Cdt.dtmFechaFinCdt && decInteresCdt < decValorInteresEstipulado)
                decInteresCdt = decValorInteresEstipulado;

            decimal decValorRetencionCdt = 0;
            if (decValorDiarioIntereses >= intMontoDiarioRetencion)
            {
                decValorRetencionCdt = decInteresCdt * (decPorcentajeRetencionDiario / 100);
            }

            decimal decTotalLiquidacionCdt = Cdt.decMontoCdt + decInteresCdt - decValorRetencionCdt;

            tblAhorrosCdtsLiquidacion liquidacion = new tblAhorrosCdtsLiquidacion();
            liquidacion.dtmFechaLiquidacionCdt = DateTime.Now;
            liquidacion.decBrutoLiquidacion = Cdt.decMontoCdt + decInteresCdt;
            liquidacion.decInteresesLiquidacion = decInteresCdt;
            liquidacion.decNetolLiquidacionCdt = decTotalLiquidacionCdt;
            liquidacion.decRetencionLiquidacionCdt = decValorRetencionCdt;
            liquidacion.intNumeroCdt = tintCdt;
            liquidacion.strFormulario = "Liquidacion CDT";

            return liquidacion;
        }

    }
}
