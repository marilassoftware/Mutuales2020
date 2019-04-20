using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libMutuales2020.dominio;
using libMutuales2020.logica;
using System.Transactions;
using System.Data;
using System.Xml;
using System.Data.SqlClient;
using libMutuales2020.Recursos;
using libMutuales2020.Utilidades;

namespace libMutuales2020.dao
{
    class daoAhorrosaFuturo
    {
        /// <summary> Inserta una cuenta de ahorro a futuro. </summary>
        /// <param name="tobjAhorroaFuturo"> Un objeto del tipo ahorro a futuro. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblAhorrosaFuturo tobjAhorroaFuturo)
        {
            String strRetornar;
            try
            {
                using (dbExequial2010DataContext ahorros = new dbExequial2010DataContext())
                {
                    ahorros.tblAhorrosaFuturos.InsertOnSubmit(tobjAhorroaFuturo);
                    ahorros.tblLogdeActividades.InsertOnSubmit(tobjAhorroaFuturo.log);
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

        /// <summary> Consulta los datos de la liquidación de una cuenta de ahorro a futuro. </summary>
        /// <param name="tstrCuenta"> Cuenta de la que se desea conocer los datos de liquidación. </param>
        /// <returns> Un objeto con los datos de la liquidacion. </returns>
        public LiquidacionAhorroaFuturo gmtdCalcularLiquidacionAhorroaFuturo(string tstrCuenta)
        {
            LiquidacionAhorroaFuturo liquidacion = new LiquidacionAhorroaFuturo();

            using (dbExequial2010DataContext ahorros = new dbExequial2010DataContext())
            {
                var query = from det in ahorros.tblAhorrosaFuturoDetalles
                            where det.bitPagada == true && det.strCuenta == tstrCuenta
                            select det;

                int intCuotasPagadas = query.ToList().Count;


                var query1 = from cue in ahorros.tblAhorrosaFuturos
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
                    liquidacion.strCedulaAho = dato.strCedulaAho;
                }
                return liquidacion;
            }
        }

        /// <summary> Registra la liquidación de una cuenta de ahorro a futuro. </summary>
        /// <param name="tstrCuenta"> Cuenta de ahorro a futuro a liquidar. </param>
        /// <returns> Un string que indica si se registro o no la liquidación. </returns>
        public string gmtdLiquidarAhorroaFuturo(LiquidacionAhorroaFuturo tobjLiquidacion)
        {
            string strResultado = "";
            string strIngreso = "";
            string strEgreso = "";
            DateTime dtmFechaActual;
            tblEgreso egreso = new tblEgreso();
            tblIngreso ingreso = new tblIngreso();
            DataTable dt = new DataTable();

            tblEgresosAhorrosaFuturoLiquidacion egresoLiquidacionaFuturo = new tblEgresosAhorrosaFuturoLiquidacion();

            try
            {
                egresoLiquidacionaFuturo.decValorLiquidacion = tobjLiquidacion.decTotalRecaudado;
                egresoLiquidacionaFuturo.strCuenta = tobjLiquidacion.strCuenta;
                egresoLiquidacionaFuturo.decDescuento = tobjLiquidacion.decDescuento;

                egreso.bitRetiroAhorroaFuturoLiquidacion = true;
                egreso.decTotal = tobjLiquidacion.decTotalRecaudado;
                egreso.dtmFechaAnu = Convert.ToDateTime("1/1/1900");
                dtmFechaActual = new daoUtilidadesConfiguracion().gmtdCapturarFechadelServidor();
                egreso.dtmFechaRec = dtmFechaActual;
                egreso.strApellido = "";
                egreso.strCedulaEgre = tobjLiquidacion.strCedulaAho;
                egreso.strFormulario = tobjLiquidacion.strFormulario;
                egreso.strLetras = new blConfiguracion().montoenLetras(tobjLiquidacion.decTotalLiquidacion.ToString());
                egreso.strNombre = tobjLiquidacion.strAhorrador;
                egreso.objEgresosAhorrosaFuturoLiquidacion = egresoLiquidacionaFuturo;

                if (egresoLiquidacionaFuturo.decDescuento > 0)
                {
                    tblIngresosAhorrosaFuturoMulta ingresoaFuturoMulta = new tblIngresosAhorrosaFuturoMulta();
                    ingresoaFuturoMulta.decValorMulta = tobjLiquidacion.decDescuento;
                    ingresoaFuturoMulta.strCuenta = tobjLiquidacion.strCuenta;

                    ingreso.bitAhorroaFuturoMulta = true;
                    ingreso.decTotalIng = tobjLiquidacion.decDescuento;
                    ingreso.dtmFechaAnu = Convert.ToDateTime("1/1/1900");
                    ingreso.dtmFechaRec = dtmFechaActual;
                    ingreso.strCedulaIng = tobjLiquidacion.strCedulaAho;
                    ingreso.strComputador = tobjLiquidacion.strComputador;
                    ingreso.strFormulario = tobjLiquidacion.strFormulario; ;
                    ingreso.strLetras = new blConfiguracion().montoenLetras(tobjLiquidacion.decDescuento.ToString());
                    ingreso.strNombreIng = tobjLiquidacion.strAhorrador;
                    ingreso.strApellidoIng = "";
                    ingreso.strUsuario = tobjLiquidacion.strUsuario;
                    ingreso.objIngresosAhorrosaFuturoMulta = ingresoaFuturoMulta;
                    egreso.objIngreso = ingreso;
                }

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
                return "- Ocurrió un error al Actualizar el registro";
            }

            strEgreso = dt.Rows[0]["intCodigoEgr"].ToString();
            strIngreso = dt.Rows[0]["intCodigoIng"].ToString();

            if (egresoLiquidacionaFuturo.decDescuento > 0)
            {
                strResultado = "Se hace el registro de los siguientes recibos" + " \n " + strEgreso + " \n " + strIngreso;
            }
            else
            {
                strResultado = "Se hace el registro del siguiente egreso" + " \n " + strEgreso;
            }
            return strResultado;
        }

        /// <summary> Consulta los datos de una cuenta si esta esta liquidada. </summary>
        /// <param name="tstrCuenta"> Código de la cuenta a consultar. </param>
        /// <returns> Un objeto del tipo LiquidacionAhorroaFuturo. </returns>
        public LiquidacionAhorroaFuturo gmtdConsultarCuentaLiquidada(string tstrCuenta)
        {
            using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
            {
                var query = from cue in cuenta.tblAhorrosaFuturos
                            where cue.strCuenta == tstrCuenta && cue.bitLiquidada == true && cue.bitAnulado == false
                            select cue;

                if (query.ToList().Count > 0)
                {
                    LiquidacionAhorroaFuturo cuen = new LiquidacionAhorroaFuturo();
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
                    return new LiquidacionAhorroaFuturo();
                }
            }

        }

        /// <summary> Elimina la liquidación de una cuenta de ahorro a futuro. </summary>
        /// <param name="tobjCuentaLiquidad"> Un objeto con el código de la cuenta a aliminar. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEliminarLiquidaciondeCuenta(LiquidacionAhorroaFuturo tobjCuentaLiquidad)
        {
            DateTime dtmFechaActual = new blConfiguracion().gmtdCapturarFechadelServidor();
            String strResultado;
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

                        #region Mvto ingreso x anular liquidación de ahorro a futuro
                        List<cuentaValores>[] cuotasValores = new blCuentaPar().gmtdCalcularValores("0001", decValorLiquidacion);
                        List<cuentaValores> cuentasDebito = cuotasValores[0];
                        for (int a = 0; a < cuentasDebito.Count; a++)
                            reciboEgreso.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasDebito[a].decValor, 0, cuentasDebito[a].strCuenta, "Recibo de ingreso x Anular liquidación de ahorro a futuro", 1, tobjCuentaLiquidad.strCedulaAho, strNombre + " " + strApellido, dtmFechaActual));
                        List<cuentaValores> cuentasCredito = cuotasValores[1];
                        for (int a = 0; a < cuentasCredito.Count; a++)
                            reciboEgreso.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasCredito[a].decValor, 0, cuentasCredito[a].strCuenta, "Recibo de ingreso x Anular liquidación de ahorro a futuro", 2, tobjCuentaLiquidad.strCedulaAho, strNombre + " " + strApellido, dtmFechaActual));
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
                                reciboEgreso.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasDebito[a].decValor, 0, cuentasDebito[a].strCuenta, "Recibo de egreso x Anular liquidación de ahorro navideño", 2, tobjCuentaLiquidad.strCedulaAho, strNombre + " " + strApellido, dtmFechaActual));
                            List<cuentaValores> cuentasCredito = cuotasValores[1];
                            for (int a = 0; a < cuentasCredito.Count; a++)
                                reciboEgreso.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasCredito[a].decValor, 0, cuentasCredito[a].strCuenta, "Recibo de egreso x Anular liquidación de ahorro navideño", 1, tobjCuentaLiquidad.strCedulaAho, strNombre + " " + strApellido, dtmFechaActual));
                            #endregion
                        }
                    }

                    using (dbExequial2010DataContext ahorro = new dbExequial2010DataContext())
                    {
                        tblAhorrosaFuturo aho_old = ahorro.tblAhorrosaFuturos.SingleOrDefault(p => p.strCuenta == tobjCuentaLiquidad.strCuenta);
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
        public IList<AhorroaFuturo> gmtdConsultarTodos()
        {
            using (dbExequial2010DataContext ahorros = new dbExequial2010DataContext())
            {
                var query = from cue in ahorros.tblAhorrosaFuturos
                            join per in ahorros.tblAhorradores on cue.strCedulaAho equals per.strCedulaAho
                            where cue.bitAnulado == false && cue.bitLiquidada == false
                            select new { cue.strCuenta, cue.strCedulaAho, per.strNombreAho, per.strApellido1Aho, per.strApellido2Aho, cue.bitLiquidada, cue.dtmFechaCuenta, cue.dtmFechaLiquidada, cue.fltIntereses, cue.fltPremios, cue.fltValorCuota, cue.intAno, cue.intCuotas };

                List<AhorroaFuturo> lstAhorrosaFuturo = new List<AhorroaFuturo>();

                foreach (var dato in query.ToList())
                {
                    AhorroaFuturo aho = new AhorroaFuturo();
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
        /// <returns> un objeto del tipo tblAhorrosaFuturo. </returns>
        public tblAhorrosaFuturoDetalle gmtdConsultarDeatlle(string tstrCuenta)
        {
            using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
            {
                var query = from cue in cuenta.tblAhorrosaFuturoDetalles
                            where cue.strCuenta == tstrCuenta && cue.bitPagada == true
                            select cue;

                if (query.ToList().Count > 0)
                    return query.ToList()[0];
                else
                    return new tblAhorrosaFuturoDetalle();
            }
        }

        /// <summary> Consulta una determinada cuenta. </summary>
        /// <param name="tstrCuenta">el código de la cuenta consultar.</param>
        /// <returns> un objeto del tipo tblAhorrosaFuturo. </returns>
        public tblAhorrosaFuturo gmtdConsultar(string tstrCuenta)
        {
            using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
            {
                var query = from cue in cuenta.tblAhorrosaFuturos
                            where cue.strCuenta == tstrCuenta && (cue.bitAnulado == false || cue.bitLiquidada == false)
                            select cue;

                if (query.ToList().Count > 0)
                    return query.ToList()[0];
                else
                    return new tblAhorrosaFuturo();
            }
        }

        /// <summary> Consultas las cuotas pendientes de un ahorro a futuro. </summary>
        /// <param name="tstrCedula"> Cédula del ahorrador a consultarle las cuotas pendientes. </param>
        /// <returns> </returns>
        public List<cuotasPendientes> gmtdConsultarCuotasPendentes(string tstrCedula)
        {
            using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
            {
                var query = from cue in cuenta.tblAhorrosaFuturos
                            join det in cuenta.tblAhorrosaFuturoDetalles on cue.strCuenta equals det.strCuenta
                            where cue.strCedulaAho == tstrCedula && cue.bitAnulado == false && cue.bitLiquidada == false && det.bitPagada == false
                            orderby det.dtmFechaCuota ascending
                            select new { det.dtmFechaCuota, cue.fltValorCuota, cue.strCuenta };

                List<cuotasPendientes> lstLista = new List<cuotasPendientes>();

                int intCont = 0;
                foreach (var dato in query)
                {
                    intCont++;
                    cuotasPendientes pendiente = new cuotasPendientes();
                    pendiente.intCuota = intCont;
                    pendiente.dtmFechaCuota = dato.dtmFechaCuota;
                    pendiente.decValorCuota = (decimal)dato.fltValorCuota;
                    pendiente.strCuenta = dato.strCuenta;
                    lstLista.Add(pendiente);
                }

                if (lstLista.Count > 0)
                    return lstLista;
                else
                    return new List<cuotasPendientes>();
            }

        }

        /// <summary> Elimina una cuenta de ahorro a futuro. </summary>
        /// <param name="tobjAhorrosaFuturo"> Un objeto del tipo tblAhorrosaFuturo. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblAhorrosaFuturo tobjAhorrosaFuturo)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
                {
                    tblAhorrosaFuturo cue_old = cuenta.tblAhorrosaFuturos.SingleOrDefault(p => p.strCuenta == tobjAhorrosaFuturo.strCuenta);
                    cue_old.bitAnulado = true;
                    cue_old.dtmAnulado = DateTime.Now;
                    cuenta.tblLogdeActividades.InsertOnSubmit(tobjAhorrosaFuturo.log);
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
