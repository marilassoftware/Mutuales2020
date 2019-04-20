namespace Mutuales2020.Utilidades
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using System;
    using System.Windows.Forms;

    public partial class FrmSaldosAhorros : Form
    {
        public FrmSaldosAhorros()
        {
            InitializeComponent();
        }

        private void FrmSaldosAhorros_Load(object sender, EventArgs e)
        {
            ahorrorosRegistrados cl = new blAhorrador().gmtdConsultarTotalesdeAhorros();

            this.txtAhorroaFuturo.Text = cl.decAhorroaFuturo.ToString("##,###,#00.00");
            this.txtAhorroEstudiantil.Text = cl.decAhorroEstudiantil.ToString("##,###,#00.00");
            this.txtAhorroFijo.Text = cl.decAhorroFijo.ToString("##,###,#00.00");
            this.txtAhorroNavideño.Text = cl.decAhorroNavideño.ToString("##,###,#00.00");
            this.txtAhorroEscolar.Text = cl.decAhorroNatilleraEscolar.ToString("##,###,#00.00");
            this.txtAhorrosalaVista.Text = cl.decAhorroalaVista.ToString("##,###,#00.00");
            this.txtCdta.Text = cl.decAhorroCdta.ToString("##,###,#00.00");
            this.txtTotales.Text = cl.decTotales.ToString("##,###,#00.00");
        }
    }
}
