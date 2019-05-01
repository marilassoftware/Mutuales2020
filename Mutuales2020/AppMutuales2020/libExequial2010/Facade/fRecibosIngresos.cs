namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fRecibosIngresos
    {
        /// <summary> Inserta una cuenta de ahorro a futuro. </summary>
        /// <param name="tobjIngreso"> Un objeto del tipo ingreso. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblIngreso tobjIngreso)
        {
            return new blRecibosIngresos().gmtdInsertar(tobjIngreso);
        }

        /// <summary> Ingresa el nùmero de rifa de un socio. </summary>
        /// <param name="tintCodigoSoc"> Còdigo del socio para el nùemro de la rifa. </param>
        /// <param name="tintAño"> Año para el nùmero de la rifa. </param>
        /// <param name="tintMes"> Mes para el nùmero de la rifa. </param>
        public void gmtdIngresarNumeroRifa(int tintCodigoSoc, int tintAño, int tintMes)
        {
            new blRecibosIngresos().gmtdIngresarNumeroRifa(tintCodigoSoc, tintAño, tintMes);
        }

        /// <summary> Migra los recibos anteriores </summary>
        /// <param name="tobjIngreso"> el recibo </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdMigrarRecibos(tblIngreso tobjIngreso)
        {
            return new blRecibosIngresos().gmtdMigrarRecibos(tobjIngreso);
        }

        /// <summary> Consulta los datos de los diferentes recibos de acuerdo al código del socio. </summary>
        /// <param name="tintCodigoSoc"> Código del socio a consultar. </param>
        /// <returns> Datos consultados. </returns>
        public recibosDatos gmtdConsultarDatos(int tintCodigoSoc)
        {
            return new blRecibosIngresos().gmtdConsultarDatos(tintCodigoSoc);
        }

        public List<otrosIngresos> gmtdListaOtrosIngresos(List<otrosIngresos> tobjOtrosIngresos)
        {
            return new blRecibosIngresos().gmtdListaOtrosIngresos(tobjOtrosIngresos);
        }

        /// <summary> Consulta los datos de un determinado recibo. </summary>
        /// <param name="tintRecibo"> Código del recibo a consultar. </param>
        /// <returns> Retorna los datos del recibo. </returns>
        public tblIngreso gmtdConsultaIngreso(int tintRecibo)
        {
            return new blRecibosIngresos().gmtdConsultaIngreso(tintRecibo);
        }

        /// <summary> Consulta los datos de recibos registrados en un rango de fecha. </summary>
        /// <param name="tdtmFechaInicial"> Fecha inicial de la busqueda. </param>
        /// <param name="tdtmFechaFinal"> Fecha final de la busqueda. </param>
        /// <returns> Lista con los recibos consultados. </returns>
        public List<tblIngreso> gmtdConsultaIngresos(DateTime tdtmFechaInicial, DateTime tdtmFechaFinal)
        {
            return new blRecibosIngresos().gmtdConsultaIngresos(tdtmFechaInicial, tdtmFechaFinal);
        }

        /// <summary> Elimina un recibo de ingreso. </summary>
        /// <param name="tobjIngreso"> Un objeto del tipo ingreso. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEliminar(int intCodigoIng)
        {
            return new blRecibosIngresos().gmtdEliminar(intCodigoIng);
        }

        /// <summaiy> Imprimir recibos. </summary>
        /// <param name="tintCodigoIng"> Codigo de recibo de ingreso. </param>
        public void gmtdImprimiringreso(int tintCodigoIng)
        {
            new blRecibosIngresos().gmtdImprimiringreso(tintCodigoIng);
        }

        /// <summary> Genera el archivo Xml para el recibo de ahorros. </summary>
        /// <param name="tstrTransaccioncion"> Un string que indica 'Retiros' 0 'Ahorros' </param>
        /// <param name="tintCodigoRec"> El código del recibo que se quiere imprimir. </param>
        public void gmtdImprimirAhorro(string tstrTransaccioncion, int tintCodigoRec)
        {
            new blRecibosIngresos().gmtdImprimirAhorro(tstrTransaccioncion, tintCodigoRec);
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
            return new blRecibosIngresos().gmtdMvtoContableIngresos(decValor, tintCodigoIng, tstrCodigoCuo, tstrDescripcion,  tintTipoMvto,  tstrCedula,  tstrNombre,  tdtmFecha);
        }

        /// <summary> Selecciona la deuda de una determinada persona. </summary>
        /// <param name="tstrCedula"> Numero de la cédula de la persona. </param>
        /// <returns> El listado de las deudas de la persona. </returns>
        public List<tblEstadodeCuenta> gmtdSumarDeudasxPersona(string tstrCedula)
        {
            return new blRecibosIngresos().gmtdSumarDeudasxPersona(tstrCedula);
        }

        /// <summary> Consulta los ingresos activos en un rango de fechas. </summary>
        /// <param name="tdtmFecha"> La fecha hasta la cual se quieren conocer los datos. </param>
        /// <param name="tintMeses"> Meses de los que se quieren conocer los datos.  </summary>
        /// <returns> Diccionario con los datos consultados. </returns>
        public Dictionary<string, string> gmtdConsultarIngresosAgrupadosenunRangodeFechas(DateTime tdtmFecha, int tintMeses)
        {
            return new blRecibosIngresos().gmtdConsultarIngresosAgrupadosenunRangodeFechas(tdtmFecha, tintMeses);
        }

        /// <summary> Consulta los ingresos activos de ahorros en un rango de fechas. </summary>
        /// <param name="tdtmFecha"> La fecha hasta la cual se quieren conocer los datos. </param>
        /// <param name="tintMeses"> Meses de los que se quieren conocer los datos.  </summary>
        /// <returns> Diccionario con los datos consultados. </returns>
        public Dictionary<string, string> gmtdConsultarIngresosdeAhorrosAgrupadosenunRangodeFechas(DateTime tdtmFecha, int tintMeses)
        {
            return new blRecibosIngresos().gmtdConsultarIngresosdeAhorrosAgrupadosenunRangodeFechas(tdtmFecha, tintMeses);
        }

        /// <summary> Muestra el dia inicial o final de un determinado mes. </summary>
        /// <param name="tintMes"> El mes del que se va a mostrar el día inicial o final </param>
        /// <param name="tbitInicial"> True si se quiere devolver el dìa inicial del mes o False si quiere devolver el dia final. </param>
        /// <param name="tintAño"> El año del mes al que se le va a calcular la fecha inicial. </param>
        /// <returns> El dia inicial o final del mes. </returns>
        public int pmtdMostrardiaInicial(int tintMes, bool tbitInicial, int tintAño)
        {
            return new blRecibosIngresos().pmtdMostrardiaInicial(tintMes, tbitInicial, tintAño);
        }

        public string pmtdNombreMes(int tintMes)
        {
            return new blRecibosIngresos().pmtdNombreMes(tintMes);
        }
    }
}
