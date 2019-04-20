namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fOficio
    {
        /// <summary> Inserta un oficio. </summary>
        /// <param name="tobjOficio"> Un objeto del tipo oficio. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblOficio tobjOficio)
        {
            return new blOficio().gmtdInsertar(tobjOficio);
        }

        /// <summary> Modifica el nombre de un oficio. </summary>
        /// <param name="tobjOficio"> Un objeto del tipo Oficio. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdEditar(tblOficio tobjOficio)
        {
            return new blOficio().gmtdEditar(tobjOficio);
        }

        /// <summary> Consulta todos los oficios registrados. </summary>
        /// <returns> Un lista con los oficios registrados. </returns>
        public IList<oficio> gmtdConsultarTodos()
        {
            return new blOficio().gmtdConsultarTodos();
        }

        /// <summary> Elimina un oficio. </summary>
        /// <param name="tobjOficio"> Un objeto del tipo oficio que se va a eliminar. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public String gmtdEliminar(tblOficio tobjOficio)
        {
            return new blOficio().gmtdEditar(tobjOficio);
        }
    }
}
