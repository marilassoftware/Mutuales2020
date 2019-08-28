namespace Mutuales2020.DataAccess.Utilidades
{
    using Microsoft.Extensions.Hosting;
    using Mutuales.Common.Models;
    using Newtonsoft.Json;
    using System;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using System.IO;


    public class StoreProcedure
    {
        public String ExcecuteSp(String nameSp, String parameters)
        {
            DataTable dt = new DataTable();

            try
            {
                configuration objConfiguracion = this.readJsonFileConfiguration();
                using (SqlConnection sqlConn = new SqlConnection(objConfiguracion.conexion))
                {
                    using (SqlCommand sqlCmd = new SqlCommand(nameSp, sqlConn))
                    {
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@json", parameters);
                        sqlConn.Open();
                        using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd))
                        {
                            sqlAdapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return JsonConvert.SerializeObject(dt);

        }

        /// <summary> Metodo que lee el archivo de configuración.</summary>
        /// <returns> Los datos del archivo leido.</returns>
        private configuration readJsonFileConfiguration()
        {
            configuration objConfiguracion = new configuration();

            using (var reader = new StreamReader("configuration.json"))
            {
                objConfiguracion = JsonConvert.DeserializeObject<configuration>(reader.ReadToEnd());
            }

            return objConfiguracion;
        }
    }
}
