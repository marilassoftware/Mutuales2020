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

namespace Mutuales2020.Reportes.AhorrosNavidenos
{
    public partial class FrmAhorradoresNavidenos : Form
    {
        public FrmAhorradoresNavidenos()
        {
            InitializeComponent();
        }

        private void FrmAhorradoresNavidenos_Load(object sender, EventArgs e)
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
                        this.btnGenerarReporte.Focus();
                        break;
                }
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            ReportDataSource datasource = new ReportDataSource();
            DataSet ds = new DataSet();
            List<Microsoft.Reporting.WinForms.ReportParameter> lstParametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter parametroReporte;
            List<SqlParameter> lstParameters = new List<SqlParameter>();

            this.rptReporteAhorradoresNavidenos.Reset();

            switch (this.cboTipoReporte.Text.Substring(0, 2))
            {
                case "01":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteAhorrosNavideños01AhorradoresNavideñosActivos");

                    datasource = new ReportDataSource("spReporteAhorrosNavideños01AhorradoresNavideñosActivos_spReporteAhorrosNavideños01AhorradoresNavideñosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorradores navideños activos");
                    lstParametros.Add(parametroReporte);
                    rptReporteAhorradoresNavidenos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.AhorrosNavidenos.rptReportesAhorradoresNavidenos.rdlc";
                    break;
                case "02":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteAhorrosNavideños02AhorradoresNavideñosLiquidados");

                    datasource = new ReportDataSource("spReporteAhorrosNavideños01AhorradoresNavideñosActivos_spReporteAhorrosNavideños01AhorradoresNavideñosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorradores navideños liquidados");
                    lstParametros.Add(parametroReporte);
                    rptReporteAhorradoresNavidenos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.AhorrosNavidenos.rptReportesAhorradoresNavidenos.rdlc";
                    break;
                case "03":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteAhorrosNavideños03AhorradoresNavideñosAnulados");

                    datasource = new ReportDataSource("spReporteAhorrosNavideños01AhorradoresNavideñosActivos_spReporteAhorrosNavideños01AhorradoresNavideñosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorradores navideños anulados");
                    lstParametros.Add(parametroReporte);
                    rptReporteAhorradoresNavidenos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.AhorrosNavidenos.rptReportesAhorradoresNavidenos.rdlc";
                    break;
                case "04":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteAhorrosNavideños04AhorradoresNavideñosActivosconDeudasenCreditos");

                    datasource = new ReportDataSource("spReporteAhorrosNavideños04AhorradoresNavideñosActivosconDeudasenCreditos_spReporteAhorrosNavideños04AhorradoresNavideñosActivosconDeudasenCreditos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorradores navideños con deudas en créditos");
                    lstParametros.Add(parametroReporte);
                    rptReporteAhorradoresNavidenos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.AhorrosNavidenos.rptReportesAhorradoresNavidenosconprestamos.rdlc";
                    break;
            }

            rptReporteAhorradoresNavidenos.ProcessingMode = ProcessingMode.Local;
            rptReporteAhorradoresNavidenos.LocalReport.DataSources.Clear();
            rptReporteAhorradoresNavidenos.LocalReport.DataSources.Add(datasource);
            rptReporteAhorradoresNavidenos.LocalReport.SetParameters(lstParametros);
            rptReporteAhorradoresNavidenos.LocalReport.Refresh();

            this.rptReporteAhorradoresNavidenos.RefreshReport();
        }
    }
}
