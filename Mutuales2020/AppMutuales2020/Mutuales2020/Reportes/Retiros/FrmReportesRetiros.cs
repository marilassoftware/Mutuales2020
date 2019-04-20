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

namespace Mutuales2020.Reportes.Retiros
{
    public partial class FrmReportesRetiros : Form
    {
        public FrmReportesRetiros()
        {
            InitializeComponent();
        }

        private void FrmReportesRetiros_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            ReportDataSource datasource = new ReportDataSource();
            DataSet ds = new DataSet();
            List<Microsoft.Reporting.WinForms.ReportParameter> lstParametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter parametroReporte;
            List<SqlParameter> lstParameters = new List<SqlParameter>();
            SqlParameter parametro;

            this.rptReportesRetiros.Reset();

            switch (this.cboTipoReporte.Text.Substring(0, 2))
            {
                case "01":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteRetiros01RetirosActivosenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteRetiros01RetirosActivosenunrangodeFecha_spReporteRetiros01RetirosActivosenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de Retiros activos entre " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesRetiros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Retiros.rptReportesRetiros.rdlc";
                    break;
                case "02":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteRetiros02RetirosAnuladosenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteRetiros01RetirosActivosenunrangodeFecha_spReporteRetiros01RetirosActivosenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de Retiros anulados entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesRetiros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Retiros.rptReportesRetiros.rdlc";
                    break;
                case "03":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteRetiros03RetirosRegistradosenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteRetiros01RetirosActivosenunrangodeFecha_spReporteRetiros01RetirosActivosenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de Retiros registrados entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesRetiros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Retiros.rptReportesRetiros.rdlc";
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

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteRetiros04RetirosActivosdeunahorradorenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteRetiros01RetirosActivosenunrangodeFecha_spReporteRetiros01RetirosActivosenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de Retiros activos de un ahorrador entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesRetiros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Retiros.rptReportesRetiros.rdlc";
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

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteRetiros05RetirosAnuladosdeunahorradorenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteRetiros01RetirosActivosenunrangodeFecha_spReporteRetiros01RetirosActivosenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de Retiros anulados de un ahorrador entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesRetiros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Retiros.rptReportesRetiros.rdlc";
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

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteRetiros06RetirosRegistradosdeunahorradorenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteRetiros01RetirosActivosenunrangodeFecha_spReporteRetiros01RetirosActivosenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de Retiros registrados entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());

                    lstParametros.Add(parametroReporte);
                    rptReportesRetiros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Retiros.rptReportesRetiros.rdlc";
                    break;
            }

            rptReportesRetiros.ProcessingMode = ProcessingMode.Local;
            rptReportesRetiros.LocalReport.DataSources.Clear();
            rptReportesRetiros.LocalReport.DataSources.Add(datasource);
            rptReportesRetiros.LocalReport.SetParameters(lstParametros);
            rptReportesRetiros.LocalReport.Refresh();

            this.rptReportesRetiros.RefreshReport();
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
                        this.dtmFechaInicial.Focus();
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
    }
}
