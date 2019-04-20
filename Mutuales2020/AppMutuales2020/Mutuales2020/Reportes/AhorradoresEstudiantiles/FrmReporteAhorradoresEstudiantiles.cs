using libMutuales2020.dominio;
using libMutuales2020.logica;
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

namespace Mutuales2020.Reportes.AhorradoresEstudiantiles
{
    public partial class FrmReporteAhorradoresEstudiantiles : Form
    {
        public FrmReporteAhorradoresEstudiantiles()
        {
            InitializeComponent();
        }

        private void FrmReporteAhorradoresEstudiantiles_Load(object sender, EventArgs e)
        {
            this.cboBarrios.DataSource = new blBarrio().gmtdConsultar();
            this.cboTipoReporte.SelectedIndex = 0;

            this.rptReporteAhorradores.RefreshReport();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            ReportDataSource datasource = new ReportDataSource();
            DataSet ds = new DataSet();
            List<Microsoft.Reporting.WinForms.ReportParameter> lstParametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter parametroReporte;
            List<SqlParameter> lstParameters = new List<SqlParameter>();
            SqlParameter parametro;

            this.rptReporteAhorradores.Reset();

            switch (this.cboTipoReporte.Text.Substring(0, 2))
            {
                case "01":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteAhorradoresEstudiantiles01AhorradoresActivos");

                    datasource = new ReportDataSource("spReporteAhorradores03AhorradoresRegistrados_spReporteAhorradores03AhorradoresRegistrados", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorradores activos");
                    lstParametros.Add(parametroReporte);

                    break;
                case "02":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteAhorradoresEstudiantiles02AhorradoresAnulados");

                    datasource = new ReportDataSource("spReporteAhorradores03AhorradoresRegistrados_spReporteAhorradores03AhorradoresRegistrados", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorradores anulados");
                    lstParametros.Add(parametroReporte);

                    break;
                case "03":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteAhorradoresEstudiantiles03AhorradoresRegistrados");

                    datasource = new ReportDataSource("spReporteAhorradores03AhorradoresRegistrados_spReporteAhorradores03AhorradoresRegistrados", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorradores registrados");
                    lstParametros.Add(parametroReporte);

                    break;
                case "04":

                    parametro = new SqlParameter("@strCodigoBar", SqlDbType.VarChar);
                    parametro.Value = this.cboBarrios.SelectedValue.ToString();
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteAhorradoresEstudiantiles04AhorradoresxBarrio");

                    datasource = new ReportDataSource("spReporteAhorradores03AhorradoresRegistrados_spReporteAhorradores03AhorradoresRegistrados", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorradores del barrio " + this.cboBarrios.Text);

                    lstParametros.Add(parametroReporte);

                    break;
                case "05":
                    parametro = new SqlParameter("@bitSexo", SqlDbType.Bit);
                    parametro.Value = this.chkSexo.Checked;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteAhorradoresEstudiantiles05AhorradoresxSexo");

                    datasource = new ReportDataSource("spReporteAhorradores03AhorradoresRegistrados_spReporteAhorradores03AhorradoresRegistrados", ds.Tables[0]);

                    if (this.chkSexo.Checked)
                        parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorradores del sexo maculino");
                    else
                        parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorradores del sexo femenino");

                    lstParametros.Add(parametroReporte);

                    break;
                case "06":
                    parametro = new SqlParameter("@intCodigoSoc", SqlDbType.Int);
                    parametro.Value = this.txtSocio.Text;
                    lstParameters.Add(parametro);
                    ds = propiedades.ejecutarSp(lstParameters, "spReporteAhorradoresEstudiantiles06AhorradoresxSocio");

                    datasource = new ReportDataSource("spReporteAhorradores03AhorradoresRegistrados_spReporteAhorradores03AhorradoresRegistrados", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorradores del socio " + this.txtSocio.Text);
                    lstParametros.Add(parametroReporte);

                    break;
                case "07":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Text;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteAhorradoresEstudiantiles07Ahorradoresregistradosenunrangodefecha");

                    datasource = new ReportDataSource("spReporteAhorradores03AhorradoresRegistrados_spReporteAhorradores03AhorradoresRegistrados", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorradores registrados entre " + this.dtmFechaInicial.Text + " y " + this.dtmFechaFinal.Text);

                    lstParametros.Add(parametroReporte);

                    break;
                case "08":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Text;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteAhorradoresEstudiantiles08Ahorradoresanuladosenunrangodefecha");

                    datasource = new ReportDataSource("spReporteAhorradores03AhorradoresRegistrados_spReporteAhorradores03AhorradoresRegistrados", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorradores anulados entre " + this.dtmFechaInicial.Text + " y " + this.dtmFechaFinal.Text);

                    lstParametros.Add(parametroReporte);

                    break;
                case "09":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Text;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteAhorradoresEstudiantiles09Ahorradoresnacidosentre2fechas");

                    datasource = new ReportDataSource("spReporteAhorradores03AhorradoresRegistrados_spReporteAhorradores03AhorradoresRegistrados", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorradores nacidos entre " + this.dtmFechaInicial.Value.Year.ToString() + "-" + this.dtmFechaInicial.Value.Month.ToString() + " y " + this.dtmFechaFinal.Value.Year.ToString() + "-" + this.dtmFechaFinal.Value.Month.ToString());

                    lstParametros.Add(parametroReporte);

                    break;
                case "10":

                    parametro = new SqlParameter("@intEdadIni", SqlDbType.Int);
                    parametro.Value = this.txtEdadInicial.Text;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@intEdadFin", SqlDbType.Int);
                    parametro.Value = this.txtEdadFinal.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteAhorradoresEstudiantiles10Ahorradoresentredeterminadaedad");

                    datasource = new ReportDataSource("spReporteAhorradores03AhorradoresRegistrados_spReporteAhorradores03AhorradoresRegistrados", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorradores entre " + this.txtEdadInicial.Text + " y " + this.txtEdadFinal.Text);

                    lstParametros.Add(parametroReporte);

                    break;
                case "11":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteAhorradoresEstudiantiles11Ahorradoresquetienenprestamosactivos");

                    datasource = new ReportDataSource("spReporteAhorradores03AhorradoresRegistrados_spReporteAhorradores03AhorradoresRegistrados", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorradores con préstamos activos ");

                    lstParametros.Add(parametroReporte);

                    break;
                case "12":
                    ds = propiedades.ejecutarSp(lstParameters, "spReporteAhorradoresEstudiantiles12Ahorradoresquenosonsocios");

                    datasource = new ReportDataSource("spReporteAhorradores03AhorradoresRegistrados_spReporteAhorradores03AhorradoresRegistrados", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorradores que no son socios ");

                    lstParametros.Add(parametroReporte);

                    break;
                case "13":
                    ds = propiedades.ejecutarSp(lstParameters, "spReporteAhorradoresEstudiantiles13Ahorradoresquesonsocios");

                    datasource = new ReportDataSource("spReporteAhorradores03AhorradoresRegistrados_spReporteAhorradores03AhorradoresRegistrados", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de ahorradores que son socios ");

                    lstParametros.Add(parametroReporte);

                    break;
            }

            rptReporteAhorradores.ProcessingMode = ProcessingMode.Local;
            rptReporteAhorradores.LocalReport.DataSources.Clear();
            rptReporteAhorradores.LocalReport.DataSources.Add(datasource);
            rptReporteAhorradores.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Ahorradores.rptAhorradores.rdlc";
            rptReporteAhorradores.LocalReport.SetParameters(lstParametros);
            rptReporteAhorradores.LocalReport.Refresh();

            this.rptReporteAhorradores.RefreshReport();
        }
    }
}
