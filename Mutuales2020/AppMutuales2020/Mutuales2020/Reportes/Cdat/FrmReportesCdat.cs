using libMutuales2020.dominio;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mutuales2020.Reportes.Cdat
{
    public partial class FrmReportesCdat : Form
    {
        public FrmReportesCdat()
        {
            InitializeComponent();
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
                        this.btnGenerarReporte.Focus();
                        break;
                    case "05":
                        this.txtCedula.Focus();
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

            this.rptReportesCdta.Reset();

            switch (this.cboTipoReporte.Text.Substring(0, 2))
            {
                case "01":
                    ds = propiedades.ejecutarSp(lstParameters, "spReporteCdat01CdatActivos");

                    datasource = new ReportDataSource("spReporteCdat01CdatActivos_spReporteCdat01CdatActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de CDAT activos ");
                    lstParametros.Add(parametroReporte);
                    rptReportesCdta.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Cdat.rptReportesCdat.rdlc";
                    break;
                case "02":
                    ds = propiedades.ejecutarSp(lstParameters, "spReporteCdat02CdatAnulados");

                    datasource = new ReportDataSource("spReporteCdat01CdatActivos_spReporteCdat01CdatActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de CDAT anulados ");
                    lstParametros.Add(parametroReporte);
                    rptReportesCdta.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Cdat.rptReportesCdat.rdlc";
                    break;
                case "03":
                    ds = propiedades.ejecutarSp(lstParameters, "spReporteCdat03CdatLiquidados");

                    datasource = new ReportDataSource("spReporteCdat01CdatActivos_spReporteCdat01CdatActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de CDAT liquidados ");
                    lstParametros.Add(parametroReporte);
                    rptReportesCdta.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Cdat.rptReportesCdat.rdlc";
                    break;
                case "04":
                    ds = propiedades.ejecutarSp(lstParameters, "spReporteCdat04CdatRegistrados");

                    datasource = new ReportDataSource("spReporteCdat01CdatActivos_spReporteCdat01CdatActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de CDAT registrados ");
                    lstParametros.Add(parametroReporte);
                    rptReportesCdta.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Cdat.rptReportesCdat.rdlc";
                    break;
                case "05":
                    parametro = new SqlParameter("@strCedulaAho", SqlDbType.VarChar);
                    parametro.Value = this.txtCedula.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteCdat05CdatRegistradosxAhorrador");

                    datasource = new ReportDataSource("spReporteCdat01CdatActivos_spReporteCdat01CdatActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de CDAT registrados por ahorrador ");
                    lstParametros.Add(parametroReporte);
                    rptReportesCdta.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Cdat.rptReportesCdat.rdlc";
                    break;
            }

            rptReportesCdta.ProcessingMode = ProcessingMode.Local;
            rptReportesCdta.LocalReport.DataSources.Clear();
            rptReportesCdta.LocalReport.DataSources.Add(datasource);
            rptReportesCdta.LocalReport.SetParameters(lstParametros);
            rptReportesCdta.LocalReport.Refresh();

            this.rptReportesCdta.RefreshReport();
        }
    }
}
