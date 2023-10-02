namespace ClickTix.Empleado
{
    partial class ELEGIR_FUNCION_UC
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Fecha_hora = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Dimension = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Idioma = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cartelera = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha_hora,
            this.Dimension,
            this.Idioma});
            this.dataGridView1.Location = new System.Drawing.Point(33, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(690, 265);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Tag = "";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Fecha_hora
            // 
            this.Fecha_hora.HeaderText = "Fecha y Hora";
            this.Fecha_hora.Name = "Fecha_hora";
            // 
            // Dimension
            // 
            this.Dimension.HeaderText = "Dimension";
            this.Dimension.Name = "Dimension";
            // 
            // Idioma
            // 
            this.Idioma.HeaderText = "Idioma";
            this.Idioma.Name = "Idioma";
            // 
            // cartelera
            // 
            this.cartelera.AutoSize = true;
            this.cartelera.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartelera.Location = new System.Drawing.Point(146, 13);
            this.cartelera.Name = "cartelera";
            this.cartelera.Size = new System.Drawing.Size(498, 39);
            this.cartelera.TabIndex = 2;
            this.cartelera.Text = "Confirmar datos de la funcion";
            this.cartelera.Click += new System.EventHandler(this.cartelera_Click);
            // 
            // ELEGIR_FUNCION_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cartelera);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ELEGIR_FUNCION_UC";
            this.Size = new System.Drawing.Size(800, 451);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label cartelera;
        private System.Windows.Forms.DataGridViewButtonColumn Fecha_hora;
        private System.Windows.Forms.DataGridViewButtonColumn Dimension;
        private System.Windows.Forms.DataGridViewButtonColumn Idioma;
    }
}
