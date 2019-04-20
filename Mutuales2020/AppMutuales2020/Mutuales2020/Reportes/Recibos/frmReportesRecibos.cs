using libMutuales2020.dominio;
using libMutuales2020.logica;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mutuales2020.Reportes.Recibos
{
    public partial class frmReportesRecibos : Form
    {
        public frmReportesRecibos()
        {
            InitializeComponent();
        }

        private void frmReportesRecibos_Load(object sender, EventArgs e)
        {
            this.cboOtrosIngresos.DataSource = new blOtroIngreso().gmtdConsultarTodos();
            this.rptReportesRecibo.RefreshReport();
        }

        private void cboTipoReporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                switch (this.cboTipoReporte.Text.Substring(0, 2))
                {
                    case "01":
                    case "04":
                    case "05":
                        this.btnGenerarReporte.Focus();
                        break;
                    case "02":
                    case "06":
                    case "07":
                    case "08":
                    case "09":
                    case "11":
                    case "12":
                    case "13":
                    case "16":
                    case "17":
                    case "18":
                    case "21":
                        this.dtmFechaInicial.Focus();
                        break;
                    case "03":
                    case "14":
                    case "19":
                        this.txtCedula.Focus();
                        break;
                    case "15":
                        this.txtPrestamo.Focus();
                        break;
                    case "20":
                        this.cboOtrosIngresos.Focus();
                        break;
                }
            }
        }

        private void dtmFechaInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                switch (this.cboTipoReporte.Text.Substring(0, 2))
                {
                    case "21":
                        this.btnGenerarReporte.Focus();
                        break;
                    default:
                        this.dtmFechaFinal.Focus();
                        break;
                }
            }
        }

        private void dtmFechaFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                switch (this.cboTipoReporte.Text.Substring(0, 2))
                {
                    case "02":
                        this.btnGenerarReporte.Focus();
                        break;
                }
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                switch (this.cboTipoReporte.Text.Substring(0, 2))
                {
                    case "03":
                        this.btnGenerarReporte.Focus();
                        break;
                }
            }
        }

        private void txtPrestamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.btnGenerarReporte.Focus();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            ReportDataSource datasource = new ReportDataSource();
            DataSet ds = new DataSet();
            List<Microsoft.Reporting.WinForms.ReportParameter> lstParametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter parametroReporte;
            List<SqlParameter> lstParameters = new List<SqlParameter>();
            SqlParameter parametro;

            this.rptReportesRecibo.Reset();

            switch (this.cboTipoReporte.Text.Substring(0, 2))
            {
                case "01":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteIngresos01RecibosRegistrados");

                    datasource = new ReportDataSource("recibosIngresos_spReporteIngresos01RecibosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ingresos activos");
                    lstParametros.Add(parametroReporte);
                    rptReportesRecibo.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Recibos.rptRecibosIngresos.rdlc";
                    break;
                case "02":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteIngresos02RecibosRegistradoporRangodeFechas");

                    datasource = new ReportDataSource("recibosIngresos_spReporteIngresos01RecibosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ingresos registrados entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesRecibo.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Recibos.rptRecibosIngresos.rdlc";
                    break;
                case "03":
                    parametro = new SqlParameter("@strCedulaIng", SqlDbType.VarChar);
                    parametro.Value = this.txtCedula.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteIngresos03RecibosRegistradoporCedula");

                    datasource = new ReportDataSource("recibosIngresos_spReporteIngresos01RecibosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ingresos registrados a la cédula " + this.txtCedula.Text);
                    lstParametros.Add(parametroReporte);
                    rptReportesRecibo.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Recibos.rptRecibosIngresos.rdlc";
                    break;
                case "04":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteIngresos04RecibosActivos");

                    datasource = new ReportDataSource("recibosIngresos_spReporteIngresos01RecibosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ingresos activos");
                    lstParametros.Add(parametroReporte);
                    rptReportesRecibo.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Recibos.rptRecibosIngresos.rdlc";
                    break;
                case "05":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteIngresos05RecibosAnulados");

                    datasource = new ReportDataSource("recibosIngresos_spReporteIngresos01RecibosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ingresos activos");
                    lstParametros.Add(parametroReporte);
                    rptReportesRecibo.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Recibos.rptRecibosIngresos.rdlc";
                    break;
                case "06":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteIngresos06RecibosAnuladosporRangodeFechas");

                    datasource = new ReportDataSource("recibosIngresos_spReporteIngresos01RecibosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ingresos anulados entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesRecibo.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Recibos.rptRecibosIngresos.rdlc";
                    break;
                case "07":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteIngresos07RecibosdecuotasexequialesactivosenRangodeFecha");

                    datasource = new ReportDataSource("spReporteIngresos07RecibosdecuotasexequialesactivosenRangodeFecha_spReporteIngresos07RecibosdecuotasexequialesactivosenRangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de cuotas exequiales registrados entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesRecibo.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Recibos.rptRecibosIngresosCuotasExequiales.rdlc";
                    break;
                case "08":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteIngresos08RecibosdecuotasexequialesanuladosenRangodeFecha");

                    datasource = new ReportDataSource("spReporteIngresos07RecibosdecuotasexequialesactivosenRangodeFecha_spReporteIngresos07RecibosdecuotasexequialesactivosenRangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de cuotas exequiales anuladas entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesRecibo.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Recibos.rptRecibosIngresosCuotasExequiales.rdlc";
                    break;
                case "09":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteIngresos09RecibosdecuotasexequialesregistradosenRangodeFecha");

                    datasource = new ReportDataSource("spReporteIngresos07RecibosdecuotasexequialesactivosenRangodeFecha_spReporteIngresos07RecibosdecuotasexequialesactivosenRangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de cuotas exequiales registradas entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesRecibo.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Recibos.rptRecibosIngresosCuotasExequiales.rdlc";
                    break;
                case "10":
                    parametro = new SqlParameter("@intCodigoSoc", SqlDbType.Int);
                    parametro.Value = this.txtCedula.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteIngresos10Recibosdecuotasexequialesregistradosaunsocio");

                    datasource = new ReportDataSource("spReporteIngresos07RecibosdecuotasexequialesactivosenRangodeFecha_spReporteIngresos07RecibosdecuotasexequialesactivosenRangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de cuotas exequiales registradas al socio " + this.txtCedula.Text);
                    lstParametros.Add(parametroReporte);
                    rptReportesRecibo.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Recibos.rptRecibosIngresosCuotasExequiales.rdlc";
                    break;
                case "11":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteIngresos11RecibosdecuotasdeprestamosactivosenRangodeFecha");

                    datasource = new ReportDataSource("spReporteIngresos11RecibosdecuotasdeprestamosactivosenRangodeFecha_spReporteIngresos11RecibosdecuotasdeprestamosactivosenRangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de cuotas activas de préstamos entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesRecibo.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Recibos.rptRecibosIngresosCuotasPrestamos.rdlc";
                    break;
                case "12":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteIngresos12RecibosdecuotasdeprestamosanuladosenRangodeFecha");

                    datasource = new ReportDataSource("spReporteIngresos11RecibosdecuotasdeprestamosactivosenRangodeFecha_spReporteIngresos11RecibosdecuotasdeprestamosactivosenRangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de cuotas anuladas de préstamos entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesRecibo.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Recibos.rptRecibosIngresosCuotasPrestamos.rdlc";
                    break;
                case "13":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteIngresos13RecibosdecuotasdeprestamosregistradosenRangodeFecha");

                    datasource = new ReportDataSource("spReporteIngresos11RecibosdecuotasdeprestamosactivosenRangodeFecha_spReporteIngresos11RecibosdecuotasdeprestamosactivosenRangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de cuotas registradas de préstamos entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesRecibo.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Recibos.rptRecibosIngresosCuotasPrestamos.rdlc";
                    break;
                case "14":
                    parametro = new SqlParameter("@strCedulaPre", SqlDbType.VarChar);
                    parametro.Value = this.txtCedula.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteIngresos14Recibosdecuotasdeprestamosregistradosaunapersona");

                    datasource = new ReportDataSource("spReporteIngresos11RecibosdecuotasdeprestamosactivosenRangodeFecha_spReporteIngresos11RecibosdecuotasdeprestamosactivosenRangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de cuotas registradas a una determinada persona ");
                    lstParametros.Add(parametroReporte);
                    rptReportesRecibo.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Recibos.rptRecibosIngresosCuotasPrestamos.rdlc";
                    break;
                case "15":
                    parametro = new SqlParameter("@intCodigoPre", SqlDbType.VarChar);
                    parametro.Value = this.txtPrestamo.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteIngresos15Recibosdecuotasdeprestamosregistradosauncredito");

                    datasource = new ReportDataSource("spReporteIngresos11RecibosdecuotasdeprestamosactivosenRangodeFecha_spReporteIngresos11RecibosdecuotasdeprestamosactivosenRangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de cuotas registradas al préstamo " + this.txtPrestamo.Text);
                    lstParametros.Add(parametroReporte);
                    rptReportesRecibo.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Recibos.rptRecibosIngresosCuotasPrestamos.rdlc";
                    break;
                case "16":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteIngresos16RecibosdeotrosingresosactivosenRangodeFecha");

                    datasource = new ReportDataSource("spReporteIngresos16RecibosdeotrosingresosactivosenRangodeFecha_spReporteIngresos16RecibosdeotrosingresosactivosenRangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de otros ingresos activos entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesRecibo.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Recibos.rptRecibosIngresosOtrosIngresos.rdlc";
                    break;
                case "17":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteIngresos17RecibosdeotrosingresosanuladosenRangodeFecha");

                    datasource = new ReportDataSource("spReporteIngresos16RecibosdeotrosingresosactivosenRangodeFecha_spReporteIngresos16RecibosdeotrosingresosactivosenRangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de otros ingresos anulados entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesRecibo.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Recibos.rptRecibosIngresosOtrosIngresos.rdlc";
                    break;
                case "18":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteIngresos18RecibosdeotrosingresosregistradosenRangodeFecha");

                    datasource = new ReportDataSource("spReporteIngresos16RecibosdeotrosingresosactivosenRangodeFecha_spReporteIngresos16RecibosdeotrosingresosactivosenRangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de otros ingresos registrados entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesRecibo.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Recibos.rptRecibosIngresosOtrosIngresos.rdlc";
                    break;
                case "19":
                    parametro = new SqlParameter("@strCedulaPer", SqlDbType.VarChar);
                    parametro.Value = this.txtCedula.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteIngresos19Recibosdeotrosingresosdeunapersona");

                    datasource = new ReportDataSource("spReporteIngresos16RecibosdeotrosingresosactivosenRangodeFecha_spReporteIngresos16RecibosdeotrosingresosactivosenRangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de otros ingresos registrados a " + this.txtCedula.Text);
                    lstParametros.Add(parametroReporte);
                    rptReportesRecibo.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Recibos.rptRecibosIngresosOtrosIngresos.rdlc";
                    break;
                case "20":
                    parametro = new SqlParameter("@strCodOtrosIngresos", SqlDbType.VarChar);
                    parametro.Value = this.cboOtrosIngresos.SelectedValue.ToString();
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteIngresos20Recibosdeotrosingresosdeunitem");

                    datasource = new ReportDataSource("spReporteIngresos16RecibosdeotrosingresosactivosenRangodeFecha_spReporteIngresos16RecibosdeotrosingresosactivosenRangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de otros ingresos registrados a " + this.cboOtrosIngresos.Text);
                    lstParametros.Add(parametroReporte);
                    rptReportesRecibo.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Recibos.rptRecibosIngresosOtrosIngresos.rdlc";
                    break;
                case "21":
                    parametro = new SqlParameter("@dtmFechaRec", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteIngresos21RecibosInformeDiario");

                    datasource = new ReportDataSource("spReporteIngresos21RecibosInformeDiario_spReporteIngresos21RecibosInformeDiario", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de recibos del día " + this.dtmFechaInicial.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesRecibo.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Recibos.rptRecibosIngresosInformeDiario.rdlc";
                    break;
            }

            rptReportesRecibo.ProcessingMode = ProcessingMode.Local;
            rptReportesRecibo.LocalReport.DataSources.Clear();
            rptReportesRecibo.LocalReport.DataSources.Add(datasource);
            rptReportesRecibo.LocalReport.SetParameters(lstParametros);
            rptReportesRecibo.LocalReport.Refresh();

            this.rptReportesRecibo.RefreshReport();
        }
    }
}
