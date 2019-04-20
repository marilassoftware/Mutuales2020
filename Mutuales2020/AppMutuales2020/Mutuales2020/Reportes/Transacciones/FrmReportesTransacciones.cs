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

namespace Mutuales2020.Reportes.Transacciones
{
    public partial class FrmReportesTransacciones : Form
    {
        public FrmReportesTransacciones()
        {
            InitializeComponent();
        }

        private void FrmReportesTransacciones_Load(object sender, EventArgs e)
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

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteTransacciones01TransaccionesActivasenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteTransacciones01TransaccionesActivasenunrangodeFecha_spReporteTransacciones01TransaccionesActivasenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de transacciones activas entre " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesRetiros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Transacciones.rptReporteTransacciones.rdlc";
                    break;
                case "02":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteTransacciones02TransaccionesAnualdasenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteTransacciones01TransaccionesActivasenunrangodeFecha_spReporteTransacciones01TransaccionesActivasenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de transacciones anuladas entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesRetiros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Transacciones.rptReporteTransacciones.rdlc";
                    break;
                case "03":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteTransacciones03TransaccionesRegistradasenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteTransacciones01TransaccionesActivasenunrangodeFecha_spReporteTransacciones01TransaccionesActivasenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de transacciones registradas entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesRetiros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Transacciones.rptReporteTransacciones.rdlc";
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

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteTransacciones04TransaccionesActivasdeunahorradorenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteTransacciones01TransaccionesActivasenunrangodeFecha_spReporteTransacciones01TransaccionesActivasenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de transacciones activas de un ahorrador entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesRetiros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Transacciones.rptReporteTransacciones.rdlc";
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

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteTransacciones05TransaccionesAnuladasdeunahorradorenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteTransacciones01TransaccionesActivasenunrangodeFecha_spReporteTransacciones01TransaccionesActivasenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de transacciones anuladas de un ahorrador entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesRetiros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Transacciones.rptReporteTransacciones.rdlc";
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

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteTransacciones06TransaccionesRegistradasdeunahorradorenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteTransacciones01TransaccionesActivasenunrangodeFecha_spReporteTransacciones01TransaccionesActivasenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de transacciones registradas entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());

                    lstParametros.Add(parametroReporte);
                    rptReportesRetiros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Transacciones.rptReporteTransacciones.rdlc";
                    break;
                case "07":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteTransaccionesEstudiantiles07TransaccionesEstudiantilesActivasenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteTransacciones01TransaccionesActivasenunrangodeFecha_spReporteTransacciones01TransaccionesActivasenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de transacciones Estudiantiles activas entre " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesRetiros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Transacciones.rptReporteTransacciones.rdlc";
                    break;
                case "08":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteTransaccionesEstudiantiles08TransaccionesEstudiantilesAnualdasenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteTransacciones01TransaccionesActivasenunrangodeFecha_spReporteTransacciones01TransaccionesActivasenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de transacciones Estudiantiles anuladas entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesRetiros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Transacciones.rptReporteTransacciones.rdlc";
                    break;
                case "09":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteTransaccionesEstudiantiles09TransaccionesEstudiantilesRegistradasenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteTransacciones01TransaccionesActivasenunrangodeFecha_spReporteTransacciones01TransaccionesActivasenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de transacciones Estudiantiles registradas entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesRetiros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Transacciones.rptReporteTransacciones.rdlc";
                    break;
                case "10":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@strCedulaAho", SqlDbType.VarChar);
                    parametro.Value = this.txtCedula.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteTransaccionesEstudiantiles10TransaccionesEstudiantilesActivasdeunahorradorenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteTransacciones01TransaccionesActivasenunrangodeFecha_spReporteTransacciones01TransaccionesActivasenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de transacciones Estudiantiles activas de un ahorrador entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesRetiros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Transacciones.rptReporteTransacciones.rdlc";
                    break;
                case "11":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@strCedulaAho", SqlDbType.VarChar);
                    parametro.Value = this.txtCedula.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteTransaccionesEstudiantiles11TransaccionesEstudiantilesAnuladasdeunahorradorenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteTransacciones01TransaccionesActivasenunrangodeFecha_spReporteTransacciones01TransaccionesActivasenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de transacciones Estudiantiles anuladas de un ahorrador entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesRetiros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Transacciones.rptReporteTransacciones.rdlc";
                    break;
                case "12":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@strCedulaAho", SqlDbType.VarChar);
                    parametro.Value = this.txtCedula.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteTransaccionesEstudiantiles12TransaccionesEstudiantilesRegistradasdeunahorradorenunrangodeFecha");

                    datasource = new ReportDataSource("spReporteTransacciones01TransaccionesActivasenunrangodeFecha_spReporteTransacciones01TransaccionesActivasenunrangodeFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de transacciones Estudiantiles registradas entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());

                    lstParametros.Add(parametroReporte);
                    rptReportesRetiros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Transacciones.rptReporteTransacciones.rdlc";
                    break;
            }

            rptReportesRetiros.ProcessingMode = ProcessingMode.Local;
            rptReportesRetiros.LocalReport.DataSources.Clear();
            rptReportesRetiros.LocalReport.DataSources.Add(datasource);
            rptReportesRetiros.LocalReport.SetParameters(lstParametros);
            rptReportesRetiros.LocalReport.Refresh();

            this.rptReportesRetiros.RefreshReport();
        }
    }
}
