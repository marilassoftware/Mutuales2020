namespace Mutuales2020.Ahorros
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using System;
    using System.Windows.Forms;

    public partial class FrmAhorrosNavideñoBonificacion : Form
    {
        public FrmAhorrosNavideñoBonificacion()
        {
            InitializeComponent();
        }

        #region metodos
        private static FrmAhorrosNavideñoBonificacion form = null;
        public static FrmAhorrosNavideñoBonificacion DefInstance
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new FrmAhorrosNavideñoBonificacion();
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

        /// <summary> Carga la grid con datos si tiene permisos necesarios. </summary>
        private void pmtdCargarGrid()
        {
            if (propiedades.bitConsultar == true)
            {
                this.dgvAhorrosNavideñosBonificacion.AutoGenerateColumns = false;
                this.dgvAhorrosNavideñosBonificacion.DataSource = new blAhorrosNavidenoBonificacion().gmtdConsultarTodos();
            }
        }

        /// <summary> Limpia los texbox del formulario. </summary>
        private void pmtdLimpiarText()
        {
            this.txtCuenta.Text = "";
            this.rdbIntereses.Checked = false;
            this.rdbPremios.Checked = false;
            this.txtValor.Text = "0";
            this.dtpFecha.Value = DateTime.Now;
        }

        /// <summary> Habilita o deshabilita los controles de la aplicación. </summary>
        private void pmtdHabilitarText(bool a)
        {
            this.txtCuenta.Enabled = a;
            this.rdbIntereses.Enabled = a;
            this.rdbPremios.Enabled = a;
            this.txtValor.Enabled = a;
            this.dtpFecha.Enabled = a;
        }

        /// <summary> Crea un objeto del tipo aplicación de acuerdo a la información de los texbox. </summary>
        /// <returns> Un objeto del tipo aplicación. </returns>
        private tblAhorrosNavidenoBonificacion crearObj()
        {
            tblAhorrosNavidenoBonificacion ahorros = new tblAhorrosNavidenoBonificacion();
            ahorros.bitIntereses = this.rdbIntereses.Checked;
            ahorros.bitPremios = this.rdbPremios.Checked;
            ahorros.dtmFechaSorteo = this.dtpFecha.Value;
            ahorros.fltValor = Convert.ToDouble(this.txtValor.Text);
            ahorros.strCuenta = this.txtCuenta.Text;
            ahorros.strFormulario = this.Name;
            ahorros.intCodigoBonificacion = Convert.ToInt32(this.txtBonificacion.Text);
            return ahorros;
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

        private void FrmAhorrosNavideñoBonificacion_Load(object sender, EventArgs e)
        {
            this.gmtdPermisosBotones();
            this.pmtdCargarGrid();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.pmtdMensaje(new blAhorrosNavidenoBonificacion().gmtdInsertar(crearObj()), "Bonificaciones");
            this.pmtdCargarGrid();
            this.pmtdLimpiarText();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Confirma que desea eliminar este registro? ", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlgResult == DialogResult.Yes)
                this.pmtdMensaje(new blAhorrosNavidenoBonificacion().gmtdEliminarBonificacion(crearObj()), "Bonificaciones");
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

        private void FrmAhorrosNavideñoBonificacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            propiedades.strFormActivo = "Principal";
        }

        private void txtCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.rdbIntereses.Focus();
            }
        }

        private void rdbIntereses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.rdbPremios.Focus();
            }
        }

        private void rdbPremios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtValor.Focus();
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.dtpFecha.Focus();
            }
        }

        private void dtpFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnGuardar.Focus();
            }
        }

        private void dgvAhorrosaFuturoBonificacion_DoubleClick(object sender, EventArgs e)
        {
            this.txtBonificacion.Enabled = false;
            this.txtBonificacion.Text = this.dgvAhorrosNavideñosBonificacion.CurrentRow.Cells[0].Value.ToString();
            this.txtCuenta.Text = this.dgvAhorrosNavideñosBonificacion.CurrentRow.Cells[1].Value.ToString();
            this.dtpFecha.Value = Convert.ToDateTime(this.dgvAhorrosNavideñosBonificacion.CurrentRow.Cells[2].Value);
            this.txtValor.Text = this.dgvAhorrosNavideñosBonificacion.CurrentRow.Cells[3].Value.ToString();
            this.rdbIntereses.Checked = Convert.ToBoolean(this.dgvAhorrosNavideñosBonificacion.CurrentRow.Cells[4].Value);
            this.rdbPremios.Checked = Convert.ToBoolean(this.dgvAhorrosNavideñosBonificacion.CurrentRow.Cells[5].Value);
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (this.txtValor.Text.Trim() == "")
                this.txtValor.Text = "0";
        }

    }
}
