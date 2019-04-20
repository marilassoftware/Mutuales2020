namespace Mutuales2020.Utilidades
{
    using libMutuales2020.dominio;
    using Microsoft.Reporting.WinForms;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public partial class frmRecaudosaFecha : Form
    {
        ReportDataSource rdsPrincipal;
        ReportDataSource rdsTotales;
        ReportDataSource rdsCuatroxMil;

        public frmRecaudosaFecha()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            List<SqlParameter> lstParametersPrincipal = new List<SqlParameter>();
            SqlParameter parametroPrincipal = new SqlParameter("@dtmFechaInicial", SqlDbType.DateTime);
            parametroPrincipal.Value = this.dtmFechaInicial.Value;
            lstParametersPrincipal.Add(parametroPrincipal);
            parametroPrincipal = new SqlParameter("@dtmFechaFinal", SqlDbType.DateTime);
            parametroPrincipal.Value = this.dtmFechaFinal.Value;
            lstParametersPrincipal.Add(parametroPrincipal);
            parametroPrincipal = new SqlParameter("@strTipo", SqlDbType.VarChar);
            parametroPrincipal.Value = this.cboTipo.Text.Substring(0, 2);
            lstParametersPrincipal.Add(parametroPrincipal);
            DataSet dsPrincipal = new DataSet();
            dsPrincipal = propiedades.ejecutarSp(lstParametersPrincipal, "spRecaudoaFecha");
            rdsPrincipal = new ReportDataSource("recaudoaFecha_tblInformeDairio", dsPrincipal.Tables[0]);

            List<SqlParameter> lstParametersTotales = new List<SqlParameter>();
            SqlParameter parametroTotales = new SqlParameter("@dtmFechaInicial", SqlDbType.DateTime);
            parametroTotales.Value = this.dtmFechaInicial.Value;
            lstParametersTotales.Add(parametroTotales);
            parametroTotales = new SqlParameter("@dtmFechaFinal", SqlDbType.DateTime);
            parametroTotales.Value = this.dtmFechaFinal.Value;
            lstParametersTotales.Add(parametroTotales);
            parametroTotales = new SqlParameter("@strTipo", SqlDbType.VarChar);
            parametroTotales.Value = this.cboTipo.Text.Substring(0, 2);
            lstParametersTotales.Add(parametroTotales);
            DataSet dsTotales = new DataSet();
            dsTotales = propiedades.ejecutarSp(lstParametersTotales, "spRecaudoaFechaxUsuario");
            rdsTotales = new ReportDataSource("spRecaudoaFechaxUsuario_spRecaudoaFechaxUsuario", dsTotales.Tables[0]);

            List<SqlParameter> lstParametersCuatroxMil = new List<SqlParameter>();
            SqlParameter parametroCuatroxMil = new SqlParameter("@dtmFechaInicial", SqlDbType.DateTime);
            parametroCuatroxMil.Value = this.dtmFechaInicial.Value;
            lstParametersCuatroxMil.Add(parametroCuatroxMil);
            parametroCuatroxMil = new SqlParameter("@dtmFechaFinal", SqlDbType.DateTime);
            parametroCuatroxMil.Value = this.dtmFechaFinal.Value;
            lstParametersCuatroxMil.Add(parametroCuatroxMil);
            DataSet dsCuatroxMil = new DataSet();
            dsCuatroxMil = propiedades.ejecutarSp(lstParametersCuatroxMil, "spRecaudoaFechaCuatroxMil");
            rdsCuatroxMil = new ReportDataSource("spRecaudoaFechaCuatroxMil_spRecaudoaFechaCuatroxMil", dsCuatroxMil.Tables[0]);

            List<Microsoft.Reporting.WinForms.ReportParameter> lstParametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("fechaInicial", this.dtmFechaInicial.Value.ToShortDateString());
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("fechaFinal", this.dtmFechaFinal.Value.ToShortDateString());
            lstParametros.Add(parametroReporte);

            if (this.cboTipo.Text.Substring(0, 2) == "01")
            {
                parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Recaudo a fecha de INGRESOS");
                lstParametros.Add(parametroReporte);
            }
            else
            {
                parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "EGRESOS A FECHA");
                lstParametros.Add(parametroReporte);
            }

            rptRecaudoFecha.Reset();
            rptRecaudoFecha.ProcessingMode = ProcessingMode.Local;
            rptRecaudoFecha.LocalReport.DataSources.Clear();
            rptRecaudoFecha.LocalReport.DataSources.Add(rdsPrincipal);
            rptRecaudoFecha.LocalReport.DataSources.Add(rdsTotales);
            rptRecaudoFecha.LocalReport.DataSources.Add(rdsCuatroxMil);
            rptRecaudoFecha.LocalReport.ReportEmbeddedResource = "Mutuales2020.Utilidades.Reportes.rptRecaudoFecha.rdlc";
            rptRecaudoFecha.LocalReport.SetParameters(lstParametros);
            rptRecaudoFecha.LocalReport.Refresh();

            this.rptRecaudoFecha.RefreshReport();
        }

        private void frmRecaudosaFecha_Load(object sender, EventArgs e)
        {
            this.cboTipo.SelectedIndex = 0;
            this.rptRecaudoFecha.RefreshReport();
        }
    }
}
