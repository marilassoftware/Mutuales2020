namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fCompras
    {
        /// <summary> Inserta una compra. </summary>
        /// <param name="tobjCompra"> Un objeto del tipo tblCompra. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblCompra tobjCompra)
        {
            return new blCompras().gmtdInsertar(tobjCompra);
        }

        /// <summary> Consulta todos las compras. </summary>
        /// <returns> Un lista con todos las compras seleccionadas. </returns>
        public List<Compra> gmtdConsultarTodos()
        {
            return new blCompras().gmtdConsultarTodos();
        }


        /// <summary> Consultar los registros del detalle de una compra. </summary>
        /// <param name="tintCodigo"> Codigo de la compra a la que se le va a conocer el detalle. </param>
        /// <returns> La lista con los detalles seleccionados. </returns>
        public List<CompraDetalle> gmtdConsultarDetalle(int tintCodigo)
        {
            return new blCompras().gmtdConsultarDetalle(tintCodigo);
        }

        /// <summary> Consulta una compra. </summary>
        /// <param name="tintCodigo"> El código de la compra a consultar. </param>
        /// <returns> Una compra consultada. </returns>
        public tblCompra gmtdConsultar(int tintCodigo)
        {
            return new blCompras().gmtdConsultar(tintCodigo);
        }

        /// <summary> Elimina una compra de la base de datos. </summary>
        /// <param name="tobjVenta"> Un objeto del tipo tblCompra. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblCompra tobjCompra)
        {
            return new blCompras().gmtdEliminar(tobjCompra);
        }
    }
}
