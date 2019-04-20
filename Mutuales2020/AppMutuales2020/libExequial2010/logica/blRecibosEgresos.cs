namespace libMutuales2020.logica
{
    using libMutuales2020.dao;
    using libMutuales2020.dominio;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;

    [DataObject(true)]
    public class blRecibosEgresos
    {
        static public XmlDocument SerializeServicio(tblEgreso objIngreso)
        {
            XmlSerializer ser = new XmlSerializer(typeof(tblEgreso));

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
        public string gmtdInsertar(tblEgreso tobjEgreso)
        {
            if (tobjEgreso.egresoEgreso != null)
            {
                for (int a = 0; a < tobjEgreso.egresoEgreso.Count; a++)
                    tobjEgreso.egresoEgreso[a].strCodigoPar = new blOtroEgreso().gmtdConsultar(tobjEgreso.egresoEgreso[a].strCodOtrosEgresos).strCodigoPar;
            }

            if (tobjEgreso.egresoAbonoaPrestamo != null)
                tobjEgreso.egresoAbonoaPrestamo.strCodigoPar = "0001";

            if (tobjEgreso.egresoAhorroalaVista != null)
                tobjEgreso.egresoAhorroalaVista.strCodigoPar = "0001";

            if (tobjEgreso.egresoAhorroEstudiantil != null)
                tobjEgreso.egresoAhorroEstudiantil.strCodigoPar = "0001";

            if (tobjEgreso.egresoAhorroFijo != null)
                tobjEgreso.egresoAhorroFijo.strCodigoPar = "0001";

            if (tobjEgreso.egresoIntereses != null)
                tobjEgreso.egresoIntereses.strCodigoPar = "0001";

            XmlDocument xml = blRecibosEgresos.SerializeServicio(tobjEgreso);

            string Resultado = new daoRecibosEgresos().gmtdInsertar(xml);

            if(Resultado == "0")
            {
                return "- Ha ocurrido un error al ingresar el egreso.";
            }
            else
            {
                return Resultado + "+Egreso ingresado.";
            }
        }

        /// <summary> Consulta los datos de un determinado egreso. </summary>
        /// <param name="tintRecibo"> Código del egreso a consultar. </param>
        /// <returns> Retorna los datos del egreso. </returns>
        public tblEgreso gmtdConsultaEgreso(int tintRecibo)
        {
            return new daoRecibosEgresos().gmtdConsultaEgreso(tintRecibo);
        }

        /// <summary> Consulta los datos de un determinado egreso. </summary>
        /// <param name="tintRecibo"> Código del egreso a consultar. </param>
        /// <returns> Retorna los datos del egreso. </returns>
        public string gmtdEliminarEgreso(tblEgreso tobjEgreso)
        {
            tobjEgreso.dtmFechaAnu = new blConfiguracion().gmtdCapturarFechadelServidor();

            tblAhorradore ahorrador = new daoAhorrador().gmtdConsultar(tobjEgreso.strCedulaEgre);

            if (tobjEgreso.egresoAhorroalaVista != null)
                tobjEgreso.egresoAhorroalaVista.decAhorrado = ahorrador.decAhorrado;

            if (tobjEgreso.egresoAhorroEstudiantil != null)
                tobjEgreso.egresoAhorroEstudiantil.decAhorrado = ahorrador.decAhorrosEstudiantes;

            if (tobjEgreso.egresoAhorroFijo != null)
                tobjEgreso.egresoAhorroFijo.decAhorrado = ahorrador.decAhorrosFijo;


            return new daoRecibosEgresos().gmtdEliminarEgreso(tobjEgreso);
        }

        /// <summaiy> Imprimir recibos. </summary>
        /// <param name="tintCodigoIng"> Codigo de recibo de ingreso. </param>
        public void gmtdImprimirEgreso(int tintCodigoEgr)
        {
            new daoRecibosEgresos().gmtdImprimirEgreso(tintCodigoEgr);
        }

        /// <summary> Consulta los ingresos activos en un rango de fechas. </summary>
        /// <param name="tdtmFecha"> La fecha hasta la cual se quieren conocer los datos. </param>
        /// <param name="tintMeses"> Meses de los que se quieren conocer los datos.  </summary>
        /// <returns> Diccionario con los datos consultados. </returns>
        public Dictionary<string, string> gmtdConsultarEgresosAgrupadosenunRangodeFechas(DateTime tdtmFecha, int tintMeses)
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

                DateTime dtmFechaIni = Convert.ToDateTime(intAño.ToString() + "-" + intMes.ToString() + "-" + new blRecibosIngresos().pmtdMostrardiaInicial(intMes, true, intAño).ToString());
                DateTime dtmFechaFin = Convert.ToDateTime(intAño.ToString() + "-" + intMes.ToString() + "-" + new blRecibosIngresos().pmtdMostrardiaInicial(intMes, false, intAño).ToString());

                fechasInciales[a] = dtmFechaIni;
                fechasFinales[a] = dtmFechaFin;

                intMes--;

            }

            for (int a = tintMeses - 1; a >= 0; a--)
            {
                decimal decValor = new daoRecibosEgresos().gmtdConsultarEgresosAgrupadosenunRangodeFechas(fechasInciales[a], fechasFinales[a]);

                decimal decCreditos = 0; //new daoRecibosEgresos().gmtdConsultarEgresosporCreditosenunRangodeFechas(fechasInciales[a], fechasFinales[a]);

                decValor = decValor - decCreditos;

                lstMeses.Add(new blRecibosIngresos().pmtdNombreMes(fechasInciales[a].Month), decValor.ToString());
            }

            return lstMeses;
        }

        /// <summary> Consulta los egresos activos de ahorros en un rango de fechas. </summary>
        /// <param name="tdtmFecha"> La fecha hasta la cual se quieren conocer los datos. </param>
        /// <param name="tintMeses"> Meses de los que se quieren conocer los datos.  </summary>
        /// <returns> Diccionario con los datos consultados. </returns>
        public Dictionary<string, string> gmtdConsultarEgresosdeAhorrosAgrupadosenunRangodeFechas(DateTime tdtmFecha, int tintMeses)
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

                DateTime dtmFechaIni = Convert.ToDateTime(intAño.ToString() + "-" + intMes.ToString() + "-" + new blRecibosIngresos().pmtdMostrardiaInicial(intMes, true, intAño).ToString());
                DateTime dtmFechaFin = Convert.ToDateTime(intAño.ToString() + "-" + intMes.ToString() + "-" + new blRecibosIngresos().pmtdMostrardiaInicial(intMes, false, intAño).ToString());

                fechasInciales[a] = dtmFechaIni;
                fechasFinales[a] = dtmFechaFin;

                intMes--;

            }

            for (int a = tintMeses - 1; a >= 0; a--)
            {
                decimal decValor = new daoRecibosEgresos().gmtdConsultarEgresosdeAhorrosAgrupadosenunRangodeFechas(fechasInciales[a], fechasFinales[a]);

                decimal decCreditos = 0; //new daoRecibosEgresos().gmtdConsultarEgresosporCreditosenunRangodeFechas(fechasInciales[a], fechasFinales[a]);

                decValor = decValor - decCreditos;

                lstMeses.Add(new blRecibosIngresos().pmtdNombreMes(fechasInciales[a].Month), decValor.ToString());
            }

            return lstMeses;
        }

    }
}
