namespace libMutuales2020.dao
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Transactions;
    using libMutuales2020.dominio;
    using libMutuales2020.Recursos;
    using libMutuales2020.Utilidades;

    public class daoSocio
    {
        /// <summary> Modifica los datos del socio solicitados por la aseguradora. </summary>
        /// <param name="tobjSocio"> Un objeto del tipo persona a modificar.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdActualizarDato(personasaModificar tobjPersona)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext socio = new dbExequial2010DataContext())
                {
                    tblSocio soc_old = socio.tblSocios.SingleOrDefault(p => p.intCodigoSoc == tobjPersona.intCodigoSoc);
                    soc_old.dtmFechaNac = tobjPersona.dtmFechaNacimeinto;
                    soc_old.strApellido1Soc = tobjPersona.strApellido1;
                    soc_old.strApellido2Soc = tobjPersona.strApellido2;
                    soc_old.strCedulaSoc = tobjPersona.strCedula;
                    soc_old.strDireccion = tobjPersona.strDireccion;
                    soc_old.strNombreSoc = tobjPersona.strNombre;
                    soc_old.strTelefono = tobjPersona.strTelefono;
                    soc_old.bitActualizado = true;
                    socio.tblLogdeActividades.InsertOnSubmit(tobjPersona.log);
                    socio.SubmitChanges();
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

        /// <summary> Modifica un socio. </summary>
        /// <param name="tobjSocio"> Un objeto del tipo socio.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblSocio tobjSocio)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext socio = new dbExequial2010DataContext())
                {
                    tblSocio soc_old = socio.tblSocios.SingleOrDefault(p => p.intCodigoSoc == tobjSocio.intCodigoSoc);
                    soc_old.bitActivo = tobjSocio.bitActivo;
                    soc_old.bitSexo = tobjSocio.bitSexo;
                    soc_old.dtmFechaIng = tobjSocio.dtmFechaIng;
                    soc_old.dtmFechaNac = tobjSocio.dtmFechaNac;
                    soc_old.intAdultosMayores = tobjSocio.intAdultosMayores;
                    soc_old.intContrato = tobjSocio.intContrato;
                    soc_old.strApellido1Soc = tobjSocio.strApellido1Soc;
                    soc_old.strApellido2Soc = tobjSocio.strApellido2Soc;
                    soc_old.strCodBarrio = tobjSocio.strCodBarrio;
                    soc_old.strCodOficio = tobjSocio.strCodOficio;
                    soc_old.strCodServiciop = tobjSocio.strCodServiciop;
                    soc_old.strCorreo = tobjSocio.strCorreo;
                    soc_old.strDireccion = tobjSocio.strDireccion;
                    soc_old.strEscolaridad = tobjSocio.strEscolaridad;
                    soc_old.strNombreSoc = tobjSocio.strNombreSoc;
                    soc_old.strTelefono = tobjSocio.strTelefono;
                    soc_old.strTipoCed = tobjSocio.strTipoCed;
                    soc_old.bitAhorrador = tobjSocio.bitAhorrador;
                    soc_old.strCedulaSubsidio = tobjSocio.strCedulaSubsidio;
                    soc_old.strNombreSubsidio = tobjSocio.strNombreSubsidio;
                    soc_old.strApellidoSubsidio = tobjSocio.strApellidoSubsidio;
                    soc_old.bitEsAhorradordeNatilleraEscolar = tobjSocio.bitEsAhorradordeNatilleraEscolar;
                    soc_old.strLugarExpedicion = tobjSocio.strLugarExpedicion;
                    soc_old.dtmFechaExpedicion = tobjSocio.dtmFechaExpedicion;
                    socio.tblLogdeActividades.InsertOnSubmit(tobjSocio.log);
                    socio.SubmitChanges();
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

        /// <summary> Modifica una la cédula de un socio. </summary>
        /// <param name="tobjAgraciado"> Número de cédula que desea modificar. </param>
        /// <param name="tobjAgraciado"> Número de cédula a modificar. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditarCeduladeSocio(string tstrCedulaaModificar, string tstrCambiarpor)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext socio = new dbExequial2010DataContext())
                {
                    tblSocio agra_old = socio.tblSocios.SingleOrDefault(p => p.strCedulaSoc == tstrCedulaaModificar);
                    agra_old.strCedulaSoc = tstrCambiarpor;
                    socio.SubmitChanges();
                    strResultado = "Cédula de socio Actualizada";
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                strResultado = "- Ocurrió un error al Actualizar el registro";
            }
            return strResultado;
        }

        /// <summary> Inserta un socio. </summary>
        /// <param name="tobjSocio"> Un objeto del tipo socio. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblSocio tobjSocio)
        {
            String strRetornar;
            try
            {
                using (dbExequial2010DataContext socio = new dbExequial2010DataContext())
                {
                    socio.tblSocios.InsertOnSubmit(tobjSocio);
                    socio.tblLogdeActividades.InsertOnSubmit(tobjSocio.log);
                    socio.SubmitChanges();
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

        /// <summary> Registra los cambios de nuevo año. </summary>
        /// <param name="tobjSocio"> Un objeto del tipo socio. </param>
        /// <param name="tobjNuevoAño"> Un objeto del tipo nuevo año. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdNuevoAño(tblSocio tobjSocio, tblLogNuevoAño tobjNuevoAño)
        {
            String strRetornar;
            try
            {
                List<SqlParameter> lstParametros = new List<SqlParameter>();
                SqlParameter objParameter = new SqlParameter();
                objParameter.DbType = DbType.Int32;
                objParameter.Direction = ParameterDirection.Input;
                objParameter.ParameterName = "intAno";
                objParameter.Value = tobjSocio.intAño;
                lstParametros.Add(objParameter);

                objParameter = new SqlParameter();
                objParameter.DbType = DbType.Int32;
                objParameter.Direction = ParameterDirection.Input;
                objParameter.ParameterName = "intAnoAnt";
                objParameter.Value = tobjNuevoAño.intAñoAnterior;
                lstParametros.Add(objParameter);

                objParameter = new SqlParameter();
                objParameter.DbType = DbType.Int32;
                objParameter.Direction = ParameterDirection.Input;
                objParameter.ParameterName = "intMes";
                objParameter.Value = tobjNuevoAño.intMesNuevo;
                lstParametros.Add(objParameter);

                objParameter = new SqlParameter();
                objParameter.DbType = DbType.Int32;
                objParameter.Direction = ParameterDirection.Input;
                objParameter.ParameterName = "intMesAnt";
                objParameter.Value = tobjNuevoAño.intMesAnterior;
                lstParametros.Add(objParameter);

                objParameter = new SqlParameter();
                objParameter.DbType = DbType.String;
                objParameter.Direction = ParameterDirection.Input;
                objParameter.ParameterName = "strCodServiciop";
                objParameter.Value = tobjNuevoAño.strServicioNuevo;
                lstParametros.Add(objParameter);

                objParameter = new SqlParameter();
                objParameter.DbType = DbType.String;
                objParameter.Direction = ParameterDirection.Input;
                objParameter.ParameterName = "strCodServiciopAnt";
                objParameter.Value = tobjNuevoAño.strServicioAnterior;
                lstParametros.Add(objParameter);

                objParameter = new SqlParameter();
                objParameter.DbType = DbType.Int32;
                objParameter.Direction = ParameterDirection.Input;
                objParameter.ParameterName = "intCodigoSoc";
                objParameter.Value = tobjNuevoAño.intCodigoSoc;
                lstParametros.Add(objParameter);

                objParameter = new SqlParameter();
                objParameter.DbType = DbType.String;
                objParameter.Direction = ParameterDirection.Input;
                objParameter.ParameterName = "Usuario";
                objParameter.Value = tobjNuevoAño.strUsuario;
                lstParametros.Add(objParameter);

                return new Utilidad().ejecutarSpConeccionDB(lstParametros, Sp.spNuevoAno).Rows[0]["intCodigo"].ToString();
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                strRetornar = "0";
            }
            return strRetornar;
        }

        /// <summary> Consulta si un número de cedula ya aparece registrado. </summary>
        /// <param name="tstrCedulaSocio"> Cédula del socio a consultar. </param>
        /// <returns> Un valor que indica si se encontro o no la cédula del socio. </returns>
        public bool gmtdConsultarCedulaSocio(string tstrCedulaSocio)
        {
            using (dbExequial2010DataContext socios = new dbExequial2010DataContext())
            {
                var query = from soc in socios.tblSocios
                            where soc.bitAnulado == false && soc.strCedulaSoc == tstrCedulaSocio
                            select soc;
                if (query.ToList().Count > 0)
                    return true;
                else
                    return false;
            }
        }

        /// <summary> Consulta los socios registrados con un determinado barrio. </summary>
        /// <param name="tstrCodigoBar"> Còdigo del barrio para seleccionar los socios. </param>
        /// <returns> Lista de los socios consultados. </returns>
        public List<tblSocio> gmtdConsultarSociosxBarrio(string tstrCodigoBar)
        {
            using (dbExequial2010DataContext socios = new dbExequial2010DataContext())
            {
                var query = from soc in socios.tblSocios
                            where soc.bitAnulado == false && soc.strCodBarrio == tstrCodigoBar
                            select soc;

                if (query.ToList().Count > 0)
                    return query.ToList();
                else
                    return new List<tblSocio>();
            }
        }

        /// <summary> Consulta los datos de un determinado socio. </summary>
        /// <param name="tintSocio"> El código del socio a consultar. </param>
        /// <returns> Los datos de socio consultado. </returns>
        public tblSocio gmtdConsultarDetalle(int tintSocio)
        {
            using (dbExequial2010DataContext socios = new dbExequial2010DataContext())
            {
                var query = from soc in socios.tblSocios
                            join ser in socios.tblServiciosPrimarios on soc.strCodServiciop equals ser.strCodSpr
                            join ofi in socios.tblOficios on soc.strCodOficio equals ofi.strCodOficio
                            join bar in socios.tblBarrios on soc.strCodBarrio equals bar.strCodBarrio
                            where soc.bitAnulado == false && soc.intCodigoSoc == tintSocio
                            select new { soc, ser.strNombreSpr, ser.bitUnicoSpr };

                tblSocio socio = new tblSocio();
                foreach (var dato in query.ToList())
                {
                    socio.bitActivo = dato.soc.bitActivo;
                    socio.bitSexo = dato.soc.bitSexo;
                    socio.dtmFechaIng = dato.soc.dtmFechaIng;
                    socio.dtmFechaNac = dato.soc.dtmFechaNac;
                    socio.intAdultosMayores = dato.soc.intAdultosMayores;
                    socio.intCodigoSoc = dato.soc.intCodigoSoc;
                    socio.intContrato = dato.soc.intContrato;
                    socio.strApellido1Soc = dato.soc.strApellido1Soc;
                    socio.strApellido2Soc = dato.soc.strApellido2Soc;
                    socio.strCedulaSoc = dato.soc.strCedulaSoc;
                    socio.strCodBarrio = dato.soc.strCodBarrio;
                    socio.strCodOficio = dato.soc.strCodOficio;
                    socio.strCodServiciop = dato.soc.strCodServiciop;
                    socio.strCorreo = dato.soc.strCorreo;
                    socio.strDireccion = dato.soc.strDireccion;
                    socio.strEscolaridad = dato.soc.strEscolaridad;
                    socio.strNombreSoc = dato.soc.strNombreSoc;
                    socio.strTelefono = dato.soc.strTelefono;
                    socio.strTipoCed = dato.soc.strTipoCed;
                    socio.intAño = dato.soc.intAño;
                    socio.intMeses = dato.soc.intMeses;
                    socio.servicio = new daoPrimarios().gmtdConsultar(dato.soc.strCodServiciop);
                    socio.intValorCuotaAdultoMayor = (int)new daoUtilidadesConfiguracion().gmtdConsultaConfiguracion().intValorCuotaAdultoMayor;
                    socio.bitActualizado = dato.soc.bitActualizado;
                    socio.bitAhorrador = dato.soc.bitAhorrador;
                    socio.strCedulaSubsidio = dato.soc.strCedulaSubsidio;
                    socio.strNombreSubsidio = dato.soc.strNombreSubsidio;
                    socio.strApellidoSubsidio = dato.soc.strApellidoSubsidio;
                    socio.bitEsAhorradordeNatilleraEscolar = dato.soc.bitEsAhorradordeNatilleraEscolar;
                    socio.dtmFechaExpedicion = dato.soc.dtmFechaExpedicion;
                    socio.strLugarExpedicion = dato.soc.strLugarExpedicion;
                }
                return socio;
            }
        }

        /// <summary> Consulta los datos de un determinado socio x su número de cédula. </summary>
        /// <param name="tintSocio"> El número de cédula del socio a consultar. </param>
        /// <returns> Los datos de socio consultado. </returns>
        public tblSocio gmtdConsultarDetalle(string tstrCedulaSocio)
        {
            using (dbExequial2010DataContext socios = new dbExequial2010DataContext())
            {
                var query = from soc in socios.tblSocios
                            join ser in socios.tblServiciosPrimarios on soc.strCodServiciop equals ser.strCodSpr
                            join ofi in socios.tblOficios on soc.strCodOficio equals ofi.strCodOficio
                            join bar in socios.tblBarrios on soc.strCodBarrio equals bar.strCodBarrio
                            where soc.bitAnulado == false && soc.strCedulaSoc == tstrCedulaSocio
                            select new { soc, ser.strNombreSpr, ser.bitUnicoSpr };

                tblSocio socio = new tblSocio();
                foreach (var dato in query.ToList())
                {
                    socio.bitActivo = dato.soc.bitActivo;
                    socio.bitSexo = dato.soc.bitSexo;
                    socio.dtmFechaIng = dato.soc.dtmFechaIng;
                    socio.dtmFechaNac = dato.soc.dtmFechaNac;
                    socio.intAdultosMayores = dato.soc.intAdultosMayores;
                    socio.intCodigoSoc = dato.soc.intCodigoSoc;
                    socio.intContrato = dato.soc.intContrato;
                    socio.strApellido1Soc = dato.soc.strApellido1Soc;
                    socio.strApellido2Soc = dato.soc.strApellido2Soc;
                    socio.strCedulaSoc = dato.soc.strCedulaSoc;
                    socio.strCodBarrio = dato.soc.strCodBarrio;
                    socio.strCodOficio = dato.soc.strCodOficio;
                    socio.strCodServiciop = dato.soc.strCodServiciop;
                    socio.strCorreo = dato.soc.strCorreo;
                    socio.strDireccion = dato.soc.strDireccion;
                    socio.strEscolaridad = dato.soc.strEscolaridad;
                    socio.strNombreSoc = dato.soc.strNombreSoc;
                    socio.strTelefono = dato.soc.strTelefono;
                    socio.strTipoCed = dato.soc.strTipoCed;
                    socio.intAño = dato.soc.intAño;
                    socio.intMeses = dato.soc.intMeses;
                    socio.servicio = new daoPrimarios().gmtdConsultar(dato.soc.strCodServiciop);
                    socio.intValorCuotaAdultoMayor = (int)new daoUtilidadesConfiguracion().gmtdConsultaConfiguracion().intValorCuotaAdultoMayor;
                }
                return socio;
            }
        }

        /// <summary> Consulta si un número de cedula ya aparece registrado como socio, Agraciado o Fallecido. </summary>
        /// <param name="tstrCedulaSocio"> Cédula a consultar. </param>
        /// <returns> Un valor que indica si se encontro o no la cédula del socio. </returns>
        public bool gmtdConsultarCeduladeSocioAgraciadoFallecido(string tstrCedulaaEvaluar)
        {
            using (dbExequial2010DataContext socios = new dbExequial2010DataContext())
            {
                var query = from soc in socios.tblSocios
                            where soc.strCedulaSoc == tstrCedulaaEvaluar && soc.bitAnulado == false
                            select soc;

                if (query.ToList().Count > 0)
                {
                    return true;
                }
                else
                {
                    var queryAgraciado = from ben in socios.tblAgraciados
                                         where ben.strCedulaAgra == tstrCedulaaEvaluar && ben.bitAnulado == false
                                         select ben;

                    if (queryAgraciado.ToList().Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        var queryFallecido = from fal in socios.tblFallecidos
                                             where fal.strCedulaFal == tstrCedulaaEvaluar && fal.bitAnulado == false
                                             select fal;

                        if (queryFallecido.ToList().Count > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

        }

        /// <summary>Selecciona los socios registrados cuya informacíón coicida con los
        /// campos de la clausula where. </summary>
        /// <param name="tobjSocio"> El objeto socio con los datos para filtrar </param>
        /// <returns> Un lista con los socios seleccionados. </returns>
        public IList<Socio> gmtdFiltrar(tblSocio tobjSocio)
        {
            using (dbExequial2010DataContext socios = new dbExequial2010DataContext())
            {
                var query = from soc in socios.tblSocios
                            join ser in socios.tblServiciosPrimarios on soc.strCodServiciop equals ser.strCodSpr
                            where soc.bitAnulado == false
                            && soc.strCedulaSoc.StartsWith(tobjSocio.strCedulaSoc)
                            && soc.strNombreSoc.StartsWith(tobjSocio.strNombreSoc)
                            && soc.strApellido1Soc.StartsWith(tobjSocio.strApellido1Soc)
                            && soc.strApellido2Soc.StartsWith(tobjSocio.strApellido2Soc)
                            select new { soc, ser.strNombreSpr };

                List<Socio> lstSocio = new List<Socio>();
                foreach (var dato in query.ToList())
                {
                    Socio soc = new Socio();
                    soc.intCodigoSoc = dato.soc.intCodigoSoc;
                    soc.strApellidoSoc = dato.soc.strApellido1Soc + " " + dato.soc.strApellido2Soc;
                    soc.strCedulaSoc = dato.soc.strCedulaSoc;
                    soc.strDireccion = dato.soc.strDireccion;
                    soc.strNombreSoc = dato.soc.strNombreSoc;
                    soc.strTelefono = dato.soc.strTelefono;
                    soc.strPlan = dato.strNombreSpr;
                    lstSocio.Add(soc);
                }
                return lstSocio;
            }
        }

        /// <summary> Consulta todos los socios registrados. </summary>
        /// <returns> Un lista con todos los socios seleccionados. </returns>
        public IList<Socio> gmtdConsultarTodos()
        {
            using (dbExequial2010DataContext socios = new dbExequial2010DataContext())
            {
                var query = from soc in socios.tblSocios
                            join ser in socios.tblServiciosPrimarios on soc.strCodServiciop equals ser.strCodSpr
                            where soc.bitAnulado == false
                            orderby soc.strCedulaSoc ascending
                            select new { soc, ser.strNombreSpr };

                List<Socio> lstSocio = new List<Socio>();
                foreach (var dato in query.ToList())
                {
                    Socio soc = new Socio();
                    soc.intCodigoSoc = dato.soc.intCodigoSoc;
                    soc.strApellidoSoc = dato.soc.strApellido1Soc + " " + dato.soc.strApellido2Soc;
                    soc.strCedulaSoc = dato.soc.strCedulaSoc;
                    soc.strDireccion = dato.soc.strDireccion;
                    soc.strNombreSoc = dato.soc.strNombreSoc;
                    soc.strTelefono = dato.soc.strTelefono;
                    soc.strPlan = dato.strNombreSpr;
                    lstSocio.Add(soc);
                }
                return lstSocio;
            }
        }

        /// <summary> Consulta un determinado socio. </summary>
        /// <param name="tintCodSocio">el código del socio a consultar.</param>
        /// <returns> un objeto del tipo tblSocio. </returns>
        public tblSocio gmtdConsultar(int tintCodigoSoc)
        {
            using (dbExequial2010DataContext personas = new dbExequial2010DataContext())
            {
                var query = from soc in personas.tblSocios
                            where soc.intCodigoSoc == tintCodigoSoc
                            select soc;

                if (query.ToList().Count > 0)
                    return query.ToList()[0];
                else
                    return new tblSocio();
            }
        }

        /// <summary> Consulta un determinado socio. </summary>
        /// <param name="tintCodSocio">el número de la cédula del socio.</param>
        /// <returns> un objeto del tipo tblSocio. </returns>
        public tblSocio gmtdConsultar(string tstrCedula)
        {
            using (dbExequial2010DataContext personas = new dbExequial2010DataContext())
            {
                var query = from soc in personas.tblSocios
                            where soc.strCedulaSoc == tstrCedula
                            select soc;

                if (query.ToList().Count > 0)
                    return query.ToList()[0];
                else
                    return new tblSocio();
            }
        }

        /// <summary> Elimina un socio de la base de datos. </summary>
        /// <param name="tobjSocio"> Un objeto del tipo tblSocio. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblSocio tobjSocio)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext socio = new dbExequial2010DataContext())
                {
                    tblSocio soc_old = socio.tblSocios.SingleOrDefault(p => p.intCodigoSoc == tobjSocio.intCodigoSoc);
                    soc_old.bitAnulado = true;
                    soc_old.dtmFecAnulado = DateTime.Now;

                    socio.tblLogdeActividades.InsertOnSubmit(tobjSocio.log);
                    socio.SubmitChanges();
                    strResultado = "Registro Eliminado";
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                strResultado = "- No se puede eliminar el registro.";
            }
            return strResultado;
        }

        /// <summary> Cambia el socio con el que esta registrado un determinado agraciado. </summary>
        /// <param name="tintSocioActual"> Codigo del socio que actualmente tiene registrado el agraciado. </param>
        /// <param name="tstrCedulaAgra"> Cédula del agraciado que se va a cambiar de socio. </param>
        /// <param name="tintSocioNuvo"> Código del socio al que se va a cambiar el agraciado. </param>
        /// <returns> Un mensaje que indica si se registro o no la cédula. </returns>
        public string gmtdCambiarAgraciadodeSocio(int tintSocioActual, string tstrCedulaAgra, int tintSocioNuevo)
        {
            try
            {
                using (dbExequial2010DataContext socio = new dbExequial2010DataContext())
                {
                    tblSocio soc_old = socio.tblSocios.SingleOrDefault(p => p.intCodigoSoc == tintSocioActual);
                    soc_old.intAgraciados--;

                    soc_old = socio.tblSocios.SingleOrDefault(p => p.intCodigoSoc == tintSocioNuevo);
                    soc_old.intAgraciados++;

                    tblAgraciado agr_old = socio.tblAgraciados.SingleOrDefault(p => p.bitAnulado == false && p.strCedulaAgra == tstrCedulaAgra);
                    agr_old.intCodigoSoc = tintSocioNuevo;

                    socio.SubmitChanges();

                    return "Registro Actualizado.";

                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                return "- Ocurrió un error al Actualizar el registro";
            }

        }

        /// <summary> Cambia un agraciado socio y el socio a agraciado. </summary>
        /// <param name="tobjAgraciado"> Agraciado que se va a registrar. </param>
        /// <param name="tobjSocio"> Socio que se va a acatualizar. </param>
        /// <param name="tstrCedulaAgra"> Cedula del agraciado que se va a eliminar. </param>
        /// <returns> Un mensaje indicando si se ejecuto o no la aoperación. </returns>
        public string gmtdCambiarAgraciadoaSocio(tblAgraciado tobjAgraciado, tblSocio tobjSocio, string tstrCedulaAgra)
        {
            try
            {
                using (dbExequial2010DataContext personas = new dbExequial2010DataContext())
                {
                    using (TransactionScope ts = new TransactionScope())
                    {
                        var query = from agra in personas.tblAgraciados
                                    where agra.strCedulaAgra == tstrCedulaAgra
                                    select agra;

                        foreach (var detail in query)
                            personas.tblAgraciados.DeleteOnSubmit(detail);

                        personas.SubmitChanges();

                        tblSocio soc_old = personas.tblSocios.SingleOrDefault(p => p.intCodigoSoc == tobjSocio.intCodigoSoc);
                        soc_old.bitSexo = tobjSocio.bitSexo;
                        soc_old.dtmFechaIng = tobjSocio.dtmFechaIng;
                        soc_old.dtmFechaNac = tobjSocio.dtmFechaNac;
                        soc_old.strApellido1Soc = tobjSocio.strApellido1Soc;
                        soc_old.strApellido2Soc = tobjSocio.strApellido2Soc;
                        soc_old.strCodBarrio = tobjSocio.strCodBarrio;
                        soc_old.strCodOficio = tobjSocio.strCodOficio;
                        soc_old.strCorreo = tobjSocio.strCorreo;
                        soc_old.strDireccion = tobjSocio.strDireccion;
                        soc_old.strEscolaridad = tobjSocio.strEscolaridad;
                        soc_old.strNombreSoc = tobjSocio.strNombreSoc;
                        soc_old.strTelefono = tobjSocio.strTelefono;
                        soc_old.strTipoCed = tobjSocio.strTipoCed;
                        soc_old.strCedulaSoc = tobjSocio.strCedulaSoc;
                        personas.SubmitChanges();

                        personas.tblAgraciados.InsertOnSubmit(tobjAgraciado);
                        personas.SubmitChanges();

                        ts.Complete();
                    }

                    return "Registro Guardado";

                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                return "- Ocurrió un error al actualizar el socio.";
            }
        }

        /// <summary> Habilita un asociado que se encuentre deshabilitado. </summary>
        /// <param name="tstrCedulaAgra"> Cédula del socio a habilitar. </param>
        /// <returns> Un mensaje indicando si se ejecuto o no la operación. </returns>
        public string gmtdHabilitarAnulado(int tintCodigoSoc)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext personas = new dbExequial2010DataContext())
                {
                    tblSocio soca_old = personas.tblSocios.SingleOrDefault(p => p.intCodigoSoc == tintCodigoSoc);
                    soca_old.bitAnulado = false;
                    soca_old.dtmFecAnulado = Convert.ToDateTime("1/1/1900");

                    personas.SubmitChanges();

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

    }
}
