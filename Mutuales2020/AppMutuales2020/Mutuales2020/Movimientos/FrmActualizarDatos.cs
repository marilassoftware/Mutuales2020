namespace Mutuales2020.Movimientos
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using System;
    using System.Windows.Forms;
    public partial class FrmActualizarDatos : Form
    {
        personasaModificar objPeronaaModificar = new personasaModificar();

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

        public FrmActualizarDatos(personasaModificar tobjPersona)
        {
            InitializeComponent();

            this.txtCodigo.Text = tobjPersona.intCodigoSoc.ToString();
            this.txtCedula.Text = tobjPersona.strCedula;
            this.txtNombre.Text = tobjPersona.strNombre;
            this.txtApellido1.Text = tobjPersona.strApellido1;
            this.txtApellido2.Text = tobjPersona.strApellido2;
            this.txtTelefono.Text = tobjPersona.strTelefono;
            this.txtDireccion.Text = tobjPersona.strDireccion;
            this.dtpFechaNac.Value = tobjPersona.dtmFechaNacimeinto;
            this.txtProcedencia.Text = tobjPersona.strProcedencia;
            objPeronaaModificar = tobjPersona;
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtNombre.Focus(); 
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtApellido1.Focus();
        }

        private void txtApellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtApellido2.Focus();
        }

        private void txtApellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.dtpFechaNac.Focus(); 
        }

        private void dtpFechaNac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtTelefono.Focus();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtDireccion.Focus();
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.btnAceptar.Focus();
        }

        private void FrmActualizarDatos_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            personasaModificar objPersona = new personasaModificar();
            objPersona.dtmFechaNacimeinto = this.dtpFechaNac.Value;
            objPersona.intCodigoSoc = Convert.ToInt32(this.txtCodigo.Text);
            objPersona.strApellido1 = this.txtApellido1.Text;
            objPersona.strApellido2 = this.txtApellido2.Text;
            objPersona.strCedula = this.txtCedula.Text;
            objPersona.strDireccion = this.txtDireccion.Text;
            objPersona.strNombre = this.txtNombre.Text;
            objPersona.strTelefono = this.txtTelefono.Text;

            if (this.txtCedula.Text.Trim() != objPeronaaModificar.strCedula)
            {
                if (new blSocio().gmtdConsultarCeduladeSocioAgraciadoFallecido(this.txtCedula.Text))
                {
                    MessageBox.Show("Este número de cédula ya aparece registrada como socio, agraciado o fallecido. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.txtProcedencia.Text.Trim() == "Socio")
                {
                    MessageBox.Show(new blSocio().gmtdEditarCeduladeSocio(objPeronaaModificar.strCedula, this.txtCedula.Text), "Editar.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(new blAgraciado().gmtdEditarCeduladeAgraciado(objPeronaaModificar.strCedula, this.txtCedula.Text), "Editar.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (this.txtProcedencia.Text == "Socio")
            {
                this.pmtdMensaje(new blSocio().gmtdActualizarDato(objPersona), "Ingresos");
            }
            else
            {
                this.pmtdMensaje(new blAgraciado().gmtdActualizarDato(objPersona), "Ingresos");
            }

            this.Dispose();
        }
    }
}
