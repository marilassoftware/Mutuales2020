using Mutuales.Common.Models;
using Mutuales2020.Win;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void actualizarEnvio(Int32 intSocioActualidado)
        {
            List<Affiliate> lstAfiliados = new List<Affiliate>();

            try
            {
                List<SqlParameter> lstParametros = new List<SqlParameter>();
                SqlParameter objParameter = new SqlParameter();
                objParameter.DbType = DbType.Int32;
                objParameter.Direction = ParameterDirection.Input;
                objParameter.ParameterName = "intSocioActualidado";
                objParameter.Value = intSocioActualidado;
                lstParametros.Add(objParameter);

                DataTable dt = this.ejecutarSpConeccionDB(lstParametros, Sp.spSociosProcesadosActualizar);

            }
            catch (Exception ex)
            {
                
            }

        }


        public List<Affiliate> consultarEnvio()
        {
            List<Affiliate> lstAfiliados = new List<Affiliate>();

            try
            {
                List<SqlParameter> lstParametros = new List<SqlParameter>();

                DataTable dt = this.ejecutarSpConeccionDB(lstParametros, Sp.spSociosProcesadosConsultar);

                for (int indexTabla = 0; indexTabla < dt.Rows.Count; indexTabla++)
                {
                    Affiliate objAffiliate = new Affiliate();
                    objAffiliate.dtmFechaActualizacion = Convert.ToDateTime(dt.Rows[indexTabla]["dtmFechaProceso"]);
                    objAffiliate.id = Convert.ToInt32(dt.Rows[indexTabla]["intSocioActualidado"]);
                    objAffiliate.intAnoAfi = Convert.ToInt32(dt.Rows[indexTabla]["intAnoAfi"]);
                    objAffiliate.intCodigoSoc = Convert.ToInt32(dt.Rows[indexTabla]["intCodigoAfi"]);
                    objAffiliate.intMesAfi = Convert.ToInt32(dt.Rows[indexTabla]["intMesAfi"]);
                    objAffiliate.strApellido1Afi = dt.Rows[indexTabla]["strApellido1Afi"].ToString();
                    objAffiliate.strApellido2Afi = dt.Rows[indexTabla]["strApellido2Afi"].ToString();
                    objAffiliate.strCedulaAfi = dt.Rows[indexTabla]["strCedulaAfi"].ToString();
                    objAffiliate.strCodigoMut = ConfigurationManager.AppSettings["CodigoMutual"].ToString();
                    objAffiliate.strNombreAfi = dt.Rows[indexTabla]["strNombreAfi"].ToString();
                    objAffiliate.strPlanAfi = dt.Rows[indexTabla]["strPlan"].ToString();

                    lstAfiliados.Add(objAffiliate);
                }
            }
            catch (Exception ex)
            {
                return new List<Affiliate>();
            }

            return lstAfiliados;
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

        private async void Button1_Click(object sender, EventArgs e)
        {
            List<Affiliate> lstAfiliados = this.consultarEnvio();

            String url = ConfigurationManager.AppSettings["urlBase"].ToString();

            ApiService objService = new ApiService();

            var response = await objService.PostAsync(
                url,
                "/api",
                "/Affiliates",
                lstAfiliados);

            if (response.Result.ToString() == "OK")
            {
                for (Int32 indexRegistros = 0; indexRegistros < lstAfiliados.Count; indexRegistros++)
                {
                    this.actualizarEnvio(lstAfiliados[indexRegistros].id);
                }
            }


        }
    }
}
