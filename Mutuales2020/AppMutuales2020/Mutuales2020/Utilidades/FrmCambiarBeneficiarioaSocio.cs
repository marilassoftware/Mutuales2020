namespace Mutuales2020.Utilidades
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class FrmCambiarBeneficiarioaSocio : Form
    {
        string strCedula = "";

        public FrmCambiarBeneficiarioaSocio()
        {
            InitializeComponent();
        }

        private void txtSocioActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                this.btnBuscarAgraciados.Focus();
        }

        private void btnBuscarAgraciados_Click(object sender, EventArgs e)
        {
            List<Agraciado> agraciado = new blAgraciado().gmtdConsultar(Convert.ToInt32(this.txtSocioActual.Text));

            if (agraciado.Count <= 0)
            {
                MessageBox.Show("El código escrito no tiene agracidos registrados.", "Agraciados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.dgvAgraciados.AutoGenerateColumns = false;
            this.dgvAgraciados.DataSource = agraciado;
        }

        private void txtSocioActual_Leave(object sender, EventArgs e)
        {
            strCedula = "";
            this.dgvAgraciados.DataSource = new blAgraciado().gmtdConsultar(-1);
        }

        private void dgvAgraciados_DoubleClick(object sender, EventArgs e)
        {
            strCedula = "";
            if(this.dgvAgraciados.Rows.Count > 0)
                strCedula = this.dgvAgraciados.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnEjecutarCambio_Click(object sender, EventArgs e)
        {
            utilidades.pmtdMensaje(new blSocio().gmtdCambiarAgraciadoaSocio(Convert.ToInt32(this.txtSocioActual.Text), strCedula), "Agraciados");

            this.txtSocioActual.Text = "0";
            this.dgvAgraciados.DataSource = new blAgraciado().gmtdConsultar(-1);
            this.txtSocioActual.Focus();

        }

        private void dgvAgraciados_Click(object sender, EventArgs e)
        {
            strCedula = "";
            if (this.dgvAgraciados.Rows.Count > 0)
                strCedula = this.dgvAgraciados.CurrentRow.Cells[1].Value.ToString();
        }

        private void FrmCambiarBeneficiarioaSocio_Load(object sender, EventArgs e)
        {

        }
    }
}
