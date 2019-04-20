namespace libMutuales2020.logica
{
    using System;
    using System.Collections.Generic;
    using libMutuales2020.dao;
    using libMutuales2020.dominio;

    public class blCliente
    {
        /// <summary> Inserta un cliente. </summary>
        /// <param name="tobjCliente"> Un objeto del tipo cliente. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblCliente tobjCliente)
        {
            if (tobjCliente.dtmFechaIng == null)
            {
                return "- Debe de ingresar la fecha de ingreso.";
            }

            if (tobjCliente.strCodigoCli == "")
            {
                return "- Debe de ingresar el código del cliente. ";
            }

            if (tobjCliente.strContacto == "")
            {
                return "- Debe de ingresar el contacto donde el cliente. ";
            }

            if (tobjCliente.strDireccion == "")
            {
                return "- Debe de ingresar la dirección. ";
            }

            if (tobjCliente.strEmpresa == "")
            {
                return "- Debe de ingresar el nombre de la empresa o del cliente si es un particular. ";
            }

            if (tobjCliente.strTelefono == "")
            {
                return "- Debe de ingresar el número telefonico. ";
            }

            if (tobjCliente.strTipoDoc == "")
            {
                return "- Debe de ingresar el tipo de documento. ";
            }

            tblCliente cli = new daoCliente().gmtdConsultar(tobjCliente.strCodigoCli);

            if (cli.strCodigoCli == null)
            {
                tobjCliente.bitAnulado = false;
                tobjCliente.dtmFechaAnu = Convert.ToDateTime("01/01/1900");
                tobjCliente.log = metodos.gmtdLog("Ingresa el cliente " + tobjCliente.strCodigoCli, tobjCliente.strFormulario);
                return new daoCliente().gmtdInsertar(tobjCliente);
            }
            else
            {
                return "- Este registro ya aparece ingresado.";
            }
        }

        /// <summary> Modifica un cliente. </summary>
        /// <param name="tobjCliente"> Un objeto del tipo cliente.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblCliente tobjCliente)
        {
            if (tobjCliente.dtmFechaIng == null)
            {
                return "- Debe de ingresar la fecha de ingreso.";
            }

            if (tobjCliente.strCodigoCli == "")
            {
                return "- Debe de ingresar el código del cliente. ";
            }

            if (tobjCliente.strContacto == "")
            {
                return "- Debe de ingresar el contacto donde el cliente. ";
            }

            if (tobjCliente.strDireccion == "")
            {
                return "- Debe de ingresar la dirección. ";
            }

            if (tobjCliente.strEmpresa == "")
            {
                return "- Debe de ingresar el nombre de la empresa o del cliente si es un particular. ";
            }

            if (tobjCliente.strTelefono == "")
            {
                return "- Debe de ingresar el número telefonico. ";
            }

            if (tobjCliente.strTipoDoc == "")
            {
                return "- Debe de ingresar el tipo de documento. ";
            }

            tblCliente cli = new daoCliente().gmtdConsultar(tobjCliente.strCodigoCli);

            if (cli.strCodigoCli == null)
            {
                return "- Este registro no aparece ingresado.";
            }
            else
            {
                tobjCliente.log = metodos.gmtdLog("Modifica el cliente " + tobjCliente.strCodigoCli, tobjCliente.strFormulario);
                return new daoCliente().gmtdEditar(tobjCliente);
            }
        }

        /// <summary> Consulta todos los clientes registrados. </summary>
        /// <returns> Un lista con todos los clientes seleccionados. </returns>
        public IList<Cliente> gmtdConsultarTodos()
        {
            return new daoCliente().gmtdConsultarTodos();
        }

        /// <summary> Consulta si un código de cliente ya aparece registrado. </summary>
        /// <param name="tstrCodigoCli"> Código del cliente a consultar. </param>
        /// <returns> Un valor que indica si se encontro o no el código del cliente. </returns>
        public bool gmtdConsultarCodigoCliente(string tstrCodigoCli)
        {
            return new daoCliente().gmtdConsultarCodigoCliente(tstrCodigoCli);
        }

        /// <summary>Consulta los datos de un determinado cliente. </summary>
        /// <param name="tstrCodigoCli"> El código del cliente a consultar </param>
        /// <returns> Los datos de cliente consultado. </returns>
        public tblCliente gmtdConsultarDetalle(string tstrCodigoCli)
        {
            return new daoCliente().gmtdConsultarDetalle(tstrCodigoCli);
        }

        /// <summary> Consulta los clientes registrados de un tipo. </summary>
        /// <param name="tstrCedulaCli"> Descripcion del tipo de cliente que se quiere consultar. </param>
        /// <returns> Una lista con los clientes seleccionados. </returns>
        public List<tblCliente> gmtdConsultarTipoCliente(string tstrTipoCliente)
        {
            return new daoCliente().gmtdConsultarTipoCliente(tstrTipoCliente);
        }

        /// <summary>Selecciona los clientes registrados cuya informacíón coicida con los campos de la clausula where. </summary>
        /// <param name="tobjCliente"> El objeto cliente con los datos para filtrar </param>
        /// <returns> Un lista con los clientes seleccionados. </returns>
        public IList<Cliente> gmtdFiltrar(tblCliente tobjCliente)
        {
            if (tobjCliente.strCodigoCli == "0")
            {
                tobjCliente.strCodigoCli = "";
            }

            return new daoCliente().gmtdFiltrar(tobjCliente);
        }

        /// <summary> Consulta un determinado cliente. </summary>
        /// <param name="tstrCodigoCli">El código del cliente a consultar.</param>
        /// <returns> un objeto del tipo tblCliente. </returns>
        public tblCliente gmtdConsultar(string tstrCodigoCli)
        {
            return new daoCliente().gmtdConsultar(tstrCodigoCli);
        }

        /// <summary> Elimina un cliente de la base de datos. </summary>
        /// <param name="tobjCliente"> Un objeto del tipo tblCliente. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblCliente tobjCliente)
        {
            if (tobjCliente.strCodigoCli == "0")
            {
                return "- Debe de ingresar el código del ahorrador a eliminar.";
            }

            tblCliente aho = new daoCliente().gmtdConsultar(tobjCliente.strCodigoCli);

            if (aho.strCodigoCli == null)
            {
                return "- Este registro no aparece ingresado.";
            }
            else
            {
                tobjCliente.log = metodos.gmtdLog("Elimina el cliente " + tobjCliente.strCodigoCli, tobjCliente.strFormulario);
                return new daoCliente().gmtdEliminar(tobjCliente);
            }
        }
    }
}