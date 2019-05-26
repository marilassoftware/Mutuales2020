namespace Mutuales2020.Utilidades
{
    partial class FrmCambiarBeneficiario
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
            this.txtSocioNuevo = new Texto.Texto();
            this.txtSocioActual = new Texto.Texto();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboBeneficiario = new System.Windows.Forms.ComboBox();
            this.lblBeneficiario = new System.Windows.Forms.Label();
            this.lblSocioActual = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 40);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, -1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(632, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CAMBIAR BENEFICIARIO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtSocioNuevo);
            this.panel2.Controls.Add(this.txtSocioActual);
            this.panel2.Controls.Add(this.btnActualizar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cboBeneficiario);
            this.panel2.Controls.Add(this.lblBeneficiario);
            this.panel2.Controls.Add(this.lblSocioActual);
            this.panel2.Location = new System.Drawing.Point(6, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 45);
            this.panel2.TabIndex = 8;
            // 
            // txtSocioNuevo
            // 
            this.txtSocioNuevo.Location = new System.Drawing.Point(480, 8);
            this.txtSocioNuevo.Name = "txtSocioNuevo";
            this.txtSocioNuevo.Size = new System.Drawing.Size(40, 20);
            this.txtSocioNuevo.TabIndex = 2;
            this.txtSocioNuevo.Text = "0";
            this.txtSocioNuevo.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtSocioNuevo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtSocioActual
            // 
            this.txtSocioActual.Location = new System.Drawing.Point(88, 8);
            this.txtSocioActual.Name = "txtSocioActual";
            this.txtSocioActual.Size = new System.Drawing.Size(40, 20);
            this.txtSocioActual.TabIndex = 0;
            this.txtSocioActual.Text = "0";
            this.txtSocioActual.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtSocioActual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSocioActual_KeyPress);
            this.txtSocioActual.Leave += new System.EventHandler(this.txtSocioActual_Leave);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Location = new System.Drawing.Point(536, 8);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(88, 24);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Socio Actual*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboBeneficiario
            // 
            this.cboBeneficiario.DisplayMember = "strNombreCompleto";
            this.cboBeneficiario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBeneficiario.FormattingEnabled = true;
            this.cboBeneficiario.Location = new System.Drawing.Point(216, 8);
            this.cboBeneficiario.Name = "cboBeneficiario";
            this.cboBeneficiario.Size = new System.Drawing.Size(176, 21);
            this.cboBeneficiario.TabIndex = 1;
            this.cboBeneficiario.ValueMember = "strCedulaAgra";
            this.cboBeneficiario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboBeneficiario_KeyPress);
            // 
            // lblBeneficiario
            // 
            this.lblBeneficiario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeneficiario.Location = new System.Drawing.Point(136, 8);
            this.lblBeneficiario.Name = "lblBeneficiario";
            this.lblBeneficiario.Size = new System.Drawing.Size(83, 16);
            this.lblBeneficiario.TabIndex = 9;
            this.lblBeneficiario.Text = "Beneficiario*";
            this.lblBeneficiario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSocioActual
            // 
            this.lblSocioActual.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocioActual.Location = new System.Drawing.Point(5, 8);
            this.lblSocioActual.Name = "lblSocioActual";
            this.lblSocioActual.Size = new System.Drawing.Size(83, 16);
            this.lblSocioActual.TabIndex = 7;
            this.lblSocioActual.Text = "Socio Actual*";
            this.lblSocioActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmCambiarBeneficiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 102);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCambiarBeneficiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Beneficiario";
            this.Load += new System.EventHandler(this.FrmCambiarBeneficiario_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSocioActual;
        private System.Windows.Forms.ComboBox cboBeneficiario;
        private System.Windows.Forms.Label lblBeneficiario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizar;
        private Texto.Texto txtSocioActual;
        private Texto.Texto txtSocioNuevo;
    }
}