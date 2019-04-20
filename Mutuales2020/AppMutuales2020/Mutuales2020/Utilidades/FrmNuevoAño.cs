namespace Mutuales2020.Utilidades
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using System;
    using System.Windows.Forms;
    public partial class FrmNuevoAño : Form
    {
        tblLogNuevoAño objLogNuevoAño = new tblLogNuevoAño();

        public FrmNuevoAño()
        {
            InitializeComponent();
        }

        private void FrmNuevoAño_Load(object sender, EventArgs e)
        {
            this.cboServicio.DataSource = new blPrimarios().gmtdConsultarTodos();
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            this.cboServicio.SelectedIndex = 0;
            this.lblNombre.Text = "";
            this.txtAño.Text = "0";
            this.txtMes.Text = "0";
            objLogNuevoAño = new tblLogNuevoAño();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.cboServicio.Focus();
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            tblSocio objSocio = new blSocio().gmtdConsultar(Convert.ToInt16(this.txtCodigo.Text));
            if(objSocio.strNombreSoc != null)
            {
                this.cboServicio.SelectedValue = objSocio.strCodServiciop;
                this.lblNombre.Text = objSocio.strNombreSoc + " " + objSocio.strApellido1Soc + " " + objSocio.strApellido2Soc;
                this.txtAño.Text = objSocio.intAño.ToString();
                this.txtMes.Text = objSocio.intMeses.ToString();
                objLogNuevoAño.intAñoAnterior = objSocio.intAño;
                objLogNuevoAño.intCodigoSoc = Convert.ToInt16(this.txtCodigo.Text);
                objLogNuevoAño.intMesAnterior = objSocio.intMeses;
                objLogNuevoAño.strServicioAnterior = objSocio.strCodServiciop;
            }
            else
            {
                MessageBox.Show("Este socio no aparece registrado. ", "Nuevo Año", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboServicio.SelectedIndex = 0;
                this.lblNombre.Text = "";
                this.txtAño.Text = "0";
                this.txtMes.Text = "0";
                objLogNuevoAño = new tblLogNuevoAño();
            }
        }

        private void cboServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtAño.Focus();
            }
        }

        private void txtAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtMes.Focus();
            }
        }

        private void txtMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnActualizar.Focus();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            tblSocio socio = new tblSocio();
            socio.intCodigoSoc = objLogNuevoAño.intCodigoSoc;
            socio.intAño = Convert.ToInt16(this.txtAño.Text);
            socio.intMeses = Convert.ToInt32(this.txtMes.Text);
            socio.strCodServiciop = this.cboServicio.SelectedValue.ToString();

            objLogNuevoAño.intAñoNuevo = Convert.ToInt16(this.txtAño.Text);
            objLogNuevoAño.intMesNuevo = Convert.ToInt16(this.txtMes.Text);
            objLogNuevoAño.strServicioNuevo = this.cboServicio.SelectedValue.ToString();
            objLogNuevoAño.dtmFechaLog = DateTime.Now;
            objLogNuevoAño.strUsuario = propiedades.strLogin;

            MessageBox.Show(new blSocio().gmtdNuevoAño(socio, objLogNuevoAño), "Cambiar Cédula", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
