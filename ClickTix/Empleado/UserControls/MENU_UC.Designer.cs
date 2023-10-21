namespace ClickTix.Empleado.UserControls
{
    partial class MENU_UC
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
            this.retirar = new System.Windows.Forms.Button();
            this.comprar = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // retirar
            // 
            this.retirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retirar.Location = new System.Drawing.Point(279, 228);
            this.retirar.Name = "retirar";
            this.retirar.Size = new System.Drawing.Size(242, 83);
            this.retirar.TabIndex = 7;
            this.retirar.Text = "RETIRAR";
            this.retirar.UseVisualStyleBackColor = true;
            this.retirar.Click += new System.EventHandler(this.retirar_Click);
            // 
            // comprar
            // 
            this.comprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprar.Location = new System.Drawing.Point(279, 139);
            this.comprar.Name = "comprar";
            this.comprar.Size = new System.Drawing.Size(242, 83);
            this.comprar.TabIndex = 6;
            this.comprar.Text = "COMPRAR";
            this.comprar.UseVisualStyleBackColor = true;
            this.comprar.Click += new System.EventHandler(this.comprar_Click);
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(664, 3);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(133, 41);
            this.LogOut.TabIndex = 8;
            this.LogOut.Text = "Cerrar Sesion";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // MENU_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.retirar);
            this.Controls.Add(this.comprar);
            this.Name = "MENU_UC";
            this.Size = new System.Drawing.Size(800, 451);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button retirar;
        private System.Windows.Forms.Button comprar;
        private System.Windows.Forms.Button LogOut;
    }
}
