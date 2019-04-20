using libMutuales2020.dominio;
using libMutuales2020.logica;
using Mutuales2020;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Mutuales2020.Maestros
{
    public partial class FrmSemanas : Form
    {
        public FrmSemanas()
        {
            InitializeComponent();
        }

        #region metodos
        private static FrmSemanas form = null;
        
        public static FrmSemanas DefInstance
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new FrmSemanas();
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
            Program.gmtdAsignarPermisos(ref btnGuardar, ref btnModificar, ref btnEliminar);
        }

        /// <summary> Carga la grid con datos si tiene permisos necesarios. </summary>
        private void pmtdCargarGrid()
        {
            if (propiedades.bitConsultar == true)
            {
                blSemana blSem = new blSemana();
                this.dgvSemanas.DataSource = blSem.gmtdConsultarTodos();
            }
        }

        /// <summary> Limpia los texbox del formulario. </summary>
        private void pmtdLimpiarText()
        {
            this.txtCodigo.Text = "";
            //this.dtpFechaSemana.Text = "";
            this.txtAño.Text = "";
        }

        /// <summary> Habilita o deshabilita los controles de la aplicación. </summary>
        /// <param name="a"></param>
        private void pmtdHabilitarText(bool a)
        {
            this.txtCodigo.Enabled = a;
            this.dtpFechaSemana.Enabled = a;
            this.txtAño.Enabled = a;
        }

        /// <summary> Crea un objeto del tipo aplicación de acuerdo a la información de los texbox. </summary>
        /// <returns> Un objeto del tipo aplicación. </returns>
        private tblSemana crearObj()
        {
            tblSemana Semana = new tblSemana();
            Semana.intCodigoSem = Convert.ToInt32(this.txtCodigo.Text);
            Semana.dtmFechaSem = this.dtpFechaSemana.Value;
            Semana.strFormulario = this.Name;
            Semana.intAño = Convert.ToInt32(this.txtAño.Text);
            Semana.strTipo = this.cboOpcion.Text.Trim();
            return Semana;
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

        /// <summary> Carga la información del combo para determinar si la semana es para ahorro navideño o natillera escolar. </summary>
        /// <returns> Listado para llenar combo. </returns>
        private List<CodigoValor> llenarCombo()
        {
            List<CodigoValor> lstCodigosValores = new List<CodigoValor>();

            CodigoValor objCodigoValor = new CodigoValor();
            objCodigoValor.strValue = "1";
            objCodigoValor.strTexto = "Ahorro Navideño";
            lstCodigosValores.Add(objCodigoValor);

            objCodigoValor = new CodigoValor();
            objCodigoValor.strValue = "2";
            objCodigoValor.strTexto = "Natillera Escolar";
            lstCodigosValores.Add(objCodigoValor);

            return lstCodigosValores;
        }

        #endregion

        private void Frm_Load(object sender, EventArgs e)
        {
            this.dtpFechaSemana.Format = DateTimePickerFormat.Custom;
            this.dtpFechaSemana.CustomFormat = "yyyy-MM-dd";

            this.gmtdPermisosBotones();
            this.pmtdCargarGrid();

            this.cboOpcion.DataSource = this.llenarCombo();
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Text = this.dgvSemanas.CurrentRow.Cells[0].Value.ToString();
            this.dtpFechaSemana.Text = this.dgvSemanas.CurrentRow.Cells[1].Value.ToString();
            this.txtAño.Text = this.dgvSemanas.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.pmtdMensaje(new blSemana().gmtdInsertar(crearObj()), "Semana");
            this.pmtdCargarGrid();
            this.pmtdLimpiarText();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.pmtdMensaje(new blSemana().gmtdEditar(crearObj()), "Semana");
            this.pmtdCargarGrid();
            this.pmtdLimpiarText();
            this.pmtdHabilitarText(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Confirma que desea eliminar este registro? ", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlgResult == DialogResult.Yes)
                this.pmtdMensaje(new blSemana().gmtdEliminar(crearObj()), "Semana");
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
                this.dtpFechaSemana.Focus();
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.btnGuardar.Focus();
        }

        private void cboAplicaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.btnGuardar.Focus();
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            propiedades.strFormActivo = "Principal";
        }

        private void dtpFechaSemana_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtAño.Focus();
        }

        private void txtAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.btnGuardar.Focus();
        }

    }
}
