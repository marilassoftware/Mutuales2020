using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libMutuales2020.dominio;

namespace libMutuales2020.dao
{
    class daoProvedor
    {
        /// <summary> Inserta un provedor </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo tblProvedor. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblProvedore tobjProvedor)
        {
            String strRetornar;
            try
            {
                using (dbExequial2010DataContext prove = new dbExequial2010DataContext())
                {
                    prove.tblProvedores.InsertOnSubmit(tobjProvedor);
                    prove.tblLogdeActividades.InsertOnSubmit(tobjProvedor.log);
                    prove.SubmitChanges();
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

        /// <summary> Modifica un provedor. </summary>
        /// <param name="tobjProvedor"> Un objeto del tipo tblProvedor. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblProvedore tobjProvedor)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext prove = new dbExequial2010DataContext())
                {
                    tblProvedore pro_old = prove.tblProvedores.SingleOrDefault(p => p.strCodProvedor == tobjProvedor.strCodProvedor);
                    pro_old.strConProvedor = tobjProvedor.strConProvedor;
                    pro_old.strDirProvedor = tobjProvedor.strDirProvedor;
                    pro_old.strEmpProvedor = tobjProvedor.strEmpProvedor;
                    pro_old.strMailProvedor = tobjProvedor.strMailProvedor;
                    pro_old.strTelProvedor = tobjProvedor.strTelProvedor;
                    prove.tblLogdeActividades.InsertOnSubmit(tobjProvedor.log);
                    prove.SubmitChanges();
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

        /// <summary> Consulta todos los provedores registrados. </summary>
        /// <returns> Un lista con todos los provedores registrados. </returns>
        public IList<provedor> gmtdConsultarTodos()
        {
            using (dbExequial2010DataContext prove = new dbExequial2010DataContext())
            {
                var query = from tip in prove.tblProvedores
                            select tip;
                List<provedor> lstProvedores = new List<provedor>();

                foreach (var dato in query.ToList())
                {
                    provedor pro = new provedor();
                    pro.strCodProvedor = dato.strCodProvedor;
                    pro.strConProvedor = dato.strConProvedor;
                    pro.strDirProvedor = dato.strDirProvedor;
                    pro.strEmpProvedor = dato.strEmpProvedor;
                    pro.strMailProvedor = dato.strMailProvedor;
                    pro.strTelProvedor = dato.strTelProvedor;
                    lstProvedores.Add(pro);
                }
                return lstProvedores;
            }
        }

        /// <summary> Consulta un determinado provedor. </summary>
        /// <param name="tstrCodProvedor">el código del provedor a consultar. </param>
        /// <returns> un objeto del tipo tblProvedore. </returns>
        public tblProvedore gmtdConsultar(string tstrCodProvedor)
        {
            using (dbExequial2010DataContext prove = new dbExequial2010DataContext())
            {
                var query = from pro in prove.tblProvedores
                            where pro.strCodProvedor == tstrCodProvedor
                            select pro;

                if (query.ToList().Count > 0)
                    return query.ToList()[0];
                else
                    return new tblProvedore();
            }
        }

        /// <summary> Elimina un provedor. </summary>
        /// <param name="tobjProvedor"> Un objeto del tipo provedor. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblProvedore tobjProvedor)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext pro = new dbExequial2010DataContext())
                {
                    var query = from tip in pro.tblProvedores
                                where tip.strCodProvedor == tobjProvedor.strCodProvedor
                                select tip;

                    foreach (var detail in query)
                    {
                        pro.tblProvedores.DeleteOnSubmit(detail);
                    }

                    pro.tblLogdeActividades.InsertOnSubmit(tobjProvedor.log);
                    pro.SubmitChanges();
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
