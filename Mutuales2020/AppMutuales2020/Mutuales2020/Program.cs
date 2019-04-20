using libMutuales2020.dominio;
using System;
using System.Windows.Forms;

namespace Mutuales2020
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }

        public static void gmtdAsignarPermisos(ref Button btnGuardar,
                                       ref Button btnModificar,
                                       ref Button btnEliminar)
        {
            btnEliminar.Enabled = propiedades.bitEliminar;
            btnGuardar.Enabled = propiedades.bitGuardar;
            btnModificar.Enabled = propiedades.bitEditar;
        }
    }
}
