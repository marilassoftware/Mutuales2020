namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using libMutuales2020.Utilidades;

    [DataObject(true)]
    public class fVentas
    {
        /// <summary> Inserta una venta. </summary>
        /// <param name="tobjVenta"> Un objeto del tipo tblVenta. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public Respuesta gmtdInsertar(Venta tobjVenta)
        {
            return new blVentas().gmtdInsertar(tobjVenta);
        }

        /// <summary> Consulta todos las ventas. </summary>
        /// <returns> Un lista con todos las ventas seleccionadas. </returns>
        public List<Venta> gmtdConsultarTodaslasVentas()
        {
            return new blVentas().gmtdConsultarTodaslasVentas();
        }

        /// <summary> Consulta una venta. </summary>
        /// <param name="tintCodigo"> El código de la venta a consultar. </param>
        /// <returns> Una venta consultada. </returns>
        public tblVenta gmtdConsultar(int tintCodigo)
        {
            return new blVentas().gmtdConsultar(tintCodigo);
        }

        /// <summary> Consultar los registros del detalle de una venta. </summary>
        /// <param name="tintCodigo"> Codigo de la venta a la que se le va a conocer el detalle. </param>
        /// <returns> La lista con los detalles seleccionados. </returns>
        public List<VentaDetalle> gmtdConsultarDetalle(int tintCodigo)
        {
            return new blVentas().gmtdConsultarDetalle(tintCodigo);
        }

        /// <summary> Consulta las ventas que tiene registrado un determinado cliente. </summary>
        /// <param name="tstrCedula"> Cédula del cliente que tiene registrada la venta. </param>
        /// <returns> Lista de ventas seleccionadas. </returns>
        public List<tblVenta> gmtdConsultarVentasxCedula(string tstrCedula)
        {
            return new blVentas().gmtdConsultarVentasxCedula(tstrCedula);
        }

        /// <summary> Elimina una venta de la base de datos. </summary>
        /// <param name="tobjVenta"> Un objeto del tipo tblVenta. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public Respuesta gmtdEliminar(Int32 intCodVenta)
        {
            return new blVentas().gmtdEliminar(intCodVenta);
        }

    }
}
