namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fUtilidadesInformeMafre
    {
        /// <summary> Consulta los registros de una determinada fecha. </summary>
        /// <param name="tdtmFecha"> Fecha a consultar. </param>
        /// <returns> Listado con los datos a consultar. </returns>
        public List<tblInformeMafre> consultaInformexFecha(DateTime tdtmFecha)
        {
            return new blUtilidadesInformeMafre().consultaInformexFecha(tdtmFecha);
        }

        /// <summary> Consulta los registros de una determinada fecha por tipo. </summary>
        /// <param name="tdtmFecha"> Fecha a consultar. </param>
        /// <param name="tstrTipo"> Indica si se van a seleccionar los estables los a sacar o los a adicionarl </param>
        /// <returns> Listado con los datos a consultar. </returns>
        public List<tblInformeMafre> consultaInformexFechaxTipo(DateTime tdtmFecha, string tstrTipo)
        {
            return new blUtilidadesInformeMafre().consultaInformexFechaxTipo(tdtmFecha, tstrTipo);
        }

        /// <summary> Actualiza un determinado registro </summary>
        /// <param name="tobjInformeMafre"> Un objeto con los datos a actualizar. </param>
        /// <returns> Un valor indicando si se ejecuto o no la operacion. </returns>
        public bool actualizar(tblInformeMafre tobjInformeMafre)
        {
            return new blUtilidadesInformeMafre().actualizar(tobjInformeMafre);
        }
    }
}
