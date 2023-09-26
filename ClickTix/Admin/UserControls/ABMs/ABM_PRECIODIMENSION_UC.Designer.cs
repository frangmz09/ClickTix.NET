namespace ClickTix.Admin.UserControls.ABMs
{
    partial class ABM_PRECIODIMENSION_UC
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
            this.add_dimension = new System.Windows.Forms.Button();
            this.grid_dimension = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_dimension)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(157, 19);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(263, 25);
            this.title.TabIndex = 19;
            this.title.Text = "DIMENSIONES Y PRECIOS";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_dimension
            // 
            this.add_dimension.Location = new System.Drawing.Point(439, 18);
            this.add_dimension.Name = "add_dimension";
            this.add_dimension.Size = new System.Drawing.Size(108, 25);
            this.add_dimension.TabIndex = 18;
            this.add_dimension.Text = "Agregar";
            this.add_dimension.UseVisualStyleBackColor = true;
            this.add_dimension.Click += new System.EventHandler(this.add_dimension_Click);
            // 
            // grid_dimension
            // 
            this.grid_dimension.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_dimension.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Precio,
            this.Modificar,
            this.Borrar});
            this.grid_dimension.Location = new System.Drawing.Point(23, 52);
            this.grid_dimension.Name = "grid_dimension";
            this.grid_dimension.Size = new System.Drawing.Size(524, 303);
            this.grid_dimension.TabIndex = 17;
            this.grid_dimension.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_dimension_CellContentClick);
            // 
            // ID
            // 
            this.ID.Name = "ID";
            // 
            // Nombre
            // 
            this.Nombre.Name = "Nombre";
            // 
            // Precio
            // 
            this.Precio.Name = "Precio";
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            this.Modificar.Width = 50;
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Name = "Borrar";
            this.Borrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Borrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Borrar.Width = 50;
            // 
            // ABM_PRECIODIMENSION_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.title);
            this.Controls.Add(this.add_dimension);
            this.Controls.Add(this.grid_dimension);
            this.Name = "ABM_PRECIODIMENSION_UC";
            this.Size = new System.Drawing.Size(570, 373);
            ((System.ComponentModel.ISupportInitialize)(this.grid_dimension)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button add_dimension;
        private System.Windows.Forms.DataGridView grid_dimension;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
    }
}
