using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libMutuales2020.dominio;
using System.Transactions;
using libMutuales2020.logica;
using System.Diagnostics;
using System.Xml;

namespace libMutuales2020.dao
{
    class daoCreditos
    {
        /// <summary> Inserta un credito. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo tblCredito. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblCredito tobjCredito)
        {
            String strRetornar;
            try
            {
                using (dbExequial2010DataContext recibosEgresos = new dbExequial2010DataContext())
                {
                    tblEgresosEgreso egresoEgreso = new tblEgresosEgreso();
                    egresoEgreso.decIva = 0;
                    egresoEgreso.decRetencion = 0;
                    egresoEgreso.decValorBruto = tobjCredito.decMonto;
                    egresoEgreso.decValorIva = 0;
                    egresoEgreso.decValorNeto = tobjCredito.decMonto;
                    egresoEgreso.decValorRetencion = 0;
                    egresoEgreso.strCodOtrosEgresos = "0001";
                    egresoEgreso.strDescripcion = "Se le registro el crédito " + tobjCredito.intCodigoCre.ToString() + " Linea: " + tobjCredito.strNombreLinea;

                    tblEgreso egreso = new tblEgreso();
                    egreso.bitEgreso = true;
                    egreso.decTotal = tobjCredito.decMonto;
                    egreso.dtmFechaAnu = Convert.ToDateTime("1/1/1900");
                    egreso.dtmFechaRec = new daoUtilidadesConfiguracion().gmtdCapturarFechadelServidor();
                    egreso.strApellido = tobjCredito.strApellido1Pre + " " + tobjCredito.strApellido2Pre;
                    egreso.strCedulaEgre = tobjCredito.strCedulaPre;
                    egreso.strFormulario = tobjCredito.strFormulario;
                    egreso.strLetras = new blConfiguracion().montoenLetras(tobjCredito.decMonto.ToString());
                    egreso.strNombre = tobjCredito.strNombrePre;
                    egreso.strMaquina = tobjCredito.strComputador;
                    egreso.strUsuario = tobjCredito.strUsuario;

                    List<tblEgresosEgreso> lstEgresosDetalle = new List<tblEgresosEgreso>();
                    lstEgresosDetalle.Add(egresoEgreso);

                    egreso.egresoEgreso = lstEgresosDetalle;
                    XmlDocument xml = blRecibosEgresos.SerializeServicio(egreso);
                    string strEgreso = new daoRecibosEgresos().gmtdInsertar(xml);
                    tobjCredito.intCodigoRec = Convert.ToInt32(strEgreso);
                }

                using (dbExequial2010DataContext tipo = new dbExequial2010DataContext())
                {
                    tipo.tblCreditos.InsertOnSubmit(tobjCredito);
                    tipo.tblLogdeActividades.InsertOnSubmit(tobjCredito.log);
                    tipo.SubmitChanges();
                }

                strRetornar = "Registro Insertado. Se registro el egreso # " + tobjCredito.intCodigoRec.ToString();
            }
            catch (Exception ex)
            {
                EventLog even = new EventLog();
                even.Source = "Exequial2010";
                even.WriteEntry(ex.Message, EventLogEntryType.Information); 
                new dao().gmtdInsertarError(ex);
                strRetornar = "- Ocurrió un error al insertar el registro.";
            }
            return strRetornar;
        }

        /// <summary> Consultar todos los crèditos </summary>
        /// <returns> Un listados de todos los creditos registrados. </returns>
        public List<tblCredito> gmtdConsultarTodos()
        {
            using (dbExequial2010DataContext tipos = new dbExequial2010DataContext())
            {
                var query = from cre in tipos.tblCreditos
                            select cre;

                return query.ToList();
            }
        }

        /// <summary> Consulta un determinado credito por el número. </summary>
        /// <param name="tstrCodMunicipio">el código del credito consultar.</param>
        /// <returns> un objeto del tipo tblCredito. </returns>
        public tblCredito gmtdConsultar(int tintCodCredito)
        {
            using (dbExequial2010DataContext tipos = new dbExequial2010DataContext())
            {
                var query = from cre in tipos.tblCreditos
                            where cre.intCodigoCre == tintCodCredito
                            select cre;

                if (query.ToList().Count > 0)
                    return query.ToList()[0];
                else
                    return new tblCredito();
            }
        }

        /// <summary> Consulta un determinado credito por el número de cédula del deudor. </summary>
        /// <param name="tstrCedula">Cédula para consultar el cédito.</param>
        /// <returns> un objeto del tipo tblCredito. </returns>
        public tblCredito gmtdConsultar(string tstrCedula)
        {
            using (dbExequial2010DataContext tipos = new dbExequial2010DataContext())
            {
                var query = from cre in tipos.tblCreditos
                            where cre.strCedulaPre == tstrCedula
                            select cre;

                if (query.ToList().Count > 0)
                    return query.ToList()[0];
                else
                    return new tblCredito();
            }
        }

        /// <summary> Consulta si un prestamo tiene o no cuotas pagas. </summary>
        /// <param name="tintCredito"> Código del crédito a consultarle las cuotas. </param>
        /// <returns> Un valor que indica si el credito tiene o no cuotas pagas. </returns>
        public bool gmtdSabersihaycuotaspagadasdeuncredito(int tintCredito)
        {
            using (dbExequial2010DataContext tipos = new dbExequial2010DataContext())
            {
                var query = from cre in tipos.tblCreditosCuotas
                            where cre.intCodigoCre == tintCredito && cre.bitPagada == true
                            select cre;

                if (query.ToList().Count > 0)
                    return true;
                else
                    return false;
            }
        }

        /// <summary> Consulta los creditos registrados a una persona ya sea como deudora o codeudora. </summary>
        /// <param name="tstrCedulaCredito">El número de la cédula de la persona a la que se le van a consultar los créditos. </param>
        /// <returns> Una lista con los creditos seleccuinados. </returns>
        public List<creditoss> gmtdConsultarCreditosxPersona(string tstrCedulaCredito)
        {
            using (dbExequial2010DataContext tipos = new dbExequial2010DataContext())
            {
                var query = from cre in tipos.tblCreditos
                            where (cre.strCedulaCde == tstrCedulaCredito || cre.strCedulaCde2 == tstrCedulaCredito || cre.strCedulaPre == tstrCedulaCredito ) && cre.decDebe > 0 && cre.bitAnulado == false
                            select cre;

                List<creditoss> lstCreditos = new List<creditoss>();

                foreach (var dato in query.ToList())
                {
                    creditoss credito = new creditoss();
                    credito.intCodigoPre = dato.intCodigoCre;
                    credito.decValorDebePre = dato.decDebe;
                    lstCreditos.Add(credito);
                }

                return lstCreditos;
            }
        }

        /// <summary> Consulta los códigos de los creditos registrados a una persona </summary>
        /// <param name="tstrCedulaCredito"> Cedula de la persona a la que se le van a consultar los creditos. </param>
        /// <returns> Una lista con los creditos. </returns>
        public List<tblCredito> gmtdConsultaCreditosParaRecibo(string tstrCedulaCredito)
        {
            using (dbExequial2010DataContext tipos = new dbExequial2010DataContext())
            {
                var query = from cre in tipos.tblCreditos
                            where cre.strCedulaPre == tstrCedulaCredito && cre.decDebe > 0 && cre.bitAnulado == false
                            select cre;

                return query.ToList();
            }
        }

        /// <summary> Consulta las cuotas pendientes de un credito. </summary>
        /// <param name="tintCredito">Código del credito a consultar</param>
        /// <returns> Una lista con las cuotas. </returns>
        public List<tblCreditosCuota> gmtdConsultarCuotasPendientesdeunCredito(int tintCredito)
        {
            using (dbExequial2010DataContext tipos = new dbExequial2010DataContext())
            {
                var query = from cuo in tipos.tblCreditosCuotas
                            where cuo.intCodigoCre == tintCredito && cuo.bitPagada == false
                            orderby cuo.intCuota ascending
                            select cuo;
                return query.ToList();
            }
        }

        /// <summary> Consulta lo intereses causados de un credito. </summary>
        /// <param name="tintCredito"> Código del credito. </param>
        /// <returns> Un valor que indica lo causado del crédito. </returns>
        public decimal gmtdConsultaInteresCausadoporCredito(int tintCredito)
        {
            using (dbExequial2010DataContext tipos = new dbExequial2010DataContext())
            {
                var query = from cuo in tipos.tblCreditosInteresesCausados
                            where cuo.intCodigoCre == tintCredito 
                            select cuo;

                if (query.ToList().Count > 0)
                    return query.ToList()[0].decCausadoCre;
                else
                    return 0;
            }
        }
        
        /// <summary> Elimina un de credito de la base de datos. </summary>
        /// <param name="tobjMunicipio"> Un objeto del tipo credito. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblCredito tobjCredito)
        {
            String strResultado;
            try
            {
                using (dbExequial2010DataContext tipo = new dbExequial2010DataContext())
                {
                    tblCredito cre_old = tipo.tblCreditos.SingleOrDefault(p => p.intCodigoCre == tobjCredito.intCodigoCre);
                    cre_old.dtmFechaAnu = new daoUtilidadesConfiguracion().gmtdCapturarFechadelServidor();
                    cre_old.bitAnulado = true;
                    tipo.tblLogdeActividades.InsertOnSubmit(tobjCredito.log);
                    tipo.SubmitChanges();
                }

                using (dbExequial2010DataContext recibosEgresos = new dbExequial2010DataContext())
                {
                    if (tobjCredito.intCodigoRec != 0)
                    {
                        tblEgreso egr = recibosEgresos.tblEgresos.SingleOrDefault(p => p.intCodigoEgr == tobjCredito.intCodigoRec);
                        egr.bitAnulado = true;
                        egr.dtmFechaAnu = new daoUtilidadesConfiguracion().gmtdCapturarFechadelServidor();

                        recibosEgresos.tblLogdeActividades.InsertOnSubmit(metodos.gmtdLog("Elimino el egreso " + tobjCredito.intCodigoRec.ToString(), "FrmPrestamos"));

                        recibosEgresos.SubmitChanges();
                    }
                }

                strResultado = "Registro Eliminado";
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                strResultado = "- No se puede eliminar el registro.";
            }
            return strResultado;
        }

    }
}
