namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fAhorrosCdtCausacion
    {
        /// <summary> Inserta una liquidacion de cdt. </summary>
        /// <param name="tobjAhorroaFuturo"> Un objeto del tipo liquidacion cdt. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(List<tblAhorrosCdtsCausacion> tobjAhorroCdtCausacion)
        {
            return new blAhorrosCdtCausacion().gmtdInsertar(tobjAhorroCdtCausacion);
        }

        /// <summary> Inserta una causación a un cdt si no existe para una determinada fecha. </summary>
        /// <param name="tintCdt"> El cdt a causar.</param>
        /// <returns> Un valor que indica si la causación para el cdt en la fecha actual ya existe. </returns>
        public bool gmtdInsertarCausacionIndividual(int tintCdt)
        {
            return new blAhorrosCdtCausacion().gmtdInsertarCausacionIndividual(tintCdt);
        }

        /// <summary> Consulta si para un determinado año y mes hay causación para un cdt. </summary>
        /// <param name="tintCdt"> Cdt al que se le va a causar la causación. </param>
        /// <returns> un valor que indica si hay causación registrada para un Cdt en una año - mes  determinado. </returns>
        public bool gmtdConsultarExistenciaCausacionCdt(Int32 tintCdt)
        {
            return new blAhorrosCdtCausacion().gmtdConsultarExistenciaCausacionCdt(tintCdt);
        }

        /// <summary> Consulta los datos de una causación. </summary>
        /// <param name="tintCdt"> Cdt al que se le va a causar la causación. </param>
        /// <returns> Un objeto del tipo tblAhorrosCdt. </returns>
        public tblAhorrosCdtsCausacion gmtdCalcularCausacionCdt(Int32 tintCdt)
        {
            return new blAhorrosCdtCausacion().gmtdCalcularCausacionCdt(tintCdt);
        }


        /// <summary> Suma lo que tenga recaudado por causaciones un Cdt. </summary>
        /// <param name="tintCdt"> El cdt al que se le van a sumar las causaciones. </param>
        /// <returns> La suma de las causaciones de un cdt.</returns>
        public int gmtdSumarCausacion(int tintCdt)
        {
            return new blAhorrosCdtCausacion().gmtdSumarCausacion(tintCdt);
        }

        /// <summary> Determina si un cdt se esta liquidando antes o despues de la fecha en la que tenia programado la terminación. </summary>
        /// <param name="tintCdt"> Código del Cdt para determinar Fecha. </param>
        /// <returns> Devuelve true si la fecha en la que esta liquidando es igual o superior a la fecha 
        /// de terminación. o de lo contrario devuelve false. </returns>
        public bool gmtdDeterminarFechaLiquidacion(int tintCdt)
        {
            return new blAhorrosCdtCausacion().gmtdDeterminarFechaLiquidacion(tintCdt);
        }
    }
}
