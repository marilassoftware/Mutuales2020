namespace libMutuales2020.dao
{
    using System;
    using System.Configuration;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;

    class daoGraficos
    {
        /// <summary> Ejecuta un sp que deshabilita los socio (Recesa) </summary>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public Dictionary<string, int> gmtdConsultaSociosporEdades()
        {
            Dictionary<string, int> dicResultado = new Dictionary<string, int>();
            SqlDataReader dr;
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionDb"].ToString());
            SqlCommand comando = new SqlCommand("Exec spGrafico04SociosAgrupadoporEdades ", conexion);
            try
            {
                conexion.Open();
                dr = comando.ExecuteReader();
                while (dr.Read())
                    dicResultado.Add(dr["strBloque"].ToString(), Convert.ToInt32(dr["intAños"]));

                conexion.Close();
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                    conexion.Close();
            }
            return dicResultado;
        }


    }
}
