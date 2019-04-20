namespace libMutuales2020.logica
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dao;
    using libMutuales2020.dominio;

    [DataObject(true)]
    public class blProducto
    {
        /// <summary> Inserta un producto. </summary>
        /// <param name="tobjProducto"> Un objeto del tipo producto. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblProducto tobjProducto)
        {
            if (tobjProducto.strCodProducto == "")
                return "- Debe de ingresar el código del producto. ";

            if (tobjProducto.strDesProducto == "")
                return "- Debe de ingresar la descripción de producto. ";

            if (tobjProducto.fltMargendeGanancia == 0)
                return "- Debe de ingresar el margen de ganancia. ";

            if (tobjProducto.intMaxProducto == 0)
                return "- Debe de ingresar el margen máximo. ";

            if (tobjProducto.intMinProducto == 0)
                return "- Debe de ingresar el margen mínimo. ";

            if (tobjProducto.intValCompra == 0)
                return "- Debe de ingresar el valor de compra. ";

            if (tobjProducto.intValUnitario == 0)
                return "- Debe de ingresar el valor unitario. ";

            tblProducto produc = new daoProducto().gmtdConsultar(tobjProducto.strCodProducto);

            if (produc.strCodProducto == null)
            {
                tobjProducto.log = metodos.gmtdLog("Ingresa el producto " + tobjProducto.strCodProducto, tobjProducto.strFormulario);
                return new daoProducto().gmtdInsertar(tobjProducto);
            }
            else
                return "- Este producto ya aparece registrado. ";
        }

        /// <summary> Modifica un producto. </summary>
        /// <param name="tobjProducto"> Un objeto del tipo producto.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblProducto tobjProducto)
        {
            if (tobjProducto.strCodProducto == null)
                return "- Debe de ingresar el código del producto. ";

            if (tobjProducto.strDesProducto == null)
                return "- Debe de ingresar la descripción de producto. ";

            if (tobjProducto.fltMargendeGanancia == 0)
                return "- Debe de ingresar el margen de ganancia. ";

            if (tobjProducto.intMaxProducto == 0)
                return "- Debe de ingresar el margen máximo. ";

            if (tobjProducto.intMinProducto == 0)
                return "- Debe de ingresar el margen mínimo. ";

            if (tobjProducto.intValCompra == 0)
                return "- Debe de ingresar el valor de compra. ";

            if (tobjProducto.intValUnitario == 0)
                return "- Debe de ingresar el valor unitario. ";

            tblProducto produc = new daoProducto().gmtdConsultar(tobjProducto.strCodProducto);

            if (produc.strCodProducto == null)
                return "- Este producto no aparece registrado. ";
            else
            {
                tobjProducto.log = metodos.gmtdLog("Modifica el producto " + tobjProducto.strCodProducto, tobjProducto.strFormulario);
                return new daoProducto().gmtdEditar(tobjProducto);
            }
        }

        /// <summary> Consulta todos los productos registrados. </summary>
        /// <returns> Un lista con todos los productos seleccionados. </returns>
        public List<producto> gmtdConsultarTodos()
        {
            return new daoProducto().gmtdConsultarTodos();  
        }

        /// <summary> Consulta un determinado producto. </summary>
        /// <param name="tstrCodProducto">el código del producto a consultar.</param>
        /// <returns> un objeto del tipo tblProducto. </returns>
        public tblProducto gmtdConsultar(string tstrCodProducto)
        {
            return new daoProducto().gmtdConsultar(tstrCodProducto);   
        }

        /// <summary> Consulta un determinado producto de acuerdo a su descripción. </summary>
        /// <param name="tstrCodProducto">el nombre del producto a consultar.</param>
        /// <returns> un objeto del tipo tblProducto. </returns>
        public tblProducto gmtdConsultarxNombre(string tstrDesProducto)
        {
            return new daoProducto().gmtdConsultarxNombre(tstrDesProducto);   
        }
        /// <summary> Elimina un producto de la base de datos. </summary>
        /// <param name="tobjProducto"> Un objeto del tipo tblProducto. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblProducto tobjProducto)
        {
            if (tobjProducto.strCodProducto == null)
                return "- Debe de ingresar el código del producto a eliminar. ";

            tblProducto produc = new daoProducto().gmtdConsultar(tobjProducto.strCodProducto);

            if (produc.strCodProducto == null)
                return "- Este producto no aparece registrado. ";
            else
            {
                tobjProducto.log = metodos.gmtdLog("Elimina el producto " + tobjProducto.strCodProducto, tobjProducto.strFormulario);
                return new daoProducto().gmtdEliminar(tobjProducto);
            }
        }
    }
}
