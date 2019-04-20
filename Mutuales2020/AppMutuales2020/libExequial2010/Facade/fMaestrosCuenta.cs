namespace libMutuales2020.Facade
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fCuenta
    {
        /// <summary> Inserta una Cuenta. </summary>
        /// <param name="tobjCuenta"> Un objeto del tipo cuenta. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblCuenta tobjCuenta)
        {
            return new blCuenta().gmtdInsertar(tobjCuenta);
        }

        /// <summary> Modifica una cuenta. </summary>
        /// <param name="tobjCuenta"> Un objeto del tipo cuenta.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblCuenta tobjCuenta)
        {
            return new blCuenta().gmtdEditar(tobjCuenta);
        }

        /// <summary> Consulta todas las cuentas registradas. </summary
        /// <returns> Un lista con todas las cuentas seleccionadas. </returns>
        public IList<cuenta> gmtdConsultarTodos()
        {
            return new blCuenta().gmtdConsultarTodos();
        }

        /// <summary> Consulta todas las cuentas registradas de acuerdo al parametro. si es true todas las cuentas debito o si es false todas las cuentas credito </summary>
        /// <param name="tbitDebito"> Un valor true o false. </param>
        /// <returns> Un lista con todas las cuentas seleccionadas. </returns>
        public IList<cuenta> gmtdConsultarTodos(bool tbitDebito)
        {
            return new blCuenta().gmtdConsultarTodos(tbitDebito);
        }

        /// <summary> Consulta una determinada cuentastradas de acuerdo al parametro. </summary>
        /// <param name="tbitDebito"> Un valor true o false. </param>
        /// <returns> Un lista con todas las cuentas seleccionadas. </returns>
        public tblCuenta gmtdConsultar(string tstrCuenta)
        {
            return new blCuenta().gmtdConsultar(tstrCuenta);
        }

        /// <summary> Elimina una cuenta de la base de datos. </summary>
        /// <param name="tobjCuenta"> Un objeto del tipo cuenta, con la cuenta que se quiere eliminar. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public string gmtdEliminar(tblCuenta tobjCuenta)
        {
            return new blCuenta().gmtdEliminar(tobjCuenta);
        }
    }
}
