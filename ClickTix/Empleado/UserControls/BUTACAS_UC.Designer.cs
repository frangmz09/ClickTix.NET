namespace ClickTix.Empleado.UserControls
{
    partial class BUTACAS_UC
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.confirmar_asiento = new System.Windows.Forms.Button();
            this.back_pelicula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(77, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(796, 495);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // confirmar_asiento
            // 
            this.confirmar_asiento.Location = new System.Drawing.Point(394, 3);
            this.confirmar_asiento.Name = "confirmar_asiento";
            this.confirmar_asiento.Size = new System.Drawing.Size(168, 36);
            this.confirmar_asiento.TabIndex = 1;
            this.confirmar_asiento.Text = "Confirmar Asientos";
            this.confirmar_asiento.UseVisualStyleBackColor = true;
            this.confirmar_asiento.Click += new System.EventHandler(this.confirmar_asiento_Click);
            // 
            // back_pelicula
            // 
            this.back_pelicula.Location = new System.Drawing.Point(29, 20);
            this.back_pelicula.Name = "back_pelicula";
            this.back_pelicula.Size = new System.Drawing.Size(30, 30);
            this.back_pelicula.TabIndex = 76;
            this.back_pelicula.Text = "<";
            this.back_pelicula.UseVisualStyleBackColor = true;
            this.back_pelicula.Click += new System.EventHandler(this.back_pelicula_Click);
            // 
            // BUTACAS_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.back_pelicula);
            this.Controls.Add(this.confirmar_asiento);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "BUTACAS_UC";
            this.Size = new System.Drawing.Size(920, 663);
            this.Load += new System.EventHandler(this.BUTACAS_UC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button confirmar_asiento;
        private System.Windows.Forms.Button back_pelicula;
    }
}
