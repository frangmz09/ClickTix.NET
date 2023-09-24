namespace ClickTix.Admin.UserControls.Formularios
{
    partial class FORM_PRECIODIMENSION_UC
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
            this.back_dimension = new System.Windows.Forms.Button();
            this.adddimension_btn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.label_precio = new System.Windows.Forms.Label();
            this.input_direccion = new System.Windows.Forms.TextBox();
            this.label_nombre = new System.Windows.Forms.Label();
            this.input_nombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // back_dimension
            // 
            this.back_dimension.Location = new System.Drawing.Point(26, 30);
            this.back_dimension.Name = "back_dimension";
            this.back_dimension.Size = new System.Drawing.Size(30, 30);
            this.back_dimension.TabIndex = 86;
            this.back_dimension.Text = "<";
            this.back_dimension.UseVisualStyleBackColor = true;
            this.back_dimension.Click += new System.EventHandler(this.back_dimension_Click);
            // 
            // adddimension_btn
            // 
            this.adddimension_btn.Location = new System.Drawing.Point(219, 241);
            this.adddimension_btn.Name = "adddimension_btn";
            this.adddimension_btn.Size = new System.Drawing.Size(111, 25);
            this.adddimension_btn.TabIndex = 83;
            this.adddimension_btn.Text = "Agregar";
            this.adddimension_btn.UseVisualStyleBackColor = true;
            this.adddimension_btn.Click += new System.EventHandler(this.addempleado_btn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Roboto Bk", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(46, 63);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(491, 24);
            this.title.TabIndex = 78;
            this.title.Text = "INGRESE DATOS PARA AGREGAR NUEVA DIMENSION";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_precio
            // 
            this.label_precio.AutoSize = true;
            this.label_precio.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_precio.Location = new System.Drawing.Point(139, 170);
            this.label_precio.Name = "label_precio";
            this.label_precio.Size = new System.Drawing.Size(37, 14);
            this.label_precio.TabIndex = 77;
            this.label_precio.Text = "Precio";
            this.label_precio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_direccion
            // 
            this.input_direccion.Location = new System.Drawing.Point(142, 187);
            this.input_direccion.Name = "input_direccion";
            this.input_direccion.Size = new System.Drawing.Size(268, 20);
            this.input_direccion.TabIndex = 76;
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.Location = new System.Drawing.Point(139, 126);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(44, 14);
            this.label_nombre.TabIndex = 75;
            this.label_nombre.Text = "Nombre";
            this.label_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_nombre
            // 
            this.input_nombre.Location = new System.Drawing.Point(142, 143);
            this.input_nombre.Name = "input_nombre";
            this.input_nombre.Size = new System.Drawing.Size(268, 20);
            this.input_nombre.TabIndex = 74;
            // 
            // FORM_PRECIODIMENSION_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.back_dimension);
            this.Controls.Add(this.adddimension_btn);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label_precio);
            this.Controls.Add(this.input_direccion);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.input_nombre);
            this.Name = "FORM_PRECIODIMENSION_UC";
            this.Size = new System.Drawing.Size(560, 373);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_dimension;
        private System.Windows.Forms.Button adddimension_btn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label_precio;
        private System.Windows.Forms.TextBox input_direccion;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.TextBox input_nombre;
    }
}
