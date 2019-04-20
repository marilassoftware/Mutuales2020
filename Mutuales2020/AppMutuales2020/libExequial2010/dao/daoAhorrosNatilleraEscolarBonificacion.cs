using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libMutuales2020.dominio;

namespace libMutuales2020.dao
{
    public class daoAhorrosNatilleraEscolarBonificacion
    {
        /// <summary> Inserta una bonificación de ahorro navideño. </summary>
        /// <param name="tobjAhorroaFuturoBonificacion"> Un objeto del tipo tblAhorrosNavidenoBonificacion. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblAhorrosNatilleraEscolarBonificacion tobjAhorroNatilleraEscolarBonificacion)
        {
            String strRetornar;
            try
            {
                using (dbExequial2010DataContext ahorros = new dbExequial2010DataContext())
                {
                    ahorros.tblAhorrosNatilleraEscolarBonificacions.InsertOnSubmit(tobjAhorroNatilleraEscolarBonificacion);
                    ahorros.tblLogdeActividades.InsertOnSubmit(tobjAhorroNatilleraEscolarBonificacion.log);
                    tblAhorrosNatilleraEscolar int_old = ahorros.tblAhorrosNatilleraEscolars.SingleOrDefault(p => p.strCuenta == tobjAhorroNatilleraEscolarBonificacion.strCuenta);
                    if (tobjAhorroNatilleraEscolarBonificacion.bitIntereses == true)
                    {
                        int_old.fltIntereses += tobjAhorroNatilleraEscolarBonificacion.fltValor;
                    }
                    else
                    {
                        int_old.fltPremios += tobjAhorroNatilleraEscolarBonificacion.fltValor;
                    }
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
        public IList<tblAhorrosNatilleraEscolarBonificacion> gmtdConsultarTodos()
        {
            using (dbExequial2010DataContext ahorros = new dbExequial2010DataContext())
            {
                var query = from aho in ahorros.tblAhorrosNatilleraEscolarBonificacions
                            where aho.bitAnulado == false
                            select aho;

                return query.ToList();
            }
        }

        /// <summary> Consulta una determinada bonificación. </summary>
        /// <param name="tstrCuenta">el código de la bonificación a consultar.</param>
        /// <returns> un objeto del tipo tblAhorrosNavidenoBonificacion. </returns>
        public tblAhorrosNatilleraEscolarBonificacion gmtdConsultar(int tintBonificacion)
        {
            using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
            {
                var query = from cue in cuenta.tblAhorrosNatilleraEscolarBonificacions
                            where cue.intCodigoBonificacion == tintBonificacion && cue.bitAnulado == false
                            select cue;

                if (query.ToList().Count > 0)
                    return query.ToList()[0];
                else
                    return new tblAhorrosNatilleraEscolarBonificacion();
            }
        }

        /// <summary> Consulta las bonificaciones premio de una determinada cuenta. </summary>
        /// <param name="tstrCuenta">el código de la cuenta a la que se le van a consultar las bonificaciones. </param>
        /// <returns> un objeto del tipo tblAhorrosaFuturo. </returns>
        public IList<tblAhorrosNatilleraEscolarBonificacion> gmtdConsultarBonificacionesPremioxCuenta(string tstrCuenta)
        {
            using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
            {
                var query = from cue in cuenta.tblAhorrosNatilleraEscolarBonificacions
                            where cue.strCuenta == tstrCuenta && cue.bitPremios == true && cue.bitAnulado == false
                            select cue;

                return query.ToList();
            }
        }

        /// <summary> Consulta las bonificaciones de intereses de una determinada cuenta. </summary>
        /// <param name="tstrCuenta">el código de la cuenta a la que se le van a consultar las bonificaciones. </param>
        /// <returns> un objeto del tipo tblAhorrosaFuturo. </returns>
        public IList<tblAhorrosNatilleraEscolarBonificacion> gmtdConsultarBonificacionesInteresesxCuenta(string tstrCuenta)
        {
            using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
            {
                var query = from cue in cuenta.tblAhorrosNatilleraEscolarBonificacions
                            where cue.strCuenta == tstrCuenta && cue.bitIntereses == true && cue.bitAnulado == false
                            select cue;

                return query.ToList();
            }
        }

        /// <summary> Elimina una bonificación de premios de una cuenta. </summary>
        /// <param name="tobjAhorrosaFuturoBonificacion"> Un objeto del tipo tblAhorrosNavidenoBonificacion. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminarBonificacionPremio(tblAhorrosNatilleraEscolarBonificacion tobjAhorrosNavidenoBonificacion)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
                {
                    tblAhorrosNatilleraEscolarBonificacion bon_old = cuenta.tblAhorrosNatilleraEscolarBonificacions.SingleOrDefault(p => p.intCodigoBonificacion == tobjAhorrosNavidenoBonificacion.intCodigoBonificacion);
                    bon_old.bitAnulado = true;
                    bon_old.dtmFechaAnulado = DateTime.Now;
                    cuenta.tblLogdeActividades.InsertOnSubmit(tobjAhorrosNavidenoBonificacion.log);

                    tblAhorrosNatilleraEscolar cue_old = cuenta.tblAhorrosNatilleraEscolars.SingleOrDefault(p => p.strCuenta == tobjAhorrosNavidenoBonificacion.strCuenta);
                    cue_old.fltPremios -= tobjAhorrosNavidenoBonificacion.fltValor;

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

        /// <summary> Elimina una bonificación de intereses de una cuenta. </summary>
        /// <param name="tobjAhorrosaFuturoBonificacion"> Un objeto del tipo tblAhorrosNavidenoBonificacion. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminarBonificacionInteres(tblAhorrosNatilleraEscolarBonificacion tobjAhorrosNatilleraEscolarBonificacion)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext cuenta = new dbExequial2010DataContext())
                {
                    tblAhorrosNatilleraEscolarBonificacion bon_old = cuenta.tblAhorrosNatilleraEscolarBonificacions.SingleOrDefault(p => p.intCodigoBonificacion == tobjAhorrosNatilleraEscolarBonificacion.intCodigoBonificacion);
                    bon_old.bitAnulado = true;
                    bon_old.dtmFechaAnulado = DateTime.Now;
                    cuenta.tblLogdeActividades.InsertOnSubmit(tobjAhorrosNatilleraEscolarBonificacion.log);

                    tblAhorrosNatilleraEscolar cue_old = cuenta.tblAhorrosNatilleraEscolars.SingleOrDefault(p => p.strCuenta == tobjAhorrosNatilleraEscolarBonificacion.strCuenta);
                    cue_old.fltIntereses -= tobjAhorrosNatilleraEscolarBonificacion.fltValor;

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
