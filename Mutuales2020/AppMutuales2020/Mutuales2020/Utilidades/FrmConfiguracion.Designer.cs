namespace Mutuales2020.Utilidades
{
    partial class FrmConfiguracion
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
            this.chkMostrarNumeroderifa = new System.Windows.Forms.CheckBox();
            this.txtMesActual = new Texto.Texto();
            this.lblMesActual = new System.Windows.Forms.Label();
            this.grpReceso = new System.Windows.Forms.GroupBox();
            this.txtDiasReceso = new Texto.Texto();
            this.lblDiasReceso = new System.Windows.Forms.Label();
            this.txtMesesAtrasados = new Texto.Texto();
            this.lblMesesAtrasados = new System.Windows.Forms.Label();
            this.txtComentario3 = new System.Windows.Forms.TextBox();
            this.txtComentario2 = new System.Windows.Forms.TextBox();
            this.txtComentario1 = new System.Windows.Forms.TextBox();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtRutaRespaldo = new System.Windows.Forms.TextBox();
            this.lblRutaRespaldo = new System.Windows.Forms.Label();
            this.txtMoraCreditos = new Texto.Texto();
            this.lblPorcentajeMora = new System.Windows.Forms.Label();
            this.txtValorCuotaadultomayor = new Texto.Texto();
            this.lblMontoCuotaAdultoMayor = new System.Windows.Forms.Label();
            this.txtMontointeresdiario = new Texto.Texto();
            this.lblMontoRetencion = new System.Windows.Forms.Label();
            this.txtPorcentajeRetencion = new Texto.Texto();
            this.lblPorcentajeRetencion = new System.Windows.Forms.Label();
            this.chkTasadeUsura = new System.Windows.Forms.CheckBox();
            this.chkCargarTodos = new System.Windows.Forms.CheckBox();
            this.lblAñoActual = new System.Windows.Forms.Label();
            this.txtAño = new Texto.Texto();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpReceso.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 28);
            this.panel1.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(599, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CONFIGURACION";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtAño);
            this.panel2.Controls.Add(this.lblAñoActual);
            this.panel2.Controls.Add(this.chkMostrarNumeroderifa);
            this.panel2.Controls.Add(this.txtMesActual);
            this.panel2.Controls.Add(this.lblMesActual);
            this.panel2.Controls.Add(this.grpReceso);
            this.panel2.Controls.Add(this.txtComentario3);
            this.panel2.Controls.Add(this.txtComentario2);
            this.panel2.Controls.Add(this.txtComentario1);
            this.panel2.Controls.Add(this.lblComentarios);
            this.panel2.Controls.Add(this.btnActualizar);
            this.panel2.Controls.Add(this.txtRutaRespaldo);
            this.panel2.Controls.Add(this.lblRutaRespaldo);
            this.panel2.Controls.Add(this.txtMoraCreditos);
            this.panel2.Controls.Add(this.lblPorcentajeMora);
            this.panel2.Controls.Add(this.txtValorCuotaadultomayor);
            this.panel2.Controls.Add(this.lblMontoCuotaAdultoMayor);
            this.panel2.Controls.Add(this.txtMontointeresdiario);
            this.panel2.Controls.Add(this.lblMontoRetencion);
            this.panel2.Controls.Add(this.txtPorcentajeRetencion);
            this.panel2.Controls.Add(this.lblPorcentajeRetencion);
            this.panel2.Controls.Add(this.chkTasadeUsura);
            this.panel2.Controls.Add(this.chkCargarTodos);
            this.panel2.Location = new System.Drawing.Point(4, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 298);
            this.panel2.TabIndex = 2;
            // 
            // chkMostrarNumeroderifa
            // 
            this.chkMostrarNumeroderifa.AutoSize = true;
            this.chkMostrarNumeroderifa.Location = new System.Drawing.Point(222, 107);
            this.chkMostrarNumeroderifa.Name = "chkMostrarNumeroderifa";
            this.chkMostrarNumeroderifa.Size = new System.Drawing.Size(157, 20);
            this.chkMostrarNumeroderifa.TabIndex = 7;
            this.chkMostrarNumeroderifa.Text = "Mostrar número de rifa";
            this.chkMostrarNumeroderifa.UseVisualStyleBackColor = true;
            // 
            // txtMesActual
            // 
            this.txtMesActual.Location = new System.Drawing.Point(416, 130);
            this.txtMesActual.Name = "txtMesActual";
            this.txtMesActual.Size = new System.Drawing.Size(56, 22);
            this.txtMesActual.TabIndex = 9;
            this.txtMesActual.Text = "0";
            this.txtMesActual.Tipo = Texto.Texto.Opciones.Decimal;
            // 
            // lblMesActual
            // 
            this.lblMesActual.AutoSize = true;
            this.lblMesActual.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesActual.Location = new System.Drawing.Point(341, 133);
            this.lblMesActual.Name = "lblMesActual";
            this.lblMesActual.Size = new System.Drawing.Size(73, 16);
            this.lblMesActual.TabIndex = 20;
            this.lblMesActual.Text = "Mes Actual";
            // 
            // grpReceso
            // 
            this.grpReceso.Controls.Add(this.txtDiasReceso);
            this.grpReceso.Controls.Add(this.lblDiasReceso);
            this.grpReceso.Controls.Add(this.txtMesesAtrasados);
            this.grpReceso.Controls.Add(this.lblMesesAtrasados);
            this.grpReceso.Location = new System.Drawing.Point(8, 3);
            this.grpReceso.Name = "grpReceso";
            this.grpReceso.Size = new System.Drawing.Size(583, 47);
            this.grpReceso.TabIndex = 19;
            this.grpReceso.TabStop = false;
            this.grpReceso.Text = "Receso";
            // 
            // txtDiasReceso
            // 
            this.txtDiasReceso.Location = new System.Drawing.Point(262, 16);
            this.txtDiasReceso.Name = "txtDiasReceso";
            this.txtDiasReceso.Size = new System.Drawing.Size(32, 22);
            this.txtDiasReceso.TabIndex = 1;
            this.txtDiasReceso.Text = "0";
            this.txtDiasReceso.Tipo = Texto.Texto.Opciones.Numerico;
            // 
            // lblDiasReceso
            // 
            this.lblDiasReceso.AutoSize = true;
            this.lblDiasReceso.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasReceso.Location = new System.Drawing.Point(159, 18);
            this.lblDiasReceso.Name = "lblDiasReceso";
            this.lblDiasReceso.Size = new System.Drawing.Size(100, 16);
            this.lblDiasReceso.TabIndex = 6;
            this.lblDiasReceso.Text = "Días de Receso";
            // 
            // txtMesesAtrasados
            // 
            this.txtMesesAtrasados.Location = new System.Drawing.Point(120, 16);
            this.txtMesesAtrasados.Name = "txtMesesAtrasados";
            this.txtMesesAtrasados.Size = new System.Drawing.Size(32, 22);
            this.txtMesesAtrasados.TabIndex = 0;
            this.txtMesesAtrasados.Text = "0";
            this.txtMesesAtrasados.Tipo = Texto.Texto.Opciones.Numerico;
            // 
            // lblMesesAtrasados
            // 
            this.lblMesesAtrasados.AutoSize = true;
            this.lblMesesAtrasados.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesesAtrasados.Location = new System.Drawing.Point(10, 18);
            this.lblMesesAtrasados.Name = "lblMesesAtrasados";
            this.lblMesesAtrasados.Size = new System.Drawing.Size(108, 16);
            this.lblMesesAtrasados.TabIndex = 4;
            this.lblMesesAtrasados.Text = "Meses atrasados";
            // 
            // txtComentario3
            // 
            this.txtComentario3.Location = new System.Drawing.Point(8, 267);
            this.txtComentario3.Name = "txtComentario3";
            this.txtComentario3.Size = new System.Drawing.Size(495, 22);
            this.txtComentario3.TabIndex = 14;
            // 
            // txtComentario2
            // 
            this.txtComentario2.Location = new System.Drawing.Point(8, 235);
            this.txtComentario2.Name = "txtComentario2";
            this.txtComentario2.Size = new System.Drawing.Size(495, 22);
            this.txtComentario2.TabIndex = 13;
            // 
            // txtComentario1
            // 
            this.txtComentario1.Location = new System.Drawing.Point(8, 203);
            this.txtComentario1.Name = "txtComentario1";
            this.txtComentario1.Size = new System.Drawing.Size(495, 22);
            this.txtComentario1.TabIndex = 12;
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentarios.Location = new System.Drawing.Point(8, 181);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(81, 16);
            this.lblComentarios.TabIndex = 15;
            this.lblComentarios.Text = "Comentarios";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(514, 267);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtRutaRespaldo
            // 
            this.txtRutaRespaldo.Location = new System.Drawing.Point(107, 133);
            this.txtRutaRespaldo.Name = "txtRutaRespaldo";
            this.txtRutaRespaldo.Size = new System.Drawing.Size(226, 22);
            this.txtRutaRespaldo.TabIndex = 8;
            // 
            // lblRutaRespaldo
            // 
            this.lblRutaRespaldo.AutoSize = true;
            this.lblRutaRespaldo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutaRespaldo.Location = new System.Drawing.Point(11, 133);
            this.lblRutaRespaldo.Name = "lblRutaRespaldo";
            this.lblRutaRespaldo.Size = new System.Drawing.Size(93, 16);
            this.lblRutaRespaldo.TabIndex = 12;
            this.lblRutaRespaldo.Text = "Ruta Respaldo";
            // 
            // txtMoraCreditos
            // 
            this.txtMoraCreditos.Location = new System.Drawing.Point(256, 157);
            this.txtMoraCreditos.Name = "txtMoraCreditos";
            this.txtMoraCreditos.Size = new System.Drawing.Size(56, 22);
            this.txtMoraCreditos.TabIndex = 11;
            this.txtMoraCreditos.Text = "0";
            this.txtMoraCreditos.Tipo = Texto.Texto.Opciones.Decimal;
            // 
            // lblPorcentajeMora
            // 
            this.lblPorcentajeMora.AutoSize = true;
            this.lblPorcentajeMora.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeMora.Location = new System.Drawing.Point(8, 157);
            this.lblPorcentajeMora.Name = "lblPorcentajeMora";
            this.lblPorcentajeMora.Size = new System.Drawing.Size(250, 16);
            this.lblPorcentajeMora.TabIndex = 10;
            this.lblPorcentajeMora.Text = "Porcentaje de mora de créditos atrasados";
            // 
            // txtValorCuotaadultomayor
            // 
            this.txtValorCuotaadultomayor.Location = new System.Drawing.Point(478, 54);
            this.txtValorCuotaadultomayor.Name = "txtValorCuotaadultomayor";
            this.txtValorCuotaadultomayor.Size = new System.Drawing.Size(64, 22);
            this.txtValorCuotaadultomayor.TabIndex = 4;
            this.txtValorCuotaadultomayor.Text = "0";
            this.txtValorCuotaadultomayor.Tipo = Texto.Texto.Opciones.Numerico;
            // 
            // lblMontoCuotaAdultoMayor
            // 
            this.lblMontoCuotaAdultoMayor.AutoSize = true;
            this.lblMontoCuotaAdultoMayor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoCuotaAdultoMayor.Location = new System.Drawing.Point(302, 56);
            this.lblMontoCuotaAdultoMayor.Name = "lblMontoCuotaAdultoMayor";
            this.lblMontoCuotaAdultoMayor.Size = new System.Drawing.Size(170, 16);
            this.lblMontoCuotaAdultoMayor.TabIndex = 8;
            this.lblMontoCuotaAdultoMayor.Text = "Valor cuota de adulto mayor";
            // 
            // txtMontointeresdiario
            // 
            this.txtMontointeresdiario.Location = new System.Drawing.Point(362, 82);
            this.txtMontointeresdiario.Name = "txtMontointeresdiario";
            this.txtMontointeresdiario.Size = new System.Drawing.Size(96, 22);
            this.txtMontointeresdiario.TabIndex = 5;
            this.txtMontointeresdiario.Text = "0";
            this.txtMontointeresdiario.Tipo = Texto.Texto.Opciones.Decimal;
            // 
            // lblMontoRetencion
            // 
            this.lblMontoRetencion.AutoSize = true;
            this.lblMontoRetencion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoRetencion.Location = new System.Drawing.Point(8, 82);
            this.lblMontoRetencion.Name = "lblMontoRetencion";
            this.lblMontoRetencion.Size = new System.Drawing.Size(348, 16);
            this.lblMontoRetencion.TabIndex = 6;
            this.lblMontoRetencion.Text = "Monto de interes diario a partir de cual se genera retención";
            // 
            // txtPorcentajeRetencion
            // 
            this.txtPorcentajeRetencion.Location = new System.Drawing.Point(160, 105);
            this.txtPorcentajeRetencion.Name = "txtPorcentajeRetencion";
            this.txtPorcentajeRetencion.Size = new System.Drawing.Size(56, 22);
            this.txtPorcentajeRetencion.TabIndex = 6;
            this.txtPorcentajeRetencion.Text = "0";
            this.txtPorcentajeRetencion.Tipo = Texto.Texto.Opciones.Decimal;
            // 
            // lblPorcentajeRetencion
            // 
            this.lblPorcentajeRetencion.AutoSize = true;
            this.lblPorcentajeRetencion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeRetencion.Location = new System.Drawing.Point(8, 107);
            this.lblPorcentajeRetencion.Name = "lblPorcentajeRetencion";
            this.lblPorcentajeRetencion.Size = new System.Drawing.Size(145, 16);
            this.lblPorcentajeRetencion.TabIndex = 4;
            this.lblPorcentajeRetencion.Text = "Porcentaje de retención";
            // 
            // chkTasadeUsura
            // 
            this.chkTasadeUsura.AutoSize = true;
            this.chkTasadeUsura.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTasadeUsura.Location = new System.Drawing.Point(187, 56);
            this.chkTasadeUsura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkTasadeUsura.Name = "chkTasadeUsura";
            this.chkTasadeUsura.Size = new System.Drawing.Size(108, 20);
            this.chkTasadeUsura.TabIndex = 3;
            this.chkTasadeUsura.Text = "Tasa de usura";
            this.chkTasadeUsura.UseVisualStyleBackColor = true;
            // 
            // chkCargarTodos
            // 
            this.chkCargarTodos.AutoSize = true;
            this.chkCargarTodos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCargarTodos.Location = new System.Drawing.Point(9, 56);
            this.chkCargarTodos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkCargarTodos.Name = "chkCargarTodos";
            this.chkCargarTodos.Size = new System.Drawing.Size(176, 20);
            this.chkCargarTodos.TabIndex = 2;
            this.chkCargarTodos.Text = "Cargar todos los servicios";
            this.chkCargarTodos.UseVisualStyleBackColor = true;
            // 
            // lblAñoActual
            // 
            this.lblAñoActual.AutoSize = true;
            this.lblAñoActual.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAñoActual.Location = new System.Drawing.Point(475, 133);
            this.lblAñoActual.Name = "lblAñoActual";
            this.lblAñoActual.Size = new System.Drawing.Size(31, 16);
            this.lblAñoActual.TabIndex = 21;
            this.lblAñoActual.Text = "Año";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(508, 130);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(56, 22);
            this.txtAño.TabIndex = 10;
            this.txtAño.Text = "0";
            this.txtAño.Tipo = Texto.Texto.Opciones.Decimal;
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 343);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.FrmConfiguracion_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpReceso.ResumeLayout(false);
            this.grpReceso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkTasadeUsura;
        private System.Windows.Forms.CheckBox chkCargarTodos;
        private Texto.Texto txtValorCuotaadultomayor;
        private System.Windows.Forms.Label lblMontoCuotaAdultoMayor;
        private Texto.Texto txtMontointeresdiario;
        private System.Windows.Forms.Label lblMontoRetencion;
        private Texto.Texto txtPorcentajeRetencion;
        private System.Windows.Forms.Label lblPorcentajeRetencion;
        private Texto.Texto txtMoraCreditos;
        private System.Windows.Forms.Label lblPorcentajeMora;
        private System.Windows.Forms.TextBox txtRutaRespaldo;
        private System.Windows.Forms.Label lblRutaRespaldo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtComentario3;
        private System.Windows.Forms.TextBox txtComentario2;
        private System.Windows.Forms.TextBox txtComentario1;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.GroupBox grpReceso;
        private System.Windows.Forms.Label lblDiasReceso;
        private Texto.Texto txtMesesAtrasados;
        private System.Windows.Forms.Label lblMesesAtrasados;
        private Texto.Texto txtDiasReceso;
        private Texto.Texto txtMesActual;
        private System.Windows.Forms.Label lblMesActual;
        private System.Windows.Forms.CheckBox chkMostrarNumeroderifa;
        private Texto.Texto txtAño;
        private System.Windows.Forms.Label lblAñoActual;
    }
}