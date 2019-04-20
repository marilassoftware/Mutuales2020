namespace Mutuales2020.Ahorros
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using Microsoft.Reporting.WinForms;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public partial class FrmAhorrosNavideñoIntereses : Form
    {
        public SqlParameter[] SearchValue = new SqlParameter[2];
        public List<tblAhorrosNavidenoBonificacion> ahorroaFuturoIntereses;
        ReportDataSource datasource;


        public FrmAhorrosNavideñoIntereses()
        {
            InitializeComponent();
        }

        #region metodos
        private static FrmAhorrosNavideñoIntereses form = null;
        public static FrmAhorrosNavideñoIntereses DefInstance
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new FrmAhorrosNavideñoIntereses();
                }
                else
                {
                    form.BringToFront();
                }
                return form;
            }
            set
            {
                form = value;
            }
        }

        /// <summary>
        /// De acuerdo al string devuelto por un metodo elabora un mensaje.
        /// </summary>
        /// <param name="tstrMensaje"> string que devuelve el objeto. </param>
        /// <param name="tstrFormulario"> formulario desde el que se esta mandando
        /// a contruir el mensaje</param>
        /// <returns> un mensaje </returns>
        private DialogResult pmtdMensaje(string tstrMensaje, string tstrFormulario)
        {
            DialogResult mensaje;
            if (tstrMensaje.Substring(0, 1) == "-")
            {
                mensaje = MessageBox.Show(tstrMensaje.Substring(2, tstrMensaje.Length - 2), tstrFormulario, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mensaje = MessageBox.Show(tstrMensaje, tstrFormulario, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return mensaje;
        }
        #endregion

        private void frmAhorrosNavideñoIntereses_Load(object sender, EventArgs e)
        {
            this.cboOpciones.SelectedIndex = 0;
            this.rptAhorrosInteresesaFuturo.RefreshReport();

        }

        private void FrmAhorrosNavideñoIntereses_FormClosed(object sender, FormClosedEventArgs e)
        {
            propiedades.strFormActivo = "Principal";
            this.Dispose();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            switch (this.cboOpciones.SelectedIndex)
            {
                case 0:
                    this.estimaciondeInteresesdeAhorroNavideno();
                    break;
                case 1:
                    if (ahorroaFuturoIntereses != null)
                    {
                        this.pmtdMensaje(new blAhorrosNavidenoIntereses().gmtdInsertar(ahorroaFuturoIntereses), "Ahorros a Futuro");
                    }
                    else
                    {
                        MessageBox.Show("No hay datos para procesar", "Dato no Validos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    ahorroaFuturoIntereses = null;
                    break;
                case 2:
                    this.consultadeIntereses();
                    break;
            }
            this.rptAhorrosInteresesaFuturo.RefreshReport();
        }

        private void consultadeIntereses()
        {
            List<SqlParameter> lstParameters = new List<SqlParameter>();
            SqlParameter parametro = new SqlParameter("@dtmFecha", SqlDbType.DateTime);
            parametro.Value = this.dtpFecha.Value;
            lstParameters.Add(parametro);
            DataSet ds = new DataSet();
            ds = propiedades.ejecutarSp(lstParameters, "spAhorrosNavidenoConsulta");
            datasource = new ReportDataSource("consultaInteresesAhorrosNavidenos_spAhorrosNavidenoConsulta", ds.Tables[0]);

            rptAhorrosInteresesaFuturo.Reset();
            rptAhorrosInteresesaFuturo.ProcessingMode = ProcessingMode.Local;
            rptAhorrosInteresesaFuturo.LocalReport.DataSources.Clear();
            rptAhorrosInteresesaFuturo.LocalReport.DataSources.Add(datasource);
            rptAhorrosInteresesaFuturo.LocalReport.ReportEmbeddedResource = "Mutuales2020.Ahorros.Reportes.rptAhorrosNavidenoConsulta.rdlc";
            rptAhorrosInteresesaFuturo.LocalReport.Refresh();
        }

        private void estimaciondeInteresesdeAhorroNavideno()
        {
            List<SqlParameter> lstParameters = new List<SqlParameter>();
            SqlParameter parametro = new SqlParameter("@dtmFechaCuo", SqlDbType.DateTime);
            parametro.Value = DateTime.Now;
            lstParameters.Add(parametro);
            parametro = new SqlParameter("@strUsuario", "aftabares");
            parametro.Value = "aftabares";
            lstParameters.Add(parametro);
            DataSet ds = new DataSet();
            ds = propiedades.ejecutarSp(lstParameters, "spAhorrosNavidenoCalcularIntereses");
            datasource = new ReportDataSource("calcularInteresesAhorrosNavidenos_spAhorrosNavidenoCalcularIntereses", ds.Tables[0]);
            this.contruirGuardar(ds.Tables[0]);

            List<Microsoft.Reporting.WinForms.ReportParameter> lstParametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("dtmFechaCuota", DateTime.Now.ToString());
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("strUsuario", "qqq");
            lstParametros.Add(parametroReporte);

            rptAhorrosInteresesaFuturo.Reset();
            rptAhorrosInteresesaFuturo.ProcessingMode = ProcessingMode.Local;
            rptAhorrosInteresesaFuturo.LocalReport.DataSources.Clear();
            rptAhorrosInteresesaFuturo.LocalReport.DataSources.Add(datasource);
            rptAhorrosInteresesaFuturo.LocalReport.ReportEmbeddedResource = "Mutuales2020.Ahorros.Reportes.rptAhorrosNavidenoIntereses.rdlc";
            //rptAhorrosInteresesaFuturo.LocalReport.SetParameters(lstParametros);
            rptAhorrosInteresesaFuturo.LocalReport.Refresh();
        }

        /// <summary> En este metodo tomamos los datos mostrados en el informe y se convierte en un objeto de dominio para que se puedan lamacenar los intereses. </summary>
        /// <param name="ttbl"> datable con los datos a procesar. </param>
        private void contruirGuardar(DataTable ttbl)
        {
            ahorroaFuturoIntereses = new List<tblAhorrosNavidenoBonificacion>();

            for (int a = 0; a < ttbl.Rows.Count; a++)
            {
                tblAhorrosNavidenoBonificacion intereses = new tblAhorrosNavidenoBonificacion();
                intereses.strCuenta = ttbl.Rows[a]["strCuenta"].ToString();
                intereses.strFormulario = "FrmAhorrosNavideñoIntereses";
                intereses.fltValor = Convert.ToDouble(ttbl.Rows[a]["Intereses"]);
                intereses.dtmFechaSorteo = DateTime.Now;
                intereses.dtmFechaAnulado = Convert.ToDateTime("01/01/1900");
                intereses.bitPremios = false;
                intereses.bitIntereses = true;
                intereses.bitAnulado = false;
                ahorroaFuturoIntereses.Add(intereses);
            }
        }
    }
}
