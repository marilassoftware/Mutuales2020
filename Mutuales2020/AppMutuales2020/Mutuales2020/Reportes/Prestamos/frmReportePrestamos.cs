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

namespace Mutuales2020.Reportes.Prestamos
{
    public partial class frmReportePrestamos : Form
    {
        public frmReportePrestamos()
        {
            InitializeComponent();
        }

        private void frmReportePrestamos_Load(object sender, EventArgs e)
        {
            this.rptReportesPrestamos.RefreshReport();
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
                    case "09":
                    case "13":
                        this.btnGenrarInforme.Focus();
                        break;
                    case "04":
                    case "07":
                        this.txtCedula.Focus();
                        break;
                    case "05":
                    case "06":
                    case "08":
                    case "11":
                    case "12":
                        this.dtmFechaInicial.Focus();
                        break;
                }
            }
        }

        private void btnGenrarInforme_Click(object sender, EventArgs e)
        {
            ReportDataSource datasource = new ReportDataSource();
            DataSet ds = new DataSet();
            List<Microsoft.Reporting.WinForms.ReportParameter> lstParametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter parametroReporte;
            List<SqlParameter> lstParameters = new List<SqlParameter>();
            SqlParameter parametro;

            this.rptReportesPrestamos.Reset();

            switch (this.cboTipoReporte.Text.Substring(0, 2))
            {
                case "01":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteCredito01CreditosActivos");

                    datasource = new ReportDataSource("creditos_spReporteCredito01CreditosRegistrados", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de créditos activos");
                    lstParametros.Add(parametroReporte);
                    rptReportesPrestamos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Prestamos.rptCreditos.rdlc";
                    break;
                case "02":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteCredito02CreditosAnulados");

                    datasource = new ReportDataSource("creditos_spReporteCredito01CreditosRegistrados", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de créditos anulados");
                    lstParametros.Add(parametroReporte);
                    rptReportesPrestamos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Prestamos.rptCreditos.rdlc";
                    break;
                case "03":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteCredito03CreditosRegistrados");

                    datasource = new ReportDataSource("creditos_spReporteCredito01CreditosRegistrados", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de créditos registrados");
                    lstParametros.Add(parametroReporte);
                    rptReportesPrestamos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Prestamos.rptCreditos.rdlc";
                    break;
                case "04":
                    parametro = new SqlParameter("@strCedulaCre", SqlDbType.VarChar);
                    parametro.Value = this.txtCedula.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteCredito04CreditosRegistradosxPersona");

                    datasource = new ReportDataSource("creditos_spReporteCredito01CreditosRegistrados", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de créditos registrados a la cédula " + this.txtCedula.Text);
                    lstParametros.Add(parametroReporte);
                    rptReportesPrestamos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Prestamos.rptCreditos.rdlc";
                    break;
                case "05":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteCredito05CreditosRegistradosenunrangodefecha");

                    datasource = new ReportDataSource("creditos_spReporteCredito01CreditosRegistrados", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de creditos Registrados entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesPrestamos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Prestamos.rptCreditos.rdlc";
                    break;
                case "06":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteCredito06CreditosRegistradosDetalladosenunrangodefecha");

                    datasource = new ReportDataSource("spReporteCredito06CreditosRegistradosDetalladosenunrangodefecha_spReporteCredito06CreditosRegistradosDetalladosenunrangodefecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de creditos detallados registrados entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesPrestamos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Prestamos.rptCreditosDetallados.rdlc";
                    break;
                case "07":
                    parametro = new SqlParameter("@strCedulaPre", SqlDbType.VarChar);
                    parametro.Value = this.txtCedula.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteCredito07CreditosRegistradosDetalladosaunapersona");

                    datasource = new ReportDataSource("spReporteCredito06CreditosRegistradosDetalladosenunrangodefecha_spReporteCredito06CreditosRegistradosDetalladosenunrangodefecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de creditos detallados registrados a una persona ");
                    lstParametros.Add(parametroReporte);
                    rptReportesPrestamos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Prestamos.rptCreditosDetallados.rdlc";
                    break;
                case "08":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteCredito08CreditosPagadosDetalladosenunrangodefecha");

                    datasource = new ReportDataSource("spReporteCredito06CreditosRegistradosDetalladosenunrangodefecha_spReporteCredito06CreditosRegistradosDetalladosenunrangodefecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de creditos detallados cancelados entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesPrestamos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Prestamos.rptCreditosDetallados.rdlc";
                    break;
                case "09":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteCredito09Carravencidaporedades");

                    datasource = new ReportDataSource("spReporteCredito09Carravencidaporedades_spReporteCredito09Carravencidaporedades", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de cartera vencida por edades. ");
                    lstParametros.Add(parametroReporte);
                    rptReportesPrestamos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Prestamos.rptCarteraVencidaxEdades.rdlc";
                    break;
                case "10":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteCredito10Informeparalaequidad");

                    datasource = new ReportDataSource("spReporteCredito10Informeparalaequidad_spReporteCredito10Informeparalaequidad", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Informe para la equidad");
                    lstParametros.Add(parametroReporte);
                    rptReportesPrestamos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Prestamos.rptCreditosparalaequidad.rdlc";
                    break;
                case "11":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteCredito01CreditosActivos");

                    datasource = new ReportDataSource("creditos_spReporteCredito01CreditosRegistrados", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de creditos detallados registrados entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesPrestamos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Prestamos.rptCreditosxLineasdeCredito.rdlc";
                    break;
                case "12":
                    parametro = new SqlParameter("@dtmFecha", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteCredito12CreditosDebehastadeterminadaFecha");

                    datasource = new ReportDataSource("spReporteCredito12CreditosDebehastadeterminadaFecha_spReporteCredito12CreditosDebehastadeterminadaFecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de deuda de creditos hasta el " + this.dtmFechaInicial.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesPrestamos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Prestamos.rptCreditosDeudasaFecha.rdlc";
                    break;
                case "13":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteCredito13CreditosconAbobosaPrestamo");

                    datasource = new ReportDataSource("spReporteCredito13CreditosconAbobosaPrestamo_spReporteCredito13CreditosconAbobosaPrestamo", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de créditos con abonos");
                    lstParametros.Add(parametroReporte);
                    rptReportesPrestamos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Prestamos.rptCreditosconAbono.rdlc";
                    break;
            }

            rptReportesPrestamos.ProcessingMode = ProcessingMode.Local;
            rptReportesPrestamos.LocalReport.DataSources.Clear();
            rptReportesPrestamos.LocalReport.DataSources.Add(datasource);
            rptReportesPrestamos.LocalReport.SetParameters(lstParametros);
            rptReportesPrestamos.LocalReport.Refresh();

            this.rptReportesPrestamos.RefreshReport();
        }
    }
}
