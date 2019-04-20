namespace libMutuales2020.logica
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dao;
    using libMutuales2020.dominio;

    [DataObject(true)]
    public class blCompras
    {
        /// <summary> Inserta una compra. </summary>
        /// <param name="tobjCompra"> Un objeto del tipo tblCompra. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblCompra tobjCompra)
        {
            if (tobjCompra.fltDebeCom == 0)
                return "- Debe de ingresar el valor que se debe de la compra.";

            if (tobjCompra.fltTotalCom == 0)
                return "- Debe de ingresar el valor de la compra.";

            if (tobjCompra.strCodProvedor == null)
                return "- Debe de ingresar el código del proveedor a que se le hizo la compra.";

            if (tobjCompra.lstDetalle.Count <= 0)
                return "- Debe de registrar al menos un producto en la venta. ";

            tobjCompra.bitAnuladoCom = false;
            tobjCompra.dtmFechaAnuCom = Convert.ToDateTime("1900-01-01");
            tobjCompra.dtmFechaCom = DateTime.Now;

            foreach (tblComprasDetalle coompra in tobjCompra.lstDetalle)
            {
                tobjCompra.tblComprasDetalles.Add(coompra);
            }

            tobjCompra.log = metodos.gmtdLog("Ingresa compra " + tobjCompra.dtmFechaCom.ToString(), tobjCompra.strFormulario);

            return new daoCompra().gmtdInsertar(tobjCompra);
        }

        /// <summary> Consulta todos las compras. </summary>
        /// <returns> Un lista con todos las compras seleccionadas. </returns>
        public List<Compra> gmtdConsultarTodos()
        {
            return new daoCompra().gmtdConsultarTodos();
        }


        /// <summary> Consultar los registros del detalle de una compra. </summary>
        /// <param name="tintCodigo"> Codigo de la compra a la que se le va a conocer el detalle. </param>
        /// <returns> La lista con los detalles seleccionados. </returns>
        public List<CompraDetalle> gmtdConsultarDetalle(int tintCodigo)
        {
            return new daoCompra().gmtdConsultarDetalle(tintCodigo);
        }

        /// <summary> Consulta una compra. </summary>
        /// <param name="tintCodigo"> El código de la compra a consultar. </param>
        /// <returns> Una compra consultada. </returns>
        public tblCompra gmtdConsultar(int tintCodigo)
        {
            return new daoCompra().gmtdConsultar(tintCodigo);
        }

            /// <summary> Elimina una compra de la base de datos. </summary>
        /// <param name="tobjVenta"> Un objeto del tipo tblCompra. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblCompra tobjCompra)
        {
            if (tobjCompra.intCodCompra == 0)
                return "- Debe de ingresar el código de la compra a eliminar.";

            if (tobjCompra.lstDetalle.Count <= 0)
                return "- Debe de haber registrado al menos un producto en la compra. ";

            tobjCompra.bitAnuladoCom = true;
            tobjCompra.dtmFechaAnuCom = DateTime.Now;

            tblCompra compraa = new daoCompra().gmtdConsultar(tobjCompra.intCodCompra);

            if (compraa.intCodCompra == 0)
                return "- Esta compra no aparece registrada. ";
            else
            {
                if (compraa.bitAnuladoCom == true)
                {
                    return "- No se puede eliminar una compra que ya esta eliminada.";
                }
                tobjCompra.log = metodos.gmtdLog("Elimina la compra " + tobjCompra.intCodCompra.ToString(), tobjCompra.strFormulario);
                return new daoCompra().gmtdEliminar(tobjCompra);
            }
        }
    }
}
