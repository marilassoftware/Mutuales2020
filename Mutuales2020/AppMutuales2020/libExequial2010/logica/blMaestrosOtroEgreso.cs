namespace libMutuales2020.logica
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using libMutuales2020.dao;
    using libMutuales2020.dominio;

    [DataObject(true)]
    public class blOtroEgreso
    {
        /// <summary> Inserta un Otro Egreso.  </summary>
        /// <param name="tobjOtrosEgreso"> Un objeto del tipo otroEgreso. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblOtrosEgreso tobjOtrosEgreso)
        {
            if (tobjOtrosEgreso.strCodigoPar.Trim() == "")
                return "- Debe de seleccionar un par Valido";

            if (tobjOtrosEgreso.strCodOtrosEgresos.Trim() == "")
                return "- Debe de ingresar el código del Egreso";

            if (tobjOtrosEgreso.strNomOtrosEgresos.Trim() == "")
                return "- Debe de ingresar la descripción del Egreso";

            tblOtrosEgreso otro = new daoOtroEgreso().gmtdConsultar(tobjOtrosEgreso.strCodOtrosEgresos);

            if (otro.strCodOtrosEgresos == null)
            {
                tobjOtrosEgreso.log = metodos.gmtdLog("Ingresa el otro Egreso " + tobjOtrosEgreso.strCodOtrosEgresos, tobjOtrosEgreso.strFormulario);
                return new daoOtroEgreso().gmtdInsertar(tobjOtrosEgreso);
            }
            else
                return "- Este registro ya aparece ingresado.";
        }

        /// <summary> Modifica un Otro Egreso. </summary>
        /// <param name="tobjOtrosIngreso"> Un objeto del tipo Otro Egreso.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblOtrosEgreso tobjOtrosEgreso)
        {
            if (tobjOtrosEgreso.strCodigoPar.Trim() == "")
                return "- Debe de seleccionar un par Valido";

            if (tobjOtrosEgreso.strCodOtrosEgresos.Trim() == "")
                return "- Debe de ingresar el código del Egreso";

            if (tobjOtrosEgreso.strNomOtrosEgresos.Trim() == "")
                return "- Debe de ingresar la descripción del Egreso";

            tblOtrosEgreso otro = new daoOtroEgreso().gmtdConsultar(tobjOtrosEgreso.strCodOtrosEgresos);

            if (otro.strCodOtrosEgresos == null)
                return "- Este registro no aparece ingresado.";
            else
            {
                tobjOtrosEgreso.log = metodos.gmtdLog("Modifica el otro Egreso " + tobjOtrosEgreso.strCodOtrosEgresos, tobjOtrosEgreso.strFormulario);
                return new daoOtroEgreso().gmtdEditar(tobjOtrosEgreso);
            }
        }

        /// <summary>  Consulta todos los otros ingresos registrados. </summary>
        /// <param name="tAplicacion"> Un objeto del tipo otros ingresos. </param>
        /// <returns> Un lista con todos los otros ingresos seleccionados. </returns>
        public IList<otroEgreso> gmtdConsultarTodos()
        {
            return new daoOtroEgreso().gmtdConsultarTodos();  
        }

        /// <summary>  Consulta todos los otros ingresos registrados. </summary>
        /// <param name="tAplicacion"> Un objeto del tipo otros ingresos. </param>
        /// <returns> Un lista con todos los otros ingresos seleccionados. </returns>
        public IList<otroEgreso> gmtdConsultarTodosxNombre()
        {
            IList<otroEgreso> lstOtrosEgresos = new daoOtroEgreso().gmtdConsultarTodos();

            var query = from consu in lstOtrosEgresos
                        orderby consu.strNomOtrosEgresos
                        select consu;

            return query.ToList();
        }

        /// <summary> Consulta un determinado otro Egreso. </summary>
        /// <param name="tstrCodotro">el código del otro Egreso a consultar.</param>
        /// <returns> un objeto del tipo otro Egreso. </returns>
        public tblOtrosEgreso gmtdConsultar(string tstrCodotro)
        {
            return new daoOtroEgreso().gmtdConsultar(tstrCodotro);
        }

        /// <summary> Elimina un otro Egreso de la base de datos. </summary>
        /// <param name="tobjOtrosIngreso"> Un objeto del tipo tblOtrosEgreso. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblOtrosEgreso tobjOtrosIngreso)
        {
            if (tobjOtrosIngreso.strCodOtrosEgresos.Trim() == "")
                return "- Debe de ingresar el código del Egreso";

            tblOtrosEgreso otro = new daoOtroEgreso().gmtdConsultar(tobjOtrosIngreso.strCodOtrosEgresos);

            if (otro.strCodOtrosEgresos == null)
                return "- Este registro no aparece ingresado.";
            else
            {
                tobjOtrosIngreso.log = metodos.gmtdLog("Elimina el otro Egreso " + tobjOtrosIngreso.strCodOtrosEgresos, tobjOtrosIngreso.strFormulario);
                return new daoOtroEgreso().gmtdEliminar(tobjOtrosIngreso);
            }
        }
    }
}
