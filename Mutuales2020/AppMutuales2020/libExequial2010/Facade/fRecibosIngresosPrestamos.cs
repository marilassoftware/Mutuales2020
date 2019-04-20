namespace libMutuales2020.Facade
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fRecibosIngresosPrestamos
    {
        /// <summary> Consulta los códigos de los creditos registrados a una persona </summary>
        /// <param name="tstrCedulaCredito"> Cedula de la persona a la que se le van a consultar los creditos. </param>
        /// <returns> Una lista con los creditos. </returns>
        public List<tblCredito> gmtdConsultaCreditosParaRecibo(string tstrCedulaCredito)
        {
            return new blRecibosIngresosPrestamos().gmtdConsultaCreditosParaRecibo(tstrCedulaCredito);
        }

        /// <summary> Consulta las cuotas pendientes de un credito. </summary>
        /// <param name="tintCredito">Código del credito a consultar</param>
        /// <returns> Una lista con las cuotas. </returns>
        public List<tblCreditosCuota> gmtdConsultarCuotasPendientesdeunCredito(int tintCredito)
        {
            return new blRecibosIngresosPrestamos().gmtdConsultarCuotasPendientesdeunCredito(tintCredito);
        }

        /// <summary> Devuelve el número de cuotas pendientes de un determinado credito. </summary>
        /// <param name="tintPrestamo"> Código del credito. </param>
        /// <returns> Numero de cuotas pendientes del credito. </returns>
        public int gmtdConsultaNumerodeCuotasPendientesdeunCredito(int tintPrestamo)
        {
            return new blRecibosIngresosPrestamos().gmtdConsultarCuotasPendientesdeunCredito(tintPrestamo).Count;
        }


    }
}
