namespace libMutuales2020.Facade
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fCuentaPar
    {
        /// <summary> Inserta un Par. </summary>
        /// <param name="tobjCuentaPar"> Un objeto del tipo par.  </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblCuentasPare tobjCuentaPar)
        {
            return new blCuentaPar().gmtdInsertar(tobjCuentaPar);
        }

        /// <summary> Modifica un par. </summary>
        /// <param name="tobjCuentaPar"> Un objeto del tipo par.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblCuentasPare tobjCuentaPar)
        {
            return new blCuentaPar().gmtdEditar(tobjCuentaPar);
        }

        /// <summary> Consulta los pares registrados. </summary>
        /// <param name="tstrPar"> El código del par a consultar. </param>
        /// <returns> Un lista con todas los pares seleccionados. </returns>
        public List<cuentaPar> gmtdConsultarTodos()
        {
            return new blCuentaPar().gmtdConsultarTodos();
        }

        /// <summary> Elimina un par de la base de datos. </summary>
        /// <param name="tobjCuentaPar"> Un objeto del tipo par que se va a eliminar. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public string gmtdEliminar(tblCuentasPare tobjCuentaPar)
        {
            return new blCuentaPar().gmtdEliminar(tobjCuentaPar);
        }

        /// <summary> Consulta los cuentas credito registradas a un determinado par. </summary>
        /// <param name="tstrPar"> El código del par a consultar. </param>
        /// <returns> Un lista con todas las cuentas seleccionadas. </returns>
        public List<cuentaCredito> gmtdConsultarCreditos(string tstrCodigoPar)
        {
            return new blCuentaPar().gmtdConsultarCreditos(tstrCodigoPar);
        }

        /// <summary> Consulta los cuentas debito registradas a un determinado par. </summary>
        /// <param name="tstrPar"> El código del par a consultar. </param>
        /// <returns> Un lista con todas las cuentas seleccionadas. </returns>
        public List<cuentaDebito> gmtdConsultarDebitos(string tstrCodigoPar)
        {
            return new blCuentaPar().gmtdConsultarDebitos(tstrCodigoPar);
        }

        /// <summary> Genera un vector de 2 posiciones, la primera posición almacena los creditos y la segunta los debitos </summary>
        /// <param name="tstrCodigoPar"> Código del par. </param>
        /// <param name="tdecValor"> Código del valor. </param>
        /// <returns> Un vector con las 2 posiciones indicadas. </returns>
        public List<cuentaValores>[] gmtdCalcularValores(string tstrCodigoPar, decimal tdecValor)
        {
            return new blCuentaPar().gmtdCalcularValores(tstrCodigoPar, tdecValor);
        }
    }
}
