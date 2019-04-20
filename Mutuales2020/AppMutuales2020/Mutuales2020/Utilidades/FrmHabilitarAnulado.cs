namespace Mutuales2020.Utilidades
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using System;
    using System.Windows.Forms;
    public partial class FrmHabilitarAnulado : Form
    {
        tblSocio socio;

        public FrmHabilitarAnulado()
        {
            InitializeComponent();
        }

        private void FrmHabilitarAnulado_Load(object sender, EventArgs e)
        {
            this.cboTipo.SelectedIndex = 0;
        }

        private void cboTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                switch (this.cboTipo.SelectedItem.ToString())
                {
                    case "Agraciado":
                        this.lblCedula.Text = "Cédula";
                        break;

                    case "Socio":
                        this.lblCedula.Text = "Codigo";
                        break;
                }
                this.txtCedula.Focus();
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                switch (this.cboTipo.SelectedItem.ToString())
                {
                    case "Agraciado":
                        tblAgraciado agraciado = new blAgraciado().gmtdConsultarAnulado(this.txtCedula.Text);
                        if (agraciado.strNombreAgra != null && agraciado.bitAnulado)
                        {
                            this.txtNombre.Text = agraciado.strNombreAgra + " " + agraciado.strApellido1Agra + " " + agraciado.strApellido2Agra;
                            this.btnHabilitar.Enabled = true;
                            this.btnHabilitar.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Este agraciado no aparece registrado.", "Agraciado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.btnHabilitar.Enabled = false;
                        }
                        break;

                    case "Socio":
                        socio = new blSocio().gmtdConsultar(this.txtCedula.Text);
                        if (socio.strNombreSoc != null && socio.bitAnulado)
                        {
                            this.txtNombre.Text = socio.strNombreSoc + " " + socio.strApellido1Soc + " " + socio.strApellido1Soc;
                            this.btnHabilitar.Enabled = true;
                            this.btnHabilitar.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Este socio no aparece registrado.", "Agraciado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.btnHabilitar.Enabled = false;
                        }
                        break;
                }
            }
        }

        private void txtCedula_Enter(object sender, EventArgs e)
        {
            this.txtCedula.Text = "0";
            this.txtNombre.Text = "";
            this.btnHabilitar.Enabled = false;
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            string strValoraEvaluar = "";

            if (this.cboTipo.SelectedIndex == 1)
            {
                strValoraEvaluar = socio.strCedulaSoc;
            }
            else
            {
                strValoraEvaluar = this.txtCedula.Text;
            }

            if (new blSocio().gmtdConsultarCeduladeSocioAgraciadoFallecido(strValoraEvaluar))
            {
                MessageBox.Show("Este número de cédula ya aparece registrado como socio, agraciado ó fallecido. ", "Socio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtCedula.Text = "0";
                return;
            }

            switch (this.cboTipo.SelectedText)
            {
                case "Agraciado":

                    tblAgraciado agraciado = new blAgraciado().gmtdConsultarDetalle(strValoraEvaluar);
                    if (agraciado.strNombreAgra != null)
                    {
                        this.txtNombre.Text = agraciado.strNombreAgra + " " + agraciado.strApellido1Agra + " " + agraciado.strApellido2Agra;
                        this.btnHabilitar.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Este agraciado no aparece registrado.", "Agraciado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.btnHabilitar.Enabled = false;
                    }
                    break;

                case "Socio":
                    socio = new blSocio().gmtdConsultarDetalle(strValoraEvaluar);
                    if (socio.strNombreSoc != null)
                    {
                        this.txtNombre.Text = socio.strNombreSoc + " " + socio.strApellido1Soc + " " + socio.strApellido1Soc;
                        this.btnHabilitar.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Este socio no aparece registrado.", "Agraciado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.btnHabilitar.Enabled = false;
                    }
                    break;
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            switch (this.cboTipo.SelectedItem.ToString())
            {
                case "Socio":
                    utilidades.pmtdMensaje(new blSocio().gmtdHabilitarAnulado(this.txtCedula.Text), "Socios");
                    break;
                case "Agraciado":
                    utilidades.pmtdMensaje(new blAgraciado().gmtdHabilitarAnulado(this.txtCedula.Text), "Agraciado");
                    break;
            }

            this.txtCedula.Text = "0";
            this.txtNombre.Text = "";
            this.btnHabilitar.Enabled = false;
        }

    }
}

