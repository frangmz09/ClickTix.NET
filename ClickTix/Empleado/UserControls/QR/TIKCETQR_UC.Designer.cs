namespace ClickTix.Empleado.UserControls
{
    partial class TIKCETQR_UC
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
            this.imprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imprimir
            // 
            this.imprimir.Font = new System.Drawing.Font("Roboto Bk", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprimir.Location = new System.Drawing.Point(261, 380);
            this.imprimir.Name = "imprimir";
            this.imprimir.Size = new System.Drawing.Size(279, 49);
            this.imprimir.TabIndex = 8;
            this.imprimir.Text = "Imprimir Ticket";
            this.imprimir.UseVisualStyleBackColor = true;
            // 
            // TIKCETQR_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imprimir);
            this.Name = "TIKCETQR_UC";
            this.Size = new System.Drawing.Size(800, 451);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button imprimir;
    }
}
