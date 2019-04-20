using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libMutuales2020.dominio;
using System.Transactions;

namespace libMutuales2020.dao
{
    class daoPar
    {
        /// <summary> Inserta un Par. </summary>
        /// <param name="tobjCuentaPar"> Un objeto del tipo par.  </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblCuentasPare tobjCuentaPar)
        {
            String strRetornar;
            try
            {
                using (dbExequial2010DataContext cuentaPar = new dbExequial2010DataContext())
                {
                    using (TransactionScope ts = new TransactionScope())
                    {
                        cuentaPar.tblCuentasPares.InsertOnSubmit(tobjCuentaPar);

                        foreach (tblCuentasCreditoParesDetalle dato in tobjCuentaPar.lstCredito)
                            cuentaPar.tblCuentasCreditoParesDetalles.InsertOnSubmit(dato);

                        foreach (tblCuentasDebitoParesDetalle dato in tobjCuentaPar.lstDebito)
                            cuentaPar.tblCuentasDebitoParesDetalles.InsertOnSubmit(dato);

                        cuentaPar.tblLogdeActividades.InsertOnSubmit(tobjCuentaPar.log);

                        cuentaPar.SubmitChanges();

                        strRetornar = "Registro Insertado";

                        ts.Complete();
                    }
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                strRetornar = "- Ocurrió un error al insertar el registro.";
            }
            return strRetornar;
        }

        /// <summary> Modifica un par. </summary>
        /// <param name="tobjCuentaPar"> Un objeto del tipo par.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblCuentasPare tobjCuentaPar)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
                {
                    tblCuentasPare cue_old = cuenta.tblCuentasPares.SingleOrDefault(p => p.strCodigoPar == tobjCuentaPar.strCodigoPar);
                    cue_old.bitRetencion = tobjCuentaPar.bitRetencion;
                    cue_old.fltPorcentaje = tobjCuentaPar.fltPorcentaje;
                    cue_old.intTope = tobjCuentaPar.intTope;
                    cuenta.tblLogdeActividades.InsertOnSubmit(tobjCuentaPar.log);
                    cuenta.SubmitChanges();
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

        /// <summary> Consulta un determinado par </summary>
        /// <param name="tstrPar"> El código del par a consultar. </param>
        /// <returns> Un lista con todos los pares seleccionados. </returns>
        public List<cuentaPar> gmtdConsultar(string tstrPar)
        {
            using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
            {
                var query = from cue in cuenta.tblCuentasPares
                            where cue.strCodigoPar == tstrPar
                            select cue;

                List<cuentaPar> lstPar = new List<cuentaPar>();

                foreach (var dato in query.ToList())
                {
                    cuentaPar cue = new cuentaPar();
                    cue.strCodigoPar = dato.strCodigoPar;
                    cue.bitRetencion = Convert.ToBoolean(dato.bitRetencion);
                    cue.fltPorcentaje = Convert.ToDouble(dato.fltPorcentaje);
                    cue.intTope = Convert.ToInt32(dato.intTope);
                    cue.bitEliminar = Convert.ToBoolean(dato.bitPermitirEliminar);
                    lstPar.Add(cue);
                }
                return lstPar;
            }
        }

        /// <summary> Consulta los pares registrados. </summary>
        /// <param name="tstrPar"> El código del par a consultar. </param>
        /// <returns> Un lista con todas los pares seleccionados. </returns>
        public List<cuentaPar> gmtdConsultarTodos()
        {
            using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
            {
                var query = from cue in cuenta.tblCuentasPares
                            select cue;

                List<cuentaPar> lstPar = new List<cuentaPar>();

                foreach (var dato in query.ToList())
                {
                    cuentaPar cue = new cuentaPar();
                    cue.strCodigoPar = dato.strCodigoPar;
                    cue.bitRetencion = Convert.ToBoolean(dato.bitRetencion);
                    cue.fltPorcentaje = Convert.ToDouble(dato.fltPorcentaje);
                    cue.intTope = Convert.ToInt32(dato.intTope);
                    cue.strDescripcion = dato.strDescripcion;
                    lstPar.Add(cue);
                }
                return lstPar;
            }
        }

        ///// <summary> Consulta un determinado par. </summary>
        ///// <param name="tstrCodigoPar"> Código del par. </param>
        ///// <returns> un objeto del tipo par </returns>
        //public tblCuentasPare gmtdConsultar(string tstrCodigoPar)
        //{
        //    using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
        //    {
        //        var query = from cue in cuenta.tblCuentasPares
        //                    where cue.strCodigoPar == tstrCodigoPar
        //                    select cue;

        //        if (query.ToList().Count > 0)
        //            return query.ToList()[0];
        //        else
        //            return new tblCuentasPare();

        //    }
        //}

        /// <summary> Consulta los cuentas credito registradas a un determinado par. </summary>
        /// <param name="tstrPar"> El código del par a consultar. </param>
        /// <returns> Un lista con todas las cuentas seleccionadas. </returns>
        public List<cuentaCredito> gmtdConsultarCreditos(string tstrCodigoPar)
        {
            using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
            {
                var query = from cue in cuenta.tblCuentasCreditoParesDetalles
                            where cue.strCodigoPar == tstrCodigoPar 
                            select cue;

                List<cuentaCredito> lstCcr = new List<cuentaCredito>();

                foreach (var dato in query.ToList())
                {
                    cuentaCredito cue = new cuentaCredito();
                    cue.strCuenta = dato.strCuenta;
                    cue.decPorcentaje = Convert.ToDecimal(dato.fltPorcentaje.ToString());
                    lstCcr.Add(cue);
                }

                return lstCcr;
            }
        }

        /// <summary> Consulta los cuentas debito registradas a un determinado par. </summary>
        /// <param name="tstrPar"> El código del par a consultar. </param>
        /// <returns> Un lista con todas las cuentas seleccionadas. </returns>
        public List<cuentaDebito> gmtdConsultarDebitos(string tstrCodigoPar)
        {
            using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
            {
                var query = from cue in cuenta.tblCuentasDebitoParesDetalles
                            where cue.strCodigoPar == tstrCodigoPar
                            select cue;

                List<cuentaDebito> lstCcr = new List<cuentaDebito>();

                foreach (var dato in query.ToList())
                {
                    cuentaDebito cue = new cuentaDebito();
                    cue.strCuenta = dato.strCuenta;
                    cue.decPorcentaje = Convert.ToDecimal(dato.fltPorcentaje.ToString()); ;
                    lstCcr.Add(cue);
                }

                return lstCcr;
            }
        }

        /// <summary> Elimina un par de la base de datos. </summary>
        /// <param name="tobjCuentaPar"> Un objeto del tipo par que se va a eliminar. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public string gmtdEliminar(tblCuentasPare tobjCuentaPar)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
                {

                    var query = from cue in cuenta.tblCuentasCreditoParesDetalles
                                where cue.strCodigoPar == tobjCuentaPar.strCodigoPar
                                select cue;

                    foreach (var detail in query)
                    {
                        cuenta.tblCuentasCreditoParesDetalles.DeleteOnSubmit(detail);
                    }

                    var query1 = from cue in cuenta.tblCuentasDebitoParesDetalles
                                where cue.strCodigoPar == tobjCuentaPar.strCodigoPar
                                select cue;

                    foreach (var detail in query1)
                    {
                        cuenta.tblCuentasDebitoParesDetalles.DeleteOnSubmit(detail);
                    }

                    var query2 = from cue in cuenta.tblCuentasPares
                                where cue.strCodigoPar == tobjCuentaPar.strCodigoPar
                                select cue;

                    foreach (var detail in query2)
                    {
                        cuenta.tblCuentasPares.DeleteOnSubmit(detail);
                    }

                    cuenta.tblLogdeActividades.InsertOnSubmit(tobjCuentaPar.log);
                    cuenta.SubmitChanges();
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
