namespace Mutuales2020.Utilidades
{
    partial class frmCambiarCedula
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblCambiar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblModificar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCambiar = new Texto.Texto();
            this.txtModificar = new Texto.Texto();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(9, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(247, 23);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.Items.AddRange(new object[] {
            "Agraciado",
            "Socio",
            "Ahorrador"});
            this.cboTipo.Location = new System.Drawing.Point(45, 7);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(93, 23);
            this.cboTipo.TabIndex = 0;
            this.cboTipo.Enter += new System.EventHandler(this.cboTipo_Enter);
            this.cboTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboTipo_KeyPress);
            // 
            // lblTipo
            // 
            this.lblTipo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(6, 7);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(36, 16);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo*";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCambiar
            // 
            this.lblCambiar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambiar.Location = new System.Drawing.Point(302, 7);
            this.lblCambiar.Name = "lblCambiar";
            this.lblCambiar.Size = new System.Drawing.Size(89, 16);
            this.lblCambiar.TabIndex = 4;
            this.lblCambiar.Text = "Cambiar por*";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 30);
            this.panel1.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(-1, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(470, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CAMBIAR CÉDULA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModificar
            // 
            this.lblModificar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificar.Location = new System.Drawing.Point(146, 7);
            this.lblModificar.Name = "lblModificar";
            this.lblModificar.Size = new System.Drawing.Size(82, 19);
            this.lblModificar.TabIndex = 2;
            this.lblModificar.Text = "Documento*";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtCambiar);
            this.panel2.Controls.Add(this.txtModificar);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.cboTipo);
            this.panel2.Controls.Add(this.lblTipo);
            this.panel2.Controls.Add(this.lblCambiar);
            this.panel2.Controls.Add(this.lblModificar);
            this.panel2.Location = new System.Drawing.Point(4, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 65);
            this.panel2.TabIndex = 7;
            // 
            // txtCambiar
            // 
            this.txtCambiar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambiar.Location = new System.Drawing.Point(383, 4);
            this.txtCambiar.MaxLength = 12;
            this.txtCambiar.Name = "txtCambiar";
            this.txtCambiar.Size = new System.Drawing.Size(76, 21);
            this.txtCambiar.TabIndex = 2;
            this.txtCambiar.Text = "0";
            this.txtCambiar.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtCambiar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCambiar_KeyPress);
            // 
            // txtModificar
            // 
            this.txtModificar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificar.Location = new System.Drawing.Point(221, 5);
            this.txtModificar.MaxLength = 12;
            this.txtModificar.Name = "txtModificar";
            this.txtModificar.Size = new System.Drawing.Size(76, 21);
            this.txtModificar.TabIndex = 1;
            this.txtModificar.Text = "0";
            this.txtModificar.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtModificar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModificar_KeyPress);
            this.txtModificar.Enter += new System.EventHandler(this.txtModificar_Enter);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(262, 35);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // frmCambiarCedula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 107);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCambiarCedula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar cédula";
            this.Load += new System.EventHandler(this.frmCambiarCedula_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblCambiar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblModificar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnModificar;
        private Texto.Texto txtCambiar;
        private Texto.Texto txtModificar;
    }
}