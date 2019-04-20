namespace Mutuales2020.Utilidades
{
    partial class FrmNuevoAño
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtMes = new Texto.Texto();
            this.lblMes = new System.Windows.Forms.Label();
            this.txtAño = new Texto.Texto();
            this.lblAño = new System.Windows.Forms.Label();
            this.cboServicio = new System.Windows.Forms.ComboBox();
            this.Servicio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new Texto.Texto();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 32);
            this.panel1.TabIndex = 7;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(472, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "NUEVO AÑO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnActualizar);
            this.panel2.Controls.Add(this.txtMes);
            this.panel2.Controls.Add(this.lblMes);
            this.panel2.Controls.Add(this.txtAño);
            this.panel2.Controls.Add(this.lblAño);
            this.panel2.Controls.Add(this.cboServicio);
            this.panel2.Controls.Add(this.Servicio);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.txtCodigo);
            this.panel2.Controls.Add(this.lblCodigo);
            this.panel2.Location = new System.Drawing.Point(8, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 72);
            this.panel2.TabIndex = 8;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(392, 40);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(64, 24);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtMes
            // 
            this.txtMes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMes.Location = new System.Drawing.Point(336, 40);
            this.txtMes.MaxLength = 12;
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(48, 21);
            this.txtMes.TabIndex = 3;
            this.txtMes.Text = "0";
            this.txtMes.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMes_KeyPress);
            // 
            // lblMes
            // 
            this.lblMes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(296, 40);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(40, 16);
            this.lblMes.TabIndex = 25;
            this.lblMes.Text = "Mes";
            // 
            // txtAño
            // 
            this.txtAño.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAño.Location = new System.Drawing.Point(232, 40);
            this.txtAño.MaxLength = 12;
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(48, 21);
            this.txtAño.TabIndex = 2;
            this.txtAño.Text = "0";
            this.txtAño.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAño_KeyPress);
            // 
            // lblAño
            // 
            this.lblAño.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(200, 40);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(32, 16);
            this.lblAño.TabIndex = 23;
            this.lblAño.Text = "Año";
            // 
            // cboServicio
            // 
            this.cboServicio.DisplayMember = "strNombreSpr";
            this.cboServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServicio.FormattingEnabled = true;
            this.cboServicio.Location = new System.Drawing.Point(64, 40);
            this.cboServicio.Name = "cboServicio";
            this.cboServicio.Size = new System.Drawing.Size(121, 21);
            this.cboServicio.TabIndex = 1;
            this.cboServicio.ValueMember = "strCodSpr";
            this.cboServicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboServicio_KeyPress);
            // 
            // Servicio
            // 
            this.Servicio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Servicio.Location = new System.Drawing.Point(8, 40);
            this.Servicio.Name = "Servicio";
            this.Servicio.Size = new System.Drawing.Size(56, 16);
            this.Servicio.TabIndex = 21;
            this.Servicio.Text = "Servicio";
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(144, 12);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(312, 16);
            this.lblNombre.TabIndex = 20;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(59, 8);
            this.txtCodigo.MaxLength = 12;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(76, 21);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = "0";
            this.txtCodigo.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            this.txtCodigo.Enter += new System.EventHandler(this.txtCodigo_Enter);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(8, 8);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(48, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // FrmNuevoAño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 128);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNuevoAño";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Nuevo Año";
            this.Load += new System.EventHandler(this.FrmNuevoAño_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private Texto.Texto txtCodigo;
        private System.Windows.Forms.ComboBox cboServicio;
        private System.Windows.Forms.Label Servicio;
        private System.Windows.Forms.Button btnActualizar;
        private Texto.Texto txtMes;
        private System.Windows.Forms.Label lblMes;
        private Texto.Texto txtAño;
        private System.Windows.Forms.Label lblAño;
    }
}