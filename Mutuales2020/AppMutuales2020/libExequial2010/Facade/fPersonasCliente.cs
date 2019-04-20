namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fCliente
    {
        /// <summary> Inserta un cliente. </summary>
        /// <param name="tobjCliente"> Un objeto del tipo cliente. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblCliente tobjCliente)
        {
            return new blCliente().gmtdInsertar(tobjCliente);
        }

        /// <summary> Modifica un cliente. </summary>
        /// <param name="tobjCliente"> Un objeto del tipo cliente.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblCliente tobjCliente)
        {
            return new blCliente().gmtdEditar(tobjCliente);
        }

        /// <summary> Consulta todos los clientes registrados. </summary>
        /// <returns> Un lista con todos los clientes seleccionados. </returns>
        public IList<Cliente> gmtdConsultarTodos()
        {
            return new blCliente().gmtdConsultarTodos();
        }

        /// <summary> Consulta si un código de cliente ya aparece registrado. </summary>
        /// <param name="tstrCodigoCli"> Código del cliente a consultar. </param>
        /// <returns> Un valor que indica si se encontro o no el código del cliente. </returns>
        public bool gmtdConsultarCodigoCliente(string tstrCodigoCli)
        {
            return new blCliente().gmtdConsultarCodigoCliente(tstrCodigoCli);
        }

        /// <summary>Consulta los datos de un determinado cliente. </summary>
        /// <param name="tstrCodigoCli"> El código del cliente a consultar </param>
        /// <returns> Los datos de cliente consultado. </returns>
        public tblCliente gmtdConsultarDetalle(string tstrCodigoCli)
        {
            return new blCliente().gmtdConsultarDetalle(tstrCodigoCli);
        }

        /// <summary> Consulta los clientes registrados de un tipo. </summary>
        /// <param name="tstrCedulaCli"> Descripcion del tipo de cliente que se quiere consultar. </param>
        /// <returns> Una lista con los clientes seleccionados. </returns>
        public List<tblCliente> gmtdConsultarTipoCliente(string tstrTipoCliente)
        {
            return new blCliente().gmtdConsultarTipoCliente(tstrTipoCliente);
        }

        /// <summary>Selecciona los clientes registrados cuya informacíón coicida con los campos de la clausula where. </summary>
        /// <param name="tobjCliente"> El objeto cliente con los datos para filtrar </param>
        /// <returns> Un lista con los clientes seleccionados. </returns>
        public IList<Cliente> gmtdFiltrar(tblCliente tobjCliente)
        {
            return new blCliente().gmtdFiltrar(tobjCliente);
        }

        /// <summary> Consulta un determinado cliente. </summary>
        /// <param name="tstrCodigoCli">El código del cliente a consultar.</param>
        /// <returns> un objeto del tipo tblCliente. </returns>
        public tblCliente gmtdConsultar(string tstrCodigoCli)
        {
            return new blCliente().gmtdConsultar(tstrCodigoCli);
        }

        /// <summary> Elimina un cliente de la base de datos. </summary>
        /// <param name="tobjCliente"> Un objeto del tipo tblCliente. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblCliente tobjCliente)
        {
            return new blCliente().gmtdEliminar(tobjCliente);
        }
    }
}
