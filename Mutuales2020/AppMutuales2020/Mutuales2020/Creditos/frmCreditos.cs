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


    public partial class frmCreditos : Form
    {
        public frmCreditos()
        {
            InitializeComponent();
        }

        #region metodos
        private static frmCreditos form = null;
        public static frmCreditos DefInstance
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new frmCreditos();
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

        /// <summary> Habilita o deshabilita los botones de acuerdo a las opciones en la base de datos </summary>
        private void gmtdPermisosBotones()
        {
            Program.gmtdAsignarPermisos(ref btnGuardar, ref btnConsultar, ref btnEliminar);
        }

        /// <summary> Limpia los texbox del formulario. </summary>
        private void pmtdLimpiarText()
        {
            this.txtCodigo.Text = "0";
            this.txtCedula.Text = "";
            this.txtSocio.Text = "0";
            this.txtNombre.Text = "";
            this.txtApellidoPre1.Text = "";
            this.txtApellidoPre2.Text = "";
            this.txtPagare.Text = "0";
            this.cboFrecuencia.SelectedIndex = 0;
            this.cboLinea.SelectedIndex = 0;
            this.dtpFechaPre.Value = DateTime.Now;
            this.txtIntereses.Text = "0";
            this.txtMonto.Text = "0";
            this.txtMeses.Text = "0";
            this.cboPago.SelectedIndex = 0;
            this.cboProcedencia.SelectedIndex = 0;
            this.txtTelefono.Text = "";
            this.txtDireccion.Text = "";
            this.cboPar.SelectedIndex = 0;
            this.txtCedulaCodeudor1.Text = "";
            this.txtNombreCodeudor1.Text = "";
            this.txtApellidoCodeudor1.Text = "";
            this.txtTelefonoCodeudor1.Text = "";
            this.txtCedulaCodeudor2.Text = "";
            this.txtNombreCodeudor2.Text = "";
            this.txtApellidoCodeudor2.Text = "";
            this.txtTelefonoCodeudor2.Text = "";
            this.txtAhorrado.Text = "0";
            this.txtDescripcionGarantia.Text = "";
            this.txtValorCuota.Text = "0";
            this.chkAhorros.Checked = false;
            this.rdbHipotecaria.Checked = false;
            this.rdbPrendaria.Checked = false;
            this.rptCreditos.Visible = false;
            this.rptRecibos.Visible = false;

            this.txtCodigo.Text = new blCreditos().gmtdConsultarCodigodeCredito().ToString();
        }

        private void pmtdHabilitarText(bool tbitA)
        {
            this.txtCodigo.Enabled = tbitA;
            this.txtCedula.Enabled = tbitA;
            this.txtSocio.Enabled = tbitA;
            this.txtNombre.Enabled = tbitA;
            this.txtApellidoPre1.Enabled = tbitA;
            this.txtApellidoPre2.Enabled = tbitA;
            this.txtPagare.Enabled = tbitA;
            this.cboFrecuencia.Enabled = tbitA;
            this.cboLinea.Enabled = tbitA;
            this.dtpFechaPre.Enabled = tbitA;
            this.txtIntereses.Enabled = tbitA;
            this.txtMonto.Enabled = tbitA;
            this.txtMeses.Enabled = tbitA;
            this.cboPago.Enabled = tbitA;
            this.cboProcedencia.Enabled = tbitA;
            this.txtTelefono.Enabled = tbitA;
            this.txtDireccion.Enabled = tbitA;
            this.cboPar.Enabled = tbitA;
            this.txtCedulaCodeudor1.Enabled = tbitA;
            this.txtNombreCodeudor1.Enabled = tbitA;
            this.txtApellidoCodeudor1.Enabled = tbitA;
            this.txtTelefonoCodeudor1.Enabled = tbitA;
            this.txtCedulaCodeudor2.Enabled = tbitA;
            this.txtNombreCodeudor2.Enabled = tbitA;
            this.txtApellidoCodeudor2.Enabled = tbitA;
            this.txtTelefonoCodeudor2.Enabled = tbitA;
            this.txtAhorrado.Enabled = tbitA;
            this.txtDescripcionGarantia.Enabled = tbitA;
            this.txtValorCuota.Enabled = tbitA;
            this.chkAhorros.Enabled = tbitA;
            this.rdbHipotecaria.Enabled = tbitA;
            this.rdbPrendaria.Enabled = tbitA;
            this.rptCreditos.Visible = false;
        }

        /// <summary> Crea un objeto del tipo aplicación de acuerdo a la información de los texbox. </summary>
        /// <returns> Un objeto del tipo aplicación. </returns>
        private tblCredito crearObj()
        {
            tblCredito credito = new tblCredito();
            credito.bitAhorrado = this.chkAhorros.Checked;
            credito.decAbono = 0;
            credito.decAhorrado = Convert.ToDecimal(this.txtAhorrado.Text);
            credito.decDebe = Convert.ToDecimal(this.txtMonto.Text);
            credito.decIntereses = Convert.ToDecimal(this.txtIntereses.Text);
            credito.decMonto = Convert.ToDecimal(this.txtMonto.Text);
            credito.dtmFechaPre = this.dtpFechaPre.Value;
            credito.intCodigoCre = Convert.ToInt32(this.txtCodigo.Text);
            credito.intCodigoSoc = Convert.ToInt32(this.txtSocio.Text);
            credito.intCuotas = Convert.ToInt32(this.txtMeses.Text);
            credito.intPagarePre = Convert.ToInt32(this.txtPagare.Text);
            credito.intCuotas = Convert.ToInt32(this.txtMeses.Text);
            if (this.txtNombreCodeudor1.Text.Trim() != "")
            {
                credito.intTipoGarantia = 1;
            }
            if (Convert.ToInt32(this.txtAhorrado.Text) > 0)
            {
                credito.intTipoGarantia = 2;
            }
            if (this.rdbHipotecaria.Checked || this.rdbPrendaria.Checked)
            {
                credito.intTipoGarantia = 3;
            }
            credito.strApellido1Pre = this.txtApellidoPre1.Text.Trim();
            credito.strApellido2Pre = this.txtApellidoPre2.Text.Trim();
            credito.strApellidoCde = this.txtApellidoCodeudor1.Text.Trim();
            credito.strApellidoCde2 = this.txtApellidoCodeudor2.Text.Trim();
            credito.strCedulaCde = this.txtCedulaCodeudor1.Text.Trim();
            credito.strCedulaCde2 = this.txtCedulaCodeudor2.Text.Trim();
            credito.strCedulaPre = this.txtCedula.Text.Trim();
            credito.strCodigoPar = this.cboPar.SelectedValue.ToString();
            credito.strCodLineadeCredito = this.cboLinea.SelectedValue.ToString();
            credito.strDescripcionGarantiadelCredito = this.txtDescripcionGarantia.Text.Trim();
            credito.strDireccion = this.txtDireccion.Text.Trim();
            credito.strFormadeCobroPre = this.cboPago.Text;
            credito.strFrecuenciaPre = this.cboFrecuencia.Text;
            credito.strFormulario = this.Name;
            credito.strNombreCde = this.txtNombreCodeudor1.Text.Trim();
            credito.strNombreCde2 = this.txtNombreCodeudor2.Text.Trim();
            credito.strNombrePre = this.txtNombre.Text.Trim();
            credito.strTelefono = this.txtTelefono.Text.Trim();
            credito.strTelefonoCde = this.txtTelefonoCodeudor1.Text.Trim();
            credito.strTelefonoCde2 = this.txtTelefonoCodeudor2.Text.Trim();
            credito.strNombreLinea = this.cboLinea.Text;
            credito.strComputador = Environment.MachineName;
            credito.strUsuario = propiedades.strLogin;
            credito.dtmFechaExpedicion = this.dtmFechaExpedicion.Value;
            credito.strLugarExpedicion = this.txtLugardeExpedicion.Text;
            return credito;
        }


        /// <summary> De acuerdo al string devuelto por un metodo elabora un mensaje. </summary>
        /// <param name="tstrMensaje"> string que devuelve el objeto. </param>
        /// <param name="tstrFormulario"> formulario desde el que se esta mandando a contruir el mensaje</param>
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

        private void frmCreditos_Load(object sender, EventArgs e)
        {
            this.pmtdLimpiarText();

            this.gmtdPermisosBotones();
            this.cboLinea.DataSource = new blCreditosLinea().gmtdConsultarTodos();
            this.cboPar.DataSource = new blCuentaPar().gmtdConsultarTodos();

            if (this.cboLinea.Items.Count <= 0)
            {
                MessageBox.Show("Debe de ingresar lineas de crédito para utilizar esta pantalla. ", "Socios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnCancelar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnGuardar.Enabled = false;
                this.btnSalir.Enabled = false;
            }

            if (this.cboPar.Items.Count <= 0)
            {
                MessageBox.Show("Debe de ingresar´pares para utilizar esta pantalla. ", "Socios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnCancelar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnGuardar.Enabled = false;
                this.btnSalir.Enabled = false;
            }

            this.cboFrecuencia.SelectedIndex = 0;
            this.cboProcedencia.SelectedIndex = 0;
            this.cboPago.SelectedIndex = 0;

            this.rptCreditos.RefreshReport();
            this.rptRecibos.RefreshReport();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string strMensaje = new blCreditos().gmtdInsertar(crearObj());

            this.pmtdMensaje(strMensaje, "Credito");

            if (strMensaje.Substring(0, 1) != "-")
            {
                char[] separador = new char[]{'#'};

                string[] strVector = strMensaje.Split(separador);

                this.gmtdMostrarReporte("Recibo");

                this.gmtdMostrarReciboEgreso(strVector[1]);
            }
        }

        private void gmtdMostrarReporte(string tstrTipo)
        {
            List<SqlParameter> lstParameters = new List<SqlParameter>();
            SqlParameter parametro = new SqlParameter("@intPrestamo", SqlDbType.Int);
            parametro.Value = this.txtCodigo.Text;
            lstParameters.Add(parametro);
            DataSet ds = new DataSet();
            ds = propiedades.ejecutarSp(lstParameters, "spConsultaPrestamo");
            ReportDataSource datasource;
            datasource = new ReportDataSource("consultaPrestamos_spConsultaPrestamo", ds.Tables[0]);

            List<Microsoft.Reporting.WinForms.ReportParameter> lstParametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Pretsamo", this.txtCodigo.Text);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Mutual", propiedades.strNombreMutual);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Nit", propiedades.strNit);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Personeria", propiedades.strPersoneria);
            lstParametros.Add(parametroReporte);

            rptCreditos.Reset();
            rptCreditos.Visible = true;
            rptCreditos.Left = 0;
            rptCreditos.Top = 0;
            if (tstrTipo == "Consulta")
            {
                rptCreditos.Height = 345;
                rptCreditos.Width = 933;
            }
            else
            {
                rptCreditos.Height = 192;
                rptCreditos.Width = 933;
            }
            rptCreditos.ProcessingMode = ProcessingMode.Local;
            rptCreditos.LocalReport.DataSources.Clear();
            rptCreditos.LocalReport.DataSources.Add(datasource);
            rptCreditos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Creditos.Reportes.rptCreditos.rdlc";
            rptCreditos.LocalReport.SetParameters(lstParametros);
            rptCreditos.LocalReport.Refresh();

            this.rptCreditos.RefreshReport();
        }

        private void gmtdMostrarReciboEgreso(string tstrRecibo)
        {
            List<SqlParameter> lstParameters = new List<SqlParameter>();
            SqlParameter parametro = new SqlParameter("@intCodigoEgr", SqlDbType.Int);
            parametro.Value = tstrRecibo;
            lstParameters.Add(parametro);
            DataSet ds = new DataSet();
            ds = propiedades.ejecutarSp(lstParameters, "spImprimirRecibosdeEgresos");
            ReportDataSource datasource;
            datasource = new ReportDataSource("spImprimirRecibosdeEgresos_spImprimirRecibosdeEgresos", ds.Tables[0]);

            List<Microsoft.Reporting.WinForms.ReportParameter> lstParametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Recibo", tstrRecibo);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("nombreMutual", propiedades.strNombreMutual);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Telefono", propiedades.strNit);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Personeria", propiedades.strPersoneria);
            lstParametros.Add(parametroReporte);

            rptRecibos.Reset();
            rptRecibos.Visible = true;
            rptRecibos.Left = 4;
            rptRecibos.Top = 201;
            rptRecibos.Height = 146;
            rptRecibos.Width = 932;
            rptRecibos.ProcessingMode = ProcessingMode.Local;
            rptRecibos.LocalReport.DataSources.Clear();
            rptRecibos.LocalReport.DataSources.Add(datasource);
            rptRecibos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Movimientos.Reportes.rptEgresos.rdlc";
            rptRecibos.LocalReport.SetParameters(lstParametros);
            rptRecibos.LocalReport.Refresh();

            this.rptRecibos.RefreshReport();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.gmtdMostrarReporte("Consulta");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.gmtdMostrarReporte("Consulta");
            DialogResult dlgResult = MessageBox.Show("Confirma que desea eliminar este registro? ", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlgResult == DialogResult.Yes)
            {
                this.pmtdMensaje(new blCreditos().gmtdEliminar(crearObj()), "Credito");
            }
            this.pmtdLimpiarText();
            this.pmtdHabilitarText(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.pmtdLimpiarText();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            propiedades.strFormActivo = "Principal";
            this.Dispose();
        }

        private void frmCreditos_FormClosed(object sender, FormClosedEventArgs e)
        {
            propiedades.strFormActivo = "Principal";
            this.Dispose();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtCedula.Focus();
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtNombre.Focus();
            }
        }

        private void txtSocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtNombre.Focus();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtApellidoPre1.Focus();
            }
        }

        private void txtApellidoPre1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtApellidoPre2.Focus();
            }
        }

        private void txtApellidoPre2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtPagare.Focus();
            }

        }

        private void txtPagare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.cboFrecuencia.Focus();
            }
        }

        private void cboFrecuencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.cboLinea.Focus();
            }
        }

        private void cboLinea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.dtpFechaPre.Focus();
            }

        }

        private void dtpFechaPre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtMonto.Focus();
            }
        }

        private void txtIntereses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtMonto.Focus();
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtMeses.Focus();
            }

        }

        private void txtMeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.cboPago.Focus();
            }

        }

        private void cboPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.cboProcedencia.Focus();
            }

        }

        private void cboProcedencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtTelefono.Focus();
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtDireccion.Focus();
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.cboPar.Focus();
            }
        }

        private void cboPar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.dtmFechaExpedicion.Focus();
            }
        }

        private void txtCedulaCodeudor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtNombreCodeudor1.Focus();
            }
        }

        private void txtNombreCodeudor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtApellidoCodeudor1.Focus();
            }
        }

        private void txtApellidoCodeudor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtTelefonoCodeudor1.Focus();
            }
        }

        private void txtTelefonoCodeudor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtCedulaCodeudor2.Focus();
            }
        }

        private void txtCedulaCodeudor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtNombreCodeudor2.Focus();
            }

        }

        private void txtNombreCodeudor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtApellidoCodeudor2.Focus();
            }

        }

        private void txtApellidoCodeudor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtTelefonoCodeudor2.Focus();
            }

        }

        private void txtTelefonoCodeudor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnGuardar.Focus();
            }

        }

        private void chkAhorros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtAhorrado.Focus();
            }
        }

        private void txtAhorrado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnGuardar.Focus();
            }
        }

        private void rdbHipotecaria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.rdbPrendaria.Focus();
            }
        }

        private void rdbPrendaria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtDescripcionGarantia.Focus();
            }
        }

        private void txtDescripcionGarantia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnGuardar.Focus();
            }
        }

        private void txtCedulaCodeudor1_Leave(object sender, EventArgs e)
        {
            this.dataCodeudor1.AutoGenerateColumns = false;
            this.dataCodeudor1.DataSource = new blCreditos().gmtdConsultarCreditosxPersona(this.txtCedula.Text);
        }

        private void txtCedulaCodeudor2_Leave(object sender, EventArgs e)
        {
            this.dataCodeudor2.AutoGenerateColumns = false;
            this.dataCodeudor2.DataSource = new blCreditos().gmtdConsultarCreditosxPersona(this.txtCedula.Text);
        }

        private void cboLinea_Leave(object sender, EventArgs e)
        {
            switch (this.cboFrecuencia.Text)
            {
                case "Mensual":
                    this.txtIntereses.Text = Convert.ToString(new blCreditosLinea().gmtdConsultarValordeInteres(this.cboLinea.SelectedValue.ToString(), propiedades.FrecuenciaPago.Mensual)).ToString();
                    break;
                case "Quincenal":
                    this.txtIntereses.Text = Convert.ToString(new blCreditosLinea().gmtdConsultarValordeInteres(this.cboLinea.SelectedValue.ToString(), propiedades.FrecuenciaPago.Quincenal)).ToString();
                    break;
                case "Decadal":
                    this.txtIntereses.Text = Convert.ToString(new blCreditosLinea().gmtdConsultarValordeInteres(this.cboLinea.SelectedValue.ToString(), propiedades.FrecuenciaPago.Decadal)).ToString();
                    break;
                case "Semanal":
                    this.txtIntereses.Text = Convert.ToString(new blCreditosLinea().gmtdConsultarValordeInteres(this.cboLinea.SelectedValue.ToString(), propiedades.FrecuenciaPago.Semanal)).ToString();
                    break;
                case "Termino":
                    this.txtIntereses.Text = Convert.ToString(new blCreditosLinea().gmtdConsultarValordeInteres(this.cboLinea.SelectedValue.ToString(), propiedades.FrecuenciaPago.Mensual)).ToString();
                    break;
            }
        }

        private void txtMonto_Leave(object sender, EventArgs e)
        {
            if (this.txtMonto.Text.Trim() != "" && this.txtMonto.Text.Trim() != "0"
                && this.txtIntereses.Text.Trim() != "" && this.txtIntereses.Text.Trim() != "0"
                && this.txtMeses.Text.Trim() != "" && this.txtMeses.Text.Trim() != "0"
                && this.cboFrecuencia.Text != "")
            {
                tblCredito credito = new tblCredito();
                credito.strFrecuenciaPre = this.cboFrecuencia.Text;
                credito.decMonto = Convert.ToDecimal(this.txtMonto.Text);
                credito.decIntereses = Convert.ToDecimal(this.txtIntereses.Text);
                credito.intCuotas = Convert.ToInt32(this.txtMeses.Text);
                this.txtValorCuota.Text = new blCreditos().gmtCalcularValordeCuota(credito).ToString("#,#00.00");
            }
        }

        private void txtMeses_Leave(object sender, EventArgs e)
        {
            if (this.txtMonto.Text.Trim() != "" && this.txtMonto.Text.Trim() != "0"
                && this.txtIntereses.Text.Trim() != "" && this.txtIntereses.Text.Trim() != "0"
                && this.txtMeses.Text.Trim() != "" && this.txtMeses.Text.Trim() != "0"
                && this.cboFrecuencia.Text != "")
            {
                tblCredito credito = new tblCredito();
                credito.strFrecuenciaPre = this.cboFrecuencia.Text;
                credito.decMonto = Convert.ToDecimal(this.txtMonto.Text);
                credito.decIntereses = Convert.ToDecimal(this.txtIntereses.Text);
                credito.intCuotas = Convert.ToInt32(this.txtMeses.Text);
                this.txtValorCuota.Text = new blCreditos().gmtCalcularValordeCuota(credito).ToString("#,#00.00");
            }
        }

        private void txtIntereses_Leave(object sender, EventArgs e)
        {
            if (this.txtMonto.Text.Trim() != "" && this.txtMonto.Text.Trim() != "0"
                && this.txtIntereses.Text.Trim() != "" && this.txtIntereses.Text.Trim() != "0"
                && this.txtMeses.Text.Trim() != "" && this.txtMeses.Text.Trim() != "0"
                && this.cboFrecuencia.Text != "")
            {
                tblCredito credito = new tblCredito();
                credito.strFrecuenciaPre = this.cboFrecuencia.Text;
                credito.decMonto = Convert.ToDecimal(this.txtMonto.Text);
                credito.decIntereses = Convert.ToDecimal(this.txtIntereses.Text);
                credito.intCuotas = Convert.ToInt32(this.txtMeses.Text);
                this.txtValorCuota.Text = new blCreditos().gmtCalcularValordeCuota(credito).ToString("#,#00.00");
            }

        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (new blCreditos().gmtdConsultar(Convert.ToInt32(this.txtCodigo.Text)).strNombreCde != null)
            {
                MessageBox.Show("Este credito ya aparece ingresado.", "Crédito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.pmtdLimpiarText();
                this.txtCodigo.Focus();
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            propiedades.strFormActivo = "Principal";
            this.Dispose();
        }

        private void txtIntereses_Leave_1(object sender, EventArgs e)
        {
            if (this.txtIntereses.Text.Trim() == "")
            {
                this.txtIntereses.Text = "0";
            }
        }

        private void txtMonto_Leave_1(object sender, EventArgs e)
        {
            if (this.txtMonto.Text.Trim() == "")
            {
                this.txtMonto.Text = "0";
            }
        }

        private void txtAhorrado_Leave(object sender, EventArgs e)
        {
            if (this.txtAhorrado.Text.Trim() == "")
            {
                this.txtAhorrado.Text = "0";
            }

        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            tblSocio socio =  new blSocio().gmtdConsultarDetalle(this.txtCedula.Text);
            if (socio.strApellido1Soc != null)
            {
                this.txtSocio.Text = socio.intCodigoSoc.ToString();
                this.txtNombre.Text = socio.strNombreSoc;
                this.txtApellidoPre1.Text = socio.strApellido1Soc;
                this.txtApellidoPre2.Text = socio.strApellido2Soc;
            }
            else
            {
                tblAgraciado agraciado = new blAgraciado().gmtdConsultar(this.txtCedula.Text);
                if (agraciado.strNombreAgra != null)
                {
                    this.txtSocio.Text = agraciado.intCodigoSoc.ToString();
                    this.txtNombre.Text = agraciado.strNombreAgra;
                    this.txtApellidoPre1.Text = agraciado.strApellido1Agra;
                    this.txtApellidoPre2.Text = agraciado.strApellido2Agra;
                }
            }


            this.datosDeudor.AutoGenerateColumns = false;
            this.datosDeudor.DataSource = new blCreditos().gmtdConsultarCreditosxPersona(this.txtCedula.Text);

        }

        private void txtLugardeExpedicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtCedulaCodeudor1.Focus();
            }
        }

        private void dtmFechaExpedicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtLugardeExpedicion.Focus();
            }
        }
    }
}
