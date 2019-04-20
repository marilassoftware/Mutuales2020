namespace Mutuales2020.Utilidades
{
    using libMutuales2020.dominio;
    using Microsoft.Reporting.WinForms;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;


    public partial class FrmSociosyBeneficiarios : Form
    {
        public FrmSociosyBeneficiarios()
        {
            InitializeComponent();
        }

        private void FrmSociosyBeneficiarios_Load(object sender, EventArgs e)
        {

            this.rptSocioyAgraciados.RefreshReport();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            List<SqlParameter> lstParameters = new List<SqlParameter>();
            SqlParameter parametro = new SqlParameter("@intCodigo", SqlDbType.Int);
            parametro.Value = this.txtCodigo.Text;
            lstParameters.Add(parametro);
            DataSet ds = new DataSet();
            ds = propiedades.ejecutarSp(lstParameters, "spSocioBeneficiario");
            ReportDataSource datasource;
            datasource = new ReportDataSource("spSocioBeneficiario_spSocioBeneficiario", ds.Tables[0]);

            List<Microsoft.Reporting.WinForms.ReportParameter> lstParametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Mutual", propiedades.strNombreMutual);
            lstParametros.Add(parametroReporte);

            rptSocioyAgraciados.Reset();
            rptSocioyAgraciados.ProcessingMode = ProcessingMode.Local;
            rptSocioyAgraciados.LocalReport.DataSources.Clear();
            rptSocioyAgraciados.LocalReport.DataSources.Add(datasource);
            rptSocioyAgraciados.LocalReport.ReportEmbeddedResource = "Mutuales2020.Utilidades.Reportes.rptSociosyBeneficiarios.rdlc";
            rptSocioyAgraciados.LocalReport.SetParameters(lstParametros);
            rptSocioyAgraciados.LocalReport.Refresh();

            this.rptSocioyAgraciados.RefreshReport();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnEjecutar.Focus();
            }
        }
    }
}
