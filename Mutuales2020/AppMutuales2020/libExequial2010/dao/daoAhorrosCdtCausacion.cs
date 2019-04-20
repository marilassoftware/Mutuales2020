using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libMutuales2020.dominio;

namespace libMutuales2020.dao
{
    class daoAhorrosCdtCausacion
    {
        /// <summary> Inserta una causacion de cdt. </summary>
        /// <param name="tobjAhorroaFuturo"> Un objeto del tipo tblAhorrosCdtsCausacion. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(List<tblAhorrosCdtsCausacion> tobjAhorroCdtCausacion)
        {
            String strRetornar;
            try
            {
                using (dbExequial2010DataContext ahorros = new dbExequial2010DataContext())
                {
                    foreach (tblAhorrosCdtsCausacion dato in tobjAhorroCdtCausacion)
                    {
                        ahorros.tblAhorrosCdtsCausacions.InsertOnSubmit(dato);
                        ahorros.tblLogdeActividades.InsertOnSubmit(dato.log);
                    }
                    ahorros.SubmitChanges();
                    strRetornar = "Registro Insertado";
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                strRetornar = "- Ocurrió un error al insertar el registro.";
            }
            return strRetornar;
        }

        /// <summary> Consulta los datos de una causación. </summary>
        /// <param name="tintCdt"> Cdt al que se le va a causar la causación. </param>
        /// <returns> Un objeto del tipo tblAhorrosCdt. </returns>
        public tblAhorrosCdt gmtdConsultaCalcularCausacionCdt(Int32 tintCdt)
        {
            using (dbExequial2010DataContext ahorros = new dbExequial2010DataContext())
            {
                var query = from det in ahorros.tblAhorrosCdts
                            where det.bitAnuladoCdt == false && det.bitLiquidadoCdt == false && det.intNumeroCdt == tintCdt
                            select det;

                return query.ToList()[0];
            }
        }

        /// <summary> Consulta si para un determinado año y mes hay causación para un cdt. </summary>
        /// <param name="tintCdt"> Cdt al que se le va a causar la causación. </param>
        /// <returns> un valor que indica si hay causación registrada para un Cdt en una año - mes  determinado. </returns>
        public bool gmtdConsultarExistenciaCausacionCdt(Int32 tintCdt)
        {
            tblAhorrosCdtsCausacion causacion = new tblAhorrosCdtsCausacion();

            using (dbExequial2010DataContext ahorros = new dbExequial2010DataContext())
            {
                var query = from det in ahorros.tblAhorrosCdtsCausacions
                            where det.bitAnulado == false && det.dtmFechaCausacion.Year == DateTime.Now.Year && det.dtmFechaCausacion.Month == DateTime.Now.Month && det.intNumeroCdt == tintCdt
                            select det;

                if (query.ToList().Count > 0)
                    return true;
                else
                {
                    return false;
                }
            }
        }

        /// <summary> Suma lo que tenga recaudado por causaciones un Cdt. </summary>
        /// <param name="tintCdt"> El cdt al que se le van a sumar las causaciones. </param>
        /// <returns> La suma de las causaciones de un cdt.</returns>
        public int gmtdSumarCausacion(int tintCdt)
        {
            using (dbExequial2010DataContext ahorros = new dbExequial2010DataContext())
            {
                var query =  from det in ahorros.tblAhorrosCdtsCausacions
                             where det.bitAnulado == false && det.intNumeroCdt == tintCdt
                             select det;

                if (query.ToList().Count > 0)
                {
                    var consu = (from det in ahorros.tblAhorrosCdtsCausacions
                                 where det.bitAnulado == false && det.intNumeroCdt == tintCdt
                                 select det.decValorCausacion).Sum();

                    return Convert.ToInt32(consu);
                }
                else
                {
                    return 0;
                }


            }
        }

        /// <summary> Determina si un cdt se esta liquidando antes o despues de la fecha en la que tenia programado la terminación. </summary>
        /// <param name="tintCdt"> Código del Cdt para determinar Fecha. </param>
        /// <returns> Devuelve true si la fecha en la que esta liquidando es igual o superior a la fecha 
        /// de terminación. o de lo contrario devuelve false. </returns>
        public bool gmtdDeterminarFechaLiquidacion(int tintCdt)
        { 
            using (dbExequial2010DataContext ahorros = new dbExequial2010DataContext())
            {
                var query = from det in ahorros.tblAhorrosCdts
                            where det.intNumeroCdt == tintCdt && det.bitAnuladoCdt == false && det.bitLiquidadoCdt == false
                            select det;

                if (DateTime.Now >= query.ToList()[0].dtmFechaFinCdt)
                    return true;
                else
                    return false;
            }
        }
    }
}
