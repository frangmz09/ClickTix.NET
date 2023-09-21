namespace ClickTix.UserControls
{
    partial class ABMPELICULAS_UC
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
            this.add_pelicula = new System.Windows.Forms.Button();
            this.back_pelicula = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(524, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // add_pelicula
            // 
            this.add_pelicula.Location = new System.Drawing.Point(432, 16);
            this.add_pelicula.Name = "add_pelicula";
            this.add_pelicula.Size = new System.Drawing.Size(108, 25);
            this.add_pelicula.TabIndex = 1;
            this.add_pelicula.Text = "Agregar";
            this.add_pelicula.UseVisualStyleBackColor = true;
            this.add_pelicula.Click += new System.EventHandler(this.add_pelicula_Click);
            // 
            // back_pelicula
            // 
            this.back_pelicula.Location = new System.Drawing.Point(16, 13);
            this.back_pelicula.Name = "back_pelicula";
            this.back_pelicula.Size = new System.Drawing.Size(30, 30);
            this.back_pelicula.TabIndex = 2;
            this.back_pelicula.Text = "<";
            this.back_pelicula.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Roboto Bk", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(212, 16);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(114, 24);
            this.title.TabIndex = 4;
            this.title.Text = "PELICULAS";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ABMPELICULAS_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.title);
            this.Controls.Add(this.back_pelicula);
            this.Controls.Add(this.add_pelicula);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ABMPELICULAS_UC";
            this.Size = new System.Drawing.Size(560, 373);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add_pelicula;
        private System.Windows.Forms.Button back_pelicula;
        private System.Windows.Forms.Label title;
    }
}
