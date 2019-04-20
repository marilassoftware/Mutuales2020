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

namespace Mutuales2020.Reportes.Fallecidos
{
    public partial class FrmReporteFallecidos : Form
    {
        public FrmReporteFallecidos()
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
                        this.btnGenerarReporte.Focus();
                        break;
                    case "02":
                        this.dtmFechaInicial.Focus();
                        break;
                    case "03":
                        this.txtSocio.Focus();
                        break;
                }
            }
        }

        private void txtSocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.btnGenerarReporte.Focus();
        }

        private void dtmFechaInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.dtmFechaFinal.Focus();
        }

        private void dtmFechaFinal_KeyPress(object sender, KeyPressEventArgs e)
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

            switch (this.cboTipoReporte.Text.Substring(0, 2))
            {
                case "01":
                    ds = propiedades.ejecutarSp(lstParameters, "spReporteFallecidos01FallecidosRegistrados");

                    datasource = new ReportDataSource("spReporteFallecidos01FallecidosRegistrados_spReporteFallecidos01FallecidosRegistrados", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de fallecidos Registrados ");
                    lstParametros.Add(parametroReporte);
                    rptReportesFallecidos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Fallecidos.rptReportesFallecidos.rdlc";
                    break;
                case "02":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteFallecidos02FallecidosRegistradosenunrangodefecha");

                    datasource = new ReportDataSource("spReporteFallecidos01FallecidosRegistrados_spReporteFallecidos01FallecidosRegistrados", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de fallecidos Registrados entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesFallecidos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Fallecidos.rptReportesFallecidos.rdlc";
                    break;
                case "03":
                    parametro = new SqlParameter("@intCodigoSoc", SqlDbType.Int);
                    parametro.Value = this.txtSocio.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteFallecidos03FallecidosRegistradosaunsocio");

                    datasource = new ReportDataSource("spReporteFallecidos01FallecidosRegistrados_spReporteFallecidos01FallecidosRegistrados", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de Fallecidos registrados por socio ");
                    lstParametros.Add(parametroReporte);
                    rptReportesFallecidos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Fallecidos.rptReportesFallecidos.rdlc";
                    break;
            }

            rptReportesFallecidos.ProcessingMode = ProcessingMode.Local;
            rptReportesFallecidos.LocalReport.DataSources.Clear();
            rptReportesFallecidos.LocalReport.DataSources.Add(datasource);
            rptReportesFallecidos.LocalReport.SetParameters(lstParametros);
            rptReportesFallecidos.LocalReport.Refresh();

            this.rptReportesFallecidos.RefreshReport();
        }
    }
}
