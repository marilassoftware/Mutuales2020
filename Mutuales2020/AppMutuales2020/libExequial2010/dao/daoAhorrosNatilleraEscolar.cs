namespace libMutuales2020.dao
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Transactions;
    using System.Xml;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using libMutuales2020.Recursos;
    using libMutuales2020.Utilidades;

    class daoAhorrosNatilleraEscolar
    {
        /// <summary> Inserta una cuenta de ahorro navideño. </summary>
        /// <param name="tobjAhorroaFuturo"> Un objeto del tipo ahorro navideño. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblAhorrosNatilleraEscolar tobjAhorronavideno)
        {
            String strRetornar;
            try
            {
                using (dbExequial2010DataContext ahorros = new dbExequial2010DataContext())
                {
                    ahorros.tblAhorrosNatilleraEscolars.InsertOnSubmit(tobjAhorronavideno);
                    ahorros.tblAhorrosNatilleraEscolarDetalles.InsertAllOnSubmit(tobjAhorronavideno.lstMeses);
                    ahorros.tblLogdeActividades.InsertOnSubmit(tobjAhorronavideno.log);
                    ahorros.SubmitChanges();
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

        /// <summary> Consulta los datos de la liquidación de una cuenta de ahorro navideño. </summary>
        /// <param name="tstrCuenta"> Cuenta de la que se desea conocer los datos de liquidación. </param>
        /// <returns> Un objeto con los datos de la liquidacion. </returns>
        public LiquidacionAhorroNatilleraEscolar gmtdCalcularLiquidacionAhorroNatilleraEscolar(string tstrCuenta, int tintAño)
        {
            LiquidacionAhorroNatilleraEscolar liquidacion = new LiquidacionAhorroNatilleraEscolar();

            using (dbExequial2010DataContext ahorros = new dbExequial2010DataContext())
            {
                var query = from det in ahorros.tblAhorrosNatilleraEscolarDetalles
                            join enc in ahorros.tblAhorrosNatilleraEscolars on det.strCuenta equals enc.strCuenta
                            where det.bitPagada == true && det.strCuenta == tstrCuenta && enc.intAno == tintAño
                            orderby det.dtmFechaCuota ascending
                            select new { det, enc };

                int intCuotasPagadas = query.ToList().Count;

                if (intCuotasPagadas != 38)
                {
                    var queryCuotas = from det in ahorros.tblAhorrosNatilleraEscolarDetalles
                                      join enc in ahorros.tblAhorrosNatilleraEscolars on det.strCuenta equals enc.strCuenta
                                      where det.strCuenta == tstrCuenta && enc.intAno == tintAño
                                      orderby det.dtmFechaCuota ascending
                                      select det;

                    DateTime dtmUltimaCuota = queryCuotas.ToList()[queryCuotas.ToList().Count - 1].dtmFechaCuota;

                    if (new daoUtilidadesConfiguracion().gmtdCapturarFechadelServidor() < dtmUltimaCuota)
                    {
                        liquidacion.bitAplicarMulta = true;
                    }
                    else
                    {
                        liquidacion.bitAplicarMulta = false;
                    }
                }


                var query1 = from cue in ahorros.tblAhorrosNatilleraEscolars
                             join per in ahorros.tblAhorradores on cue.strCedulaAho equals per.strCedulaAho
                             where cue.bitAnulado == false && cue.bitLiquidada == false && cue.strCuenta == tstrCuenta
                             select new { cue.strCuenta, cue.strCedulaAho, per.strNombreAho, per.strApellido1Aho, per.strApellido2Aho, cue.bitLiquidada, cue.dtmFechaCuenta, cue.dtmFechaLiquidada, cue.fltIntereses, cue.fltPremios, cue.fltValorCuota, cue.intAno, cue.intCuotas };

                foreach (var dato in query1.ToList())
                {
                    liquidacion.decDescuento = 0;
                    liquidacion.decIntereses = Convert.ToDecimal(dato.fltIntereses);
                    liquidacion.decPorcentajeCuotasPagadas = 0;
                    liquidacion.decPremios = Convert.ToDecimal(dato.fltPremios);
                    liquidacion.decTotalLiquidacion = 0;
                    liquidacion.decTotalRecaudado = Convert.ToDecimal(dato.fltValorCuota) * intCuotasPagadas;
                    liquidacion.intCuotasPagadas = intCuotasPagadas;
                    liquidacion.strAhorrador = dato.strNombreAho + " " + dato.strApellido1Aho + " " + dato.strApellido2Aho;
                    liquidacion.strCuenta = tstrCuenta;
                }
                return liquidacion;
            }
        }

        /// <summary> Registra la liquidación de una cuenta de ahorro navideño. </summary>
        /// <param name="tstrCuenta"> Cuenta de ahorro navideño a liquidar. </param>
        /// <returns> Un string que indica si se registro o no la liquidación. </returns>
        public string gmtdLiquidarAhorroNatilleraEscolar(LiquidacionAhorroNatilleraEscolar tobjLiquidacion, string pstrUsuario, string pstrMaquina)
        {
            String strResultado;
            string strIngreso = "";
            string strEgreso = "";
            DateTime dtmFechaActual;
            tblEgreso egreso = new tblEgreso();
            tblIngreso ingreso = new tblIngreso();
            DataTable dt = new DataTable();
            try
            {
                tblEgresosAhorrosNatilleraEscolarLiquidacion egresoLiquidacionNavideno = new tblEgresosAhorrosNatilleraEscolarLiquidacion();
                egresoLiquidacionNavideno.strCuenta = tobjLiquidacion.strCuenta;

                egreso.bitRetiroAhorroNatilleraEscolarLiquidacion = true;
                if (tobjLiquidacion.bitAplicarMulta)
                {
                    egresoLiquidacionNavideno.decValorLiquidacion = tobjLiquidacion.decTotalRecaudado;
                    egreso.decTotal = tobjLiquidacion.decTotalRecaudado;
                }
                else
                {
                    egresoLiquidacionNavideno.decValorLiquidacion = tobjLiquidacion.decTotalLiquidacion;
                    egreso.decTotal = tobjLiquidacion.decTotalLiquidacion;
                }

                egreso.dtmFechaAnu = Convert.ToDateTime("1/1/1900");
                dtmFechaActual = new daoUtilidadesConfiguracion().gmtdCapturarFechadelServidor();
                egreso.dtmFechaRec = dtmFechaActual;
                egreso.strApellido = "";
                egreso.strCedulaEgre = tobjLiquidacion.strCedulaAho;
                egreso.strFormulario = tobjLiquidacion.strFormulario;
                egreso.strLetras = new blConfiguracion().montoenLetras(tobjLiquidacion.decTotalLiquidacion.ToString());
                egreso.strNombre = tobjLiquidacion.strAhorrador;
                egreso.strMaquina = pstrMaquina;
                egreso.strUsuario = pstrUsuario;
                egreso.objEgresosAhorrosNatilleraEscolarLiquidacion = egresoLiquidacionNavideno;

                XmlDocument xml = blRecibosEgresos.SerializeServicio(egreso);

                List<SqlParameter> lstParametros = new List<SqlParameter>();
                SqlParameter objParameter = new SqlParameter();
                objParameter.DbType = DbType.Xml;
                objParameter.Direction = ParameterDirection.Input;
                objParameter.ParameterName = "xmlEgreso";
                objParameter.Value = xml.OuterXml;
                lstParametros.Add(objParameter);

                dt = new Utilidad().ejecutarSpConeccionDB(lstParametros, Sp.spEgresoInsertar);
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                strResultado = "- Ocurrió un error al Actualizar el registro";
            }

            strEgreso = dt.Rows[0]["intCodigoEgr"].ToString();
            strIngreso = dt.Rows[0]["intCodigoIng"].ToString();

            strResultado = "Se hace el registro del siguiente egreso" + " \n " + strEgreso;

            return strResultado;
        }

        /// <summary> Consulta los datos de una cuenta si esta esta liquidada. </summary>
        /// <param name="tstrCuenta"> Código de la cuenta a consultar. </param>
        /// <returns> Un objeto del tipo LiquidacionAhorroNavideno. </returns>
        public LiquidacionAhorroNatilleraEscolar gmtdConsultarCuentaLiquidada(string tstrCuenta)
        {
            using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
            {
                var query = from cue in cuenta.tblAhorrosNatilleraEscolars
                            where cue.strCuenta == tstrCuenta && cue.bitLiquidada == true && cue.bitAnulado == false
                            select cue;

                if (query.ToList().Count > 0)
                {
                    LiquidacionAhorroNatilleraEscolar cuen = new LiquidacionAhorroNatilleraEscolar();
                    foreach (var dato in query.ToList())
                    {
                        cuen.strCuenta = tstrCuenta;
                        cuen.intCodigoEgr = (int)dato.intCodigoEgr;
                        cuen.intCodigoIng = (int)dato.intCodigoIng;
                    }
                    return cuen;
                }
                else
                {
                    return new LiquidacionAhorroNatilleraEscolar();
                }
            }

        }

        /// <summary> Elimina la liquidación de una cuenta de ahorro navideño. </summary>
        /// <param name="tobjCuentaLiquidad"> Un objeto con el código de la cuenta a eliminar. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEliminarLiquidaciondeCuenta(LiquidacionAhorroNatilleraEscolar tobjCuentaLiquidad)
        {
            String strResultado;
            DateTime dtmFechaActual = new blConfiguracion().gmtdCapturarFechadelServidor();
            decimal decValorLiquidacion = 0;
            decimal decValorMulta = 0;
            string strNombre = "";
            string strApellido = "";
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    using (dbExequial2010DataContext reciboEgreso = new dbExequial2010DataContext())
                    {
                        tblEgreso egre_old = reciboEgreso.tblEgresos.SingleOrDefault(p => p.intCodigoEgr == tobjCuentaLiquidad.intCodigoEgr);
                        egre_old.bitAnulado = true;
                        egre_old.dtmFechaAnu = dtmFechaActual;
                        decValorLiquidacion = egre_old.decTotal;
                        strNombre = egre_old.strNombre;
                        strApellido = egre_old.strApellido;
                        reciboEgreso.tblLogdeActividades.InsertOnSubmit(metodos.gmtdLog("Elimino el egreso " + tobjCuentaLiquidad.intCodigoEgr.ToString(), "FrmAhorrosaFuturoLiquidacion"));
                        reciboEgreso.SubmitChanges();

                        #region Mvto ingreso x anular liquidación de ahorro navideño
                        List<cuentaValores>[] cuotasValores = new blCuentaPar().gmtdCalcularValores("0001", decValorLiquidacion);
                        List<cuentaValores> cuentasDebito = cuotasValores[0];
                        for (int a = 0; a < cuentasDebito.Count; a++)
                            reciboEgreso.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasDebito[a].decValor, 0, cuentasDebito[a].strCuenta, "Recibo de ingreso x Anular liquidación de ahorro navideño", 1, tobjCuentaLiquidad.strCedulaAho, strNombre + " " + strApellido, dtmFechaActual));
                        List<cuentaValores> cuentasCredito = cuotasValores[1];
                        for (int a = 0; a < cuentasCredito.Count; a++)
                            reciboEgreso.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasCredito[a].decValor, 0, cuentasCredito[a].strCuenta, "Recibo de ingreso x Anular liquidación de ahorro navideño", 2, tobjCuentaLiquidad.strCedulaAho, strNombre + " " + strApellido, dtmFechaActual));
                        #endregion
                    }

                    if (tobjCuentaLiquidad.intCodigoIng > 0)
                    {
                        using (dbExequial2010DataContext reciboEgreso = new dbExequial2010DataContext())
                        {
                            tblIngreso ing_old = reciboEgreso.tblIngresos.SingleOrDefault(p => p.intCodigoIng == tobjCuentaLiquidad.intCodigoIng);
                            ing_old.bitAnulado = true;
                            ing_old.dtmFechaAnu = dtmFechaActual;
                            decValorMulta = ing_old.decTotalIng;
                            reciboEgreso.tblLogdeActividades.InsertOnSubmit(metodos.gmtdLog("Elimino el ingreso " + tobjCuentaLiquidad.intCodigoIng.ToString(), "FrmAhorrosaFuturoLiquidacion"));
                            reciboEgreso.SubmitChanges();

                            #region Mvto egreso x anular liquidación de ahorro navideño
                            List<cuentaValores>[] cuotasValores = new blCuentaPar().gmtdCalcularValores("0001", decValorMulta);
                            List<cuentaValores> cuentasDebito = cuotasValores[0];
                            for (int a = 0; a < cuentasDebito.Count; a++)
                                reciboEgreso.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasDebito[a].decValor, 0, cuentasDebito[a].strCuenta, "Recibo de egreso x Anular liquidación de ahorro a futuro", 2, tobjCuentaLiquidad.strCedulaAho, strNombre + " " + strApellido, dtmFechaActual));
                            List<cuentaValores> cuentasCredito = cuotasValores[1];
                            for (int a = 0; a < cuentasCredito.Count; a++)
                                reciboEgreso.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasCredito[a].decValor, 0, cuentasCredito[a].strCuenta, "Recibo de egreso x Anular liquidación de ahorro a futuro", 1, tobjCuentaLiquidad.strCedulaAho, strNombre + " " + strApellido, dtmFechaActual));
                            #endregion
                        }
                    }

                    using (dbExequial2010DataContext ahorro = new dbExequial2010DataContext())
                    {
                        tblAhorrosNatilleraEscolar aho_old = ahorro.tblAhorrosNatilleraEscolars.SingleOrDefault(p => p.strCuenta == tobjCuentaLiquidad.strCuenta);
                        aho_old.bitLiquidada = false;
                        aho_old.dtmFechaLiquidada = Convert.ToDateTime("1900/01/01");
                        ahorro.tblLogdeActividades.InsertOnSubmit(tobjCuentaLiquidad.log);
                        ahorro.SubmitChanges();
                        strResultado = "Registro Anulado";
                    }

                    ts.Complete();
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                strResultado = "- Ocurrió un error al Actualizar el registro";
            }
            return strResultado;
        }

        /// <summary> Consulta todos los cuentas registradas. </summary>
        /// <returns> Un lista con todos las cuentas seleccionadas. </returns>
        public IList<AhorroNatilleraEscolar> gmtdConsultarTodos()
        {
            using (dbExequial2010DataContext ahorros = new dbExequial2010DataContext())
            {
                var query = from cue in ahorros.tblAhorrosNatilleraEscolars
                            join per in ahorros.tblAhorradores on cue.strCedulaAho equals per.strCedulaAho
                            where cue.bitAnulado == false && cue.bitLiquidada == false
                            select new { cue.strCuenta, cue.strCedulaAho, per.strNombreAho, per.strApellido1Aho, per.strApellido2Aho, cue.bitLiquidada, cue.dtmFechaCuenta, cue.dtmFechaLiquidada, cue.fltIntereses, cue.fltPremios, cue.fltValorCuota, cue.intAno, cue.intCuotas };

                List<AhorroNatilleraEscolar> lstAhorrosaFuturo = new List<AhorroNatilleraEscolar>();

                foreach (var dato in query.ToList())
                {
                    AhorroNatilleraEscolar aho = new AhorroNatilleraEscolar();
                    aho.bitLiquidada = dato.bitLiquidada;
                    aho.dtmFechaCuenta = dato.dtmFechaCuenta;
                    aho.dtmFechaLiquidada = dato.dtmFechaLiquidada;
                    aho.fltIntereses = dato.fltIntereses;
                    aho.fltPremios = dato.fltPremios;
                    aho.fltValorCuota = dato.fltValorCuota;
                    aho.strApellidoAho = dato.strApellido1Aho + " " + dato.strApellido2Aho;
                    aho.strCedulaAho = dato.strCedulaAho;
                    aho.strCuenta = dato.strCuenta;
                    aho.strNombreAho = dato.strNombreAho;
                    aho.intAno = dato.intAno;
                    aho.intCuotas = dato.intCuotas;
                    lstAhorrosaFuturo.Add(aho);
                }
                return lstAhorrosaFuturo;
            }
        }

        /// <summary> Consulta si una determinada cuenta tiene al menos una cuota paga. </summary>
        /// <param name="tstrCuenta">el código de la cuenta consultar.</param>
        /// <returns> un objeto del tipo tblAhorrosNatilleraEscolarDetalle. </returns>
        public tblAhorrosNatilleraEscolarDetalle gmtdConsultarDetalle(string tstrCuenta)
        {
            using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
            {
                var query = from cue in cuenta.tblAhorrosNatilleraEscolarDetalles
                            where cue.strCuenta == tstrCuenta && cue.bitPagada == true
                            select cue;

                if (query.ToList().Count > 0)
                    return query.ToList()[0];
                else
                    return new tblAhorrosNatilleraEscolarDetalle();
            }
        }

        /// <summary> Consulta una determinada cuenta. </summary>
        /// <param name="tstrCuenta">el código de la cuenta consultar.</param>
        /// <returns> un objeto del tipo tblAhorrosaFuturo. </returns>
        public tblAhorrosNatilleraEscolar gmtdConsultar(string tstrCuenta)
        {
            using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
            {
                var query = from cue in cuenta.tblAhorrosNatilleraEscolars
                            where cue.strCuenta == tstrCuenta && (cue.bitAnulado == false || cue.bitLiquidada == false)
                            select cue;

                if (query.ToList().Count > 0)
                {
                    return query.ToList()[0];
                }
                else
                {
                    return new tblAhorrosNatilleraEscolar();
                }
            }
        }

        /// <summary> Consulta una cuenta de un año. </summary>
        /// <param name="tstrCuenta">el código de la cuenta consultar.</param>
        /// <param name="tintAño">el año al que pertenece la cuenta.</param>
        /// <returns> un objeto del tipo tblAhorrosaFuturo. </returns>
        public tblAhorrosNatilleraEscolar gmtdConsultarxCuentayAño(string tstrCuenta, int tintAño)
        {
            using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
            {
                var query = from cue in cuenta.tblAhorrosNatilleraEscolars
                            where cue.strCuenta == tstrCuenta && cue.intAno == tintAño && (cue.bitAnulado == false || cue.bitLiquidada == false)
                            select cue;

                if (query.ToList().Count > 0)
                {
                    return query.ToList()[0];
                }
                else
                {
                    return new tblAhorrosNatilleraEscolar();
                }
            }
        }

        /// <summary> Consultas las cuotas pendientes de un ahorro navideño. </summary>
        /// <param name="tstrCedula"> Cédula del ahorrador a consultarle las cuotas pendientes. </param>
        /// <returns> </returns>
        public List<cuotasPendientesNatilleEscolar> gmtdConsultarCuotasPendintes(string tstrCedula)
        {
            using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
            {
                var query = from cue in cuenta.tblAhorrosNatilleraEscolars
                            join det in cuenta.tblAhorrosNatilleraEscolarDetalles on cue.strCuenta equals det.strCuenta
                            where cue.strCedulaAho == tstrCedula && cue.bitAnulado == false && cue.bitLiquidada == false && det.bitPagada == false
                            orderby det.dtmFechaCuota ascending
                            select new { det.dtmFechaCuota, cue.fltValorCuota, cue.strCuenta };

                List<cuotasPendientesNatilleEscolar> lstLista = new List<cuotasPendientesNatilleEscolar>();

                int intCont = 0;
                foreach (var dato in query)
                {
                    intCont++;
                    cuotasPendientesNatilleEscolar pendiente = new cuotasPendientesNatilleEscolar();
                    pendiente.intCuota = intCont;
                    pendiente.dtmFechaCuota = dato.dtmFechaCuota;
                    pendiente.decValorCuota = (decimal)dato.fltValorCuota;
                    pendiente.strCuenta = dato.strCuenta;
                    lstLista.Add(pendiente);
                }

                if (lstLista.Count > 0)
                {
                    return lstLista;
                }
                else
                {
                    return new List<cuotasPendientesNatilleEscolar>();
                }
            }

        }

        /// <summary>
        /// Consulta los datos activos de una determinada cuenta, esto se da por que la cuenta
        /// 0001 puede estar varias veces por pertenecer a varios años, pero solo esta activa 
        /// en un determinado año.
        /// </summary>
        /// <param name="tstrCuenta"> Código de la cuenta a consultar. </param>
        /// <returns> La cuenta consultada. </returns>
        public tblAhorrosNatilleraEscolar gmtdConsultarCuentaActiva(string tstrCuenta)
        {
            using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
            {
                var query = from cue in cuenta.tblAhorrosNatilleraEscolars
                            where cue.strCuenta == tstrCuenta && cue.bitAnulado == false && cue.bitLiquidada == false
                            select cue;

                if (query.ToList().Count > 0)
                {
                    return query.ToList()[0];
                }
                else
                {
                    return new tblAhorrosNatilleraEscolar();
                }
            }
        }

        /// <summary> Elimina una cuenta de ahorro a futuro. </summary>
        /// <param name="tobjAhorrosaFuturo"> Un objeto del tipo tblAhorrosaFuturo. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblAhorrosNatilleraEscolar tobjAhorrosNavideno)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
                {
                    tblAhorrosNatilleraEscolar cue_old = cuenta.tblAhorrosNatilleraEscolars.SingleOrDefault(p => p.strCuenta == tobjAhorrosNavideno.strCuenta);
                    cue_old.bitAnulado = true;
                    cue_old.dtmAnulado = DateTime.Now;
                    cuenta.tblLogdeActividades.InsertOnSubmit(tobjAhorrosNavideno.log);
                    cuenta.SubmitChanges();
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
    }
}
