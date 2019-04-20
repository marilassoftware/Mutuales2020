namespace libMutuales2020.logica
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dao;
    using libMutuales2020.dominio;

    [DataObject(true)]
    public class blBarrio
    {
        /// <summary> Inserta un barrio. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo barrio. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblBarrio tobjBarrio)
        {
            if (tobjBarrio.strCodBarrio == "")
                return "- Debe de ingresar el código del barrio.";

            if (tobjBarrio.strNomBarrio == "")
                return "- Debe de ingresar el nombre del barrio.";

            if (tobjBarrio.strCodMunicipio.Trim() == "" || tobjBarrio.strCodMunicipio.Trim() == "0")
                return "- Debe de ingresar el código el municipio.";

            tblBarrio bar = new daoBarrio().gmtdConsultar(tobjBarrio.strCodBarrio);

            if (bar.strCodBarrio == null)
            {
                tobjBarrio.log = metodos.gmtdLog("Ingresa el barrio " + tobjBarrio.strCodBarrio, tobjBarrio.strFormulario);
                return new daoBarrio().gmtdInsertar(tobjBarrio);
            }
            else
                return "- Este registro ya aparece ingresado.";
        }

        /// <summary> Modifica un barrio. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo barrio.</param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblBarrio tobjBarrio)
        {
            if (tobjBarrio.strCodBarrio == "")
            {
                return "- Debe de ingresar el código del barrio.";
            }

            if (tobjBarrio.strNomBarrio == "")
            {
                return "- Debe de ingresar el nombre del barrio.";
            }

            if (tobjBarrio.strCodMunicipio.Trim() == "" || tobjBarrio.strCodMunicipio.Trim() == "0")
                return "- Debe de ingresar el código el municipio.";


            tblBarrio bar = new daoBarrio().gmtdConsultar(tobjBarrio.strCodBarrio);

            if (bar.strCodBarrio == null)
                return "- Este registro no aparece ingresado.";
            else
            {
                tobjBarrio.log = metodos.gmtdLog("Edito el barrio " + tobjBarrio.strCodBarrio, tobjBarrio.strFormulario);
                return new daoBarrio().gmtdEditar(tobjBarrio);
            }
        }

        /// <summary> Consulta todos los barrios registrados. </summary>
        /// <param name="tAplicacion"> Un objeto del tipo barrio. </param>
        /// <returns> Un lista con todos los municipios seleccionados. </returns>
        public IList<barrio> gmtdConsultarTodos(string tstrCodMunicipio)
        {
            return new daoBarrio().gmtdConsultarTodos(tstrCodMunicipio);
        }

        /// <summary> Consulta todos los barrios registrados. </summary>
        /// <returns> Un lista con todos los barrios seleccionados. </returns>
        public IList<barrio> gmtdConsultarTodos()
        {
            return new daoBarrio().gmtdConsultarTodos();
        }

        /// <summary> Consulta todos los barrios registrados. </summary>
        /// <returns> Un lista con todos los barrios seleccionados. </returns>
        public IList<barrio> gmtdConsultarBarriosconMunicipios()
        {
            return new daoBarrio().gmtdConsultarBarriosconMunicipios();
        }

        /// <summary> Seleccionar todos los barrios registrados. </summary>
        /// <returns> Un lista con los barrios registrados. </returns>
        public IList<tblBarrio> gmtdConsultar()
        {
            return new daoBarrio().gmtdConsultar(); 
        }

        /// <summary> Elimina un barrio de la base de datos. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo tblBarrio. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblBarrio tobjBarrio)
        {
            if (tobjBarrio.strCodBarrio == "")
                return "- Debe de ingresar el código del barrio.";

            List<tblAgraciado> lstAgraciados = new blAgraciado().gmtdConsultarAgraciadosxBarrio(tobjBarrio.strCodBarrio);
            if (lstAgraciados.Count > 0)
                return "- Este barrio no se puede eliminar por que lo tiene registrado al menos un agraciado.";

            List<tblAhorradore> lstAhorradores = new blAhorrador().gmtdConsultarAhorradoresxBarrio(tobjBarrio.strCodBarrio);
            if (lstAhorradores.Count > 0)
                return "- Este barrio no se puede eliminar por que lo tiene registrado al menos un ahorrador.";

            List<tblSocio> lstSocios = new blSocio().gmtdConsultarSociosxBarrio(tobjBarrio.strCodBarrio);
            if (lstSocios.Count > 0)
                return "- Este barrio no se puede eliminar por que lo tiene registrado al menos un socio.";

            tblBarrio bar = new daoBarrio().gmtdConsultar(tobjBarrio.strCodBarrio);

            if (bar.strCodBarrio == null)
                return "- Este registro no aparece ingresado.";
            else
            {
                tobjBarrio.log = metodos.gmtdLog("Elimino el barrio " + tobjBarrio.strCodBarrio, tobjBarrio.strFormulario);
                return new daoBarrio().gmtdEliminar(tobjBarrio);
            }
        }

    }
}
