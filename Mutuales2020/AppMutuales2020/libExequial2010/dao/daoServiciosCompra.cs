using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libMutuales2020.dominio;

namespace libMutuales2020.dao
{
    class daoCompra
    {
        /// <summary> Inserta una compra. </summary>
        /// <param name="tobjCompra"> Un objeto del tipo tblCompra. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblCompra tobjCompra)
        {
            String strRetornar;
            try
            {
                using (dbExequial2010DataContext compras = new dbExequial2010DataContext())
                {
                    compras.tblCompras.InsertOnSubmit(tobjCompra);
                    compras.tblLogdeActividades.InsertOnSubmit(tobjCompra.log);
                    foreach (tblComprasDetalle coompras in tobjCompra.lstDetalle)
                    {
                        tblProducto pro_old = compras.tblProductos.SingleOrDefault(p => p.strCodProducto == coompras.strCodProducto);
                        pro_old.intCantidad += coompras.intCantidad;
                        string strValor = coompras.fltValorVenta.ToString();
                        pro_old.intValUnitario = Convert.ToInt32(strValor);
                    }
                    compras.SubmitChanges();
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

        /// <summary> Consulta todos las compras. </summary>
        /// <returns> Un lista con todos las compras seleccionadas. </returns>
        public List<Compra> gmtdConsultarTodos()
        {
            using (dbExequial2010DataContext compras = new dbExequial2010DataContext())
            {
                var query = from com in compras.tblCompras
                            join cli in compras.tblClientes on com.strCodProvedor equals cli.strCodigoCli
                            select new {com.bitAnuladoCom, com.dtmFechaAnuCom, com.dtmFechaCom, com.fltDebeCom, com.fltTotalCom, com.intCodCompra, com.strCodProvedor, cli.strContacto };     

                List<Compra> lstCompra = new List<Compra>();

                foreach (var dato in query.ToList())
                {
                    Compra com = new Compra();
                    com.bitAnuladoCom = dato.bitAnuladoCom;
                    com.dtmFechaAnuCom = dato.dtmFechaAnuCom;
                    com.dtmFechaCom = dato.dtmFechaCom;
                    com.fltDebeCom = dato.fltDebeCom;
                    com.fltTotalCom = dato.fltTotalCom;
                    com.intCodCompra = dato.intCodCompra;
                    com.strCodProvedor = dato.strCodProvedor;
                    com.strNomProvedor = dato.strContacto; 
                    lstCompra.Add(com);
                }

                return lstCompra;
            }
        }

        /// <summary> Consulta una compra. </summary>
        /// <param name="tintCodigo"> El código de la compra a consultar. </param>
        /// <returns> Una compra consultada. </returns>
        public tblCompra gmtdConsultar(int tintCodigo)
        {
            using (dbExequial2010DataContext compras = new dbExequial2010DataContext())
            {
                var query = from com in compras.tblCompras
                            where com.intCodCompra == tintCodigo
                            select com;

                if (query.ToList().Count > 0)
                    return query.ToList()[0];
                else
                    return new tblCompra();

            }
        }

        /// <summary> Consultar los registros del detalle de una compra. </summary>
        /// <param name="tintCodigo"> Codigo de la compra a la que se le va a conocer el detalle. </param>
        /// <returns> La lista con los detalles seleccionados. </returns>
        public List<CompraDetalle> gmtdConsultarDetalle(int tintCodigo)
        {
            using (dbExequial2010DataContext compras = new dbExequial2010DataContext())
            {
                var query = from com in compras.tblComprasDetalles
                            join pro in compras.tblProductos on com.strCodProducto equals pro.strCodProducto
                            where com.intCodCompra == tintCodigo
                            select new { com.fltTotal, com.fltValorCompra, com.fltValorVenta, com.intCantidad, com.intCodCompra, com.strCodProducto, pro.strDesProducto };

                List<CompraDetalle> lstCompraDetalle = new List<CompraDetalle>();

                foreach (var dato in query.ToList())
                {
                    CompraDetalle com = new CompraDetalle();
                    com.fltTotal = dato.fltTotal;
                    com.fltValorCompra = dato.fltValorCompra;
                    com.fltValorVenta = dato.fltValorVenta;
                    com.intCantidad = dato.intCantidad;
                    com.intCodCompra = dato.intCodCompra;
                    com.strCodProducto = dato.strCodProducto;
                    com.strNomProducto = dato.strDesProducto;
                    lstCompraDetalle.Add(com);
                }
                return lstCompraDetalle;
            }
        }

        /// <summary> Elimina una compra de la base de datos. </summary>
        /// <param name="tobjVenta"> Un objeto del tipo tblCompra. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblCompra tobjCompra)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext compraa = new dbExequial2010DataContext())
                {
                    tblCompra ofi_old = compraa.tblCompras.SingleOrDefault(p => p.intCodCompra == tobjCompra.intCodCompra);
                    ofi_old.bitAnuladoCom = tobjCompra.bitAnuladoCom;
                    ofi_old.dtmFechaAnuCom = tobjCompra.dtmFechaAnuCom;
                    compraa.tblLogdeActividades.InsertOnSubmit(tobjCompra.log);
                    foreach (tblComprasDetalle coompras in tobjCompra.lstDetalle)
                    {
                        tblProducto pro_old = compraa.tblProductos.SingleOrDefault(p => p.strCodProducto == coompras.strCodProducto);
                        pro_old.intCantidad -= coompras.intCantidad;
                    }
                    compraa.SubmitChanges();
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
