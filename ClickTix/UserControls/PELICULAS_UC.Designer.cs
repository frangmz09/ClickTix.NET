namespace ClickTix.UserControls
{
    partial class PELICULAS_UC
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
            this.addpelicula_btn = new System.Windows.Forms.Button();
            this.input_titulo = new System.Windows.Forms.TextBox();
            this.input_descripcion = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.input_director = new System.Windows.Forms.TextBox();
            this.input_genero = new System.Windows.Forms.ComboBox();
            this.input_duracion = new System.Windows.Forms.NumericUpDown();
            this.input_clasificacion = new System.Windows.Forms.ComboBox();
            this.input_estreno = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_titulo = new System.Windows.Forms.Label();
            this.label_director = new System.Windows.Forms.Label();
            this.label_duracion = new System.Windows.Forms.Label();
            this.label_categoria = new System.Windows.Forms.Label();
            this.label_clasificacion = new System.Windows.Forms.Label();
            this.label_estreno = new System.Windows.Forms.Label();
            this.label_descripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.input_duracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Roboto Bk", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(63, 38);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(452, 24);
            this.title.TabIndex = 2;
            this.title.Text = "INGRESE DATOS PARA AGREGAR UNA PELICULA";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addpelicula_btn
            // 
            this.addpelicula_btn.Location = new System.Drawing.Point(222, 312);
            this.addpelicula_btn.Name = "addpelicula_btn";
            this.addpelicula_btn.Size = new System.Drawing.Size(111, 25);
            this.addpelicula_btn.TabIndex = 46;
            this.addpelicula_btn.Text = "Agregar";
            this.addpelicula_btn.UseVisualStyleBackColor = true;
            this.addpelicula_btn.Click += new System.EventHandler(this.addpelicula_btn_Click);
            // 
            // input_titulo
            // 
            this.input_titulo.Location = new System.Drawing.Point(222, 108);
            this.input_titulo.Name = "input_titulo";
            this.input_titulo.Size = new System.Drawing.Size(268, 20);
            this.input_titulo.TabIndex = 47;
            // 
            // input_descripcion
            // 
            this.input_descripcion.Location = new System.Drawing.Point(223, 274);
            this.input_descripcion.Name = "input_descripcion";
            this.input_descripcion.Size = new System.Drawing.Size(268, 20);
            this.input_descripcion.TabIndex = 48;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(376, 248);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(0, 20);
            this.textBox3.TabIndex = 49;
            // 
            // input_director
            // 
            this.input_director.Location = new System.Drawing.Point(222, 146);
            this.input_director.Name = "input_director";
            this.input_director.Size = new System.Drawing.Size(86, 20);
            this.input_director.TabIndex = 50;
            // 
            // input_genero
            // 
            this.input_genero.FormattingEnabled = true;
            this.input_genero.Location = new System.Drawing.Point(282, 187);
            this.input_genero.Name = "input_genero";
            this.input_genero.Size = new System.Drawing.Size(71, 21);
            this.input_genero.TabIndex = 51;
            this.input_genero.SelectedIndexChanged += new System.EventHandler(this.input_genero_SelectedIndexChanged);
            // 
            // input_duracion
            // 
            this.input_duracion.Location = new System.Drawing.Point(222, 187);
            this.input_duracion.Name = "input_duracion";
            this.input_duracion.Size = new System.Drawing.Size(45, 20);
            this.input_duracion.TabIndex = 52;
            // 
            // input_clasificacion
            // 
            this.input_clasificacion.FormattingEnabled = true;
            this.input_clasificacion.Location = new System.Drawing.Point(359, 187);
            this.input_clasificacion.Name = "input_clasificacion";
            this.input_clasificacion.Size = new System.Drawing.Size(71, 21);
            this.input_clasificacion.TabIndex = 53;
            // 
            // input_estreno
            // 
            this.input_estreno.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_estreno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.input_estreno.Location = new System.Drawing.Point(222, 235);
            this.input_estreno.Name = "input_estreno";
            this.input_estreno.Size = new System.Drawing.Size(86, 21);
            this.input_estreno.TabIndex = 54;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(55, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 204);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(219, 91);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(35, 14);
            this.label_titulo.TabIndex = 56;
            this.label_titulo.Text = "Titulo";
            this.label_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_director
            // 
            this.label_director.AutoSize = true;
            this.label_director.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_director.Location = new System.Drawing.Point(220, 131);
            this.label_director.Name = "label_director";
            this.label_director.Size = new System.Drawing.Size(45, 14);
            this.label_director.TabIndex = 57;
            this.label_director.Text = "Director";
            this.label_director.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_duracion
            // 
            this.label_duracion.AutoSize = true;
            this.label_duracion.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_duracion.Location = new System.Drawing.Point(220, 170);
            this.label_duracion.Name = "label_duracion";
            this.label_duracion.Size = new System.Drawing.Size(50, 14);
            this.label_duracion.TabIndex = 58;
            this.label_duracion.Text = "Duracion";
            this.label_duracion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_categoria
            // 
            this.label_categoria.AutoSize = true;
            this.label_categoria.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_categoria.Location = new System.Drawing.Point(283, 170);
            this.label_categoria.Name = "label_categoria";
            this.label_categoria.Size = new System.Drawing.Size(40, 14);
            this.label_categoria.TabIndex = 59;
            this.label_categoria.Text = "Genero";
            this.label_categoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_clasificacion
            // 
            this.label_clasificacion.AutoSize = true;
            this.label_clasificacion.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_clasificacion.Location = new System.Drawing.Point(356, 170);
            this.label_clasificacion.Name = "label_clasificacion";
            this.label_clasificacion.Size = new System.Drawing.Size(69, 14);
            this.label_clasificacion.TabIndex = 60;
            this.label_clasificacion.Text = "Clasificacion";
            this.label_clasificacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_estreno
            // 
            this.label_estreno.AutoSize = true;
            this.label_estreno.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_estreno.Location = new System.Drawing.Point(219, 218);
            this.label_estreno.Name = "label_estreno";
            this.label_estreno.Size = new System.Drawing.Size(87, 14);
            this.label_estreno.TabIndex = 61;
            this.label_estreno.Text = "Fecha de estreno";
            this.label_estreno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_descripcion
            // 
            this.label_descripcion.AutoSize = true;
            this.label_descripcion.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_descripcion.Location = new System.Drawing.Point(221, 259);
            this.label_descripcion.Name = "label_descripcion";
            this.label_descripcion.Size = new System.Drawing.Size(62, 14);
            this.label_descripcion.TabIndex = 62;
            this.label_descripcion.Text = "Descripcion";
            this.label_descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PELICULAS_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_descripcion);
            this.Controls.Add(this.label_estreno);
            this.Controls.Add(this.label_clasificacion);
            this.Controls.Add(this.label_categoria);
            this.Controls.Add(this.label_duracion);
            this.Controls.Add(this.label_director);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.input_estreno);
            this.Controls.Add(this.input_clasificacion);
            this.Controls.Add(this.input_duracion);
            this.Controls.Add(this.input_genero);
            this.Controls.Add(this.input_director);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.input_descripcion);
            this.Controls.Add(this.input_titulo);
            this.Controls.Add(this.addpelicula_btn);
            this.Controls.Add(this.title);
            this.Name = "PELICULAS_UC";
            this.Size = new System.Drawing.Size(560, 373);
            this.Load += new System.EventHandler(this.PELICULAS_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.input_duracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button addpelicula_btn;
        private System.Windows.Forms.TextBox input_titulo;
        private System.Windows.Forms.TextBox input_descripcion;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox input_director;
        private System.Windows.Forms.ComboBox input_genero;
        private System.Windows.Forms.NumericUpDown input_duracion;
        private System.Windows.Forms.ComboBox input_clasificacion;
        private System.Windows.Forms.DateTimePicker input_estreno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label_director;
        private System.Windows.Forms.Label label_duracion;
        private System.Windows.Forms.Label label_categoria;
        private System.Windows.Forms.Label label_clasificacion;
        private System.Windows.Forms.Label label_estreno;
        private System.Windows.Forms.Label label_descripcion;
    }
}
