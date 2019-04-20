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

    public partial class frmAhorrosCdtCausacion : Form
    {
        public SqlParameter[] SearchValue = new SqlParameter[2];
        public List<tblAhorrosCdtsCausacion> ahorroCadtCausacion;
        ReportDataSource datasource;

        public frmAhorrosCdtCausacion()
        {
            InitializeComponent();
        }

        #region metodos
        private static frmAhorrosCdtCausacion form = null;
        public static frmAhorrosCdtCausacion DefInstance
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new frmAhorrosCdtCausacion();
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

        private void frmAhorrosCdtCausacion_Load(object sender, EventArgs e)
        {
            this.cboOpciones.SelectedIndex = 0;

        }

        private void frmAhorrosCdtCausacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            propiedades.strFormActivo = "Principal";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            switch (this.cboOpciones.SelectedIndex)
            {
                case 0:
                    this.estimaciondeInteresesdeAhorroaFuturo();
                    break;
                case 1:
                    if (ahorroCadtCausacion != null)
                        this.pmtdMensaje(new blAhorrosCdtCausacion().gmtdInsertar(ahorroCadtCausacion), "Ahorros Cdt");
                    else
                        MessageBox.Show("No hay datos para procesar", "Dato no Validos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    ahorroCadtCausacion = null;
                    break;
                case 2:
                    this.consultadeCausacion();
                    break;
            }
            this.rptAhorrosInteresesaFuturo.RefreshReport();
        }

        private void estimaciondeInteresesdeAhorroaFuturo()
        {
            List<SqlParameter> lstParameters = new List<SqlParameter>();
            SqlParameter parametro = new SqlParameter("@dtmFecha", SqlDbType.DateTime);
            parametro.Value = DateTime.Now;
            lstParameters.Add(parametro);
            DataSet ds = new DataSet();
            ds = propiedades.ejecutarSp(lstParameters, "spAhorrosCdtCalculaCausacion");
            datasource = new ReportDataSource("ahorrosCdtCalcularCausacion_spAhorrosCdtCalculaCausacion", ds.Tables[0]);
            this.contruirGuardar(ds.Tables[0]);

            rptAhorrosInteresesaFuturo.Reset();
            rptAhorrosInteresesaFuturo.ProcessingMode = ProcessingMode.Local;
            rptAhorrosInteresesaFuturo.LocalReport.DataSources.Clear();
            rptAhorrosInteresesaFuturo.LocalReport.DataSources.Add(datasource);
            rptAhorrosInteresesaFuturo.LocalReport.ReportEmbeddedResource = "Mutuales2020.Ahorros.Reportes.rptAhorrosCdtCalcularCausacion.rdlc";
            rptAhorrosInteresesaFuturo.LocalReport.Refresh();
        }

        private void consultadeCausacion()
        {
            List<SqlParameter> lstParameters = new List<SqlParameter>();
            SqlParameter parametro = new SqlParameter("@dtmFecha", SqlDbType.DateTime);
            parametro.Value = this.dtpFecha.Value;
            lstParameters.Add(parametro);
            DataSet ds = new DataSet();
            ds = propiedades.ejecutarSp(lstParameters, "spAhorrosCdtConsultaCausacion");
            datasource = new ReportDataSource("ahorrosCdtConsultarCausacion_spAhorrosCdtConsultaCausacion", ds.Tables[0]);

            rptAhorrosInteresesaFuturo.Reset();
            rptAhorrosInteresesaFuturo.ProcessingMode = ProcessingMode.Local;
            rptAhorrosInteresesaFuturo.LocalReport.DataSources.Clear();
            rptAhorrosInteresesaFuturo.LocalReport.DataSources.Add(datasource);
            rptAhorrosInteresesaFuturo.LocalReport.ReportEmbeddedResource = "Mutuales2020.Ahorros.Reportes.rptAhorrosCdtCausacionConsultar.rdlc";
            rptAhorrosInteresesaFuturo.LocalReport.Refresh();
        }

        /// <summary> En este metodo tomamos los datos mostrados en el informe y se convierte en un objeto de dominio
        /// para que se puedan lamacenar los intereses.
        /// </summary>
        /// <param name="ttbl"> datable con los datos a procesar. </param>
        private void contruirGuardar(DataTable ttbl)
        {
            ahorroCadtCausacion = new List<tblAhorrosCdtsCausacion>();

            for (int a = 0; a < ttbl.Rows.Count; a++)
            {
                tblAhorrosCdtsCausacion causacion = new tblAhorrosCdtsCausacion();
                causacion.intNumeroCdt = Convert.ToInt32(ttbl.Rows[a]["intNumeroCdt"]);
                causacion.dtmFechaCausacion = Convert.ToDateTime(ttbl.Rows[a]["dtmFechaCausacion"]);
                causacion.decMonto = Convert.ToDecimal(ttbl.Rows[a]["decMontoCdt"]);
                causacion.decInteresCdt = Convert.ToDecimal(ttbl.Rows[a]["decInteresesCdt"]);
                causacion.intDias = Convert.ToInt32(ttbl.Rows[a]["intDias"]);
                causacion.decDiario = Convert.ToDecimal(ttbl.Rows[a]["decDiario"]);
                causacion.decValorCausacion = Convert.ToDecimal(ttbl.Rows[a]["decValorCausacion"]);
                causacion.strFormulario = "frmAhorrosCdtCausacion";
                ahorroCadtCausacion.Add(causacion);
            }
        }
    }
}
