using libMutuales2020.dominio;
using libMutuales2020.Recursos;
using libMutuales2020.Utilidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Transactions;
using System.Xml;

namespace libMutuales2020.dao
{
    class daoRecibosEgresos
    {
        /// <summary> Inserta un recibo de egresos. </summary>
        /// <param name="tobjIngreso"> Un objeto del tipo tblEgreso. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(XmlDocument xml)
        {
            try
            {
                List<SqlParameter> lstParametros = new List<SqlParameter>();
                SqlParameter objParameter = new SqlParameter();
                objParameter.DbType = DbType.Xml;
                objParameter.Direction = ParameterDirection.Input;
                objParameter.ParameterName = "xmlEgreso";
                objParameter.Value = xml.OuterXml;
                lstParametros.Add(objParameter);

                return new Utilidad().ejecutarSpConeccionDB(lstParametros, Sp.spEgresoInsertar).Rows[0]["intCodigoEgr"].ToString();
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                return "- Ocurrió un error al insertar el registro.";
            }
        }

        /// <summary> Consulta los datos de un determinado egreso. </summary>
        /// <param name="tintRecibo"> Código del egreso a consultar. </param>
        /// <returns> Retorna los datos del egreso. </returns>
        public tblEgreso gmtdConsultaEgreso(int tintRecibo)
        {
            using (dbExequial2010DataContext recibosEgresos = new dbExequial2010DataContext())
            {
                var query = from rec in recibosEgresos.tblEgresos
                            where rec.intCodigoEgr == tintRecibo
                            select rec;

                if (query.ToList().Count > 0)
                {

                    tblEgreso egreso = query.ToList()[0];

                    if (egreso.bitEgreso == true)
                    {
                        var queryEgreso = from rec in recibosEgresos.tblEgresosEgresos
                                          where rec.intCodigoEgr == tintRecibo
                                          select rec;
                        egreso.egresoEgreso = queryEgreso.ToList();
                    }

                    if (egreso.bitRetiro == true)
                    {
                        var queryRetiro = from rec in recibosEgresos.tblEgresosAhorros
                                          where rec.intCodigoEgr == tintRecibo
                                          select rec;
                        egreso.egresoAhorroalaVista = queryRetiro.ToList()[0];
                    }

                    if (egreso.bitRetiroAbonos == true)
                    {
                        var queryAbonoaPrestamo = from rec in recibosEgresos.tblEgresosPrestamosAbonos
                                                  where rec.intCodigoEgr == tintRecibo
                                                  select rec;
                        egreso.egresoAbonoaPrestamo = queryAbonoaPrestamo.ToList()[0];
                    }

                    if (egreso.bitRetiroAhorroEstudiante == true)
                    {
                        var queryRetiroEstudiantil = from rec in recibosEgresos.tblEgresosAhorrosEstudiantes
                                                     where rec.intCodigoEgr == tintRecibo
                                                     select rec;
                        egreso.egresoAhorroEstudiantil = queryRetiroEstudiantil.ToList()[0];
                    }

                    if (egreso.bitRetiroAhorroFijo == true)
                    {
                        var queryRetiroFijo = from rec in recibosEgresos.tblEgresosAhorrosFijos
                                              where rec.intCodigoEgr == tintRecibo
                                              select rec;
                        egreso.egresoAhorroFijo = queryRetiroFijo.ToList()[0];
                    }

                    if (egreso.bitRetiroIntereses == true)
                    {
                        var queryRetiroIntereses = from rec in recibosEgresos.tblEgresosIntereses
                                                   where rec.intCodigoEgr == tintRecibo
                                                   select rec;
                        egreso.egresoIntereses = queryRetiroIntereses.ToList()[0];
                    }

                    return egreso;
                }
                else
                {
                    return new tblEgreso();
                }


            }
        }

        /// <summary> Consulta los datos de un determinado egreso. </summary>
        /// <param name="tintRecibo"> Código del egreso a consultar. </param>
        /// <returns> Retorna los datos del egreso. </returns>
        public string gmtdEliminarEgreso(tblEgreso tobjEgreso)
        {
            String strRetornar;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    using (dbExequial2010DataContext recibosEgresos = new dbExequial2010DataContext())
                    {
                        tblEgreso egr = recibosEgresos.tblEgresos.SingleOrDefault(p => p.intCodigoEgr == tobjEgreso.intCodigoEgr);
                        egr.bitAnulado = true;
                        egr.dtmFechaAnu = tobjEgreso.dtmFechaAnu;

                        if (tobjEgreso.bitRetiro == true)
                        {
                            tblAhorradore cre = recibosEgresos.tblAhorradores.SingleOrDefault(p => p.strCedulaAho == tobjEgreso.strCedulaEgre);
                            cre.decAhorrado += tobjEgreso.egresoAhorroalaVista.decRetiro;
                        }

                        if (tobjEgreso.bitRetiroAbonos == true)
                        {
                            tblCredito cre = recibosEgresos.tblCreditos.SingleOrDefault(p => p.intCodigoCre == tobjEgreso.egresoAbonoaPrestamo.intCodigoCre);
                            cre.decAbono += tobjEgreso.egresoAbonoaPrestamo.decAbonoPrestamo;
                        }

                        if (tobjEgreso.bitRetiroAhorroEstudiante == true)
                        {
                            tblAhorradore cre = recibosEgresos.tblAhorradores.SingleOrDefault(p => p.strCedulaAho == tobjEgreso.strCedulaEgre);
                            cre.decAhorrosEstudiantes += tobjEgreso.egresoAhorroEstudiantil.decRetiro;
                        }

                        if (tobjEgreso.bitRetiroAhorroFijo == true)
                        {
                            tblAhorradore cre = recibosEgresos.tblAhorradores.SingleOrDefault(p => p.strCedulaAho == tobjEgreso.strCedulaEgre);
                            cre.decAhorrosFijo += tobjEgreso.egresoAhorroFijo.decRetiro;
                        }

                        if (tobjEgreso.bitRetiroIntereses == true)
                        {
                            tblAhorradore cre = recibosEgresos.tblAhorradores.SingleOrDefault(p => p.strCedulaAho == tobjEgreso.strCedulaEgre);
                            cre.decIntereses += tobjEgreso.egresoIntereses.decIntereses;
                        }

                        recibosEgresos.SubmitChanges();

                        tobjEgreso.log = metodos.gmtdLog("Elimina el egreso " + tobjEgreso.intCodigoEgr.ToString(), tobjEgreso.strFormulario);
                        recibosEgresos.tblLogdeActividades.InsertOnSubmit(tobjEgreso.log);

                        if (tobjEgreso.egresoAhorroalaVista != null)
                        {
                            tblAhorrosTransaccione tra = recibosEgresos.tblAhorrosTransacciones.SingleOrDefault(p => p.intCodigoIng == tobjEgreso.intCodigoEgr);
                            tra.bitMuestra = false;

                            tblAhorrosTransaccione transaccion = new tblAhorrosTransaccione();
                            transaccion.bitMuestra = false;
                            transaccion.decAcumula = tobjEgreso.egresoAhorroalaVista.decAhorrado + tobjEgreso.egresoAhorroalaVista.decRetiro;
                            transaccion.decAhorrado = tobjEgreso.egresoAhorroalaVista.decAhorrado;
                            transaccion.decValor = tobjEgreso.egresoAhorroalaVista.decRetiro;
                            transaccion.dtmFechaTra = tobjEgreso.dtmFechaAnu;
                            transaccion.intCodigoIng = tobjEgreso.intCodigoEgr;
                            transaccion.strCedulaAho = tobjEgreso.strCedulaEgre;
                            transaccion.strDescripcion = "Comprobante # " + tobjEgreso.intCodigoEgr.ToString();
                            transaccion.strTransaccion = "Ahorro";
                            recibosEgresos.tblAhorrosTransacciones.InsertOnSubmit(transaccion);

                        }

                        if (tobjEgreso.egresoAhorroEstudiantil != null)
                        {
                            tblAhorrosTransaccionesEstudiantil tra = recibosEgresos.tblAhorrosTransaccionesEstudiantils.SingleOrDefault(p => p.intCodigoIng == tobjEgreso.intCodigoEgr);
                            tra.bitMuestra = false;

                            tblAhorrosTransaccionesEstudiantil transaccion = new tblAhorrosTransaccionesEstudiantil();
                            transaccion.bitMuestra = false;
                            transaccion.decAcumula = tobjEgreso.egresoAhorroEstudiantil.decAcumula + tobjEgreso.egresoAhorroEstudiantil.decRetiro;
                            transaccion.decAhorrado = tobjEgreso.egresoAhorroEstudiantil.decAhorrado;
                            transaccion.decValor = tobjEgreso.egresoAhorroEstudiantil.decRetiro;
                            transaccion.dtmFechaTra = tobjEgreso.dtmFechaAnu;
                            transaccion.intCodigoIng = tobjEgreso.intCodigoEgr;
                            transaccion.strCedulaAho = tobjEgreso.strCedulaEgre;
                            transaccion.strDescripcion = "Comprobante # " + tobjEgreso.intCodigoEgr.ToString();
                            transaccion.strTransaccion = "Ahorro";

                            recibosEgresos.tblAhorrosTransaccionesEstudiantils.InsertOnSubmit(transaccion);
                        }

                        if (tobjEgreso.egresoAhorroFijo != null)
                        {
                            tblAhorrosTransaccionesFijo tra = recibosEgresos.tblAhorrosTransaccionesFijos.SingleOrDefault(p => p.intCodigoIng == tobjEgreso.intCodigoEgr);
                            tra.bitMuestra = false;

                            tblAhorrosTransaccionesFijo transaccion = new tblAhorrosTransaccionesFijo();
                            transaccion.bitMuestra = false;
                            transaccion.decAcumula = tobjEgreso.egresoAhorroFijo.decAcumula - tobjEgreso.egresoAhorroFijo.decRetiro;
                            transaccion.decAhorrado = tobjEgreso.egresoAhorroFijo.decAhorrado;
                            transaccion.decValor = tobjEgreso.egresoAhorroFijo.decRetiro;
                            transaccion.dtmFechaTra = tobjEgreso.dtmFechaAnu;
                            transaccion.intCodigoIng = tobjEgreso.intCodigoEgr;
                            transaccion.strCedulaAho = tobjEgreso.strCedulaEgre;
                            transaccion.strDescripcion = "Comprobante # " + tobjEgreso.intCodigoEgr.ToString();
                            transaccion.strTransaccion = "Ahorro";

                            recibosEgresos.tblAhorrosTransaccionesFijos.InsertOnSubmit(transaccion);
                        }

                        recibosEgresos.SubmitChanges();
                    }
                    ts.Complete();
                    strRetornar = "Registro Insertado";
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                strRetornar = "- No se puede eliminar el registro.";
            }
            return strRetornar;
        }

        /// <summaiy> Imprimir recibos. </summary>
        /// <param name="tintCodigoIng"> Codigo de recibo de ingreso. </param>
        public void gmtdImprimirEgreso(int tintCodigoEgr)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(ConfigurationManager.AppSettings["conexionDb"].ToString());
                SqlCommand comando = new SqlCommand("Exec spImprimirRecibosdeEgresos " + tintCodigoEgr.ToString(), conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataSet ds = new DataSet();
                adaptador.Fill(ds);
                ds.WriteXml(@"C:\Reportes\rptRecibosEgresos.Xml");
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
            }
        }

        /// <summary> Consulta los egresos activos en un rango de fechas. </summary>
        /// <param name="tdtmFechaIni"> Fecha de inicio de la consulta. </param>
        /// <param name="tdtmFechaFin"> Fecha final de la consulta. </param>
        /// <returns> El valor de la suma consultada. </returns>
        public decimal gmtdConsultarEgresosAgrupadosenunRangodeFechas(DateTime tdtmFechaIni, DateTime tdtmFechaFin)
        {
            try
            {
                using (dbExequial2010DataContext graficos = new dbExequial2010DataContext())
                {
                    var query = (from gra in graficos.tblEgresos
                                 where gra.bitAnulado == false
                                 && gra.dtmFechaRec >= tdtmFechaIni
                                 && gra.dtmFechaRec <= tdtmFechaFin
                                 select gra.decTotal).Sum();

                    return query;
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                return -1;
            }
        }

        /// <summary> Consulta los egresos activos en un rango de fechas. </summary>
        /// <param name="tdtmFechaIni"> Fecha de inicio de la consulta. </param>
        /// <param name="tdtmFechaFin"> Fecha final de la consulta. </param>
        /// <returns> El valor de la suma consultada. </returns>
        public decimal gmtdConsultarEgresosdeAhorrosAgrupadosenunRangodeFechas(DateTime tdtmFechaIni, DateTime tdtmFechaFin)
        {
            try
            {
                using (dbExequial2010DataContext graficos = new dbExequial2010DataContext())
                {
                    var query = (from gra in graficos.tblEgresos
                                 join det in graficos.tblEgresosAhorros on gra.intCodigoEgr equals det.intCodigoEgr
                                 where gra.bitAnulado == false
                                 && gra.dtmFechaRec >= tdtmFechaIni
                                 && gra.dtmFechaRec <= tdtmFechaFin
                                 select det.decRetiro).Sum();

                    return query;
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                return -1;
            }
        }

        /// <summary> Consulta los egresos por concepto de creditos en un rango de fechas. </summary>
        /// <param name="tdtmFechaIni"> Fecha de inicio de la consulta. </param>
        /// <param name="tdtmFechaFin"> Fecha final de la consulta. </param>
        /// <returns> El valor de la suma consultada. </returns>
        public decimal gmtdConsultarEgresosporCreditosenunRangodeFechas(DateTime tdtmFechaIni, DateTime tdtmFechaFin)
        {
            try
            {
                using (dbExequial2010DataContext graficos = new dbExequial2010DataContext())
                {
                    var query = (from gra in graficos.tblEgresos
                                 join egr in graficos.tblEgresosEgresos on gra.intCodigoEgr equals egr.intCodigoEgr
                                 where gra.bitAnulado == false
                                 && gra.dtmFechaRec >= tdtmFechaIni
                                 && gra.dtmFechaRec <= tdtmFechaFin
                                 select gra.decTotal).Sum();

                    return query;
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                return -1;
            }
        }
    }
}
