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
    public class blAhorrosCdtCausacion
    {
        /// <summary> Inserta una liquidacion de cdt. </summary>
        /// <param name="tobjAhorroaFuturo"> Un objeto del tipo liquidacion cdt. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(List<tblAhorrosCdtsCausacion> tobjAhorroCdtCausacion)
        {
            if (tobjAhorroCdtCausacion.Count <= 0)
                return "- Debe de haber al menos un cdt para causar.";

            foreach (tblAhorrosCdtsCausacion dato in tobjAhorroCdtCausacion)
            {
                dato.log = metodos.gmtdLog("Ingresa causación para el cdt.  " + dato.intNumeroCdt.ToString(), dato.strFormulario);
                dato.dtmFechaAnulado = Convert.ToDateTime("1/1/1900");
            }

            return new daoAhorrosCdtCausacion().gmtdInsertar(tobjAhorroCdtCausacion);
        }

        /// <summary> Inserta una causación a un cdt si no existe para una determinada fecha. </summary>
        /// <param name="tintCdt"> El cdt a causar.</param>
        /// <returns> Un valor que indica si la causación para el cdt en la fecha actual ya existe. </returns>
        public bool gmtdInsertarCausacionIndividual(int tintCdt)
        {
            if (!this.gmtdConsultarExistenciaCausacionCdt(tintCdt))
            {
                tblAhorrosCdtsCausacion causacion = this.gmtdCalcularCausacionCdt(tintCdt);
                causacion.strFormulario = "liquidar CDT.";
                List<tblAhorrosCdtsCausacion> lstCausaciones = new List<tblAhorrosCdtsCausacion>();
                lstCausaciones.Add(causacion);
                if (this.gmtdInsertar(lstCausaciones).Substring(0, 1) == "-")
                    return false;
                else
                    return true;

            }
            else
                return true;
        }

        /// <summary> Consulta si para un determinado año y mes hay causación para un cdt. </summary>
        /// <param name="tintCdt"> Cdt al que se le va a causar la causación. </param>
        /// <returns> un valor que indica si hay causación registrada para un Cdt en una año - mes  determinado. </returns>
        public bool gmtdConsultarExistenciaCausacionCdt(Int32 tintCdt)
        {
            return new daoAhorrosCdtCausacion().gmtdConsultarExistenciaCausacionCdt(tintCdt);
        }

        /// <summary> Consulta los datos de una causación. </summary>
        /// <param name="tintCdt"> Cdt al que se le va a causar la causación. </param>
        /// <returns> Un objeto del tipo tblAhorrosCdt. </returns>
        public tblAhorrosCdtsCausacion gmtdCalcularCausacionCdt(Int32 tintCdt)
        {
            tblAhorrosCdt cdt = new daoAhorrosCdt().gmtdConsultarCdt(tintCdt);

            tblAhorrosCdtsCausacion causacion = new tblAhorrosCdtsCausacion();

            causacion.dtmFechaCausacion = DateTime.Now;
            causacion.decDiario = cdt.decMontoCdt * ((cdt.decInteresMensualCdt / 30) / 100);
            causacion.decInteresCdt = cdt.decInteresesCdt;
            causacion.intDias = DateTime.Now.Date.Day;
            if (causacion.intDias > 30)
                causacion.intDias = 30;
            causacion.decValorCausacion = causacion.intDias * causacion.decDiario;
            causacion.decMonto = cdt.decMontoCdt;
            causacion.intNumeroCdt = cdt.intNumeroCdt;

            return causacion;

        }


        /// <summary> Suma lo que tenga recaudado por causaciones un Cdt. </summary>
        /// <param name="tintCdt"> El cdt al que se le van a sumar las causaciones. </param>
        /// <returns> La suma de las causaciones de un cdt.</returns>
        public int gmtdSumarCausacion(int tintCdt)
        {
            return new daoAhorrosCdtCausacion().gmtdSumarCausacion(tintCdt);
        }

        /// <summary> Determina si un cdt se esta liquidando antes o despues de la fecha en la que tenia programado la terminación. </summary>
        /// <param name="tintCdt"> Código del Cdt para determinar Fecha. </param>
        /// <returns> Devuelve true si la fecha en la que esta liquidando es igual o superior a la fecha 
        /// de terminación. o de lo contrario devuelve false. </returns>
        public bool gmtdDeterminarFechaLiquidacion(int tintCdt)
        {
            return new daoAhorrosCdtCausacion().gmtdDeterminarFechaLiquidacion(tintCdt);
        }
    }
}
