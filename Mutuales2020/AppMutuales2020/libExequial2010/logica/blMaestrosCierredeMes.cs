namespace libMutuales2020.logica
{
    using System;
    using System.ComponentModel;
    using libMutuales2020.dao;

    [DataObject(true)]
    public class blMaestrosCierredeMes
    {
        /// <summary> Consulta si un periodo ya aparece cerrado. </returns>
        /// <param name="tstrPeriodo"> Periodo a consultar. </param>
        /// <returns> Un valor que indica si el periodo existe o no. </returns>
        public bool gmtdConsultarPeriodo(string tstrPeriodo)
        {
            return new daoMaestrosCierredeMes().gmtdConsultarPeriodo(tstrPeriodo);
        }

        /// <summary> Genera cierre de mes </summary>
        /// <param name="tstrAño"> Año del que se va hacer el cierre. </param>
        /// <param name="tstrMes"> Mes del que se va hacer el cierre. </param>
        /// <returns> Un mensaje indicando si se ejecuto o no la operación. </returns>
        public string gmtdCierredeMes(string tstrAño, string tstrMes)
        {
            if (this.gmtdConsultarPeriodo(tstrAño + tstrMes))
                return "- Este periodo ya aparece cerrado";

            int intMes = Convert.ToInt32(tstrMes);
            int intAño = Convert.ToInt32(tstrAño);
            string strPeriodoAnterior = "";
            intMes--;

            if (intMes == 0)
            {
                intAño--;
                intMes = 12;
            }

            string strMes = "";
            if (intMes.ToString().Trim().Length == 1)
                strMes = "0" + intMes.ToString().Trim();
            else
                strMes = intMes.ToString().Trim();

            strPeriodoAnterior = intAño.ToString().Trim() + strMes.Trim();

            return new daoMaestrosCierredeMes().gmtdCierredeMes(intAño.ToString().Trim(), tstrMes, strPeriodoAnterior);
        }
    }
}
