namespace Mutuales2020
{
    using libMutuales2020.dominio;
    using Seguridad;
    using SeguridadWindows.Dominio;
    using System;
    using System.Windows.Forms;

    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.txtContraseñaActual.Focus();
            }
        }

        private void txtContraseñaActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnIngresar.Focus();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            permiso Usuario = new blUsuarios().gmtdIngresarSistema(this.txtUsuario.Text, this.txtContraseñaActual.Text, "Exequial2010");

            if (Usuario.strGrupo.Trim() != "")
            {
                propiedades.strAplicacion = "Seguridad";
                propiedades.strGrupo = Usuario.strGrupo;
                propiedades.strLogin = this.txtUsuario.Text;
                propiedades.strCodigoUsuario = Usuario.strUsuario;
                FrmPrincipal.DefInstance.Show(); ;
                this.Hide();
            }
            else
            {
                MessageBox.Show("No puede ingresar al sistema : " + Usuario.strUsuario, "Ingresar al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
