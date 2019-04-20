using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using libMutuales2020.dominio;
using libMutuales2020.dao;

namespace libMutuales2020.logica
{
    [DataObject(true)]
    public class blCreditos
    {
        List<DateTime> lstFechas;

        #region InsertarCreditos

        /// <summary> Inserta un credito. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo credito. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblCredito tobjCredito)
        {
            if (tobjCredito.intCodigoCre == 0)
                return "- Debe de ingresar el código del crédito.";

            if (tobjCredito.strNombrePre == "" || tobjCredito.strNombrePre == null)
                return "- Debe de ingresar el primer apellido.";

            if (tobjCredito.strApellido1Pre == "" || tobjCredito.strApellido1Pre == null)
                return "- Debe de ingresar el primer apellido.";

            if (tobjCredito.intPagarePre == 0)
                return "- Debe de ingresar el número del pagaré.";

            if (tobjCredito.decIntereses == 0)
                return "- Debe de ingresar el porcentaje de interes del crédito.";

            if (tobjCredito.decMonto == 0)
                return "- Debe de ingresar el monto del credito.";

            if (tobjCredito.intCuotas == 0)
                return "- Debe de ingresar el número de cuotas del crédito.";

            tobjCredito.decDebe = tobjCredito.decMonto;
            tobjCredito.decAbono = 0;
            tobjCredito.dtmFechaPre = new daoUtilidadesConfiguracion().gmtdCapturarFechadelServidor();

            switch (tobjCredito.intTipoGarantia)
            {
                case 1:
                    if (tobjCredito.strApellidoCde == "" || tobjCredito.strApellidoCde == null)
                        return "- Debe de ingresar el apellido del codeudor";

                    if (tobjCredito.strNombreCde == "" || tobjCredito.strNombreCde == null)
                        return "- Debe de ingresar el nombre del codeudor";

                    if (tobjCredito.strCedulaCde == "" || tobjCredito.strCedulaCde == null)
                        return "- Debe de ingresar la cédula del codeudor";
                    break;
                case 2:
                    if (tobjCredito.decAhorrado == 0)
                        return "- Debe de ingresar valor del ahorro para respaldar el credito";
                    break;
                case 3:
                    if (tobjCredito.strDescripcionGarantiadelCredito == null || tobjCredito.strDescripcionGarantiadelCredito == "")
                        return "- Debe de ingresar la descripción de la garantia del credito";
                    break;
            }

            if (tobjCredito.strCedulaPre == "" || tobjCredito.strCedulaPre == null)
                return "- Debe de ingresar la cédula del deudor.";

            if (tobjCredito.strCodigoPar == "" || tobjCredito.strCodigoPar == null)
                return "- Debe de seleccionar el par.";

            if (tobjCredito.strCodLineadeCredito == "" || tobjCredito.strCodLineadeCredito == null)
                return "- Debe de seleccionar la linea de crédito.";

            if (tobjCredito.strDireccion == "" || tobjCredito.strDireccion == null)
                return "- Debe de ingresar la dirección.";

            if (tobjCredito.strFormadeCobroPre == "" || tobjCredito.strFormadeCobroPre == null)
                return "- Debe de seleccionar la forma de cobro del crédito. ";

            if (tobjCredito.strFrecuenciaPre == "" || tobjCredito.strFrecuenciaPre == null)
                return "- Debe de seleccionar la frecuencia del rédito. ";

            if (tobjCredito.strTelefono == "" || tobjCredito.strTelefono == null)
                return "- Debe de escribir el teléfono del deudor. ";

            tblCredito cre = new daoCreditos().gmtdConsultar(tobjCredito.intCodigoCre);

            if (cre.strNombrePre == null)
            {
                tobjCredito.bitAnulado = false;
                tobjCredito.dtmFechaAnu = Convert.ToDateTime("1/1/1900");
                tobjCredito.log = metodos.gmtdLog("Ingresa el crédito " + tobjCredito.intCodigoCre.ToString(), tobjCredito.strFormulario);

                double dblValorCuota = this.gmtCalcularValordeCuota(tobjCredito);
                
                List<tblCreditosCuota> lstCuotas = new List<tblCreditosCuota>();
                pGenerarFechasdeCuotasAutomaticamente(tobjCredito);
                try
                {
                    decimal decMonto = tobjCredito.decMonto;
                    for (int a = 1; a <= tobjCredito.intCuotas; a++)
                    {
                        double dblIntereses = Convert.ToDouble(tobjCredito.decIntereses) / 100;
                        dblIntereses = Convert.ToDouble(decMonto) * dblIntereses;
                        double dblCapital = dblValorCuota - dblIntereses;
                        tblCreditosCuota cuota = new tblCreditosCuota();
                        cuota.bitPagada = false;
                        cuota.decCapital = (decimal)dblCapital;
                        cuota.decIntereses = (decimal)dblIntereses;
                        cuota.decSaldoCapital = decMonto;
                        cuota.decValorCuo = (decimal)dblValorCuota;
                        cuota.dtmFechaCuo = lstFechas[a - 1];
                        cuota.intCodigoCre = tobjCredito.intCodigoCre;
                        cuota.intCuota = a;
                        cuota.strDatosdePago = "No Pagada";
                        cuota.dtmFechaPago = Convert.ToDateTime("1/1/1900");
                        tobjCredito.tblCreditosCuotas.Add(cuota);
                        decMonto = decMonto - Convert.ToInt32(dblCapital);
                    }
                }
                catch (Exception ex)
                {
                    new dao.dao().gmtdInsertarError(ex);
                    return "- Hubo un error calculando las cuotas y el sistema no puede continuar.";
                }

                return new daoCreditos().gmtdInsertar(tobjCredito);
            }
            else
                return "- Este registro ya aparece ingresado.";
        }

        /// <summary> Calcula el valor de cada cuota de un credito. </summary>
        /// <param name="tobjCredito"> Un objeto del tipo crédito. </param>
        /// <returns> El valor de cada cuota. </returns>
        public double gmtCalcularValordeCuota(tblCredito tobjCredito)
        {
			double dblValor = 0;
            int intNumeroCuotas = tobjCredito.intCuotas;
			if (tobjCredito.decIntereses != 0)
			{
                decimal decMonto = tobjCredito.decMonto;
				decimal decIntereses = Convert.ToDecimal(tobjCredito.decIntereses / 100);

                switch(tobjCredito.strFrecuenciaPre)
				{
					case "Termino":
                        //intNumeroCuotas = intNumeroCuotas;
						break;
					case "Mensual":
                        //intNumeroCuotas = intNumeroCuotas;
						break;
					case "Quincenal":
                        intNumeroCuotas = intNumeroCuotas * 2;
						break;
					case "Decadal":
						intNumeroCuotas = intNumeroCuotas * 3;
						break;
					case "Semanal":
						intNumeroCuotas = intNumeroCuotas * 4;
						break;
				}
				//double dblElevar = this.fElevar((1 + dblIntereses), intCuotas);
				double dblElevar = Math.Pow(Convert.ToDouble(1 + decIntereses), intNumeroCuotas); 

				dblValor = Convert.ToDouble(tobjCredito.decMonto) * Convert.ToDouble( decIntereses) * (dblElevar / (dblElevar -1 ));
			}
			else
			{
				decimal decMontoCero = tobjCredito.decMonto;
				switch(tobjCredito.strFrecuenciaPre)
				{
					case "Termino":
                        //intNumeroCuotas = intNumeroCuotas;
						break;
					case "Mensual":
                        //intNumeroCuotas = intNumeroCuotas;
						break;
					case "Quincenal":
						intNumeroCuotas = intNumeroCuotas * 2;
						break;
					case "Decadal":
						intNumeroCuotas = intNumeroCuotas * 3;
						break;
				}

				dblValor = Convert.ToDouble(decMontoCero) / intNumeroCuotas;
			}
            return dblValor;
        }

        /// <summary> Calcula las fecha de un crédito. </summary>
        /// <param name="tobjCredito"> Un objeto con los datos del crédito. </param>
        /// <param name="tintCuotas"> El número de cuotas del credito. </param>
        /// <returns> Un lista con las fechas del crédito. </returns>
        private List<DateTime> pGenerarFechasdeCuotasAutomaticamente(tblCredito tobjCredito)
        {
            DateTime dtmFechaini = tobjCredito.dtmFechaPre;
            DateTime dtmFechaCuo;
            DateTime dtmFechaCuoQuincena;
            int intCuotas = 0;

            lstFechas = new List<DateTime>();

            switch (tobjCredito.strFrecuenciaPre)
            {
                case "Mensual":
                    intCuotas = tobjCredito.intCuotas;
                    for (int a = 1; a <= intCuotas; a++)
                    {
                        dtmFechaCuo = dtmFechaini.AddMonths(a);
                        this.pGenerarFechas(intCuotas, dtmFechaCuo);
                    }
                    break;
                case "Termino":
                    intCuotas = tobjCredito.intCuotas;
                    for (int a = 1; a <= intCuotas; a++)
                    {
                        dtmFechaCuo = dtmFechaini.AddMonths(a);
                        this.pGenerarFechas(intCuotas, dtmFechaCuo);
                    }
                    break;
                case "Quincenal":
                    intCuotas = tobjCredito.intCuotas * 2;
                    for (int a = 1; a <= intCuotas / 2; a++)
                    {
                        dtmFechaCuo = dtmFechaini.AddMonths(a);
                        this.pGenerarFechas(intCuotas, dtmFechaCuo);
                        dtmFechaCuoQuincena = dtmFechaCuo.AddDays(15);
                        this.pGenerarFechas(intCuotas, dtmFechaCuoQuincena);
                    }
                    break;
                case "Decadal":
                    intCuotas = tobjCredito.intCuotas * 3;
                    for (int a = 1; a <= intCuotas; a++)
                    {
                        dtmFechaCuo = dtmFechaini.AddDays(10);
                        this.pGenerarFechas(intCuotas, dtmFechaCuo);
                    }
                    break;
            }
            return lstFechas;
        }

        /// <summary> Adiciona una fecha a la lista de fechas. </summary>
        /// <param name="tintCuotas"> Cuotas que debe tener el crédito. </param>
        /// <param name="tdtmFecha"> Fecha en la que se debe de pagar la cuota</param>
        /// <returns> Un valor que indica si se pudo o no adicionar la fecha a la lista. </returns>
        private bool pGenerarFechas(int tintCuotas, DateTime tdtmFecha)
        {
            if (this.lstFechas.Count < tintCuotas)
            {
                lstFechas.Add(tdtmFecha);

                if (lstFechas.Count == tintCuotas)
                    return false;
                else
                    return true;
            }
            else
                return false;

        }

        #endregion

        /// <summary> Consulta un determinado credito. </summary>
        /// <param name="tstrCodMunicipio">el código del credito consultar.</param>
        /// <returns> un objeto del tipo tblCredito. </returns>
        public tblCredito gmtdConsultar(int tintCodCredito)
        {
            return new daoCreditos().gmtdConsultar(tintCodCredito);
        }

        /// <summary> Consulta un determinado credito por el número de cédula del deudor. </summary>
        /// <param name="tstrCedula">Cédula para consultar el cédito.</param>
        /// <returns> un objeto del tipo tblCredito. </returns>
        public tblCredito gmtdConsultar(string tstrCedula)
        {
            return new daoCreditos().gmtdConsultar(tstrCedula);
        }

        /// <summary> Calcula el còdigo de crèdito que se va a generar. </summary>
        /// <returns> El còdigo del credito que se debe de generar. </returns>
        public int gmtdConsultarCodigodeCredito()
        {
            int intCodigo = 0;
            List<tblCredito> lstCreditos = new daoCreditos().gmtdConsultarTodos();
            if (lstCreditos.Count > 0)
            {
                intCodigo = lstCreditos[lstCreditos.Count - 1].intCodigoCre;
            }
            else
            {
                intCodigo = 0;
            }
            intCodigo++;
            return intCodigo;
        }


        /// <summary> Consulta el valor y código del crédito egistrados a una persona. </summary>
        /// <param name="tstrCedulaCredito">El número de la cédula de la persona a la que se le van a consultar los créditos. </param>
        /// <returns> Una lista con los creditos seleccuinados. </returns>
        public List<creditoss> gmtdConsultarCreditosxPersona(string tstrCedulaCredito)
        {
            return new daoCreditos().gmtdConsultarCreditosxPersona(tstrCedulaCredito);
        }

        /// <summary> Consulta los códigos de los creditos registrados a una persona </summary>
        /// <param name="tstrCedulaCredito"> Cedula de la persona a la que se le van a consultar los creditos. </param>
        /// <returns> Una lista con los creditos. </returns>
        public List<tblCredito> gmtdConsultaCreditosParaRecibo(string tstrCedulaCredito)
        {
            return new daoCreditos().gmtdConsultaCreditosParaRecibo(tstrCedulaCredito);
        }

        /// <summary> Consulta el monto de un crédito. </summary>
        /// <param name="tintPrestamo"> Código del crédito a consultar. </param>
        /// <returns> El monto de un crédito. </returns>
        public decimal gmtdConsultarMonto(int tintPrestamo)
        {
            tblCredito credito = this.gmtdConsultar(tintPrestamo);

            return credito.decMonto;

        }

        /// <summary> Consulta si un prestamo tiene o no cuotas pagas. </summary>
        /// <param name="tintCredito"> Código del crédito a consultarle las cuotas. </param>
        /// <returns> Un valor que indica si el credito tiene o no cuotas pagas. </returns>
        public bool gmtdSabersihaycuotaspagadasdeuncredito(int tintCredito)
        {
            return new daoCreditos().gmtdSabersihaycuotaspagadasdeuncredito(tintCredito);
        }

        /// <summary> Consulta lo intereses causados de un credito. </summary>
        /// <param name="tintCredito"> Código del credito. </param>
        /// <returns> Un valor que indica lo causado del crédito. </returns>
        public decimal gmtdConsultaInteresCausadoporCredito(int tintCredito)
        {
            return new daoCreditos().gmtdConsultaInteresCausadoporCredito(tintCredito);
        }

        /// <summary> Consulta las cuotas pendientes de un credito. </summary>
        /// <param name="tintCredito">Código del credito a consultar</param>
        /// <returns> Una lista con las cuotas. </returns>
        public List<tblCreditosCuota> gmtdConsultarCuotasPendientesdeunCredito(int tintCredito)
        {
            return new daoCreditos().gmtdConsultarCuotasPendientesdeunCredito(tintCredito);
        }

        /// <summary> Calcula la diferencia entre la fecha de la cuota y la fecha actual. </summary>
        /// <param name="tdtmFechaCuota"> Fecha de la cuota. </param>
        /// <returns> El número de meses </returns>
        private int pmtdCalcularDiferenciaMeses(DateTime tdtmFechaCuota)
        {
            // Difference in days, hours, and minutes.
            TimeSpan ts = new daoUtilidadesConfiguracion().gmtdCapturarFechadelServidor() - tdtmFechaCuota;

            // Difference in days.
            int intDiferenciaenMeses = ts.Days;

            if (intDiferenciaenMeses <= 0)
                intDiferenciaenMeses = 0;
            else
            {

                intDiferenciaenMeses = intDiferenciaenMeses / 30;
                intDiferenciaenMeses ++;
            }

            return intDiferenciaenMeses;
        }

        /// <summary> Calcula las cuotas a cancelar en un recibo. </summary>
        /// <param name="tintCredito"> Codigo del crésdito al que se le van a pagar las cuotas. </param>
        /// <param name="tintCuotas"> Numero de cuotas a cancelar. </param>
        /// <returns> Listado de cuotas procesadas. </returns>
        public List<recibosIngresosPrestamos> gmtdCalcularValordeCuotas(int tintCredito, int tintCuotas)
        { 
            List<tblCreditosCuota> lstCuotas = new daoCreditos().gmtdConsultarCuotasPendientesdeunCredito(tintCredito);

            decimal decCausadoTotal = this.gmtdConsultaInteresCausadoporCredito(tintCredito);
            decimal decMora = new daoUtilidadesConfiguracion().gmtdConsultaConfiguracion().decMoraCreditos;

            List<recibosIngresosPrestamos> lstCuotasOrganizadas = new List<recibosIngresosPrestamos>();

             for (int a = 0; a < tintCuotas; a++)
             {
                 tblCreditosCuota cuota = new tblCreditosCuota();
                 cuota = lstCuotas[a];

                 decimal decCausado = 0;
                 int intMeses = this.pmtdCalcularDiferenciaMeses(cuota.dtmFechaCuo);
                 decimal decInteresMora = cuota.decCapital * (decMora / 100) * intMeses;

                 if (decCausadoTotal > cuota.decIntereses)
                 {
                     decCausado = cuota.decIntereses;
                     cuota.decIntereses = 0;
                     decCausadoTotal -= decCausado;
                 }
                 else
                 {
                     decCausado = decCausadoTotal;
                     cuota.decIntereses -= decCausadoTotal;
                     decCausadoTotal = 0;
                 }

                 recibosIngresosPrestamos cuotaRecibo = new recibosIngresosPrestamos();
                 cuotaRecibo.decCapital = cuota.decCapital;
                 cuotaRecibo.decCausado = decCausado;
                 cuotaRecibo.decIntereses = cuota.decIntereses;
                 cuotaRecibo.decInteresesMora = decInteresMora;
                 cuotaRecibo.decValorCuota = cuota.decCapital + cuota.decIntereses + decInteresMora + decCausado;
                 cuotaRecibo.intCuota = cuota.intCuota;
                 cuotaRecibo.intMesesAtrasados = intMeses;
                 cuotaRecibo.dtmFechaCuo = cuota.dtmFechaCuo;

                 lstCuotasOrganizadas.Add(cuotaRecibo);
             }

             return lstCuotasOrganizadas;
        }

        /// <summary> Elimina un de credito de la base de datos. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo credito. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblCredito tobjCredito)
        {
            if (tobjCredito.intCodigoCre == 0)
                return "- Debe de ingresar el código del prestamo a eliminar.";

            tblCredito cre = new daoCreditos().gmtdConsultar(tobjCredito.intCodigoCre);

            if (cre.strNombrePre == null)
                return "- Este crédito no aparece registrado.";

            if (new daoCreditos().gmtdSabersihaycuotaspagadasdeuncredito(cre.intCodigoCre))
                return "- Este crédito ya tiene cuotas pagadas y no se puede eliminar.";

            tobjCredito.intCodigoRec = new blCreditos().gmtdConsultar(tobjCredito.intCodigoCre).intCodigoRec;

            tobjCredito.log = metodos.gmtdLog("Elimina el crédito " + tobjCredito.intCodigoCre.ToString(), tobjCredito.strFormulario);

            return new daoCreditos().gmtdEliminar(tobjCredito);
        }
    }
}
