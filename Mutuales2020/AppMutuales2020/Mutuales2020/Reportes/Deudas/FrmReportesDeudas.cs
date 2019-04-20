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

namespace Mutuales2020.Reportes.Deudas
{
    public partial class FrmReportesDeudas : Form
    {
        public FrmReportesDeudas()
        {
            InitializeComponent();
        }

        private void FrmReportesDeudas_Load(object sender, EventArgs e)
        {

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

            this.rptReportesDeudas.Reset();

            switch (this.cboTipoReporte.Text.Substring(0, 2))
            {
                case "01":
                    ds = propiedades.ejecutarSp(lstParameters, "spReporteDeudas01DeudasRegistradas");

                    datasource = new ReportDataSource("spReporteDeudas01DeudasRegistradas_spReporteDeudas01DeudasRegistradas", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de Deudas Registradas ");
                    lstParametros.Add(parametroReporte);
                    rptReportesDeudas.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Deudas.rptReportesDeudas.rdlc";
                    break;
                case "02":
                    parametro = new SqlParameter("@strCedula", SqlDbType.VarChar);
                    parametro.Value = this.txtCedula.Text;
                    lstParameters.Add(parametro);

                    ds = propiedades.ejecutarSp(lstParameters, "spReporteDeudas02DeudasRegistradasxSocio");

                    datasource = new ReportDataSource("spReporteDeudas01DeudasRegistradas_spReporteDeudas01DeudasRegistradas", ds.Tables[0]);

                    parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Reporte de Deudas registradas por socio ");
                    lstParametros.Add(parametroReporte);
                    rptReportesDeudas.LocalReport.ReportEmbeddedResource = "Mutuales2020.Reportes.Deudas.rptReportesDeudas.rdlc";
                    break;
            }

            rptReportesDeudas.ProcessingMode = ProcessingMode.Local;
            rptReportesDeudas.LocalReport.DataSources.Clear();
            rptReportesDeudas.LocalReport.DataSources.Add(datasource);
            rptReportesDeudas.LocalReport.SetParameters(lstParametros);
            rptReportesDeudas.LocalReport.Refresh();

            this.rptReportesDeudas.RefreshReport();
        }
    }
}
