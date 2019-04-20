namespace libMutuales2020.dao
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
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

    class daoRecibosIngresos
    {
        /// <summary> Inserta una cuenta de ahorro a futuro. </summary>
        /// <param name="tobjIngreso"> Un objeto del tipo ingreso. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(XmlDocument xml)
        {
            String strRetornar;
            try
            {
                List<SqlParameter> lstParametros = new List<SqlParameter>();
                SqlParameter objParameter = new SqlParameter();
                objParameter.DbType = DbType.Xml;
                objParameter.Direction = ParameterDirection.Input;
                objParameter.ParameterName = "xmlIngreso";
                objParameter.Value = xml.OuterXml;
                lstParametros.Add(objParameter);

                return new Utilidad().ejecutarSpConeccionDB(lstParametros, Sp.spIngresoInsertar).Rows[0]["intCodigoIng"].ToString();
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                strRetornar = "0";
            }
            return strRetornar;
        }

        /// <summary> Migra los recibos anteriores </summary>
        /// <param name="tobjIngreso"> el recibo </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdMigrarRecibos(tblIngreso tobjIngreso)
        {
            string strRetornar = "";
            try
            {
                using (dbExequial2010DataContext recibosIngresos = new dbExequial2010DataContext())
                {
                    #region Mvto Ingreso Cuota
                    if (tobjIngreso.ingresoCuota != null)
                    {
                        List<cuentaValores>[] cuotasValores = new blCuentaPar().gmtdCalcularValores(tobjIngreso.ingresoCuota.strCodigoPar, tobjIngreso.ingresoCuota.intTotal);

                        List<cuentaValores> cuentasDebito = cuotasValores[1];
                        for (int a = 0; a < cuentasDebito.Count; a++)
                            recibosIngresos.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasDebito[a].decValor, tobjIngreso.intCodigoIng, cuentasDebito[a].strCuenta, "Cuota exequial", 1, tobjIngreso.strCedulaIng, tobjIngreso.strNombreIng + " " + tobjIngreso.strApellidoIng, tobjIngreso.dtmFechaRec));

                        List<cuentaValores> cuentasCredito = cuotasValores[0];
                        for (int a = 0; a < cuentasCredito.Count; a++)
                            recibosIngresos.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasCredito[a].decValor, tobjIngreso.intCodigoIng, cuentasCredito[a].strCuenta, "Cuota exequial.", 2, tobjIngreso.strCedulaIng, tobjIngreso.strNombreIng + " " + tobjIngreso.strApellidoIng, tobjIngreso.dtmFechaRec));
                    }
                    #endregion

                    #region Mvto Ingreso Prestamo
                    if (tobjIngreso.ingresoPrestamo != null)
                    {
                        for (int b = 0; b < tobjIngreso.ingresoPrestamo.Count; b++)
                        {
                            List<cuentaValores>[] cuotasValores = new blCuentaPar().gmtdCalcularValores(tobjIngreso.ingresoPrestamo[0].strParCapital, tobjIngreso.ingresoPrestamo[b].decCapital);
                            List<cuentaValores> cuentasDebito = cuotasValores[0];
                            for (int a = 0; a < cuentasDebito.Count; a++)
                                recibosIngresos.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasDebito[a].decValor, tobjIngreso.intCodigoIng, cuentasDebito[a].strCuenta, "Credito Capital.", 1, tobjIngreso.strCedulaIng, tobjIngreso.strNombreIng + " " + tobjIngreso.strApellidoIng, tobjIngreso.dtmFechaRec));
                            List<cuentaValores> cuentasCredito = cuotasValores[1];
                            for (int a = 0; a < cuentasCredito.Count; a++)
                                recibosIngresos.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasCredito[a].decValor, tobjIngreso.intCodigoIng, cuentasCredito[a].strCuenta, "Credito Capital.", 2, tobjIngreso.strCedulaIng, tobjIngreso.strNombreIng + " " + tobjIngreso.strApellidoIng, tobjIngreso.dtmFechaRec));

                            cuotasValores = new blCuentaPar().gmtdCalcularValores(tobjIngreso.ingresoPrestamo[0].strParCapital, tobjIngreso.ingresoPrestamo[b].decInteres);
                            cuentasDebito = cuotasValores[0];
                            for (int a = 0; a < cuentasDebito.Count; a++)
                                recibosIngresos.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasDebito[a].decValor, tobjIngreso.intCodigoIng, cuentasDebito[a].strCuenta, "Credito Intereses.", 1, tobjIngreso.strCedulaIng, tobjIngreso.strNombreIng + " " + tobjIngreso.strApellidoIng, tobjIngreso.dtmFechaRec));
                            cuentasCredito = cuotasValores[1];
                            for (int a = 0; a < cuentasCredito.Count; a++)
                                recibosIngresos.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasCredito[a].decValor, tobjIngreso.intCodigoIng, cuentasCredito[a].strCuenta, "Credito Intereses.", 2, tobjIngreso.strCedulaIng, tobjIngreso.strNombreIng + " " + tobjIngreso.strApellidoIng, tobjIngreso.dtmFechaRec));

                            cuotasValores = new blCuentaPar().gmtdCalcularValores(tobjIngreso.ingresoPrestamo[0].strParCapital, tobjIngreso.ingresoPrestamo[b].decMora);
                            cuentasDebito = cuotasValores[0];
                            for (int a = 0; a < cuentasDebito.Count; a++)
                                recibosIngresos.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasDebito[a].decValor, tobjIngreso.intCodigoIng, cuentasDebito[a].strCuenta, "Credito Mora.", 1, tobjIngreso.strCedulaIng, tobjIngreso.strNombreIng + " " + tobjIngreso.strApellidoIng, tobjIngreso.dtmFechaRec));
                            cuentasCredito = cuotasValores[1];
                            for (int a = 0; a < cuentasCredito.Count; a++)
                                recibosIngresos.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasCredito[a].decValor, tobjIngreso.intCodigoIng, cuentasCredito[a].strCuenta, "Credito Mora.", 2, tobjIngreso.strCedulaIng, tobjIngreso.strNombreIng + " " + tobjIngreso.strApellidoIng, tobjIngreso.dtmFechaRec));
                        }
                    }
                    #endregion

                    #region Mvto Ingreso Ahorro a la Vista
                    if (tobjIngreso.ingresoAhorro != null)
                    {
                        List<cuentaValores>[] cuotasValores = new blCuentaPar().gmtdCalcularValores(tobjIngreso.ingresoAhorro.strCodigoPar, tobjIngreso.ingresoAhorro.decAhorro);
                        List<cuentaValores> cuentasDebito = cuotasValores[0];
                        for (int a = 0; a < cuentasDebito.Count; a++)
                            recibosIngresos.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasDebito[a].decValor, tobjIngreso.intCodigoIng, cuentasDebito[a].strCuenta, "Ahorro a la vista.", 1, tobjIngreso.strCedulaIng, tobjIngreso.strNombreIng + " " + tobjIngreso.strApellidoIng, tobjIngreso.dtmFechaRec));
                        List<cuentaValores> cuentasCredito = cuotasValores[1];
                        for (int a = 0; a < cuentasCredito.Count; a++)
                            recibosIngresos.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasCredito[a].decValor, tobjIngreso.intCodigoIng, cuentasCredito[a].strCuenta, "Ahorro a la vista.", 2, tobjIngreso.strCedulaIng, tobjIngreso.strNombreIng + " " + tobjIngreso.strApellidoIng, tobjIngreso.dtmFechaRec));
                    }
                    #endregion

                    #region Mvto Ingreso Ahorro Estudiantil
                    if (tobjIngreso.ingresoAhorroEstudiantil != null)
                    {
                        List<cuentaValores>[] cuotasValores = new blCuentaPar().gmtdCalcularValores(tobjIngreso.ingresoAhorroEstudiantil.strCodigoPar, tobjIngreso.ingresoAhorroEstudiantil.decAhorro);
                        List<cuentaValores> cuentasDebito = cuotasValores[0];
                        for (int a = 0; a < cuentasDebito.Count; a++)
                            recibosIngresos.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasDebito[a].decValor, tobjIngreso.intCodigoIng, cuentasDebito[a].strCuenta, "Ahorro estudiantil", 1, tobjIngreso.strCedulaIng, tobjIngreso.strNombreIng + " " + tobjIngreso.strApellidoIng, tobjIngreso.dtmFechaRec));
                        List<cuentaValores> cuentasCredito = cuotasValores[1];
                        for (int a = 0; a < cuentasCredito.Count; a++)
                            recibosIngresos.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasCredito[a].decValor, tobjIngreso.intCodigoIng, cuentasCredito[a].strCuenta, "Ahorro estudiantil", 2, tobjIngreso.strCedulaIng, tobjIngreso.strNombreIng + " " + tobjIngreso.strApellidoIng, tobjIngreso.dtmFechaRec));
                    }
                    #endregion

                    #region Mvto Ingreso Ahorro Fijo
                    if (tobjIngreso.ingresoAhorroFijo != null)
                    {
                        List<cuentaValores>[] cuotasValores = new blCuentaPar().gmtdCalcularValores(tobjIngreso.ingresoAhorroFijo.strCodigoPar, tobjIngreso.ingresoAhorroFijo.decAhorro);
                        List<cuentaValores> cuentasDebito = cuotasValores[0];
                        for (int a = 0; a < cuentasDebito.Count; a++)
                            recibosIngresos.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasDebito[a].decValor, tobjIngreso.intCodigoIng, cuentasDebito[a].strCuenta, "Ahorro Fijo.", 1, tobjIngreso.strCedulaIng, tobjIngreso.strNombreIng + " " + tobjIngreso.strApellidoIng, tobjIngreso.dtmFechaRec));
                        List<cuentaValores> cuentasCredito = cuotasValores[1];
                        for (int a = 0; a < cuentasCredito.Count; a++)
                            recibosIngresos.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasCredito[a].decValor, tobjIngreso.intCodigoIng, cuentasCredito[a].strCuenta, "Ahorro Fijo.", 2, tobjIngreso.strCedulaIng, tobjIngreso.strNombreIng + " " + tobjIngreso.strApellidoIng, tobjIngreso.dtmFechaRec));
                    }
                    #endregion

                    #region Mvto Ingreso Ahorro CDT
                    if (tobjIngreso.ingresoAhorroCdt != null)
                    {
                        List<cuentaValores>[] cuotasValores = new blCuentaPar().gmtdCalcularValores(tobjIngreso.ingresoAhorroCdt.strCodigoPar, tobjIngreso.ingresoAhorroFijo.decAhorro);
                        List<cuentaValores> cuentasDebito = cuotasValores[0];
                        for (int a = 0; a < cuentasDebito.Count; a++)
                            recibosIngresos.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasDebito[a].decValor, tobjIngreso.intCodigoIng, cuentasDebito[a].strCuenta, "Ahorro CDT", 1, tobjIngreso.strCedulaIng, tobjIngreso.strNombreIng + " " + tobjIngreso.strApellidoIng, tobjIngreso.dtmFechaRec));
                        List<cuentaValores> cuentasCredito = cuotasValores[1];
                        for (int a = 0; a < cuentasCredito.Count; a++)
                            recibosIngresos.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasCredito[a].decValor, tobjIngreso.intCodigoIng, cuentasCredito[a].strCuenta, "Ahorro CDT", 2, tobjIngreso.strCedulaIng, tobjIngreso.strNombreIng + " " + tobjIngreso.strApellidoIng, tobjIngreso.dtmFechaRec));
                    }
                    #endregion

                    #region Mvto Ingreso Ahorro Navideño
                    if (tobjIngreso.ingresoAhorroNavideño != null)
                    {
                        for (int b = 0; b < tobjIngreso.ingresoAhorroNavideño.Count; b++)
                        {
                            List<cuentaValores>[] cuotasValores = new blCuentaPar().gmtdCalcularValores(tobjIngreso.ingresoAhorroNavideño[b].strCodigoPar, tobjIngreso.ingresoAhorroNavideño[b].decValorCuo);
                            List<cuentaValores> cuentasDebito = cuotasValores[0];
                            for (int a = 0; a < cuentasDebito.Count; a++)
                                recibosIngresos.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasDebito[a].decValor, tobjIngreso.intCodigoIng, cuentasDebito[a].strCuenta, "Ahorro Navideño.", 1, tobjIngreso.strCedulaIng, tobjIngreso.strNombreIng + " " + tobjIngreso.strApellidoIng, tobjIngreso.dtmFechaRec));
                            List<cuentaValores> cuentasCredito = cuotasValores[1];
                            for (int a = 0; a < cuentasCredito.Count; a++)
                                recibosIngresos.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasCredito[a].decValor, tobjIngreso.intCodigoIng, cuentasCredito[a].strCuenta, "Ahorro Navideño.", 2, tobjIngreso.strCedulaIng, tobjIngreso.strNombreIng + " " + tobjIngreso.strApellidoIng, tobjIngreso.dtmFechaRec));
                        }
                    }
                    #endregion

                    #region Mvto Ingreso Ahorro a futuro
                    if (tobjIngreso.ingresoAhorroaFuturo != null)
                    {
                        for (int b = 0; b < tobjIngreso.ingresoAhorroaFuturo.Count; b++)
                        {
                            List<cuentaValores>[] cuotasValores = new blCuentaPar().gmtdCalcularValores(tobjIngreso.ingresoAhorroaFuturo[b].strCodigoPar, tobjIngreso.ingresoAhorroaFuturo[b].decValorCuo);
                            List<cuentaValores> cuentasDebito = cuotasValores[0];
                            for (int a = 0; a < cuentasDebito.Count; a++)
                                recibosIngresos.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasDebito[a].decValor, tobjIngreso.intCodigoIng, cuentasDebito[a].strCuenta, "Ahorro a futuro.", 1, tobjIngreso.strCedulaIng, tobjIngreso.strNombreIng + " " + tobjIngreso.strApellidoIng, tobjIngreso.dtmFechaRec));
                            List<cuentaValores> cuentasCredito = cuotasValores[1];
                            for (int a = 0; a < cuentasCredito.Count; a++)
                                recibosIngresos.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasCredito[a].decValor, tobjIngreso.intCodigoIng, cuentasCredito[a].strCuenta, "Ahorro a futuro.", 2, tobjIngreso.strCedulaIng, tobjIngreso.strNombreIng + " " + tobjIngreso.strApellidoIng, tobjIngreso.dtmFechaRec));
                        }
                    }
                    #endregion

                    #region Mvto Ingreso Otros Ingresos
                    if (tobjIngreso.ingresoOtrosIngresos != null)
                    {
                        for (int b = 0; b < tobjIngreso.ingresoOtrosIngresos.Count; b++)
                        {
                            List<cuentaValores>[] cuotasValores = new blCuentaPar().gmtdCalcularValores(tobjIngreso.ingresoOtrosIngresos[b].strCodigoPar, tobjIngreso.ingresoOtrosIngresos[b].decValor);
                            List<cuentaValores> cuentasDebito = cuotasValores[0];
                            for (int a = 0; a < cuentasDebito.Count; a++)
                                recibosIngresos.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasDebito[a].decValor, tobjIngreso.intCodigoIng, cuentasDebito[a].strCuenta, "Ing Otro " + tobjIngreso.ingresoOtrosIngresos[b].strCodOtrosIngresos, 1, tobjIngreso.strCedulaIng, tobjIngreso.strNombreIng + " " + tobjIngreso.strApellidoIng, tobjIngreso.dtmFechaRec));
                            List<cuentaValores> cuentasCredito = cuotasValores[1];
                            for (int a = 0; a < cuentasCredito.Count; a++)
                                recibosIngresos.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasCredito[a].decValor, tobjIngreso.intCodigoIng, cuentasCredito[a].strCuenta, "Ing Otro " + tobjIngreso.ingresoOtrosIngresos[b].strCodOtrosIngresos, 2, tobjIngreso.strCedulaIng, tobjIngreso.strNombreIng + " " + tobjIngreso.strApellidoIng, tobjIngreso.dtmFechaRec));
                        }
                    }
                    #endregion

                    #region Mvto Ingreso Abono a Prestamos
                    if (tobjIngreso.ingresoAbonoaPrestamo != null)
                    {
                        List<cuentaValores>[] cuotasValores = new blCuentaPar().gmtdCalcularValores(tobjIngreso.ingresoAbonoaPrestamo.strCodigoPar, tobjIngreso.ingresoAbonoaPrestamo.decAbonoPrestamo);
                        List<cuentaValores> cuentasDebito = cuotasValores[0];
                        for (int a = 0; a < cuentasDebito.Count; a++)
                            recibosIngresos.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasDebito[a].decValor, tobjIngreso.intCodigoIng, cuentasDebito[a].strCuenta, "Abono a préstamo", 1, tobjIngreso.strCedulaIng, tobjIngreso.strNombreIng + " " + tobjIngreso.strApellidoIng, tobjIngreso.dtmFechaRec));
                        List<cuentaValores> cuentasCredito = cuotasValores[1];
                        for (int a = 0; a < cuentasCredito.Count; a++)
                            recibosIngresos.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasCredito[a].decValor, tobjIngreso.intCodigoIng, cuentasCredito[a].strCuenta, "Abono a préstamo", 2, tobjIngreso.strCedulaIng, tobjIngreso.strNombreIng + " " + tobjIngreso.strApellidoIng, tobjIngreso.dtmFechaRec));
                    }
                    #endregion

                    #region Mvto Ingreso Abono a Venta
                    if (tobjIngreso.ingresoAbonoaVenta != null)
                    {
                        List<cuentaValores>[] cuotasValores = new blCuentaPar().gmtdCalcularValores(tobjIngreso.ingresoAbonoaVenta.strCodigoPar, tobjIngreso.ingresoAbonoaVenta.decAbona);
                        List<cuentaValores> cuentasDebito = cuotasValores[0];
                        for (int a = 0; a < cuentasDebito.Count; a++)
                            recibosIngresos.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasDebito[a].decValor, tobjIngreso.intCodigoIng, cuentasDebito[a].strCuenta, "Abono a venta.", 1, tobjIngreso.strCedulaIng, tobjIngreso.strNombreIng + " " + tobjIngreso.strApellidoIng, tobjIngreso.dtmFechaRec));
                        List<cuentaValores> cuentasCredito = cuotasValores[1];
                        for (int a = 0; a < cuentasCredito.Count; a++)
                            recibosIngresos.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasCredito[a].decValor, tobjIngreso.intCodigoIng, cuentasCredito[a].strCuenta, "Abono a venta.", 2, tobjIngreso.strCedulaIng, tobjIngreso.strNombreIng + " " + tobjIngreso.strApellidoIng, tobjIngreso.dtmFechaRec));
                    }
                    #endregion

                    #region Mvto Ingreso Abono a Deuda
                    if (tobjIngreso.ingresoAbonoaDeuda != null)
                    {
                        for (int b = 0; b < tobjIngreso.ingresoAbonoaDeuda.Count; b++)
                        {
                            List<cuentaValores>[] cuotasValores = new blCuentaPar().gmtdCalcularValores(tobjIngreso.ingresoAbonoaDeuda[b].strCodigoPar, tobjIngreso.ingresoAbonoaDeuda[b].decAbona);
                            List<cuentaValores> cuentasDebito = cuotasValores[0];
                            for (int a = 0; a < cuentasDebito.Count; a++)
                                recibosIngresos.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasDebito[a].decValor, tobjIngreso.intCodigoIng, cuentasDebito[a].strCuenta, "Abono a deuda.", 1, tobjIngreso.strCedulaIng, tobjIngreso.strNombreIng + " " + tobjIngreso.strApellidoIng, tobjIngreso.dtmFechaRec));
                            List<cuentaValores> cuentasCredito = cuotasValores[1];
                            for (int a = 0; a < cuentasCredito.Count; a++)
                                recibosIngresos.tblCuentasOperacionesContabilidads.InsertOnSubmit(new blRecibosIngresos().gmtdMvtoContableIngresos(cuentasCredito[a].decValor, tobjIngreso.intCodigoIng, cuentasCredito[a].strCuenta, "Abono a deuda.", 2, tobjIngreso.strCedulaIng, tobjIngreso.strNombreIng + " " + tobjIngreso.strApellidoIng, tobjIngreso.dtmFechaRec));
                        }
                    }
                    #endregion

                    recibosIngresos.SubmitChanges();

                    strRetornar = "Registro Guardado. ";
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                strRetornar = "- Ocurrió un error al insertar el registro. ::: " + tobjIngreso.intCodigoIng.ToString() + " ::: Mensaje " + ex.Message;
            }
            return strRetornar;

        }

        /// <summary> Inserta el nùmero de rifa </summary>
        /// <param name="tintCodigoSoc"> Socio al que se le va a registrar el nùmero de rifa. </param>
        /// <param name="tintAño"> Año al que se le va a registrar el nùmero de la rifa. </param>
        /// <param name="tintMes"> Mes al que se le va a registrar el nùmero de la rifa. </param>
        public void gmtdIngresarNumeroRifa(int tintCodigoSoc, int tintAño, int tintMes)
        {
            using (dbExequial2010DataContext ahorros = new dbExequial2010DataContext())
            {
                ahorros.ExecuteCommand("Exec spNumerodeRifa " + tintCodigoSoc.ToString() + ", " + tintMes.ToString() + ", " + tintAño.ToString() + ", '02'");
            }
        }

        /// <summary> Consulta si un socio para un año y mes determinado ya tiene nùmero de rifa </summary>
        /// <param name="tintCodigoSoc"> Còdigo del socio a consultar. </param>
        /// <param name="tintAño"> Año a evaluar el nùmero para la rifa. </param>
        /// <param name="tintMes"> Mes a evaluar para la rifa. </param>
        /// <returns> Un string que indica el nùmero de la rifa o un '-' si no tiene. </returns>
        public string gmtdConsultarNumeroRifa(int tintCodigoSoc, int tintAño, int tintMes)
        {
            using (dbExequial2010DataContext rifas = new dbExequial2010DataContext())
            {
                var query = from rifa in rifas.tblNumerosRifas
                            where rifa.bitSocio == true && rifa.intAno == tintAño && rifa.intCodigoSoc == tintCodigoSoc && rifa.intMes == tintMes
                            select rifa;
                if (query.ToList().Count > 0)
                    return query.ToList()[0].intNumeroRifa.ToString();
                else
                    return "-1";
            }
        }

        /// <summary> Consulta las transacciones de un determinado ahorrador. </summary>
        /// <param name="tstrCedulaAho"> Cédula del ahorrador al que se le va a consultar las transacciones. </param>
        /// <returns> Lista de transacciones seleccionadas. </returns>
        public List<tblAhorrosTransaccione> gmtdConsultarTransacciones(string tstrCedulaAho)
        {
            using (dbExequial2010DataContext recibosIngresos = new dbExequial2010DataContext())
            {
                var query = (from soc in recibosIngresos.tblAhorrosTransacciones
                             where soc.bitMuestra == true && soc.strCedulaAho == tstrCedulaAho
                             orderby soc.dtmFechaTra descending
                             select soc).Take(10);

                return query.ToList();
            }

        }

        /// <summary> Consulta las transacciones estudiantiles de un determinado ahorrador. </summary>
        /// <param name="tstrCedulaAho"> Cédula del ahorrador al que se le va a consultar las transacciones. </param>
        /// <returns> Lista de transacciones seleccionadas. </returns>
        public List<tblAhorrosTransaccionesEstudiantil> gmtdConsultarTransaccionesEstudiantiles(string tstrCedulaAho)
        {
            using (dbExequial2010DataContext recibosIngresos = new dbExequial2010DataContext())
            {
                var query = (from soc in recibosIngresos.tblAhorrosTransaccionesEstudiantils
                             where soc.bitMuestra == true && soc.strCedulaAho == tstrCedulaAho
                             orderby soc.dtmFechaTra descending
                             select soc).Take(10);

                return query.ToList();
            }
        }

        /// <summary> Consulta las transacciones fijas de un determinado ahorrador. </summary>
        /// <param name="tstrCedulaAho"> Cédula del ahorrador al que se le va a consultar las transacciones fijas. </param>
        /// <returns> Lista de transacciones seleccionadas. </returns>
        public List<tblAhorrosTransaccionesFijo> gmtdConsultarTransaccionesFijas(string tstrCedulaAho)
        {
            using (dbExequial2010DataContext recibosIngresos = new dbExequial2010DataContext())
            {
                var query = (from soc in recibosIngresos.tblAhorrosTransaccionesFijos
                             where soc.bitMuestra == true && soc.strCedulaAho == tstrCedulaAho
                             orderby soc.dtmFechaTra descending
                             select soc).Take(10);

                return query.ToList();
            }

        }

        /// <summary> Consulta los datos de un determinado recibo. </summary>
        /// <param name="tintRecibo"> Código del recibo a consultar. </param>
        /// <returns> Retorna los datos del recibo. </returns>
        public tblIngreso gmtdConsultaIngreso(int tintRecibo)
        {
            using (dbExequial2010DataContext recibosIngresos = new dbExequial2010DataContext())
            {
                var query = from rec in recibosIngresos.tblIngresos
                            where rec.intCodigoIng == tintRecibo
                            select rec;

                if (query.ToList().Count > 0)
                {
                    tblIngreso ingreso = query.ToList()[0];

                    if (ingreso.bitAhorro == true)
                    {
                        var queryAhorro = from rec in recibosIngresos.tblIngresosAhorros
                                          where rec.intCodigoIng == tintRecibo
                                          select rec;
                        ingreso.ingresoAhorro = queryAhorro.ToList()[0];
                    }

                    if (ingreso.bitAhorroaFuturo == true)
                    {
                        var queryAhorroaFuturo = from rec in recibosIngresos.tblIngresosAhorrosaFuturos
                                                 where rec.intCodigoIng == tintRecibo
                                                 select rec;
                        ingreso.ingresoAhorroaFuturo = queryAhorroaFuturo.ToList();
                    }

                    if (ingreso.bitAhorroNavideno == true)
                    {
                        var queryAhorroNavideño = from rec in recibosIngresos.tblIngresosAhorrosNavidenos
                                                  where rec.intCodigoIng == tintRecibo
                                                  select rec;
                        ingreso.ingresoAhorroNavideño = queryAhorroNavideño.ToList();
                    }

                    if (ingreso.bitAhorroNatilleraEscolar == true)
                    {
                        var queryAhorroNatilleraEscolar = from rec in recibosIngresos.tblIngresosAhorrosNatilleraEscolars
                                                  where rec.intCodigoIng == tintRecibo
                                                  select rec;
                        ingreso.ingresoAhorroNatilleraEscolar = queryAhorroNatilleraEscolar.ToList();
                    }

                    if (ingreso.bitAhorroEstudiante == true)
                    {
                        var queryAhorroEstudiantil = from rec in recibosIngresos.tblIngresosAhorrosEstudiantils
                                                     where rec.intCodigoIng == tintRecibo
                                                     select rec;
                        ingreso.ingresoAhorroEstudiantil = queryAhorroEstudiantil.ToList()[0];
                    }

                    if (ingreso.bitAhorroFijo == true)
                    {
                        var queryAhorroFijo = from rec in recibosIngresos.tblIngresosAhorrosFijos
                                              where rec.intCodigoIng == tintRecibo
                                              select rec;
                        ingreso.ingresoAhorroFijo = queryAhorroFijo.ToList()[0];
                    }

                    if (ingreso.bitCuota == true)
                    {
                        var queryCuotaExequial = from rec in recibosIngresos.tblIngresosCuotas
                                                 where rec.intCodigoIng == tintRecibo
                                                 select rec;
                        ingreso.ingresoCuota = queryCuotaExequial.ToList()[0];
                    }

                    if (ingreso.bitDeuda == true)
                    {
                        var queryDeuda = from rec in recibosIngresos.tblIngresosDeudas
                                         where rec.intCodigoIng == tintRecibo
                                         select rec;
                        ingreso.ingresoAbonoaDeuda = queryDeuda.ToList();
                    }

                    if (ingreso.bitOtro == true)
                    {
                        var queryOtro = from rec in recibosIngresos.tblIngresosOtrosIngresos
                                        where rec.intCodigoIng == tintRecibo
                                        select rec;
                        ingreso.ingresoOtrosIngresos = queryOtro.ToList();
                    }

                    if (ingreso.bitPrestamo == true)
                    {
                        var queryPrestamo = from rec in recibosIngresos.tblIngresosPrestamos
                                            where rec.intCodigoIng == tintRecibo
                                            select rec;
                        ingreso.ingresoPrestamo = queryPrestamo.ToList();
                    }

                    if (ingreso.bitPrestamoAbono == true)
                    {
                        var queryPrestamoAbono = from rec in recibosIngresos.tblIngresosPrestamosAbonos
                                                 where rec.intCodigoIng == tintRecibo
                                                 select rec;
                        ingreso.ingresoAbonoaPrestamo = queryPrestamoAbono.ToList()[0];
                    }

                    if (ingreso.bitVenta == true)
                    {
                        var queryVenta = from rec in recibosIngresos.tblIngresosVentas
                                         where rec.intCodigoIng == tintRecibo
                                         select rec;
                        ingreso.ingresoAbonoaVenta = queryVenta.ToList()[0];
                    }

                    return ingreso;
                }
                else
                    return new tblIngreso();
            }
        }

        /// <summary> Consulta los datos de recibos registrados en un rango de fecha. </summary>
        /// <param name="tdtmFechaInicial"> Fecha inicial de la busqueda. </param>
        /// <param name="tdtmFechaFinal"> Fecha final de la busqueda. </param>
        /// <returns> Lista con los recibos consultados. </returns>
        public List<tblIngreso> gmtdConsultaIngresos(DateTime tdtmFechaInicial, DateTime tdtmFechaFinal)
        {
            List<tblIngreso> lstIngresosConsultados = new List<tblIngreso>();

            using (dbExequial2010DataContext recibosIngresos = new dbExequial2010DataContext())
            {
                int tintRecibo = 0;

                var query = from rec in recibosIngresos.tblIngresos
                            where rec.dtmFechaRec >= tdtmFechaInicial && rec.dtmFechaRec <= tdtmFechaFinal
                            orderby rec.intCodigoIng ascending
                            select rec;

                List<tblIngreso> lstIngresos = query.ToList();

                for (int a = 0; a < lstIngresos.Count; a++)
                {
                    tblIngreso ingreso = lstIngresos[a];

                    tintRecibo = ingreso.intCodigoIng;

                    if (ingreso.bitAhorro == true)
                    {
                        var queryAhorro = from rec in recibosIngresos.tblIngresosAhorros
                                          where rec.intCodigoIng == tintRecibo
                                          select rec;
                        ingreso.ingresoAhorro = queryAhorro.ToList()[0];
                    }

                    if (ingreso.bitAhorroaFuturo == true)
                    {
                        var queryAhorroaFuturo = from rec in recibosIngresos.tblIngresosAhorrosaFuturos
                                                 where rec.intCodigoIng == tintRecibo
                                                 select rec;
                        ingreso.ingresoAhorroaFuturo = queryAhorroaFuturo.ToList();
                    }

                    if (ingreso.bitAhorroNavideno == true)
                    {
                        var queryAhorroNavideño = from rec in recibosIngresos.tblIngresosAhorrosNavidenos
                                                  where rec.intCodigoIng == tintRecibo
                                                  select rec;
                        ingreso.ingresoAhorroNavideño = queryAhorroNavideño.ToList();
                    }

                    if (ingreso.bitAhorroEstudiante == true)
                    {
                        var queryAhorroEstudiantil = from rec in recibosIngresos.tblIngresosAhorrosEstudiantils
                                                     where rec.intCodigoIng == tintRecibo
                                                     select rec;
                        ingreso.ingresoAhorroEstudiantil = queryAhorroEstudiantil.ToList()[0];
                    }

                    if (ingreso.bitAhorroFijo == true)
                    {
                        var queryAhorroFijo = from rec in recibosIngresos.tblIngresosAhorrosFijos
                                              where rec.intCodigoIng == tintRecibo
                                              select rec;
                        ingreso.ingresoAhorroFijo = queryAhorroFijo.ToList()[0];
                    }

                    if (ingreso.bitCuota == true)
                    {
                        var queryCuotaExequial = from rec in recibosIngresos.tblIngresosCuotas
                                                 where rec.intCodigoIng == tintRecibo
                                                 select rec;
                        ingreso.ingresoCuota = queryCuotaExequial.ToList()[0];
                    }

                    if (ingreso.bitDeuda == true)
                    {
                        var queryDeuda = from rec in recibosIngresos.tblIngresosDeudas
                                         where rec.intCodigoIng == tintRecibo
                                         select rec;
                        ingreso.ingresoAbonoaDeuda = queryDeuda.ToList();
                    }

                    if (ingreso.bitOtro == true)
                    {
                        var queryOtro = from rec in recibosIngresos.tblIngresosOtrosIngresos
                                        where rec.intCodigoIng == tintRecibo
                                        select rec;
                        ingreso.ingresoOtrosIngresos = queryOtro.ToList();
                    }

                    if (ingreso.bitPrestamo == true)
                    {
                        var queryPrestamo = from rec in recibosIngresos.tblIngresosPrestamos
                                            where rec.intCodigoIng == tintRecibo
                                            select rec;
                        ingreso.ingresoPrestamo = queryPrestamo.ToList();
                    }

                    if (ingreso.bitPrestamoAbono == true)
                    {
                        var queryPrestamoAbono = from rec in recibosIngresos.tblIngresosPrestamosAbonos
                                                 where rec.intCodigoIng == tintRecibo
                                                 select rec;
                        ingreso.ingresoAbonoaPrestamo = queryPrestamoAbono.ToList()[0];
                    }

                    if (ingreso.bitVenta == true)
                    {
                        var queryVenta = from rec in recibosIngresos.tblIngresosVentas
                                         where rec.intCodigoIng == tintRecibo
                                         select rec;
                        ingreso.ingresoAbonoaVenta = queryVenta.ToList()[0];
                    }

                    lstIngresosConsultados.Add(ingreso);
                }
            }

            return lstIngresosConsultados;
        }

        /// <summary> Elimina un recibo de ingreso. </summary>
        /// <param name="tobjIngreso"> Un objeto del tipo ingreso. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEliminar(tblIngreso tobjIngreso)
        {
            String strRetornar;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    using (dbExequial2010DataContext recibosIngresos = new dbExequial2010DataContext())
                    {
                        tblIngreso ing = recibosIngresos.tblIngresos.SingleOrDefault(p => p.intCodigoIng == tobjIngreso.intCodigoIng);
                        ing.bitAnulado = true;
                        ing.dtmFechaAnu = tobjIngreso.dtmFechaAnu;

                        if (tobjIngreso.ingresoCuota != null)
                        {
                            tblSocio soc = recibosIngresos.tblSocios.SingleOrDefault(p => p.intCodigoSoc == tobjIngreso.ingresoCuota.intCodigoSoc);
                            soc.intMeses -= tobjIngreso.ingresoCuota.intCantidad;
                        }

                        if (tobjIngreso.ingresoPrestamo != null)
                        {
                            for (int a = 0; a < tobjIngreso.ingresoPrestamo.Count; a++)
                            {
                                tblCredito cre = recibosIngresos.tblCreditos.SingleOrDefault(p => p.intCodigoCre == tobjIngreso.ingresoPrestamo[a].intCodigoPre);
                                cre.decDebe += tobjIngreso.ingresoPrestamo[a].decCapital;

                                tblCreditosCuota cuo = recibosIngresos.tblCreditosCuotas.SingleOrDefault(p => p.intCodigoCre == tobjIngreso.ingresoPrestamo[a].intCodigoPre && p.intCuota == tobjIngreso.ingresoPrestamo[a].intCuota);
                                cuo.bitPagada = false;
                                cuo.dtmFechaPago = Convert.ToDateTime("1/1/1900");
                            }
                        }

                        if (tobjIngreso.ingresoAhorro != null)
                        {
                            tblAhorradore aho = recibosIngresos.tblAhorradores.SingleOrDefault(p => p.strCedulaAho == tobjIngreso.strCedulaIng);
                            aho.decAhorrado -= tobjIngreso.ingresoAhorro.decAhorro;
                        }

                        if (tobjIngreso.ingresoAhorroEstudiantil != null)
                        {
                            tblAhorradore aho = recibosIngresos.tblAhorradores.SingleOrDefault(p => p.strCedulaAho == tobjIngreso.strCedulaIng);
                            aho.decAhorrosEstudiantes -= tobjIngreso.ingresoAhorroEstudiantil.decAhorro;
                        }

                        if (tobjIngreso.ingresoAhorroFijo != null)
                        {
                            tblAhorradore aho = recibosIngresos.tblAhorradores.SingleOrDefault(p => p.strCedulaAho == tobjIngreso.strCedulaIng);
                            aho.decAhorrosFijo -= tobjIngreso.ingresoAhorroFijo.decAhorro;
                        }

                        if (tobjIngreso.ingresoAhorroNavideño != null)
                        {
                            for (int a = 0; a < tobjIngreso.ingresoAhorroNavideño.Count; a++)
                            {
                                tblAhorrosNavidenoDetalle nav = recibosIngresos.tblAhorrosNavidenoDetalles.SingleOrDefault(p => p.strCuenta == tobjIngreso.ingresoAhorroNavideño[a].strCuenta && p.dtmFechaCuota == tobjIngreso.ingresoAhorroNavideño[a].dtmFechaCuo);
                                nav.bitPagada = false;
                                nav.dtmFechaPago = Convert.ToDateTime("1/1/1900");

                                tblAhorrosNavideno aho = recibosIngresos.tblAhorrosNavidenos.SingleOrDefault(p => p.strCuenta == tobjIngreso.ingresoAhorroNavideño[a].strCuenta);
                                aho.intPagadas--;

                            }
                        }

                        if (tobjIngreso.ingresoAhorroNatilleraEscolar != null)
                        {
                            for (int a = 0; a < tobjIngreso.ingresoAhorroNatilleraEscolar.Count; a++)
                            {
                                tblAhorrosNatilleraEscolarDetalle nav = recibosIngresos.tblAhorrosNatilleraEscolarDetalles.SingleOrDefault(p => p.strCuenta == tobjIngreso.ingresoAhorroNatilleraEscolar[a].strCuenta && p.dtmFechaCuota == tobjIngreso.ingresoAhorroNatilleraEscolar[a].dtmFechaCuo);
                                nav.bitPagada = false;
                                nav.dtmFechaPago = Convert.ToDateTime("1/1/1900");

                                tblAhorrosNatilleraEscolar aho = recibosIngresos.tblAhorrosNatilleraEscolars.SingleOrDefault(p => p.strCuenta == tobjIngreso.ingresoAhorroNatilleraEscolar[a].strCuenta);
                                aho.intPagadas--;

                            }
                        }

                        if (tobjIngreso.ingresoAhorroaFuturo != null)
                        {
                            for (int a = 0; a < tobjIngreso.ingresoAhorroaFuturo.Count; a++)
                            {
                                tblAhorrosaFuturoDetalle afu = recibosIngresos.tblAhorrosaFuturoDetalles.SingleOrDefault(p => p.strCuenta == tobjIngreso.ingresoAhorroaFuturo[a].strCuenta && p.dtmFechaCuota == tobjIngreso.ingresoAhorroaFuturo[a].dtmFechaCuo);
                                afu.bitPagada = false;
                                afu.dtmFechaPago = Convert.ToDateTime("1/1/1900");
                            }
                        }

                        if (tobjIngreso.ingresoOtrosIngresos != null)
                        {
                            ///No se necesita devolver ninguna operación.
                        }

                        if (tobjIngreso.ingresoAbonoaPrestamo != null)
                        {
                            tblCredito cre = recibosIngresos.tblCreditos.SingleOrDefault(p => p.intCodigoCre == tobjIngreso.ingresoAbonoaPrestamo.intCodigoCre);
                            cre.decAbono -= tobjIngreso.ingresoAbonoaPrestamo.decAbonoPrestamo;

                            if (tobjIngreso.ingresoAbonoaPrestamo.bitDeducirAbonodelMonto)
                            {
                                cre.decDebe += tobjIngreso.ingresoAbonoaPrestamo.decAbonoPrestamo;
                            }
                        }

                        if (tobjIngreso.ingresoAbonoaVenta != null)
                        {
                            tblVenta ven = recibosIngresos.tblVentas.SingleOrDefault(p => p.intCodVenta == tobjIngreso.ingresoAbonoaVenta.intCodVenta);
                            ven.decDebeVen += tobjIngreso.ingresoAbonoaVenta.decAbona;
                        }

                        if (tobjIngreso.ingresoAbonoaDeuda != null)
                        {
                            for (int a = 0; a < tobjIngreso.ingresoAbonoaDeuda.Count; a++)
                            {
                                tblDeuda deu = recibosIngresos.tblDeudas.SingleOrDefault(p => p.intCodDeu == tobjIngreso.ingresoAbonoaDeuda[a].intCodDeu && p.strCedula == tobjIngreso.ingresoAbonoaDeuda[a].strCedula);
                                deu.decDebeDeu += tobjIngreso.ingresoAbonoaDeuda[a].decAbona;
                                deu.decAbonaDeu -= tobjIngreso.ingresoAbonoaDeuda[a].decAbona;
                            }
                        }

                        recibosIngresos.SubmitChanges();

                        tobjIngreso.log = metodos.gmtdLog("Elimina el recibo " + tobjIngreso.intCodigoIng.ToString(), tobjIngreso.strFormulario);
                        recibosIngresos.tblLogdeActividades.InsertOnSubmit(tobjIngreso.log);

                        if (tobjIngreso.ingresoAhorro != null)
                        {
                            tblAhorrosTransaccione tra = recibosIngresos.tblAhorrosTransacciones.SingleOrDefault(p => p.intCodigoIng == tobjIngreso.intCodigoIng);
                            tra.bitMuestra = false;

                            tblAhorrosTransaccione transaccion = new tblAhorrosTransaccione();
                            transaccion.bitMuestra = false;
                            transaccion.decAcumula = tobjIngreso.ingresoAhorro.decAcumula - tobjIngreso.ingresoAhorro.decAhorro;
                            transaccion.decAhorrado = tobjIngreso.ingresoAhorro.decAhorrado;
                            transaccion.decValor = tobjIngreso.ingresoAhorro.decAhorro;
                            transaccion.dtmFechaTra = tobjIngreso.dtmFechaAnu;
                            transaccion.intCodigoIng = tobjIngreso.intCodigoIng;
                            transaccion.strCedulaAho = tobjIngreso.strCedulaIng;
                            transaccion.strDescripcion = "Comprobante # " + tobjIngreso.intCodigoIng.ToString();
                            transaccion.strTransaccion = "Retiro";
                            recibosIngresos.tblAhorrosTransacciones.InsertOnSubmit(transaccion);

                        }

                        if (tobjIngreso.ingresoAhorroEstudiantil != null)
                        {
                            tblAhorrosTransaccionesEstudiantil tra = recibosIngresos.tblAhorrosTransaccionesEstudiantils.SingleOrDefault(p => p.intCodigoIng == tobjIngreso.intCodigoIng);
                            tra.bitMuestra = false;

                            tblAhorrosTransaccionesEstudiantil transaccion = new tblAhorrosTransaccionesEstudiantil();
                            transaccion.bitMuestra = false;
                            transaccion.decAcumula = tobjIngreso.ingresoAhorroEstudiantil.decAcumula - tobjIngreso.ingresoAhorroEstudiantil.decAhorro;
                            transaccion.decAhorrado = tobjIngreso.ingresoAhorroEstudiantil.decAhorrado;
                            transaccion.decValor = tobjIngreso.ingresoAhorroEstudiantil.decAhorro;
                            transaccion.dtmFechaTra = tobjIngreso.dtmFechaAnu;
                            transaccion.intCodigoIng = tobjIngreso.intCodigoIng;
                            transaccion.strCedulaAho = tobjIngreso.strCedulaIng;
                            transaccion.strDescripcion = "Comprobante # " + tobjIngreso.intCodigoIng.ToString();
                            transaccion.strTransaccion = "Retiro";

                            recibosIngresos.tblAhorrosTransaccionesEstudiantils.InsertOnSubmit(transaccion);
                        }

                        if (tobjIngreso.ingresoAhorroFijo != null)
                        {
                            tblAhorrosTransaccionesFijo tra = recibosIngresos.tblAhorrosTransaccionesFijos.SingleOrDefault(p => p.intCodigoIng == tobjIngreso.intCodigoIng);
                            tra.bitMuestra = false;

                            tblAhorrosTransaccionesFijo transaccion = new tblAhorrosTransaccionesFijo();
                            transaccion.bitMuestra = false;
                            transaccion.decAcumula = tobjIngreso.ingresoAhorroFijo.decAcumula - tobjIngreso.ingresoAhorroFijo.decAhorro;
                            transaccion.decAhorrado = tobjIngreso.ingresoAhorroFijo.decAhorrado;
                            transaccion.decValor = tobjIngreso.ingresoAhorroFijo.decAhorro;
                            transaccion.dtmFechaTra = tobjIngreso.dtmFechaAnu;
                            transaccion.intCodigoIng = tobjIngreso.intCodigoIng;
                            transaccion.strCedulaAho = tobjIngreso.strCedulaIng;
                            transaccion.strDescripcion = "Comprobante # " + tobjIngreso.intCodigoIng.ToString();
                            transaccion.strTransaccion = "Retiro";

                            recibosIngresos.tblAhorrosTransaccionesFijos.InsertOnSubmit(transaccion);
                        }

                        recibosIngresos.SubmitChanges();

                    }
                    ts.Complete();
                    strRetornar = "Registro Eliminado";
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
        public void gmtdImprimirIngreso(int tintCodigoIng)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(ConfigurationManager.AppSettings["conexionDb"].ToString());
                SqlCommand comando = new SqlCommand("Exec spImprimirRecibosdeIngresos " + tintCodigoIng.ToString(), conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataSet ds = new DataSet();
                adaptador.Fill(ds);
                ds.WriteXml(@"C:\Reportes\rptRecibosIngresos.Xml");
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
            }
        }

        /// <summary> Genera el archivo Xml para el recibo de ahorros. </summary>
        /// <param name="tstrTransaccioncion"> Un string que indica 'Retiros' 0 'Ahorros' </param>
        /// <param name="tintCodigoRec"> El código del recibo que se quiere imprimir. </param>
        public void gmtdImprimirAhorro(string tstrTransaccioncion, int tintCodigoRec)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(ConfigurationManager.AppSettings["conexionDb"].ToString());
                SqlCommand comando = new SqlCommand("Exec spImprimirReciboTransacciones " + tintCodigoRec.ToString() + ", " + tstrTransaccioncion, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataSet ds = new DataSet();
                adaptador.Fill(ds);
                ds.WriteXml(@"C:\Reportes\rptRecibosTransacciones.Xml");
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
            }
        }

        /// <summary> Inserta el movimiento contable. </summary>
        /// <param name="tstrCodigoPar"> Codigo del par a trabajar. </param>
        /// <param name="tdecValor"> Valor del movimiento. </param>
        /// <param name="tintCodigoRec"> Código del recibo de ingreso o egreso. </param>
        public void gmtdInsertarMvtoContable(string tstrCodigoPar, decimal tdecValor, int tintCodigoRec)
        {
            using (dbExequial2010DataContext recibos = new dbExequial2010DataContext())
            {
                List<cuentaValores>[] cuotasValores = new blCuentaPar().gmtdCalcularValores(tstrCodigoPar, tdecValor);

                List<cuentaValores> cuentasDebito = cuotasValores[0];
                for (int a = 0; a < cuentasDebito.Count; a++)
                {
                    tblCuentasOperacionesContabilidad operacion = new tblCuentasOperacionesContabilidad();
                    operacion.decValor = cuentasDebito[a].decValor;
                    operacion.dtmFecha = DateTime.Now;
                    operacion.intCodigoRec = tintCodigoRec;
                    operacion.intTipodeIngreso = 1;
                    operacion.strCuenta = cuentasDebito[a].strCuenta;
                    operacion.strDescripcion = cuentasDebito[a].strCuenta;
                    recibos.tblCuentasOperacionesContabilidads.InsertOnSubmit(operacion);
                }

                List<cuentaValores> cuentasCredito = cuotasValores[1];
                for (int a = 0; a < cuentasCredito.Count; a++)
                {
                    tblCuentasOperacionesContabilidad operacion = new tblCuentasOperacionesContabilidad();
                    operacion.decValor = cuentasCredito[a].decValor;
                    operacion.dtmFecha = DateTime.Now;
                    operacion.intCodigoRec = tintCodigoRec;
                    operacion.intTipodeIngreso = 2;
                    operacion.strCuenta = cuentasCredito[a].strCuenta;
                    operacion.strDescripcion = cuentasCredito[a].strCuenta;
                    recibos.tblCuentasOperacionesContabilidads.InsertOnSubmit(operacion);
                }
            }
        }

        /// <summary> Selecciona la deuda de una determinada persona. </summary>
        /// <param name="tstrCedula"> Numero de la cédula de la persona. </param>
        /// <returns> El listado de las deudas de la persona. </returns>
        public List<tblEstadodeCuenta> gmtdSumarDeudasxPersona(string tstrCedula)
        {
            try
            {
                using (dbExequial2010DataContext deudas = new dbExequial2010DataContext())
                {
                    deudas.ExecuteCommand("Exec spReporteEstadodeCuenta '" + tstrCedula + "'");

                    var query = from fecha in deudas.tblEstadodeCuentas
                                select fecha;

                    return query.ToList();
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                return new List<tblEstadodeCuenta>();
            }
        }

        /// <summary> Consulta los ingresos activos en un rango de fechas. </summary>
        /// <param name="tdtmFechaIni"> Fecha de inicio de la consulta. </param>
        /// <param name="tdtmFechaFin"> Fecha final de la consulta. </param>
        /// <returns> El valor de la suma consultada. </returns>
        public decimal gmtdConsultarIngresosAgrupadosenunRangodeFechas(DateTime tdtmFechaIni, DateTime tdtmFechaFin)
        {
            try
            {
                using (dbExequial2010DataContext deudas = new dbExequial2010DataContext())
                {
                    var query = (from gra in deudas.tblIngresos
                                 where gra.bitAnulado == false
                                 && gra.dtmFechaRec >= tdtmFechaIni
                                 && gra.dtmFechaRec <= tdtmFechaFin
                                 select gra.decTotalIng).Sum();

                    return query;
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                return -1;
            }
        }

        /// <summary> Consulta los ingresos activos de ahorros en un rango de fechas. </summary>
        /// <param name="tdtmFechaIni"> Fecha de inicio de la consulta. </param>
        /// <param name="tdtmFechaFin"> Fecha final de la consulta. </param>
        /// <returns> El valor de la suma consultada. </returns>
        public decimal gmtdConsultarIngresosdeAhorrosAgrupadosenunRangodeFechas(DateTime tdtmFechaIni, DateTime tdtmFechaFin)
        {
            try
            {
                using (dbExequial2010DataContext deudas = new dbExequial2010DataContext())
                {
                    var query = (from gra in deudas.tblIngresos
                                 join det in deudas.tblIngresosAhorros on gra.intCodigoIng equals det.intCodigoIng
                                 where gra.bitAnulado == false
                                 && gra.dtmFechaRec >= tdtmFechaIni
                                 && gra.dtmFechaRec <= tdtmFechaFin
                                 select det.decAhorro).Sum();

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
