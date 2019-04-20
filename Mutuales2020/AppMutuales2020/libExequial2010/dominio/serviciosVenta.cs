using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    [Serializable]
    public class Venta
    {
        public int intCodVenta {get;set;}

        public string strCodigoCliVen {get;set;}

        public string strNombreCliente { get; set; }

        public string strFormulario { get; set; }

        public decimal decGranTotalVen { get; set; }

        public decimal decDebeVen {get;set;}

        public DateTime dtmFechaVen {get;set;}

        public bool bitAnuladoVen {get;set;}

        public DateTime dtmFechaAnuVen {get;set;}

        public bool bitSocioVen {get;set;}

        public decimal decAbonoEfectivoVen {get;set;}

        public int intCodigoPreVen {get;set;}

        public int intCodigoRec { get; set; }

        public string strUsuario { get; set; }

        public List<VentaDetalle> lstVentasDetalle { get; set; }

        /// <summary> Registra el log de actividades. </summary>
        public tblLogdeActividade log { get; set; }

        /// <summary> Almacena el mensaje despues de hacer la operación de inserción. </summary>
        public string strMensaje { get; set; }

        /// <summary> Monto del prèstamo </summary>
        public decimal decMontoPrestamo { get; set; }

        /// <summary> Indica el computador desde el que se esta haciendo la venta </summary>
        public string strComputador { get; set; }

        public string strLetra { get; set; }
    }

    [Serializable]
    public class VentaDetalle
    {
        public int intCodVenta { get; set; }
        public string strCodProducto { get; set; }
        public string strNomProducto { get; set; }
        public string strDesProducto { get; set; }
        public decimal decValCompra { get; set; }
        public decimal decValVenta { get; set; }
        public int intCantidad { get; set; }
        public decimal decTotal { get; set; }
    }
    public partial class tblVenta
    {
        /// <summary> Registra el log de actividades. </summary>
        public tblLogdeActividade log {get; set;}

        /// <summary> Nombre desde el formulario donde se ejecuto la operación. </summary>
        public string strFormulario {get;set;}

        /// <summary> Nombre de la persona a la que se le hizo la venta. </summary>
        public string strNombreCliente { get; set; }

        /// <summary> Listado de los detalles de una venta. </summary>
        public List<tblVentasDetalle> lstDetalle {get; set;}

        /// <summary> Almacena el mensaje despues de hacer la operación de inserción. </summary>
        public string strMensaje { get; set; }

        /// <summary> Monto del prèstamo </summary>
        public decimal decMontoPrestamo {get;set;}

        /// <summary> Indica el computador desde el que se esta haciendo la venta </summary>
        public string strComputador { get; set; }

        public List<tblVentasDetalle> tblVentasDetalles { get; set; }

    }
}
