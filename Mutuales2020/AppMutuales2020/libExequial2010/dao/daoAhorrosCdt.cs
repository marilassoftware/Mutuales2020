using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libMutuales2020.dominio;
using System.Transactions;
using libMutuales2020.logica;
using System.Xml;

namespace libMutuales2020.dao
{
    class daoAhorrosCdt
    {
        /// <summary> Inserta un cdt. </summary>
        /// <param name="tobjAhorroaFuturo"> Un objeto del tipo ahorro cdt. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblAhorrosCdt tobjAhorroCdt)
        {
            try
            {
                tblIngresosAhorrosCdt ingresoCdt = new tblIngresosAhorrosCdt();
                ingresoCdt.decValorCdt = tobjAhorroCdt.decMontoCdt;
                ingresoCdt.intNumeroCdt = tobjAhorroCdt.intNumeroCdt;

                tblIngreso ingreso = new tblIngreso();
                ingreso.bitAhorroCdt = true;
                ingreso.decTotalIng = tobjAhorroCdt.decMontoCdt;
                ingreso.dtmFechaAnu = Convert.ToDateTime("1/1/2009");
                ingreso.dtmFechaRec = new blConfiguracion().gmtdCapturarFechadelServidor();
                ingreso.strCedulaIng = tobjAhorroCdt.strCedulaAho;
                ingreso.strComputador = Environment.MachineName;
                ingreso.strFormulario = tobjAhorroCdt.strFormulario;
                ingreso.strLetras = new blConfiguracion().montoenLetras(tobjAhorroCdt.decMontoCdt.ToString());
                tblAhorradore ahorrador = new blAhorrador().gmtdConsultar(tobjAhorroCdt.strCedulaAho);
                ingreso.strNombreIng = ahorrador.strNombreAho;
                ingreso.strApellidoIng = ahorrador.strApellido1Aho + " " + ahorrador.strApellido2Aho;
                ingreso.strUsuario = "";
                ingreso.strUsuario = propiedades.strLogin;
                ingreso.objIngresosAhorrosCdt = ingresoCdt;
                ingreso.objAhorroCdt = tobjAhorroCdt;

                XmlDocument xml = blRecibosIngresos.SerializeServicio(ingreso);

                string strRetorno = new daoRecibosIngresos().gmtdInsertar(xml);

                if (strRetorno == "0")
                {
                    return "- Ha ocurrido un error al ingresar el CDT.";
                }
                else
                {
                    return strRetorno + "+ Se ha registrado el CDT, el ingreso generado es el # " + strRetorno;
                }
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                return "- Ocurrió un error al insertar el registro.";
            }
        }

        /// <summary> Consulta todos los cdt-s registrados. </summary>
        /// <returns> Un lista con todos los cdt-s seleccionados. </returns>
        public IList<ahorrosCdt> gmtdConsultarTodos()
        {
                using (dbExequial2010DataContext ahorros = new dbExequial2010DataContext())
                {
                    List<ahorrosCdt> lstAhorrosCdt = new List<ahorrosCdt>();
                    var query = from cdt in ahorros.tblAhorrosCdts
                                join per in ahorros.tblAhorradores on cdt.strCedulaAho equals per.strCedulaAho
                                where cdt.bitAnuladoCdt == false && cdt.bitLiquidadoCdt == false
                                select new { cdt.intNumeroCdt, cdt.dtmFechaIniCdt, cdt.dtmFechaFinCdt, cdt.strCedulaAho, per.strNombreAho, per.strApellido1Aho, per.strApellido2Aho, cdt.decMontoCdt, cdt.intAnoMes, cdt.intMesesCdt, cdt.decInteresesCdt, cdt.bitAnticipadoCdt };


                    foreach (var dato in query.ToList())
                    {
                        ahorrosCdt aho = new ahorrosCdt();
                        aho.intNumeroCdt = dato.intNumeroCdt;
                        aho.dtmFechaIniCdt = dato.dtmFechaIniCdt;
                        aho.dtmFechaFinCdt = dato.dtmFechaFinCdt;
                        aho.strCedulaAho = dato.strCedulaAho;
                        aho.strNombreAho = dato.strNombreAho + " " + dato.strApellido1Aho + " " + dato.strApellido2Aho;
                        aho.decMontoCdt = dato.decMontoCdt;
                        aho.intAnoMes = dato.intAnoMes;
                        aho.intMesesCdt = dato.intMesesCdt;
                        aho.decInteresesCdt = dato.decInteresesCdt;
                        aho.bitAnticipadoCdt = dato.bitAnticipadoCdt;
                        lstAhorrosCdt.Add(aho);
                    }
                    return lstAhorrosCdt;
                }
        }

        /// <summary> Consulta un cdt registrado. </summary>
        /// <returns> Un cdt. </returns>
        public ahorrosCdt gmtdConsultar(int tintCdt)
        {
            using (dbExequial2010DataContext ahorros = new dbExequial2010DataContext())
            {
                var query = from cdt in ahorros.tblAhorrosCdts
                            join per in ahorros.tblAhorradores on cdt.strCedulaAho equals per.strCedulaAho
                            where cdt.bitAnuladoCdt == false && cdt.bitLiquidadoCdt == false && cdt.intNumeroCdt == tintCdt
                            select new { cdt.intNumeroCdt, cdt.dtmFechaIniCdt, cdt.strCedulaAho, per.strNombreAho, per.strApellido1Aho, per.strApellido2Aho, cdt.decMontoCdt, cdt.intAnoMes, cdt.intMesesCdt, cdt.decInteresesCdt };

                ahorrosCdt AhorrosCdt = new ahorrosCdt();

                foreach (var dato in query.ToList())
                {
                    AhorrosCdt.intNumeroCdt = dato.intNumeroCdt;
                    AhorrosCdt.dtmFechaIniCdt = dato.dtmFechaIniCdt;
                    AhorrosCdt.strCedulaAho = dato.strCedulaAho;
                    AhorrosCdt.strNombreAho = dato.strNombreAho + " " + dato.strApellido1Aho + " " + dato.strApellido2Aho;
                    AhorrosCdt.decMontoCdt = dato.decMontoCdt;
                    AhorrosCdt.intAnoMes = dato.intAnoMes;
                    AhorrosCdt.intMesesCdt = dato.intMesesCdt;
                    AhorrosCdt.decInteresesCdt = dato.decInteresesCdt;
                }
                return AhorrosCdt;
            }
        }

        /// <summary> Consulta un determiando Cdt. </summary>
        /// <param name="tintCdt"> Codigo del cdt a consultar. </param>
        /// <returns> Un objeto del tipo tblAhorrosCdt con el cdt consultado. </returns>
        public tblAhorrosCdt gmtdConsultarCdt(int tintCdt)
        {
            using (dbExequial2010DataContext ahorros = new dbExequial2010DataContext())
            {
                var query = from cdt in ahorros.tblAhorrosCdts
                            where cdt.bitAnuladoCdt == false && cdt.bitLiquidadoCdt == false && cdt.intNumeroCdt == tintCdt
                            select cdt;

                if (query.ToList().Count > 0)
                    return query.ToList()[0];
                else
                    return new tblAhorrosCdt();
            }
        }

        /// <summary> Elimina un cdt. </summary>
        /// <param name="tobjAhorrosaFuturo"> Un objeto del tipo tblAhorrosCdt. </param>
        /// <returns> Un string que indica si se ejecuto o no el metodo. </returns>
        public String gmtdEliminar(tblAhorrosCdt tobjAhorrosCdt)
        {
            String strResultado;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    using (dbExequial2010DataContext cdt = new dbExequial2010DataContext())
                    {
                        tblAhorrosCdt cdt_old = cdt.tblAhorrosCdts.SingleOrDefault(p => p.intNumeroCdt == tobjAhorrosCdt.intNumeroCdt);
                        cdt_old.bitAnuladoCdt = true;
                        cdt_old.dtmFechaAnulado = DateTime.Now;
                        cdt.tblLogdeActividades.InsertOnSubmit(tobjAhorrosCdt.log);
                        cdt.SubmitChanges();
                    }

                    using (dbExequial2010DataContext recibosIngresos = new dbExequial2010DataContext())
                    {
                        tblIngreso ing = recibosIngresos.tblIngresos.SingleOrDefault(p => p.intCodigoIng == tobjAhorrosCdt.intCodigoIng);
                        ing.bitAnulado = true;
                        ing.dtmFechaAnu = new daoUtilidadesConfiguracion().gmtdCapturarFechadelServidor();

                        recibosIngresos.tblLogdeActividades.InsertOnSubmit(metodos.gmtdLog("Elimino el ingreso " + tobjAhorrosCdt.intCodigoIng.ToString(), "frmAhorrosCdt"));

                        recibosIngresos.SubmitChanges();
                    }

                    ts.Complete();

                    strResultado = "Registro Eliminado";
                }
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
