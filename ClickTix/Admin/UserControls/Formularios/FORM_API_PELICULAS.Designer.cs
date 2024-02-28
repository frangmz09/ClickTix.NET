namespace ClickTix.Admin.UserControls.Formularios
{
    partial class FORM_API_PELICULAS
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
            this.label1 = new System.Windows.Forms.Label();
            this.search_films = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.grid_peliculas = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeEstreno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.loadingText = new System.Windows.Forms.Label();
            this.back_pelicula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_peliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Buscar peliculas:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // search_films
            // 
            this.search_films.Location = new System.Drawing.Point(108, 28);
            this.search_films.Name = "search_films";
            this.search_films.Size = new System.Drawing.Size(157, 20);
            this.search_films.TabIndex = 13;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(402, 23);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(131, 25);
            this.title.TabIndex = 12;
            this.title.Text = "PELICULAS";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grid_peliculas
            // 
            this.grid_peliculas.AllowUserToAddRows = false;
            this.grid_peliculas.AllowUserToDeleteRows = false;
            this.grid_peliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_peliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.FechaDeEstreno,
            this.imagen,
            this.descripcion,
            this.Seleccionar});
            this.grid_peliculas.Location = new System.Drawing.Point(20, 57);
            this.grid_peliculas.Name = "grid_peliculas";
            this.grid_peliculas.ReadOnly = true;
            this.grid_peliculas.Size = new System.Drawing.Size(524, 303);
            this.grid_peliculas.TabIndex = 10;
            // 
            // Titulo
            // 
            this.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // FechaDeEstreno
            // 
            this.FechaDeEstreno.HeaderText = "Fecha de Estreno";
            this.FechaDeEstreno.Name = "FechaDeEstreno";
            this.FechaDeEstreno.ReadOnly = true;
            // 
            // imagen
            // 
            this.imagen.HeaderText = "imagen";
            this.imagen.Name = "imagen";
            this.imagen.ReadOnly = true;
            this.imagen.Visible = false;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Visible = false;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Seleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Seleccionar.Text = "Seleccionar";
            this.Seleccionar.Width = 75;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 20);
            this.button1.TabIndex = 15;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loadingText
            // 
            this.loadingText.AutoSize = true;
            this.loadingText.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.loadingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingText.Location = new System.Drawing.Point(224, 137);
            this.loadingText.Name = "loadingText";
            this.loadingText.Size = new System.Drawing.Size(125, 25);
            this.loadingText.TabIndex = 16;
            this.loadingText.Text = "Cargando...";
            this.loadingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loadingText.Visible = false;
            // 
            // back_pelicula
            // 
            this.back_pelicula.Location = new System.Drawing.Point(20, 18);
            this.back_pelicula.Name = "back_pelicula";
            this.back_pelicula.Size = new System.Drawing.Size(30, 30);
            this.back_pelicula.TabIndex = 67;
            this.back_pelicula.Text = "<";
            this.back_pelicula.UseVisualStyleBackColor = true;
            this.back_pelicula.Click += new System.EventHandler(this.back_pelicula_Click);
            // 
            // FORM_API_PELICULAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.back_pelicula);
            this.Controls.Add(this.loadingText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_films);
            this.Controls.Add(this.title);
            this.Controls.Add(this.grid_peliculas);
            this.Name = "FORM_API_PELICULAS";
            this.Size = new System.Drawing.Size(560, 373);
            ((System.ComponentModel.ISupportInitialize)(this.grid_peliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_films;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridView grid_peliculas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label loadingText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeEstreno;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.Button back_pelicula;
    }
}
