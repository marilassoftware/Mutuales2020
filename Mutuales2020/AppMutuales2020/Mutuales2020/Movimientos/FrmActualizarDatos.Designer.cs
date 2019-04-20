namespace Mutuales2020.Movimientos
{
    partial class FrmActualizarDatos
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
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtProcedencia = new Texto.Texto();
            this.lblProcedencia = new System.Windows.Forms.Label();
            this.txtDireccion = new Texto.Texto();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtTelefono = new Texto.Texto();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.txtApellido2 = new Texto.Texto();
            this.lblApellido2 = new System.Windows.Forms.Label();
            this.txtApellido1 = new Texto.Texto();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.txtNombre = new Texto.Texto();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCedula = new Texto.Texto();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtCodigo = new Texto.Texto();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pnlTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Location = new System.Drawing.Point(5, 5);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(334, 31);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(3, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(322, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ACTUALIZA DATOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtProcedencia);
            this.panel1.Controls.Add(this.lblProcedencia);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.lblDireccion);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.lblTelefono);
            this.panel1.Controls.Add(this.dtpFechaNac);
            this.panel1.Controls.Add(this.lblNacimiento);
            this.panel1.Controls.Add(this.txtApellido2);
            this.panel1.Controls.Add(this.lblApellido2);
            this.panel1.Controls.Add(this.txtApellido1);
            this.panel1.Controls.Add(this.lblApellido1);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.lblCedula);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Location = new System.Drawing.Point(5, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 233);
            this.panel1.TabIndex = 1;
            // 
            // txtProcedencia
            // 
            this.txtProcedencia.Enabled = false;
            this.txtProcedencia.Location = new System.Drawing.Point(88, 28);
            this.txtProcedencia.MaxLength = 25;
            this.txtProcedencia.Name = "txtProcedencia";
            this.txtProcedencia.Size = new System.Drawing.Size(237, 20);
            this.txtProcedencia.TabIndex = 1;
            this.txtProcedencia.Tipo = Texto.Texto.Opciones.Texto;
            // 
            // lblProcedencia
            // 
            this.lblProcedencia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcedencia.Location = new System.Drawing.Point(5, 26);
            this.lblProcedencia.Name = "lblProcedencia";
            this.lblProcedencia.Size = new System.Drawing.Size(88, 20);
            this.lblProcedencia.TabIndex = 79;
            this.lblProcedencia.Text = "Procedencia";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(88, 206);
            this.txtDireccion.MaxLength = 50;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(236, 20);
            this.txtDireccion.TabIndex = 8;
            this.txtDireccion.Tipo = Texto.Texto.Opciones.Texto;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(7, 207);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(66, 20);
            this.lblDireccion.TabIndex = 77;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(88, 180);
            this.txtTelefono.MaxLength = 15;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(147, 20);
            this.txtTelefono.TabIndex = 7;
            this.txtTelefono.Tipo = Texto.Texto.Opciones.Texto;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(7, 181);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(66, 20);
            this.lblTelefono.TabIndex = 75;
            this.lblTelefono.Text = "Teléfono";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(88, 154);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(91, 20);
            this.dtpFechaNac.TabIndex = 6;
            this.dtpFechaNac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaNac_KeyPress);
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacimiento.Location = new System.Drawing.Point(6, 154);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(75, 20);
            this.lblNacimiento.TabIndex = 73;
            this.lblNacimiento.Text = "Nacimiento";
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(87, 127);
            this.txtApellido2.MaxLength = 15;
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(147, 20);
            this.txtApellido2.TabIndex = 5;
            this.txtApellido2.Tipo = Texto.Texto.Opciones.Texto;
            this.txtApellido2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido2_KeyPress);
            // 
            // lblApellido2
            // 
            this.lblApellido2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido2.Location = new System.Drawing.Point(6, 128);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(66, 20);
            this.lblApellido2.TabIndex = 71;
            this.lblApellido2.Text = "Apellido 2";
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(87, 101);
            this.txtApellido1.MaxLength = 15;
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(147, 20);
            this.txtApellido1.TabIndex = 4;
            this.txtApellido1.Tipo = Texto.Texto.Opciones.Texto;
            this.txtApellido1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido1_KeyPress);
            // 
            // lblApellido1
            // 
            this.lblApellido1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido1.Location = new System.Drawing.Point(6, 102);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(66, 20);
            this.lblApellido1.TabIndex = 69;
            this.lblApellido1.Text = "Apellido 1";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(87, 75);
            this.txtNombre.MaxLength = 25;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(237, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Tipo = Texto.Texto.Opciones.Texto;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 76);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 20);
            this.lblNombre.TabIndex = 67;
            this.lblNombre.Text = "Nombre";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(87, 51);
            this.txtCedula.MaxLength = 15;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(106, 20);
            this.txtCedula.TabIndex = 2;
            this.txtCedula.Text = "0";
            this.txtCedula.Tipo = Texto.Texto.Opciones.Numerico;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // lblCedula
            // 
            this.lblCedula.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(6, 53);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(51, 20);
            this.lblCedula.TabIndex = 65;
            this.lblCedula.Text = "Cédula";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(86, 3);
            this.txtCodigo.MaxLength = 4;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(62, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = "0";
            this.txtCodigo.Tipo = Texto.Texto.Opciones.Numerico;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(5, 4);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAceptar);
            this.panel2.Location = new System.Drawing.Point(5, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 46);
            this.panel2.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(9, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(316, 32);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FrmActualizarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 326);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmActualizarDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Datos";
            this.Load += new System.EventHandler(this.FrmActualizarDatos_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCodigo;
        private Texto.Texto txtCedula;
        private System.Windows.Forms.Label lblCedula;
        private Texto.Texto txtCodigo;
        private Texto.Texto txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private Texto.Texto txtApellido1;
        private System.Windows.Forms.Label lblApellido1;
        private Texto.Texto txtApellido2;
        private System.Windows.Forms.Label lblApellido2;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label lblNacimiento;
        private Texto.Texto txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private Texto.Texto txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAceptar;
        private Texto.Texto txtProcedencia;
        private System.Windows.Forms.Label lblProcedencia;
    }
}