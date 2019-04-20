namespace libMutuales2020.logica
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dao;
    using libMutuales2020.dominio;

    [DataObject(true)]
    public class blProvedor
    {
        /// <summary> Inserta un provedor </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo tblProvedor. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblProvedore tobjProvedor)
        {
            if (tobjProvedor.strCodProvedor == "")
                return "- Debe de ingresar el código del provedor.";

            if (tobjProvedor.strConProvedor == "")
                return "- Debe de ingresar el contacto del provedor.";

            if (tobjProvedor.strDirProvedor == "")
                return "- Debe de ingresar la dirección del provedor.";

            if (tobjProvedor.strEmpProvedor == "")
                return "- Debe de ingresar el nombre del provedor.";

            if (tobjProvedor.strMailProvedor == "")
                return "- Debe de ingresar el mail del provedor.";

            if (tobjProvedor.strTelProvedor == "")
                return "- Debe de ingresar el teléfono del provedor.";

            tblProvedore pvd = new daoProvedor().gmtdConsultar(tobjProvedor.strCodProvedor);

            if (pvd.strCodProvedor == null)
            {
                tobjProvedor.log = metodos.gmtdLog("Ingresa el provedor " + tobjProvedor.strCodProvedor, tobjProvedor.strFormulario);
                return new daoProvedor().gmtdInsertar(tobjProvedor);
            }
            else
                return "- Este provedor ya aparece registrado.";
        }

        /// <summary> Modifica un provedor. </summary>
        /// <param name="tobjProvedor"> Un objeto del tipo tblProvedor. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblProvedore tobjProvedor)
        {
            if (tobjProvedor.strCodProvedor == null)
                return "- Debe de ingresar el código del provedor.";

            if (tobjProvedor.strConProvedor == null)
                return "- Debe de ingresar el contacto del provedor.";

            if (tobjProvedor.strDirProvedor == null)
                return "- Debe de ingresar la dirección del provedor.";

            if (tobjProvedor.strEmpProvedor == null)
                return "- Debe de ingresar el nombre del provedor.";

            if (tobjProvedor.strMailProvedor == null)
                return "- Debe de ingresar el mail del provedor.";

            if (tobjProvedor.strTelProvedor == null)
                return "- Debe de ingresar el teléfono del provedor.";

            tblProvedore pvd = new daoProvedor().gmtdConsultar(tobjProvedor.strCodProvedor);

            if (pvd.strCodProvedor == null)
                return "- Este provedor no aparece registrado.";
            else
            {
                tobjProvedor.log = metodos.gmtdLog("Modifica el provedor " + tobjProvedor.strCodProvedor, tobjProvedor.strFormulario);
                return new daoProvedor().gmtdEditar(tobjProvedor);
            }
        }

        /// <summary> Consulta todos los provedores registrados. </summary>
        /// <returns> Un lista con todos los provedores registrados. </returns>
        public IList<provedor> gmtdConsultarTodos()
        {
            return new daoProvedor().gmtdConsultarTodos(); 
        }

        /// <summary> Elimina un provedor. </summary>
        /// <param name="tobjProvedor"> Un objeto del tipo provedor. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblProvedore tobjProvedor)
        {
            if (tobjProvedor.strCodProvedor == null)
                return "- Debe de ingresar el código del provedor a eliminar.";

            tblProvedore pvd = new daoProvedor().gmtdConsultar(tobjProvedor.strCodProvedor);

            if (pvd.strCodProvedor == null)
                return "- Este provedor no aparece registrado.";
            else
            {
                tobjProvedor.log = metodos.gmtdLog("Elimina el provedor " + tobjProvedor.strCodProvedor, tobjProvedor.strFormulario);
                return new daoProvedor().gmtdEliminar(tobjProvedor);
            }
        }
    }
}
