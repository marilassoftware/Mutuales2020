using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace libMutuales2020.Utilidades
{
    public class Utilidad
    {
        /// <summary> Ejecuta los procedimientos almacenados.</summary>
        /// <param name="tlstParametros"> Parametros del sp.</param>
        /// <param name="tstrNombreSp"> Nombre del sp a ejecutar.</param>
        /// <returns> Los resultados obtenidos de la ejecución.</returns>
        public DataTable ejecutarSp(List<SqlParameter> tlstParametros, string tstrNombreSp)
        {
            string Conecion = ConfigurationManager.AppSettings["ConexionVentas"].ToString();

            Conecion = Conecion.Replace("12345", "Sql__12345..");

            SqlConnection Conecction = new SqlConnection(Conecion);
            SqlDataReader dr;
            try
            {
                SqlCommand comando = new SqlCommand(tstrNombreSp, Conecction);
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandTimeout = 0;
                comando.Parameters.Clear();

                foreach (SqlParameter parametro in tlstParametros)
                {
                    comando.Parameters.Add(parametro);
                }

                Conecction.Open();
                dr = comando.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (Conecction.State == ConnectionState.Open)
                {
                    Conecction.Close();
                }
            }
            return null;
        }

        /// <summary> Ejecuta los procedimientos almacenados.</summary>
        /// <param name="tlstParametros"> Parametros del sp.</param>
        /// <param name="tstrNombreSp"> Nombre del sp a ejecutar.</param>
        /// <returns> Los resultados obtenidos de la ejecución.</returns>
        public DataTable ejecutarSpConeccionDB(List<SqlParameter> tlstParametros, string tstrNombreSp)
        {
            string Conecion = ConfigurationManager.ConnectionStrings["conexionDb"].ToString();

            Conecion = Conecion.Replace("12345", "Sql__12345..");

            SqlConnection Conecction = new SqlConnection(Conecion);
            SqlDataReader dr;
            try
            {
                SqlCommand comando = new SqlCommand(tstrNombreSp, Conecction);
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandTimeout = 0;
                comando.Parameters.Clear();

                foreach (SqlParameter parametro in tlstParametros)
                {
                    comando.Parameters.Add(parametro);
                }

                Conecction.Open();
                dr = comando.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (Conecction.State == ConnectionState.Open)
                {
                    Conecction.Close();
                }
            }
            return null;
        }
    }
}
