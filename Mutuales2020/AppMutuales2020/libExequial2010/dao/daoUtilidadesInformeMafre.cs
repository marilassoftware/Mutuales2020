namespace libMutuales2020.dao
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using libMutuales2020.dominio;

    public class daoUtilidadesInformeMafre
    {
        /// <summary> Consulta los registros de una determinada fecha. </summary>
        /// <param name="tdtmFecha"> Fecha a consultar. </param>
        /// <returns> Listado con los datos a consultar. </returns>
        public List<tblInformeMafre> consultaInformexFecha(DateTime tdtmFecha)
        {
            using (dbExequial2010DataContext db = new dbExequial2010DataContext())
            {
                var query = from consu in db.tblInformeMafres
                            where consu.Fecha.Value.Year == tdtmFecha.Year && consu.Fecha.Value.Month == tdtmFecha.Month
                            select consu;

                return query.ToList();
            }
        }

        /// <summary> Actualiza un determinado registro </summary>
        /// <param name="tobjInformeMafre"> Un objeto con los datos a actualizar. </param>
        /// <returns> Un valor indicando si se ejecuto o no la operacion. </returns>
        public bool actualizar(tblInformeMafre tobjInformeMafre)
        {
            try
            {
                using (dbExequial2010DataContext db = new dbExequial2010DataContext())
                {
                    tblInformeMafre inf_old = db.tblInformeMafres.SingleOrDefault(p => p.intCodigo == tobjInformeMafre.intCodigo);
                    //inf_old.bitSocio = tobjInformeMafre.bitSocio;
                    //inf_old.Fecha = tobjInformeMafre.Fecha;
                    //inf_old.FechaNac = tobjInformeMafre.FechaNac;
                    //inf_old.intSocio = tobjInformeMafre.intSocio;
                    //inf_old.strApellido = tobjInformeMafre.strApellido;
                    //inf_old.strCedula = tobjInformeMafre.strCedula;
                    inf_old.strEstado = tobjInformeMafre.strEstado;
                    //inf_old.strNombre = tobjInformeMafre.strNombre;
                    db.SubmitChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                return false;
            }
        }
    }
}
