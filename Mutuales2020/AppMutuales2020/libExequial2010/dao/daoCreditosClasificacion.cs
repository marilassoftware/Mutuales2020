using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libMutuales2020.dominio;

namespace libMutuales2020.dao
{
    class daoCreditosClasificacion
    {
        /// <summary> Inserta un tipo de clasificacion. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo clasificación. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblCreditosClasificacion tobjClasificaciondeCredito)
        {
            String strRetornar;
            try
            {
                using (dbExequial2010DataContext tipo = new dbExequial2010DataContext())
                {
                    tipo.tblCreditosClasificacions.InsertOnSubmit(tobjClasificaciondeCredito);
                    tipo.tblLogdeActividades.InsertOnSubmit(tobjClasificaciondeCredito.log);
                    tipo.SubmitChanges();
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

        /// <summary> Modifica una clasificación de credito. </summary>
        /// <param name="tobjTiposdeCredito"> Un objeto del tipo tblCreditosClasificacion.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblCreditosClasificacion tobjClasificaciondeCredito)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext tipo = new dbExequial2010DataContext())
                {
                    tblCreditosClasificacion cla_old = tipo.tblCreditosClasificacions.SingleOrDefault(p => p.strCodigoCla == tobjClasificaciondeCredito.strCodigoCla);
                    cla_old.bitCausarInteresesCla = tobjClasificaciondeCredito.bitCausarInteresesCla;
                    cla_old.bitInteresporDiasCla = tobjClasificaciondeCredito.bitInteresporDiasCla;
                    cla_old.bitSumarICM = tobjClasificaciondeCredito.bitSumarICM;
                    cla_old.decValorProvisionCla = tobjClasificaciondeCredito.decValorProvisionCla;
                    cla_old.intDesdeCla = tobjClasificaciondeCredito.intDesdeCla;
                    cla_old.intHastaCla = tobjClasificaciondeCredito.intHastaCla;
                    cla_old.strCodigoTcr = tobjClasificaciondeCredito.strCodigoTcr;
                    cla_old.strNombreCla = tobjClasificaciondeCredito.strNombreCla;
                    tipo.tblLogdeActividades.InsertOnSubmit(tobjClasificaciondeCredito.log);
                    tipo.SubmitChanges();
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

        /// <summary> Consulta todas las clasificaciones de creditos. </summary>
        /// <returns> Un lista con todas las clasificaciones de crédito. </returns>
        public IList<creditosClasificacion> gmtdConsultarTodos()
        {
            using (dbExequial2010DataContext tipos = new dbExequial2010DataContext())
            {
                var query = from tip in tipos.tblCreditosClasificacions
                            select tip;
                List<creditosClasificacion> lstClasificaciondeCredito = new List<creditosClasificacion>();

                foreach (var dato in query.ToList())
                {
                    creditosClasificacion cla = new creditosClasificacion();
                    cla.bitCausarInteresesCla = dato.bitCausarInteresesCla;
                    cla.bitInteresporDiasCla = dato.bitInteresporDiasCla;
                    cla.bitSumarICM = dato.bitSumarICM;
                    cla.decValorProvisionCla = dato.decValorProvisionCla;
                    cla.intDesdeCla = dato.intDesdeCla;
                    cla.intHastaCla = dato.intHastaCla;
                    cla.strCodigoCla = dato.strCodigoCla;
                    cla.strCodigoTcr = dato.strCodigoTcr;
                    cla.strNombreCla = dato.strNombreCla;
                    lstClasificaciondeCredito.Add(cla);
                }
                return lstClasificaciondeCredito;
            }
        }

        /// <summary> Consulta una determinada clasificacion de credito. </summary>
        /// <param name="tobjClasificaciondeCredito">el código de la clasificación de crédito.</param>
        /// <returns> un objeto del tipo tblCreditosClasificacion. </returns>
        public tblCreditosClasificacion gmtdConsultar(string tobjClasificaciondeCredito)
        {
            using (dbExequial2010DataContext tipos = new dbExequial2010DataContext())
            {
                var query = from tip in tipos.tblCreditosClasificacions
                            where tip.strCodigoCla == tobjClasificaciondeCredito
                            select tip;
                
                if (query.ToList().Count > 0)
                    return query.ToList()[0];
                else
                    return new tblCreditosClasificacion();
            }
        }

        /// <summary> Elimina una clasificación de credito. </summary>
        /// <param name="tobjClasificaciondeCredito"> Un objeto del tipo tblCreditosClasificacion. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblCreditosClasificacion tobjClasificaciondeCredito)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext tipo = new dbExequial2010DataContext())
                {
                    var query = from tip in tipo.tblCreditosClasificacions
                                where tip.strCodigoCla == tobjClasificaciondeCredito.strCodigoCla
                                select tip;

                    foreach (var detail in query)
                    {
                        tipo.tblCreditosClasificacions.DeleteOnSubmit(detail);
                    }

                    tipo.tblLogdeActividades.InsertOnSubmit(tobjClasificaciondeCredito.log);
                    tipo.SubmitChanges();
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
