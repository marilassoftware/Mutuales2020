using System;
using System.Collections.Generic;
using System.Linq;
using libMutuales2020.dominio;

namespace libMutuales2020.dao
{
    class daoOficio
    {
        /// <summary>
        /// Inserta un oficio.
        /// </summary>
        /// <param name="tobjOficio"> Un objeto del tipo oficio. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblOficio tobjOficio)
        {
            String strRetornar;
            try
            {
                using (dbExequial2010DataContext oficio = new dbExequial2010DataContext())
                {
                    oficio.tblOficios.InsertOnSubmit(tobjOficio);
                    oficio.tblLogdeActividades.InsertOnSubmit(tobjOficio.log);
                    oficio.SubmitChanges();
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

        /// <summary>
        /// Modifica el nombre de un oficio.
        /// </summary>
        /// <param name="tobjOficio"> Un objeto del tipo Oficio. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblOficio tobjOficio)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext oficio = new dbExequial2010DataContext())
                {
                    tblOficio ofi_old = oficio.tblOficios.SingleOrDefault(p => p.strCodOficio == tobjOficio.strCodOficio);
                    ofi_old.strNomOficio = tobjOficio.strNomOficio;
                    oficio.tblLogdeActividades.InsertOnSubmit(tobjOficio.log);
                    oficio.SubmitChanges();
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

        /// <summary>
        /// Consulta todos los oficios registrados.
        /// </summary>
        /// <returns> Un lista con los oficios registrados. </returns>
        public IList<oficio> gmtdConsultarTodos()
        {
            using (dbExequial2010DataContext oficio = new dbExequial2010DataContext())
            {
                var query = from ofc in oficio.tblOficios
                            select ofc;
                List<oficio> lstOficio = new List<oficio>();

                foreach (var dato in query.ToList())
                {
                    oficio ofc = new oficio();
                    ofc.strCodOficio = dato.strCodOficio;
                    ofc.strNomOficio = dato.strNomOficio;
                    lstOficio.Add(ofc);
                }
                return lstOficio;
            }
        }

        /// <summary>
        /// Busca los datos de un determinado oficio.
        /// </summary>
        /// <param name="tstrCodOficio"> El código del oficio del que se quiere conocer los datos. </param>
        /// <returns> Un objeto del tipo Oficio. </returns>
        public tblOficio gmtdConsultar(string tstrCodOficio)
        {
            using (dbExequial2010DataContext oficio = new dbExequial2010DataContext())
            {
                var query = from ofc in oficio.tblOficios
                            where ofc.strCodOficio == tstrCodOficio
                            select ofc;

                if (query.ToList().Count > 0)
                    return query.ToList()[0];
                else
                    return new tblOficio();
            }
        }

        /// <summary>
        /// Elimina un oficio.
        /// </summary>
        /// <param name="tobjOficio"> Un objeto del tipo oficio que se va a eliminar. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public String gmtdEliminar(tblOficio tobjOficio)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext oficio = new dbExequial2010DataContext())
                {
                    var query = from ofc in oficio.tblOficios
                                where ofc.strCodOficio == tobjOficio.strCodOficio
                                select ofc;

                    foreach (var detail in query)
                    {
                        oficio.tblOficios.DeleteOnSubmit(detail);
                    }

                    oficio.tblLogdeActividades.InsertOnSubmit(tobjOficio.log);
                    oficio.SubmitChanges();
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
