using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libMutuales2020.dominio;

namespace libMutuales2020.dao
{
    class daoCreditosTipo
    {
        /// <summary> Inserta un tipo de credito. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo tipodecredito. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblCreditosTipo tobjTiposdeCredito)
        {
            String strRetornar;
            try
            {
                using (dbExequial2010DataContext tipo = new dbExequial2010DataContext())
                {
                    tipo.tblCreditosTipos.InsertOnSubmit(tobjTiposdeCredito);
                    tipo.tblLogdeActividades.InsertOnSubmit(tobjTiposdeCredito.log);
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

        /// <summary> Modifica un tipo de credito. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo tipodecredito.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblCreditosTipo tobjTiposdeCredito)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext tipo = new dbExequial2010DataContext())
                {
                    tblCreditosTipo tip_old = tipo.tblCreditosTipos.SingleOrDefault(p => p.strCodigoTcr == tobjTiposdeCredito.strCodigoTcr);
                    tip_old.strDescripcionTcr = tobjTiposdeCredito.strDescripcionTcr;
                    tip_old.decTasaEfectivaAnualBasicaTcr = tobjTiposdeCredito.decTasaEfectivaAnualBasicaTcr;
                    tip_old.decTasaEfectivaAnualUsuraTcr = tobjTiposdeCredito.decTasaEfectivaAnualUsuraTcr;
                    tip_old.decTasaNominalAnualBasicaDecadalTcr = tobjTiposdeCredito.decTasaNominalAnualBasicaDecadalTcr;
                    tip_old.decTasaNominalAnualBasicaMensualTcr = tobjTiposdeCredito.decTasaNominalAnualBasicaMensualTcr;
                    tip_old.decTasaNominalAnualBasicaQuincenalTcr = tobjTiposdeCredito.decTasaNominalAnualBasicaQuincenalTcr;
                    tip_old.decTasaNominalAnualBasicaSemanalTcr = tobjTiposdeCredito.decTasaNominalAnualBasicaSemanalTcr;
                    tip_old.decTasaNominalAnualBasicaTcr = tobjTiposdeCredito.decTasaNominalAnualBasicaTcr;
                    tip_old.decTasaNominalAnualUsuraDecadalTcr = tobjTiposdeCredito.decTasaNominalAnualUsuraDecadalTcr;
                    tip_old.decTasaNominalAnualUsuraMensualTcr = tobjTiposdeCredito.decTasaNominalAnualUsuraMensualTcr;
                    tip_old.decTasaNominalAnualUsuraQuincenalTcr = tobjTiposdeCredito.decTasaNominalAnualUsuraQuincenalTcr;
                    tip_old.decTasaNominalAnualUsuraSemanalTcr = tobjTiposdeCredito.decTasaNominalAnualUsuraSemanalTcr;
                    tip_old.decTasaNominalAnualUsuraTcr = tobjTiposdeCredito.decTasaNominalAnualUsuraTcr;
                    tipo.tblLogdeActividades.InsertOnSubmit(tobjTiposdeCredito.log);
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

        /// <summary>
        /// Consulta todos los tipos de credito registrados.
        /// </summary>
        /// <param name="tAplicacion"> Un objeto del tipo tipo de credito. </param>
        /// <returns> Un lista con todos los tipos de credito seleccionados. </returns>
        public IList<creditosTipo> gmtdConsultarTodos()
        {
            using (dbExequial2010DataContext tipos = new dbExequial2010DataContext())
            {
                var query = from tip in tipos.tblCreditosTipos
                            select tip;
                List<creditosTipo> lstTiposdeCredito = new List<creditosTipo>();

                foreach (var dato in query.ToList())
                {
                    creditosTipo tip = new creditosTipo();
                    tip.strCodigoTcr = dato.strCodigoTcr;
                    tip.strDescripcionTcr = dato.strDescripcionTcr;
                    tip.decTasaEfectivaAnualBasicaTcr = dato.decTasaEfectivaAnualBasicaTcr;
                    tip.decTasaEfectivaAnualUsuraTcr = Convert.ToDecimal(dato.decTasaEfectivaAnualUsuraTcr);
                    tip.decTasaNominalAnualBasicaDecadalTcr = Convert.ToDecimal(dato.decTasaNominalAnualBasicaDecadalTcr);
                    tip.decTasaNominalAnualBasicaMensualTcr = Convert.ToDecimal(dato.decTasaNominalAnualBasicaMensualTcr);
                    tip.decTasaNominalAnualBasicaQuincenalTcr = Convert.ToDecimal(dato.decTasaNominalAnualBasicaQuincenalTcr);
                    tip.decTasaNominalAnualBasicaSemanalTcr = Convert.ToDecimal(dato.decTasaNominalAnualBasicaSemanalTcr);
                    tip.decTasaNominalAnualBasicaTcr = Convert.ToDecimal(dato.decTasaNominalAnualBasicaTcr);
                    tip.decTasaNominalAnualUsuraDecadalTcr = Convert.ToDecimal(dato.decTasaNominalAnualUsuraDecadalTcr);
                    tip.decTasaNominalAnualUsuraMensualTcr = Convert.ToDecimal(dato.decTasaNominalAnualUsuraMensualTcr);
                    tip.decTasaNominalAnualUsuraQuincenalTcr = Convert.ToDecimal(dato.decTasaNominalAnualUsuraQuincenalTcr);
                    tip.decTasaNominalAnualUsuraSemanalTcr = Convert.ToDecimal(dato.decTasaNominalAnualUsuraSemanalTcr);
                    tip.decTasaNominalAnualUsuraTcr = Convert.ToDecimal(dato.decTasaNominalAnualUsuraTcr);
                    lstTiposdeCredito.Add(tip);
                }
                return lstTiposdeCredito;
            }
        }

        /// <summary>
        /// Consulta un determinado tipo de credito.
        /// </summary>
        /// <param name="tstrCodMunicipio">el código del tipo de credito a consultar.</param>
        /// <returns> un objeto del tipo tblTiposdeCredito. </returns>
        public tblCreditosTipo gmtdConsultar(string tstrCodTipo)
        {
            using (dbExequial2010DataContext tipos = new dbExequial2010DataContext())
            {
                var query = from tip in tipos.tblCreditosTipos
                            where tip.strCodigoTcr == tstrCodTipo
                            select tip;

                if (query.ToList().Count > 0)
                    return query.ToList()[0];
                else
                    return new tblCreditosTipo();
            }
        }

        /// <summary> Elimina un tipo de credito de la base de datos. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo tipodecredito. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblCreditosTipo tobjTiposdeCredito)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext tipo = new dbExequial2010DataContext())
                {
                    var query = from tip in tipo.tblCreditosTipos
                                where tip.strCodigoTcr == tobjTiposdeCredito.strCodigoTcr
                                select tip;

                    foreach (var detail in query)
                    {
                        tipo.tblCreditosTipos.DeleteOnSubmit(detail);
                    }

                    tipo.tblLogdeActividades.InsertOnSubmit(tobjTiposdeCredito.log);
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
