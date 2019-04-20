namespace Mutuales2020.Utilidades
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using System;
    using System.Windows.Forms;
    public partial class frmRespaldos : Form
    {
        public frmRespaldos()
        {
            InitializeComponent();
        }

        private void btnRespaldo_Click(object sender, EventArgs e)
        {
            this.lblMensaje.Text = new blConfiguracion().gmtdRespaldarBasedeDatos(propiedades.strConexionDatos);
            this.lblMensaje.Refresh();
        }

        private void frmRespaldos_Load(object sender, EventArgs e)
        {

        }
    }
}
