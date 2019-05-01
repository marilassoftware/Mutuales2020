namespace libMutuales2020.logica
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;
    using libMutuales2020.dao;
    using libMutuales2020.dominio;

    [DataObject(true)]
    public class blRecibosIngresos
    {
        static public XmlDocument SerializeServicio(tblIngreso objIngreso)
        {
            XmlSerializer ser = new XmlSerializer(typeof(tblIngreso));

            StringBuilder sb = new StringBuilder();

            StringWriter writer = new StringWriter(sb);

            ser.Serialize(writer, objIngreso);

            XmlDocument doc = new XmlDocument();

            doc.LoadXml(sb.ToString());

            writer.Close();

            return doc;
        }

        /// <summary> Inserta una cuenta de ahorro a futuro. </summary>
        /// <param name="tobjIngreso"> Un objeto del tipo ingreso. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblIngreso tobjIngreso)
        {
            if (tobjIngreso.ingresoAbonoaDeuda != null)
            {
                for (int a = 0; a < tobjIngreso.ingresoAbonoaDeuda.Count; a++)
                {
                    tobjIngreso.ingresoAbonoaDeuda[a].strCodigoPar = new blDeudas().gmtdConsultar(tobjIngreso.ingresoAbonoaDeuda[a].intCodDeu).strCodigoPar;
                }
            }

            if (tobjIngreso.ingresoAbonoaPrestamo != null)
            {
                tobjIngreso.ingresoAbonoaPrestamo.strCodigoPar = new blCreditos().gmtdConsultar(tobjIngreso.ingresoAbonoaPrestamo.intCodigoCre).strCodigoPar;
            }

            if (tobjIngreso.ingresoAbonoaVenta != null)
            {
                tobjIngreso.ingresoAbonoaVenta.strCodigoPar = new blVentas().gmtdConsultar(tobjIngreso.ingresoAbonoaVenta.intCodVenta).strNombreCliente;
            }

            if (tobjIngreso.ingresoAhorro != null)
            {
                tobjIngreso.ingresoAhorro.strCodigoPar = "0001";
            }

            if (tobjIngreso.ingresoAhorroaFuturo != null)
            {
                for (int a = 0; a < tobjIngreso.ingresoAhorroaFuturo.Count; a++)
                {
                    tobjIngreso.ingresoAhorroaFuturo[a].strCodigoPar = "0001";
                }
            }

            if (tobjIngreso.ingresoAhorroCdt != null)
            {
                tobjIngreso.ingresoAhorro.strCodigoPar = "0001";
            }

            if (tobjIngreso.ingresoAhorroEstudiantil != null)
            {
                tobjIngreso.ingresoAhorroEstudiantil.strCodigoPar = "0001";
            }

            if (tobjIngreso.ingresoAhorroFijo != null)
            {
                tobjIngreso.ingresoAhorroFijo.strCodigoPar = "0001";
            }

            if (tobjIngreso.ingresoAhorroNavideño != null)
            {
                for (int a = 0; a < tobjIngreso.ingresoAhorroNavideño.Count; a++)
                {
                    tobjIngreso.ingresoAhorroNavideño[a].strCodigoPar = "0001";
                }
            }

            if (tobjIngreso.ingresoCuota != null)
            {
                tobjIngreso.ingresoCuota.strCodigoPar = new blPrimarios().gmtdConsultar(tobjIngreso.ingresoCuota.strCodServiciop).strCodigoPar;

                tobjIngreso.ingresoCuota.fechasCuotas = new List<tblSociosPagosCuota>();

                char[] delimitador = { ',' };

                string[] vector = tobjIngreso.ingresoCuota.strMeses.Split(delimitador);

                for (int b = 0; b < vector.Length; b++)
                {
                    int intMes = this.calcularNumeroMes(vector[b].ToString());

                    tblSociosPagosCuota objSocioPagoCuota = new tblSociosPagosCuota();
                    objSocioPagoCuota.dtmFechaPag = tobjIngreso.dtmFechaRec;
                    objSocioPagoCuota.intAño = tobjIngreso.ingresoCuota.intAño;
                    objSocioPagoCuota.intCodigoIng = 0;
                    objSocioPagoCuota.intMes = intMes;
                    objSocioPagoCuota.intSocio = tobjIngreso.ingresoCuota.intCodigoSoc;

                    tobjIngreso.ingresoCuota.fechasCuotas.Add(objSocioPagoCuota);
                }
            }

            if (tobjIngreso.ingresoOtrosIngresos != null)
            {
                for (int a = 0; a < tobjIngreso.ingresoOtrosIngresos.Count; a++)
                {
                    tobjIngreso.ingresoOtrosIngresos[a].strCodigoPar = new blOtroIngreso().gmtdConsultar(tobjIngreso.ingresoOtrosIngresos[a].strCodOtrosIngresos).strCodigoPar;
                }
            }

            if (tobjIngreso.ingresoPrestamo != null)
            {
                for (int a = 0; a < tobjIngreso.ingresoPrestamo.Count; a++)
                {
                    tobjIngreso.ingresoPrestamo[a].strParCapital = new blCreditosLinea().gmtdConsultar(new blCreditos().gmtdConsultar(tobjIngreso.ingresoPrestamo[a].intCodigoPre).strCodLineadeCredito).strParCapital;
                    tobjIngreso.ingresoPrestamo[a].strParInteres = new blCreditosLinea().gmtdConsultar(new blCreditos().gmtdConsultar(tobjIngreso.ingresoPrestamo[a].intCodigoPre).strCodLineadeCredito).strParInteres;
                    tobjIngreso.ingresoPrestamo[a].strParMora = new blCreditosLinea().gmtdConsultar(new blCreditos().gmtdConsultar(tobjIngreso.ingresoPrestamo[a].intCodigoPre).strCodLineadeCredito).strParMora;
                }
            }

            if (tobjIngreso.ingresoAbonoaPrestamo != null)
            {
                tobjIngreso.ingresoAbonoaPrestamo.bitDeducirAbonodelMonto = (bool)new blConfiguracion().gmtdConsultaConfiguracion().bitDeducirAbonosdelMontodelPrestamo;
            }

            XmlDocument xml = blRecibosIngresos.SerializeServicio(tobjIngreso);

            string strRetorno = new daoRecibosIngresos().gmtdInsertar(xml);

            if (strRetorno == "0")
            {
                return "- Ha ocurrido un error al registrar el ingreso.";
            }
            else
            {
                return strRetorno + "+Ingreso ingresado.";
            }

            if (tobjIngreso.ingresoCuota != null)
            {
                int tintAño = new blConfiguracion().gmtdConsultaConfiguracion().intAnoEvaluado;
                int tintMes = new blConfiguracion().gmtdConsultaConfiguracion().intMesEvaluado;

                this.gmtdIngresarNumeroRifa(tobjIngreso.ingresoCuota.intCodigoSoc, tintAño, tintMes);
            }

            return strRetorno;
        }

        /// <summary> Ingresa el nùmero de rifa de un socio. </summary>
        /// <param name="tintCodigoSoc"> Còdigo del socio para el nùemro de la rifa. </param>
        /// <param name="tintAño"> Año para el nùmero de la rifa. </param>
        /// <param name="tintMes"> Mes para el nùmero de la rifa. </param>
        public void gmtdIngresarNumeroRifa(int tintCodigoSoc, int tintAño, int tintMes)
        {
            string strResultado = new daoRecibosIngresos().gmtdConsultarNumeroRifa(tintCodigoSoc, tintAño, tintMes);

            if (strResultado == "-1")
                new daoRecibosIngresos().gmtdIngresarNumeroRifa(tintCodigoSoc, tintAño, tintMes);
        }

        /// <summary> Migra los recibos anteriores </summary>
        /// <param name="tobjIngreso"> el recibo </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdMigrarRecibos(tblIngreso tobjIngreso)
        {
            if (tobjIngreso.ingresoAbonoaDeuda != null)
            {
                for (int a = 0; a < tobjIngreso.ingresoAbonoaDeuda.Count; a++)
                {
                    tobjIngreso.ingresoAbonoaDeuda[a].strCodigoPar = new blDeudas().gmtdConsultar(tobjIngreso.ingresoAbonoaDeuda[a].intCodDeu).strCodigoPar;
                }
            }

            if (tobjIngreso.ingresoAbonoaPrestamo != null)
                tobjIngreso.ingresoAbonoaPrestamo.strCodigoPar = new blCreditos().gmtdConsultar(tobjIngreso.ingresoAbonoaPrestamo.intCodigoCre).strCodigoPar;

            if (tobjIngreso.ingresoAbonoaVenta != null)
                tobjIngreso.ingresoAbonoaVenta.strCodigoPar = new blVentas().gmtdConsultar(tobjIngreso.ingresoAbonoaVenta.intCodVenta).strNombreCliente;

            if (tobjIngreso.ingresoAhorro != null)
                tobjIngreso.ingresoAhorro.strCodigoPar = "0001";

            if (tobjIngreso.ingresoAhorroaFuturo != null)
            {
                for (int a = 0; a < tobjIngreso.ingresoAhorroaFuturo.Count; a++)
                    tobjIngreso.ingresoAhorroaFuturo[a].strCodigoPar = "0001";
            }

            if (tobjIngreso.ingresoAhorroCdt != null)
                tobjIngreso.ingresoAhorro.strCodigoPar = "0001";

            if (tobjIngreso.ingresoAhorroEstudiantil != null)
                tobjIngreso.ingresoAhorroEstudiantil.strCodigoPar = "0001";

            if (tobjIngreso.ingresoAhorroFijo != null)
                tobjIngreso.ingresoAhorroFijo.strCodigoPar = "0001";

            if (tobjIngreso.ingresoAhorroNavideño != null)
            {
                for (int a = 0; a < tobjIngreso.ingresoAhorroNavideño.Count; a++)
                    tobjIngreso.ingresoAhorroNavideño[a].strCodigoPar = "0001";
            }

            if (tobjIngreso.ingresoCuota != null)
                tobjIngreso.ingresoCuota.strCodigoPar = new blPrimarios().gmtdConsultar(tobjIngreso.ingresoCuota.strCodServiciop).strCodigoPar;

            if (tobjIngreso.ingresoOtrosIngresos != null)
            {
                for (int a = 0; a < tobjIngreso.ingresoOtrosIngresos.Count; a++)
                    tobjIngreso.ingresoOtrosIngresos[a].strCodigoPar = new blOtroIngreso().gmtdConsultar(tobjIngreso.ingresoOtrosIngresos[a].strCodOtrosIngresos).strCodigoPar;
            }

            if (tobjIngreso.ingresoPrestamo != null)
            {
                for (int a = 0; a < tobjIngreso.ingresoPrestamo.Count; a++)
                    tobjIngreso.ingresoPrestamo[a].strParCapital = new blCreditos().gmtdConsultar(tobjIngreso.ingresoPrestamo[a].intCodigoPre).strCodigoPar;
            }

            return new daoRecibosIngresos().gmtdMigrarRecibos(tobjIngreso);
        }

        /// <summary> Consulta los datos de los diferentes recibos de acuerdo al código del socio. </summary>
        /// <param name="tintCodigoSoc"> Código del socio a consultar. </param>
        /// <returns> Datos consultados. </returns>
        public recibosDatos gmtdConsultarDatos(int tintCodigoSoc)
        {
            recibosDatos datos = new recibosDatos();
            datos.intCodigoSoc = tintCodigoSoc;
            datos.datosSocio = new daoSocio().gmtdConsultarDetalle(tintCodigoSoc);
            if (datos.datosSocio.strNombreSoc != null)
            {
                datos.strCedula = datos.datosSocio.strCedulaSoc;
                datos.strCodigoPar = datos.datosSocio.servicio.strCodigoPar;
            }
            return datos;
        }

        public List<otrosIngresos> gmtdListaOtrosIngresos(List<otrosIngresos> tobjOtrosIngresos)
        {
            return tobjOtrosIngresos;
        }

        /// <summary> Consulta los datos de un determinado recibo. </summary>
        /// <param name="tintRecibo"> Código del recibo a consultar. </param>
        /// <returns> Retorna los datos del recibo. </returns>
        public tblIngreso gmtdConsultaIngreso(int tintRecibo)
        {
            return new daoRecibosIngresos().gmtdConsultaIngreso(tintRecibo);
        }

        /// <summary> Consulta los datos de recibos registrados en un rango de fecha. </summary>
        /// <param name="tdtmFechaInicial"> Fecha inicial de la busqueda. </param>
        /// <param name="tdtmFechaFinal"> Fecha final de la busqueda. </param>
        /// <returns> Lista con los recibos consultados. </returns>
        public List<tblIngreso> gmtdConsultaIngresos(DateTime tdtmFechaInicial, DateTime tdtmFechaFinal)
        {
            string strFechaIni = tdtmFechaInicial.Date.ToShortDateString() + " 00:00:00";
            string strFechaFin = tdtmFechaFinal.Date.ToShortDateString() + " 23:59:59";

            return new daoRecibosIngresos().gmtdConsultaIngresos(Convert.ToDateTime(strFechaIni), Convert.ToDateTime(strFechaFin));
        }

        /// <summary> Elimina un recibo de ingreso. </summary>
        /// <param name="tobjIngreso"> Un objeto del tipo ingreso. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEliminar(int intCodigoIng)
        {
            String Respuesta =  new daoRecibosIngresos().gmtdEliminar(intCodigoIng);

            switch (Respuesta)
            {
                case "-1":
                    return "- No se puede eliminar un recibo de un año diferente al actual del socio.";
                    break;
                case "0":
                    return "- No se puede realizar la operación.";
                    break;
                case "1":
                    return "Registro anulado.";
                    break;
            }

            return Respuesta;
        }

        /// <summaiy> Imprimir recibos. </summary>
        /// <param name="tintCodigoIng"> Codigo de recibo de ingreso. </param>
        public void gmtdImprimiringreso(int tintCodigoIng)
        {
            new daoRecibosIngresos().gmtdImprimirIngreso(tintCodigoIng);
        }

        /// <summary> Genera el archivo Xml para el recibo de ahorros. </summary>
        /// <param name="tstrTransaccioncion"> Un string que indica 'Retiros' 0 'Ahorros' </param>
        /// <param name="tintCodigoRec"> El código del recibo que se quiere imprimir. </param>
        public void gmtdImprimirAhorro(string tstrTransaccioncion, int tintCodigoRec)
        {
            new daoRecibosIngresos().gmtdImprimirAhorro(tstrTransaccioncion, tintCodigoRec);
        }

        /// <summary> Genera un item de un Mvto contable. </summary>
        /// <param name="decValor"> Valor del Mvto. </param>
        /// <param name="tintCodigoIng"> Código de ingreso del Mvto. </param>
        /// <param name="tstrCodigoCuo"> Código de la cuenta. </param>
        /// <param name="tstrDescripcion"> Descripción del Mvto. </param>
        /// <param name="tintTipoMvto"> Tipo del mvto. </param>
        /// <param name="tdtmFecha"> Fecha en la que se ejecuto la operación. </param>
        /// <returns> Un objeto con el tipo de la operación contable. </returns>
        public tblCuentasOperacionesContabilidad gmtdMvtoContableIngresos(decimal decValor, int tintCodigoIng, string tstrCodigoCuo, string tstrDescripcion, int tintTipoMvto, string tstrCedula, string tstrNombre, DateTime tdtmFecha)
        {
            tblCuentasOperacionesContabilidad operacion = new tblCuentasOperacionesContabilidad();
            operacion.decValor = decValor;
            operacion.dtmFecha = tdtmFecha;
            operacion.intCodigoRec = tintCodigoIng;
            operacion.intTipodeIngreso = tintTipoMvto;
            operacion.strCuenta = tstrCodigoCuo;
            operacion.strDescripcion = tstrDescripcion;
            operacion.strCedula = tstrCedula;
            operacion.strNombre = tstrNombre;
            tblCuenta objCuenta = new blCuenta().gmtdConsultar(tstrCodigoCuo);
            if (objCuenta.strCedula != null && objCuenta.strCedula != "")
            {
                operacion.strCedula = objCuenta.strCedula;
                operacion.strNombre = objCuenta.strNombre;
            }

            return operacion;
        }

        /// <summary> Selecciona la deuda de una determinada persona. </summary>
        /// <param name="tstrCedula"> Numero de la cédula de la persona. </param>
        /// <returns> El listado de las deudas de la persona. </returns>
        public List<tblEstadodeCuenta> gmtdSumarDeudasxPersona(string tstrCedula)
        {
            return new daoRecibosIngresos().gmtdSumarDeudasxPersona(tstrCedula);
        }

        /// <summary> Consulta los ingresos activos en un rango de fechas. </summary>
        /// <param name="tdtmFecha"> La fecha hasta la cual se quieren conocer los datos. </param>
        /// <param name="tintMeses"> Meses de los que se quieren conocer los datos.  </summary>
        /// <returns> Diccionario con los datos consultados. </returns>
        public Dictionary<string, string> gmtdConsultarIngresosAgrupadosenunRangodeFechas(DateTime tdtmFecha, int tintMeses)
        {
            Dictionary<string, string> lstMeses = new Dictionary<string, string>();
 
            int intAño = tdtmFecha.Year;
            int intMes = tdtmFecha.Month;

            DateTime[] fechasInciales = new DateTime[tintMeses];
            DateTime[] fechasFinales = new DateTime[tintMeses];

            for (int a = 0; a < tintMeses; a++)
            {
                if (intMes < 1)
                {
                    intMes = 12;
                    intAño -= 1;
                }

                DateTime dtmFechaIni = Convert.ToDateTime(intAño.ToString() + "-" + intMes.ToString() + "-" + pmtdMostrardiaInicial(intMes, true, intAño).ToString());
                DateTime dtmFechaFin = Convert.ToDateTime(intAño.ToString() + "-" + intMes.ToString() + "-" + pmtdMostrardiaInicial(intMes, false, intAño).ToString());

                fechasInciales[a] = dtmFechaIni;
                fechasFinales[a] = dtmFechaFin;

                intMes --;

            }

            for(int a = tintMeses - 1; a >= 0; a--)
            {
                decimal decValor = new daoRecibosIngresos().gmtdConsultarIngresosAgrupadosenunRangodeFechas(fechasInciales[a], fechasFinales[a]);

                lstMeses.Add(this.pmtdNombreMes(fechasInciales[a].Month), decValor.ToString());
            }

            return lstMeses;
        }

        /// <summary> Consulta los ingresos activos de ahorros en un rango de fechas. </summary>
        /// <param name="tdtmFecha"> La fecha hasta la cual se quieren conocer los datos. </param>
        /// <param name="tintMeses"> Meses de los que se quieren conocer los datos.  </summary>
        /// <returns> Diccionario con los datos consultados. </returns>
        public Dictionary<string, string> gmtdConsultarIngresosdeAhorrosAgrupadosenunRangodeFechas(DateTime tdtmFecha, int tintMeses)
        {
            Dictionary<string, string> lstMeses = new Dictionary<string, string>();

            int intAño = tdtmFecha.Year;
            int intMes = tdtmFecha.Month;

            DateTime[] fechasInciales = new DateTime[tintMeses];
            DateTime[] fechasFinales = new DateTime[tintMeses];

            for (int a = 0; a < tintMeses; a++)
            {
                if (intMes < 1)
                {
                    intMes = 12;
                    intAño -= 1;
                }

                DateTime dtmFechaIni = Convert.ToDateTime(intAño.ToString() + "-" + intMes.ToString() + "-" + pmtdMostrardiaInicial(intMes, true, intAño).ToString());
                DateTime dtmFechaFin = Convert.ToDateTime(intAño.ToString() + "-" + intMes.ToString() + "-" + pmtdMostrardiaInicial(intMes, false, intAño).ToString());

                fechasInciales[a] = dtmFechaIni;
                fechasFinales[a] = dtmFechaFin;

                intMes--;

            }

            for (int a = tintMeses - 1; a >= 0; a--)
            {
                decimal decValor = new daoRecibosIngresos().gmtdConsultarIngresosdeAhorrosAgrupadosenunRangodeFechas(fechasInciales[a], fechasFinales[a]);

                lstMeses.Add(this.pmtdNombreMes(fechasInciales[a].Month), decValor.ToString());
            }

            return lstMeses;
        }

        /// <summary> Muestra el dia inicial o final de un determinado mes. </summary>
        /// <param name="tintMes"> El mes del que se va a mostrar el día inicial o final </param>
        /// <param name="tbitInicial"> True si se quiere devolver el dìa inicial del mes o False si quiere devolver el dia final. </param>
        /// <param name="tintAño"> El año del mes al que se le va a calcular la fecha inicial. </param>
        /// <returns> El dia inicial o final del mes. </returns>
        public int pmtdMostrardiaInicial(int tintMes, bool tbitInicial, int tintAño)
        {
            int intDia = 0;
            switch (tintMes)
            { 
                case 1:
                    if (tbitInicial)
                        intDia = 1;
                    else
                        intDia = 31;
                    break;
                case 2:
                    if (tbitInicial)
                        intDia = 1;
                    else
                    {
                        if (tintAño % 4 == 0)
                            intDia = 29;
                        else
                            intDia = 28;
                    }
                    break;
                case 3:
                    if (tbitInicial)
                        intDia = 1;
                    else
                        intDia = 31;
                    break;
                case 4:
                    if (tbitInicial)
                        intDia = 1;
                    else
                        intDia = 30;
                    break;
                case 5:
                    if (tbitInicial)
                        intDia = 1;
                    else
                        intDia = 31;
                    break;
                case 6:
                    if (tbitInicial)
                        intDia = 1;
                    else
                        intDia = 30;
                    break;
                case 7:
                    if (tbitInicial)
                        intDia = 1;
                    else
                        intDia = 31;
                    break;
                case 8:
                    if (tbitInicial)
                        intDia = 1;
                    else
                        intDia = 31;
                    break;
                case 9:
                    if (tbitInicial)
                        intDia = 1;
                    else
                        intDia = 30;
                    break;
                case 10:
                    if (tbitInicial)
                        intDia = 1;
                    else
                        intDia = 31;
                    break;
                case 11:
                    if (tbitInicial)
                        intDia = 1;
                    else
                        intDia = 30;
                    break;
                case 12:
                    if (tbitInicial)
                        intDia = 1;
                    else
                        intDia = 31;
                    break;
            }

            return intDia;
        }

        public string pmtdNombreMes(int tintMes)
        {
            string strRespuesta = "";
            switch (tintMes)
            {
                case 1:
                    strRespuesta = "Enero";
                    break;
                case 2:
                    strRespuesta = "Febrero";
                    break;
                case 3:
                    strRespuesta = "Marzo";
                    break;
                case 4:
                    strRespuesta = "Abril";
                    break;
                case 5:
                    strRespuesta = "Mayo";
                    break;
                case 6:
                    strRespuesta = "Junio";
                    break;
                case 7:
                    strRespuesta = "Julio";
                    break;
                case 8:
                    strRespuesta = "Agosto";
                    break;
                case 9:
                    strRespuesta = "Septiembre";
                    break;
                case 10:
                    strRespuesta = "Octubre";
                    break;
                case 11:
                    strRespuesta = "Noviembre";
                    break;
                case 12:
                    strRespuesta = "Diciembre";
                    break;
            }

            return strRespuesta;
        }

        /// <summary> Calcula el numero del mes de acuerdo a la descripcion </summary>
        /// <param name="strEvaluar"> Descripcion del mes </param>
        /// <returns> Numero del mes calculado. </returns>
        private int calcularNumeroMes(string strEvaluar)
        {
            int intResultado = 0;
            switch (strEvaluar.Trim())
            {
                case "Ene":
                    intResultado = 1;
                    break;
                case "Feb":
                    intResultado = 2;
                    break;
                case "Mar":
                    intResultado = 3;
                    break;
                case "Abr":
                    intResultado = 4;
                    break;
                case "May":
                    intResultado = 5;
                    break;
                case "Jun":
                    intResultado = 6;
                    break;
                case "Jul":
                    intResultado = 7;
                    break;
                case "Ago":
                    intResultado = 8;
                    break;
                case "Sep":
                    intResultado = 9;
                    break;
                case "Oct":
                    intResultado = 10;
                    break;
                case "Nov":
                    intResultado = 11;
                    break;
                case "Dic":
                    intResultado = 12;
                    break;
            }

            return intResultado;
        }

    }
}
