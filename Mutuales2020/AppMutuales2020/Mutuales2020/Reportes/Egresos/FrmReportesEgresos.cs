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

namespace Mutuales2020.Reportes.Egresos
{
    public partial class FrmReportesEgresos : Form
    {
        public FrmReportesEgresos()
        {
            InitializeComponent();
        }

        private void FrmReportesEgresos_Load(object sender, EventArgs e)
        {
            this.cboOtrosIngresos.DataSource = new blOtroEgreso().gmtdConsultarTodos();
            this.rptReportesEgresos.RefreshReport();
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
                    case "07":
                    case "08":
                    case "09":
                    case "10":
                    case "11":
                    case "12":
                    case "13":
                        this.dtmFechaInicial.Focus();
                        break;
                }
            }
        }

        private void dtmFechaInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                switch (this.cboTipoReporte.Text.Substring(0, 2))
                {
                    case "13":
                        this.btnGenerarReporte.Focus();
                        break;
                    default:
                        this.dtmFechaFinal.Focus();
                        break;
                }
            }
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
                    case "07":
                    case "08":
                    case "09":
                        this.btnGenerarReporte.Focus();
                        break;
                    case "04":
                    case "05":
                    case "06":
                    case "10":
                    case "11":
                    case "12":
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

            this.rptReportesEgresos.Reset();

            switch (this.cboTipoReporte.Text.Substring(0, 2))
            {
                case "01":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteEgresos01EgresosActivosenunRangodefecha");

                    datasource = new ReportDataSource("spReporteEgresos01EgresosActivosenunRangodefecha_spReporteEgresos01EgresosActivosenunRangodefecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de egresos activos entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesEgresos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Egresos.rptReporteEgresos.rdlc";
                    break;
                case "02":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteEgresos02EgresosAnuladosenunRangodefecha");

                    datasource = new ReportDataSource("spReporteEgresos01EgresosActivosenunRangodefecha_spReporteEgresos01EgresosActivosenunRangodefecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de egresos anulados entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesEgresos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Egresos.rptReporteEgresos.rdlc";
                    break;
                case "03":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteEgresos03EgresosRegistradossenunRangodefecha");

                    datasource = new ReportDataSource("spReporteEgresos01EgresosActivosenunRangodefecha_spReporteEgresos01EgresosActivosenunRangodefecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de egresos registrados entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesEgresos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Egresos.rptReporteEgresos.rdlc";
                    break;
                case "04":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@strCedulaCli", SqlDbType.VarChar);
                    parametro.Value = this.txtCedula.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteEgresos04EgresosRegistradossenunRangodefechaxCliente");

                    datasource = new ReportDataSource("spReporteEgresos01EgresosActivosenunRangodefecha_spReporteEgresos01EgresosActivosenunRangodefecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de egresos x persona activos entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesEgresos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Egresos.rptReporteEgresos.rdlc";
                    break;
                case "05":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@strCedulaCli", SqlDbType.VarChar);
                    parametro.Value = this.txtCedula.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteEgresos05EgresosAnuladosenunRangodefechaxCliente");

                    datasource = new ReportDataSource("spReporteEgresos01EgresosActivosenunRangodefecha_spReporteEgresos01EgresosActivosenunRangodefecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de egresos x persona anulados entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesEgresos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Egresos.rptReporteEgresos.rdlc";
                    break;
                case "06":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@strCedulaCli", SqlDbType.VarChar);
                    parametro.Value = this.txtCedula.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteEgresos06EgresosRegistradossenunRangodefechaxCliente");

                    datasource = new ReportDataSource("spReporteEgresos01EgresosActivosenunRangodefecha_spReporteEgresos01EgresosActivosenunRangodefecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de egresos x persona registrados entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesEgresos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Egresos.rptReporteEgresos.rdlc";
                    break;
                case "07":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteEgresos07EgresosOtrosActivosenunRangodefecha");

                    datasource = new ReportDataSource("spReporteEgresos07EgresosOtrosActivosenunRangodefecha_spReporteEgresos07EgresosOtrosActivosenunRangodefecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de otros egresos activos entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesEgresos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Egresos.rptReporteEgresosOtros.rdlc";
                    break;
                case "08":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteEgresos08EgresosOtrosAnuladosenunRangodefecha");

                    datasource = new ReportDataSource("spReporteEgresos07EgresosOtrosActivosenunRangodefecha_spReporteEgresos07EgresosOtrosActivosenunRangodefecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de otros egresos anulados entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesEgresos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Egresos.rptReporteEgresosOtros.rdlc";
                    break;
                case "09":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteEgresos09EgresosOtrosRegistradosenunRangodefecha");

                    datasource = new ReportDataSource("spReporteEgresos07EgresosOtrosActivosenunRangodefecha_spReporteEgresos07EgresosOtrosActivosenunRangodefecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de otros egresos registrados entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesEgresos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Egresos.rptReporteEgresosOtros.rdlc";
                    break;
                case "10":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@strCedulaCli", SqlDbType.VarChar);
                    parametro.Value = this.txtCedula.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteEgresos10EgresosOtrosAnuladosenunRangodefechaxPersona");

                    datasource = new ReportDataSource("spReporteEgresos07EgresosOtrosActivosenunRangodefecha_spReporteEgresos07EgresosOtrosActivosenunRangodefecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de otros egresos x persona activos entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesEgresos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Egresos.rptReporteEgresosOtros.rdlc";
                    break;
                case "11":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@strCedulaCli", SqlDbType.VarChar);
                    parametro.Value = this.txtCedula.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteEgresos11EgresosOtrosAnuladosenunRangodefechaxPersona");

                    datasource = new ReportDataSource("spReporteEgresos07EgresosOtrosActivosenunRangodefecha_spReporteEgresos07EgresosOtrosActivosenunRangodefecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de otros egresos x persona anulados entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesEgresos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Egresos.rptReporteEgresosOtros.rdlc";
                    break;
                case "12":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@strCedulaCli", SqlDbType.VarChar);
                    parametro.Value = this.txtCedula.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteEgresos12EgresosOtrosAnuladosenunRangodefechaxPersona");

                    datasource = new ReportDataSource("spReporteEgresos07EgresosOtrosActivosenunRangodefecha_spReporteEgresos07EgresosOtrosActivosenunRangodefecha", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de otros egresos x persona registrados entre el " + this.dtmFechaInicial.Value.ToShortDateString() + " y el " + this.dtmFechaFinal.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);
                    rptReportesEgresos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Egresos.rptReporteEgresosOtros.rdlc";
                    break;
                case "13":
                    parametro = new SqlParameter("@dtmFechaRec", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteEgresos13EgresosInformeDiarioGlobal");

                    datasource = new ReportDataSource("spReporteIngresos21RecibosInformeDiario_spReporteIngresos21RecibosInformeDiario", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de egresos del día " + this.dtmFechaInicial.Value.ToShortDateString());
                    lstParametros.Add(parametroReporte);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Cantidad", "Valor Bruto");
                    lstParametros.Add(parametroReporte);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Descuento", "IVA");
                    lstParametros.Add(parametroReporte);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Capital", "Valor IVA");
                    lstParametros.Add(parametroReporte);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Interes", "Retención");
                    lstParametros.Add(parametroReporte);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Mora", "Valor Retención");
                    lstParametros.Add(parametroReporte);

                    rptReportesEgresos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Recibos.rptRecibosIngresosInformeDiario.rdlc";
                    break;
            }

            rptReportesEgresos.ProcessingMode = ProcessingMode.Local;
            rptReportesEgresos.LocalReport.DataSources.Clear();
            rptReportesEgresos.LocalReport.DataSources.Add(datasource);
            rptReportesEgresos.LocalReport.SetParameters(lstParametros);
            rptReportesEgresos.LocalReport.Refresh();

            this.rptReportesEgresos.RefreshReport();
        }
    }
}
