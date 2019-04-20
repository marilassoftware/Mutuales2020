namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fMaestrosProducto
    {
        /// <summary> Inserta un producto. </summary>
        /// <param name="tobjProducto"> Un objeto del tipo producto. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblProducto tobjProducto)
        {
            return new blProducto().gmtdInsertar(tobjProducto);
        }

        /// <summary> Modifica un producto. </summary>
        /// <param name="tobjProducto"> Un objeto del tipo producto.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblProducto tobjProducto)
        {
            return new blProducto().gmtdEditar(tobjProducto);
        }

        /// <summary> Consulta todos los productos registrados. </summary>
        /// <returns> Un lista con todos los productos seleccionados. </returns>
        public IList<producto> gmtdConsultarTodos()
        {
            return new blProducto().gmtdConsultarTodos();
        }

        /// <summary> Consulta un determinado producto. </summary>
        /// <param name="tstrCodProducto">el código del producto a consultar.</param>
        /// <returns> un objeto del tipo tblProducto. </returns>
        public tblProducto gmtdConsultar(string tstrCodProducto)
        {
            return new blProducto().gmtdConsultar(tstrCodProducto);
        }

        /// <summary> Consulta un determinado producto de acuerdo a su descripción. </summary>
        /// <param name="tstrCodProducto">el nombre del producto a consultar.</param>
        /// <returns> un objeto del tipo tblProducto. </returns>
        public tblProducto gmtdConsultarxNombre(string tstrDesProducto)
        {
            return new blProducto().gmtdConsultarxNombre(tstrDesProducto);
        }
        /// <summary> Elimina un producto de la base de datos. </summary>
        /// <param name="tobjProducto"> Un objeto del tipo tblProducto. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblProducto tobjProducto)
        {
            return new blProducto().gmtdEliminar(tobjProducto);
        }
    }
}
