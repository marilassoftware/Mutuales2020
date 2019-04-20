namespace Mutuales2020.Utilidades
{
    using libMutuales2020.dominio;
    using libMutuales2020.Facade;
    using libMutuales2020.logica;
    using System;
    using System.Windows.Forms;
    public partial class frmCambiarCedula : Form
    {
        tblSocio socio;
        tblAgraciado agraciado;
        tblCliente cliente;
        tblAhorradore ahorrador;

        public frmCambiarCedula()
        {
            InitializeComponent();
        }

        private void gmtdLimpiarControles()
        {
            this.txtModificar.Text = "";
            this.txtCambiar.Text = "";
            this.lblNombre.Text = "";
        }

        private void cboTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtModificar.Focus();
            }
        }

        private void txtModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.lblNombre.Text = "";

                switch (this.cboTipo.Text)
                { 
                    case "Agraciado":
                        agraciado = new blAgraciado().gmtdConsultarDetalle(this.txtModificar.Text);
                        this.lblNombre.Text = agraciado.strNombreAgra + " " + agraciado.strApellido1Agra + " " + agraciado.strApellido2Agra;
                        break;
                    case "Ahorrador":
                        ahorrador = new blAhorrador().gmtdConsultarDetalle(this.txtModificar.Text);
                        this.lblNombre.Text = ahorrador.strNombreAho + " " + ahorrador.strApellido1Aho + " " + ahorrador.strApellido2Aho;
                        break;
                    case "Cliente":
                        cliente = new blCliente().gmtdConsultarDetalle(this.txtModificar.Text);
                        this.lblNombre.Text = cliente.strContacto;
                        break;
                    case "Socio":
                        socio = new blSocio().gmtdConsultarDetalle(this.txtModificar.Text);
                        this.lblNombre.Text = socio.strNombreSoc + " " + socio.strApellido1Soc + " " + socio.strApellido2Soc;
                        break;
                }

                if (this.lblNombre.Text.Trim() == "")
                {
                    MessageBox.Show("Este número de cédula no aparece registrada como " + this.cboTipo.Text, "Cambiar Cédula", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.txtCambiar.Focus();
            }
        }

        private void frmCambiarCedula_Load(object sender, EventArgs e)
        {
            this.cboTipo.SelectedIndex = 0;
        }

        private void cboTipo_Enter(object sender, EventArgs e)
        {
            this.gmtdLimpiarControles();
        }

        private void txtModificar_Enter(object sender, EventArgs e)
        {
            this.gmtdLimpiarControles();
        }

        private void txtCambiar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnModificar.Focus();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            switch (this.cboTipo.Text)
            {
                case "Agraciado":
                    if (this.txtCambiar.Text.Trim() == "" || this.txtCambiar.Text.Trim() == "0"
                        || this.txtModificar.Text.Trim() == "" || this.txtModificar.Text.Trim() == "0"
                        || this.lblNombre.Text.Trim() == "")
                    {
                        MessageBox.Show("Faltan datos por ingresar. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (new blSocio().gmtdConsultarCeduladeSocioAgraciadoFallecido(this.txtCambiar.Text))
                    {
                        MessageBox.Show("Este número de cédula ya aparece registrada como socio, agraciado o fallecido. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show(new blAgraciado().gmtdEditarCeduladeAgraciado(this.txtModificar.Text, this.txtCambiar.Text), "Editar.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    break;
                case "Socio":

                    if (this.txtCambiar.Text.Trim() == "" || this.txtCambiar.Text.Trim() == "0"
                        || this.txtModificar.Text.Trim() == "" || this.txtModificar.Text.Trim() == "0"
                        || this.lblNombre.Text.Trim() == "")
                    {
                        MessageBox.Show("Faltan datos por ingresar. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (new blSocio().gmtdConsultarCeduladeSocioAgraciadoFallecido(this.txtCambiar.Text))
                    {
                        MessageBox.Show("Este número de cédula ya aparece registrada como socio, agraciado o fallecido. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show(new blSocio().gmtdEditarCeduladeSocio(this.txtModificar.Text, this.txtCambiar.Text), "Editar.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    break;
                case "Ahorrador":

                    if (this.txtCambiar.Text.Trim() == "" || this.txtCambiar.Text.Trim() == "0"
                        || this.txtModificar.Text.Trim() == "" || this.txtModificar.Text.Trim() == "0"
                        || this.lblNombre.Text.Trim() == "")
                    {
                        MessageBox.Show("Faltan datos por ingresar. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (new fAhorrador().gmtdConsultarDetalle(this.txtCambiar.Text).strNombreAho != null)
                    {
                        MessageBox.Show("Este número de cédula ya aparece registrada como socio, agraciado o fallecido. ", "Ingreso.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show(new fAhorrador().gmtdCambiarCedulaAhorrador(this.txtModificar.Text, this.txtCambiar.Text, propiedades.strConexionDatos), "Editar.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    break;
            }

            this.txtModificar.Text = "0";
            this.txtCambiar.Text = "0";
            this.lblNombre.Text = "";
            this.cboTipo.Focus();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

    }
}
