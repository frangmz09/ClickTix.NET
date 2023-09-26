namespace ClickTix.UserControls
{
    partial class ABM_EMPLEADOS_UC
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
            this.add_empleado = new System.Windows.Forms.Button();
            this.grid_empleados = new System.Windows.Forms.DataGridView();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Roboto Bk", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(219, 18);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(125, 24);
            this.title.TabIndex = 7;
            this.title.Text = "EMPLEADOS";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // add_empleado
            // 
            this.add_empleado.Location = new System.Drawing.Point(439, 18);
            this.add_empleado.Name = "add_empleado";
            this.add_empleado.Size = new System.Drawing.Size(108, 25);
            this.add_empleado.TabIndex = 6;
            this.add_empleado.Text = "Agregar";
            this.add_empleado.UseVisualStyleBackColor = true;
            this.add_empleado.Click += new System.EventHandler(this.add_empleado_Click);
            // 
            // grid_empleados
            // 
            this.grid_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_empleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar,
            this.Borrar});
            this.grid_empleados.Location = new System.Drawing.Point(23, 52);
            this.grid_empleados.Name = "grid_empleados";
            this.grid_empleados.Size = new System.Drawing.Size(524, 303);
            this.grid_empleados.TabIndex = 5;
            this.grid_empleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_empleados_CellContentClick);
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
            // ABM_EMPLEADOS_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.title);
            this.Controls.Add(this.add_empleado);
            this.Controls.Add(this.grid_empleados);
            this.Name = "ABM_EMPLEADOS_UC";
            this.Size = new System.Drawing.Size(570, 373);
            this.Load += new System.EventHandler(this.ABM_EMPLEADOS_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button add_empleado;
        private System.Windows.Forms.DataGridView grid_empleados;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
    }
}
