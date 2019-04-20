namespace libMutuales2020.Facade
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using libMutuales2020.dominio;
    using libMutuales2020.logica;

    [DataObject(true)]
    public class fCreditos
    {
        #region InsertarCreditos

        /// <summary> Inserta un credito. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo credito. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblCredito tobjCredito)
        {
            return new blCreditos().gmtdInsertar(tobjCredito);
        }

        /// <summary> Calcula el valor de cada cuota de un credito. </summary>
        /// <param name="tobjCredito"> Un objeto del tipo crédito. </param>
        /// <returns> El valor de cada cuota. </returns>
        public double gmtCalcularValordeCuota(tblCredito tobjCredito)
        {
            return new blCreditos().gmtCalcularValordeCuota(tobjCredito);
        }

        #endregion

        /// <summary> Consulta un determinado credito. </summary>
        /// <param name="tstrCodMunicipio">el código del credito consultar.</param>
        /// <returns> un objeto del tipo tblCredito. </returns>
        public tblCredito gmtdConsultar(int tintCodCredito)
        {
            return new blCreditos().gmtdConsultar(tintCodCredito);
        }

        /// <summary> Consulta un determinado credito por el número de cédula del deudor. </summary>
        /// <param name="tstrCedula">Cédula para consultar el cédito.</param>
        /// <returns> un objeto del tipo tblCredito. </returns>
        public tblCredito gmtdConsultar(string tstrCedula)
        {
            return new blCreditos().gmtdConsultar(tstrCedula);
        }

        /// <summary> Calcula el còdigo de crèdito que se va a generar. </summary>
        /// <returns> El còdigo del credito que se debe de generar. </returns>
        public int gmtdConsultarCodigodeCredito()
        {
            return new blCreditos().gmtdConsultarCodigodeCredito();
        }


        /// <summary> Consulta el valor y código del crédito egistrados a una persona. </summary>
        /// <param name="tstrCedulaCredito">El número de la cédula de la persona a la que se le van a consultar los créditos. </param>
        /// <returns> Una lista con los creditos seleccuinados. </returns>
        public List<creditoss> gmtdConsultarCreditosxPersona(string tstrCedulaCredito)
        {
            return new blCreditos().gmtdConsultarCreditosxPersona(tstrCedulaCredito);
        }

        /// <summary> Consulta los códigos de los creditos registrados a una persona </summary>
        /// <param name="tstrCedulaCredito"> Cedula de la persona a la que se le van a consultar los creditos. </param>
        /// <returns> Una lista con los creditos. </returns>
        public List<tblCredito> gmtdConsultaCreditosParaRecibo(string tstrCedulaCredito)
        {
            return new blCreditos().gmtdConsultaCreditosParaRecibo(tstrCedulaCredito);
        }

        /// <summary> Consulta el monto de un crédito. </summary>
        /// <param name="tintPrestamo"> Código del crédito a consultar. </param>
        /// <returns> El monto de un crédito. </returns>
        public decimal gmtdConsultarMonto(int tintPrestamo)
        {
            return new blCreditos().gmtdConsultarMonto(tintPrestamo);
        }

        /// <summary> Consulta si un prestamo tiene o no cuotas pagas. </summary>
        /// <param name="tintCredito"> Código del crédito a consultarle las cuotas. </param>
        /// <returns> Un valor que indica si el credito tiene o no cuotas pagas. </returns>
        public bool gmtdSabersihaycuotaspagadasdeuncredito(int tintCredito)
        {
            return new blCreditos().gmtdSabersihaycuotaspagadasdeuncredito(tintCredito);
        }

        /// <summary> Consulta lo intereses causados de un credito. </summary>
        /// <param name="tintCredito"> Código del credito. </param>
        /// <returns> Un valor que indica lo causado del crédito. </returns>
        public decimal gmtdConsultaInteresCausadoporCredito(int tintCredito)
        {
            return new blCreditos().gmtdConsultaInteresCausadoporCredito(tintCredito);
        }

        /// <summary> Consulta las cuotas pendientes de un credito. </summary>
        /// <param name="tintCredito">Código del credito a consultar</param>
        /// <returns> Una lista con las cuotas. </returns>
        public List<tblCreditosCuota> gmtdConsultarCuotasPendientesdeunCredito(int tintCredito)
        {
            return new blCreditos().gmtdConsultarCuotasPendientesdeunCredito(tintCredito);
        }

        /// <summary> Calcula las cuotas a cancelar en un recibo. </summary>
        /// <param name="tintCredito"> Codigo del crésdito al que se le van a pagar las cuotas. </param>
        /// <param name="tintCuotas"> Numero de cuotas a cancelar. </param>
        /// <returns> Listado de cuotas procesadas. </returns>
        public List<recibosIngresosPrestamos> gmtdCalcularValordeCuotas(int tintCredito, int tintCuotas)
        {
            return new blCreditos().gmtdCalcularValordeCuotas(tintCredito, tintCuotas);
        }

        /// <summary> Elimina un de credito de la base de datos. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo credito. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblCredito tobjCredito)
        {
            return new blCreditos().gmtdEliminar(tobjCredito);
        }
    }
}
