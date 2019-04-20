namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fMaestrosSemana
    {
        /// <summary> Inserta una semana. </summary>
        /// <param name="tobjSemana"> Un objeto del tipo semana. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblSemana tobjSemana)
        {
            return new blSemana().gmtdInsertar(tobjSemana);
        }

        /// <summary> Modificar una semana. </summary>
        /// <param name="tobjSemana"> Un objeto del tipo semana. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblSemana tobjSemana)
        {
            return new blSemana().gmtdEditar(tobjSemana);
        }

        /// <summary> Consulta todas las semanas registradas. </summary>
        /// <returns> Una lista con las semanas registradas. </returns>
        public IList<semana> gmtdConsultarTodos()
        {
            return new blSemana().gmtdConsultarTodos();
        }

        /// <summary> Elimina una semana. </summary>
        /// <param name="tobjSemana"> Un objeto del tipo semana a eliminar. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public String gmtdEliminar(tblSemana tobjSemana)
        {
            return new blSemana().gmtdEliminar(tobjSemana);
        }

        /// <summary> Consulta las semanas registradas de un año. </summary>
        /// <param name="tintAño"> Año del que se quiere conocer las semanas. </param>
        /// <returns></returns>
        public List<tblSemana> gmtdConsultarSemanasxAño(int tintAño)
        {
            return new blSemana().gmtdConsultarSemanasxAño(tintAño);
        }
    }
}
