using System;

namespace ClickTix.UserControls
{
    partial class ABM_PELICULAS_UC
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
            this.add_pelicula = new System.Windows.Forms.Button();
            this.grid_peliculas = new System.Windows.Forms.DataGridView();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_peliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(219, 18);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(122, 25);
            this.title.TabIndex = 7;
            this.title.Text = "PELICULAS";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_pelicula
            // 
            this.add_pelicula.Location = new System.Drawing.Point(439, 18);
            this.add_pelicula.Name = "add_pelicula";
            this.add_pelicula.Size = new System.Drawing.Size(108, 25);
            this.add_pelicula.TabIndex = 6;
            this.add_pelicula.Text = "Agregar";
            this.add_pelicula.UseVisualStyleBackColor = true;
            this.add_pelicula.Click += new System.EventHandler(this.add_pelicula_Click);
            // 
            // grid_peliculas
            // 
            this.grid_peliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_peliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar,
            this.Borrar});
            this.grid_peliculas.Location = new System.Drawing.Point(23, 49);
            this.grid_peliculas.Name = "grid_peliculas";
            this.grid_peliculas.Size = new System.Drawing.Size(524, 303);
            this.grid_peliculas.TabIndex = 5;
            this.grid_peliculas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_peliculas_CellContentClick);
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            this.Modificar.Text = "MODIFICAR";
            this.Modificar.Width = 75;
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Name = "Borrar";
            this.Borrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Borrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Borrar.Text = "BORRAR";
            this.Borrar.Width = 75;
            // 
            // ABM_PELICULAS_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.title);
            this.Controls.Add(this.add_pelicula);
            this.Controls.Add(this.grid_peliculas);
            this.Name = "ABM_PELICULAS_UC";
            this.Size = new System.Drawing.Size(570, 373);
            this.Load += new System.EventHandler(this.ABM_PELICULAS_UC_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.grid_peliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button add_pelicula;
        private System.Windows.Forms.DataGridView grid_peliculas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Director;
        private System.Windows.Forms.DataGridViewTextBoxColumn emision;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;

       
}
}
