using System;
using System.Collections.Generic;
using System.Linq;
using libMutuales2020.dominio;

namespace libMutuales2020.dao
{
    class daoOtroIngreso
    {
        /// <summary> Inserta un Otro Ingreso. </summary>
        /// <param name="tobjOtrosIngreso"> Un objeto del tipo otroIngreso. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblOtrosIngreso tobjOtrosIngreso)
        {
            String strRetornar;
            try
            {
                using (dbExequial2010DataContext otroIngreso = new dbExequial2010DataContext())
                {
                    otroIngreso.tblOtrosIngresos.InsertOnSubmit(tobjOtrosIngreso);
                    otroIngreso.tblLogdeActividades.InsertOnSubmit(tobjOtrosIngreso.log);
                    otroIngreso.SubmitChanges();
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

        /// <summary> Modifica un Otro Ingreso. </summary>
        /// <param name="tobjOtrosIngreso"> Un objeto del tipo Otro Ingreso.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblOtrosIngreso tobjOtrosIngreso)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext OtrosIngreso = new dbExequial2010DataContext())
                {
                    tblOtrosIngreso oin_old = OtrosIngreso.tblOtrosIngresos.SingleOrDefault(p => p.strCodOtrosIngresos == tobjOtrosIngreso.strCodOtrosIngresos);
                    oin_old.strNomOtrosIngresos = tobjOtrosIngreso.strNomOtrosIngresos;
                    OtrosIngreso.tblLogdeActividades.InsertOnSubmit(tobjOtrosIngreso.log);
                    OtrosIngreso.SubmitChanges();
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

        /// <summary> Consulta todos los otros ingresos registrados. </summary>
        /// <param name="tAplicacion"> Un objeto del tipo otros ingresos. </param>
        /// <returns> Un lista con todos los otros ingresos seleccionados. </returns>
        public IList<otroIngreso> gmtdConsultarTodos()
        {
            using (dbExequial2010DataContext otroIngreso = new dbExequial2010DataContext())
            {
                var query = from oin in otroIngreso.tblOtrosIngresos
                            select oin;
                List<otroIngreso> lstotroIngreso = new List<otroIngreso>();

                foreach (var dato in query.ToList())
                {
                    otroIngreso oin = new otroIngreso();
                    oin.strCodigoPar = dato.strCodigoPar;
                    oin.strNomOtrosIngresos = dato.strNomOtrosIngresos;
                    oin.strCodOtrosIngresos = dato.strCodOtrosIngresos;
                    lstotroIngreso.Add(oin);
                }
                return lstotroIngreso;
            }
        }

        /// <summary> Consulta un determinado otro ingreso. </summary>
        /// <param name="tstrCodotro">el código del otro ingreso a consultar.</param>
        /// <returns> un objeto del tipo otro ingreso. </returns>
        public tblOtrosIngreso gmtdConsultar(string tstrCodotro)
        {
            using (dbExequial2010DataContext oin = new dbExequial2010DataContext())
            {
                var query = from otro in oin.tblOtrosIngresos
                            where otro.strCodOtrosIngresos == tstrCodotro
                            select otro;

                if (query.ToList().Count > 0)
                    return query.ToList()[0];
                else
                    return new tblOtrosIngreso();
            }
        }

        /// <summary> Elimina un otro ingreso de la base de datos. </summary>
        /// <param name="tobjOtrosIngreso"> Un objeto del tipo tblOtrosIngreso. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblOtrosIngreso tobjOtrosIngreso)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext oin = new dbExequial2010DataContext())
                {
                    var query = from otro in oin.tblOtrosIngresos
                                where otro.strCodOtrosIngresos == tobjOtrosIngreso.strCodOtrosIngresos
                                select otro;

                    foreach (var detail in query)
                    {
                        oin.tblOtrosIngresos.DeleteOnSubmit(detail);
                    }

                    oin.tblLogdeActividades.InsertOnSubmit(tobjOtrosIngreso.log);
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
