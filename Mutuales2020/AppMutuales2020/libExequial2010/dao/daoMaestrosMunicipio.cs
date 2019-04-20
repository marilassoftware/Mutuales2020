using System;
using System.Collections.Generic;
using System.Linq;
using libMutuales2020.dominio;

namespace libMutuales2020.dao
{
    class daoMunicipio
    {
        /// <summary> Inserta un municipio. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo municipio. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblMunicipio tobjMunicipio)
        {
            String strRetornar;
            try
            {
                using (dbExequial2010DataContext maestro = new dbExequial2010DataContext())
                {
                    maestro.tblMunicipios.InsertOnSubmit(tobjMunicipio);
                    maestro.tblLogdeActividades.InsertOnSubmit(tobjMunicipio.log);
                    maestro.SubmitChanges();
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

        /// <summary> Modifica un municipio. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo municipio.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblMunicipio tobjMunicipio)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext maestro = new dbExequial2010DataContext())
                {
                    tblMunicipio mun_old = maestro.tblMunicipios.SingleOrDefault(p => p.strCodMunicipio == tobjMunicipio.strCodMunicipio);
                    mun_old.strNomMunicipio = tobjMunicipio.strNomMunicipio;
                    maestro.tblLogdeActividades.InsertOnSubmit(tobjMunicipio.log);
                    maestro.SubmitChanges();
                    strResultado = "Registro Actualizado";
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                strResultado = "- Ocurrió un error al Actualizar el registro";
            }
            return strResultado;
        }

        /// <summary> Consulta todos los municipios registrados. </summary>
        /// <param name="tAplicacion"> Un objeto del tipo municipio. </param>
        /// <returns> Un lista con todos los municipios seleccionados. </returns>
        public List<municipio> gmtdConsultarTodos()
        {
            using (dbExequial2010DataContext maestro = new dbExequial2010DataContext())
            {
                var query = from mcp in maestro.tblMunicipios 
                            select mcp;
                List<municipio> lstMunicipio = new List<municipio>();

                foreach (var dato in query.ToList())
                {
                    municipio muni = new municipio();
                    muni.strCodMunicipio = dato.strCodMunicipio;
                    muni.strNomMunicipio = dato.strNomMunicipio;
                    lstMunicipio.Add(muni);
                }
                return lstMunicipio;
            }
        }

        /// <summary> Consulta un determinado municipio. </summary>
        /// <param name="tstrCodMunicipio">el código del municipio a consultar.</param>
        /// <returns> un objeto del tipo tblmunicipio. </returns>
        public tblMunicipio gmtdConsultar(string tstrCodMunicipio)
        {
            using (dbExequial2010DataContext maestro = new dbExequial2010DataContext())
            {
                var query = from mcp in maestro.tblMunicipios
                            where mcp.strCodMunicipio == tstrCodMunicipio  
                            select mcp;

                if (query.ToList().Count > 0)
                    return query.ToList()[0];
                else
                    return new tblMunicipio();
            }
        }

        /// <summary> Elimina un municipio de la base de datos. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo munipio. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblMunicipio tobjMunicipio)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext maestro = new dbExequial2010DataContext())
                {
                    var query = from mun in maestro.tblMunicipios 
                                where mun.strCodMunicipio == tobjMunicipio.strCodMunicipio 
                                select mun;

                    foreach (var detail in query)
                    {
                        maestro.tblMunicipios.DeleteOnSubmit(detail);
                    }

                    maestro.tblLogdeActividades.InsertOnSubmit(tobjMunicipio.log);
                    maestro.SubmitChanges();
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
