namespace libMutuales2020.logica
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using libMutuales2020.dao;
    using libMutuales2020.dominio;

    public class blUtilidadesInformeMafre
    {
        /// <summary> Consulta los registros de una determinada fecha. </summary>
        /// <param name="tdtmFecha"> Fecha a consultar. </param>
        /// <returns> Listado con los datos a consultar. </returns>
        public List<tblInformeMafre> consultaInformexFecha(DateTime tdtmFecha)
        {
            return new daoUtilidadesInformeMafre().consultaInformexFecha(tdtmFecha);
        }

        /// <summary> Consulta los registros de una determinada fecha por tipo. </summary>
        /// <param name="tdtmFecha"> Fecha a consultar. </param>
        /// <param name="tstrTipo"> Indica si se van a seleccionar los estables los a sacar o los a adicionarl </param>
        /// <returns> Listado con los datos a consultar. </returns>
        public List<tblInformeMafre> consultaInformexFechaxTipo(DateTime tdtmFecha, string tstrTipo )
        {
            List<tblInformeMafre> lst = new daoUtilidadesInformeMafre().consultaInformexFecha(tdtmFecha);

            var query = from consu in lst
                        where consu.strEstado == tstrTipo
                        select consu;

            return query.ToList();
        }

        /// <summary> Actualiza un determinado registro </summary>
        /// <param name="tobjInformeMafre"> Un objeto con los datos a actualizar. </param>
        /// <returns> Un valor indicando si se ejecuto o no la operacion. </returns>
        public bool actualizar(tblInformeMafre tobjInformeMafre)
        {
            return new daoUtilidadesInformeMafre().actualizar(tobjInformeMafre);
        }
    }
}
