namespace Mutuales2020.Utilidades
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    public partial class FrmNumeroRifa : Form
    {
        public FrmNumeroRifa()
        {
            InitializeComponent();
        }

        private void txtSocio_Enter(object sender, EventArgs e)
        {
            this.txtSocio.Text = "0";
            this.txtNumeroRifa.Text = "0";
            this.chkSocio.Checked = false;
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            tblNumerosRifa objNumeroRifa = new tblNumerosRifa();
            objNumeroRifa.intAno = Convert.ToInt32(this.txtAño.Text);
            objNumeroRifa.intCodigoSoc = Convert.ToInt32(this.txtSocio.Text);
            objNumeroRifa.intMes = Convert.ToInt32(this.txtMes.Text);
            objNumeroRifa.intNumeroRifa = 0;

            if (this.chkSocio.Checked)
                utilidades.pmtdMensaje(new blConfiguracion().gmtdInsertarNumeroRifa(objNumeroRifa, "02"), "Número de rifa - Socios");
            else
                utilidades.pmtdMensaje(new blConfiguracion().gmtdInsertarNumeroRifa(objNumeroRifa, "04"), "Número de rifa - Préstamos");


        }

        private void btnEjecutarAutomaticamente_Click(object sender, EventArgs e)
        {
            List<string> lstCodigos;
            if(this.chkSocio.Checked)
            {
                tblNumerosRifa rifa = new tblNumerosRifa();
                rifa.intAno = Convert.ToInt32(this.txtAño.Text);
                rifa.intMes = Convert.ToInt32(this.txtMes.Text);

                lstCodigos = new blConfiguracion().gmtdConsultarSociosPrestamosparaRifa(rifa, "03");

                foreach (string strDato in lstCodigos)
                {
                    tblNumerosRifa numeroRifaSocio = new tblNumerosRifa();
                    numeroRifaSocio.intAno = Convert.ToInt32(this.txtAño.Text);
                    numeroRifaSocio.intCodigoSoc = Convert.ToInt32(strDato);
                    numeroRifaSocio.intMes = Convert.ToInt32(this.txtMes.Text);
                    numeroRifaSocio.intNumeroRifa = 0;

                    new blConfiguracion().gmtdInsertarNumeroRifa(numeroRifaSocio, "02");
                }

                MessageBox.Show("Operaciòn Terminada", "Número Rifa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tblNumerosRifa rifa = new tblNumerosRifa();
                rifa.intAno = Convert.ToInt32(this.txtAño.Text);
                rifa.intMes = Convert.ToInt32(this.txtMes.Text);

                lstCodigos = new blConfiguracion().gmtdConsultarSociosPrestamosparaRifa(rifa, "05");

                foreach (string strDato in lstCodigos)
                {
                    tblNumerosRifa numeroRifaSocio = new tblNumerosRifa();
                    numeroRifaSocio.intAno = Convert.ToInt32(this.txtAño.Text);
                    numeroRifaSocio.intCodigoSoc = Convert.ToInt32(strDato);
                    numeroRifaSocio.intMes = Convert.ToInt32(this.txtMes.Text);
                    numeroRifaSocio.intNumeroRifa = 0;

                    new blConfiguracion().gmtdInsertarNumeroRifa(numeroRifaSocio, "04");
                }

                MessageBox.Show("Operaciòn Terminada", "Número Rifa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmNumeroRifa_Load(object sender, EventArgs e)
        {
            tblConfiguracione configuracion = new blConfiguracion().gmtdConsultaConfiguracion();
            this.txtAño.Text = configuracion.intAnoEvaluado.ToString();
            this.txtMes.Text = configuracion.intMesEvaluado.ToString();
        }
    }
}
