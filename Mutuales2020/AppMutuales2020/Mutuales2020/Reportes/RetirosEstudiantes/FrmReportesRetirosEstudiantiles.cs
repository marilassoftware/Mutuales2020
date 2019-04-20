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

namespace Mutuales2020.Reportes.RetirosEstudiantes
{
    public partial class FrmReportesRetirosEstudiantiles : Form
    {
        public FrmReportesRetirosEstudiantiles()
        {
            InitializeComponent();
        }

        private void FrmReportesRetirosEstudiantiles_Load(object sender, EventArgs e)
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

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteRetiroEstudiantiles01RetirosActivosenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteRetiros01RetirosActivosenunrangodeFecha_spReporteRetiros01RetirosActivosenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de retiros estudiantiles activos entre " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesAhorros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Retiros.rptReportesRetiros.rdlc";
                    break;
                case "02":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteRetiroEstudiantiles02RetiroAnuladosenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteRetiros01RetirosActivosenunrangodeFecha_spReporteRetiros01RetirosActivosenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de retiros estudiantiles anulados entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesAhorros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Retiros.rptReportesRetiros.rdlc";
                    break;
                case "03":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteRetiroEstudiantiles03RetiroRegistradosenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteRetiros01RetirosActivosenunrangodeFecha_spReporteRetiros01RetirosActivosenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de retiros estudiantiles registrados entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesAhorros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Retiros.rptReportesRetiros.rdlc";
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

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteRetiroEstudiantiles04RetiroActivosdeunahorradorenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteRetiros01RetirosActivosenunrangodeFecha_spReporteRetiros01RetirosActivosenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de retiros estudiantiles activos de un ahorrador entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesAhorros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Retiros.rptReportesRetiros.rdlc";
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

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteRetiroEstudiantiles05RetiroAnuladosdeunahorradorenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteRetiros01RetirosActivosenunrangodeFecha_spReporteRetiros01RetirosActivosenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de retiros estudiantiles anulados de un ahorrador entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesAhorros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Retiros.rptReportesRetiros.rdlc";
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

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteRetiroEstudiantiles06RetirosRegistradosdeunahorradorenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteRetiros01RetirosActivosenunrangodeFecha_spReporteRetiros01RetirosActivosenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de retiros estudiantiles registrados de un ahorrador entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());

                    lstParametros.Add(parametroReporte);
                    rptReportesAhorros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Retiros.rptReportesRetiros.rdlc";
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
