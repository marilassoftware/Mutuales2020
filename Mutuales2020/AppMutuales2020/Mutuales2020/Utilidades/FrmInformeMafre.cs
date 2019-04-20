namespace Mutuales2020.Utilidades
{
    using libMutuales2020.dominio;
    using libMutuales2020.logica;
    using System;
    using System.Windows.Forms;

    public partial class FrmInformeMafre : Form
    {
        public FrmInformeMafre()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.dgvInformeMafre.AutoGenerateColumns = false;
            this.dgvInformeMafre.DataSource = new blUtilidadesInformeMafre().consultaInformexFechaxTipo(this.dtpFecha.Value, this.cboTipo.Text);

            this.lblRegistros.Text = "Registros : " + (this.dgvInformeMafre.Rows.Count - 1).ToString();

        }

        private void FrmInformeMafre_Load(object sender, EventArgs e)
        {
            this.cboTipo.SelectedIndex = 0;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < this.dgvInformeMafre.Rows.Count; a++)
            {
                tblInformeMafre objInformeMafre = new tblInformeMafre();
                objInformeMafre.strEstado = Convert.ToString(this.dgvInformeMafre.Rows[a].Cells[8].Value);
                objInformeMafre.intCodigo = Convert.ToInt32(this.dgvInformeMafre.Rows[a].Cells[0].Value);

                if (!new blUtilidadesInformeMafre().actualizar(objInformeMafre))
                {
                    MessageBox.Show("No se pudo actualizar el registro " + objInformeMafre.intCodigo.ToString(), "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            this.dgvInformeMafre.AutoGenerateColumns = false;
            this.dgvInformeMafre.DataSource = new blUtilidadesInformeMafre().consultaInformexFechaxTipo(this.dtpFecha.Value, this.cboTipo.Text);

            this.lblRegistros.Text = "Registros : " + (this.dgvInformeMafre.Rows.Count - 1).ToString();
        }
    }
}
