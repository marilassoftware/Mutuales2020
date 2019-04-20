namespace Mutuales2020.Utilidades
{
    using libMutuales2020.logica;
    using System;
    using System.Windows.Forms;

    public partial class FrmDeshabilitarSocios : Form
    {
        public FrmDeshabilitarSocios()
        {
            InitializeComponent();
        }

        private void btnDeshabilitarSocio_Click(object sender, EventArgs e)
        {
            utilidades.pmtdMensaje(new blConfiguracion().gmtdDeshabilitarSocios(), "Socios");
        }

        private void FrmDeshabilitarSocios_Load(object sender, EventArgs e)
        {

        }
    }
}
