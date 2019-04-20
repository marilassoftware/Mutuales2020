using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace winExequial2010.Utilidades
{
    public partial class FrmMigrarRecibos : Form
    {
        public FrmMigrarRecibos()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<tblIngreso> lstIngresosConsultados = new blRecibosIngresos().gmtdConsultaIngresos(this.dtpFechaInicial.Value, this.dtpFechaFinal.Value);

            foreach (tblIngreso ingreso in lstIngresosConsultados)
            {
                string strResultado = new blRecibosIngresos().gmtdMigrarRecibos(ingreso);
                if (strResultado.Substring(0, 1) == "-")
                    MessageBox.Show(strResultado); 
            }
        }
    }
}
