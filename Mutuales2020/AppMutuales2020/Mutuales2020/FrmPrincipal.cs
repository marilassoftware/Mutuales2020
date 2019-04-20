namespace Mutuales2020
{
    using libMutuales2020.dominio;
    using Mutuales2020.Maestros;
    using Mutuales2020.Personas;
    using Mutuales2020.Servicios;
    using Seguridad;
    using SeguridadWindows.Dominio;
    using System;
    using System.Configuration;
    using System.Windows.Forms;
    using Mutuales2020.Servicios;
    using Mutuales2020.Ahorros;
    using Mutuales2020.Creditos;
    using Mutuales2020.Movimientos;
    using Mutuales2020.Utilidades;
    using Mutuales2020.Reportes.Socios;
    using Mutuales2020.Reportes.Ahorradores;
    using Mutuales2020.Reportes.AhorradoresEstudiantiles;
    using Mutuales2020.Reportes.AhorrosNavidenos;
    using Mutuales2020.Reportes.AhorrosaFuturo;
    using Mutuales2020.Reportes.Ahorros;
    using Mutuales2020.Reportes.Cdat;
    using Mutuales2020.Reportes.Agraciados;
    using Mutuales2020.Reportes.Deudas;
    using Mutuales2020.Reportes.Egresos;
    using Mutuales2020.Reportes.Fallecidos;
    using Mutuales2020.Reportes.Prestamos;
    using Mutuales2020.Reportes.Recibos;
    using Mutuales2020.Reportes.Retiros;
    using Mutuales2020.Reportes.RetirosEstudiantes;
    using Mutuales2020.Reportes.Transacciones;
    using Mutuales2020.Reportes.AhorrosEstudiantiles;

    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        #region metods
        /// <summary> Metodo que carga los valores para habilitar o no los controles.</summary>
        /// <param name="tstrOpcion"> Pantalla sobre la que se quieren habilitar o no los controles.</param>
        /// <returns> Un valor que indica si se habilita  no la pantalla.</returns>
        private bool pmtdCargarPermisos(string tstrOpcion)
        {
            acceso permiso = new blOpcionGrupoAppl().gmtdPermiso(propiedades.strAplicacion, propiedades.strGrupo, tstrOpcion);

            propiedades.bitConsultar = permiso.bolConsultar;
            propiedades.bitEditar = permiso.bolEditar;
            propiedades.bitEliminar = permiso.bolEliminar;
            propiedades.bitGuardar = permiso.bolIngresar;

            return permiso.bolEjecutar;
        }

        private static FrmPrincipal form = null;
        public static FrmPrincipal DefInstance
        {
            get
            {
                if (form == null || form.IsDisposed)
                {
                    form = new FrmPrincipal();
                }
                else
                {
                    form.BringToFront();
                }
                return form;
            }
            set
            {
                form = value;
            }
        }
        #endregion

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            propiedades.strFormActivo = "Principal";
            propiedades.strAplicacion = ConfigurationManager.AppSettings["Aplicacion"].ToString();
            propiedades.strNombreMutual = ConfigurationManager.AppSettings["NombreMutual"].ToString();
            propiedades.strNit = ConfigurationManager.AppSettings["Nit"].ToString();
            propiedades.strPersoneria = ConfigurationManager.AppSettings["Personeria"].ToString();

            propiedades.strConexionDatos = ConfigurationManager.ConnectionStrings["conexionDb"].ConnectionString.Replace("12345", "Sql__12345..");
            propiedades.strConexionSeguridad = ConfigurationManager.ConnectionStrings["ConexionSE"].ConnectionString.Replace("12345", "Sql__12345..");

            this.Text = "Sistema de administraciòn de mutuales.  Grupo: " + propiedades.strGrupo + " Usuario: " + propiedades.strLogin + " Versión: " + Application.ProductVersion;
        }

        #region MenuMaestros
        private void barriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmBarrios"))
            {
                frmBarrios objBarrio = new frmBarrios();
                Propiedades.strFormActivo = "FrmBarrios";
                objBarrio.MdiParent = this;
                objBarrio.Show();
            }
        }

        private void municipiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmMunicipios"))
            {
                frmMunicipios objMunicipio = new frmMunicipios();
                Propiedades.strFormActivo = "FrmMunicipios";
                objMunicipio.MdiParent = this;
                objMunicipio.Show();
            }
        }

        private void oficiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmOficios"))
            {
                frmOficio objOficio = new frmOficio();
                Propiedades.strFormActivo = "FrmOficios";
                objOficio.MdiParent = this;
                objOficio.Show();
            }
        }

        private void otrosIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmOtrosIngresos"))
            {
                frmOtrosIngresos objOtrosIngresos = new frmOtrosIngresos();
                Propiedades.strFormActivo = "FrmOtrosIngresos";
                objOtrosIngresos.MdiParent = this;
                objOtrosIngresos.Show();
            }
        }

        private void otrosEgresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmOtrosEgresos"))
            {
                frmOtrosEgresos otrosEgresos = new frmOtrosEgresos();
                Propiedades.strFormActivo = "FrmOtrosEgresos";
                otrosEgresos.MdiParent = this;
                otrosEgresos.Show();
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmProductos"))
            {
                frmProductos product = new frmProductos();
                Propiedades.strFormActivo = "FrmProductos";
                product.MdiParent = this;
                product.Show();
            }
        }

        private void semanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmSemana"))
            {
                FrmSemanas frmSemanas = new FrmSemanas();
                Propiedades.strFormActivo = "FrmSemana";
                frmSemanas.MdiParent = this;
                frmSemanas.Show();
            }
        }
        #endregion

        #region MenuPersonas
        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmSocios"))
            {
                FrmSocios socios = new FrmSocios();
                Propiedades.strFormActivo = "FrmSocios";
                FrmSocios.strLLamada = "Menu";
                socios.MdiParent = this;
                socios.Show();
            }
        }

        private void agraciadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmAgraciados"))
            {
                FrmAgraciados agraciados = new FrmAgraciados();
                Propiedades.strFormActivo = "FrmAgraciados";
                agraciados.MdiParent = this;
                agraciados.Show();
            }
        }

        private void fallecidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmFallecidos"))
            {
                FrmFallecidos fallecidos = new FrmFallecidos();
                Propiedades.strFormActivo = "FrmFallecidos";
                fallecidos.MdiParent = this;
                fallecidos.Show();
            }
        }

        private void tercerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmTerceros"))
            {
                FrmTerceros terceros = new FrmTerceros();
                Propiedades.strFormActivo = "FrmTerceros";
                terceros.MdiParent = this;
                terceros.Show();
            }
        }
        #endregion

        #region MenuServicios
        private void deudasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmDeudas"))
            {
                FrmDeudas deudas = new FrmDeudas();
                Propiedades.strFormActivo = "FrmDeudas";
                deudas.MdiParent = this;
                deudas.Show();
            }
        }

        private void primariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmServiciosPrimarios"))
            {
                FrmServiciosPrimarios serviciosPrimarios = new FrmServiciosPrimarios();
                Propiedades.strFormActivo = "FrmServiciosPrimarios";
                serviciosPrimarios.MdiParent = this;
                serviciosPrimarios.Show();
            }
        }

        private void secundariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmServiciosSecundarios"))
            {
                FrmServiciosSecundarios serviciosSecundarios = new FrmServiciosSecundarios();
                Propiedades.strFormActivo = "FrmServiciosSecundarios";
                serviciosSecundarios.MdiParent = this;
                serviciosSecundarios.Show();
            }
        }

        #endregion

        #region MenuAhorradores
        private void ahorradoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmAhorradores"))
            {
                FrmAhorradores ahorradores = new FrmAhorradores();
                Propiedades.strFormActivo = "FrmAhorradores";
                ahorradores.MdiParent = this;
                ahorradores.Show();
            }
        }

        private void ahorrosaFuturo_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmAhorrosaFuturo"))
            {
                FrmAhorrosaFuturo ahorros = new FrmAhorrosaFuturo();
                Propiedades.strFormActivo = "FrmAhorrosaFuturo";
                ahorros.MdiParent = this;
                ahorros.Show();
            }
        }

        private void bonificacionesafuturo_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmAhorrosaFuturoBonificacion"))
            {
                FrmAhorrosaFuturoBonificacion ahorros = new FrmAhorrosaFuturoBonificacion();
                Propiedades.strFormActivo = "FrmAhorrosaFuturoBonificacion";
                ahorros.MdiParent = this;
                ahorros.Show();
            }
        }

        private void interesesafuturo_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmAhorrosaFuturoIntereses"))
            {
                FrmAhorrosaFuturoIntereses ahorros = new FrmAhorrosaFuturoIntereses();
                Propiedades.strFormActivo = "FrmAhorrosaFuturoIntereses";
                ahorros.MdiParent = this;
                ahorros.Show();
            }
        }

        private void liquidacionafuturo_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmAhorrosaFuturoLiquidacion"))
            {
                FrmAhorrosaFuturoLiquidacion frmAhorrosaFuturoLiquidacion = new FrmAhorrosaFuturoLiquidacion();
                Propiedades.strFormActivo = "FrmAhorrosaFuturoLiquidacion";
                frmAhorrosaFuturoLiquidacion.MdiParent = this;
                frmAhorrosaFuturoLiquidacion.Show();
            }

        }


        private void ahorrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmAhorrosNatilleraEscolar"))
            {
                frmAhorrosNatilleraEscolar ahorros = new frmAhorrosNatilleraEscolar();
                Propiedades.strFormActivo = "FrmAhorrosNatilleraEscolar";
                ahorros.MdiParent = this;
                ahorros.Show();
            }
        }

        private void interesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmAhorrosNatilleraEscolarInte"))
            {
                frmAhorrosNatilleraEscolarIntereses ahorros = new frmAhorrosNatilleraEscolarIntereses();
                Propiedades.strFormActivo = "FrmAhorrosNatilleraEscolarInte";
                ahorros.MdiParent = this;
                ahorros.Show();
            }

        }

        private void liquidaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("frmAhorrosNatilleraEscolarLiqu"))
            {
                frmAhorrosNatilleraEscolarLiquidacion ahorros = new frmAhorrosNatilleraEscolarLiquidacion();
                Propiedades.strFormActivo = "frmAhorrosNatilleraEscolarLiqu";
                ahorros.MdiParent = this;
                ahorros.Show();
            }

        }

        private void ahorrosnavideños_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmAhorrosNavideño"))
            {
                frmAhorrosNavideño ahorros = new frmAhorrosNavideño();
                Propiedades.strFormActivo = "FrmAhorrosNavideño";
                ahorros.MdiParent = this;
                ahorros.Show();
            }
        }

        private void bonificacionesnavideñas_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmAhorrosNavideñoBonificacion"))
            {
                FrmAhorrosNavideñoBonificacion ahorros = new FrmAhorrosNavideñoBonificacion();
                Propiedades.strFormActivo = "FrmAhorrosNavideñoBonificacion";
                ahorros.MdiParent = this;
                ahorros.Show();
            }
        }

        private void interesesnavideños_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmAhorrosNavideñoIntereses"))
            {
                FrmAhorrosNavideñoIntereses ahorros = new FrmAhorrosNavideñoIntereses();
                Propiedades.strFormActivo = "FrmAhorrosNavideñoIntereses";
                ahorros.MdiParent = this;
                ahorros.Show();
            }
        }

        private void liquidaciónNavideños_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmAhorrosNavideñoLiquidacion"))
            {
                FrmAhorrosNavideñoLiquidacion frmAhorrosNavideñoLiquidacion = new FrmAhorrosNavideñoLiquidacion();
                Propiedades.strFormActivo = "FrmAhorrosNavideñoLiquidacion";
                frmAhorrosNavideñoLiquidacion.MdiParent = this;
                frmAhorrosNavideñoLiquidacion.Show();
            }
        }

        private void cdtsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmAhorrosCdt"))
            {
                frmAhorrosCdt ahorros = new frmAhorrosCdt();
                Propiedades.strFormActivo = "FrmAhorrosCdt";
                ahorros.MdiParent = this;
                ahorros.Show();
            }

        }

        private void causacióncdtsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmAhorrosCdtCausacion"))
            {
                frmAhorrosCdtCausacion ahorros = new frmAhorrosCdtCausacion();
                Propiedades.strFormActivo = "FrmAhorrosCdtCausacion";
                ahorros.MdiParent = this;
                ahorros.Show();
            }
        }

        #endregion

        #region MenuCreditos
        private void creditosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmCreditos"))
            {
                frmCreditos frmTipodeCredito = new frmCreditos();
                Propiedades.strFormActivo = "FrmCreditos";
                frmTipodeCredito.MdiParent = this;
                frmTipodeCredito.Show();
            }
        }

        private void lineasDeCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmLineasdeCredito"))
            {
                frmCreditosLineas frmTipodeCredito = new frmCreditosLineas();
                Propiedades.strFormActivo = "FrmLineasdeCredito";
                frmTipodeCredito.MdiParent = this;
                frmTipodeCredito.Show();
            }
        }

        private void tiposDeCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmTiposdeCredito"))
            {
                frmTiposdeCredito frmTipodeCredito = new frmTiposdeCredito();
                Propiedades.strFormActivo = "FrmTiposdeCredito";
                frmTipodeCredito.MdiParent = this;
                frmTipodeCredito.Show();
            }
        }

        private void clasificaciondecreditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmClasificaciondeCredito"))
            {
                frmCreditosClasificacion frmTipodeCredito = new frmCreditosClasificacion();
                Propiedades.strFormActivo = "FrmClasificaciondeCredito";
                frmTipodeCredito.MdiParent = this;
                frmTipodeCredito.Show();
            }
        }

        private void provisionDeCarteraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmProvisiondeCartera"))
            {
                frmProvisiondeCartera frmProvisiondeCartera = new frmProvisiondeCartera();
                Propiedades.strFormActivo = "FrmProvisiondeCartera";
                frmProvisiondeCartera.MdiParent = this;
                frmProvisiondeCartera.Show();
            }

        }
        #endregion

        #region MenuMovimientos
        private void egresos_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmEgresos"))
            {
                frmEgresos frmTipodeCredito = new frmEgresos();
                Propiedades.strFormActivo = "FrmEgresos";
                frmTipodeCredito.MdiParent = this;
                frmTipodeCredito.Show();
            }
        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmIngresos"))
            {
                frmIngresos frmTipodeCredito = new frmIngresos();
                Propiedades.strFormActivo = "FrmIngresos";
                frmTipodeCredito.MdiParent = this;
                frmTipodeCredito.Show();
            }

        }

        #endregion

        #region MenuUtilidades
        private void cambiarBeneficiarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmCambiarBeneficiario"))
            {
                FrmCambiarBeneficiario frmCambiarBeneficiario = new FrmCambiarBeneficiario();
                Propiedades.strFormActivo = "FrmCambiarBeneficiario";
                frmCambiarBeneficiario.MdiParent = this;
                frmCambiarBeneficiario.Show();
            }
        }

        private void cambiarBeneficiarioASocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmCambiarBeneficiarioaSocio"))
            {
                FrmCambiarBeneficiarioaSocio frmCambiarBeneficiarioaSocio = new FrmCambiarBeneficiarioaSocio();
                Propiedades.strFormActivo = "FrmCambiarBeneficiarioaSocio";
                frmCambiarBeneficiarioaSocio.MdiParent = this;
                frmCambiarBeneficiarioaSocio.Show();
            }
        }

        private void cambiarSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmCambiarCedula"))
            {
                frmCambiarCedula frmTipodeCredito = new frmCambiarCedula();
                Propiedades.strFormActivo = "FrmCambiarCedula";
                frmTipodeCredito.MdiParent = this;
                frmTipodeCredito.Show();
            }
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmConfiguracion"))
            {
                FrmConfiguracion frmConfiguracion = new FrmConfiguracion();
                Propiedades.strFormActivo = "FrmConfiguracion";
                frmConfiguracion.MdiParent = this;
                frmConfiguracion.Show();
            }

        }

        private void deshabilitarSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmDeshabilitarSocios"))
            {
                FrmDeshabilitarSocios frmDeshabilitarSocios = new FrmDeshabilitarSocios();
                Propiedades.strFormActivo = "FrmDeshabilitarSocios";
                frmDeshabilitarSocios.MdiParent = this;
                frmDeshabilitarSocios.Show();
            }
        }

        private void habilitarAnuladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmHabilitarAnulado"))
            {
                FrmHabilitarAnulado frmHabilitarAnulado = new FrmHabilitarAnulado();
                Propiedades.strFormActivo = "FrmHabilitarAnulado";
                frmHabilitarAnulado.MdiParent = this;
                frmHabilitarAnulado.Show();
            }
        }

        private void informeMafreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmInformeMafre"))
            {
                FrmInformeMafre frmInformeMafre = new FrmInformeMafre();
                Propiedades.strFormActivo = "FrmInformeMafre";
                frmInformeMafre.MdiParent = this;
                frmInformeMafre.Show();
            }
        }

        private void liquidarAhorrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmLiquidarAhorros"))
            {
                FrmLiquidarAhorros frmLiquidarAhorros = new FrmLiquidarAhorros();
                Propiedades.strFormActivo = "FrmLiquidarAhorros";
                frmLiquidarAhorros.MdiParent = this;
                frmLiquidarAhorros.Show();
            }
        }

        private void liquidarInteresesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmLiquidarIntereses"))
            {
                FrmLiquidarIntereses frmLiquidarIntereses = new FrmLiquidarIntereses();
                Propiedades.strFormActivo = "FrmLiquidarIntereses";
                frmLiquidarIntereses.MdiParent = this;
                frmLiquidarIntereses.Show();
            }
        }

        private void liquidarInteresesEstudiantilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("frmLiquidarInteresesEstudianti"))
            {
                FrmLiquidarInteresesEstudiantiles frmLiquidarInteresesEstudiantiles = new FrmLiquidarInteresesEstudiantiles();
                Propiedades.strFormActivo = "frmLiquidarInteresesEstudianti";
                frmLiquidarInteresesEstudiantiles.MdiParent = this;
                frmLiquidarInteresesEstudiantiles.Show();
            }

        }

        private void nuevoAñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmNuevoAño"))
            {
                FrmNuevoAño frmNuevoAño = new FrmNuevoAño();
                Propiedades.strFormActivo = "FrmNuevoAño";
                frmNuevoAño.MdiParent = this;
                frmNuevoAño.Show();
            }

        }

        private void numerosRifaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmNumeroRifa"))
            {
                FrmNumeroRifa frmNumeroRifa = new FrmNumeroRifa();
                Propiedades.strFormActivo = "FrmNumeroRifa";
                frmNumeroRifa.MdiParent = this;
                frmNumeroRifa.Show();
            }
        }

        private void recaudoAFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmRecaudosaFecha"))
            {
                frmRecaudosaFecha frmTipodeCredito = new frmRecaudosaFecha();
                Propiedades.strFormActivo = "FrmRecaudosaFecha";
                frmTipodeCredito.MdiParent = this;
                frmTipodeCredito.Show();
            }

        }

        private void respaldosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmRespaldos"))
            {
                frmRespaldos frmTipodeCredito = new frmRespaldos();
                Propiedades.strFormActivo = "FrmRespaldos";
                frmTipodeCredito.MdiParent = this;
                frmTipodeCredito.Show();
            }

        }

        private void saldosAhorrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmSaldosAhorros"))
            {
                FrmSaldosAhorros frmSaldosAhorros = new FrmSaldosAhorros();
                Propiedades.strFormActivo = "FrmSaldosAhorros";
                frmSaldosAhorros.MdiParent = this;
                frmSaldosAhorros.Show();
            }

        }

        private void socioYAgraciadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmSociosyBeneficiarios"))
            {
                FrmSociosyBeneficiarios frmSociosyBeneficiarios = new FrmSociosyBeneficiarios();
                Propiedades.strFormActivo = "FrmSociosyBeneficiarios";
                frmSociosyBeneficiarios.MdiParent = this;
                frmSociosyBeneficiarios.Show();
            }

        }
        #endregion

        private void mnuReportesociosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmReportesSocios"))
            {
                frmReportesSocios frmTipodeCredito = new frmReportesSocios();
                Propiedades.strFormActivo = "FrmReportesSocios";
                frmTipodeCredito.MdiParent = this;
                frmTipodeCredito.Show();
            }
        }

        private void mnuReportecdtToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmReporteAhorradores"))
            {
                frmReporteAhorradores FrmReporteAhorradores = new frmReporteAhorradores();
                Propiedades.strFormActivo = "FrmReporteAhorradores";
                FrmReporteAhorradores.MdiParent = this;
                FrmReporteAhorradores.Show();
            }
        }

        private void ahorradoresEscolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmReportesRetirosEstudiantile"))
            {
                FrmReporteAhorradoresEstudiantiles frmReportesAhorros = new FrmReporteAhorradoresEstudiantiles();
                Propiedades.strFormActivo = "FrmReportesRetirosEstudiantile";
                frmReportesAhorros.MdiParent = this;
                frmReportesAhorros.Show();
            }
        }

        private void ahorradoresEstudiantilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmReporteAhorradoresEstudiant"))
            {
                FrmReporteAhorradoresEstudiantiles frmReportesAhorros = new FrmReporteAhorradoresEstudiantiles();
                Propiedades.strFormActivo = "FrmReporteAhorradoresEstudiant";
                frmReportesAhorros.MdiParent = this;
                frmReportesAhorros.Show();
            }
        }

        private void mnuReporteahorradoresNavideñosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmReporteAhorrosNavidenos"))
            {
                FrmAhorradoresNavidenos frmAhorradoresNavidenos = new FrmAhorradoresNavidenos();
                Propiedades.strFormActivo = "FrmReporteAhorrosNavidenos";
                frmAhorradoresNavidenos.MdiParent = this;
                frmAhorradoresNavidenos.Show();

            }
        }

        private void mnuReporteahorradoresAFuturoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmReporteAhorradoresaFuturo"))
            {
                FrmReporteAhorradoresaFuturo frmReporteAhorradoresaFuturo = new FrmReporteAhorradoresaFuturo();
                Propiedades.strFormActivo = "FrmReporteAhorradoresaFuturo";
                frmReporteAhorradoresaFuturo.MdiParent = this;
                frmReporteAhorradoresaFuturo.Show();
            }
        }

        private void mnuReporteahorrosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmReportesAhorros"))
            {
                FrmReportesAhorros frmReportesAhorros = new FrmReportesAhorros();
                Propiedades.strFormActivo = "FrmReportesAhorros";
                frmReportesAhorros.MdiParent = this;
                frmReportesAhorros.Show();
            }

        }

        private void mnuReportecdatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmReportesCdat"))
            {
                FrmReportesCdat frmReportesCdat = new FrmReportesCdat();
                Propiedades.strFormActivo = "FrmReportesCdat";
                frmReportesCdat.MdiParent = this;
                frmReportesCdat.Show();
            }
        }

        private void mnuReportedeAgraciados_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmReportedeAgraciados"))
            {
                frmReportedeAgraciados FrmReportedeAgraciados = new frmReportedeAgraciados();
                Propiedades.strFormActivo = "FrmReportedeAgraciados";
                FrmReportedeAgraciados.MdiParent = this;
                FrmReportedeAgraciados.Show();
            }
        }

        private void mnuReportedeudasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmReportesDeudas"))
            {
                FrmReportesDeudas frmReportesDeudas = new FrmReportesDeudas();
                Propiedades.strFormActivo = "FrmReportesDeudas";
                frmReportesDeudas.MdiParent = this;
                frmReportesDeudas.Show();
            }
        }

        private void mnuReporteegresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmReportesEgresos"))
            {
                FrmReportesEgresos frmReportesEgresos = new FrmReportesEgresos();
                Propiedades.strFormActivo = "FrmReportesEgresos";
                frmReportesEgresos.MdiParent = this;
                frmReportesEgresos.Show();
            }
        }

        private void mnuReportefallecidosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmReporteFallecidos"))
            {
                FrmReporteFallecidos frmReporteFallecidos = new FrmReporteFallecidos();
                Propiedades.strFormActivo = "FrmReporteFallecidos";
                frmReporteFallecidos.MdiParent = this;
                frmReporteFallecidos.Show();
            }
        }

        private void mnuReportepréstamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmReportePrestamos"))
            {
                frmReportePrestamos frmTipodeCredito = new frmReportePrestamos();
                Propiedades.strFormActivo = "FrmReportePrestamos";
                frmTipodeCredito.MdiParent = this;
                frmTipodeCredito.Show();
            }
        }

        private void mnuReporterecibosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmReportesRecibos"))
            {
                frmReportesRecibos frmTipodeCredito = new frmReportesRecibos();
                Propiedades.strFormActivo = "FrmReportesRecibos";
                frmTipodeCredito.MdiParent = this;
                frmTipodeCredito.Show();
            }

        }

        private void mnuReporteretirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmReportesRetiros"))
            {
                FrmReportesRetiros frmReportesRetiros = new FrmReportesRetiros();
                Propiedades.strFormActivo = "FrmReportesRetiros";
                frmReportesRetiros.MdiParent = this;
                frmReportesRetiros.Show();
            }
        }

        private void retirosEstudiantilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmReportesRetirosEstudiantile"))
            {
                FrmReportesRetirosEstudiantiles frmReportesRetirosEstudiantiles = new FrmReportesRetirosEstudiantiles();
                Propiedades.strFormActivo = "FrmReportesRetirosEstudiantile";
                frmReportesRetirosEstudiantiles.MdiParent = this;
                frmReportesRetirosEstudiantiles.Show();
            }
        }

        private void mnuReportetransaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmReportesTransacciones"))
            {
                FrmReportesTransacciones frmReportesTransacciones = new FrmReportesTransacciones();
                Propiedades.strFormActivo = "FrmReportesTransacciones";
                frmReportesTransacciones.MdiParent = this;
                frmReportesTransacciones.Show();
            }
        }

        private void ahorrosEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (propiedades.strFormActivo == "Principal" && pmtdCargarPermisos("FrmReportesAhorrosEstudiantile"))
            {
                FrmReportesAhorrosEstudiantiles frmReportesAhorros = new FrmReportesAhorrosEstudiantiles();
                Propiedades.strFormActivo = "FrmReportesAhorrosEstudiantile";
                frmReportesAhorros.MdiParent = this;
                frmReportesAhorros.Show();
            }
        }
    }
}
