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

namespace Mutuales2020.Reportes.AhorrosNatilleraEscolar
{
    public partial class FrmAhorradoresNatilleraEscolar : Form
    {
        public FrmAhorradoresNatilleraEscolar()
        {
            InitializeComponent();
        }

        private void FrmAhorradoresNatilleraEscolar_Load(object sender, EventArgs e)
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

            this.rptReporteAhorradoresNatilleraEscolar.Reset();

            switch (this.cboTipoReporte.Text.Substring(0, 2))
            {
                case "01":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteAhorrosNatilleraEscolar01AhorradoresNatilleraEscolarActivos");

                    datasource = new ReportDataSource("spReporteAhorrosNavideños01AhorradoresNavideñosActivos_spReporteAhorrosNavideños01AhorradoresNavideñosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorradores escolares activos");
                    lstParametros.Add(parametroReporte);
                    rptReporteAhorradoresNatilleraEscolar.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.AhorrosNavidenos.rptReportesAhorradoresNavidenos.rdlc";
                    break;
                case "02":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteAhorrosNatilleraEscolar02AhorradoresNatilleraEscolarLiquidados");

                    datasource = new ReportDataSource("spReporteAhorrosNavideños01AhorradoresNavideñosActivos_spReporteAhorrosNavideños01AhorradoresNavideñosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorradores escolares liquidados");
                    lstParametros.Add(parametroReporte);
                    rptReporteAhorradoresNatilleraEscolar.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.AhorrosNavidenos.rptReportesAhorradoresNavidenos.rdlc";
                    break;
                case "03":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteAhorrosNatilleraEscolar03AhorradoresNatilleraEscolarAnulados");

                    datasource = new ReportDataSource("spReporteAhorrosNavideños01AhorradoresNavideñosActivos_spReporteAhorrosNavideños01AhorradoresNavideñosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorradores escolares anulados");
                    lstParametros.Add(parametroReporte);
                    rptReporteAhorradoresNatilleraEscolar.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.AhorrosNavidenos.rptReportesAhorradoresNavidenos.rdlc";
                    break;
                case "04":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteAhorrosNatilleraEscolar04AhorradoresNatilleraEscolarActivosconDeudasenCreditos");

                    datasource = new ReportDataSource("spReporteAhorrosNavideños04AhorradoresNavideñosActivosconDeudasenCreditos_spReporteAhorrosNavideños04AhorradoresNavideñosActivosconDeudasenCreditos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorradores escolares con deudas en créditos");
                    lstParametros.Add(parametroReporte);
                    rptReporteAhorradoresNatilleraEscolar.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.AhorrosNavidenos.rptReportesAhorradoresNavidenosconprestamos.rdlc";
                    break;
            }

            rptReporteAhorradoresNatilleraEscolar.ProcessingMode = ProcessingMode.Local;
            rptReporteAhorradoresNatilleraEscolar.LocalReport.DataSources.Clear();
            rptReporteAhorradoresNatilleraEscolar.LocalReport.DataSources.Add(datasource);
            rptReporteAhorradoresNatilleraEscolar.LocalReport.SetParameters(lstParametros);
            rptReporteAhorradoresNatilleraEscolar.LocalReport.Refresh();

            this.rptReporteAhorradoresNatilleraEscolar.RefreshReport();
        }
    }
}
