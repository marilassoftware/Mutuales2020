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
    class daoAhorrador
    {
        /// <summary> Inserta un Ahorrador. </summary>
        /// <param name="tobjAhorrador"> Un objeto del tipo tblAhorrador. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblAhorradore tobjAhorrador)
        {
            String strRetornar;
            try
            {
                using (dbExequial2010DataContext ahorrador = new dbExequial2010DataContext())
                {
                    ahorrador.tblAhorradores.InsertOnSubmit(tobjAhorrador);
                    ahorrador.tblLogdeActividades.InsertOnSubmit(tobjAhorrador.log);
                    ahorrador.SubmitChanges();
                    strRetornar = "Registro Insertado";
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                strRetornar = "- No se puede insertar el registro.";
            }
            return strRetornar;
        }

        /// <summary> Modifica un Ahorrador. </summary>
        /// <param name="tobjSocio"> Un objeto del tipo Ahorrador.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblAhorradore tobjAhorrador)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext ahorrador = new dbExequial2010DataContext())
                {
                    tblAhorradore aho_old = ahorrador.tblAhorradores.SingleOrDefault(p => p.strCedulaAho == tobjAhorrador.strCedulaAho);
                    aho_old.bitAhorroEstudiantil = tobjAhorrador.bitAhorroEstudiantil;
                    aho_old.bitSexo = tobjAhorrador.bitSexo;
                    aho_old.bitCobraCuatroxMil = tobjAhorrador.bitCobraCuatroxMil;
                    aho_old.dtmFechaIng = tobjAhorrador.dtmFechaIng;
                    aho_old.dtmFechaNac = tobjAhorrador.dtmFechaNac;
                    aho_old.strCedulaAho = tobjAhorrador.strCedulaAho;
                    aho_old.strNombreAho = tobjAhorrador.strNombreAho;
                    aho_old.strApellido1Aho = tobjAhorrador.strApellido1Aho;
                    aho_old.strApellido2Aho = tobjAhorrador.strApellido2Aho;
                    aho_old.strCodBarrio = tobjAhorrador.strCodBarrio;
                    aho_old.strCodOficio = tobjAhorrador.strCodOficio;
                    aho_old.strCorreo = tobjAhorrador.strCorreo;
                    aho_old.strDireccion = tobjAhorrador.strDireccion;
                    aho_old.strEscolaridad = tobjAhorrador.strEscolaridad;
                    aho_old.strTelefono = tobjAhorrador.strTelefono;
                    aho_old.strTipoCed = tobjAhorrador.strTipoCed;
                    aho_old.strOrigen = tobjAhorrador.strOrigen;
                    aho_old.strCedulaBen = tobjAhorrador.strCedulaBen;
                    aho_old.strNombreBen = tobjAhorrador.strNombreBen;
                    aho_old.strApellidoBen = tobjAhorrador.strApellidoBen;
                    aho_old.strCedulaAut = tobjAhorrador.strCedulaAut;
                    aho_old.strNombreAut = tobjAhorrador.strNombreAut;
                    aho_old.strApellidoAut = tobjAhorrador.strApellidoAut;
                    aho_old.dtmFechaExpedicion = tobjAhorrador.dtmFechaExpedicion;
                    aho_old.strLugarExpedicion = tobjAhorrador.strLugarExpedicion;
                    ahorrador.tblLogdeActividades.InsertOnSubmit(tobjAhorrador.log);
                    ahorrador.SubmitChanges();
                    strResultado = "Registro Actualizado";
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                strResultado = "- Ocurrió un error al Actualizar el registro";
            }
            return strResultado;
        }

        /// <summary> Consulta los datos de un determinado ahorrador. </summary>
        /// <param name="tstrCedulaAho"> La cédula del ahorrador a consultar. </param>
        /// <returns> Los datos de ahorrador consultado. </returns>
        public tblAhorradore gmtdConsultarDetalle(string tstrCedulaAho)
        {
            using (dbExequial2010DataContext ahorradores = new dbExequial2010DataContext())
            {
                var query = from aho in ahorradores.tblAhorradores
                            join ofi in ahorradores.tblOficios on aho.strCodOficio equals ofi.strCodOficio 
                            join bar in ahorradores.tblBarrios on aho.strCodBarrio equals bar.strCodBarrio
                            where aho.bitAnulado == false && aho.strCedulaAho == tstrCedulaAho 
                            select new { ahorrador = aho};


                tblAhorradore ahorrador = new tblAhorradore();
                foreach (var dato in query.ToList())
                {
                    ahorrador.bitAhorroEstudiantil = dato.ahorrador.bitAhorroEstudiantil;
                    ahorrador.bitCobraCuatroxMil = Convert.ToBoolean(dato.ahorrador.bitCobraCuatroxMil);
                    ahorrador.bitSexo = dato.ahorrador.bitSexo;
                    ahorrador.dtmFechaIng = dato.ahorrador.dtmFechaIng;
                    ahorrador.dtmFechaNac = dato.ahorrador.dtmFechaNac;
                    ahorrador.intCodigoSoc = dato.ahorrador.intCodigoSoc;
                    ahorrador.strCedulaAho = dato.ahorrador.strCedulaAho;
                    ahorrador.strNombreAho = dato.ahorrador.strNombreAho;
                    ahorrador.strApellido1Aho = dato.ahorrador.strApellido1Aho;
                    ahorrador.strApellido2Aho = dato.ahorrador.strApellido2Aho;
                    ahorrador.strCodBarrio = dato.ahorrador.strCodBarrio;
                    ahorrador.strCodOficio = dato.ahorrador.strCodOficio;
                    ahorrador.strCorreo = dato.ahorrador.strCorreo;
                    ahorrador.strDireccion = dato.ahorrador.strDireccion;
                    ahorrador.strEscolaridad = dato.ahorrador.strEscolaridad;
                    ahorrador.strTelefono = dato.ahorrador.strTelefono;
                    ahorrador.strTipoCed = dato.ahorrador.strTipoCed;
                    ahorrador.strCedulaBen = dato.ahorrador.strCedulaBen;
                    ahorrador.strNombreBen = dato.ahorrador.strNombreBen;
                    ahorrador.strApellidoBen = dato.ahorrador.strApellidoBen;
                    ahorrador.strOrigen = dato.ahorrador.strOrigen;
                    ahorrador.strTipoCed = dato.ahorrador.strTipoCed;
                    ahorrador.strCedulaAut = dato.ahorrador.strCedulaAut;
                    ahorrador.strNombreAut = dato.ahorrador.strNombreAut;
                    ahorrador.strApellidoAut = dato.ahorrador.strApellidoAut;
                    ahorrador.strLugarExpedicion = dato.ahorrador.strLugarExpedicion;
                    ahorrador.dtmFechaExpedicion = dato.ahorrador.dtmFechaExpedicion;
                }
                return ahorrador;

            }
        }

        /// <summary> Consulta si un número de cedula ya aparece registrado. </summary>
        /// <param name="tstrCedulaSocio"> Cédula del ahorrador a consultar. </param>
        /// <returns> Un valor que indica si se encontro o no la cédula del ahorrador. </returns>
        public bool gmtdConsultarCedulaAhorrador(string tstrCedulaAhorrador)
        {
            using (dbExequial2010DataContext ahorradores = new dbExequial2010DataContext())
            {
                var query = from aho in ahorradores.tblAhorradores
                            where aho.bitAnulado == false && aho.strCedulaAho == tstrCedulaAhorrador
                            select aho;

                if (query.ToList().Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>Selecciona los ahorradores registrados cuya informacíón coicida con los
        /// campos de la clausula where. </summary>
        /// <param name="tobjSocio"> El objeto ahorrador con los datos para filtrar </param>
        /// <returns> Un lista con los ahorradores seleccionados. </returns>
        public IList<Ahorrador> gmtdFiltrar(tblAhorradore tobjAhorrador)
        {
            using (dbExequial2010DataContext ahorradores = new dbExequial2010DataContext())
            {
                var query = from aho in ahorradores.tblAhorradores
                            where aho.bitAnulado == false
                            && aho.strCedulaAho.StartsWith(tobjAhorrador.strCedulaAho)
                            && aho.strNombreAho.StartsWith(tobjAhorrador.strNombreAho)
                            && aho.strApellido1Aho.StartsWith(tobjAhorrador.strApellido1Aho)
                            && aho.strApellido2Aho.StartsWith(tobjAhorrador.strApellido2Aho)   
                            select new {soc = aho};

                List<Ahorrador> lstAhorradores = new List<Ahorrador>();
                foreach (var dato in query.ToList())
                {
                    Ahorrador aho = new Ahorrador();
                    aho.intCodigoSoc = dato.soc.intCodigoSoc;
                    aho.strApellidoAho = dato.soc.strApellido1Aho + " " + dato.soc.strApellido2Aho;
                    aho.strCedulaAho = dato.soc.strCedulaAho;
                    aho.strDireccion = dato.soc.strDireccion;
                    aho.strNombreAho = dato.soc.strNombreAho;
                    aho.strTelefono = dato.soc.strTelefono;
                    lstAhorradores.Add(aho);
                }
                return lstAhorradores;
            }
        }

        /// <summary> Consulta todos los ahorradores registrados. </summary>
        /// <returns> Un lista con todos los ahorradores seleccionados. </returns>
        public IList<Ahorrador> gmtdConsultarTodos()
        {
            using (dbExequial2010DataContext ahorradores = new dbExequial2010DataContext())
            {
                var query = from aho in ahorradores.tblAhorradores
                            where aho.bitAnulado == false
                            select aho;

                List<Ahorrador> lstAhorradores = new List<Ahorrador>();
                foreach (var dato in query.ToList())
                {
                    Ahorrador aho = new Ahorrador();
                    aho.intCodigoSoc = dato.intCodigoSoc;
                    aho.strApellidoAho = dato.strApellido1Aho + " " + dato.strApellido2Aho;
                    aho.strCedulaAho = dato.strCedulaAho;
                    aho.strDireccion = dato.strDireccion;
                    aho.strNombreAho = dato.strNombreAho;
                    aho.strTelefono = dato.strTelefono;
                    lstAhorradores.Add(aho);
                }
                return lstAhorradores;
            }
        }

        /// <summary> Consulta un determinado ahorrador. </summary>
        /// <param name="tintCodSocio">la cédula del ahorrador a consultar.</param>
        /// <returns> un objeto del tipo tblAhorradore. </returns>
        public tblAhorradore gmtdConsultar(string tstrCedulaAho)
        {
            using (dbExequial2010DataContext ahorradores = new dbExequial2010DataContext())
            {
                var query = from aho in ahorradores.tblAhorradores
                            where aho.bitAnulado == false && aho.strCedulaAho == tstrCedulaAho
                            select aho;

                if (query.ToList().Count > 0)
                {
                    return query.ToList()[0];
                }
                else
                {
                    return new tblAhorradore();
                }
            }
        }

        /// <summary> Consulta los ahorradores registrados con un determinado barrio. </summary>
        /// <param name="tstrCodigoBar"> Còdigo del barrio para seleccionar los ahorradores. </param>
        /// <returns> Lista de los ahorradores consultados. </returns>
        public List<tblAhorradore> gmtdConsultarAhorradoresxBarrio(string tstrCodigoBar)
        {
            using (dbExequial2010DataContext ahorradores = new dbExequial2010DataContext())
            {
                var query = from aho in ahorradores.tblAhorradores
                            where aho.bitAnulado == false && aho.strCodBarrio == tstrCodigoBar
                            select aho;

                if (query.ToList().Count > 0)
                {
                    return query.ToList();
                }
                else
                {
                    return new List<tblAhorradore>();
                }
            }
        }

        /// <summary> Elimina un ahorrador de la base de datos. </summary>
        /// <param name="tobjSocio"> Un objeto del tipo tblAhorradore. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblAhorradore tobjAhorrador)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext ahorradores = new dbExequial2010DataContext())
                {
                    tblAhorradore aho_old = ahorradores.tblAhorradores.SingleOrDefault(p => p.strCedulaAho == tobjAhorrador.strCedulaAho);
                    aho_old.bitAnulado = true;
                    aho_old.dtmFecAnulado = DateTime.Now;

                    ahorradores.tblLogdeActividades.InsertOnSubmit(tobjAhorrador.log);
                    ahorradores.SubmitChanges();
                    strResultado = "Registro Eliminado";
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                strResultado = "- Ocurrió un error al Eliminar el registro.";
            }
            return strResultado;
        }

        /// <summary> Suma el valor de los ahorros de los ahorradores registrados. </summary>
        /// <returns> el valor de los ahorros de los ahorradores registrados</returns>
        public decimal gmtdSumarAhorros()
        {
            using (dbExequial2010DataContext persona = new dbExequial2010DataContext())
            {
                decimal query = (from aho in persona.tblAhorradores
                             where aho.bitAnulado == false
                             select aho.decAhorrado).Sum();

                return query;
            }
        }

        /// <summary> Registra los intereses de fin de año de los ahorradores. </summary>
        /// <param name="tdecPorcentaje"> Porcentaje de intereses que se le van a dar a los ahorros. </param>
        /// <returns> Un mensaje que indica si se ejecuto o no la operación </returns>
        public string gmtdActualizarIntereses(string tstrPorcentaje)
        {
            using (dbExequial2010DataContext personas = new dbExequial2010DataContext())
            {
                try
                {
                    personas.ExecuteCommand("Exec spAhorradoresInsertarIntereses '" + tstrPorcentaje.ToString().Replace(",", ".") + "'");
                    return "Registro Actualizados.";
                }
                catch (Exception ex)
                {
                    new dao().gmtdInsertarError(ex);
                    return "- Ocurrió un error al Eliminar el registro.";
                }
            }
        }

        /// <summary> Consulta el total de cada uno de los tipos de ahorro de la mutual. </summary>
        /// <returns> Un objeto que muestra los valores ahorrados de cada tipo de ahorro. </returns>
        public ahorrorosRegistrados gmtdConsultarTotalesdeAhorros()
        {
            ahorrorosRegistrados objResultado = new ahorrorosRegistrados();
            String strConexion = ConfigurationManager.ConnectionStrings["conexionDb"].ConnectionString;
            strConexion = strConexion.Replace("12345", "Sql__12345..");
            SqlConnection conexion = new SqlConnection(strConexion);
            SqlCommand comando = new SqlCommand("Exec spConsultarAhorrosRegistrados ", conexion);
            SqlDataReader dr;
            try
            {
                conexion.Open();
                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    objResultado.decAhorroalaVista = Convert.ToDecimal(dr["decAhorros"]);
                    objResultado.decAhorroEstudiantil = Convert.ToDecimal(dr["decEstudiantes"]);
                    objResultado.decAhorroaFuturo = Convert.ToDecimal(dr["decAhorrosFuturo"]);
                    objResultado.decAhorroNavideño = Convert.ToDecimal(dr["decAhorrosNavideno"]);
                    objResultado.decAhorroNatilleraEscolar = Convert.ToDecimal(dr["decAhorrosNatilleraEscolar"]);
                    objResultado.decAhorroFijo = Convert.ToDecimal(dr["decAhorrosFijos"]);
                    objResultado.decAhorroCdta = Convert.ToDecimal(dr["decCdts"]);
                    objResultado.decTotales = Convert.ToDecimal(dr["decTotal"]);
                }
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
            return objResultado;
        }

        /// <summary> Cambia el número de cedula de un ahorrador.</summary>
        /// <param name="tstrCedulaAct"> Número de cédula actual del ahorrador.</param>
        /// <param name="tstrCedulaNue"> Número de cédula nuevo del ahorrador.</param>
        /// <returns> Un valor que indica si se modifico o no la cédula. </returns>
        public string gmtdCambiarCedulaAhorrador(string tstrCedulaAct, string tstrCedulaNue, string tstrCadena)
        {
            string strResultado = "";

            SqlConnection conexion = new SqlConnection(tstrCadena);
            SqlCommand comando = new SqlCommand("Exec spActualizaCedulaAhorrador '" + tstrCedulaAct + "', '" + tstrCedulaNue + "'", conexion);
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                strResultado = "Registro Modificado";
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                strResultado = "Registro no Modificado";
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            return strResultado;
        }

    }
}
