namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fOtroEgreso
    {
        /// <summary> Inserta un Otro Egreso.  </summary>
        /// <param name="tobjOtrosEgreso"> Un objeto del tipo otroEgreso. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblOtrosEgreso tobjOtrosEgreso)
        {
            return new blOtroEgreso().gmtdInsertar(tobjOtrosEgreso);
        }

        /// <summary> Modifica un Otro Egreso. </summary>
        /// <param name="tobjOtrosIngreso"> Un objeto del tipo Otro Egreso.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblOtrosEgreso tobjOtrosEgreso)
        {
            return new blOtroEgreso().gmtdEditar(tobjOtrosEgreso);
        }

        /// <summary>  Consulta todos los otros ingresos registrados. </summary>
        /// <param name="tAplicacion"> Un objeto del tipo otros ingresos. </param>
        /// <returns> Un lista con todos los otros ingresos seleccionados. </returns>
        public IList<otroEgreso> gmtdConsultarTodos()
        {
            return new blOtroEgreso().gmtdConsultarTodos();
        }

        /// <summary>  Consulta todos los otros ingresos registrados. </summary>
        /// <param name="tAplicacion"> Un objeto del tipo otros ingresos. </param>
        /// <returns> Un lista con todos los otros ingresos seleccionados. </returns>
        public IList<otroEgreso> gmtdConsultarTodosxNombre()
        {
            return new blOtroEgreso().gmtdConsultarTodosxNombre();
        }

        /// <summary> Consulta un determinado otro Egreso. </summary>
        /// <param name="tstrCodotro">el código del otro Egreso a consultar.</param>
        /// <returns> un objeto del tipo otro Egreso. </returns>
        public tblOtrosEgreso gmtdConsultar(string tstrCodotro)
        {
            return new blOtroEgreso().gmtdConsultar(tstrCodotro);
        }

        /// <summary> Elimina un otro Egreso de la base de datos. </summary>
        /// <param name="tobjOtrosIngreso"> Un objeto del tipo tblOtrosEgreso. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblOtrosEgreso tobjOtrosIngreso)
        {
            return new blOtroEgreso().gmtdEliminar(tobjOtrosIngreso);
        }
    }
}
