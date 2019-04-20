namespace Mutuales2020.Utilidades
{
    partial class FrmInformeMafre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvInformeMafre = new System.Windows.Forms.DataGridView();
            this.intCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strEstado = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformeMafre)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 32);
            this.panel1.TabIndex = 26;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(-2, -1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(855, 28);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "INFORMACIÓN MAFRE";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnActualizar);
            this.panel2.Controls.Add(this.lblRegistros);
            this.panel2.Controls.Add(this.btnConsultar);
            this.panel2.Controls.Add(this.dgvInformeMafre);
            this.panel2.Controls.Add(this.cboTipo);
            this.panel2.Controls.Add(this.lblTipo);
            this.panel2.Controls.Add(this.dtpFecha);
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Location = new System.Drawing.Point(4, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(857, 364);
            this.panel2.TabIndex = 27;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(507, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblRegistros
            // 
            this.lblRegistros.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.Location = new System.Drawing.Point(402, 5);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(119, 23);
            this.lblRegistros.TabIndex = 9;
            this.lblRegistros.Text = "Registros :";
            this.lblRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(321, 6);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvInformeMafre
            // 
            this.dgvInformeMafre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformeMafre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intCodigo,
            this.intSocio,
            this.strCedula,
            this.strNombre,
            this.strApellido,
            this.bitSocio,
            this.FechaNac,
            this.Fecha,
            this.strEstado});
            this.dgvInformeMafre.Location = new System.Drawing.Point(4, 35);
            this.dgvInformeMafre.Name = "dgvInformeMafre";
            this.dgvInformeMafre.Size = new System.Drawing.Size(848, 321);
            this.dgvInformeMafre.TabIndex = 7;
            // 
            // intCodigo
            // 
            this.intCodigo.DataPropertyName = "intCodigo";
            this.intCodigo.HeaderText = "Código";
            this.intCodigo.Name = "intCodigo";
            this.intCodigo.ReadOnly = true;
            this.intCodigo.Width = 60;
            // 
            // intSocio
            // 
            this.intSocio.DataPropertyName = "intSocio";
            this.intSocio.HeaderText = "Socio";
            this.intSocio.Name = "intSocio";
            this.intSocio.Width = 60;
            // 
            // strCedula
            // 
            this.strCedula.DataPropertyName = "strCedula";
            this.strCedula.HeaderText = "Cédula";
            this.strCedula.Name = "strCedula";
            this.strCedula.Width = 80;
            // 
            // strNombre
            // 
            this.strNombre.DataPropertyName = "strNombre";
            this.strNombre.HeaderText = "Nombre";
            this.strNombre.Name = "strNombre";
            this.strNombre.Width = 130;
            // 
            // strApellido
            // 
            this.strApellido.DataPropertyName = "strApellido";
            this.strApellido.HeaderText = "Apellido";
            this.strApellido.Name = "strApellido";
            this.strApellido.Width = 130;
            // 
            // bitSocio
            // 
            this.bitSocio.DataPropertyName = "bitSocio";
            this.bitSocio.HeaderText = "Socio";
            this.bitSocio.Name = "bitSocio";
            this.bitSocio.Width = 60;
            // 
            // FechaNac
            // 
            this.FechaNac.DataPropertyName = "FechaNac";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.FechaNac.DefaultCellStyle = dataGridViewCellStyle1;
            this.FechaNac.HeaderText = "Fecha Nac";
            this.FechaNac.Name = "FechaNac";
            this.FechaNac.Width = 90;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle2;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 90;
            // 
            // strEstado
            // 
            this.strEstado.DataPropertyName = "strEstado";
            this.strEstado.HeaderText = "Estado";
            this.strEstado.Items.AddRange(new object[] {
            "Estable",
            "Sacar",
            "Adicionar"});
            this.strEstado.Name = "strEstado";
            this.strEstado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.strEstado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.strEstado.Width = 85;
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Estable",
            "Adicionar",
            "Sacar"});
            this.cboTipo.Location = new System.Drawing.Point(194, 6);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 21);
            this.cboTipo.TabIndex = 1;
            // 
            // lblTipo
            // 
            this.lblTipo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(157, 9);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(36, 23);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(58, 8);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(93, 20);
            this.dtpFecha.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(6, 5);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(52, 23);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmInformeMafre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 409);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInformeMafre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información Mafre";
            this.Load += new System.EventHandler(this.FrmInformeMafre_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformeMafre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.DataGridView dgvInformeMafre;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn intCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn intSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn strNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn strApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewComboBoxColumn strEstado;
    }
}