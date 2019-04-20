using System;
using System.Collections.Generic;
using System.Linq;
using libMutuales2020.dominio;

namespace libMutuales2020.dao
{
    class daoOtroEgreso
    {
        /// <summary> Inserta un Otro Egreso. </summary>
        /// <param name="tobjOtrosEgreso"> Un objeto del tipo otroEgreso. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblOtrosEgreso tobjOtrosEgreso)
        {
            String strRetornar;
            try
            {
                using (dbExequial2010DataContext otroEgreso = new dbExequial2010DataContext())
                {
                    otroEgreso.tblOtrosEgresos.InsertOnSubmit(tobjOtrosEgreso);
                    otroEgreso.tblLogdeActividades.InsertOnSubmit(tobjOtrosEgreso.log);
                    otroEgreso.SubmitChanges();
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

        /// <summary> Modifica un Otro Egreso. </summary>
        /// <param name="tobjOtrosEgreso"> Un objeto del tipo Otro Egreso.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblOtrosEgreso tobjOtrosEgreso)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext OtrosEgreso = new dbExequial2010DataContext())
                {
                    tblOtrosEgreso oin_old = OtrosEgreso.tblOtrosEgresos.SingleOrDefault(p => p.strCodOtrosEgresos == tobjOtrosEgreso.strCodOtrosEgresos);
                    oin_old.strNomOtrosEgresos = tobjOtrosEgreso.strNomOtrosEgresos;
                    OtrosEgreso.tblLogdeActividades.InsertOnSubmit(tobjOtrosEgreso.log);
                    OtrosEgreso.SubmitChanges();
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

        /// <summary> Consulta todos los otros egresos registrados. </summary>
        /// <param name="tAplicacion"> Un objeto del tipo otros egresos. </param>
        /// <returns> Un lista con todos los otros egresos seleccionados. </returns>
        public IList<otroEgreso> gmtdConsultarTodos()
        {
            using (dbExequial2010DataContext otroEgreso = new dbExequial2010DataContext())
            {
                var query = from oin in otroEgreso.tblOtrosEgresos
                            select oin;
                List<otroEgreso> lstotroIngreso = new List<otroEgreso>();

                foreach (var dato in query.ToList())
                {
                    otroEgreso oin = new otroEgreso();
                    oin.strCodigoPar = dato.strCodigoPar;
                    oin.strNomOtrosEgresos = dato.strNomOtrosEgresos;
                    oin.strCodOtrosEgresos = dato.strCodOtrosEgresos;
                    lstotroIngreso.Add(oin);
                }
                return lstotroIngreso;
            }
        }

        /// <summary> Consulta un determinado otro Egreso. </summary>
        /// <param name="tstrCodotro">el código del otro Egreso a consultar.</param>
        /// <returns> un objeto del tipo otro Egreso. </returns>
        public tblOtrosEgreso gmtdConsultar(string tstrCodotro)
        {
            using (dbExequial2010DataContext oin = new dbExequial2010DataContext())
            {
                var query = from otro in oin.tblOtrosEgresos
                            where otro.strCodOtrosEgresos == tstrCodotro
                            select otro;

                if (query.ToList().Count > 0)
                    return query.ToList()[0];
                else
                    return new tblOtrosEgreso();
            }
        }

        /// <summary> Elimina un otro Egreso de la base de datos. </summary>
        /// <param name="tobjOtrosIngreso"> Un objeto del tipo tblOtrosEgreso. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblOtrosEgreso tobjOtrosEgreso)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext oin = new dbExequial2010DataContext())
                {
                    var query = from otro in oin.tblOtrosEgresos
                                where otro.strCodOtrosEgresos == tobjOtrosEgreso.strCodOtrosEgresos
                                select otro;

                    foreach (var detail in query)
                    {
                        oin.tblOtrosEgresos.DeleteOnSubmit(detail);
                    }

                    oin.tblLogdeActividades.InsertOnSubmit(tobjOtrosEgreso.log);
                    oin.SubmitChanges();
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
