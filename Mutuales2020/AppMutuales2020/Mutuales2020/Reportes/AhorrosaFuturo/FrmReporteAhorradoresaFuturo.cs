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

namespace Mutuales2020.Reportes.AhorrosaFuturo
{
    public partial class FrmReporteAhorradoresaFuturo : Form
    {
        public FrmReporteAhorradoresaFuturo()
        {
            InitializeComponent();
        }

        private void FrmReporteAhorradoresaFuturo_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            ReportDataSource datasource = new ReportDataSource();
            DataSet ds = new DataSet();
            List<Microsoft.Reporting.WinForms.ReportParameter> lstParametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter parametroReporte;
            List<SqlParameter> lstParameters = new List<SqlParameter>();

            this.rptReporteAhorradoresaFuturo.Reset();

            switch (this.cboTipoReporte.Text.Substring(0, 2))
            {
                case "01":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteAhorrosaFuturo01AhorradoresaFuturoActivos");

                    datasource = new ReportDataSource("spReporteAhorrosaFuturo01AhorradoresaFuturoActivos_spReporteAhorrosaFuturo01AhorradoresaFuturoActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorradores a futuro activos");
                    lstParametros.Add(parametroReporte);

                    break;
                case "02":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteAhorrosaFuturo02AhorradoresaFuturoLiquidados");

                    datasource = new ReportDataSource("spReporteAhorrosaFuturo01AhorradoresaFuturoActivos_spReporteAhorrosaFuturo01AhorradoresaFuturoActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorradores a futuro liquidados");
                    lstParametros.Add(parametroReporte);

                    break;
                case "03":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteAhorrosaFuturo03AhorradoresaFuturoAnulados");

                    datasource = new ReportDataSource("spReporteAhorrosaFuturo01AhorradoresaFuturoActivos_spReporteAhorrosaFuturo01AhorradoresaFuturoActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorradores a futuro anulados");
                    lstParametros.Add(parametroReporte);

                    break;
            }

            rptReporteAhorradoresaFuturo.ProcessingMode = ProcessingMode.Local;
            rptReporteAhorradoresaFuturo.LocalReport.DataSources.Clear();
            rptReporteAhorradoresaFuturo.LocalReport.DataSources.Add(datasource);
            rptReporteAhorradoresaFuturo.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.AhorrosaFuturo.rptAhorradoresaFuturo.rdlc";
            rptReporteAhorradoresaFuturo.LocalReport.SetParameters(lstParametros);
            rptReporteAhorradoresaFuturo.LocalReport.Refresh();

            this.rptReporteAhorradoresaFuturo.RefreshReport();
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
                        this.btnGenerarReporte.Focus();
                        break;
                }
            }
        }
    }
}
