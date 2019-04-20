namespace Mutuales2020.Movimientos
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using Microsoft.Reporting.WinForms;
    using Mutuales2020;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Windows.Forms;

    public partial class frmEgresos : Form
    {
        tblEgreso egresoConsultado = new tblEgreso();
        private static frmEgresos form = null;
        public static frmEgresos DefInstance
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new frmEgresos();
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

        public frmEgresos()
        {
            InitializeComponent();
        }

        #region Metodos

        /// <summary> Habilita o deshabilita los botones de acuerdo a las opciones en la base de datos. </summary>
        private void gmtdPermisosBotones()
        {
            Program.gmtdAsignarPermisos(ref btnGuardar, ref btnNuevo, ref btnEliminar);
        }

        /// <summary> Calcula el gran total del recibo. </summary>
        private void pmtdCalcularGranTotal()
        {
            decimal decIntereses = 0;

            if (this.chkIntereses.Checked)
                decIntereses = Convert.ToDecimal(this.txtIntereses.Text);

            this.txtGranTotal.Text = (Convert.ToDecimal(this.txtTotalEgresos.Text) + Convert.ToDecimal(this.txtRetirar.Text) + decIntereses + Convert.ToDecimal(this.txtValoraRetirarPrestamo.Text) + Convert.ToDecimal(this.txtRetirarFijo.Text) + Convert.ToDecimal(this.txtRetirarEstudiante.Text)).ToString("#,#00.00");
        }

        private void pmtdCalcularTotalEgresos()
        {
            decimal decTotal = 0;

            for (int a = 0; a < this.dgvEgresos.RowCount; a++)
                decTotal += Convert.ToDecimal(this.dgvEgresos[2, a].Value) + (Convert.ToDecimal(this.dgvEgresos[2, a].Value) * (Convert.ToDecimal(this.dgvEgresos[3, a].Value) / 100)) - (Convert.ToDecimal(this.dgvEgresos[2, a].Value) * (Convert.ToDecimal(this.dgvEgresos[4, a].Value) / 100));

            this.txtTotalEgresos.Text = decTotal.ToString();

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

        #region limpiarControles

        /// <summary> Agrupa la limpieza de todos los controles. </summary>
        private void pmtdLimpiarControles()
        {
            this.pmtdLimpiarControlesPrincipal();
            this.pmtdLimpiarControlesEgresos();
            this.pmtdLimpiarControlesAhorrosalaVista();
            this.pmtdLimpiarControlesAbonoaPrestamos();
            this.pmtdLimpiarControlesRetidosFijos();
            this.pmtdLimpiarControlesRetidosEstudiantes();
        }

        /// <summary> Limpia los controles del encabezado del formulario. </summary>
        private void pmtdLimpiarControlesPrincipal()
        {
            this.txtEgreso.Text = "0";
            this.txtIdentificacion.Text = "0";
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.txtGranTotal.Text = "0";
            this.chkCheque.Checked = false;
            this.btnAnulado.Visible = false;
            //this.cboRetirar.SelectedIndex = 0;
        }

        /// <summary> Limpia los controles de los egresos. </summary>
        private void pmtdLimpiarControlesEgresos()
        {
            //this.cboEgresos.SelectedIndex = 0;
            this.txtDescripcion.Text = "";
            this.txtTotalEgresos.Text = "0";
            this.txtValor.Text = "0";
            this.txtPorcentajeIva.Text = "0";
            this.txtPorcentajeRetencion.Text = "0";
            this.dgvEgresos.Rows.Clear();
            this.chkEgresos.Checked = false;

        }

        /// <summary> Limpia los controles de los retiros de ahorros a la vista. </summary>
        private void pmtdLimpiarControlesAhorrosalaVista()
        {
            this.txtAhorrado.Text = "0";
            this.txtRetirar.Text = "0";
            this.txtIntereses.Text = "0";
            this.txtApellidoAut.Text = "";
            this.txtCedulaAut.Text = "";
            this.txtNombreAut.Text = "";
            this.chkRetirar.Checked = false;
            this.chkIntereses.Checked = false;
            this.chk4xMil.Checked = false;
            this.dgvAhorrosalaVista.AutoGenerateColumns = false;
            this.dgvAhorrosalaVista.DataSource = new blRecibosIngresosAhorros().gmtdConsultarTransacciones("-1");
        }

        /// <summary> Limpia los controles de abono a préstamos. </summary>
        private void pmtdLimpiarControlesAbonoaPrestamos()
        {
            this.txtValoraRetirarPrestamo.Text = "0";
            if (this.cboPrestamosAbono.Items.Count > 0)
            {
                this.cboPrestamosAbono.SelectedIndex = 0;
            }
            this.chkRetirosPrestamo.Checked = false;
            this.txtAbonoaPrestamosActual.Text = "0";
        }

        /// <summary> Limpia los controles de los retiros fijos. </summary>
        private void pmtdLimpiarControlesRetidosFijos()
        {
            this.txtAhorradoFijo.Text = "0";
            this.txtRetirarFijo.Text = "0";
            this.chkRetirosFijos.Checked = false;
            this.dgvRetirosFijo.AutoGenerateColumns = false;
            this.dgvRetirosFijo.DataSource = new blRecibosIngresosAhorros().gmtdConsultarTransaccionesFijas("-1");
        }

        /// <summary> Limpia los controles de los retiros fijos. </summary>
        private void pmtdLimpiarControlesRetidosEstudiantes()
        {
            this.txtAhorradoEstudiante.Text = "0";
            this.txtRetirarEstudiante.Text = "0";
            this.chkRetirarEstudiante.Checked = false;
            this.dgvAhorrosEstudiantil.AutoGenerateColumns = false;
            this.dgvAhorrosEstudiantil.DataSource = new blRecibosIngresosAhorros().gmtdConsultarTransaccionesEstudiantiles("-1");
        }

        #endregion

        #region habilitarControles

        private void pmtdHabilitarControles(bool bitA)
        {
            this.pmtdHabilitarControlesPrincipal(bitA);
            this.pmtdHabilitarControlesEgresos(bitA);
            this.pmtdHabilitarControlesAhorrosalaVista(bitA);
            this.pmtdHabilitarControlesAbonoaPrestamos(bitA);
            this.pmtdHabilitarControlesRetidosFijos(bitA);
            this.pmtdHabilitarControlesRetidosEstudiantiles(bitA);
        }

        /// <summary> Habilita los controles modificables del encabezado del formulario. </summary>
        /// <param name="bitA"> Un valor boleano que habilitara o deshabilitara los controles. </param>
        private void pmtdHabilitarControlesPrincipal(bool bitA)
        {
            //this.txtIdentificacion.Enabled = bitA;
            //this.cboRetirar.Enabled = bitA;
            this.chkCheque.Enabled = bitA;
        }

        /// <summary> Habilita los controles modificables de los egresos. </summary>
        /// <param name="bitA"> Un valor boleano que habilitara o deshabilitara los controles. </param>
        private void pmtdHabilitarControlesEgresos(bool bitA)
        {
            this.cboEgresos.Enabled = bitA;
            this.txtDescripcion.Enabled = bitA;
            this.txtValor.Enabled = bitA;
            this.txtPorcentajeIva.Enabled = bitA;
            this.txtPorcentajeRetencion.Enabled = bitA;
            this.chkEgresos.Enabled = bitA;
            this.btnAgregarEgresos.Enabled = bitA;
            this.btnEliminarEgresos.Enabled = bitA;
        }

        /// <summary> Habilita los controles modificables de los egresos. </summary>
        /// <param name="bitA"> Un valor boleano que habilitara o deshabilitara los controles. </param>
        private void pmtdHabilitarControlesAhorrosalaVista(bool bitA)
        {
            this.txtRetirar.Enabled = bitA;
            this.chkRetirar.Enabled = bitA;
            this.chkIntereses.Enabled = bitA;
        }

        /// <summary> Habilita los controles modificables de los retiros de abonos a prestamo. </summary>
        /// <param name="bitA"> Un valor boleano que habilitara o deshabilitara los controles. </param>
        private void pmtdHabilitarControlesAbonoaPrestamos(bool bitA)
        {
            this.txtValoraRetirarPrestamo.Enabled = bitA;
            this.chkRetirosPrestamo.Enabled = bitA;
        }

        /// <summary> Habilita los controles modificables de los retiros de ahorros fijos. </summary>
        /// <param name="bitA"> Un valor boleano que habilitara o deshabilitara los controles. </param>
        private void pmtdHabilitarControlesRetidosFijos(bool bitA)
        {
            this.txtRetirarFijo.Enabled = bitA;
            this.chkRetirosFijos.Enabled = bitA;
        }

        /// <summary> Habilita los controles modificables de los retiros de ahorros fijos. </summary>
        /// <param name="bitA"> Un valor boleano que habilitara o deshabilitara los controles. </param>
        private void pmtdHabilitarControlesRetidosEstudiantiles(bool bitA)
        {
            this.txtRetirarEstudiante.Enabled = bitA;
            this.chkRetirarEstudiante.Enabled = bitA;
        }

        #endregion

        private void pmtdConsultarDeudaCreditos()
        { 
            decimal decValorCreditos = 0;

            List<creditoss> lstCreditosxAhorradores = new blCreditos().gmtdConsultarCreditosxPersona(this.txtIdentificacion.Text);

            foreach (creditoss credito in lstCreditosxAhorradores)
            {
                decValorCreditos += credito.decValorDebePre;
            }

            if (decValorCreditos > 0)
            { 
                MessageBox.Show("Esta persona tiene deuda en créditos por un valor de $ " + decValorCreditos.ToString("#,#00.00"), "Créditos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gmtdMostrarReciboEgreso()
        {
            List<SqlParameter> lstParameters = new List<SqlParameter>();
            SqlParameter parametro = new SqlParameter("@intCodigoEgr", SqlDbType.Int);
            parametro.Value = this.txtEgreso.Text;
            lstParameters.Add(parametro);
            DataSet ds = new DataSet();
            ds = propiedades.ejecutarSp(lstParameters, "spImprimirRecibosdeEgresos");
            ReportDataSource datasource;
            datasource = new ReportDataSource("spImprimirRecibosdeEgresos_spImprimirRecibosdeEgresos", ds.Tables[0]);

            List<Microsoft.Reporting.WinForms.ReportParameter> lstParametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Recibo", this.txtEgreso.Text);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("nombreMutual", propiedades.strNombreMutual);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Telefono", propiedades.strNit);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Personeria", propiedades.strPersoneria);
            lstParametros.Add(parametroReporte);

            rptRecibos.Reset();
            rptRecibos.Visible = true;
            rptRecibos.Left = 0;
            rptRecibos.Top = 0;
            rptRecibos.Height = 328;
            rptRecibos.Width = 680;
            rptRecibos.ProcessingMode = ProcessingMode.Local;
            rptRecibos.LocalReport.DataSources.Clear();
            rptRecibos.LocalReport.DataSources.Add(datasource);
            rptRecibos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Movimientos.Reportes.rptEgresos.rdlc";
            rptRecibos.LocalReport.SetParameters(lstParametros);
            rptRecibos.LocalReport.Refresh();

            this.rptRecibos.RefreshReport();
        }

        private void gmtdMostrarReciboTransacciones()
        {
            List<SqlParameter> lstParameters = new List<SqlParameter>();
            SqlParameter parametro = new SqlParameter("@intCodigoRec", SqlDbType.Int);
            parametro.Value = this.txtEgreso.Text;
            lstParameters.Add(parametro);
            parametro = new SqlParameter("@strTransaccion", SqlDbType.VarChar);
            parametro.Value = "Retiros";
            lstParameters.Add(parametro);
            DataSet ds = new DataSet();
            ds = propiedades.ejecutarSp(lstParameters, "spImprimirReciboTransacciones");
            ReportDataSource datasource;
            datasource = new ReportDataSource("spImprimirReciboTransacciones_spImprimirReciboTransacciones", ds.Tables[0]);

            List<Microsoft.Reporting.WinForms.ReportParameter> lstParametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Recibo", this.txtEgreso.Text);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("nombreMutual", propiedades.strNombreMutual);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Telefono", propiedades.strNit);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Personeria", propiedades.strPersoneria);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("SaldoAnterior", this.txtAhorrado.Text);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Transaccion", "Retiro");
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Acumula", this.txtRetirar.Text);
            lstParametros.Add(parametroReporte);

            rptRecibos.Reset();
            rptRecibos.Visible = true;
            rptRecibos.Left = 0;
            rptRecibos.Top = 0;
            rptRecibos.Height = 312;
            rptRecibos.Width = 680;
            rptRecibos.ProcessingMode = ProcessingMode.Local;
            rptRecibos.LocalReport.DataSources.Clear();
            rptRecibos.LocalReport.DataSources.Add(datasource);
            rptRecibos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Movimientos.Reportes.rptTransacciones.rdlc";
            rptRecibos.LocalReport.SetParameters(lstParametros);
            rptRecibos.LocalReport.Refresh();

            this.rptRecibos.RefreshReport();
        }

        private void cboRetirar_Enter(object sender, EventArgs e)
        {
            this.pmtdLimpiarControles();
        }

        private void txtIdentificacion_Enter(object sender, EventArgs e)
        {
            this.pmtdLimpiarControles();
        }

        private void cboRetirar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtIdentificacion.Focus();

                switch (this.cboRetirar.SelectedIndex)
                { 
                    case 0:
                        this.txtIdentificacion.Tipo = Texto.Texto.Opciones.Texto;
                        break;
                }
            }
        }

        private void frmEgresos_Load(object sender, EventArgs e)
        {
            this.cboEgresos.DataSource = new blOtroEgreso().gmtdConsultarTodosxNombre();
            this.rptRecibos.RefreshReport();
            this.gmtdPermisosBotones();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.pmtdLimpiarControles();
            this.pmtdHabilitarControles(false);
            this.cboRetirar.Enabled = true;
            this.txtIdentificacion.Enabled = true;
            this.cboRetirar.SelectedIndex = 0;
            this.rptRecibos.Visible = false;
            this.cboRetirar.Focus();
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                switch (this.cboRetirar.SelectedIndex)
                { 
                    case 0:
                        tblCliente cliente = new blCliente().gmtdConsultarDetalle(this.txtIdentificacion.Text);
                        if (cliente.strContacto != null)
                        {
                            this.txtNombre.Text = cliente.strContacto;
                            this.pmtdHabilitarControlesEgresos(true);
                            this.chkEgresos.Focus();
                        }
                        break;
                    case 4:
                        //Datos de las cuotas de préstamos.
                        List<tblCredito> lstCreditos = new blRecibosIngresosPrestamos().gmtdConsultaCreditosParaRecibo(this.txtIdentificacion.Text);
                        if (lstCreditos.Count > 0)
                        {
                            tblCredito Credito =  new blCreditos().gmtdConsultar(this.txtIdentificacion.Text);
                            this.txtNombre.Text = Credito.strNombrePre;
                            this.txtApellido.Text = Credito.strApellido1Pre + " " + Credito.strApellido2Pre;
                            this.chkRetirosPrestamo.Enabled = true;
                        }

                        break;
                    default:
                        tblAhorradore ahorrador = new blAhorrador().gmtdConsultar(this.txtIdentificacion.Text);
                        if (ahorrador != null)
                        {
                            this.txtNombre.Text = ahorrador.strNombreAho;
                            this.txtApellido.Text = ahorrador.strApellido1Aho + " " + ahorrador.strApellido2Aho;

                            this.txtAhorrado.Text = ahorrador.decAhorrado.ToString();
                            this.txtIntereses.Text = ahorrador.decIntereses.ToString();
                            this.txtCedulaAut.Text = ahorrador.strCedulaAut;
                            this.txtNombreAut.Text = ahorrador.strNombreAut;
                            this.txtApellidoAut.Text = ahorrador.strApellidoAut;
                            this.txtRetirar.Enabled = true;
                            this.chkRetirar.Enabled = true;
                            this.chkIntereses.Enabled = true;
                            this.chk4xMil.Checked = Convert.ToBoolean(ahorrador.bitCobraCuatroxMil);
                            this.dgvAhorrosalaVista.DataSource = new blRecibosIngresosAhorros().gmtdConsultarTransacciones(this.txtIdentificacion.Text);

                            this.txtAhorradoEstudiante.Text = ahorrador.decAhorrosEstudiantes.ToString();
                            this.txtRetirarEstudiante.Enabled = true;
                            this.chkRetirarEstudiante.Enabled = true;
                            this.dgvAhorrosEstudiantil.DataSource = new blRecibosIngresosAhorros().gmtdConsultarTransaccionesEstudiantiles(this.txtIdentificacion.Text);

                            this.txtAhorradoFijo.Text = ahorrador.decAhorrosFijo.ToString();
                            this.txtRetirarFijo.Enabled = true;
                            this.chkRetirosFijos.Enabled = true;
                            this.dgvRetirosFijo.AutoGenerateColumns = false;
                            this.dgvRetirosFijo.DataSource = new blRecibosIngresosAhorros().gmtdConsultarTransaccionesFijas(this.txtIdentificacion.Text);


                            this.pmtdConsultarDeudaCreditos();
                        }
                        break;

                }
            }
        }

        private void chkEgresos_Click(object sender, EventArgs e)
        {
            if (this.chkEgresos.Checked == true)
            {
                this.cboEgresos.Focus();
            }
            else
            {
                this.txtDescripcion.Text = "";
                this.txtTotalEgresos.Text = "0";
                this.txtValor.Text = "0";
                this.txtPorcentajeIva.Text = "0";
                this.txtPorcentajeRetencion.Text = "0";
                this.dgvEgresos.Rows.Clear();
            }
        }

        private void cboEgresos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtDescripcion.Focus();
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtValor.Focus();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtPorcentajeIva.Focus();
        }

        private void txtPorcentajeIva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtPorcentajeRetencion.Focus();
        }

        private void txtPorcentajeRetencion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.btnAgregarEgresos.Focus();
        }

        private void btnAgregarEgresos_Click(object sender, EventArgs e)
        {
            if (this.cboEgresos.Text.Trim() == "")
            {
                MessageBox.Show("Debe de seleccionar un item para clasificar el egreso", "Egresos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Debe de ingresar la descripción del egreso", "Egresos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.txtValor.Text.Trim() == "" || this.txtValor.Text.Trim() == "0")
            {
                MessageBox.Show("Debe de ingresar el valor del item", "Egresos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.dgvEgresos.RowCount >= 3)
            {
                MessageBox.Show("No se pueden ingresar mas de 3 items", "Egresos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal decValor = 0;
            decimal decIva = 0;
            decimal decRetencion = 0;

            decValor = Convert.ToDecimal(this.txtValor.Text.Trim());

            if (this.txtPorcentajeIva.Text.Trim() != "" || this.txtPorcentajeIva.Text.Trim() != "0")
            {
                decIva = (decValor * (Convert.ToDecimal(this.txtPorcentajeIva.Text.Trim()) / 100));
            }

            if (this.txtPorcentajeRetencion.Text.Trim() != "" || this.txtPorcentajeRetencion.Text.Trim() != "0")
            {
                decRetencion = (decValor * (Convert.ToDecimal(this.txtPorcentajeRetencion.Text.Trim()) / 100));
            }

            //decValor += decIva - decRetencion;

            string[] ventor = new string[5] { this.cboEgresos.SelectedValue.ToString(), this.txtDescripcion.Text, decValor.ToString(), this.txtPorcentajeIva.Text, this.txtPorcentajeRetencion.Text };
            this.dgvEgresos.Rows.Add(ventor);

            this.pmtdCalcularTotalEgresos();

            this.cboEgresos.SelectedIndex = 0;
            this.txtDescripcion.Text = "";
            this.txtValor.Text = "0";
            this.txtPorcentajeIva.Text = "0";
            this.txtPorcentajeRetencion.Text = "0";

            this.cboEgresos.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtIdentificacion.Text.Trim() == "0" || this.txtIdentificacion.Text.Trim() == ""
                || this.txtGranTotal.Text.Trim() == "0" || this.txtGranTotal.Text.Trim() == ""
                || this.txtNombre.Text.Trim() == "" || this.cboEgresos.Text.Trim() == "")
            {
                MessageBox.Show("Debe de ingresar la identificación del cliente. ", "Egreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.chkEgresos.Checked == false && this.chkRetirar.Checked == false
                && this.chkIntereses.Checked == false && this.chkRetirosPrestamo.Checked == false
                && this.chkRetirosFijos.Checked == false && this.chkRetirarEstudiante.Checked == false)
            {
                MessageBox.Show("Debe de seleccionar un tipo de recibo a realizar.");
                return;
            }

            tblEgreso egreso = new tblEgreso();
            egreso.bitAnulado = false;
            egreso.bitCheque = this.chkCheque.Checked;
            egreso.bitRetiroAhorroaFuturoLiquidacion = false;
            egreso.bitRetiroAhorroNavidenoLiquidacion = false;
            egreso.dtmFechaAnu = Convert.ToDateTime("1/1/1900");
            egreso.dtmFechaRec = new blConfiguracion().gmtdCapturarFechadelServidor();
            egreso.decTotal = Convert.ToDecimal(this.txtGranTotal.Text);
            egreso.strApellido = string.Empty;
            egreso.strCedulaEgre = this.txtIdentificacion.Text;
            egreso.strLetras = new blConfiguracion().montoenLetras(this.txtGranTotal.Text);
            egreso.strNombre = this.txtNombre.Text;
            egreso.strFormulario = this.Name;
            egreso.strMaquina = Environment.MachineName;
            egreso.strUsuario = propiedades.strLogin;

            if (this.chkEgresos.Checked)
            {
                if (this.dgvEgresos.RowCount <= 1)
                {
                    MessageBox.Show("Debe de adicionar registros a los egresos.");
                    return;
                }

                List<tblEgresosEgreso> lstEgresos = new List<tblEgresosEgreso>();

                for (int a = 0; a < this.dgvEgresos.RowCount - 1; a++)
                {
                    tblEgresosEgreso reciboEgreso = new tblEgresosEgreso();
                    reciboEgreso.decIva = Convert.ToDecimal(this.dgvEgresos[3, a].Value);
                    reciboEgreso.decValorIva = Convert.ToDecimal(this.dgvEgresos[2, a].Value) * (reciboEgreso.decIva / 100);
                    reciboEgreso.decRetencion = Convert.ToDecimal(this.dgvEgresos[4, a].Value);
                    reciboEgreso.decValorRetencion = Convert.ToDecimal(this.dgvEgresos[2, a].Value) * (reciboEgreso.decRetencion / 100);
                    reciboEgreso.decValorBruto = Convert.ToDecimal(this.dgvEgresos[2, a].Value);
                    reciboEgreso.decValorNeto = Convert.ToDecimal(this.dgvEgresos[2, a].Value) + reciboEgreso.decValorIva - reciboEgreso.decValorRetencion;
                    reciboEgreso.strCodOtrosEgresos = this.dgvEgresos[0, a].Value.ToString();
                    reciboEgreso.strDescripcion = this.dgvEgresos[1, a].Value.ToString();

                    lstEgresos.Add(reciboEgreso);
                }

                egreso.bitEgreso = true;
                egreso.egresoEgreso = lstEgresos;
            }

            if (this.chkRetirar.Checked)
            {
                if (this.txtRetirar.Text.Trim() == "" || this.txtRetirar.Text.Trim() == "0")
                {
                    MessageBox.Show("Debe ingresar el valor a retirar.");
                    return;
                }

                if (Convert.ToDecimal(this.txtRetirar.Text) > Convert.ToDecimal(this.txtAhorrado.Text))
                {
                    MessageBox.Show("El valor a retirar no puede ser mayor al ahorrado.", "Egresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                tblEgresosAhorro egresoAhorro = new tblEgresosAhorro();
                egresoAhorro.decAhorrado = Convert.ToDecimal(this.txtAhorrado.Text);
                egresoAhorro.decRetiro = Convert.ToDecimal(this.txtRetirar.Text);
                egresoAhorro.decAcumula = egresoAhorro.decAhorrado - egresoAhorro.decRetiro;
                egresoAhorro.bitCobraCuatroxMil = Convert.ToBoolean(this.chk4xMil.Checked);

                egreso.egresoAhorroalaVista = egresoAhorro;
                egreso.bitRetiro = true;

            }

            if (this.chkRetirarEstudiante.Checked)
            {
                if (this.txtRetirarEstudiante.Text.Trim() == "" || this.txtRetirarEstudiante.Text.Trim() == "0")
                {
                    MessageBox.Show("Debe ingresar el valor a retirar del ahorro estudiantil.");
                    return;
                }

                if (Convert.ToDecimal(this.txtRetirarEstudiante.Text) > Convert.ToDecimal(this.txtAhorradoEstudiante.Text))
                {
                    MessageBox.Show("El valor a retirar no puede ser mayor al ahorrado.", "Egresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                tblEgresosAhorrosEstudiante egresoAhorroEstudiantil = new tblEgresosAhorrosEstudiante();
                egresoAhorroEstudiantil.decAhorrado = Convert.ToDecimal(this.txtAhorradoEstudiante.Text);
                egresoAhorroEstudiantil.decRetiro = Convert.ToDecimal(this.txtRetirarEstudiante.Text);
                egresoAhorroEstudiantil.decAcumula = egresoAhorroEstudiantil.decAhorrado - egresoAhorroEstudiantil.decRetiro;

                egreso.egresoAhorroEstudiantil = egresoAhorroEstudiantil;
                egreso.bitRetiroAhorroEstudiante = true;

            }

            if (this.chkRetirosFijos.Checked)
            {
                if (this.txtRetirarFijo.Text.Trim() == "" || this.txtRetirarFijo.Text.Trim() == "0")
                {
                    MessageBox.Show("Debe ingresar el valor a retirar del ahorro fijo.");
                    return;
                }

                if (Convert.ToDecimal(this.txtRetirarFijo.Text) > Convert.ToDecimal(this.txtAhorradoFijo.Text))
                {
                    MessageBox.Show("El valor a retirar no puede ser mayor al ahorrado.", "Egresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                tblEgresosAhorrosFijo egresoAhorroFijo = new tblEgresosAhorrosFijo();
                egresoAhorroFijo.decAhorrado = Convert.ToDecimal(this.txtAhorradoFijo.Text);
                egresoAhorroFijo.decRetiro = Convert.ToDecimal(this.txtRetirarFijo.Text);
                egresoAhorroFijo.decAcumula = egresoAhorroFijo.decAhorrado - egresoAhorroFijo.decRetiro;

                egreso.egresoAhorroFijo = egresoAhorroFijo;
                egreso.bitRetiroAhorroFijo = true;

            }

            if (this.chkIntereses.Checked)
            {
                if (this.txtIntereses.Text.Trim() == "" || this.txtIntereses.Text.Trim() == "0")
                {
                    MessageBox.Show("Debe ingresar el valor de intereses.");
                    return;
                }

                tblEgresosInterese egresoIntereses = new tblEgresosInterese();
                egresoIntereses.decIntereses = Convert.ToDecimal(this.txtIntereses.Text);

                egreso.egresoIntereses = egresoIntereses;
                egreso.bitRetiroIntereses = true;

            }

            if (this.chkRetirosPrestamo.Checked)
            {
                if (this.txtValoraRetirarPrestamo.Text.Trim() == "" || this.txtValoraRetirarPrestamo.Text.Trim() == "0")
                {
                    MessageBox.Show("Debe ingresar el valor de retiro de préstamos.");
                    return;
                }

                if (Convert.ToDecimal(this.txtValoraRetirarPrestamo.Text) > Convert.ToDecimal(this.txtAbonoaPrestamosActual.Text))
                {
                    MessageBox.Show("El valor a retirar no puede ser mayor al actual.", "Egresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtValoraRetirarPrestamo.Text = "0";
                    return;
                }
                tblEgresosPrestamosAbono egresoPrestamosAbono = new tblEgresosPrestamosAbono();
                egresoPrestamosAbono.decAbonoPrestamo = Convert.ToDecimal(this.txtValoraRetirarPrestamo.Text);
                egresoPrestamosAbono.intCodigoCre = Convert.ToInt16(this.cboPrestamosAbono.Text);

                egreso.egresoAbonoaPrestamo = egresoPrestamosAbono;
                egreso.bitRetiroAbonos = true;

            }

            string strResultado = new blRecibosEgresos().gmtdInsertar(egreso);

            if (strResultado.Substring(0, 1) == "-")
            {
                this.pmtdMensaje(strResultado, "Ingresos");
            }
            else
            {
                int intInicio = strResultado.LastIndexOf("+");
                this.txtEgreso.Text = strResultado.Substring(0, intInicio).Trim();

                if (egreso.bitRetiro && !egreso.bitRetiroIntereses)
                {
                    this.gmtdMostrarReciboTransacciones();
                }
                else
                {
                    this.gmtdMostrarReciboEgreso();
                }
            }

            //this.pmtdMensaje(strResultado, "Egresos");

            //if (strResultado.Substring(0, 1) != "-")
            //{
            //    if (MessageBox.Show("Desea imprimir el recibo. ", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            //    {
            //        if (egreso.bitRetiro)
            //        {
            //            rptTransacciones transacciones = new rptTransacciones();
            //            transacciones.DataDefinition.FormulaFields["strNombreMutual"].Text = "'" + propiedades.strNombreMutual + "'";
            //            transacciones.DataDefinition.FormulaFields["strTelefonoMutual"].Text = "'" + propiedades.strNit + "'";
            //            transacciones.DataDefinition.FormulaFields["strPersoneria"].Text = "'" + propiedades.strPersoneria + "'";
            //            transacciones.DataDefinition.FormulaFields["strTitulo"].Text = "'COMPROBANTE DE RETIRO'";
            //            transacciones.DataDefinition.FormulaFields["strTransaccion"].Text = "'Retiro'";
            //            transacciones.PrintToPrinter(1, false, 1, 1);
            //        }
            //        else
            //        {
            //            rptEgresos egresoNormal = new rptEgresos();
            //            egresoNormal.DataDefinition.FormulaFields["strNombreMutual"].Text = "'" + propiedades.strNombreMutual + "'";
            //            egresoNormal.DataDefinition.FormulaFields["strTelefonoMutual"].Text = "'" + propiedades.strNit + "'";
            //            egresoNormal.DataDefinition.FormulaFields["strPersoneria"].Text = "'" + propiedades.strPersoneria + "'";
            //            egresoNormal.PrintToPrinter(1, false, 1, 1);
            //        }
            //    }
            //}
            this.pmtdLimpiarControles();
            this.pmtdHabilitarControles(false);
        }

        private void txtTotalEgresos_TextChanged(object sender, EventArgs e)
        {
            if (this.txtTotalEgresos.Text.Trim() == "")
                this.txtTotalEgresos.Text = "0";

            this.pmtdCalcularGranTotal();
        }

        private void chkRetirosPrestamo_Click(object sender, EventArgs e)
        {
            if (this.chkRetirosPrestamo.Checked == true)
            {
                List<tblCredito> lstCreditos = new blRecibosIngresosPrestamos().gmtdConsultaCreditosParaRecibo(this.txtIdentificacion.Text);

                this.cboPrestamosAbono.Enabled = true;
                this.txtValoraRetirarPrestamo.Enabled = true;

                this.cboPrestamosAbono.Items.Clear();
                for (int a = 0; a < lstCreditos.Count; a++)
                    this.cboPrestamosAbono.Items.Add(lstCreditos[a].intCodigoCre);

                if (lstCreditos.Count > 0)
                {
                    MessageBox.Show("Esta persona tiene mas de un crédito activo.", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.cboPrestamosAbono.SelectedIndex = 0;
                    this.cboPrestamosAbono.Focus();
                }
            }
            else
            {
                this.cboPrestamosAbono.Enabled = false;
            }
        }

        private void cboPrestamosAbono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtValoraRetirarPrestamo.Focus();
        }

        private void cboPrestamosAbono_Leave(object sender, EventArgs e)
        {
            this.txtAbonoaPrestamosActual.Text = new blCreditos().gmtdConsultar(Convert.ToInt32(this.cboPrestamosAbono.Text)).decAbono.ToString();
        }

        private void txtValoraRetirarPrestamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (this.txtValoraRetirarPrestamo.Text == "" || this.txtValoraRetirarPrestamo.Text == "0")
                {
                    MessageBox.Show("Debe de ingresar el valor del retiro de abono a préstamo.", "Egresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtValoraRetirarPrestamo.Text = "0";
                    return;
                }

                if (Convert.ToDecimal(this.txtValoraRetirarPrestamo.Text) > Convert.ToDecimal(this.txtAbonoaPrestamosActual.Text))
                {
                    MessageBox.Show("El valor a retirar no puede ser mayor al actual.", "Egresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtValoraRetirarPrestamo.Text = "0";
                    return;
                }

                this.btnGuardar.Focus();
            }

        }

        private void txtValoraRetirarPrestamo_TextChanged(object sender, EventArgs e)
        {
            if (this.txtValoraRetirarPrestamo.Text.Trim() == "")
                this.txtValoraRetirarPrestamo.Text = "0";

            this.pmtdCalcularGranTotal();
        }

        private void txtRetirar_TextChanged(object sender, EventArgs e)
        {
            if (this.txtRetirar.Text.Trim() == "")
                this.txtRetirar.Text = "0";

            this.pmtdCalcularGranTotal();
        }

        private void txtRetirarFijo_TextChanged(object sender, EventArgs e)
        {
            if (this.txtRetirarFijo.Text.Trim() == "")
                this.txtRetirarFijo.Text = "0";

            this.pmtdCalcularGranTotal();
        }

        private void txtRetirarEstudiante_TextChanged(object sender, EventArgs e)
        {
            if (this.txtRetirarEstudiante.Text.Trim() == "")
                this.txtRetirarEstudiante.Text = "0";

            this.pmtdCalcularGranTotal();
        }

        private void chkRetirar_Click(object sender, EventArgs e)
        {
            this.txtRetirar.Text = "0";
            if (this.chkRetirar.Checked)
            {
                this.txtRetirar.Enabled = true;
                this.txtRetirar.Focus();
            }
            else
            {
                this.txtRetirar.Enabled = false;
            }
        }

        private void chkRetirosFijos_Click(object sender, EventArgs e)
        {
            this.txtRetirarFijo.Text = "0";
            if (this.chkRetirosFijos.Checked)
            {
                this.txtRetirarFijo.Enabled = true;
                this.txtRetirarFijo.Focus();
            }
            else
            {
                this.txtRetirarFijo.Enabled = false;
            }
        }

        private void chkRetirarEstudiante_Click(object sender, EventArgs e)
        {
            this.txtRetirarFijo.Text = "0";
            if (this.chkRetirosFijos.Checked)
            {
                this.txtRetirarFijo.Enabled = true;
                this.txtRetirarFijo.Focus();
            }
            else
            {
                this.txtRetirarFijo.Enabled = false;
            }
        }

        private void txtRetirar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (this.txtRetirar.Text == "" || this.txtRetirar.Text == "0")
                {
                    MessageBox.Show("Debe de ingresar el valor del retiro de ahorros.", "Egresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtValoraRetirarPrestamo.Text = "0";
                    return;
                }

                if (Convert.ToDecimal(this.txtRetirar.Text) > Convert.ToDecimal(this.txtAhorrado.Text))
                {
                    MessageBox.Show("El valor a retirar no puede ser mayor al ahorrado.", "Egresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtValoraRetirarPrestamo.Text = "0";
                    return;
                }

                this.btnGuardar.Focus();
            }
        }

        private void txtRetirarFijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (this.txtRetirarFijo.Text == "" || this.txtRetirarFijo.Text == "0")
                {
                    MessageBox.Show("Debe de ingresar el valor del retiro de ahorros.", "Egresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtValoraRetirarPrestamo.Text = "0";
                    return;
                }

                if (Convert.ToDecimal(this.txtRetirarFijo.Text) > Convert.ToDecimal(this.txtAhorradoFijo.Text))
                {
                    MessageBox.Show("El valor a retirar no puede ser mayor al ahorrado.", "Egresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtValoraRetirarPrestamo.Text = "0";
                    return;
                }

                this.btnGuardar.Focus();
            }
        }

        private void txtRetirarEstudiante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (this.txtRetirarEstudiante.Text == "" || this.txtRetirarEstudiante.Text == "0")
                {
                    MessageBox.Show("Debe de ingresar el valor del retiro de ahorros.", "Egresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtValoraRetirarPrestamo.Text = "0";
                    return;
                }

                if (Convert.ToDecimal(this.txtRetirarEstudiante.Text) > Convert.ToDecimal(this.txtAhorradoEstudiante.Text))
                {
                    MessageBox.Show("El valor a retirar no puede ser mayor al ahorrado.", "Egresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtValoraRetirarPrestamo.Text = "0";
                    return;
                }

                this.btnGuardar.Focus();
            }
        }

        private void txtEgreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                egresoConsultado = new blRecibosEgresos().gmtdConsultaEgreso(Convert.ToInt32(this.txtEgreso.Text));
                this.pmtdLimpiarControles();
                if (egresoConsultado.strNombre != null)
                {
                    egresoConsultado.strFormulario = this.Name;
                    if (egresoConsultado.bitAnulado == true)
                        this.btnAnulado.Visible = true;

                    this.txtEgreso.Text = egresoConsultado.intCodigoEgr.ToString();
                    this.txtNombre.Text = egresoConsultado.strNombre;
                    this.txtApellido.Text = egresoConsultado.strApellido;
                    this.chkCheque.Checked = egresoConsultado.bitCheque;
                    this.txtGranTotal.Text = egresoConsultado.decTotal.ToString();

                    if (egresoConsultado.egresoAbonoaPrestamo != null)
                    {
                        this.cboPrestamosAbono.Items.Clear();
                        this.cboPrestamosAbono.Items.Add(egresoConsultado.egresoAbonoaPrestamo.intCodigoEgr);
                        this.cboPrestamosAbono.SelectedIndex = 0;
                        this.txtAbonoaPrestamosActual.Text = egresoConsultado.egresoAbonoaPrestamo.decAbonoPrestamo.ToString();
                        this.txtValoraRetirarPrestamo.Text = egresoConsultado.egresoAbonoaPrestamo.decAbonoPrestamo.ToString();
                        this.chkRetirosPrestamo.Checked = true;
                    }

                    if (egresoConsultado.egresoAhorroalaVista != null)
                    {
                        this.txtAhorrado.Text = egresoConsultado.egresoAhorroalaVista.decAhorrado.ToString();
                        this.txtRetirar.Text = egresoConsultado.egresoAhorroalaVista.decRetiro.ToString();
                        this.chkRetirar.Checked = true;
                    }

                    if (egresoConsultado.egresoAhorroEstudiantil != null)
                    {
                        this.txtAhorradoEstudiante.Text = egresoConsultado.egresoAhorroEstudiantil.decAhorrado.ToString();
                        this.txtRetirarEstudiante.Text = egresoConsultado.egresoAhorroEstudiantil.decRetiro.ToString();
                        this.chkRetirarEstudiante.Checked = true;
                    }

                    if (egresoConsultado.egresoAhorroFijo != null)
                    {
                        this.txtAhorradoFijo.Text = egresoConsultado.egresoAhorroFijo.decAhorrado.ToString();
                        this.txtRetirarFijo.Text = egresoConsultado.egresoAhorroFijo.decRetiro.ToString();
                        this.chkRetirosFijos.Checked = true;
                    }

                    if (egresoConsultado.egresoEgreso != null)
                    {
                        this.dgvEgresos.Rows.Clear();
                        for (int a = 0; a < egresoConsultado.egresoEgreso.Count; a++)
                        {
                            string[] ventor = new string[5] { egresoConsultado.egresoEgreso[a].strCodOtrosEgresos, egresoConsultado.egresoEgreso[a].strDescripcion, egresoConsultado.egresoEgreso[a].decValorBruto.ToString(), egresoConsultado.egresoEgreso[a].decIva.ToString(), egresoConsultado.egresoEgreso[a].decRetencion.ToString() };
                            this.dgvEgresos.Rows.Add(ventor);
                        }
                        this.txtTotalEgresos.Text = egresoConsultado.decTotal.ToString();
                        this.chkEgresos.Checked = true;
                    }

                    if (egresoConsultado.egresoIntereses != null)
                    {
                        this.txtIntereses.Text = egresoConsultado.egresoIntereses.decIntereses.ToString();
                        this.chkIntereses.Checked = true;
                    }

                    if (egresoConsultado.bitRetiro && !egresoConsultado.bitRetiroIntereses)
                        this.gmtdMostrarReciboTransacciones();
                    else
                        this.gmtdMostrarReciboEgreso();

                }
                else
                {
                    MessageBox.Show("Este código no aparece registrado. ", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtEgreso.Text = "0";
                    return;
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.pmtdHabilitarControles(false);
            this.pmtdLimpiarControles();
            this.txtEgreso.Enabled = true;
            this.txtEgreso.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.btnAnulado.Visible == true)
            {
                MessageBox.Show("No puede eliminar un recibo que ya esta eliminado. ", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (this.txtEgreso.Text == "0" || this.txtEgreso.Text == "")
            {
                MessageBox.Show("Debe de ingresar el número de egreso a eliminar. ", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (egresoConsultado.strNombre == null)
            {
                MessageBox.Show("Debe de consultar el egreso a eliminar. ", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            DialogResult dlgResult = MessageBox.Show("Confirma que desea eliminar este registro? ", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlgResult == DialogResult.Yes)
            {
                this.pmtdMensaje(new blRecibosEgresos().gmtdEliminarEgreso(egresoConsultado), "Egresos");
            }

            this.pmtdHabilitarControles(false);
            this.pmtdLimpiarControles();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.pmtdHabilitarControles(false);
            this.pmtdLimpiarControles();
            this.rptRecibos.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            propiedades.strFormActivo = "Principal";
            this.Dispose();
        }

        private void txtEgreso_Leave(object sender, EventArgs e)
        {
            this.txtEgreso.Enabled = false;
        }

        private void txtIdentificacion_Leave(object sender, EventArgs e)
        {
            this.txtIdentificacion.Enabled = false;
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (this.txtValor.Text.Trim() == "")
                this.txtValor.Text = "0";
        }

        private void txtPorcentajeIva_Leave(object sender, EventArgs e)
        {
            if (this.txtPorcentajeIva.Text.Trim() == "")
                this.txtPorcentajeIva.Text = "0";

            if (Convert.ToDecimal(this.txtPorcentajeIva.Text) > 100)
            {
                MessageBox.Show("El porcenta de iva debe de estar entre 0 y 100. ", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void txtPorcentajeRetencion_Leave(object sender, EventArgs e)
        {
            if (this.txtPorcentajeRetencion.Text.Trim() == "")
                this.txtPorcentajeRetencion.Text = "0";

            if (Convert.ToDecimal(this.txtPorcentajeRetencion.Text) > 100)
            {
                MessageBox.Show("El porcenta de retención debe de estar entre 0 y 100. ", "Ingresos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void txtRetirar_Leave(object sender, EventArgs e)
        {
            if (this.txtRetirar.Text.Trim() == "")
                this.txtRetirar.Text = "0";
        }

        private void txtRetirarFijo_Leave(object sender, EventArgs e)
        {
            if (this.txtRetirarFijo.Text.Trim() == "")
                this.txtRetirarFijo.Text = "0";
        }

        private void txtRetirarEstudiante_Leave(object sender, EventArgs e)
        {
            if (this.txtRetirarEstudiante.Text.Trim() == "")
                this.txtRetirarEstudiante.Text = "0";
        }

        private void txtValoraRetirarPrestamo_Leave(object sender, EventArgs e)
        {
            if (this.txtValoraRetirarPrestamo.Text.Trim() == "")
                this.txtValoraRetirarPrestamo.Text = "0";
        }

        private void btnEliminarEgresos_Click(object sender, EventArgs e)
        {
            if (this.dgvEgresos.Rows.Count > 1)
            {
                this.dgvEgresos.Rows.RemoveAt(this.dgvEgresos.CurrentRow.Index);
            }

            this.pmtdCalcularTotalEgresos();
        }

        private void chkIntereses_Click(object sender, EventArgs e)
        {
            this.pmtdCalcularGranTotal();
        }
    }
}