using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libMutuales2020.dominio;
using System.Transactions;
using libMutuales2020.logica;
using System.Xml;
using System.Data.SqlClient;
using System.Data;
using libMutuales2020.Utilidades;
using libMutuales2020.Recursos;

namespace libMutuales2020.dao
{
    class daoAhorrosCdtLiquidacion
    {
        /// <summary> Inserta una liquidacion de cdt. </summary>
        /// <param name="tobjAhorroaFuturo"> Un objeto del tipo tblAhorrosCdtsLiquidacion cdt. </param>
        /// <returns> Un string que indica si se ejecuto o no la operación. </returns>
        public string gmtdInsertar(tblAhorrosCdtsLiquidacion tobjAhorroCdtLiquidacion)
        {
            string strIngreso = "";
            string strEgreso = "";
            DateTime dtmFechaActual;
            DataTable dt = new DataTable();
            tblEgresosAhorrosCdtLiquidacion egresoLiquidacionCdt = new tblEgresosAhorrosCdtLiquidacion();

            try
            {
                egresoLiquidacionCdt.decValorLiquidacion = tobjAhorroCdtLiquidacion.decBrutoLiquidacion;
                egresoLiquidacionCdt.intNumeroCdt = tobjAhorroCdtLiquidacion.intNumeroCdt;
                egresoLiquidacionCdt.decRetencionLiquidacionCdt = tobjAhorroCdtLiquidacion.decRetencionLiquidacionCdt;

                tblEgreso egreso = new tblEgreso();
                egreso.bitRetiroAhorroCdtLiquidacion = true;
                egreso.decTotal = tobjAhorroCdtLiquidacion.decBrutoLiquidacion;
                egreso.dtmFechaAnu = Convert.ToDateTime("1/1/1900");
                dtmFechaActual = new daoUtilidadesConfiguracion().gmtdCapturarFechadelServidor();
                egreso.dtmFechaRec = dtmFechaActual;
                egreso.strApellido = tobjAhorroCdtLiquidacion.strApellidoAho;
                egreso.strCedulaEgre = tobjAhorroCdtLiquidacion.strCedulaAho;
                egreso.strFormulario = tobjAhorroCdtLiquidacion.strFormulario;
                egreso.strLetras = new blConfiguracion().montoenLetras(tobjAhorroCdtLiquidacion.decBrutoLiquidacion.ToString());
                egreso.strNombre = tobjAhorroCdtLiquidacion.strNombreAho;
                egreso.objEgresosAhorrosCdtLiquidacion = egresoLiquidacionCdt;

                if (egresoLiquidacionCdt.decRetencionLiquidacionCdt > 0)
                {
                    tblIngresosAhorrosCdtMulta ingresoCdtMulta = new tblIngresosAhorrosCdtMulta();
                    ingresoCdtMulta.decValorMulta = tobjAhorroCdtLiquidacion.decRetencionLiquidacionCdt;
                    ingresoCdtMulta.intNumeroCdt = tobjAhorroCdtLiquidacion.intNumeroCdt;
                    ingresoCdtMulta.strTipoOperacion = "Retención";

                    tblIngreso ingreso = new tblIngreso();
                    ingreso.bitAhorroCdtMulta = true;
                    ingreso.decTotalIng = tobjAhorroCdtLiquidacion.decRetencionLiquidacionCdt;
                    ingreso.dtmFechaAnu = Convert.ToDateTime("1/1/1900");
                    ingreso.dtmFechaRec = dtmFechaActual;
                    ingreso.strCedulaIng = tobjAhorroCdtLiquidacion.strCedulaAho;
                    ingreso.strComputador = "";
                    ingreso.strFormulario = tobjAhorroCdtLiquidacion.strFormulario; ;
                    ingreso.strLetras = new blConfiguracion().montoenLetras(tobjAhorroCdtLiquidacion.decRetencionLiquidacionCdt.ToString());
                    ingreso.strNombreIng = tobjAhorroCdtLiquidacion.strNombreAho;
                    ingreso.strApellidoIng = tobjAhorroCdtLiquidacion.strApellidoAho;
                    ingreso.strUsuario = "";
                    ingreso.objIngresosAhorrosCdtMulta = ingresoCdtMulta;
                    egreso.objIngreso = ingreso;
                }

                XmlDocument xml = blRecibosEgresos.SerializeServicio(egreso);

                List<SqlParameter> lstParametros = new List<SqlParameter>();
                SqlParameter objParameter = new SqlParameter();
                objParameter.DbType = DbType.Xml;
                objParameter.Direction = ParameterDirection.Input;
                objParameter.ParameterName = "xmlEgreso";
                objParameter.Value = xml.OuterXml;
                lstParametros.Add(objParameter);

                dt = new Utilidad().ejecutarSpConeccionDB(lstParametros, Sp.spEgresoInsertar);
            }
            catch (Exception ex)
            {
                new dao().gmtdInsertarError(ex);
                return "- Ocurrió un error al insertar el registro.";
            }

            strEgreso = dt.Rows[0]["intCodigoEgr"].ToString();
            strIngreso = dt.Rows[0]["intCodigoIng"].ToString();

            if (egresoLiquidacionCdt.decRetencionLiquidacionCdt > 0)
            {
                return "Se hace el registro de los siguientes recibos" + " \n " + strEgreso + " \n " + strIngreso;
            }
            else
            {
                return "Se hace el registro del siguiente egreso" + " \n " + strEgreso;
            }
        }

    }
}
