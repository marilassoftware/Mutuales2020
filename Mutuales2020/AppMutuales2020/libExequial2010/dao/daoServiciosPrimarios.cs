using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libMutuales2020.dominio;

namespace libMutuales2020.dao
{
    class daoPrimarios
    {
        /// <summary> Inserta un servicio primario. </summary>
        /// <param name="tobjServicio"> Un objeto del tipo tblServiciosPrimario. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblServiciosPrimario tobjServicio)
        {
            String strRetornar;
            try
            {
                using (dbExequial2010DataContext servicio = new dbExequial2010DataContext())
                {
                    servicio.tblServiciosPrimarios.InsertOnSubmit(tobjServicio);
                    servicio.tblLogdeActividades.InsertOnSubmit(tobjServicio.log);
                    servicio.SubmitChanges();
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

        /// <summary> Modifica un servicio primario. </summary>
        /// <param name="tobjServicioPrimario"> Un objeto del tipo tblServiciosPrimario.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblServiciosPrimario tobjServicioPrimario)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext servicio = new dbExequial2010DataContext())
                {
                    tblServiciosPrimario ser_old = servicio.tblServiciosPrimarios.SingleOrDefault(p => p.strCodSpr == tobjServicioPrimario.strCodSpr);
                    ser_old.bitUnicoSpr = tobjServicioPrimario.bitUnicoSpr;
                    ser_old.intAñoSpr = tobjServicioPrimario.intAñoSpr;
                    ser_old.intValorCuotaSpr = tobjServicioPrimario.intValorCuotaSpr;
                    ser_old.intAñoSpr = tobjServicioPrimario.intAñoSpr;
                    ser_old.intValorSpr = tobjServicioPrimario.intValorSpr;
                    ser_old.strNombreSpr = tobjServicioPrimario.strNombreSpr;
                    servicio.tblLogdeActividades.InsertOnSubmit(tobjServicioPrimario.log);
                    servicio.SubmitChanges();
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

        /// <summary> Consulta todos los servicios primarios. </summary>
        /// <returns> Un lista con todos los servicios primarios seleccionados. </returns>
        public IList<Primarios> gmtdConsultarTodos()
        {
            using (dbExequial2010DataContext servicios = new dbExequial2010DataContext())
            {
                var query = from ser in servicios.tblServiciosPrimarios
                            select ser ;

                List<Primarios> lstPrimarios = new List<Primarios>();

                foreach (var dato in query.ToList())
                {
                    Primarios pri = new Primarios();
                    pri.bitUnicoSpr = (bool)dato.bitUnicoSpr;
                    pri.intAñoSpr = (int)dato.intAñoSpr;
                    pri.intValorCuotaSpr = (int)dato.intValorCuotaSpr;
                    pri.intValorSpr = (int)dato.intValorSpr;
                    pri.strCodigoPar = dato.strCodigoPar;
                    pri.strNombreSpr = dato.strNombreSpr;
                    pri.strCodSpr = dato.strCodSpr;
                    lstPrimarios.Add(pri);
                }
                return lstPrimarios;
            }
        }

        /// <summary> Consulta un determinado servicio primario. </summary>
        /// <param name="tstrCodigo"> El código de servicio primario a consultar. </param>
        /// <returns> Un servicio primario consultado. </returns>
        public tblServiciosPrimario gmtdConsultar(string tstrCodigo)
        {
            using (dbExequial2010DataContext servicios = new dbExequial2010DataContext())
            {
                var query = from ser in servicios.tblServiciosPrimarios
                            where ser.strCodSpr == tstrCodigo 
                            select ser;

                if (query.ToList().Count > 0)
                    return query.ToList()[0];
                else
                    return new tblServiciosPrimario();

            }
        }

        /// <summary> Elimina un servicio primario de la base de datos. </summary>
        /// <param name="tobjPrimarios"> Un objeto del tipo tblServiciosPrimarios. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblServiciosPrimario tobjPrimarios)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext servicios = new dbExequial2010DataContext())
                {
                    var query = from ser in servicios.tblServiciosPrimarios
                                where ser.strCodSpr == tobjPrimarios.strCodSpr
                                select ser;

                    foreach (var detail in query)
                    {
                        servicios.tblServiciosPrimarios.DeleteOnSubmit(detail);
                    }

                    servicios.tblLogdeActividades.InsertOnSubmit(tobjPrimarios.log);
                    servicios.SubmitChanges();
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
