namespace libMutuales2020.logica
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dao;
    using libMutuales2020.dominio;

    [DataObject(true)]
    public class blOficio
    {
        /// <summary> Inserta un oficio. </summary>
        /// <param name="tobjOficio"> Un objeto del tipo oficio. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblOficio tobjOficio)
        {
            if (tobjOficio.strCodOficio == "")
            {
                return "- Debe de ingresar el código del oficio. ";
            }

            if (tobjOficio.strNomOficio == "")
            {
                return "- Debe de ingresar el nombre del oficio.";
            }

            tblOficio mcp = new daoOficio().gmtdConsultar(tobjOficio.strCodOficio);

            if (mcp.strCodOficio == null)
            {
                tobjOficio.log = metodos.gmtdLog("Ingresa el oficio " + tobjOficio.strCodOficio, tobjOficio.strFormulario);
                return new daoOficio().gmtdInsertar(tobjOficio);
            }
            else
                return "- Este registro ya aparece ingresado. ";
        }

        /// <summary> Modifica el nombre de un oficio. </summary>
        /// <param name="tobjOficio"> Un objeto del tipo Oficio. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblOficio tobjOficio)
        {
            if (tobjOficio.strCodOficio == "")
            {
                return "- Debe de ingresar el código del oficio. ";
            }

            if (tobjOficio.strNomOficio == "")
            {
                return "- Debe de ingresar el nombre del oficio.";
            }

            tblOficio mcp = new daoOficio().gmtdConsultar(tobjOficio.strCodOficio);

            if (mcp.strCodOficio == null)
                return "- Este registro no aparece ingresado. ";
            else
            {
                tblLogdeActividade log = new tblLogdeActividade();
                log.dtmFechaEventoLog = DateTime.Now;
                log.strCodigoApp = propiedades.strAplicacion;
                log.strCodigoOpc = tobjOficio.strFormulario;
                log.strCodigoUsu = propiedades.strCodigoUsuario;
                log.strDescripcionLog = "Edito el municipio " + tobjOficio.strCodOficio;
                tobjOficio.log = log;
                return new daoOficio().gmtdEditar(tobjOficio);
            }
        }

        /// <summary> Consulta todos los oficios registrados. </summary>
        /// <returns> Un lista con los oficios registrados. </returns>
        public IList<oficio> gmtdConsultarTodos()
        {
            return new daoOficio().gmtdConsultarTodos();
        }

        /// <summary> Elimina un oficio. </summary>
        /// <param name="tobjOficio"> Un objeto del tipo oficio que se va a eliminar. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public String gmtdEliminar(tblOficio tobjOficio)
        {
            if (tobjOficio.strCodOficio == "")
            {
                return "- Debe de ingresar el código del oficio.";
            }

            tblOficio mcp = new daoOficio().gmtdConsultar(tobjOficio.strCodOficio);

            if (mcp.strCodOficio == null)
                return "- Este registro no aparece ingresado.";
            else
            {
                tblLogdeActividade log = new tblLogdeActividade();
                log.dtmFechaEventoLog = DateTime.Now;
                log.strCodigoApp = propiedades.strAplicacion;
                log.strCodigoOpc = tobjOficio.strFormulario;
                log.strCodigoUsu = propiedades.strCodigoUsuario;
                log.strDescripcionLog = "Elimino el oficio. " + tobjOficio.strCodOficio;
                tobjOficio.log = log;
                return new daoOficio().gmtdEliminar(tobjOficio);
            }
        }

    }
}
