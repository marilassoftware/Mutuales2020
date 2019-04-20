namespace libMutuales2020.logica
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dao;
    using libMutuales2020.dominio;

    [DataObject(true)]
    public class blCuenta
    {
        /// <summary> Inserta una Cuenta. </summary>
        /// <param name="tobjCuenta"> Un objeto del tipo cuenta. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblCuenta tobjCuenta)
        {
            if (tobjCuenta.strCuenta == "")
            {
                return "- Debe de ingresar el código de la cuenta.";
            }

            if (tobjCuenta.strDescripcion == "")
            {
                return "- Debe de ingresar la descripción de la cuenta.";
            }

            tblCuenta cue = new daoCuenta().gmtdConsultar(tobjCuenta.strCuenta);

            if (cue.strCuenta == null)
            {
                tobjCuenta.log = metodos.gmtdLog("Ingresa la cuenta " + tobjCuenta.strCuenta, tobjCuenta.strFormulario);
                return new daoCuenta().gmtdInsertar(tobjCuenta);
            }
            else
                return "- Este registro ya aparece ingresado.";
        }

        /// <summary> Modifica una cuenta. </summary>
        /// <param name="tobjCuenta"> Un objeto del tipo cuenta.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblCuenta tobjCuenta)
        {
            if (tobjCuenta.strCuenta == "")
            {
                return "- Debe de ingresar el código de la cuenta.";
            }

            if (tobjCuenta.strDescripcion == "")
            {
                return "- Debe de ingresar la descripción de la cuenta.";
            }

            tblCuenta cue = new daoCuenta().gmtdConsultar(tobjCuenta.strCuenta);

            if (cue.strCuenta == null)
                return "- Este registro no aparece ingresado.";
            else
            {
                tobjCuenta.log = metodos.gmtdLog("Modifica la cuenta " + tobjCuenta.strCuenta, tobjCuenta.strFormulario);
                return new daoCuenta().gmtdEditar(tobjCuenta);
            }
        }

        /// <summary> Consulta todas las cuentas registradas. </summary
        /// <returns> Un lista con todas las cuentas seleccionadas. </returns>
        public IList<cuenta> gmtdConsultarTodos()
        {
            return new daoCuenta().gmtdConsultarTodos();  
        }

        /// <summary> Consulta todas las cuentas registradas de acuerdo al parametro. si es true todas las cuentas debito o si es false todas las cuentas credito </summary>
        /// <param name="tbitDebito"> Un valor true o false. </param>
        /// <returns> Un lista con todas las cuentas seleccionadas. </returns>
        public IList<cuenta> gmtdConsultarTodos(bool tbitDebito)
        {
            return new daoCuenta().gmtdConsultarTodos(tbitDebito);   
        }

        /// <summary> Consulta una determinada cuentastradas de acuerdo al parametro. </summary>
        /// <param name="tbitDebito"> Un valor true o false. </param>
        /// <returns> Un lista con todas las cuentas seleccionadas. </returns>
        public tblCuenta gmtdConsultar(string tstrCuenta)
        {
            return new daoCuenta().gmtdConsultar(tstrCuenta);
        }

        /// <summary> Elimina una cuenta de la base de datos. </summary>
        /// <param name="tobjCuenta"> Un objeto del tipo cuenta, con la cuenta que se quiere eliminar. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public string gmtdEliminar(tblCuenta tobjCuenta)
        {
            if (tobjCuenta.strCuenta == "")
            {
                return "- Debe de ingresar el código de la cuenta.";
            }

            tblCuenta cue = new daoCuenta().gmtdConsultar(tobjCuenta.strCuenta);

            if (cue.strCuenta == null)
                return "- Este registro no aparece ingresado.";
            else
            {
                tobjCuenta.log = metodos.gmtdLog("Elimina la cuenta " + tobjCuenta.strCuenta, tobjCuenta.strFormulario);
                return new daoCuenta().gmtdEliminar(tobjCuenta);
            }
        }
    }
}
