namespace libMutuales2020.logica
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dao;
    using libMutuales2020.dominio;

    [DataObject(true)]
    public class blMunicipio
    {
        /// <summary> Inserta un municipio. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo municipio. </param>
        /// <returns> un string indicando si se ejecuto o no satisfactoriamente el metodo. </returns>
        public string gmtdInsertar(tblMunicipio tobjMunicipio)
        {
            if (tobjMunicipio.strCodMunicipio == "")
            {
                return "- Debe de ingresar el código del municipio.";
            }

            if (tobjMunicipio.strNomMunicipio == "")
            {
                return "- Debe de ingresar el nombre del municipio.";
            }

            tblMunicipio mcp = new daoMunicipio().gmtdConsultar(tobjMunicipio.strCodMunicipio);

            if (mcp.strCodMunicipio == null)
            {
                tobjMunicipio.log = metodos.gmtdLog("Ingresa el municipio " + tobjMunicipio.strCodMunicipio, tobjMunicipio.strFormulario);
                return new daoMunicipio().gmtdInsertar(tobjMunicipio);
            }
            else
                return "- Este registro ya aparece ingresado.";
        }

        /// <summary> Modifica un municipio. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo municipio.</param>
        /// <returns> Un string indicando si se ejecuto o no el metodo. </returns>
        public string gmtdEditar(tblMunicipio tobjMunicipio)
        {
            if (tobjMunicipio.strCodMunicipio == "")
            {
                return "- Debe de ingresar el código del municipio.";
            }

            if (tobjMunicipio.strNomMunicipio == "")
            {
                return "- Debe de ingresar el nombre del municipio.";
            }

            tblMunicipio mcp = new daoMunicipio().gmtdConsultar(tobjMunicipio.strCodMunicipio);

            if (mcp.strCodMunicipio == null)
                return "- Este registro no aparece ingresado.";
            else
            {
                tobjMunicipio.log = metodos.gmtdLog("Edito el municipio " + tobjMunicipio.strCodMunicipio, tobjMunicipio.strFormulario);
                return new daoMunicipio().gmtdEditar(tobjMunicipio);
            }
        }

        /// <summary> Consulta todos los municipios registrados. </summary>
        /// <param name="tAplicacion"> Un objeto del tipo municipio. </param>
        /// <returns> Un lista con todos los municipios seleccionados. </returns>
        public List<municipio> gmtdConsultarTodos()
        {
            List<municipio> lstMunicipios = new List<municipio>();
            List<municipio> lstLista = new daoMunicipio().gmtdConsultarTodos();

            municipio Muni = new municipio();
            Muni.strCodMunicipio = "0";
            Muni.strNomMunicipio = "";
            lstMunicipios.Add(Muni);

            foreach(municipio Municipio in lstLista)
                lstMunicipios.Add(Municipio);

            return lstMunicipios;
        }

        /// <summary> Elimina un municipio de la base de datos. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo munipio. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblMunicipio tobjMunicipio)
        {
            if (tobjMunicipio.strCodMunicipio == "")
                return "- Debe de ingresar el código del municipio.";

            IList<barrio> lstBarrios = new blBarrio().gmtdConsultarTodos(tobjMunicipio.strCodMunicipio);

            if(lstBarrios.Count > 0)
                return "- No se puede eliminar el municipio por que lo tiene registrado al menos un barrio.";

            tblMunicipio mcp = new daoMunicipio().gmtdConsultar(tobjMunicipio.strCodMunicipio);

            if (mcp.strCodMunicipio == null)
                return "- Este registro no aparece ingresado.";
            else
            {
                tobjMunicipio.log = metodos.gmtdLog("Elimino el municipio " + tobjMunicipio.strCodMunicipio, tobjMunicipio.strFormulario);
                return new daoMunicipio().gmtdEliminar(tobjMunicipio);
            }
        }

    }
}
