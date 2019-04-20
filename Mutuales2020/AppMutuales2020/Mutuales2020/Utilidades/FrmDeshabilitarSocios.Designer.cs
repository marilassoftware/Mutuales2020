namespace Mutuales2020.Utilidades
{
    partial class FrmDeshabilitarSocios
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
            this.btnDeshabilitarSocio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeshabilitarSocio
            // 
            this.btnDeshabilitarSocio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitarSocio.Location = new System.Drawing.Point(8, 8);
            this.btnDeshabilitarSocio.Name = "btnDeshabilitarSocio";
            this.btnDeshabilitarSocio.Size = new System.Drawing.Size(188, 23);
            this.btnDeshabilitarSocio.TabIndex = 0;
            this.btnDeshabilitarSocio.Text = "DESHABILITAR AFILIADOS";
            this.btnDeshabilitarSocio.UseVisualStyleBackColor = true;
            this.btnDeshabilitarSocio.Click += new System.EventHandler(this.btnDeshabilitarSocio_Click);
            // 
            // FrmDeshabilitarSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 40);
            this.Controls.Add(this.btnDeshabilitarSocio);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDeshabilitarSocios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deshabilitar Afiliados";
            this.Load += new System.EventHandler(this.FrmDeshabilitarSocios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeshabilitarSocio;
    }
}