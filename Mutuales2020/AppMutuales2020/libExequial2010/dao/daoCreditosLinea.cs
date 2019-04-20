using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libMutuales2020.dominio;

namespace libMutuales2020.dao
{
    class daoCreditosLinea
    {
        /// <summary> Inserta una linea de credito. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo tblCreditosLinea. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblCreditosLinea tobjTiposdeCredito)
        {
            String strRetornar;
            try
            {
                using (dbExequial2010DataContext tipo = new dbExequial2010DataContext())
                {
                    tipo.tblCreditosLineas.InsertOnSubmit(tobjTiposdeCredito);
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

        /// <summary> Modifica una linea de credito. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo tblCreditosLinea.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblCreditosLinea tobjTiposdeCredito)
        {
            String strResultado;
            try
            
            {
                using (dbExequial2010DataContext tipo = new dbExequial2010DataContext())
                {
                    tblCreditosLinea lin_old = tipo.tblCreditosLineas.SingleOrDefault(p => p.strCodLineadeCredito == tobjTiposdeCredito.strCodLineadeCredito);
                    lin_old.strNomLineadeCredito = tobjTiposdeCredito.strNomLineadeCredito;
                    lin_old.strCodigoTcr = tobjTiposdeCredito.strCodigoTcr;
                    lin_old.strParCapital = tobjTiposdeCredito.strParCapital;
                    lin_old.strParInteres = tobjTiposdeCredito.strParInteres;
                    lin_old.strParMora = tobjTiposdeCredito.strParMora;
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

        /// <summary> Consulta todos las lineas de credito registrados. </summary>
        /// <returns> Un lista con todos los tipos de credito seleccionados. </returns>
        public IList<creditosLinea> gmtdConsultarTodos()
        {
            using (dbExequial2010DataContext tipos = new dbExequial2010DataContext())
            {
                var query = from tip in tipos.tblCreditosLineas
                            select tip;
                List<creditosLinea> lstTiposdeCredito = new List<creditosLinea>();

                foreach (var dato in query.ToList())
                {
                    creditosLinea tip = new creditosLinea();
                    tip.strCodigoTcr = dato.strCodigoTcr;
                    tip.strNomLineadeCredito = dato.strNomLineadeCredito;
                    tip.strCodigoLin = dato.strCodLineadeCredito;
                    lstTiposdeCredito.Add(tip);
                }
                return lstTiposdeCredito;
            }
        }

        /// <summary> Consulta todas las lineas de credito registradas a un determinado tipo. </summary>
        /// <param name="tstrCodTipoCredito"> El código del tipo de credito. </param>
        /// <returns> Un lista con todos las lineas de credito seleccionadas. </returns>
        public IList<creditosLinea> gmtdConsultarLineasxTipodeCredito(string tstrCodTipoCredito)
        {
            using (dbExequial2010DataContext tipos = new dbExequial2010DataContext())
            {
                var query = from tip in tipos.tblCreditosLineas
                            where tip.strCodigoTcr == tstrCodTipoCredito
                            select tip;
                List<creditosLinea> lstTiposdeCredito = new List<creditosLinea>();

                foreach (var dato in query.ToList())
                {
                    creditosLinea tip = new creditosLinea();
                    tip.strCodigoTcr = dato.strCodigoTcr;
                    tip.strNomLineadeCredito = dato.strNomLineadeCredito;
                    tip.strCodigoLin = dato.strCodLineadeCredito;
                    lstTiposdeCredito.Add(tip);
                }
                return lstTiposdeCredito;
            }
        }


        /// <summary> Consulta todos las lineas de credito registrados. </summary>
        /// <returns> Un lista con todos los tipos de credito seleccionados. </returns>
        public tblCreditosLinea gmtdConsultar(string tstrCodLinea)
        {
            using (dbExequial2010DataContext tipos = new dbExequial2010DataContext())
            {
                var query = from tip in tipos.tblCreditosLineas
                            where tip.strCodLineadeCredito == tstrCodLinea
                            select tip;
                if (query.ToList().Count > 0)
                    return query.ToList()[0];
                else
                    return new tblCreditosLinea();

            }
        }

        /// <summary> Consulta el valor de interes de un tipo de crédito. </summary>
        /// <param name="tstrCodLinea"> Codigo de la linea de crédito.</param>
        /// <param name="tstrFecuenciadePago"> Frecuencia en la que se va a pagar el crédito.</param>
        /// <returns> El porcentaje del crédito. </returns>
        public decimal gmtdConsultarValordeInteres(string tstrCodLinea, propiedades.FrecuenciaPago tstrFecuenciadePago)
        {
            using (dbExequial2010DataContext tipos = new dbExequial2010DataContext())
            {
                var query = from tip in tipos.tblCreditosLineas
                            join lin in tipos.tblCreditosTipos on tip.strCodigoTcr equals lin.strCodigoTcr
                            where tip.strCodLineadeCredito == tstrCodLinea
                            select new { lin.decTasaNominalAnualUsuraDecadalTcr, lin.decTasaNominalAnualUsuraMensualTcr, lin.decTasaNominalAnualUsuraQuincenalTcr, lin.decTasaNominalAnualUsuraSemanalTcr };

                if (tstrFecuenciadePago == propiedades.FrecuenciaPago.Semanal)
                    return (decimal)query.ToList()[0].decTasaNominalAnualUsuraSemanalTcr;

                if (tstrFecuenciadePago == propiedades.FrecuenciaPago.Decadal)
                    return (decimal)query.ToList()[0].decTasaNominalAnualUsuraDecadalTcr;

                if (tstrFecuenciadePago == propiedades.FrecuenciaPago.Quincenal)
                    return (decimal)query.ToList()[0].decTasaNominalAnualUsuraQuincenalTcr;

                if (tstrFecuenciadePago == propiedades.FrecuenciaPago.Mensual)
                    return (decimal)query.ToList()[0].decTasaNominalAnualUsuraMensualTcr;

                return 0;
            }
        }

        /// <summary> Elimina un tipo de credito de la base de datos. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo tipodecredito. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblCreditosLinea tobjLineadeCredito)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext tipo = new dbExequial2010DataContext())
                {
                    var query = from tip in tipo.tblCreditosLineas
                                where tip.strCodLineadeCredito == tobjLineadeCredito.strCodLineadeCredito
                                select tip;

                    foreach (var detail in query)
                        tipo.tblCreditosLineas.DeleteOnSubmit(detail);

                    tipo.tblLogdeActividades.InsertOnSubmit(tobjLineadeCredito.log);
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
