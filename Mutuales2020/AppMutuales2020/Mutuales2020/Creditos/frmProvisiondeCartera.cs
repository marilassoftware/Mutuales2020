namespace Mutuales2020.Creditos
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using Microsoft.Reporting.WinForms;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public partial class frmProvisiondeCartera : Form
    {
        public frmProvisiondeCartera()
        {
            InitializeComponent();
        }

        private void gmtdMostrarReporte(DateTime tdtmFechaInial, DateTime tdtmFechaFinal, string tstrTipo)
        {
            DateTime dtmFechaActual = new blConfiguracion().gmtdCapturarFechadelServidor(); ;

            List<SqlParameter> lstParameters = new List<SqlParameter>();
            SqlParameter parametro = new SqlParameter("@dtmFechaIni", SqlDbType.DateTime);
            parametro.Value = tdtmFechaInial;
            lstParameters.Add(parametro);
            parametro = new SqlParameter("@dtmFechaFin", SqlDbType.DateTime);
            parametro.Value = tdtmFechaFinal;
            lstParameters.Add(parametro);
            parametro = new SqlParameter("@strTipo", SqlDbType.VarChar);
            parametro.Value = tstrTipo;
            lstParameters.Add(parametro);
            DataSet ds = new DataSet();
            ds = propiedades.ejecutarSp(lstParameters, "spClasificaciondeCreditos");

            if (tstrTipo == "01")
            {
                ReportDataSource datasource = new ReportDataSource("clasificaciondeCredito_spClasificaciondeCreditos", ds.Tables[0]);
                lstParameters = new List<SqlParameter>();
                ds = propiedades.ejecutarSp(lstParameters, "spClasificaciondeCreditosTotalesporClasificacion");
                ReportDataSource datasource1 = new ReportDataSource("spClasificaciondeCreditosTotalesporClasificacion_spClasificaciondeCreditosTotalesporClasificacion", ds.Tables[0]);
                ds = propiedades.ejecutarSp(lstParameters, "spClasificaciondeCreditosIndicedeCarteraMorosa");
                ReportDataSource datasource2 = new ReportDataSource("spClasificaciondeCreditosIndicedeCarteraMorosa_spClasificaciondeCreditosIndicedeCarteraMorosa", ds.Tables[0]);
                ds = propiedades.ejecutarSp(lstParameters, "spClasificaciondeCreditosPorClasificaciónyLinea");
                ReportDataSource datasource3 = new ReportDataSource("spClasificaciondeCreditosPorClasificaciónyLinea_spClasificaciondeCreditosPorClasificaciónyLinea", ds.Tables[0]);

                List<Microsoft.Reporting.WinForms.ReportParameter> lstParametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
                Microsoft.Reporting.WinForms.ReportParameter parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Titulo", "Clasificación de Créditos");
                lstParametros.Add(parametroReporte);

                rptProvisiondeCartera.Reset();
                rptProvisiondeCartera.Visible = true;
                rptProvisiondeCartera.ProcessingMode = ProcessingMode.Local;
                rptProvisiondeCartera.LocalReport.DataSources.Clear();
                rptProvisiondeCartera.LocalReport.DataSources.Add(datasource);
                rptProvisiondeCartera.LocalReport.DataSources.Add(datasource1);
                rptProvisiondeCartera.LocalReport.DataSources.Add(datasource2);
                rptProvisiondeCartera.LocalReport.DataSources.Add(datasource3);
                rptProvisiondeCartera.LocalReport.ReportEmbeddedResource = "Mutuales2020.Creditos.Reportes.rptProvisiondeCartera.rdlc";
                rptProvisiondeCartera.LocalReport.SetParameters(lstParametros);
                rptProvisiondeCartera.LocalReport.Refresh();

                this.rptProvisiondeCartera.RefreshReport();
            }
            else
                MessageBox.Show("Operación Realizada", "Operación", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        private void frmProvisiondeCartera_Load(object sender, EventArgs e)
        {
            this.rptProvisiondeCartera.RefreshReport();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string strTipo = "";

            if(this.cboAccion.SelectedIndex == 0)
                strTipo = "01";
            else
                strTipo = "02";

            this.gmtdMostrarReporte(this.dtpFechaIni.Value, this.dtmFechaFinal.Value, strTipo);
        }
    }
}
