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

    public partial class frmAhorrosCdt : Form
    {
        public frmAhorrosCdt()
        {
            InitializeComponent();
        }

        #region metodos
        private static frmAhorrosCdt form = null;
        public static frmAhorrosCdt DefInstance
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new frmAhorrosCdt();
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
            Program.gmtdAsignarPermisos(ref btnGuardar, ref btnModificar, ref btnEliminar);
        }

        /// <summary>
        /// Carga la grid con datos si tiene permisos necesarios.
        /// </summary>
        private void pmtdCargarGrid()
        {
            if (propiedades.bitConsultar == true)
            {
                this.dgvAhorrosCdt.AutoGenerateColumns = false;
                this.dgvAhorrosCdt.DataSource = new blAhorrosCdt().gmtdConsultarTodos();
            }
        }

        /// <summary>
        /// Limpia los texbox del formulario.
        /// </summary>
        private void pmtdLimpiarText()
        {
            this.txtCodigo.Text = "0";
            this.dtpFechaCuenta.Value = DateTime.Now;
            this.chkAnticipado.Checked = false;
            this.txtCedulaAho.Text = "0";
            this.txtNomAhorrador.Text = "";
            this.txtMeses.Text = "0";
            this.txtIntereses.Text = "0";
            this.txtMonto.Text = "0";
            
        }

        /// <summary>
        /// Habilita o deshabilita los controles de la aplicación.
        /// </summary>
        /// <param name="a"></param>
        private void pmtdHabilitarText(bool a)
        {
            this.txtCodigo.Enabled = a;
            this.dtpFechaCuenta.Enabled = a;
            this.chkAnticipado.Enabled = a;
            this.txtCedulaAho.Enabled = a;
            this.txtNomAhorrador.Enabled = a;
            this.txtMeses.Enabled = a;
            this.txtIntereses.Enabled = a;
            this.txtMonto.Enabled = a;
        }

        /// <summary>
        /// Crea un objeto del tipo aplicación de acuerdo a la información de los texbox.
        /// </summary>
        /// <returns> Un objeto del tipo aplicación. </returns>
        private tblAhorrosCdt crearObj()
        {
            tblAhorrosCdt ahorros = new tblAhorrosCdt();
            ahorros.bitAnticipadoCdt = this.chkAnticipado.Checked;
            ahorros.bitAnuladoCdt = false;
            ahorros.bitLiquidadoCdt = false;
            ahorros.dtmFechaAnulado = Convert.ToDateTime("1900-01-01");
            ahorros.dtmFechaLiquidacion = Convert.ToDateTime("1900-01-01");
            ahorros.dtmFechaIniCdt = this.dtpFechaCuenta.Value;
            ahorros.dtmFechaFinCdt = this.dtpFechaCuenta.Value.AddMonths(Convert.ToInt32(this.txtMeses.Text));
            ahorros.decInteresesCdt = Convert.ToDecimal(this.txtIntereses.Text);
            ahorros.intMesesCdt = Convert.ToInt32(txtMeses.Text);
            ahorros.decMontoCdt = Convert.ToDecimal(this.txtMonto.Text);
            ahorros.intNumeroCdt = Convert.ToInt32(txtCodigo.Text);

            ahorros.intAnoMes = Convert.ToInt32(txtCodigo.Text);
            ahorros.strFormulario = this.Name;
            if (this.txtNomAhorrador.Text == "")
                ahorros.strCedulaAho = null;
            else
                ahorros.strCedulaAho = this.txtCedulaAho.Text;
            return ahorros;
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
                mensaje = MessageBox.Show(tstrMensaje.Substring(tstrMensaje.LastIndexOf("+") + 1, (tstrMensaje.Length - (tstrMensaje.LastIndexOf("+") + 1))), tstrFormulario, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return mensaje;
        }

        private void gmtdMostrarReciboIngreso(string ingreso)
        {
            List<SqlParameter> lstParameters = new List<SqlParameter>();
            SqlParameter parametro = new SqlParameter("@intCodigoRec", SqlDbType.Int);
            parametro.Value = ingreso;
            lstParameters.Add(parametro);
            DataSet ds = new DataSet();
            ds = propiedades.ejecutarSp(lstParameters, "spImprimirRecibosdeIngresos");
            //ds = this.ejecutarSp(lstParameters, "spImprimirRecibosdeIngresos");
            ReportDataSource datasource;
            datasource = new ReportDataSource("spImprimirRecibosdeIngresos_spImprimirRecibosdeIngresos", ds.Tables[0]);

            List<Microsoft.Reporting.WinForms.ReportParameter> lstParametros = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Recibo", ingreso);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("nombreMutual", propiedades.strNombreMutual);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Telefono", propiedades.strNit);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Personeria", propiedades.strPersoneria);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Socio", String.Empty);
            lstParametros.Add(parametroReporte);
            parametroReporte = new Microsoft.Reporting.WinForms.ReportParameter("Plan", String.Empty);
            lstParametros.Add(parametroReporte);

            rptRecibos.Reset();
            rptRecibos.Visible = true;
            rptRecibos.Left = 0;
            rptRecibos.Top = 0;
            rptRecibos.Height = 269;
            rptRecibos.Width = 810;
            rptRecibos.ProcessingMode = ProcessingMode.Local;
            rptRecibos.LocalReport.DataSources.Clear();
            rptRecibos.LocalReport.DataSources.Add(datasource);
            rptRecibos.LocalReport.ReportEmbeddedResource = "Mutuales2020.Movimientos.Reportes.rptIngresos.rdlc";
            rptRecibos.LocalReport.SetParameters(lstParametros);
            rptRecibos.LocalReport.Refresh();

            this.rptRecibos.RefreshReport();
        }
        #endregion

        private void frmAhorrosCdt_Load(object sender, EventArgs e)
        {
            this.gmtdPermisosBotones();
            this.pmtdCargarGrid();
        }

        private void dgvAhorrosCdt_DoubleClick(object sender, EventArgs e)
        {
            this.pmtdLimpiarText();
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Text = this.dgvAhorrosCdt.CurrentRow.Cells[0].Value.ToString();
            this.dtpFechaCuenta.Value = Convert.ToDateTime(this.dgvAhorrosCdt.CurrentRow.Cells[4].Value);
            this.txtCedulaAho.Text = this.dgvAhorrosCdt.CurrentRow.Cells[1].Value.ToString();
            this.txtNomAhorrador.Text = this.dgvAhorrosCdt.CurrentRow.Cells[2].Value.ToString();
            this.txtMeses.Text = this.dgvAhorrosCdt.CurrentRow.Cells[7].Value.ToString();
            this.txtIntereses.Text = this.dgvAhorrosCdt.CurrentRow.Cells[3].Value.ToString();
            this.txtMonto.Text = this.dgvAhorrosCdt.CurrentRow.Cells[6].Value.ToString();
            if (this.dgvAhorrosCdt.CurrentRow.Cells[8].Value.ToString() == "False")
                this.chkAnticipado.Checked = false;
            else
                this.chkAnticipado.Checked = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string strMensaje = new blAhorrosCdt().gmtdInsertar(crearObj());
            this.pmtdMensaje(strMensaje, "Ahorros Cdt");
            this.pmtdCargarGrid();

            if(strMensaje.Substring(0) != "-")
            {
                this.gmtdMostrarReciboIngreso(strMensaje.Substring(0, strMensaje.LastIndexOf("+")));
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Confirma que desea eliminar este registro? ", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlgResult == DialogResult.Yes)
                this.pmtdMensaje(new blAhorrosCdt().gmtdEliminar(crearObj()), "Ahorros Cdt");
            this.pmtdCargarGrid();
            this.pmtdLimpiarText();
            this.pmtdHabilitarText(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.pmtdLimpiarText();
            this.pmtdCargarGrid();
            this.pmtdHabilitarText(true);
            this.rptRecibos.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            propiedades.strFormActivo = "Principal";
            this.Dispose();
        }

        private void frmAhorrosCdt_FormClosed(object sender, FormClosedEventArgs e)
        {
            propiedades.strFormActivo = "Principal";
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.dtpFechaCuenta.Focus();
            }
        }

        private void dtpFechaCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtCedulaAho.Focus();
            }
        }

        private void txtCedulaAho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtMeses.Focus();
            }
        }

        private void txtAño_KeyPress(object sender, KeyPressEventArgs e)
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
                this.txtIntereses.Focus();
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
                this.chkAnticipado.Focus();
            }
        }

        private void chkAnticipado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnGuardar.Focus();
            }
        }

        private void txtCedulaAho_Leave(object sender, EventArgs e)
        {
            if (this.txtCedulaAho.Text.Trim() == "")
                this.txtCedulaAho.Text = "0";

            tblAhorradore ahorrador = new blAhorrador().gmtdConsultar(this.txtCedulaAho.Text);

            if (ahorrador.strNombreAho == null)
            {
                this.txtNomAhorrador.Text = "";
                MessageBox.Show("Este número de cédula no aparece registrada como ahorrador. ", "Cdt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                this.txtNomAhorrador.Text = ahorrador.strNombreAho + " " + ahorrador.strApellido1Aho + " " + ahorrador.strApellido2Aho;
        }

        private void btnLiquidar_Click(object sender, EventArgs e)
        {
            if (this.txtCodigo.Text.Trim() != "0" && this.txtCodigo.Text.Trim() != "")
            {
                if (new blAhorrosCdt().gmtdConsultarCdt(Convert.ToInt16(this.txtCodigo.Text)).strCedulaAho != null)
                {

                    tblAhorrosCdtsLiquidacion liquidacion = new blAhorrosCdtLiquidacion().gmtdCalcularLiquidacion(Convert.ToInt32(this.txtCodigo.Text));
                    if (liquidacion.strFormulario != null)
                    {
                        DialogResult respuesta = MessageBox.Show("Confirma que desea liquidar el CDT?. \n Los datos con los siguientes: \n Monto : " + Convert.ToDouble(this.txtMonto.Text).ToString("#,#00.00")
                            + " \n Intereses: " + liquidacion.decInteresesLiquidacion.ToString("#,#00.00")
                            + " \n Retención: " + liquidacion.decRetencionLiquidacionCdt.ToString("#,#00.00")
                            + " \n Total Liquidación: " + liquidacion.decNetolLiquidacionCdt.ToString("#,#00.00"),
                            "Liquidación CDT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (respuesta == DialogResult.Yes)
                        {
                            this.pmtdMensaje(new blAhorrosCdtLiquidacion().gmtdInsertar(liquidacion), "Liquidación CDT");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede liquidar el CDT por que no se puede calcular el valor de la liquidación.", "Liquidar CDT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.pmtdCargarGrid();
                }
                else
                {
                    MessageBox.Show("El cdt a eliminar no puede estar anulado, liquidado o inexistente.", "Liquidar CDT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtMeses_Leave(object sender, EventArgs e)
        {
            if (this.txtMeses.Text.Trim() == "")
                this.txtMeses.Text = "0";
        }

        private void txtIntereses_Leave(object sender, EventArgs e)
        {
            if (this.txtIntereses.Text.Trim() == "")
                this.txtIntereses.Text = "0";
        }

        private void txtMonto_Leave(object sender, EventArgs e)
        {
            if (this.txtMonto.Text.Trim() == "")
                this.txtMonto.Text = "0";
        }
    }
}
