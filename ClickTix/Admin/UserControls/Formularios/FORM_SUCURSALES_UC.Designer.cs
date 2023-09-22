namespace ClickTix.UserControls
{
    partial class FORM_SUCURSALES_UC
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
            this.title = new System.Windows.Forms.Label();
            this.addsucursal_btn = new System.Windows.Forms.Button();
            this.label_titulo = new System.Windows.Forms.Label();
            this.input_nombre = new System.Windows.Forms.TextBox();
            this.label_direccion = new System.Windows.Forms.Label();
            this.input_direccion = new System.Windows.Forms.TextBox();
            this.label_cuit = new System.Windows.Forms.Label();
            this.input_cuit = new System.Windows.Forms.TextBox();
            this.label_salas = new System.Windows.Forms.Label();
            this.input_salas = new System.Windows.Forms.NumericUpDown();
            this.back_pelicula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.input_salas)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Roboto Bk", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(71, 22);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(416, 24);
            this.title.TabIndex = 3;
            this.title.Text = "INGRESE DATOS PARA AGREGAR SUCURSAL";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // addsucursal_btn
            // 
            this.addsucursal_btn.Location = new System.Drawing.Point(222, 285);
            this.addsucursal_btn.Name = "addsucursal_btn";
            this.addsucursal_btn.Size = new System.Drawing.Size(111, 25);
            this.addsucursal_btn.TabIndex = 33;
            this.addsucursal_btn.Text = "Agregar";
            this.addsucursal_btn.UseVisualStyleBackColor = true;
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(140, 88);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(44, 14);
            this.label_titulo.TabIndex = 58;
            this.label_titulo.Text = "Nombre";
            this.label_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_nombre
            // 
            this.input_nombre.Location = new System.Drawing.Point(143, 105);
            this.input_nombre.Name = "input_nombre";
            this.input_nombre.Size = new System.Drawing.Size(268, 20);
            this.input_nombre.TabIndex = 57;
            // 
            // label_direccion
            // 
            this.label_direccion.AutoSize = true;
            this.label_direccion.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_direccion.Location = new System.Drawing.Point(140, 132);
            this.label_direccion.Name = "label_direccion";
            this.label_direccion.Size = new System.Drawing.Size(51, 14);
            this.label_direccion.TabIndex = 60;
            this.label_direccion.Text = "Direccion";
            this.label_direccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_direccion
            // 
            this.input_direccion.Location = new System.Drawing.Point(143, 149);
            this.input_direccion.Name = "input_direccion";
            this.input_direccion.Size = new System.Drawing.Size(268, 20);
            this.input_direccion.TabIndex = 59;
            // 
            // label_cuit
            // 
            this.label_cuit.AutoSize = true;
            this.label_cuit.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cuit.Location = new System.Drawing.Point(140, 181);
            this.label_cuit.Name = "label_cuit";
            this.label_cuit.Size = new System.Drawing.Size(27, 14);
            this.label_cuit.TabIndex = 62;
            this.label_cuit.Text = "Cuit";
            this.label_cuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_cuit
            // 
            this.input_cuit.Location = new System.Drawing.Point(143, 198);
            this.input_cuit.Name = "input_cuit";
            this.input_cuit.Size = new System.Drawing.Size(268, 20);
            this.input_cuit.TabIndex = 61;
            // 
            // label_salas
            // 
            this.label_salas.AutoSize = true;
            this.label_salas.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_salas.Location = new System.Drawing.Point(205, 238);
            this.label_salas.Name = "label_salas";
            this.label_salas.Size = new System.Drawing.Size(86, 14);
            this.label_salas.TabIndex = 64;
            this.label_salas.Text = "Numero de salas";
            this.label_salas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_salas
            // 
            this.input_salas.Location = new System.Drawing.Point(297, 236);
            this.input_salas.Name = "input_salas";
            this.input_salas.Size = new System.Drawing.Size(45, 20);
            this.input_salas.TabIndex = 65;
            // 
            // back_pelicula
            // 
            this.back_pelicula.Location = new System.Drawing.Point(17, 16);
            this.back_pelicula.Name = "back_pelicula";
            this.back_pelicula.Size = new System.Drawing.Size(30, 30);
            this.back_pelicula.TabIndex = 66;
            this.back_pelicula.Text = "<";
            this.back_pelicula.UseVisualStyleBackColor = true;
            this.back_pelicula.Click += new System.EventHandler(this.back_pelicula_Click);
            // 
            // FORMSUCURSALES_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.back_pelicula);
            this.Controls.Add(this.input_salas);
            this.Controls.Add(this.label_salas);
            this.Controls.Add(this.label_cuit);
            this.Controls.Add(this.input_cuit);
            this.Controls.Add(this.label_direccion);
            this.Controls.Add(this.input_direccion);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.input_nombre);
            this.Controls.Add(this.addsucursal_btn);
            this.Controls.Add(this.title);
            this.Name = "FORMSUCURSALES_UC";
            this.Size = new System.Drawing.Size(560, 373);
            ((System.ComponentModel.ISupportInitialize)(this.input_salas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button addsucursal_btn;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.TextBox input_nombre;
        private System.Windows.Forms.Label label_direccion;
        private System.Windows.Forms.TextBox input_direccion;
        private System.Windows.Forms.Label label_cuit;
        private System.Windows.Forms.TextBox input_cuit;
        private System.Windows.Forms.Label label_salas;
        private System.Windows.Forms.NumericUpDown input_salas;
        private System.Windows.Forms.Button back_pelicula;
    }
}
