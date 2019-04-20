namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fDeudas
    {
        /// <summary> Inserta una deuda. </summary>
        /// <param name="tobjDeuda"> Un objeto del tipo tblDeuda. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblDeuda tobjDeuda)
        {
            return new blDeudas().gmtdInsertar(tobjDeuda);
        }

        /// <summary> Consulta todos las deudas. </summary>
        /// <returns> Un lista con todos las deudas seleccionadas. </returns>
        public IList<Deuda> gmtdConsultarTodos()
        {
            return new blDeudas().gmtdConsultarTodos();
        }

        /// <summary> Consulta una deuda. </summary>
        /// <param name="tintCodigo"> El código de la deuda que se quiere consultar. </param>
        /// <returns> La deuda consultada. </returns>
        public tblDeuda gmtdConsultar(int tintCodDeuda)
        {
            return new blDeudas().gmtdConsultar(tintCodDeuda);
        }

        /// <summary> Consulta las deudas de un detreminado socio. </summary>
        /// <param name="tintCodigoSoc"> Codigo del socio al que se le van a consultar las deudas. </param>
        /// <returns> Listado de deudas seleciionadas. </returns>
        public List<Deuda> gmtdConsultarDeudasxSocio(string tstrCedula)
        {
            return new blDeudas().gmtdConsultarDeudasxSocio(tstrCedula);
        }

        /// <summary> Elimina una deuda de la base de datos siempre y cuando esta no tenga abonos hechos a ella. </summary>
        /// <param name="tobjDeuda"> Un objeto del tipo tblServiciosSecundario. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblDeuda tobjDeuda)
        {
            return new blDeudas().gmtdEliminar(tobjDeuda);
        }

    }
}
