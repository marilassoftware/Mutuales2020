using System;
using System.Collections.Generic;
using System.Linq;
using libMutuales2020.dominio;

namespace libMutuales2020.dao
{
    class daoProducto
    {
        /// <summary> Inserta un producto. </summary>
        /// <param name="tobjProducto"> Un objeto del tipo producto. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblProducto tobjProducto)
        {
            String strRetornar;
            try
            {
                using (dbExequial2010DataContext Producto = new dbExequial2010DataContext())
                {
                    Producto.tblProductos.InsertOnSubmit(tobjProducto);
                    Producto.tblLogdeActividades.InsertOnSubmit(tobjProducto.log);
                    Producto.SubmitChanges();
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

        /// <summary> Modifica un producto. </summary>
        /// <param name="tobjProducto"> Un objeto del tipo producto.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblProducto tobjProducto)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext producto = new dbExequial2010DataContext())
                {
                    tblProducto pro_old = producto.tblProductos.SingleOrDefault(p => p.strCodProducto == tobjProducto.strCodProducto);
                    pro_old.fltIva = tobjProducto.fltIva;
                    pro_old.fltMargendeGanancia = tobjProducto.fltMargendeGanancia;
                    pro_old.intCantidad = tobjProducto.intCantidad;
                    pro_old.intMaxProducto = tobjProducto.intMaxProducto;
                    pro_old.intMinProducto = tobjProducto.intMinProducto;
                    pro_old.intValCompra = tobjProducto.intValCompra;
                    pro_old.intValUnitario = tobjProducto.intValUnitario;
                    pro_old.strDesProducto = tobjProducto.strDesProducto;
                    producto.tblLogdeActividades.InsertOnSubmit(tobjProducto.log);
                    producto.SubmitChanges();
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

        /// <summary> Consulta todos los productos registrados. </summary>
        /// <returns> Un lista con todos los productos seleccionados. </returns>
        public List<producto> gmtdConsultarTodos()
        {
            using (dbExequial2010DataContext product = new dbExequial2010DataContext())
            {
                var query = from pro in product.tblProductos
                            select pro;

                List<producto> lstProducto = new List<producto>();

                foreach (var dato in query.ToList())
                {
                    producto pro = new producto();
                    pro.fltIva = dato.fltIva;
                    pro.fltMargendeGanancia = dato.fltMargendeGanancia;
                    pro.intCantidad = dato.intCantidad;
                    pro.intMaxProducto = dato.intMaxProducto;
                    pro.intMinProducto = dato.intMinProducto;
                    pro.intValCompra = dato.intValCompra;
                    pro.intValUnitario = dato.intValUnitario;
                    pro.strCodProducto = dato.strCodProducto;
                    pro.strDesProducto = dato.strDesProducto;
                    lstProducto.Add(pro);
                }
                return lstProducto;
            }
        }

        /// <summary> Consulta un determinado producto. </summary>
        /// <param name="tstrCodProducto">el código del producto a consultar.</param>
        /// <returns> un objeto del tipo tblProducto. </returns>
        public tblProducto gmtdConsultar(string tstrCodProducto)
        {
            using (dbExequial2010DataContext product = new dbExequial2010DataContext())
            {
                var query = from pro in product.tblProductos
                            where pro.strCodProducto == tstrCodProducto
                            select pro;

                if (query.ToList().Count > 0)
                    return query.ToList()[0];
                else
                    return new tblProducto();
            }
        }

        /// <summary> Consulta un determinado producto de acuerdo a su descripción. </summary>
        /// <param name="tstrCodProducto">el nombre del producto a consultar.</param>
        /// <returns> un objeto del tipo tblProducto. </returns>
        public tblProducto gmtdConsultarxNombre(string tstrDesProducto)
        {
            using (dbExequial2010DataContext product = new dbExequial2010DataContext())
            {
                var query = from pro in product.tblProductos
                            where pro.strDesProducto == tstrDesProducto
                            select pro;

                if (query.ToList().Count > 0)
                    return query.ToList()[0];
                else
                    return new tblProducto();
            }
        }

        /// <summary> Elimina un producto de la base de datos. </summary>
        /// <param name="tobjProducto"> Un objeto del tipo tblProducto. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblProducto tobjProducto)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext product = new dbExequial2010DataContext())
                {
                    var query = from pro in product.tblProductos
                                where pro.strCodProducto == tobjProducto.strCodProducto
                                select pro;

                    foreach (var detail in query)
                    {
                        product.tblProductos.DeleteOnSubmit(detail);
                    }

                    product.tblLogdeActividades.InsertOnSubmit(tobjProducto.log);
                    product.SubmitChanges();
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
