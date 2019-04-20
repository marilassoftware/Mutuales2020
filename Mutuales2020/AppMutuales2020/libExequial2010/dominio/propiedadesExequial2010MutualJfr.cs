using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace libMutuales2020.dominio
{
    public partial class propiedadesMutualJfr
    {
        public enum DiferenciasFecha
        {
            Dias = 0,
            Meses = 1,
            Años = 3
        }

        public enum FrecuenciaPago
        {
            Semanal = 0,
            Decadal = 1,
            Quincenal = 2,
            Mensual = 3,
        }

        /// <summary> Almacena el nombre de la aplicación. </summary>
        public static string strAplicacion { get; set; }

        /// <summary> Almacena el código del usuario. </summary>
        public static string strCodigoUsuario { get; set; }

        /// <summary> Almacena el nombre del formulario sobre el que se esta trabajando actualemnete. </summary>
        public static string strFormActivo { get; set; }

        /// <summary> Almacena el login del usuario conectado en la aplicación. </summary>
        public static string strLogin { get; set; }

        /// <summary> Almacena el grupo al que pertenece el usuario logueado. </summary>
        public static string strGrupo { get; set; }

        /// <summary> Almacena si se puede o no abrir una determinada pantall. </summary>
        public static string bitEjecutar { get; set; }

        /// <summary> Almacena si se puede o no guardar en una pantalla. </summary>
        public static bool bitGuardar { get; set; }

        /// <summary> Almacena si se puede o no editar en una pantalla. </summary>
        public static bool bitEditar { get; set; }

        /// <summary> Almacena si se puede o no consultar en una pantalla. </summary>
        public static bool bitConsultar { get; set; }

        /// <summary> Almacena si se puede o no eliminar en una pantalla. </summary>
        public static bool bitEliminar;

        /// <summary> Cadena de conexion a la base de datos de datos. </summary>
        public static string strConexionDatos { set; get; }

        /// <summary> Cadena de conexion a la base de datos de seguridad. </summary>
        public static string strConexionSeguridad { set; get; }

        /// <summary> Cadena de conexion a la base de datos de respaldos. </summary>
        public static string strConexionRespaldos { set; get; }

        /// <summary> Almacena el nombre de la mutual. </summary>
        public static string strNombreMutual { set; get; }

        /// <summary> Almacena el nit de la mutual. </summary>
        public static string strNit { set; get; }

        /// <summary> Almacena el nit de la mutual. </summary>
        public static string strPersoneria { set; get; }

        /// <summary> Alamcena el nombre del video a reproducir. </summary>
        public static string strVideo { get; set; }

        /// <summary> Ejecuta un store procedure de Sql. </summary>
        /// <param name="tlstParametros"> Lista de parametros para el sp. </param>
        /// <param name="tstrNombreSp">Nombre del sp. </param>
        /// <returns>Un dataset con los datos consultados. </returns>
        public static DataSet ejecutarSp(List<SqlParameter> tlstParametros, string tstrNombreSp)
        {
            SqlConnection Conecction = new SqlConnection(propiedadesMutualJfr.strConexionDatos);
            SqlCommand comando = new SqlCommand(tstrNombreSp, Conecction);
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandTimeout = 0;
            comando.Parameters.Clear();

            foreach (SqlParameter parametro in tlstParametros)
            {
                comando.Parameters.Add(parametro);
            }

            DataSet DataSet = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(DataSet);
            return DataSet;
        }

        public static decimal diferenciaEntreFechas(DateTime tdtmFechaInicio,
            DateTime tdtmFechaFinal, DiferenciasFecha tDiferencias)
        {

            decimal decValor = 0;
            switch (tDiferencias)
            {
                case DiferenciasFecha.Dias:
                    decValor = Convert.ToDecimal(tdtmFechaFinal.Subtract(tdtmFechaInicio).TotalDays.ToString());
                    break;

            }

            return decValor;
        }
    }
}
