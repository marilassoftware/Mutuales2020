using libMutuales2020.dominio;
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

namespace Mutuales2020.Reportes.Ahorros
{
    public partial class FrmReportesAhorros : Form
    {
        public FrmReportesAhorros()
        {
            InitializeComponent();
        }

        private void FrmReportesAhorros_Load(object sender, EventArgs e)
        {

        }

        private void cboTipoReporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                switch (this.cboTipoReporte.Text.Substring(0, 2))
                {
                    case "01":
                    case "02":
                    case "03":
                    case "04":
                    case "05":
                    case "06":
                    case "08":
                    case "09":
                        this.dtmFechaInicial.Focus();
                        break;
                    case "10":
                        this.dtmFechaInicial.Value = Convert.ToDateTime("2000/01/01");
                        this.dtmFechaFinal.Focus();
                        break;
                }
            }
        }

        private void dtmFechaInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.dtmFechaFinal.Focus();
        }

        private void dtmFechaFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                switch (this.cboTipoReporte.Text.Substring(0, 2))
                {
                    case "01":
                    case "02":
                    case "03":
                    case "09":
                    case "10":
                        this.btnGenerarReporte.Focus();
                        break;
                    case "04":
                    case "05":
                    case "06":
                        this.txtCedula.Focus();
                        break;
                }
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
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

            this.rptReportesAhorros.Reset();

            switch (this.cboTipoReporte.Text.Substring(0, 2))
            {
                case "01":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteAhorros01AhorrosActivosenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteAhorros01AhorrosActivosenunrangodeFecha_spReporteAhorros01AhorrosActivosenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorros activos entre " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesAhorros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Ahorros.rptReportesAhorros.rdlc";
                    break;
                case "02":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteAhorros02AhorrosAnuladosenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteAhorros01AhorrosActivosenunrangodeFecha_spReporteAhorros01AhorrosActivosenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorros anulados entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesAhorros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Ahorros.rptReportesAhorros.rdlc";
                    break;
                case "03":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteAhorros03AhorrosRegistradosenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteAhorros01AhorrosActivosenunrangodeFecha_spReporteAhorros01AhorrosActivosenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorros registrados entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesAhorros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Ahorros.rptReportesAhorros.rdlc";
                    break;
                case "04":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@strCedulaAho", SqlDbType.VarChar);
                    parametro.Value = this.txtCedula.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteAhorros04AhorrosActivosdeunahorradorenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteAhorros01AhorrosActivosenunrangodeFecha_spReporteAhorros01AhorrosActivosenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorros activos de un ahorrador entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesAhorros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Ahorros.rptReportesAhorros.rdlc";
                    break;
                case "05":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@strCedulaAho", SqlDbType.VarChar);
                    parametro.Value = this.txtCedula.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteAhorros05AhorrosAnuladosdeunahorradorenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteAhorros01AhorrosActivosenunrangodeFecha_spReporteAhorros01AhorrosActivosenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorros anulados de un ahorrador entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesAhorros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Ahorros.rptReportesAhorros.rdlc";
                    break;
                case "06":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@strCedulaAho", SqlDbType.VarChar);
                    parametro.Value = this.txtCedula.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteAhorros06AhorrosRegistradosdeunahorradorenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteAhorros01AhorrosActivosenunrangodeFecha_spReporteAhorros01AhorrosActivosenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorros registrados entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());

                    lstParametros.Add(parametroReporte);
                    rptReportesAhorros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Ahorros.rptReportesAhorros.rdlc";
                    break;
                case "08":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteAhorros07AhorrosdeahorradoresporrangodeFecha");

                    datasource = new ReportDataSource("spReporteAhorros07AhorrosdeahorradoresporrangodeFecha_spReporteAhorros07AhorrosdeahorradoresporrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorros de ahorradores entre " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesAhorros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Ahorros.rptAhorrosdeAhorradoresenrangodefechas.rdlc";
                    break;
                case "09":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteAhorros09AhorrosAhorradoresObligatorios");

                    datasource = new ReportDataSource("spReporteAhorros09AhorrosAhorradoresObligatorios_spReporteAhorros09AhorrosAhorradoresObligatorios", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorros Obligatorios entre " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesAhorros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Ahorros.rptAhorrosObligatorios.rdlc";
                    break;
                case "10":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteAhorros10AhorrosAhorradoresObligatoriosAnulados");

                    datasource = new ReportDataSource("spReporteAhorros09AhorrosAhorradoresObligatorios_spReporteAhorros09AhorrosAhorradoresObligatorios", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorros Obligatorios Anulados entre " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesAhorros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Ahorros.rptAhorrosObligatorios.rdlc";
                    break;
            }

            rptReportesAhorros.ProcessingMode = ProcessingMode.Local;
            rptReportesAhorros.LocalReport.DataSources.Clear();
            rptReportesAhorros.LocalReport.DataSources.Add(datasource);
            rptReportesAhorros.LocalReport.SetParameters(lstParametros);
            rptReportesAhorros.LocalReport.Refresh();

            this.rptReportesAhorros.RefreshReport();
        }
    }
}
