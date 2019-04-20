using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using libMutuales2020.dominio;
using libMutuales2020.logica;
using System.Data.SqlClient;
using libMutuales2020.Utilidades;
using libMutuales2020.Recursos;
using System.Data;

namespace libMutuales2020.dao
{
    class daoVenta
    {
        /// <summary> Inserta una venta. </summary>
        /// <param name="tobjVenta"> Un objeto del tipo tblVenta. </param>
        /// <returns> Un objeto del tipo tblventa con el código de la venta
        /// que se registro y un mensaje que indica si se ejecuto o no la operación. </returns>
        public Respuesta gmtdInsertar(string txmlVenta)
        {
            Respuesta objResuesta = new Respuesta();
            try
            {
                List<SqlParameter> lstParameters = new List<SqlParameter>();
                lstParameters.Add(new SqlParameter("xmlVenta", txmlVenta));

                DataTable dt = new Utilidad().ejecutarSp(lstParameters, Sp.spVentaInsertar);

                if (dt.Rows.Count > 0)
                {
                    objResuesta.intCodigo = Convert.ToInt32(dt.Rows[0]["intCodigo"].ToString());
                    objResuesta.strRespuesta = dt.Rows[0]["strRespuesta"].ToString();
                    objResuesta.strAdicional = dt.Rows[0]["strAdicional"].ToString();
                }
                else
                {
                    objResuesta.intCodigo = 0;
                    objResuesta.strRespuesta = "Error registrando la venta.";
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                objResuesta.intCodigo = 0;
                objResuesta.strRespuesta = "Error registrando la venta.";
            }

            return objResuesta;
            //try
            //{
            //    tblIngresosVenta ingresoVenta = new tblIngresosVenta();
            //    tblIngreso ingreso = new tblIngreso();
            //    if (tobjVenta.decAbonoEfectivoVen > 0 || tobjVenta.decMontoPrestamo > 0)
            //    {
            //        ingresoVenta.decAbona = tobjVenta.decAbonoEfectivoVen + tobjVenta.decMontoPrestamo;
            //        ingresoVenta.decAdeuda = tobjVenta.decDebeVen;
            //        ingresoVenta.intCodVenta = tobjVenta.intCodVenta;

            //        ingreso.bitVenta = true;
            //        ingreso.decTotalIng = tobjVenta.decAbonoEfectivoVen + tobjVenta.decMontoPrestamo;
            //        ingreso.dtmFechaAnu = Convert.ToDateTime("1/1/1900");
            //        ingreso.dtmFechaRec = tobjVenta.dtmFechaVen;
            //        ingreso.ingresoAbonoaVenta = ingresoVenta;
            //        ingreso.strCedulaIng = tobjVenta.strCodigoCliVen;
            //        ingreso.strComputador = tobjVenta.strComputador;
            //        ingreso.strFormulario = "FrmVentas";
            //        ingreso.strLetras = new blConfiguracion().montoenLetras(tobjVenta.decAbonoEfectivoVen.ToString());
            //        ingreso.strNombreIng = tobjVenta.strNombreCliente;
            //        ingreso.strApellidoIng = "";
            //        ingreso.strUsuario = tobjVenta.strUsuario;

            //        using (dbExequial2010DataContext recibosIngresos = new dbExequial2010DataContext())
            //        {
            //            //recibosIngresos.tblIngresos.InsertOnSubmit(ingreso);
            //            //ingreso.tblIngresosVentas.Add(ingreso.ingresoAbonoaVenta);

            //            if (tobjVenta.intCodigoPreVen > 0)
            //            {
            //                tblCredito cre_old = recibosIngresos.tblCreditos.SingleOrDefault(p => p.intCodigoCre == tobjVenta.intCodigoPreVen);
            //                cre_old.bitRespaldoVenta = true;

            //            }
            //            recibosIngresos.SubmitChanges();

            //            //ingreso.log = metodos.gmtdLog("Ingresa el recibo " + ingreso.intCodigoIng.ToString(), ingreso.strFormulario);
            //            //recibosIngresos.tblLogdeActividades.InsertOnSubmit(ingreso.log);

            //            recibosIngresos.SubmitChanges();
            //        }
            //    }

            //    using (dbExequial2010DataContext ventas = new dbExequial2010DataContext())
            //    {
            //        tobjVenta.intCodigoRec = ingreso.intCodigoIng;
            //        ventas.tblVentas.InsertOnSubmit(tobjVenta);

            //        foreach (tblVentasDetalle veenta in tobjVenta.lstDetalle)
            //        {
            //            veenta.intCodVenta = tobjVenta.intCodVenta;
            //            tobjVenta.tblVentasDetalles.Add(veenta);
            //        }

            //        ventas.tblLogdeActividades.InsertOnSubmit(tobjVenta.log);

            //        foreach (tblVentasDetalle veentas in tobjVenta.lstDetalle)
            //        {
            //            tblProducto can_old = ventas.tblProductos.SingleOrDefault(p => p.strCodProducto == veentas.strCodProducto);
            //            can_old.intCantidad -= veentas.intCantidad;
            //        }

            //        ventas.SubmitChanges();

            //        //tblIngresosVenta ven_old = ventas.tblIngresosVentas.SingleOrDefault(p => p.intCodigoIng == tobjVenta.intCodigoRec);
            //        //ven_old.intCodVenta = tobjVenta.intCodVenta;

            //        //ventas.SubmitChanges();
            //    }

            //    tobjVenta.strMensaje = "Registro Insertado";
            //}
            //catch (Exception ex)
            //{
            //    new dao().gmtdInsertarError(ex);
            //    tobjVenta.strMensaje = "- Ocurrió un error al insertar el registro.";
            //}
            //return tobjVenta;
        }

        /// <summary> Consulta todos las ventas. </summary>
        /// <returns> Un lista con todos las ventas seleccionadas. </returns>
        public List<Venta> gmtdConsultarTodaslasVentas()
        {
            using (dbExequial2010DataContext ventas = new dbExequial2010DataContext())
            {
                var query = from deu in ventas.tblVentas
                            select deu;

                List<Venta> lstVenta = new List<Venta>();

                foreach (var dato in query.ToList())
                {
                    Venta ven = new Venta();
                    ven.bitAnuladoVen = dato.bitAnuladoVen;
                    ven.bitSocioVen = dato.bitSocioVen;
                    ven.dtmFechaAnuVen = dato.dtmFechaAnuVen;
                    ven.dtmFechaVen = dato.dtmFechaVen;
                    ven.decAbonoEfectivoVen = dato.decAbonoEfectivoVen;
                    ven.intCodigoPreVen = dato.intCodigoPreVen;
                    ven.intCodVenta = dato.intCodVenta;
                    ven.decDebeVen = dato.decDebeVen;
                    ven.decGranTotalVen = dato.decGranTotalVen;
                    ven.strCodigoCliVen = dato.strCodigoCliVen;
                    lstVenta.Add(ven);
                }

                return lstVenta;
            }
        }

        /// <summary> Consulta una venta. </summary>
        /// <param name="tintCodigo"> El código de la venta a consultar. </param>
        /// <returns> Una venta consultada. </returns>
        public tblVenta gmtdConsultar(int tintCodigo)
        {
            tblVenta objVenta = new tblVenta();
            try
            {
                List<SqlParameter> lstParameters = new List<SqlParameter>();
                lstParameters.Add(new SqlParameter("intCodVenta", tintCodigo));

                DataTable dt = new Utilidad().ejecutarSp(lstParameters, Sp.uspVentaConsultar);

                if (dt.Rows.Count > 0)
                {
                    objVenta.bitAnuladoVen = Convert.ToBoolean(dt.Rows[0]["bitAnuladoVen"]);
                    objVenta.bitSocioVen = Convert.ToBoolean(dt.Rows[0]["bitSocioVen"]);
                    objVenta.decAbonoEfectivoVen = Convert.ToDecimal(dt.Rows[0]["decAbonoEfectivoVen"]);
                    objVenta.decDebeVen = Convert.ToDecimal(dt.Rows[0]["decDebeVen"]);
                    objVenta.decGranTotalVen = Convert.ToDecimal(dt.Rows[0]["decGranTotalVen"]);
                    objVenta.dtmFechaAnuVen = Convert.ToDateTime(dt.Rows[0]["dtmFechaAnuVen"]);
                    objVenta.dtmFechaVen = Convert.ToDateTime(dt.Rows[0]["dtmFechaVen"]);
                    objVenta.intCodigoPreVen = Convert.ToInt32(dt.Rows[0]["intCodigoPreVen"]);
                    objVenta.intCodigoRec = Convert.ToInt32(dt.Rows[0]["intCodigoRec"]);
                    objVenta.intCodVenta = Convert.ToInt32(dt.Rows[0]["intCodVenta"]);
                    objVenta.strCodigoCliVen = dt.Rows[0]["strCodigoCliVen"].ToString();
                    objVenta.strNombreCliente = dt.Rows[0]["strContacto"].ToString();
                }
                else
                {
                    objVenta.intCodVenta = -1;
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                objVenta.intCodigoRec = -1;
            }

            return objVenta;
        }

        /// <summary> Consultar los registros del detalle de una venta. </summary>
        /// <param name="tintCodigo"> Codigo de la venta a la que se le va a conocer el detalle. </param>
        /// <returns> La lista con los detalles de venta seleccionados. </returns>
        public List<VentaDetalle> gmtdConsultarDetalle(int tintCodigo)
        {
            List<VentaDetalle> lstVentaDetalle = new List<VentaDetalle>();
            try
            {
                List<SqlParameter> lstParameters = new List<SqlParameter>();
                lstParameters.Add(new SqlParameter("intCodVenta", tintCodigo));

                DataTable dt = new Utilidad().ejecutarSp(lstParameters, Sp.uspVentaDetalleConsultar);

                if (dt.Rows.Count > 0)
                {
                    for (int indexRow = 0; indexRow < dt.Rows.Count; indexRow++)
                    {
                        VentaDetalle objVentaDetalle = new VentaDetalle();
                        objVentaDetalle.decValCompra = Convert.ToDecimal(dt.Rows[indexRow]["decValCompra"]);
                        objVentaDetalle.decValVenta = Convert.ToDecimal(dt.Rows[indexRow]["decValVenta"]);
                        objVentaDetalle.intCantidad = Convert.ToInt32(dt.Rows[indexRow]["intCantidad"]);
                        objVentaDetalle.intCodVenta = Convert.ToInt32(dt.Rows[indexRow]["intCodVenta"]);
                        objVentaDetalle.decTotal = Convert.ToInt32(dt.Rows[indexRow]["intTotal"]);
                        objVentaDetalle.strCodProducto = dt.Rows[indexRow]["strCodProducto"].ToString();
                        objVentaDetalle.strDesProducto = dt.Rows[indexRow]["strDesProducto"].ToString();

                        lstVentaDetalle.Add(objVentaDetalle);
                    }

                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
            }

            return lstVentaDetalle;
        }

        /// <summary> Elimina una venta de la base de datos. </summary>
        /// <param name="tobjVenta"> Un objeto del tipo tblVenta. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public Respuesta gmtdEliminar(Int32 intCodVenta)
        {
            Respuesta objRespuesta = new Respuesta();

            try
            {
                List<SqlParameter> lstParameters = new List<SqlParameter>();
                lstParameters.Add(new SqlParameter("intCodVenta", intCodVenta));

                DataTable dt = new Utilidad().ejecutarSp(lstParameters, Sp.uspVentaEliminar);

                objRespuesta.intCodigo = Convert.ToInt32(dt.Rows[0]["Respuesta"]);

            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                objRespuesta.intCodigo = 0;
            }

            return objRespuesta;
        }

        /// <summary> Consulta las ventas que tiene registrado un determinado cliente. </summary>
        /// <param name="tstrCedula"> Cédula del cliente que tiene registrada la venta. </param>
        /// <returns> Lista de ventas seleccionadas. </returns>
        public List<tblVenta> gmtdConsultarVentasxCedula(string tstrCedula)
        {
            using (dbExequial2010DataContext ventas = new dbExequial2010DataContext())
            {
                var query = from ven in ventas.tblVentas
                            where ven.strCodigoCliVen == tstrCedula && ven.bitAnuladoVen == false && ven.decDebeVen > 0
                            select ven;
                return query.ToList();
            }
        }

        /// <summary> Consultar los registros del detalle de una venta. </summary>
        /// <param name="tintCodigo"> Codigo de la venta a la que se le va a conocer el detalle. </param>
        /// <returns> La lista con los detalles de venta seleccionados. </returns>
        public List<VentaDetalle> gmtdConsultarDetalleTbl(int tintCodigo)
        {
            using (dbExequial2010DataContext ventas = new dbExequial2010DataContext())
            {
                var query = from deu in ventas.tblVentasDetalles
                            join ven in ventas.tblProductos on deu.strCodProducto equals ven.strCodProducto
                            where deu.intCodVenta == tintCodigo
                            select new { deu.intCantidad, deu.intCodVenta, deu.intTotal, deu.decValCompra, deu.decValVenta, deu.strCodProducto, ven.strDesProducto };

                List<VentaDetalle> lstVentaDetalle = new List<VentaDetalle>();

                foreach (var dato in query.ToList())
                {
                    VentaDetalle ven = new VentaDetalle();
                    ven.intCantidad = dato.intCantidad;
                    ven.decTotal = dato.intTotal;
                    ven.decValCompra = dato.decValCompra;
                    ven.decValVenta = dato.decValVenta;
                    ven.strCodProducto = dato.strCodProducto;
                    //ven.strNomProducto = dato.strDesProducto;
                    lstVentaDetalle.Add(ven);
                }
                return lstVentaDetalle;
            }
        }
    }
}
