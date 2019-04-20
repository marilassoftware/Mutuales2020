namespace libMutuales2020.logica
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using libMutuales2020.dao;
    using libMutuales2020.dominio;

    [DataObject(true)]
    public class blOtroIngreso
    {
        /// <summary> Inserta un Otro Ingreso. </summary>
        /// <param name="tobjOtrosIngreso"> Un objeto del tipo otroIngreso. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblOtrosIngreso tobjOtrosIngreso)
        {
            if (tobjOtrosIngreso.strCodigoPar.Trim() == "")
                return "- Debe de seleccionar un par Valido";

            if (tobjOtrosIngreso.strCodOtrosIngresos.Trim() == "")
                return "- Debe de ingresar el código del ingreso";

            if (tobjOtrosIngreso.strNomOtrosIngresos.Trim() == "")
                return "- Debe de ingresar la descripción del ingreso";

            tblOtrosIngreso otro = new daoOtroIngreso().gmtdConsultar(tobjOtrosIngreso.strCodOtrosIngresos);

            if (otro.strCodOtrosIngresos == null)
            {
                tobjOtrosIngreso.log = metodos.gmtdLog("Ingresa el otro ingreso " + tobjOtrosIngreso.strCodOtrosIngresos, tobjOtrosIngreso.strFormulario);
                return new daoOtroIngreso().gmtdInsertar(tobjOtrosIngreso);
            }
            else
                return "- Este registro ya aparece ingresado.";
        }

        /// <summary> Modifica un Otro Ingreso. </summary>
        /// <param name="tobjOtrosIngreso"> Un objeto del tipo Otro Ingreso.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblOtrosIngreso tobjOtrosIngreso)
        {
            if (tobjOtrosIngreso.strCodigoPar.Trim() == "")
                return "- Debe de seleccionar un par Valido";

            if (tobjOtrosIngreso.strCodOtrosIngresos.Trim() == "")
                return "- Debe de ingresar el código del ingreso";

            if (tobjOtrosIngreso.strNomOtrosIngresos.Trim() == "")
                return "- Debe de ingresar la descripción del ingreso";

            tblOtrosIngreso otro = new daoOtroIngreso().gmtdConsultar(tobjOtrosIngreso.strCodOtrosIngresos);

            if (otro.strCodOtrosIngresos == null)
                return "- Este registro no aparece ingresado.";
            else
            {
                tobjOtrosIngreso.log = metodos.gmtdLog("Modifica el otro ingreso " + tobjOtrosIngreso.strCodOtrosIngresos, tobjOtrosIngreso.strFormulario);
                return new daoOtroIngreso().gmtdEditar(tobjOtrosIngreso);
            }
        }

        /// <summary> Consulta todos los otros ingresos registrados. </summary>
        /// <param name="tAplicacion"> Un objeto del tipo otros ingresos. </param>
        /// <returns> Un lista con todos los otros ingresos seleccionados. </returns>
        public IList<otroIngreso> gmtdConsultarTodos()
        {
            return new daoOtroIngreso().gmtdConsultarTodos();  
        }

        /// <summary> Consulta todos los otros ingresos registrados por nombre. </summary>
        /// <param name="tAplicacion"> Un objeto del tipo otros ingresos. </param>
        /// <returns> Un lista con todos los otros ingresos seleccionados. </returns>
        public IList<otroIngreso> gmtdConsultarTodosxNombre()
        {
            IList<otroIngreso> lstOtrosIngresos = new daoOtroIngreso().gmtdConsultarTodos();

            var query = from consu in lstOtrosIngresos
                        orderby consu.strNomOtrosIngresos
                        select consu;

            return query.ToList();
        }


        /// <summary> Consulta un determinado otro ingreso. </summary>
        /// <param name="tstrCodotro">el código del otro ingreso a consultar.</param>
        /// <returns> un objeto del tipo otro ingreso. </returns>
        public tblOtrosIngreso gmtdConsultar(string tstrCodotro)
        {
            return new daoOtroIngreso().gmtdConsultar(tstrCodotro);
        }

        /// <summary> Elimina un otro ingreso de la base de datos. </summary>
        /// <param name="tobjOtrosIngreso"> Un objeto del tipo tblOtrosIngreso. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblOtrosIngreso tobjOtrosIngreso)
        {
            if (tobjOtrosIngreso.strCodOtrosIngresos.Trim() == "")
                return "- Debe de ingresar el código del ingreso";

            tblOtrosIngreso otro = new daoOtroIngreso().gmtdConsultar(tobjOtrosIngreso.strCodOtrosIngresos);

            if (otro.strCodOtrosIngresos == null)
                return "- Este registro no aparece ingresado.";
            else
            {
                tobjOtrosIngreso.log = metodos.gmtdLog("Elimina el otro ingreso " + tobjOtrosIngreso.strCodOtrosIngresos, tobjOtrosIngreso.strFormulario);
                return new daoOtroIngreso().gmtdEliminar(tobjOtrosIngreso);
            }
        }

    }
}
