using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libMutuales2020.dominio;

namespace libMutuales2020.dao
{
    public class daoAhorrosaFuturoBonificacion
    {
        /// <summary> Inserta una bonificación de ahorro a futuro. </summary>
        /// <param name="tobjAhorroaFuturoBonificacion"> Un objeto del tipo tblAhorrosaFuturoBonificacion. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblAhorrosaFuturoBonificacion tobjAhorroaFuturoBonificacion)
        {
            String strRetornar;
            try
            {
                using (dbExequial2010DataContext ahorros = new dbExequial2010DataContext())
                {
                    ahorros.tblAhorrosaFuturoBonificacions.InsertOnSubmit(tobjAhorroaFuturoBonificacion);
                    ahorros.tblLogdeActividades.InsertOnSubmit(tobjAhorroaFuturoBonificacion.log);
                    tblAhorrosaFuturo int_old = ahorros.tblAhorrosaFuturos.SingleOrDefault(p => p.strCuenta == tobjAhorroaFuturoBonificacion.strCuenta);
                    if (tobjAhorroaFuturoBonificacion.bitIntereses == true)
                        int_old.fltIntereses += tobjAhorroaFuturoBonificacion.fltValor;
                    else
                        int_old.fltPremios += tobjAhorroaFuturoBonificacion.fltValor;
                    ahorros.SubmitChanges();
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

        /// <summary> Consulta todos las bonificaciones registradas. </summary>
        /// <returns> Un lista con todos las bonificaciones seleccionadas. </returns>
        public IList<tblAhorrosaFuturoBonificacion> gmtdConsultarTodos()
        {
            using (dbExequial2010DataContext ahorros = new dbExequial2010DataContext())
            {
                var query = from aho in ahorros.tblAhorrosaFuturoBonificacions
                            where aho.bitAnulado == false
                            select aho;

                return query.ToList();
            }
        }

        /// <summary> Consulta una determinada bonificación. </summary>
        /// <param name="tstrCuenta">el código de la bonificación a consultar.</param>
        /// <returns> un objeto del tipo tblAhorrosaFuturo. </returns>
        public tblAhorrosaFuturoBonificacion gmtdConsultar(int tintBonificacion)
        {
            using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
            {
                var query = from cue in cuenta.tblAhorrosaFuturoBonificacions
                            where cue.intCodigoBonificacion == tintBonificacion && cue.bitAnulado == false
                            select cue;

                if (query.ToList().Count > 0)
                    return query.ToList()[0];
                else
                    return new tblAhorrosaFuturoBonificacion();
            }
        }

        /// <summary> Consulta las bonificaciones premio de una determinada cuenta. </summary>
        /// <param name="tstrCuenta">el código de la cuenta a la que se le van a consultar las bonificaciones. </param>
        /// <returns> un objeto del tipo tblAhorrosaFuturo. </returns>
        public IList<tblAhorrosaFuturoBonificacion> gmtdConsultarBonificacionesPremioxCuenta(string tstrCuenta)
        {
            using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
            {
                var query = from cue in cuenta.tblAhorrosaFuturoBonificacions
                            where cue.strCuenta == tstrCuenta && cue.bitPremios == true && cue.bitAnulado == false
                            select cue;

                return query.ToList();
            }
        }

        /// <summary> Consulta las bonificaciones de intereses de una determinada cuenta. </summary>
        /// <param name="tstrCuenta">el código de la cuenta a la que se le van a consultar las bonificaciones. </param>
        /// <returns> un objeto del tipo tblAhorrosaFuturo. </returns>
        public IList<tblAhorrosaFuturoBonificacion> gmtdConsultarBonificacionesInteresesxCuenta(string tstrCuenta)
        {
            using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
            {
                var query = from cue in cuenta.tblAhorrosaFuturoBonificacions
                            where cue.strCuenta == tstrCuenta && cue.bitIntereses == true && cue.bitAnulado == false
                            select cue;

                return query.ToList();
            }
        }

        /// <summary> Elimina una bonificación de premios de una cuenta. </summary>
        /// <param name="tobjAhorrosaFuturoBonificacion"> Un objeto del tipo tblAhorrosaFuturo. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminarBonificacionPremio(tblAhorrosaFuturoBonificacion tobjAhorrosaFuturoBonificacion)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
                {
                    tblAhorrosaFuturoBonificacion bon_old = cuenta.tblAhorrosaFuturoBonificacions.SingleOrDefault(p => p.intCodigoBonificacion == tobjAhorrosaFuturoBonificacion.intCodigoBonificacion);
                    bon_old.bitAnulado = true;
                    bon_old.dtmFechaAnulado = DateTime.Now;
                    cuenta.tblLogdeActividades.InsertOnSubmit(tobjAhorrosaFuturoBonificacion.log);

                    tblAhorrosaFuturo cue_old = cuenta.tblAhorrosaFuturos.SingleOrDefault(p => p.strCuenta == tobjAhorrosaFuturoBonificacion.strCuenta);
                    cue_old.fltPremios -= tobjAhorrosaFuturoBonificacion.fltValor;

                    cuenta.SubmitChanges();
                    strResultado = "Registro Eliminado";
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                strResultado = "- Ocurrió un error al Eliminar el registro.";
            }
            return strResultado;
        }

        /// <summary> Elimina una bonificación de intereses de una cuenta. </summary>
        /// <param name="tobjAhorrosaFuturoBonificacion"> Un objeto del tipo tblAhorrosaFuturo. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminarBonificacionInteres(tblAhorrosaFuturoBonificacion tobjAhorrosaFuturoBonificacion)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
                {
                    tblAhorrosaFuturoBonificacion bon_old = cuenta.tblAhorrosaFuturoBonificacions.SingleOrDefault(p => p.intCodigoBonificacion == tobjAhorrosaFuturoBonificacion.intCodigoBonificacion);
                    bon_old.bitAnulado = true;
                    bon_old.dtmFechaAnulado = DateTime.Now;
                    cuenta.tblLogdeActividades.InsertOnSubmit(tobjAhorrosaFuturoBonificacion.log);

                    tblAhorrosaFuturo cue_old = cuenta.tblAhorrosaFuturos.SingleOrDefault(p => p.strCuenta == tobjAhorrosaFuturoBonificacion.strCuenta);
                    cue_old.fltIntereses -= tobjAhorrosaFuturoBonificacion.fltValor;

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
