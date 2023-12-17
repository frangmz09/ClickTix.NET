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
            this.grid_funcionesc = new System.Windows.Forms.DataGridView();
            this.cartelera = new System.Windows.Forms.Label();
            this.back_pelicula = new System.Windows.Forms.Button();
            this.idFunSel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NROsala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dimm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idiomma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_funcionesc)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_funcionesc
            // 
            this.grid_funcionesc.AllowUserToAddRows = false;
            this.grid_funcionesc.AllowUserToDeleteRows = false;
            this.grid_funcionesc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_funcionesc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFunSel,
            this.Pelicula,
            this.NROsala,
            this.Dimm,
            this.Idiomma,
            this.Precio,
            this.Fecha,
            this.Hora,
            this.Seleccionar});
            this.grid_funcionesc.Location = new System.Drawing.Point(33, 85);
            this.grid_funcionesc.Name = "grid_funcionesc";
            this.grid_funcionesc.ReadOnly = true;
            this.grid_funcionesc.Size = new System.Drawing.Size(690, 265);
            this.grid_funcionesc.TabIndex = 0;
            this.grid_funcionesc.Tag = "";
            this.grid_funcionesc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // back_pelicula
            // 
            this.back_pelicula.Location = new System.Drawing.Point(33, 25);
            this.back_pelicula.Name = "back_pelicula";
            this.back_pelicula.Size = new System.Drawing.Size(30, 30);
            this.back_pelicula.TabIndex = 74;
            this.back_pelicula.Text = "<";
            this.back_pelicula.UseVisualStyleBackColor = true;
            this.back_pelicula.Click += new System.EventHandler(this.back_pelicula_Click);
            // 
            // idFunSel
            // 
            this.idFunSel.HeaderText = "ID";
            this.idFunSel.Name = "idFunSel";
            this.idFunSel.ReadOnly = true;
            // 
            // Pelicula
            // 
            this.Pelicula.HeaderText = "Pelicula";
            this.Pelicula.Name = "Pelicula";
            this.Pelicula.ReadOnly = true;
            // 
            // NROsala
            // 
            this.NROsala.HeaderText = "Numero de Sala";
            this.NROsala.Name = "NROsala";
            this.NROsala.ReadOnly = true;
            // 
            // Dimm
            // 
            this.Dimm.HeaderText = "Dimension";
            this.Dimm.Name = "Dimm";
            this.Dimm.ReadOnly = true;
            // 
            // Idiomma
            // 
            this.Idiomma.HeaderText = "Idioma";
            this.Idiomma.Name = "Idiomma";
            this.Idiomma.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // ELEGIR_FUNCION_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.back_pelicula);
            this.Controls.Add(this.cartelera);
            this.Controls.Add(this.grid_funcionesc);
            this.Name = "ELEGIR_FUNCION_UC";
            this.Size = new System.Drawing.Size(800, 451);
            this.Load += new System.EventHandler(this.ELEGIR_FUNCION_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_funcionesc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_funcionesc;
        private System.Windows.Forms.Label cartelera;
        private System.Windows.Forms.Button back_pelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFunSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn NROsala;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dimm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idiomma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
    }
}
