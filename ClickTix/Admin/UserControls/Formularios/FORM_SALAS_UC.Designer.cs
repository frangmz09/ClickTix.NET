namespace ClickTix.UserControls
{
    partial class FORM_SALAS_UC
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
            this.addsala_btn = new System.Windows.Forms.Button();
            this.back_pelicula = new System.Windows.Forms.Button();
            this.input_filas = new System.Windows.Forms.NumericUpDown();
            this.input_columnas = new System.Windows.Forms.NumericUpDown();
            this.valorCapacidad = new System.Windows.Forms.Label();
            this.labelColumnas = new System.Windows.Forms.Label();
            this.labelFilas = new System.Windows.Forms.Label();
            this.labelCapacidad = new System.Windows.Forms.Label();
            this.nroSalaLabel = new System.Windows.Forms.Label();
            this.valorNroSala = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.input_filas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_columnas)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(71, 22);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(408, 25);
            this.title.TabIndex = 3;
            this.title.Text = "INGRESE DATOS PARA AGREGAR SALAS";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addsala_btn
            // 
            this.addsala_btn.Location = new System.Drawing.Point(222, 285);
            this.addsala_btn.Name = "addsala_btn";
            this.addsala_btn.Size = new System.Drawing.Size(111, 25);
            this.addsala_btn.TabIndex = 33;
            this.addsala_btn.Text = "Agregar";
            this.addsala_btn.UseVisualStyleBackColor = true;
            //this.addsala_btn.Click += new System.EventHandler(this.addsala_btn_Click);
            // 
            // back_pelicula
            // 
            this.back_pelicula.Location = new System.Drawing.Point(0, 0);
            this.back_pelicula.Name = "back_pelicula";
            this.back_pelicula.Size = new System.Drawing.Size(75, 23);
            this.back_pelicula.TabIndex = 70;
            this.back_pelicula.Text = "<";
            this.back_pelicula.Click += new System.EventHandler(this.back_pelicula_Click_1);
            // 
            // input_filas
            // 
            this.input_filas.Location = new System.Drawing.Point(312, 131);
            this.input_filas.Name = "input_filas";
            this.input_filas.Size = new System.Drawing.Size(45, 20);
            this.input_filas.TabIndex = 67;
            // 
            // input_columnas
            // 
            this.input_columnas.Location = new System.Drawing.Point(312, 89);
            this.input_columnas.Name = "input_columnas";
            this.input_columnas.Size = new System.Drawing.Size(45, 20);
            this.input_columnas.TabIndex = 68;
            // 
            // valorCapacidad
            // 
            this.valorCapacidad.AutoSize = true;
            this.valorCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorCapacidad.Location = new System.Drawing.Point(324, 201);
            this.valorCapacidad.Name = "valorCapacidad";
            this.valorCapacidad.Size = new System.Drawing.Size(92, 15);
            this.valorCapacidad.TabIndex = 69;
            this.valorCapacidad.Text = "valorCapacidad";
            this.valorCapacidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColumnas
            // 
            this.labelColumnas.AutoSize = true;
            this.labelColumnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColumnas.Location = new System.Drawing.Point(219, 94);
            this.labelColumnas.Name = "labelColumnas";
            this.labelColumnas.Size = new System.Drawing.Size(78, 15);
            this.labelColumnas.TabIndex = 71;
            this.labelColumnas.Text = "COLUMNAS:";
            this.labelColumnas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFilas
            // 
            this.labelFilas.AutoSize = true;
            this.labelFilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilas.Location = new System.Drawing.Point(219, 136);
            this.labelFilas.Name = "labelFilas";
            this.labelFilas.Size = new System.Drawing.Size(42, 15);
            this.labelFilas.TabIndex = 72;
            this.labelFilas.Text = "FILAS:";
            this.labelFilas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCapacidad
            // 
            this.labelCapacidad.AutoSize = true;
            this.labelCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapacidad.Location = new System.Drawing.Point(219, 201);
            this.labelCapacidad.Name = "labelCapacidad";
            this.labelCapacidad.Size = new System.Drawing.Size(76, 15);
            this.labelCapacidad.TabIndex = 73;
            this.labelCapacidad.Text = "CAPACIDAD:";
            this.labelCapacidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nroSalaLabel
            // 
            this.nroSalaLabel.AutoSize = true;
            this.nroSalaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nroSalaLabel.Location = new System.Drawing.Point(219, 229);
            this.nroSalaLabel.Name = "nroSalaLabel";
            this.nroSalaLabel.Size = new System.Drawing.Size(69, 15);
            this.nroSalaLabel.TabIndex = 74;
            this.nroSalaLabel.Text = "NRO SALA:";
            this.nroSalaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valorNroSala
            // 
            this.valorNroSala.AutoSize = true;
            this.valorNroSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorNroSala.Location = new System.Drawing.Point(324, 229);
            this.valorNroSala.Name = "valorNroSala";
            this.valorNroSala.Size = new System.Drawing.Size(58, 15);
            this.valorNroSala.TabIndex = 75;
            this.valorNroSala.Text = "valorSala";
            this.valorNroSala.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FORM_SALAS_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.valorNroSala);
            this.Controls.Add(this.nroSalaLabel);
            this.Controls.Add(this.labelCapacidad);
            this.Controls.Add(this.labelFilas);
            this.Controls.Add(this.labelColumnas);
            this.Controls.Add(this.valorCapacidad);
            this.Controls.Add(this.input_columnas);
            this.Controls.Add(this.input_filas);
            this.Controls.Add(this.back_pelicula);
            this.Controls.Add(this.addsala_btn);
            this.Controls.Add(this.title);
            this.Name = "FORM_SALAS_UC";
            this.Size = new System.Drawing.Size(560, 373);
            ((System.ComponentModel.ISupportInitialize)(this.input_filas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input_columnas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button addsala_btn;
        
        private System.Windows.Forms.Button back_pelicula;
        private System.Windows.Forms.NumericUpDown input_filas;
        private System.Windows.Forms.NumericUpDown input_columnas;
        private System.Windows.Forms.Label valorCapacidad;
        private System.Windows.Forms.Label labelColumnas;
        private System.Windows.Forms.Label labelFilas;
        private System.Windows.Forms.Label labelCapacidad;
        private System.Windows.Forms.Label nroSalaLabel;
        private System.Windows.Forms.Label valorNroSala;
    }
}
