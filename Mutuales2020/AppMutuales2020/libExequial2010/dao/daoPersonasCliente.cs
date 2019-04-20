using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libMutuales2020.dominio;

namespace libMutuales2020.dao
{
    class daoCliente
    {
        /// <summary> Inserta un cliente. </summary>
        /// <param name="tobjCliente"> Un objeto del tipo tblCliente. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblCliente tobjCliente)
        {
            String strRetornar;
            try
            {
                using (dbExequial2010DataContext cliente = new dbExequial2010DataContext())
                {
                    cliente.tblClientes.InsertOnSubmit(tobjCliente);
                    cliente.tblLogdeActividades.InsertOnSubmit(tobjCliente.log);
                    cliente.SubmitChanges();
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

        /// <summary> Modifica un Cliente. </summary>
        /// <param name="tobjCliente"> Un objeto del tipo Cliente.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblCliente tobjCliente)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext cliente = new dbExequial2010DataContext())
                {
                    tblCliente cli_old = cliente.tblClientes.SingleOrDefault(p => p.strCodigoCli == tobjCliente.strCodigoCli);
                    cli_old.strCodigoCli = tobjCliente.strCodigoCli;
                    cli_old.strContacto = tobjCliente.strContacto;
                    cli_old.strCorreo = tobjCliente.strCorreo;
                    cli_old.strDireccion = tobjCliente.strDireccion;
                    cli_old.strEmpresa = tobjCliente.strEmpresa;
                    cli_old.dtmFechaIng = tobjCliente.dtmFechaIng;
                    cli_old.strTelefono = tobjCliente.strTelefono;
                    cli_old.strTipoCliente = tobjCliente.strTipoCliente;
                    cli_old.strTipoDoc = tobjCliente.strTipoDoc;
                    cliente.tblLogdeActividades.InsertOnSubmit(tobjCliente.log);
                    cliente.SubmitChanges();
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

        /// <summary> Consulta los datos de un determinado cliente. </summary>
        /// <param name="tstrCedulaCli"> La cédula del cliente a consultar. </param>
        /// <returns> Los datos del cliente consultado. </returns>
        public tblCliente gmtdConsultarDetalle(string tstrCodigoCli)
        {
            using (dbExequial2010DataContext clientes = new dbExequial2010DataContext())
            {
                var query = from cli in clientes.tblClientes
                            where cli.bitAnulado == false && cli.strCodigoCli == tstrCodigoCli
                            select cli;

                tblCliente cliente = new tblCliente();
                foreach (var dato in query.ToList())
                {
                    cliente.dtmFechaAnu = dato.dtmFechaAnu;
                    cliente.dtmFechaIng = dato.dtmFechaIng;
                    cliente.strCelular = dato.strCelular;
                    cliente.strCodigoCli = dato.strCodigoCli;
                    cliente.strContacto = dato.strContacto;
                    cliente.strCorreo = dato.strCorreo;
                    cliente.strDireccion = dato.strDireccion;
                    cliente.strEmpresa = dato.strEmpresa;
                    cliente.strTelefono = dato.strTelefono;
                    cliente.strTipoCliente = dato.strTipoCliente;
                    cliente.strTipoDoc = dato.strTipoDoc;
                }
                return cliente;

            }
        }

        /// <summary> Consulta si un número de cedula ya aparece registrado. </summary>
        /// <param name="tstrCedulaCli"> Cédula del cliente a consultar. </param>
        /// <returns> Un valor que indica si se encontro o no la cédula del cliente. </returns>
        public bool gmtdConsultarCodigoCliente(string tstrCodigoCli)
        {
            using (dbExequial2010DataContext clientes = new dbExequial2010DataContext())
            {
                var query = from aho in clientes.tblClientes
                            where aho.bitAnulado == false && aho.strCodigoCli == tstrCodigoCli
                            select aho;
                if (query.ToList().Count > 0)
                    return true;
                else
                    return false;
            }
        }

        /// <summary> Consulta los clientes registrados de un tipo. </summary>
        /// <param name="tstrCedulaCli"> Descripcion del tipo de cliente que se quiere consultar. </param>
        /// <returns> Una lista con los clientes seleccionados. </returns>
        public List<tblCliente> gmtdConsultarTipoCliente(string tstrTipoCliente)
        {
            using (dbExequial2010DataContext clientes = new dbExequial2010DataContext())
            {
                var query = from cli in clientes.tblClientes
                            where cli.bitAnulado == false && cli.strTipoCliente == tstrTipoCliente
                            select cli;

                return query.ToList();
            }
        }

        /// <summary>Selecciona los clientes registrados cuya informacíón coicida con los campos de la clausula where. </summary>
        /// <param name="tobjcliente"> El objeto cliente con los datos para filtrar </param>
        /// <returns> Un lista con los clientes seleccionados. </returns>
        public IList<Cliente> gmtdFiltrar(tblCliente tobjcliente)
        {
            using (dbExequial2010DataContext clientes = new dbExequial2010DataContext())
            {
                var query = from cli in clientes.tblClientes
                            where cli.bitAnulado == false
                            && cli.strCodigoCli.StartsWith(tobjcliente.strCodigoCli)
                            && cli.strContacto.StartsWith(tobjcliente.strContacto)
                            && cli.strEmpresa.StartsWith(tobjcliente.strEmpresa)
                            select cli;

                List<Cliente> lstClientes = new List<Cliente>();
                foreach (var dato in query.ToList())
                {
                    Cliente cli = new Cliente();
                    cli.strCodigoCli = dato.strCodigoCli;
                    cli.strContacto = dato.strContacto;
                    cli.strCelular = dato.strCelular;
                    cli.strEmpresa = dato.strEmpresa;
                    cli.strTelefono = dato.strTelefono;
                    lstClientes.Add(cli);
                }
                return lstClientes;
            }
        }

        /// <summary> Consulta todos los clientes registrados. </summary>
        /// <returns> Un lista con todos los clientes seleccionados. </returns>
        public IList<Cliente> gmtdConsultarTodos()
        {
            using (dbExequial2010DataContext clientes = new dbExequial2010DataContext())
            {
                var query = from aho in clientes.tblClientes
                            where aho.bitAnulado == false
                            select aho;

                List<Cliente> lstClientes = new List<Cliente>();
                foreach (var dato in query.ToList())
                {
                    Cliente cli = new Cliente();
                    cli.strCelular = dato.strCelular;
                    cli.strCodigoCli = dato.strCodigoCli;
                    cli.strContacto = dato.strContacto;
                    cli.strEmpresa = dato.strEmpresa;
                    cli.strTelefono = dato.strTelefono;
                    lstClientes.Add(cli);
                }
                return lstClientes;
            }
        }

        /// <summary> Consulta un determinado cliente. </summary>
        /// <param name="tstrCodigoCli">la cédula del cliente a consultar.</param>
        /// <returns> un objeto del tipo tblCliente. </returns>
        public tblCliente gmtdConsultar(string tstrCodigoCli)
        {
            using (dbExequial2010DataContext clientes = new dbExequial2010DataContext())
            {
                var query = from cli in clientes.tblClientes
                            where cli.bitAnulado == false && cli.strCodigoCli == tstrCodigoCli
                            select cli;

                if (query.ToList().Count > 0)
                {
                    return query.ToList()[0];
                }
                else
                {
                    return new tblCliente();
                }
            }
        }

        /// <summary> Elimina un cliente de la base de datos. </summary>
        /// <param name="tobjCliente"> Un objeto del tipo tblAhorradore. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblCliente tobjCliente)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext clientes = new dbExequial2010DataContext())
                {
                    tblCliente cli_old = clientes.tblClientes.SingleOrDefault(p => p.strCodigoCli == tobjCliente.strCodigoCli);
                    cli_old.bitAnulado = true;
                    cli_old.dtmFechaAnu = DateTime.Now;

                    clientes.tblLogdeActividades.InsertOnSubmit(tobjCliente.log);
                    clientes.SubmitChanges();
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
