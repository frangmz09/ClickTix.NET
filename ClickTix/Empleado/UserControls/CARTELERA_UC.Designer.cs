namespace ClickTix.Empleado.UserControls
{
    partial class CARTELERA_UC
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
            this.cartelera_grid = new System.Windows.Forms.DataGridView();
            this.cartelera = new System.Windows.Forms.Label();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cartelera_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // cartelera_grid
            // 
            this.cartelera_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartelera_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.cartelera_grid.Location = new System.Drawing.Point(34, 89);
            this.cartelera_grid.Name = "cartelera_grid";
            this.cartelera_grid.Size = new System.Drawing.Size(690, 265);
            this.cartelera_grid.TabIndex = 0;
            this.cartelera_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartelera_grid_CellContentClick);
            // 
            // cartelera
            // 
            this.cartelera.AutoSize = true;
            this.cartelera.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartelera.Location = new System.Drawing.Point(162, 13);
            this.cartelera.Name = "cartelera";
            this.cartelera.Size = new System.Drawing.Size(426, 73);
            this.cartelera.TabIndex = 1;
            this.cartelera.Text = "CARTELERA";
            this.cartelera.Click += new System.EventHandler(this.label1_Click);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            // 
            // CARTELERA_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cartelera);
            this.Controls.Add(this.cartelera_grid);
            this.Name = "CARTELERA_UC";
            this.Size = new System.Drawing.Size(800, 451);
            ((System.ComponentModel.ISupportInitialize)(this.cartelera_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cartelera_grid;
        private System.Windows.Forms.Label cartelera;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
    }
}
