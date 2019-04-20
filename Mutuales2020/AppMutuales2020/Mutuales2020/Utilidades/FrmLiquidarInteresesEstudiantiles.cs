namespace Mutuales2020.Utilidades
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using Microsoft.Reporting.WinForms;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;
    public partial class FrmLiquidarInteresesEstudiantiles : Form
    {
        public FrmLiquidarInteresesEstudiantiles()
        {
            InitializeComponent();
        }

        private void FrmLiquidarInteresesEstudiantiles_Load(object sender, EventArgs e)
        {
            this.cboTrimestre.SelectedIndex = 0;
            this.cboTipodeReporte.SelectedIndex = 0;
            this.cboAño.SelectedIndex = 0;
        }

        private void cboTipodeReporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.cboAño.Focus();
        }

        private void cboAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.cboTrimestre.Focus();
        }

        private void cboTrimestre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.btnConsultar.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            bool bitExiste = false;
            switch (this.cboTipodeReporte.Text.Substring(0, 2))
            {
                case "01":
                    bitExiste = new blAhorrosIntereses().gmtdConsultarAñoyTrimestreAhorrosEstudiantiles(Convert.ToInt32(this.cboAño.Text), Convert.ToInt32(this.cboTrimestre.Text));
                    if (new blAhorrosIntereses().gmtdConsultarAñoyTrimestreAhorrosEstudiantiles(Convert.ToInt32(this.cboAño.Text), Convert.ToInt32(this.cboTrimestre.Text)))
                        MessageBox.Show("Ya hay información para este año y trimestre", "Intereses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        this.gmtdMostrarReporte("01");
                    }
                    break;
                case "02":
                    bitExiste = new blAhorrosIntereses().gmtdConsultarAñoyTrimestreAhorrosEstudiantiles(Convert.ToInt32(this.cboAño.Text), Convert.ToInt32(this.cboTrimestre.Text));
                    if (new blAhorrosIntereses().gmtdConsultarAñoyTrimestreAhorrosEstudiantiles(Convert.ToInt32(this.cboAño.Text), Convert.ToInt32(this.cboTrimestre.Text)))
                        MessageBox.Show("Ya hay información para este año y trimetre", "Intereses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        this.gmtdMostrarReporte("02");
                    break;
                case "03":
                    this.gmtdMostrarReporte("03");
                    break;
            }
        }

        private void gmtdMostrarReporte(string tstrTipo)
        {
            List<SqlParameter> lstParameters = new List<SqlParameter>();
            SqlParameter parametro = new SqlParameter("@intAño", SqlDbType.Int);
            parametro.Value = this.cboAño.Text;
            lstParameters.Add(parametro);

            parametro = new SqlParameter("@intTrimestre", SqlDbType.Int);
            parametro.Value = this.cboTrimestre.Text;
            lstParameters.Add(parametro);

            parametro = new SqlParameter("@strUsuario", SqlDbType.VarChar);
            parametro.Value = propiedades.strLogin;
            lstParameters.Add(parametro);

            parametro = new SqlParameter("@strTipo", SqlDbType.VarChar);
            parametro.Value = tstrTipo;
            lstParameters.Add(parametro);

            DataSet ds = new DataSet();
            ds = propiedades.ejecutarSp(lstParameters, "spLiquidarInteresesEstudiantiles");
            ReportDataSource datasource;
            datasource = new ReportDataSource("spLiquidarIntereses_spLiquidarIntereses", ds.Tables[0]);

            List<Microsoft.Reporting.WinForms.ReportParameter> lstParametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            ReportParameter parametroReporte = new ReportParameter("Mutual", propiedades.strNombreMutual);
            lstParametros.Add(parametroReporte);
            parametroReporte = new ReportParameter("Titulo", "Liquidar Intereses Estudiantiles");
            lstParametros.Add(parametroReporte);

            rptLiquidarIntereses.Reset();
            rptLiquidarIntereses.Visible = true;
            rptLiquidarIntereses.ProcessingMode = ProcessingMode.Local;
            rptLiquidarIntereses.LocalReport.DataSources.Clear();
            rptLiquidarIntereses.LocalReport.DataSources.Add(datasource);
            rptLiquidarIntereses.LocalReport.ReportEmbeddedResource = "Mutuales2020.Utilidades.Reportes.rptLiquidarIntereses.rdlc";
            rptLiquidarIntereses.LocalReport.SetParameters(lstParametros);
            rptLiquidarIntereses.LocalReport.Refresh();

            this.rptLiquidarIntereses.RefreshReport();
        }

    }
}
