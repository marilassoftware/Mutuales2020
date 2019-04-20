namespace libMutuales2020.logica
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Xml;
    using System.Xml.Serialization;
    using libMutuales2020.dao;
    using libMutuales2020.dominio;
    using libMutuales2020.Utilidades;

    [DataObject(true)]
    public class blVentas
    {
        /// <summary> Inserta una venta. </summary>
        /// <param name="tobjVenta"> Un objeto del tipo tblVenta. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public Respuesta gmtdInsertar(Venta tobjVenta)
        {
            Respuesta objResuesta = new Respuesta();

            if (tobjVenta.decGranTotalVen == 0)
            {
                objResuesta.intCodigo = 0;
                objResuesta.strRespuesta = "Debe de ingresar el valor total de la venta. ";
                return objResuesta;
            }

            if (tobjVenta.lstVentasDetalle.Count <= 0)
            {
                objResuesta.intCodigo = 0;
                objResuesta.strRespuesta = "Debe de registrar al menos un producto en la venta.";
                return objResuesta;
            }

            if (tobjVenta.strCodigoCliVen == "")
            {
                objResuesta.intCodigo = 0;
                objResuesta.strRespuesta = "Debe de digitar la identificación del cliente de la venta.";
                return objResuesta;
            }

            tobjVenta.decDebeVen = tobjVenta.decGranTotalVen - tobjVenta.decAbonoEfectivoVen - tobjVenta.decMontoPrestamo;

            tobjVenta.bitAnuladoVen = false;
            tobjVenta.dtmFechaAnuVen = Convert.ToDateTime("1900/01/01");;
            tobjVenta.dtmFechaVen = new daoUtilidadesConfiguracion().gmtdCapturarFechadelServidor();

            if (tobjVenta.intCodigoPreVen > 0)
            { 
                tblCredito objCredito = new blCreditos().gmtdConsultar(tobjVenta.intCodigoPreVen);

                if (objCredito.strNombrePre == null)
                {
                    objResuesta.intCodigo = 0;
                    objResuesta.strRespuesta = "El crédito no aparece registrado.";
                    return objResuesta;
                }

                if (objCredito.bitRespaldoVenta)
                {
                    objResuesta.intCodigo = 0;
                    objResuesta.strRespuesta = "El crédito ya respaldo una venta, debe de ingresar un código de credito diferente.";
                    return objResuesta;
                }
            }

            for (int a = 0; a < tobjVenta.lstVentasDetalle.Count - 1; a++)
            {
                for (int b = a + 1; b < tobjVenta.lstVentasDetalle.Count; b++)
                {
                    if (tobjVenta.lstVentasDetalle[a].strCodProducto == tobjVenta.lstVentasDetalle[b].strCodProducto)
                    {
                        objResuesta.intCodigo = 0;
                        objResuesta.strRespuesta = "No puede haber 2 productos iguales en la lista de la venta.";
                        return objResuesta;
                    }
                }
            }

            tobjVenta.log = metodos.gmtdLog("Ingresa la venta " + DateTime.Now.ToString(), tobjVenta.strFormulario);

            string xmlVenta = this.generarXML(tobjVenta);

            return new daoVenta().gmtdInsertar(xmlVenta);
        }

        /// <summary> Consulta todos las ventas. </summary>
        /// <returns> Un lista con todos las ventas seleccionadas. </returns>
        public List<Venta> gmtdConsultarTodaslasVentas()
        {
            return new daoVenta().gmtdConsultarTodaslasVentas();
        }

        /// <summary> Consulta una venta. </summary>
        /// <param name="tintCodigo"> El código de la venta a consultar. </param>
        /// <returns> Una venta consultada. </returns>
        public tblVenta gmtdConsultar(int tintCodigo)
        {
            return new daoVenta().gmtdConsultar(tintCodigo);
        }

        /// <summary> Consultar los registros del detalle de una venta. </summary>
        /// <param name="tintCodigo"> Codigo de la venta a la que se le va a conocer el detalle. </param>
        /// <returns> La lista con los detalles seleccionados. </returns>
        public List<VentaDetalle> gmtdConsultarDetalle(int tintCodigo)
        {
            return new daoVenta().gmtdConsultarDetalle(tintCodigo);
        }

        /// <summary> Consulta las ventas que tiene registrado un determinado cliente. </summary>
        /// <param name="tstrCedula"> Cédula del cliente que tiene registrada la venta. </param>
        /// <returns> Lista de ventas seleccionadas. </returns>
        public List<tblVenta> gmtdConsultarVentasxCedula(string tstrCedula)
        {
            return new daoVenta().gmtdConsultarVentasxCedula(tstrCedula);
        }

        /// <summary> Elimina una venta de la base de datos. </summary>
        /// <param name="tobjVenta"> Un objeto del tipo tblVenta. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public Respuesta gmtdEliminar(Int32 intCodVenta)
        {
            Respuesta objRespuesta = new Respuesta();
            if (intCodVenta <= 0)
            {
                objRespuesta.intCodigo = 0;
                objRespuesta.strRespuesta = "Debe de ingresar el código de la venta a eliminar.";
                return objRespuesta;
            }

            tblVenta venta = new daoVenta().gmtdConsultar(intCodVenta);

            if (venta.intCodVenta == 0)
            {
                objRespuesta.intCodigo = 1;
                objRespuesta.strRespuesta = "Esta venta no aparece registrada.";
                return objRespuesta;
            }
            else
            {
                return new daoVenta().gmtdEliminar(intCodVenta);
            }
        }

        #region Utilidades
        public string generarXML(Venta objVenta)
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(Venta));
            StringWriter sw = new StringWriter();
            XmlWriter writer = XmlWriter.Create(sw);
            xsSubmit.Serialize(writer, objVenta);
            return sw.ToString();
        }
        #endregion
    }
}
