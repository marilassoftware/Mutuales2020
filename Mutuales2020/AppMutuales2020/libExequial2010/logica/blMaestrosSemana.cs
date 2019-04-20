namespace libMutuales2020.logica
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dao;
    using libMutuales2020.dominio;

    [DataObject(true)]
    public class blSemana
    {
        /// <summary> Inserta una semana. </summary>
        /// <param name="tobjSemana"> Un objeto del tipo semana. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblSemana tobjSemana)
        {
            if (tobjSemana.intCodigoSem == 0)
            {
                return "- Debe de ingresar el código de la semana. ";
            }

            if (tobjSemana.dtmFechaSem == null)
            {
                return "- Debe de ingresar la fecha de la semana.";
            }

            tblSemana mcp = new daoSemana().gmtdConsultar(tobjSemana.intCodigoSem.ToString());

            if (mcp.intCodigoSem == 0)
            {
                tblLogdeActividade log = new tblLogdeActividade();
                log.dtmFechaEventoLog = DateTime.Now;
                log.strCodigoApp = propiedades.strAplicacion;
                log.strCodigoOpc = tobjSemana.strFormulario;
                log.strCodigoUsu = propiedades.strCodigoUsuario;
                log.strDescripcionLog = "Ingresa la semana " + tobjSemana.intCodigoSem.ToString();
                tobjSemana.log = log;
                return new daoSemana().gmtdInsertar(tobjSemana);
            }
            else
                return "- Este registro ya aparece ingresado. ";
        }

        /// <summary> Modificar una semana. </summary>
        /// <param name="tobjSemana"> Un objeto del tipo semana. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblSemana tobjSemana)
        {
            if (tobjSemana.intCodigoSem == 0)
                return "- Debe de ingresar el código de la semana. ";

            if (tobjSemana.dtmFechaSem == null)
                return "- Debe de ingresar la fecha de la semana.";

            tblSemana mcp = new daoSemana().gmtdConsultar(tobjSemana.intCodigoSem.ToString());

            if (mcp.intCodigoSem == 0)
                return "- Este registro no aparece ingresado. ";
            else
            {
                tblLogdeActividade log = new tblLogdeActividade();
                log.dtmFechaEventoLog = DateTime.Now;
                log.strCodigoApp = propiedades.strAplicacion;
                log.strCodigoOpc = tobjSemana.strFormulario;
                log.strCodigoUsu = propiedades.strCodigoUsuario;
                log.strDescripcionLog = "Edito la semana " + tobjSemana.intCodigoSem.ToString();
                tobjSemana.log = log;
                return new daoSemana().gmtdEditar(tobjSemana);
            }
        }

        /// <summary> Consulta todas las semanas registradas. </summary>
        /// <returns> Una lista con las semanas registradas. </returns>
        public IList<semana> gmtdConsultarTodos()
        {
            return new daoSemana().gmtdConsultarTodos();
        }

        /// <summary> Elimina una semana. </summary>
        /// <param name="tobjSemana"> Un objeto del tipo semana a eliminar. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public String gmtdEliminar(tblSemana tobjSemana)
        {
            if (tobjSemana.intCodigoSem == 0)
            {
                return "- Debe de ingresar el código de la semana";
            }

            tblSemana mcp = new daoSemana().gmtdConsultar(tobjSemana.intCodigoSem.ToString());

            if (mcp.intCodigoSem == 0)
                return "- Este registro no aparece ingresado.";
            else
            {
                tblLogdeActividade log = new tblLogdeActividade();
                log.dtmFechaEventoLog = DateTime.Now;
                log.strCodigoApp = propiedades.strAplicacion;
                log.strCodigoOpc = tobjSemana.strFormulario;
                log.strCodigoUsu = propiedades.strCodigoUsuario;
                log.strDescripcionLog = "Elimino la semana. " + tobjSemana.intCodigoSem.ToString();
                tobjSemana.log = log;
                return new daoSemana().gmtdEliminar(tobjSemana);
            }
        }

        /// <summary> Consulta las semanas registradas de un año. </summary>
        /// <param name="tintAño"> Año del que se quiere conocer las semanas. </param>
        /// <returns></returns>
        public List<tblSemana> gmtdConsultarSemanasxAño(int tintAño)
        {
            return new daoSemana().gmtdConsultarSemanasxAño(tintAño);
        }

        /// <summary> Consulta las semanas registradas de un año. </summary>
        /// <param name="tintAño"> Año del que se quiere conocer las semanas. </param>
        /// <returns></returns>
        public List<tblSemana> gmtdConsultarSemanasxAñoxTipo(int tintAño, string tstrTipo)
        {
            return new daoSemana().gmtdConsultarSemanasxAñoxTipo(tintAño, tstrTipo);
        }
    }
}
