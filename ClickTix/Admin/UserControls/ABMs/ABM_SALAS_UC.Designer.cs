using System;
using System.Windows.Forms;

namespace ClickTix.UserControls
{
    partial class ABM_SALAS_UC
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
            this.add_salas = new System.Windows.Forms.Button();
            this.grid_salas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.IdSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_salas)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(219, 18);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(79, 25);
            this.title.TabIndex = 16;
            this.title.Text = "SALAS";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_salas
            // 
            this.add_salas.Location = new System.Drawing.Point(439, 18);
            this.add_salas.Name = "add_salas";
            this.add_salas.Size = new System.Drawing.Size(108, 25);
            this.add_salas.TabIndex = 15;
            this.add_salas.Text = "Agregar";
            this.add_salas.UseVisualStyleBackColor = true;
            this.add_salas.Click += new System.EventHandler(this.add_salas_Click);
            // 
            // grid_salas
            // 
            this.grid_salas.AllowUserToAddRows = false;
            this.grid_salas.AllowUserToDeleteRows = false;
            this.grid_salas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_salas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSala,
            this.nroSala,
            this.Filas,
            this.Columnas,
            this.Capacidad,
            this.Modificar,
            this.Borrar});
            this.grid_salas.Location = new System.Drawing.Point(23, 52);
            this.grid_salas.Name = "grid_salas";
            this.grid_salas.ReadOnly = true;
            this.grid_salas.Size = new System.Drawing.Size(524, 303);
            this.grid_salas.TabIndex = 14;
            this.grid_salas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_salas_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.back_button_Click_SalaToSucursales);
            // 
            // IdSala
            // 
            this.IdSala.HeaderText = "ID";
            this.IdSala.Name = "IdSala";
            this.IdSala.ReadOnly = true;
            // 
            // nroSala
            // 
            this.nroSala.HeaderText = "Numero de Sala";
            this.nroSala.Name = "nroSala";
            this.nroSala.ReadOnly = true;
            // 
            // Filas
            // 
            this.Filas.HeaderText = "Filas";
            this.Filas.Name = "Filas";
            this.Filas.ReadOnly = true;
            // 
            // Columnas
            // 
            this.Columnas.HeaderText = "Columnas";
            this.Columnas.Name = "Columnas";
            this.Columnas.ReadOnly = true;
            // 
            // Capacidad
            // 
            this.Capacidad.HeaderText = "Capacidad";
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.ReadOnly = true;
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Modificar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // ABM_SALAS_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.add_salas);
            this.Controls.Add(this.grid_salas);
            this.Name = "ABM_SALAS_UC";
            this.Size = new System.Drawing.Size(570, 373);
            ((System.ComponentModel.ISupportInitialize)(this.grid_salas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button add_salas;
        private System.Windows.Forms.DataGridView grid_salas;
        private Button button1;
        private DataGridViewTextBoxColumn IdSala;
        private DataGridViewTextBoxColumn nroSala;
        private DataGridViewTextBoxColumn Filas;
        private DataGridViewTextBoxColumn Columnas;
        private DataGridViewTextBoxColumn Capacidad;
        private DataGridViewButtonColumn Modificar;
        private DataGridViewButtonColumn Borrar;
    }
}
