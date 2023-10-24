namespace ClickTix.UserControls
{
    partial class ABM_FUNCION_UC
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
            this.add_funcion = new System.Windows.Forms.Button();
            this.grid_funciones = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dimension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_funciones)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Roboto Bk", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(219, 18);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(119, 24);
            this.title.TabIndex = 13;
            this.title.Text = "FUNCIONES";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // add_funcion
            // 
            this.add_funcion.Location = new System.Drawing.Point(439, 18);
            this.add_funcion.Name = "add_funcion";
            this.add_funcion.Size = new System.Drawing.Size(108, 25);
            this.add_funcion.TabIndex = 12;
            this.add_funcion.Text = "Agregar";
            this.add_funcion.UseVisualStyleBackColor = true;
            this.add_funcion.Click += new System.EventHandler(this.add_funcion_Click);
            // 
            // grid_funciones
            // 
            this.grid_funciones.AllowUserToAddRows = false;
            this.grid_funciones.AllowUserToDeleteRows = false;
            this.grid_funciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_funciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Pelicula,
            this.Fecha,
            this.Horario,
            this.Sala,
            this.Idioma,
            this.Dimension,
            this.Sucursal,
            this.Modificar,
            this.Borrar});
            this.grid_funciones.Location = new System.Drawing.Point(23, 52);
            this.grid_funciones.Name = "grid_funciones";
            this.grid_funciones.ReadOnly = true;
            this.grid_funciones.Size = new System.Drawing.Size(524, 303);
            this.grid_funciones.TabIndex = 11;
            this.grid_funciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_funciones_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Pelicula
            // 
            this.Pelicula.HeaderText = "Pelicula";
            this.Pelicula.Name = "Pelicula";
            this.Pelicula.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Horario
            // 
            this.Horario.HeaderText = "Horario";
            this.Horario.Name = "Horario";
            this.Horario.ReadOnly = true;
            // 
            // Sala
            // 
            this.Sala.HeaderText = "Numero de Sala";
            this.Sala.Name = "Sala";
            this.Sala.ReadOnly = true;
            // 
            // Idioma
            // 
            this.Idioma.HeaderText = "Idioma";
            this.Idioma.Name = "Idioma";
            this.Idioma.ReadOnly = true;
            // 
            // Dimension
            // 
            this.Dimension.HeaderText = "Dimension";
            this.Dimension.Name = "Dimension";
            this.Dimension.ReadOnly = true;
            // 
            // Sucursal
            // 
            this.Sucursal.HeaderText = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.ReadOnly = true;
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Width = 50;
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            this.Borrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Borrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Borrar.Width = 50;
            // 
            // ABM_FUNCION_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.title);
            this.Controls.Add(this.add_funcion);
            this.Controls.Add(this.grid_funciones);
            this.Name = "ABM_FUNCION_UC";
            this.Size = new System.Drawing.Size(570, 373);
            ((System.ComponentModel.ISupportInitialize)(this.grid_funciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button add_funcion;
        private System.Windows.Forms.DataGridView grid_funciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idioma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dimension;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
    }
}
