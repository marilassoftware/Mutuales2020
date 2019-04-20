namespace Mutuales2020.Utilidades
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class FrmCambiarBeneficiario : Form
    {
        public FrmCambiarBeneficiario()
        {
            InitializeComponent();
        }

        private void txtSocioActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.cboBeneficiario.Focus();
        }

        private void txtSocioActual_Leave(object sender, EventArgs e)
        {
            List<Agraciado> agraciado = new blAgraciado().gmtdConsultar(Convert.ToInt32(this.txtSocioActual.Text));

            if (agraciado.Count <= 0)
            {
                MessageBox.Show("El código escrito no tiene agracidos registrados.", "Agraciados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnActualizar.Enabled = false;
            }

            this.cboBeneficiario.DataSource = agraciado;
        }

        private void cboBeneficiario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.txtSocioNuevo.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                tblSocio socio = new blSocio().gmtdConsultar(Convert.ToInt32(this.txtSocioNuevo.Text));
                if (socio.strNombreSoc != null)
                {
                    this.btnActualizar.Enabled = true;
                    this.btnActualizar.Focus();
                }
                else
                {
                    MessageBox.Show("El socio al que desea cambiar ela garciado no aparece registrado.", "Socio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            utilidades.pmtdMensaje(new blSocio().gmtdCambiarAgraciadodeSocio(Convert.ToInt32(this.txtSocioActual.Text), this.cboBeneficiario.SelectedValue.ToString(), Convert.ToInt32(this.txtSocioNuevo.Text)), "Ahorradores");

            this.txtSocioNuevo.Text = "0";
            this.txtSocioActual.Text = "0";
            this.cboBeneficiario.SelectedValue = 0;
            this.btnActualizar.Enabled = false;
            this.txtSocioActual.Focus();
        }

        private void FrmCambiarBeneficiario_Load(object sender, EventArgs e)
        {

        }
    }
}
