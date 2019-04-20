namespace libMutuales2020.dao
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using libMutuales2020.dominio;

    class daoUtilidadesConfiguracion
    {
        /// <summary> Consulta los datos de configuración del sistema. </summary>
        /// <returns> Los datos de configuración consultados. </returns>
        public tblConfiguracione gmtdConsultaConfiguracion()
        {
            using (dbExequial2010DataContext ahorros = new dbExequial2010DataContext())
            {
                var query = from con in ahorros.tblConfiguraciones
                            select con;

                return query.ToList()[0];
            }
        }

        /// <summary> Actualiza los datos de la tabla de configuraciones. </summary>
        /// <param name="tobjConfiguracion"> Objeto con los datos a actualizar. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdActualizarDatosdeConfiguracion(tblConfiguracione tobjConfiguracion)
        {
            try
            {
                using (dbExequial2010DataContext configuracion = new dbExequial2010DataContext())
                {
                    tblConfiguracione con_old = configuracion.tblConfiguraciones.SingleOrDefault(p => p.intCodigo == tobjConfiguracion.intCodigo);
                    con_old.bitCargarTodos = tobjConfiguracion.bitCargarTodos;
                    con_old.bitTasadeUsura = tobjConfiguracion.bitTasadeUsura;
                    con_old.decMoraCreditos = tobjConfiguracion.decMoraCreditos;
                    con_old.fltPorcentajeparaRetencionenCdt = tobjConfiguracion.fltPorcentajeparaRetencionenCdt;
                    con_old.intAnoEvaluado = tobjConfiguracion.intAnoEvaluado;
                    con_old.intAtrasados = tobjConfiguracion.intAtrasados;
                    con_old.intMesEvaluado = tobjConfiguracion.intMesEvaluado;
                    con_old.intMontoDiarioParaRetenciondeCdt = tobjConfiguracion.intMontoDiarioParaRetenciondeCdt;
                    con_old.intValorCuotaAdultoMayor = tobjConfiguracion.intValorCuotaAdultoMayor;
                    con_old.intDiasReceso = tobjConfiguracion.intDiasReceso;
                    con_old.strComentario1 = tobjConfiguracion.strComentario1;
                    con_old.strComentario2 = tobjConfiguracion.strComentario2;
                    con_old.strComentario3 = tobjConfiguracion.strComentario3;
                    con_old.strRutaRespaldo = tobjConfiguracion.strRutaRespaldo;
                    con_old.bitPermiteNumeroRifa = tobjConfiguracion.bitPermiteNumeroRifa;
                    con_old.intTipoCobro = tobjConfiguracion.intTipoCobro;
                    configuracion.SubmitChanges();
                    return "Registro Actualizado.";
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                return "- Ocurrió un error al Actualizar el registro";
            }
        }

        /// <summary> Consulta el valor de la fecha actual. </summary>
        /// <returns> La fecha actual del servidor de base de datos. </returns>
        public DateTime gmtdCapturarFechadelServidor()
        {
            using (dbExequial2010DataContext ahorros = new dbExequial2010DataContext())
            {
                ahorros.ExecuteCommand("upDate tblConfiguraciones Set dtmFechaActual = getDate()");

                var query = from fecha in ahorros.tblConfiguraciones
                            select fecha.dtmFechaActual;

               return (DateTime)query.ToList()[0];
            }
        }

        /// <summary> Realiza el respaldo de la base de datos. </summary>
        /// <param name="tstrCadena"> Cadena de conexion a la base de datos. </param>
        /// <returns> Un mensaje que indica si se pudo o no ejecutar el respaldo. </returns>
        public string gmtdRespaldarBasedeDatos(string tstrCadena)
        {
            string strResultado = "";

            DateTime dtmFecha = gmtdCapturarFechadelServidor();

            string strFecha = dtmFecha.Year.ToString() + "_" + dtmFecha.Month.ToString() + "_" + dtmFecha.Day.ToString() + "_" + dtmFecha.Hour.ToString() + "_" + dtmFecha.Minute.ToString() + "_" + dtmFecha.Second.ToString() + "_" + dtmFecha.Millisecond;

            SqlConnection conexion = new SqlConnection(tstrCadena);
            SqlCommand comando = new SqlCommand("Exec spRespaldos '01', '" + strFecha + "'", conexion);
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                strResultado = "Respaldo Generado. ";
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                strResultado = "- No se pudo generar el respaldo.";
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                    conexion.Close();
            }
            return strResultado;
        }

        /// <summary> Consulta todos los videos registrados. </summary>
        /// <returns> Un lista con todos los videos seleccionados. </returns>
        public List<tblVideosAyuda> gmtdConsultarTodoslosVideos()
        {
            using (dbExequial2010DataContext videos = new dbExequial2010DataContext())
            {
                var query = from vid in videos.tblVideosAyudas
                            select vid;
                List<tblVideosAyuda> lstVideos = new List<tblVideosAyuda>();

                foreach (var dato in query.ToList())
                {
                    tblVideosAyuda vid = new tblVideosAyuda();
                    vid.intCodigoVideo = dato.intCodigoVideo;
                    vid.strNombreVideo = dato.strNombreVideo;
                    vid.strDescripcionVideo = dato.strDescripcionVideo;
                    lstVideos.Add(vid);
                }
                return lstVideos;
            }
        }

        /// <summary> Ejecuta un sp que deshabilita los socio (Recesa) </summary>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdDeshabilitarSocios()
        {
            string strResultado = "";
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionDb"].ToString());
            SqlCommand comando = new SqlCommand("Exec spDeshabilitarSocios ", conexion);
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                strResultado = "Operación Realizada. ";
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                strResultado = "- Ocurrio un error al tratar de deshabilitar los socios.";
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                    conexion.Close();
            }
            return strResultado;
        }

        /// <summary> Insert el número de rifa para un socio o código de préstamo. </summary>
        /// <param name="tobjRifa"> Un objeto con los datos a ingresar de un número de rifa.</param>
        /// <param name="tstrTipo"> Un código que indica si se va a insertar un código de rifa para un socio (02) o para un crédito(04)</param>
        /// <returns> Un mensaje indicando si se ejecuto o no la operación. </returns>
        public string gmtdInsertarNumeroRifa(tblNumerosRifa tobjRifa, string tstrTipo)
        {
            string strResultado = "";
            SqlConnection conexion = new SqlConnection(propiedades.strConexionDatos);
            SqlCommand comando = new SqlCommand("Exec spNumerodeRifa " + tobjRifa.intCodigoSoc.ToString() + " , " + tobjRifa.intMes.ToString() + " , " + tobjRifa.intAno.ToString() + " , '" + tstrTipo + "'", conexion);
            SqlDataReader dr;
            try
            {
                conexion.Open();
                dr = comando.ExecuteReader();
                while (dr.Read())
                    strResultado = dr["strResultado"].ToString();
                conexion.Close();
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                strResultado = "- Ocurrio un error al tratar de deshabilitar los socios.";
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                    conexion.Close();
            }
            return strResultado;
        }

        /// <summary> Consulta los códigos de socio o préstamos disponibles para asignarles número de rifa. </summary>
        /// <param name="tobjRifa"> Un objeto del tipo tblRifa </param>
        /// <param name="tstrTipo"> Un valor que indica si se quieres consultar los socio(03) o los préstamos (05). </param>
        /// <returns></returns>
        public List<string> gmtdConsultarSociosPrestamosparaRifa(tblNumerosRifa tobjRifa, string tstrTipo)
        {
            List<string> lstResultado = new List<string>();
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionDb"].ConnectionString);
            SqlCommand comando = new SqlCommand("Exec spNumerodeRifa " + tobjRifa.intCodigoSoc.ToString() + " , " + tobjRifa.intMes.ToString() + " , " + tobjRifa.intAno.ToString() + " , '" + tstrTipo + "'", conexion);
            SqlDataReader dr;
            try
            {
                conexion.Open();
                dr = comando.ExecuteReader();
                while (dr.Read())
                    lstResultado.Add(dr["intCodigoSoc"].ToString());
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
            return lstResultado;
        }

        /// <summary> Consulta todos los periodos registrados. </summary>
        /// <returns> La lista de periodos seleccionados. </returns>
        public List<tblCuentasPeriodo> gmtdConsultarPeriodos()
        {
            using (dbExequial2010DataContext periodos = new dbExequial2010DataContext())
            {
                var query = from periodo in periodos.tblCuentasPeriodos
                            orderby periodo.intCodigo ascending
                            select periodo;

                return query.ToList();
            }
        }

        /// <summary> Consulta las quincenas registradas en un determinado año.</summary>
        /// <param name="tintAño"> El año del que se quieren seleccionar las quincenas.</param>
        /// <returns> Listado de quincenas consultadas.</returns>
        public List<tblQuincena> gmtdConsultarQuincenas(int tintAño)
        {
            using (dbExequial2010DataContext quincenas = new dbExequial2010DataContext())
            {
                var query = from quincena in quincenas.tblQuincenas
                            where quincena.intAñoQui == tintAño
                            orderby quincena.intCodigoQui ascending
                            select quincena;

                return query.ToList();
            }
        }
    }
}
