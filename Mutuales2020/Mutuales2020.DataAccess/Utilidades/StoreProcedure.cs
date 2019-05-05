namespace Mutuales2020.DataAccess.Utilidades
{
    using Newtonsoft.Json;
    using System;
    using System.Data;
    using System.Data.SqlClient;

    public class StoreProcedure
    {
        public String ExcecuteSp(String nameSp, String parameters)
        {
            DataTable dt = new DataTable();

            var re = (String)parameters;

            try
            {
                using (SqlConnection sqlConn = new SqlConnection("Server=SQL5041.site4now.net;Initial Catalog=DB_A40B4C_dbMutualAMFSA;User ID=DB_A40B4C_dbMutualAMFSA_admin;Password=Sql__12345..;MultipleActiveResultSets=true"))
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
    }
}
