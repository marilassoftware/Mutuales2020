namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fRecibosEgresos
    {
        /// <summary> Inserta una cuenta de ahorro a futuro. </summary>
        /// <param name="tobjIngreso"> Un objeto del tipo ingreso. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblEgreso tobjEgreso)
        {
            return new blRecibosEgresos().gmtdInsertar(tobjEgreso);
        }

        /// <summary> Consulta los datos de un determinado egreso. </summary>
        /// <param name="tintRecibo"> Código del egreso a consultar. </param>
        /// <returns> Retorna los datos del egreso. </returns>
        public tblEgreso gmtdConsultaEgreso(int tintRecibo)
        {
            return new blRecibosEgresos().gmtdConsultaEgreso(tintRecibo);
        }

        /// <summary> Consulta los datos de un determinado egreso. </summary>
        /// <param name="tintRecibo"> Código del egreso a consultar. </param>
        /// <returns> Retorna los datos del egreso. </returns>
        public string gmtdEliminarEgreso(tblEgreso tobjEgreso)
        {
            return new blRecibosEgresos().gmtdEliminarEgreso(tobjEgreso);
        }

        /// <summaiy> Imprimir recibos. </summary>
        /// <param name="tintCodigoIng"> Codigo de recibo de ingreso. </param>
        public void gmtdImprimirEgreso(int tintCodigoEgr)
        {
            new blRecibosEgresos().gmtdImprimirEgreso(tintCodigoEgr);
        }

        /// <summary> Consulta los ingresos activos en un rango de fechas. </summary>
        /// <param name="tdtmFecha"> La fecha hasta la cual se quieren conocer los datos. </param>
        /// <param name="tintMeses"> Meses de los que se quieren conocer los datos.  </summary>
        /// <returns> Diccionario con los datos consultados. </returns>
        public Dictionary<string, string> gmtdConsultarEgresosAgrupadosenunRangodeFechas(DateTime tdtmFecha, int tintMeses)
        {
            return new blRecibosEgresos().gmtdConsultarEgresosAgrupadosenunRangodeFechas(tdtmFecha, tintMeses);
        }

        /// <summary> Consulta los egresos activos de ahorros en un rango de fechas. </summary>
        /// <param name="tdtmFecha"> La fecha hasta la cual se quieren conocer los datos. </param>
        /// <param name="tintMeses"> Meses de los que se quieren conocer los datos.  </summary>
        /// <returns> Diccionario con los datos consultados. </returns>
        public Dictionary<string, string> gmtdConsultarEgresosdeAhorrosAgrupadosenunRangodeFechas(DateTime tdtmFecha, int tintMeses)
        {
            return new blRecibosEgresos().gmtdConsultarEgresosdeAhorrosAgrupadosenunRangodeFechas(tdtmFecha, tintMeses);
        }

    }
}
