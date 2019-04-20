using System;
using System.Collections.Generic;
using System.Linq;
using libMutuales2020.dominio;

namespace libMutuales2020.dao
{
    class daoBarrio
    {
        /// <summary> Inserta un barrio. </summary>
        /// <param name="tobjBarrio"> Un objeto del tipo barrio. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblBarrio tobjBarrio)
        {
            String strRetornar;
            try
            {
                using (dbExequial2010DataContext barrio = new dbExequial2010DataContext())
                {
                    barrio.tblBarrios.InsertOnSubmit(tobjBarrio);
                    barrio.tblLogdeActividades.InsertOnSubmit(tobjBarrio.log);
                    barrio.SubmitChanges();
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

        /// <summary> Modifica un barrio. </summary>
        /// <param name="tobjBarrio"> Un objeto del tipo barrio.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblBarrio tobjBarrio)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext barrio = new dbExequial2010DataContext())
                {
                    tblBarrio bar_old = barrio.tblBarrios.SingleOrDefault(p => p.strCodBarrio == tobjBarrio.strCodBarrio);
                    bar_old.strNomBarrio = tobjBarrio.strNomBarrio;
                    bar_old.strCodMunicipio = tobjBarrio.strCodMunicipio;
                    barrio.tblLogdeActividades.InsertOnSubmit(tobjBarrio.log);
                    barrio.SubmitChanges();
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

        /// <summary> Consulta todos los barrios registrados a un determinado municipio. </summary>
        /// <param name="tstrCodMunicipio"> El código del municipio del que se van a consultar los datos </param>
        /// <returns> Un lista con todos los barrios seleccionados. </returns>
        public IList<barrio> gmtdConsultarTodos(string tstrCodMunicipio)
        {
            using (dbExequial2010DataContext barrio = new dbExequial2010DataContext())
            {
                var query = from bar in barrio.tblBarrios
                            join mun in barrio.tblMunicipios on bar.strCodMunicipio equals mun.strCodMunicipio
                            where mun.strCodMunicipio == tstrCodMunicipio
                            select new { bar.strCodBarrio, bar.strNomBarrio, mun.strNomMunicipio };  
                List<barrio> lstBarrio = new List<barrio>();

                foreach (var dato in query.ToList())
                {
                    barrio bar = new barrio();
                    bar.strCodBarrio = dato.strCodBarrio;
                    bar.strNomMunicipio = dato.strNomMunicipio;
                    bar.strNomBarrio = dato.strNomBarrio;
                    lstBarrio.Add(bar);
                }
                return lstBarrio;
            }
        }

        /// <summary> Consulta todos los barrios registrados. </summary>
        /// <returns> Un lista con todos los barrios seleccionados. </returns>
        public IList<barrio> gmtdConsultarTodos()
        {
            using (dbExequial2010DataContext barrio = new dbExequial2010DataContext())
            {
                var query = from bar in barrio.tblBarrios
                            join mun in barrio.tblMunicipios on bar.strCodMunicipio equals mun.strCodMunicipio
                            select new { bar.strCodBarrio, bar.strNomBarrio, mun.strNomMunicipio };
                List<barrio> lstBarrio = new List<barrio>();

                foreach (var dato in query.ToList())
                {
                    barrio bar = new barrio();
                    bar.strCodBarrio = dato.strCodBarrio;
                    bar.strNomMunicipio = dato.strNomMunicipio;
                    bar.strNomBarrio = dato.strNomBarrio;
                    lstBarrio.Add(bar);
                }
                return lstBarrio;
            }
        }

        /// <summary> Consulta todos los barrios registrados. </summary>
        /// <returns> Un lista con todos los barrios seleccionados. </returns>
        public IList<barrio> gmtdConsultarBarriosconMunicipios()
        {
            using (dbExequial2010DataContext barrio = new dbExequial2010DataContext())
            {
                var query = from bar in barrio.tblBarrios
                            join mun in barrio.tblMunicipios on bar.strCodMunicipio equals mun.strCodMunicipio
                            orderby bar.strNomBarrio ascending
                            select new { bar.strCodBarrio, bar.strNomBarrio, mun.strNomMunicipio };
                List<barrio> lstBarrio = new List<barrio>();

                foreach (var dato in query.ToList())
                {
                    barrio bar = new barrio();
                    bar.strCodBarrio = dato.strCodBarrio;
                    bar.strNomMunicipio = dato.strNomMunicipio;
                    bar.strNomBarrio = dato.strNomBarrio + "-" + dato.strNomMunicipio;
                    lstBarrio.Add(bar);
                }
                return lstBarrio;
            }
        }

        /// <summary> Consulta un determinado barrio. </summary>
        /// <param name="tstrCodMunicipio">el código del barrio a consultar.</param>
        /// <returns> un objeto del tipo tblBarriio. </returns>
        public tblBarrio gmtdConsultar(string tstrCodBarrio)
        {
            using (dbExequial2010DataContext barrio = new dbExequial2010DataContext())
            {
                var query = from bar in barrio.tblBarrios
                            where bar.strCodBarrio == tstrCodBarrio
                            select bar;

                if (query.ToList().Count > 0)
                    return query.ToList()[0];
                else
                    return new tblBarrio();
            }
        }

        /// <summary> Seleccionar todos los barrios registrados. </summary>
        /// <returns> Un lista con los barrios registrados. </returns>
        public IList<tblBarrio> gmtdConsultar()
        {
            using (dbExequial2010DataContext barrio = new dbExequial2010DataContext())
            {
                var query = from bar in barrio.tblBarrios
                            orderby bar.strCodMunicipio 
                            select bar;

                    return query.ToList();
            }
        }

        /// <summary> Elimina un barrio de la base de datos. </summary>
        /// <param name="tobjBarrio"> Un objeto del tipo tblBarrio. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblBarrio tobjBarrio)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext barrio = new dbExequial2010DataContext())
                {
                    var query = from bar in barrio.tblBarrios
                                where bar.strCodBarrio == tobjBarrio.strCodBarrio
                                select bar;

                    foreach (var detail in query)
                    {
                        barrio.tblBarrios.DeleteOnSubmit(detail);
                    }

                    barrio.tblLogdeActividades.InsertOnSubmit(tobjBarrio.log);
                    barrio.SubmitChanges();
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
