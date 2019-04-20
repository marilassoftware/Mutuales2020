using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libMutuales2020.dominio;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace libMutuales2020.dao
{
    public class daoMaestrosCierredeMes
    {
        /// <summary> Consulta si un periodo ya aparece cerrado. </returns>
        /// <param name="tstrPeriodo"> Periodo a consultar. </param>
        /// <returns> Un valor que indica si el periodo existe o no. </returns>
        public bool gmtdConsultarPeriodo(string tstrPeriodo)
        {
            bool bitResultado = false;
            try
            {
                using (dbExequial2010DataContext ahorros = new dbExequial2010DataContext())
                {
                    var query = from consu in ahorros.tblCuentasOperacionesContabilidadGlobales
                                where consu.strPeriodo == tstrPeriodo
                                select consu;

                    if (query.ToList().Count > 0)
                        bitResultado = true;
                    else
                        bitResultado = false;
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                bitResultado = false;
            }
            return bitResultado;
        }

        /// <summary> Genera cierre de mes </summary>
        /// <param name="tstrAño"> Año del que se va hacer el cierre. </param>
        /// <param name="tstrMes"> Mes del que se va hacer el cierre. </param>
        /// <param name="tstrPeriodoAnterior"> Periodo anterior realizado al que se pretende cerra. </param>
        /// <returns> Un mensaje indicando si se ejecuto o no la operación. </returns>
        public string gmtdCierredeMes(string tstrAño, string tstrMes, string tstrPeriodoAnterior)
        {
            string strRespuesta = "";
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionDb"].ConnectionString);
            SqlCommand comando = new SqlCommand("Exec spGenerarCierredeMes '" + tstrAño + "', '" + tstrMes + "', '" + tstrPeriodoAnterior + "'", conexion);
            SqlDataReader dr;
            try
            {
                conexion.Open();
                dr = comando.ExecuteReader();
                conexion.Close();
                strRespuesta = "Operacion ejecutada satisfactoriamente.";
            }
            catch (Exception ex)
            {
                strRespuesta = "- Ocurrio un error al ejecutar la operación.";
                new dao().gmtdInsertarError(ex);
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                    conexion.Close();
            }
            return strRespuesta;
        }

    }
}
