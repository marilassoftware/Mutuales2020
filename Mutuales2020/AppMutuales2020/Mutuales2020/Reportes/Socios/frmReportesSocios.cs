namespace Mutuales2020.Reportes.Socios
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using Microsoft.Reporting.WinForms;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public partial class frmReportesSocios : Form
    {
        public frmReportesSocios()
        {
            InitializeComponent();
        }

        private void frmReportesSocios_Load(object sender, EventArgs e)
        {
            this.cboBarrios.DataSource = new blBarrio().gmtdConsultar();
            this.cboServicios.DataSource = new blPrimarios().gmtdConsultarTodos();
            this.cboTipoReporte.SelectedIndex = 0;

            this.rptReporteSocios.RefreshReport();
            this.rptReporteSocios.RefreshReport();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            ReportDataSource datasource = new ReportDataSource();
            DataSet ds = new DataSet();
            List<Microsoft.Reporting.WinForms.ReportParameter> lstParametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter parametroReporte;
            List<SqlParameter> lstParameters = new List<SqlParameter>();
            SqlParameter parametro;

            this.rptReporteSocios.Reset();

            switch (this.cboTipoReporte.Text.Substring(0, 2))
            {
                case "01":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteSocios01SociosActivos");

                    datasource = new ReportDataSource("reporteSocios_spReporteSocios01SociosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de socios activos");
                    lstParametros.Add(parametroReporte);

                    rptReporteSocios.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Socios.rptSocios.rdlc";

                    break;
                case "02":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteSocios02SociosAnulados");

                    datasource = new ReportDataSource("reporteSocios_spReporteSocios01SociosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de socios anulados");
                    lstParametros.Add(parametroReporte);

                    rptReporteSocios.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Socios.rptSocios.rdlc";

                    break;
                case "03":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteSocios03SociosRegistrados");

                    datasource = new ReportDataSource("reporteSocios_spReporteSocios01SociosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de socios registrados");
                    lstParametros.Add(parametroReporte);

                    rptReporteSocios.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Socios.rptSocios.rdlc";

                    break;
                case "04":

                    parametro = new SqlParameter("@intMeses", SqlDbType.Int);
                    parametro.Value = this.txtMeses.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteSocios04SociosAtrasados");

                    datasource = new ReportDataSource("reporteSocios_spReporteSocios01SociosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de socios atrasados " + this.txtMeses.Text + " Meses");
                    lstParametros.Add(parametroReporte);

                    rptReporteSocios.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Socios.rptSocios.rdlc";

                    break;
                case "05":

                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteSocios05SociosRecesados");

                    datasource = new ReportDataSource("reporteSocios_spReporteSocios01SociosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de socios recesados");
                    lstParametros.Add(parametroReporte);

                    rptReporteSocios.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Socios.rptSocios.rdlc";

                    break;
                case "06":

                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteSocios05SociosNoRecesados");

                    datasource = new ReportDataSource("reporteSocios_spReporteSocios01SociosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de socios no recesados");
                    lstParametros.Add(parametroReporte);

                    rptReporteSocios.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Socios.rptSocios.rdlc";

                    break;
                case "07":

                    parametro = new SqlParameter("@bitSexo", SqlDbType.Bit);
                    parametro.Value = this.chkSexo.Checked;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteSocios07SociosxSexo");

                    datasource = new ReportDataSource("reporteSocios_spReporteSocios01SociosActivos", ds.Tables[0]);

                    if (this.chkSexo.Checked)
                        parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de socios del sexo maculino");
                    else
                        parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de socios del sexo femenino");

                    lstParametros.Add(parametroReporte);

                    rptReporteSocios.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Socios.rptSocios.rdlc";

                    break;
                case "08":

                    parametro = new SqlParameter("@strCodigoBar", SqlDbType.VarChar);
                    parametro.Value = this.cboBarrios.SelectedValue.ToString();
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteSocios08SociosxBarrio");

                    datasource = new ReportDataSource("reporteSocios_spReporteSocios01SociosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de socios del barrio " + this.cboBarrios.Text);

                    lstParametros.Add(parametroReporte);

                    rptReporteSocios.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Socios.rptSocios.rdlc";

                    break;
                case "09":

                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteSocios09SociosaPazySalvo");

                    datasource = new ReportDataSource("reporteSocios_spReporteSocios01SociosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de socios a paz y salvo");
                    lstParametros.Add(parametroReporte);

                    rptReporteSocios.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Socios.rptSocios.rdlc";

                    break;
                case "10":

                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteSocios10SociosconPrestamosActivos");

                    datasource = new ReportDataSource("reporteSocios_spReporteSocios01SociosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de socios con préstamos activos");
                    lstParametros.Add(parametroReporte);

                    rptReporteSocios.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Socios.rptSocios.rdlc";

                    break;
                case "11":

                    parametro = new SqlParameter("@strCodigoSer", SqlDbType.VarChar);
                    parametro.Value = this.cboServicios.SelectedValue.ToString();
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteSocios11SociosxPlan");

                    datasource = new ReportDataSource("reporteSocios_spReporteSocios01SociosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de socios del plan " + this.cboServicios.Text);

                    lstParametros.Add(parametroReporte);

                    rptReporteSocios.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Socios.rptSocios.rdlc";

                    break;
                case "12":

                    parametro = new SqlParameter("@intEdadIni", SqlDbType.Int);
                    parametro.Value = this.txtEdadInicial.Text;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@intEdadFin", SqlDbType.Int);
                    parametro.Value = this.txtEdadFinal.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteSocios12Sociosentredeterminadaedad");

                    datasource = new ReportDataSource("reporteSocios_spReporteSocios01SociosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de socios entre " + this.txtEdadInicial.Text + " y " + this.txtEdadFinal.Text);

                    lstParametros.Add(parametroReporte);

                    rptReporteSocios.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Socios.rptSocios.rdlc";

                    break;
                case "13":

                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Text;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteSocios13Sociosanuladosenunrangodefecha");

                    datasource = new ReportDataSource("reporteSocios_spReporteSocios01SociosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de socios anulados entre " + this.dtmFechaInicial.Text + " y " + this.dtmFechaFinal.Text);

                    lstParametros.Add(parametroReporte);

                    rptReporteSocios.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Socios.rptSocios.rdlc";

                    break;
                case "14":

                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Text;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteSocios14Sociosregistradosenunrangodefecha");

                    datasource = new ReportDataSource("reporteSocios_spReporteSocios01SociosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de socios registrados entre " + this.dtmFechaInicial.Text + " y " + this.dtmFechaFinal.Text);

                    lstParametros.Add(parametroReporte);

                    rptReporteSocios.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Socios.rptSocios.rdlc";

                    break;
                case "15":

                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Text;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteSocios15Sociosnacidosentre2fechas");

                    datasource = new ReportDataSource("reporteSocios_spReporteSocios01SociosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de socios nacidos entre " + this.dtmFechaInicial.Value.Year.ToString() + "-" + this.dtmFechaInicial.Value.Day.ToString() + " y " + this.dtmFechaFinal.Value.Year.ToString() + "-" + this.dtmFechaFinal.Value.Day.ToString());

                    lstParametros.Add(parametroReporte);

                    rptReporteSocios.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Socios.rptSocios.rdlc";

                    break;
                case "16":

                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@strCodigoSer", SqlDbType.VarChar);
                    parametro.Value = this.cboServicios.SelectedValue.ToString();
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteSocios16Sociosregistradosenunrangodefechaporplan");

                    datasource = new ReportDataSource("reporteSocios_spReporteSocios01SociosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de socios registrados entre " + this.dtmFechaInicial.Text + " y " + this.dtmFechaFinal.Text + " y en el plan " + this.cboServicios.Text);

                    lstParametros.Add(parametroReporte);

                    rptReporteSocios.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Socios.rptSocios.rdlc";

                    break;
                case "17":

                    parametro = new SqlParameter("@intMeses", SqlDbType.Int);
                    parametro.Value = this.txtMeses.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteSocios17Sociosatrasadosexactamente");

                    datasource = new ReportDataSource("reporteSocios_spReporteSocios01SociosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de socios atrasados " + this.txtMeses.Text + " meses");

                    lstParametros.Add(parametroReporte);

                    rptReporteSocios.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Socios.rptSocios.rdlc";

                    break;
                case "18":

                    parametro = new SqlParameter("@intMes", SqlDbType.Int);
                    parametro.Value = this.dtmFechaInicial.Value.Month;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@intAño", SqlDbType.Int);
                    parametro.Value = this.dtmFechaInicial.Value.Year;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteSocios18Numerosderifa");

                    datasource = new ReportDataSource("spReporteSocios18Numerosderifa_spReporteSocios18Numerosderifa", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de números de rifa del año " + this.dtmFechaInicial.Value.Year.ToString() + " y el mes " + this.dtmFechaInicial.Value.Month.ToString());

                    lstParametros.Add(parametroReporte);

                    rptReporteSocios.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Socios.rptSociosNumeroRifa.rdlc";

                    break;
                case "19":

                    lstParameters = new List<SqlParameter>();

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteSocios19SociosyBeneficiarios");

                    datasource = new ReportDataSource("spReporteSocios19SociosyBeneficiarios_spReporteSocios19SociosyBeneficiarios", ds.Tables[0]);

                    rptReporteSocios.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Socios.rptReporteSociosyBeneficiarios.rdlc";

                    break;
                case "20":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteSocios20Sociossinactualizarinformacion");

                    datasource = new ReportDataSource("reporteSocios_spReporteSocios01SociosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de socios sin actualizar información");
                    lstParametros.Add(parametroReporte);

                    rptReporteSocios.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Socios.rptSocios.rdlc";

                    break;
                case "21":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteSocios21SociosconinformacionActualizada");

                    datasource = new ReportDataSource("reporteSocios_spReporteSocios01SociosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de socios con información actualizada");
                    lstParametros.Add(parametroReporte);

                    rptReporteSocios.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Socios.rptSocios.rdlc";

                    break;
                case "22":

                    parametro = new SqlParameter("@intMeses", SqlDbType.Int);
                    parametro.Value = this.txtMeses.Text;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@intMesAnterior", SqlDbType.Int);
                    parametro.Value = this.dtmFechaInicial.Value.Month;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@intAñoAnterior", SqlDbType.Int);
                    parametro.Value = this.dtmFechaInicial.Value.Year;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaaRegistrar", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value.AddMonths(1);
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@strTipoResultado", SqlDbType.VarChar);
                    parametro.Value = "Estable";
                    lstParameters.Add(parametro);

                    if (MessageBox.Show("Desea solo consultar los datos", "Reporte", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        parametro = new SqlParameter("@strEjecutarConsulta", SqlDbType.VarChar);
                        parametro.Value = "Si";
                        lstParameters.Add(parametro);
                    }
                    else
                    {
                        parametro = new SqlParameter("@strEjecutarConsulta", SqlDbType.VarChar);
                        parametro.Value = "No";
                        lstParameters.Add(parametro);
                    }

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteSocios22SociosdeSalidaeIngresoaMafre");

                    datasource = new ReportDataSource("spReporteSocios22SociosdeSalidaeIngresoaMafre_spReporteSocios22SociosdeSalidaeIngresoaMafre", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Informe para mafre - Socios Estables");
                    lstParametros.Add(parametroReporte);

                    rptReporteSocios.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Socios.rptInformeMafre.rdlc";

                    break;
                case "23":

                    parametro = new SqlParameter("@intMeses", SqlDbType.Int);
                    parametro.Value = this.txtMeses.Text;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@intMesAnterior", SqlDbType.Int);
                    parametro.Value = this.dtmFechaInicial.Value.Month;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@intAñoAnterior", SqlDbType.Int);
                    parametro.Value = this.dtmFechaInicial.Value.Year;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaaRegistrar", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value.AddMonths(1);
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@strTipoResultado", SqlDbType.VarChar);
                    parametro.Value = "Sacar";
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteSocios22SociosdeSalidaeIngresoaMafre");

                    datasource = new ReportDataSource("spReporteSocios22SociosdeSalidaeIngresoaMafre_spReporteSocios22SociosdeSalidaeIngresoaMafre", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Informe para mafre - Socios a Sacar");
                    lstParametros.Add(parametroReporte);

                    rptReporteSocios.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Socios.rptInformeMafre.rdlc";

                    break;
                case "24":

                    parametro = new SqlParameter("@intMeses", SqlDbType.Int);
                    parametro.Value = this.txtMeses.Text;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@intMesAnterior", SqlDbType.Int);
                    parametro.Value = this.dtmFechaInicial.Value.Month;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@intAñoAnterior", SqlDbType.Int);
                    parametro.Value = this.dtmFechaInicial.Value.Year;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaaRegistrar", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value.AddMonths(1);
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@strTipoResultado", SqlDbType.VarChar);
                    parametro.Value = "Adicionar";
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteSocios22SociosdeSalidaeIngresoaMafre");

                    datasource = new ReportDataSource("spReporteSocios22SociosdeSalidaeIngresoaMafre_spReporteSocios22SociosdeSalidaeIngresoaMafre", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Informe para mafre - Socios a Adicionar");
                    lstParametros.Add(parametroReporte);

                    rptReporteSocios.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Socios.rptInformeMafre.rdlc";

                    break;
            }

            rptReporteSocios.ProcessingMode = ProcessingMode.Local;
            rptReporteSocios.LocalReport.DataSources.Clear();
            rptReporteSocios.LocalReport.DataSources.Add(datasource);
            rptReporteSocios.LocalReport.SetParameters(lstParametros);
            rptReporteSocios.LocalReport.Refresh();

            this.rptReporteSocios.RefreshReport();

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
                    case "05":
                    case "06":
                    case "09":
                    case "10":
                    case "19":
                    case "20":
                    case "21":
                        this.btnGenerarReporte.Focus();
                        break;
                    case "04":
                    case "17":
                    case "22":
                    case "23":
                    case "24":
                        this.txtMeses.Focus();
                        break;
                    case "07":
                        this.chkSexo.Focus();
                        break;
                    case "08":
                        this.cboBarrios.Focus();
                        break;
                    case "11":
                    case "16":
                        this.cboServicios.Focus();
                        break;
                    case "12":
                        this.txtEdadInicial.Focus();
                        break;
                    case "13":
                    case "14":
                    case "15":
                    case "18":
                        this.dtmFechaInicial.Focus();
                        break;
                }
            }
        }

        private void txtMeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                switch (this.cboTipoReporte.Text.Substring(0, 2))
                {
                    case "04":
                    case "17":
                        this.btnGenerarReporte.Focus();
                        break;
                    case "22":
                    case "23":
                    case "24":
                        this.lblFechaInicial.Text = "Ultimo Informe";
                        this.dtmFechaInicial.Focus();
                        break;

                }
            }

        }

        private void chkSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.btnGenerarReporte.Focus();
        }

        private void cboBarrios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.btnGenerarReporte.Focus();
        }

        private void cboServicios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (this.cboTipoReporte.Text.Substring(0, 2) != "16")
                    this.btnGenerarReporte.Focus();
                else
                    this.dtmFechaInicial.Focus();
            }

        }

        private void txtEdadInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtEdadFinal.Focus();

        }

        private void txtEdadFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.btnGenerarReporte.Focus();

        }

        private void dtmFechaInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                switch (this.cboTipoReporte.Text.Substring(0, 2))
                {
                    case "18":
                    case "22":
                    case "23":
                    case "24":
                        this.btnGenerarReporte.Focus();
                        break;
                    default:
                        this.dtmFechaInicial.Focus();
                        break;

                }
            }

        }

        private void dtmFechaFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.btnGenerarReporte.Focus();

        }

        private void cboTipoReporte_Enter(object sender, EventArgs e)
        {
            this.lblFechaInicial.Text = "Fecha Inicial";

        }
    }
}
