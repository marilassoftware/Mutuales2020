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

    public partial class FrmAhorrosaFuturoIntereses : Form
    {
        public SqlParameter[] SearchValue = new SqlParameter[2];
        public List<tblAhorrosaFuturoBonificacion> ahorroaFuturoIntereses;
        ReportDataSource datasource;

        public FrmAhorrosaFuturoIntereses()
        {
            InitializeComponent();
        }

        #region metodos
        private static FrmAhorrosaFuturoIntereses form = null;
        public static FrmAhorrosaFuturoIntereses DefInstance
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new FrmAhorrosaFuturoIntereses();
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
        /// Habilita o deshabilita los botones de acuerdo a las opciones en la base de 
        /// datos
        /// </summary>
        private void gmtdPermisosBotones()
        {
            //Program.gmtdAsignarPermisos(ref btnGuardar, ref btnModificar, ref btnEliminar);
        }

        /// <summary>
        /// Carga la grid con datos si tiene permisos necesarios.
        /// </summary>
        private void pmtdCargarGrid()
        {
            //if (Propiedades.bitConsultar == true)
            //{
            //    blGrupo blGrp = new blGrupo();
            //    this.dgvGrupos.DataSource = blGrp.gmtdConsultarGrupoAppl(this.cboAplicaciones.Text);
            //}
        }

        /// <summary>
        /// Limpia los texbox del formulario.
        /// </summary>
        private void pmtdLimpiarText()
        {
        }

        /// <summary>
        /// Habilita o deshabilita los controles de la aplicación.
        /// </summary>
        /// <param name="a"></param>
        private void pmtdHabilitarText(bool a)
        {
        }

        /// <summary>
        /// Crea un objeto del tipo aplicación de acuerdo a la información de los texbox.
        /// </summary>
        /// <returns> Un objeto del tipo aplicación. </returns>
        //private municipio crearObj()
        //{
        //    return municipio;
        //}

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

        private void Frm_Load(object sender, EventArgs e)
        {
            this.gmtdPermisosBotones();
            this.pmtdCargarGrid();
            this.cboOpciones.SelectedIndex = 0;
            this.rptAhorrosInteresesaFuturo.RefreshReport();
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
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
                    if (ahorroaFuturoIntereses != null)
                        this.pmtdMensaje(new blAhorrosaFuturoIntereses().gmtdInsertar(ahorroaFuturoIntereses), "Ahorros a Futuro");
                    else
                        MessageBox.Show("No hay datos para procesar", "Dato no Validos", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            ds = propiedades.ejecutarSp(lstParameters, "spAhorrosaFuturoConsulta");
            datasource = new ReportDataSource("dbExequial2010DataSet1_spAhorrosaFuturoConsulta", ds.Tables[0]);

            rptAhorrosInteresesaFuturo.Reset();
            rptAhorrosInteresesaFuturo.ProcessingMode = ProcessingMode.Local;
            rptAhorrosInteresesaFuturo.LocalReport.DataSources.Clear();
            rptAhorrosInteresesaFuturo.LocalReport.DataSources.Add(datasource);
            rptAhorrosInteresesaFuturo.LocalReport.ReportEmbeddedResource = "Mutuales2020.Ahorros.Reportes.rptAhorrosaFuturoConsulta.rdlc";
            rptAhorrosInteresesaFuturo.LocalReport.Refresh();
        }

        private void estimaciondeInteresesdeAhorroaFuturo()
        {
            List<SqlParameter> lstParameters = new List<SqlParameter>();
            SqlParameter parametro = new SqlParameter("@dtmFechaCuo", SqlDbType.DateTime);
            parametro.Value = DateTime.Now;
            lstParameters.Add(parametro);
            parametro = new SqlParameter("@strUsuario", "aftabares");
            parametro.Value = "aftabares";
            lstParameters.Add(parametro);
            DataSet ds = new DataSet();
            ds = propiedades.ejecutarSp(lstParameters, "spAhorrosaFuturoCalcularIntereses");
            datasource = new ReportDataSource("dbExequial2010DataSet_spAhorrosaFuturoCalcularIntereses", ds.Tables[0]);
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
            rptAhorrosInteresesaFuturo.LocalReport.ReportEmbeddedResource = "Mutuales2020.Ahorros.Reportes.rptAhorrosaFuturoIntereses.rdlc";
//            rptAhorrosInteresesaFuturo.LocalReport.ReportPath = ConfigurationManager.AppSettings["rutaReportes"].ToString() + "rptAhorrosaFuturoIntereses.rdlc";
            rptAhorrosInteresesaFuturo.LocalReport.SetParameters(lstParametros);
            rptAhorrosInteresesaFuturo.LocalReport.Refresh();
        }

        /// <summary> En este metodo tomamos los datos mostrados en el informe y se convierte en un objeto de dominio
        /// para que se puedan lamacenar los intereses.
        /// </summary>
        /// <param name="ttbl"> datable con los datos a procesar. </param>
        private void contruirGuardar(DataTable ttbl)
        {
            ahorroaFuturoIntereses = new List<tblAhorrosaFuturoBonificacion>();

            for (int a = 0; a < ttbl.Rows.Count; a++)
            {
                tblAhorrosaFuturoBonificacion intereses = new tblAhorrosaFuturoBonificacion();
                intereses.strCuenta = ttbl.Rows[a]["strCuenta"].ToString();
                intereses.strFormulario = "frmAhorrosaFuturoIntereses";
                intereses.fltValor = Convert.ToDouble(ttbl.Rows[a]["intereses"]);
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
