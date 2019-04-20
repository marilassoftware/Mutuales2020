using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libMutuales2020.dominio;

namespace libMutuales2020.dao
{
    public class daoCuenta
    {
        /// <summary> Inserta una Cuenta. </summary>
        /// <param name="tobjCuenta"> Un objeto del tipo cuenta. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblCuenta tobjCuenta)
        {
            String strRetornar;
            try
            {
                using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
                {
                    cuenta.tblCuentas.InsertOnSubmit(tobjCuenta);
                    cuenta.tblLogdeActividades.InsertOnSubmit(tobjCuenta.log);
                    cuenta.SubmitChanges();
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

        /// <summary> Modifica una cuenta. </summary>
        /// <param name="tobjCuenta"> Un objeto del tipo cuenta.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblCuenta tobjCuenta)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
                {
                    tblCuenta cue_old = cuenta.tblCuentas.SingleOrDefault(p => p.strCuenta == tobjCuenta.strCuenta);
                    cue_old.strDescripcion = tobjCuenta.strDescripcion;
                    cue_old.bitDebito = tobjCuenta.bitDebito;
                    cuenta.tblLogdeActividades.InsertOnSubmit(tobjCuenta.log);
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

        /// <summary> Consulta todas las cuentas registradas de acuerdo al parametro.  si es true todas las cuentas debito o si es false todas las cuentas credito </summary>
        /// <param name="tbitDebito"> Un valor true o false. </param>
        /// <returns> Un lista con todas las cuentas seleccionadas. </returns>
        public IList<cuenta> gmtdConsultarTodos(Boolean tbitDebito)
        {
            using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
            {
                var query = from cue in cuenta.tblCuentas
                            where cue.bitDebito == tbitDebito
                            select cue;

                List<cuenta> lstCuenta = new List<cuenta>();

                foreach (var dato in query.ToList())
                {
                    cuenta cue = new cuenta();
                    cue.strCuenta = dato.strCuenta;
                    cue.strDescripcion = dato.strDescripcion;
                    cue.strCedula = dato.strCedula;
                    cue.strNombre = dato.strNombre;
                    lstCuenta.Add(cue);
                }

                return lstCuenta;
            }
        }

        /// <summary> Consulta todas las cuentas registradas. </summary>
        /// <returns> Un lista con todas las cuentas seleccionadas. </returns>
        public IList<cuenta> gmtdConsultarTodos()
        {
            using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
            {
                var query = from cue in cuenta.tblCuentas
                            orderby cue.strCuenta ascending
                            select new { cue.strCuenta, cue.strDescripcion, cue.bitDebito, cue.strCedula, cue.strNombre };

                List<cuenta> lstCuenta = new List<cuenta>();

                foreach (var dato in query.ToList())
                {
                    cuenta cue = new cuenta();
                    cue.strCuenta = dato.strCuenta;
                    cue.strDescripcion = dato.strDescripcion;
                    cue.strCedula = dato.strCedula;
                    cue.strNombre = dato.strNombre;
                    lstCuenta.Add(cue);
                }

                return lstCuenta;
            }
        }

        /// <summary> Consulta una determinada cuentastradas de acuerdo al parametro. </summary>
        /// <param name="tbitDebito"> Un valor true o false. </param>
        /// <returns> Un lista con todas las cuentas seleccionadas. </returns>
        public tblCuenta gmtdConsultar(string tstrCuenta)
        {
            using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
            {
                var query = from cue in cuenta.tblCuentas
                            where cue.strCuenta == tstrCuenta
                            select cue;
                if (query.ToList().Count > 0)
                    return query.ToList()[0];
                else
                    return new tblCuenta();
            }
        }

        /// <summary> Elimina una cuenta de la base de datos. </summary>
        /// <param name="tobjCuenta"> Un objeto del tipo cuenta, con la cuenta que se quiere eliminar. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public string gmtdEliminar(tblCuenta tobjCuenta)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
                {
                    var query = from cue in cuenta.tblCuentas 
                                where cue.strCuenta == tobjCuenta.strCuenta 
                                select cue;

                    foreach (var detail in query)
                    {
                        cuenta.tblCuentas.DeleteOnSubmit(detail);
                    }

                    cuenta.tblLogdeActividades.InsertOnSubmit(tobjCuenta.log);
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
