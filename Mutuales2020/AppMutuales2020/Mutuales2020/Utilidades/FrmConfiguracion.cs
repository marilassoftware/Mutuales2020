namespace Mutuales2020.Utilidades
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using System;
    using System.Windows.Forms;

    public partial class FrmConfiguracion : Form
    {
        tblConfiguracione configuracion = new blConfiguracion().gmtdConsultaConfiguracion();

        public FrmConfiguracion()
        {
            InitializeComponent();
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            configuracion = new blConfiguracion().gmtdConsultaConfiguracion();

            this.chkCargarTodos.Checked = configuracion.bitCargarTodos;
            this.chkTasadeUsura.Checked = configuracion.bitTasadeUsura;
            this.txtValorCuotaadultomayor.Text = configuracion.intValorCuotaAdultoMayor.ToString();
            this.txtMesesAtrasados.Text = configuracion.intAtrasados.ToString();
            this.txtPorcentajeRetencion.Text = configuracion.fltPorcentajeparaRetencionenCdt.ToString();
            this.txtMontointeresdiario.Text = configuracion.intMontoDiarioParaRetenciondeCdt.ToString();
            this.txtMoraCreditos.Text = configuracion.decMoraCreditos.ToString();
            this.txtRutaRespaldo.Text = configuracion.strRutaRespaldo.ToString();
            this.txtDiasReceso.Text = configuracion.intDiasReceso.ToString();
            this.txtComentario1.Text = configuracion.strComentario1;
            this.txtComentario2.Text = configuracion.strComentario2;
            this.txtComentario3.Text = configuracion.strComentario3;
            this.txtMesActual.Text = configuracion.intMesEvaluado.ToString();
            this.txtAño.Text = configuracion.intAnoEvaluado.ToString();
            this.chkMostrarNumeroderifa.Checked = (bool)configuracion.bitPermiteNumeroRifa; 
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            tblConfiguracione configuracionNuevo = configuracion;

            configuracionNuevo.bitCargarTodos = this.chkCargarTodos.Checked;
            configuracionNuevo.bitTasadeUsura = this.chkTasadeUsura.Checked;
            configuracionNuevo.intValorCuotaAdultoMayor = Convert.ToInt32(this.txtValorCuotaadultomayor.Text);
            configuracionNuevo.intAtrasados = Convert.ToInt32(this.txtMesesAtrasados.Text);
            configuracionNuevo.fltPorcentajeparaRetencionenCdt = Convert.ToDouble(this.txtPorcentajeRetencion.Text);
            configuracionNuevo.intMontoDiarioParaRetenciondeCdt = Convert.ToInt32(this.txtMontointeresdiario.Text);
            configuracionNuevo.decMoraCreditos = Convert.ToDecimal(this.txtMoraCreditos.Text);
            configuracionNuevo.intDiasReceso = Convert.ToInt32(this.txtDiasReceso.Text);
            configuracionNuevo.strRutaRespaldo = this.txtRutaRespaldo.Text;
            configuracionNuevo.strComentario1 = this.txtComentario1.Text;
            configuracionNuevo.strComentario2 = this.txtComentario2.Text;
            configuracionNuevo.strComentario3 = this.txtComentario3.Text;
            configuracionNuevo.intMesEvaluado = Convert.ToInt32(this.txtMesActual.Text);
            configuracionNuevo.intAnoEvaluado = Convert.ToInt32(this.txtAño.Text);
            configuracionNuevo.bitPermiteNumeroRifa = this.chkMostrarNumeroderifa.Checked;

            utilidades.pmtdMensaje(new blConfiguracion().gmtdActualizarDatosdeConfiguracion(configuracionNuevo), "Agraciados");
        }
    }
}
