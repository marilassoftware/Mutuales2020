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

    public partial class FrmLiquidarAhorros : Form
    {
        public FrmLiquidarAhorros()
        {
            InitializeComponent();
        }

        private void FrmLiquidarAhorros_Load(object sender, EventArgs e)
        {
            this.txtAhorrado.Text = new blAhorrador().gmtdSumarAhorros().ToString();

        }

        private void txtBanco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.btnEjecutar.Focus();

        }

        private void txtBanco_Leave(object sender, EventArgs e)
        {
            decimal decDiferencia = Convert.ToDecimal(this.txtBanco.Text) - Convert.ToDecimal(this.txtAhorrado.Text);
            decimal decPorcentaje = decDiferencia * 100 / Convert.ToDecimal(this.txtAhorrado.Text);
            this.txtPorcentaje.Text = decPorcentaje.ToString("#,#00.00");
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            List<SqlParameter> lstParameters = new List<SqlParameter>();
            SqlParameter parametro = new SqlParameter("@decPorcentaje", SqlDbType.Decimal);
            parametro.Value = this.txtPorcentaje.Text;
            lstParameters.Add(parametro);

            DataSet ds = new DataSet();
            ds = propiedades.ejecutarSp(lstParameters, "spConsultaLiquidarAhorros");
            ReportDataSource datasource = new ReportDataSource("spConsultaLiquidarAhorros_spConsultaLiquidarAhorros", ds.Tables[0]);

            rptLiquidarAhorros.Reset();
            rptLiquidarAhorros.ProcessingMode = ProcessingMode.Local;
            rptLiquidarAhorros.LocalReport.DataSources.Clear();
            rptLiquidarAhorros.LocalReport.DataSources.Add(datasource);
            rptLiquidarAhorros.LocalReport.ReportEmbeddedResource = "Mutuales2020.Utilidades.Reportes.rptLiquidarAhorros.rdlc";
            rptLiquidarAhorros.LocalReport.Refresh();
            this.rptLiquidarAhorros.RefreshReport();

            if (MessageBox.Show("Desea registrar los intereses mostrados?", "Intereses", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                utilidades.pmtdMensaje(new blAhorrador().gmtdActualizarIntereses(this.txtPorcentaje.Text), "Intereses");

        }
    }
}
