namespace Mutuales2020.Servicios
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using Mutuales2020;
    using System;
    using System.Windows.Forms;

    public partial class FrmServiciosSecundarios : Form
    {
        public FrmServiciosSecundarios()
        {
            InitializeComponent();
        }

        #region metodos
        private static FrmServiciosSecundarios form = null;
        public static FrmServiciosSecundarios DefInstance
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new FrmServiciosSecundarios();
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
                blSecundarios blSec = new blSecundarios();
                this.dgv.DataSource = blSec.gmtdConsultarTodos();
            }
        }

        /// <summary>
        /// Limpia los texbox del formulario.
        /// </summary>
        private void pmtdLimpiarText()
        {
            this.txtCodigo.Text = "";
            this.txtDescripcion.Text = "";
            this.txtValor.Text = "0";
            this.cboPares.SelectedIndex = 0;
        }

        private void pmtdHabilitarText(bool tbitA)
        {
            this.txtCodigo.Enabled = tbitA;
            this.txtDescripcion.Enabled = tbitA;
            this.txtValor.Enabled = tbitA;
            this.cboPares.Enabled = tbitA;
        }
        /// <summary>
        /// Crea un objeto del tipo aplicación de acuerdo a la información de los texbox.
        /// </summary>
        /// <returns> Un objeto del tipo aplicación. </returns>
        private tblServiciosSecundario crearObj()
        {
            tblServiciosSecundario secundarios = new tblServiciosSecundario();
            secundarios.intValorSse = Convert.ToInt32(this.txtValor.Text);
            secundarios.strCodigoPar = this.cboPares.SelectedValue.ToString();
            secundarios.strCodSse = this.txtCodigo.Text;
            secundarios.strFormulario = this.Name;
            secundarios.strNombreSse = this.txtDescripcion.Text;
            return secundarios;
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
            this.cboPares.DataSource = new blCuentaPar().gmtdConsultarTodos();

            if (this.cboPares.Items.Count <= 0)
            {
                MessageBox.Show("Debe de ingresar pares para utilizar esta pantalla. ", "Socios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnCancelar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnGuardar.Enabled = false;
                this.btnModificar.Enabled = false;
                this.btnSalir.Enabled = false;
            }

        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Text = this.dgv.CurrentRow.Cells[0].Value.ToString();
            this.txtDescripcion.Text = this.dgv.CurrentRow.Cells[1].Value.ToString();
            this.txtValor.Text = this.dgv.CurrentRow.Cells[2].Value.ToString();
            this.cboPares.SelectedValue = this.dgv.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.pmtdMensaje(new blSecundarios().gmtdInsertar(crearObj()), "Secundarios");
            this.pmtdCargarGrid();
            this.pmtdLimpiarText();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.pmtdMensaje(new blSecundarios().gmtdEditar(crearObj()), "Secundarios");
            this.pmtdCargarGrid();
            this.pmtdLimpiarText();
            this.pmtdHabilitarText(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Confirma que desea eliminar este registro? ", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlgResult == DialogResult.Yes)
                this.pmtdMensaje(new blSecundarios().gmtdEliminar(crearObj()), "Secundarios");
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
                this.txtValor.Focus();
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.cboPares.Focus();
            }
        }

        private void cboAplicaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnGuardar.Focus();
            }
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            propiedades.strFormActivo = "Principal";
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (this.txtValor.Text.Trim() == "")
                this.txtValor.Text = "0";
        }

    }
}
