namespace Mutuales2020.Maestros
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using System;
    using System.Windows.Forms;

    public partial class frmTiposdeCredito : Form
    {
        public frmTiposdeCredito()
        {
            InitializeComponent();
        }

        #region metodos
        private static frmTiposdeCredito form = null;
        public static frmTiposdeCredito DefInstance
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new frmTiposdeCredito();
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
                blCreditosTipo blTcr = new blCreditosTipo();
                this.dgvTiposdeCredito.DataSource = blTcr.gmtdConsultarTodos();
            }
        }

        /// <summary>
        /// Limpia los texbox del formulario.
        /// </summary>
        private void pmtdLimpiarText()
        {
            this.txtCodigo.Text = "";
            this.txtDescripcion.Text = "";
            this.txtTeab.Text = "0";
            this.txtTeau.Text = "0";
            this.txtTenb.Text = "0";
            this.txtTenu.Text = "0";
            this.txtTnbd.Text = "0";
            this.txtTnbm.Text = "0";
            this.txtTnbq.Text = "0";
            this.txtTnbs.Text = "0";
            this.txtTnud.Text = "0";
            this.txtTnum.Text = "0";
            this.txtTnuq.Text = "0";
            this.txtTnus.Text = "0";
        }

        /// <summary>
        /// Habilita o deshabilita los controles de la aplicación.
        /// </summary>
        /// <param name="a"></param>
        private void pmtdHabilitarText(bool a)
        {
            this.txtCodigo.Enabled = a;
            this.txtDescripcion.Enabled = a;
            this.txtTeab.Enabled = a;
            this.txtTeau.Enabled = a;
        }

        /// <summary>
        /// Crea un objeto del tipo aplicación de acuerdo a la información de los texbox.
        /// </summary>
        /// <returns> Un objeto del tipo aplicación. </returns>
        private tblCreditosTipo crearObj()
        {
            tblCreditosTipo Tcr = new tblCreditosTipo();
            Tcr.strCodigoTcr = this.txtCodigo.Text;
            Tcr.strDescripcionTcr = this.txtDescripcion.Text;
            Tcr.strFormulario = this.Name;
            Tcr.decTasaEfectivaAnualBasicaTcr = Convert.ToDecimal(this.txtTeab.Text);
            Tcr.decTasaNominalAnualBasicaTcr = Convert.ToDecimal(this.txtTenb.Text);
            Tcr.decTasaNominalAnualBasicaMensualTcr = Convert.ToDecimal(this.txtTnbm.Text);
            Tcr.decTasaNominalAnualBasicaQuincenalTcr = Convert.ToDecimal(this.txtTnbq.Text);
            Tcr.decTasaNominalAnualBasicaDecadalTcr = Convert.ToDecimal(this.txtTnbd.Text);
            Tcr.decTasaNominalAnualBasicaSemanalTcr = Convert.ToDecimal(this.txtTnbs.Text);
            Tcr.decTasaEfectivaAnualUsuraTcr = Convert.ToDecimal(this.txtTeau.Text);
            Tcr.decTasaNominalAnualUsuraTcr = Convert.ToDecimal(this.txtTenu.Text);
            Tcr.decTasaNominalAnualUsuraMensualTcr = Convert.ToDecimal(this.txtTnum.Text);
            Tcr.decTasaNominalAnualUsuraQuincenalTcr = Convert.ToDecimal(this.txtTnuq.Text);
            Tcr.decTasaNominalAnualUsuraDecadalTcr = Convert.ToDecimal(this.txtTnud.Text);
            Tcr.decTasaNominalAnualUsuraSemanalTcr = Convert.ToDecimal(this.txtTnus.Text);
            return Tcr;
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

        private void Frm_Load(object sender, EventArgs e)
        {
            this.gmtdPermisosBotones();
            this.pmtdCargarGrid();
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Text = this.dgvTiposdeCredito.CurrentRow.Cells[0].Value.ToString();
            this.txtDescripcion.Text = this.dgvTiposdeCredito.CurrentRow.Cells[1].Value.ToString();

            this.txtTeab.Text = this.dgvTiposdeCredito.CurrentRow.Cells[2].Value.ToString();
            this.txtTenb.Text = this.dgvTiposdeCredito.CurrentRow.Cells[3].Value.ToString();
            this.txtTnbs.Text = this.dgvTiposdeCredito.CurrentRow.Cells[4].Value.ToString();
            this.txtTnbd.Text = this.dgvTiposdeCredito.CurrentRow.Cells[5].Value.ToString();
            this.txtTnbq.Text = this.dgvTiposdeCredito.CurrentRow.Cells[6].Value.ToString();
            this.txtTnbm.Text = this.dgvTiposdeCredito.CurrentRow.Cells[7].Value.ToString();

            this.txtTeau.Text = this.dgvTiposdeCredito.CurrentRow.Cells[8].Value.ToString();
            this.txtTenu.Text = this.dgvTiposdeCredito.CurrentRow.Cells[9].Value.ToString();
            this.txtTnus.Text = this.dgvTiposdeCredito.CurrentRow.Cells[10].Value.ToString();
            this.txtTnud.Text = this.dgvTiposdeCredito.CurrentRow.Cells[11].Value.ToString();
            this.txtTnuq.Text = this.dgvTiposdeCredito.CurrentRow.Cells[12].Value.ToString();
            this.txtTnum.Text = this.dgvTiposdeCredito.CurrentRow.Cells[13].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.pmtdMensaje(new blCreditosTipo().gmtdInsertar(crearObj()), "Tipo de Credito");
            this.pmtdCargarGrid();
            this.pmtdLimpiarText();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.pmtdMensaje(new blCreditosTipo().gmtdEditar(crearObj()), "Tipo de Credito");
            this.pmtdCargarGrid();
            this.pmtdLimpiarText();
            this.pmtdHabilitarText(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Confirma que desea eliminar este registro? ", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlgResult == DialogResult.Yes)
                this.pmtdMensaje(new blCreditosTipo().gmtdEliminar(crearObj()), "Tipo de Credito");
            this.pmtdCargarGrid();
            this.pmtdLimpiarText();
            this.pmtdHabilitarText(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.pmtdLimpiarText();
            this.pmtdCargarGrid();
            this.pmtdHabilitarText(true);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            propiedades.strFormActivo = "Principal";
            this.Dispose();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtDescripcion.Focus();
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtTeab.Focus(); 
            }
        }

        private void cboAplicaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnGuardar.Focus();
            }
        }

        private void txtTeab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                double dblNominalAnual;
                dblNominalAnual = this.mtdPasardeEfectivoAnualaNominalAnuial (Convert.ToDouble(Convert.ToDouble(this.txtTeab.Text) / 100), 12);
                this.txtTenb.Text = dblNominalAnual.ToString();

                dblNominalAnual = this.mtdPasardeEfectivoAnualaNominalAnuial(Convert.ToDouble(this.txtTeab.Text) / 100, 12);
                this.txtTnbm.Text = Convert.ToString(Math.Round(dblNominalAnual / Convert.ToDouble(12), 3));

                dblNominalAnual = this.mtdPasardeEfectivoAnualaNominalAnuial(Convert.ToDouble(this.txtTeab.Text) / 100, 26);
                this.txtTnbq.Text = Convert.ToString(Math.Round(dblNominalAnual / Convert.ToDouble(26), 3));

                dblNominalAnual = this.mtdPasardeEfectivoAnualaNominalAnuial(Convert.ToDouble(this.txtTeab.Text) / 100, 36);
                this.txtTnbd.Text = Convert.ToString(Math.Round(dblNominalAnual / Convert.ToDouble(36), 3));

                dblNominalAnual = this.mtdPasardeEfectivoAnualaNominalAnuial(Convert.ToDouble(this.txtTeab.Text) / 100, 52);
                this.txtTnbs.Text = Convert.ToString(Math.Round(dblNominalAnual / Convert.ToDouble(52), 3));

                this.txtTeau.Focus();
            }
        }

        private void txtTeau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                double dblNominalAnual;
                dblNominalAnual = this.mtdPasardeEfectivoAnualaNominalAnuial(Convert.ToDouble(Convert.ToDouble(this.txtTeau.Text) / 100), 12);
                this.txtTenu.Text = dblNominalAnual.ToString();

                dblNominalAnual = this.mtdPasardeEfectivoAnualaNominalAnuial(Convert.ToDouble(this.txtTeau.Text) / 100, 12);
                this.txtTnum.Text = Convert.ToString(Math.Round(dblNominalAnual / Convert.ToDouble(12), 3));

                dblNominalAnual = this.mtdPasardeEfectivoAnualaNominalAnuial(Convert.ToDouble(this.txtTeau.Text) / 100, 26);
                this.txtTnuq.Text = Convert.ToString(Math.Round(dblNominalAnual / Convert.ToDouble(26), 3));

                dblNominalAnual = this.mtdPasardeEfectivoAnualaNominalAnuial(Convert.ToDouble(this.txtTeau.Text) / 100, 36);
                this.txtTnud.Text = Convert.ToString(Math.Round(dblNominalAnual / Convert.ToDouble(36), 3));

                dblNominalAnual = this.mtdPasardeEfectivoAnualaNominalAnuial(Convert.ToDouble(this.txtTeau.Text) / 100, 52);
                this.txtTnus.Text = Convert.ToString(Math.Round(dblNominalAnual / Convert.ToDouble(52), 3));


                this.btnGuardar.Focus();
            }
        }
        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            propiedades.strFormActivo = "Principal";
        }

        public Double mtdPasardeEfectivoAnualaNominalAnuial(Double pdblEfectivoAnual, Int32 intCuotas)
        {
            Double dblCalculo;
            Double dblElevar;
            dblCalculo = Convert.ToDouble((1 + pdblEfectivoAnual));
            dblElevar = Convert.ToDouble(1) / Convert.ToDouble(intCuotas);
            dblCalculo = Math.Pow(dblCalculo, dblElevar);
            dblCalculo -= 1;
            dblCalculo *= intCuotas;
            dblCalculo *= 100;
            return Math.Round(dblCalculo, 2);
        }

    }
}
