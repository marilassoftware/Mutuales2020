using System;
using System.Collections.Generic;
using System.Linq;
using libMutuales2020.dominio;

namespace libMutuales2020.dao
{
    class daoSemana
    {
        /// <summary> Inserta una semana. </summary>
        /// <param name="tobjSemana"> Un objeto del tipo semana. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblSemana tobjSemana)
        {
            String strRetornar;
            try
            {
                using (dbExequial2010DataContext semana = new dbExequial2010DataContext())
                {
                    semana.tblSemanas.InsertOnSubmit(tobjSemana);
                    semana.tblLogdeActividades.InsertOnSubmit(tobjSemana.log);
                    semana.SubmitChanges();
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

        /// <summary> Modificar una semana. </summary>
        /// <param name="tobjSemana"> Un objeto del tipo semana. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblSemana tobjSemana)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext semana = new dbExequial2010DataContext())
                {
                    tblSemana sem_old = semana.tblSemanas.SingleOrDefault(p => p.intCodigoSem == tobjSemana.intCodigoSem);
                    sem_old.dtmFechaSem = tobjSemana.dtmFechaSem;
                    sem_old.intAño = tobjSemana.intAño;
                    sem_old.strTipo = tobjSemana.strTipo;
                    semana.tblLogdeActividades.InsertOnSubmit(tobjSemana.log);
                    semana.SubmitChanges();
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

        /// <summary> Consulta todas las semanas registradas. </summary>
        /// <returns> Una lista con las semanas registradas. </returns>
        public IList<semana> gmtdConsultarTodos()
        {
            using (dbExequial2010DataContext semana = new dbExequial2010DataContext())
            {
                var query = from sem in semana.tblSemanas
                            select sem;
                List<semana> lstSemana = new List<semana>();

                foreach (var dato in query.ToList())
                {
                    semana sna = new semana();
                    sna.intCodigoSem = dato.intCodigoSem;
                    sna.dtmFechaSem = dato.dtmFechaSem.ToShortDateString();
                    sna.intAño = (int)dato.intAño;
                    sna.strTipo = dato.strTipo;
                    lstSemana.Add(sna);
                }

                return lstSemana;
            }
        }

        /// <summary> Consulta los datos de una determinada semana. </summary>
        /// <param name="tstrCodSemana"> El código de la semana a consultal. </param>
        /// <returns> un objeto del tipo semana. </returns>
        public tblSemana gmtdConsultar(string tstrCodSemana)
        {
            using (dbExequial2010DataContext semana = new dbExequial2010DataContext())
            {
                var query = from sna in semana.tblSemanas
                            where sna.intCodigoSem  == Convert.ToInt32(tstrCodSemana)
                            select sna;

                if (query.ToList().Count > 0)
                    return query.ToList()[0];
                else
                    return new tblSemana();
            }
        }

        /// <summary> Consulta las semanas registradas de un año. </summary>
        /// <param name="tintAño"> Año del que se quiere conocer las semanas. </param>
        /// <returns></returns>
        public List<tblSemana> gmtdConsultarSemanasxAño(int tintAño)
        {
            using (dbExequial2010DataContext semana = new dbExequial2010DataContext())
            {
                var query = from sna in semana.tblSemanas
                            where sna.intAño == tintAño
                            select sna;

                return query.ToList();
            }
        }

        /// <summary> Consulta las semanas registradas de un año x tipo de semana. </summary>
        /// <param name="tintAño"> Año del que se quiere conocer las semanas. </param>
        /// <param name="tstrTipo"> Año del que se quiere conocer las semanas. </param>
        /// <returns></returns>
        public List<tblSemana> gmtdConsultarSemanasxAñoxTipo(int tintAño, string tstrTipo)
        {
            using (dbExequial2010DataContext semana = new dbExequial2010DataContext())
            {
                var query = from sna in semana.tblSemanas
                            where sna.intAño == tintAño
                            && sna.strTipo == tstrTipo
                            select sna;

                return query.ToList();
            }
        }

        /// <summary> Elimina una semana. </summary>
        /// <param name="tobjSemana"> Un objeto del tipo semana a eliminar. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public String gmtdEliminar(tblSemana tobjSemana)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext semana = new dbExequial2010DataContext())
                {
                    var query = from sna in semana.tblSemanas
                                where sna.intCodigoSem == tobjSemana.intCodigoSem
                                select sna;

                    foreach (var detail in query)
                    {
                        semana.tblSemanas.DeleteOnSubmit(detail);
                    }

                    semana.tblLogdeActividades.InsertOnSubmit(tobjSemana.log);
                    semana.SubmitChanges();
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
