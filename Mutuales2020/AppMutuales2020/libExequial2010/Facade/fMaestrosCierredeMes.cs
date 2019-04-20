namespace libMutuales2020.Facade
{
    using System.ComponentModel;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fMaestrosCierredeMes
    {
        /// <summary> Consulta si un periodo ya aparece cerrado. </returns>
        /// <param name="tstrPeriodo"> Periodo a consultar. </param>
        /// <returns> Un valor que indica si el periodo existe o no. </returns>
        public bool gmtdConsultarPeriodo(string tstrPeriodo)
        {
            return new blMaestrosCierredeMes().gmtdConsultarPeriodo(tstrPeriodo);
        }

        /// <summary> Genera cierre de mes </summary>
        /// <param name="tstrAño"> Año del que se va hacer el cierre. </param>
        /// <param name="tstrMes"> Mes del que se va hacer el cierre. </param>
        /// <returns> Un mensaje indicando si se ejecuto o no la operación. </returns>
        public string gmtdCierredeMes(string tstrAño, string tstrMes)
        {
            return new blMaestrosCierredeMes().gmtdCierredeMes(tstrAño, tstrMes);
        }
    }
}
