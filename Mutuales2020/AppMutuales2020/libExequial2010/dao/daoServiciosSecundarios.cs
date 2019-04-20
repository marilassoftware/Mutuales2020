using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libMutuales2020.dominio;

namespace libMutuales2020.dao
{
    class daoSecundarios
    {
        /// <summary> Inserta un servicio secundario. </summary>
        /// <param name="tobjServicio"> Un objeto del tipo tblServiciosSecundario. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblServiciosSecundario tobjServicio)
        {
            String strRetornar;
            try
            {
                using (dbExequial2010DataContext servicio = new dbExequial2010DataContext())
                {
                    servicio.tblServiciosSecundarios.InsertOnSubmit(tobjServicio);
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

        /// <summary> Modifica un servicio secundario. </summary>
        /// <param name="tobjServicio"> Un objeto del tipo tblServiciosSecundario.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblServiciosSecundario tobjServicio)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext servicio = new dbExequial2010DataContext())
                {
                    tblServiciosSecundario ser_old = servicio.tblServiciosSecundarios.SingleOrDefault(p => p.strCodSse == tobjServicio.strCodSse);
                    ser_old.intValorSse = tobjServicio.intValorSse;
                    ser_old.strCodigoPar = tobjServicio.strCodigoPar;
                    ser_old.strNombreSse = tobjServicio.strNombreSse;
                    servicio.tblLogdeActividades.InsertOnSubmit(tobjServicio.log);
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

        /// <summary> Consulta todos los servicios secundarios. </summary>
        /// <returns> Un lista con todos los servicios secundarios seleccionados. </returns>
        public IList<Secundarios> gmtdConsultarTodos()
        {
            using (dbExequial2010DataContext servicios = new dbExequial2010DataContext())
            {
                var query = from ser in servicios.tblServiciosSecundarios
                            select ser;

                List<Secundarios> lstSecundatios = new List<Secundarios>();

                foreach (var dato in query.ToList())
                {
                    Secundarios sec = new Secundarios();
                    sec.intValorSse = dato.intValorSse;
                    sec.strCodigoPar = dato.strCodigoPar;
                    sec.strCodSse = dato.strCodSse;
                    sec.strNombreSse = dato.strNombreSse;
                    lstSecundatios.Add(sec);
                }
                return lstSecundatios;
            }
        }

        /// <summary> Consulta un determinado servicio secundario. </summary>
        /// <param name="tstrCodigo"> El código de servicio secundario a consultar. </param>
        /// <returns> Un servicio secundario consultado. </returns>
        public tblServiciosSecundario gmtdConsultar(string tstrCodigo)
        {
            using (dbExequial2010DataContext servicios = new dbExequial2010DataContext())
            {
                var query = from ser in servicios.tblServiciosSecundarios
                            where ser.strCodSse == tstrCodigo
                            select ser;

                if (query.ToList().Count > 0)
                    return query.ToList()[0];
                else
                    return new tblServiciosSecundario();

            }
        }

        /// <summary> Elimina un servicio secundario de la base de datos. </summary>
        /// <param name="tobjServicio"> Un objeto del tipo tblServiciosSecundario. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblServiciosSecundario tobjServicio)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext servicios = new dbExequial2010DataContext())
                {
                    var query = from ser in servicios.tblServiciosSecundarios
                                where ser.strCodSse == tobjServicio.strCodSse
                                select ser;

                    foreach (var detail in query)
                    {
                        servicios.tblServiciosSecundarios.DeleteOnSubmit(detail);
                    }

                    servicios.tblLogdeActividades.InsertOnSubmit(tobjServicio.log);
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
