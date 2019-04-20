namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fAhorrosCdt
    {
        /// <summary> Inserta un cdt. </summary>
        /// <param name="tobjAhorroaFuturo"> Un objeto del tipo ahorro cdt. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblAhorrosCdt tobjAhorroCdt)
        {
            return new blAhorrosCdt().gmtdInsertar(tobjAhorroCdt);
        }

        /// <summary> Consulta todos los cdt-s registrados. </summary>
        /// <returns> Un lista con todos los cdt-s seleccionados. </returns>
        public IList<ahorrosCdt> gmtdConsultarTodos()
        {
            return new blAhorrosCdt().gmtdConsultarTodos();
        }

        /// <summary> Consulta un cdt registrado. </summary>
        /// <returns> Un cdt. </returns>
        public ahorrosCdt gmtdConsultar(int tintCdt)
        {
            return new blAhorrosCdt().gmtdConsultar(tintCdt);
        }

        /// <summary> Consulta un determiando Cdt. </summary>
        /// <param name="tintCdt"> Codigo del cdt a consultar. </param>
        /// <returns> Un objeto del tipo tblAhorrosCdt con el cdt consultado. </returns>
        public tblAhorrosCdt gmtdConsultarCdt(int tintCdt)
        {
            return new blAhorrosCdt().gmtdConsultarCdt(tintCdt);
        }


        /// <summary> Elimina un cdt. </summary>
        /// <param name="tobjAhorrosaFuturo"> Un objeto del tipo tblAhorrosCdt. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblAhorrosCdt tobjAhorrosCdt)
        {
            return new blAhorrosCdt().gmtdEliminar(tobjAhorrosCdt);
        }
    }
}
