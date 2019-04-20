using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libMutuales2020.dominio
{
    public class metodos
    {
        /// <summary> Crea un objeto del tipo log. </summary>
        /// <param name="tstrMensaje"> Mensaje del log. </param>
        /// <param name="tstrFormulario"> Formulario en el que se genero el log. </param>
        /// <returns> un objeto del tipo log. </returns>
        public static tblLogdeActividade gmtdLog(string tstrMensaje, string tstrFormulario)
        {
            tblLogdeActividade log = new tblLogdeActividade();
            log.dtmFechaEventoLog = DateTime.Now;
            log.strCodigoApp = propiedades.strAplicacion;
            log.strCodigoOpc = tstrFormulario;
            log.strCodigoUsu = propiedades.strCodigoUsuario;
            log.strDescripcionLog = tstrMensaje;
            return log; 
        }

    }
}
