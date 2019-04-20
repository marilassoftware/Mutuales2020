namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fMaestrosOtroIngreso
    {
        /// <summary> Inserta un Otro Ingreso. </summary>
        /// <param name="tobjOtrosIngreso"> Un objeto del tipo otroIngreso. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblOtrosIngreso tobjOtrosIngreso)
        {
            return new blOtroIngreso().gmtdInsertar(tobjOtrosIngreso);
        }

        /// <summary> Modifica un Otro Ingreso. </summary>
        /// <param name="tobjOtrosIngreso"> Un objeto del tipo Otro Ingreso.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblOtrosIngreso tobjOtrosIngreso)
        {
            return new blOtroIngreso().gmtdEditar(tobjOtrosIngreso);
        }

        /// <summary> Consulta todos los otros ingresos registrados. </summary>
        /// <param name="tAplicacion"> Un objeto del tipo otros ingresos. </param>
        /// <returns> Un lista con todos los otros ingresos seleccionados. </returns>
        public IList<otroIngreso> gmtdConsultarTodos()
        {
            return new blOtroIngreso().gmtdConsultarTodos();
        }

        /// <summary> Consulta todos los otros ingresos registrados por nombre. </summary>
        /// <param name="tAplicacion"> Un objeto del tipo otros ingresos. </param>
        /// <returns> Un lista con todos los otros ingresos seleccionados. </returns>
        public IList<otroIngreso> gmtdConsultarTodosxNombre()
        {
            return new blOtroIngreso().gmtdConsultarTodosxNombre();
        }


        /// <summary> Consulta un determinado otro ingreso. </summary>
        /// <param name="tstrCodotro">el código del otro ingreso a consultar.</param>
        /// <returns> un objeto del tipo otro ingreso. </returns>
        public tblOtrosIngreso gmtdConsultar(string tstrCodotro)
        {
            return new blOtroIngreso().gmtdConsultar(tstrCodotro);
        }

        /// <summary> Elimina un otro ingreso de la base de datos. </summary>
        /// <param name="tobjOtrosIngreso"> Un objeto del tipo tblOtrosIngreso. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblOtrosIngreso tobjOtrosIngreso)
        {
            return new blOtroIngreso().gmtdEliminar(tobjOtrosIngreso);
        }

    }
}
