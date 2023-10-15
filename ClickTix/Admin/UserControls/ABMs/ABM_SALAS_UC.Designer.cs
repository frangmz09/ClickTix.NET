﻿using System;
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
            this.Salas = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.title.Size = new System.Drawing.Size(148, 25);
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
           
            // 
            // grid_salas
            // 
            this.grid_salas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_salas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar,
            this.Borrar,
            this.Salas});
            this.grid_salas.Location = new System.Drawing.Point(23, 52);
            this.grid_salas.Name = "grid_salas";
            this.grid_salas.Size = new System.Drawing.Size(524, 303);
            this.grid_salas.TabIndex = 14;
            this.grid_salas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_salas_CellContentClick);
            // 
            // Salas
            // 
            this.Modificar.HeaderText = "Salas";
            this.Modificar.Name = "Salas";
            this.Modificar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Modificar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Modificar.Width = 50;
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            this.Modificar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Modificar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // ABM_SALAS_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.title);
            this.Controls.Add(this.add_salas);
            this.Controls.Add(this.grid_salas);
            this.Name = "ABM_SALAS_UC";
            this.Size = new System.Drawing.Size(570, 373);
            ((System.ComponentModel.ISupportInitialize)(this.grid_salas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void grid_salas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button add_salas;
        private System.Windows.Forms.DataGridView grid_salas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
        private System.Windows.Forms.DataGridViewButtonColumn Salas;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
    }
}