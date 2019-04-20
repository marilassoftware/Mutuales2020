namespace Mutuales2020.Reportes.Agraciados
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using Microsoft.Reporting.WinForms;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;
    public partial class frmReportedeAgraciados : Form
    {
        public frmReportedeAgraciados()
        {
            InitializeComponent();
        }

        private void frmReportedeAgraciados_Load(object sender, EventArgs e)
        {
            this.cboBarrios.DataSource = new blBarrio().gmtdConsultar();
            this.cboServicios.DataSource = new blPrimarios().gmtdConsultarTodos();
            this.cboTipoReporte.SelectedIndex = 0;

            this.rptReporteAgraciados.RefreshReport();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            ReportDataSource datasource = new ReportDataSource();
            DataSet ds = new DataSet();
            List<Microsoft.Reporting.WinForms.ReportParameter> lstParametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter parametroReporte;
            List<SqlParameter> lstParameters = new List<SqlParameter>();
            SqlParameter parametro;

            this.rptReporteAgraciados.Reset();

            switch (this.cboTipoReporte.Text.Substring(0, 2))
            {
                case "01":
                    //if (new blExtra().gmtdConsultarExtraOpcion(propiedades.strAplicacion, "0001", propiedades.strGrupo))
                    //{
                        ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteAgraciados01AgraciadosActivos");

                        datasource = new ReportDataSource("spReporteAgraciados01AgraciadosActivos_spReporteAgraciados01AgraciadosActivos", ds.Tables[0]);

                        parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de agraciados activos");
                        lstParametros.Add(parametroReporte);
                    //}

                    break;
                case "02":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteAgraciados02AgraciadosAnulados");

                    datasource = new ReportDataSource("spReporteAgraciados01AgraciadosActivos_spReporteAgraciados01AgraciadosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de agraciados anulados");
                    lstParametros.Add(parametroReporte);

                    break;
                case "03":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteAgraciados03AgraciadosRegistrados");

                    datasource = new ReportDataSource("spReporteAgraciados01AgraciadosActivos_spReporteAgraciados01AgraciadosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de agraciados registrados");
                    lstParametros.Add(parametroReporte);

                    break;
                case "04":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteAgraciados04AgraciadosRecesados");

                    datasource = new ReportDataSource("spReporteAgraciados01AgraciadosActivos_spReporteAgraciados01AgraciadosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de agraciados recesados");
                    lstParametros.Add(parametroReporte);

                    break;
                case "05":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteAgraciados05AgraciadosnoRecesados");

                    datasource = new ReportDataSource("spReporteAgraciados01AgraciadosActivos_spReporteAgraciados01AgraciadosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de agraciados no recesados");
                    lstParametros.Add(parametroReporte);

                    break;
                case "06":
                    parametro = new SqlParameter("@strCodigoBar", SqlDbType.VarChar);
                    parametro.Value = this.cboBarrios.SelectedValue.ToString();
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteAgraciados06AgraciadosporBarrio");

                    datasource = new ReportDataSource("spReporteAgraciados01AgraciadosActivos_spReporteAgraciados01AgraciadosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de agraciados del barrio " + this.cboBarrios.Text);

                    lstParametros.Add(parametroReporte);

                    break;
                case "07":

                    parametro = new SqlParameter("@bitSexo", SqlDbType.Bit);
                    parametro.Value = this.chkSexo.Checked;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteAgraciados07AgraciadosporSexo");

                    datasource = new ReportDataSource("spReporteAgraciados01AgraciadosActivos_spReporteAgraciados01AgraciadosActivos", ds.Tables[0]);

                    if (this.chkSexo.Checked)
                        parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de agraciados del sexo maculino");
                    else
                        parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de agraciados del sexo femenino");

                    lstParametros.Add(parametroReporte);

                    break;
                case "08":

                    parametro = new SqlParameter("@intCodigoSoc", SqlDbType.Int);
                    parametro.Value = this.txtSocio.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteAgraciados08AgraciadosporSocio");

                    datasource = new ReportDataSource("spReporteAgraciados01AgraciadosActivos_spReporteAgraciados01AgraciadosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de agraciados registrados al socio " + this.txtSocio.Text);

                    lstParametros.Add(parametroReporte);

                    break;
                case "09":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteAgraciados09Agraciadosconprestamosactivos");

                    datasource = new ReportDataSource("spReporteAgraciados01AgraciadosActivos_spReporteAgraciados01AgraciadosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de agraciados con préstamos activos");
                    lstParametros.Add(parametroReporte);

                    break;

                case "10":
                    parametro = new SqlParameter("@strCodigoSer", SqlDbType.VarChar);
                    parametro.Value = this.cboServicios.SelectedValue.ToString();
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteAgraciados10Agraciadosxplan");

                    datasource = new ReportDataSource("spReporteAgraciados01AgraciadosActivos_spReporteAgraciados01AgraciadosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de agraciados del plan " + this.cboServicios.Text);

                    lstParametros.Add(parametroReporte);

                    break;
                case "11":
                    parametro = new SqlParameter("@intEdadIni", SqlDbType.Int);
                    parametro.Value = this.txtEdadInicial.Text;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@intEdadFin", SqlDbType.Int);
                    parametro.Value = this.txtEdadFinal.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteAgraciados11Agraciadosentredeterminadaedad");

                    datasource = new ReportDataSource("spReporteAgraciados01AgraciadosActivos_spReporteAgraciados01AgraciadosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de agraciados entre " + this.txtEdadInicial.Text + " y " + this.txtEdadFinal.Text);

                    lstParametros.Add(parametroReporte);

                    break;
                case "12":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Text;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteAgraciados12Agraciadosanuladosenunrangodefecha");

                    datasource = new ReportDataSource("spReporteAgraciados01AgraciadosActivos_spReporteAgraciados01AgraciadosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de agraciados anulados entre " + this.dtmFechaInicial.Text + " y " + this.dtmFechaFinal.Text);

                    lstParametros.Add(parametroReporte);

                    break;
                case "13":
                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Text;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteAgraciados13Agraciadosregistradosenunrangodefecha");

                    datasource = new ReportDataSource("spReporteAgraciados01AgraciadosActivos_spReporteAgraciados01AgraciadosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de agraciados registrados entre " + this.dtmFechaInicial.Text + " y " + this.dtmFechaFinal.Text);

                    lstParametros.Add(parametroReporte);

                    break;
                case "14":

                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Text;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteAgraciados14Agraciadosnacidosentre2fechas");

                    datasource = new ReportDataSource("spReporteAgraciados01AgraciadosActivos_spReporteAgraciados01AgraciadosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de agraciados nacidos entre " + this.dtmFechaInicial.Value.Year.ToString() + "-" + this.dtmFechaInicial.Value.Day.ToString() + " y " + this.dtmFechaFinal.Value.Year.ToString() + "-" + this.dtmFechaFinal.Value.Day.ToString());

                    lstParametros.Add(parametroReporte);

                    break;
                case "15":

                    parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaInicial.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
                    parametro.Value = this.dtmFechaFinal.Value;
                    lstParameters.Add(parametro);

                    parametro = new SqlParameter("@strCodigoSer", SqlDbType.VarChar);
                    parametro.Value = this.cboServicios.SelectedValue.ToString();
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteAgraciados15Agraciadosregistradosenunrangodefechaporplan");

                    datasource = new ReportDataSource("spReporteAgraciados01AgraciadosActivos_spReporteAgraciados01AgraciadosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de agraciados registrados entre " + this.dtmFechaInicial.Text + " y " + this.dtmFechaFinal.Text + " y en el plan " + this.cboServicios.Text);

                    lstParametros.Add(parametroReporte);

                    break;
                case "16":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteAgraciados16AgraciadossinActualizarInformacion");

                    datasource = new ReportDataSource("spReporteAgraciados01AgraciadosActivos_spReporteAgraciados01AgraciadosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de agraciados que no han actualizado informacion");
                    lstParametros.Add(parametroReporte);
                    break;
                case "17":
                    ds = propiedades.ejecutarSp(new List<SqlParameter>(), "spReporteAgraciados17AgraciadosconInformacionActualizada");

                    datasource = new ReportDataSource("spReporteAgraciados01AgraciadosActivos_spReporteAgraciados01AgraciadosActivos", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de agraciados con información actualizada");
                    lstParametros.Add(parametroReporte);
                    break;
            }

            rptReporteAgraciados.Reset();
            rptReporteAgraciados.ProcessingMode = ProcessingMode.Local;
            rptReporteAgraciados.LocalReport.DataSources.Clear();
            rptReporteAgraciados.LocalReport.DataSources.Add(datasource);
            rptReporteAgraciados.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Agraciados.rptAgraciados.rdlc";
            rptReporteAgraciados.LocalReport.SetParameters(lstParametros);
            rptReporteAgraciados.LocalReport.Refresh();

            this.rptReporteAgraciados.RefreshReport();
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
                    case "09":
                    case "16":
                    case "17":
                        this.btnGenerarReporte.Focus();
                        break;
                    case "08":
                        this.txtSocio.Focus();
                        break;
                    case "07":
                        this.chkSexo.Focus();
                        break;
                    case "06":
                        this.cboBarrios.Focus();
                        break;
                    case "10":
                    case "15":
                        this.cboServicios.Focus();
                        break;
                    case "11":
                        this.txtEdadInicial.Focus();
                        break;
                    case "12":
                    case "13":
                    case "14":
                        this.dtmFechaInicial.Focus();
                        break;
                }
            }
        }

        private void txtSocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.btnGenerarReporte.Focus();
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
                this.dtmFechaFinal.Focus();
        }

        private void dtmFechaFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.btnGenerarReporte.Focus();
        }
    }
}
