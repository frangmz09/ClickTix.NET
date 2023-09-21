namespace ClickTix
{
    partial class Index
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_peliculas = new System.Windows.Forms.Button();
            this.btn_sucur = new System.Windows.Forms.Button();
            this.btn_empleado = new System.Windows.Forms.Button();
            this.btn_funciones = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_peliculas
            // 
            this.btn_peliculas.Location = new System.Drawing.Point(12, 37);
            this.btn_peliculas.Name = "btn_peliculas";
            this.btn_peliculas.Size = new System.Drawing.Size(125, 51);
            this.btn_peliculas.TabIndex = 0;
            this.btn_peliculas.Text = "Peliculas";
            this.btn_peliculas.UseVisualStyleBackColor = true;
            this.btn_peliculas.Click += new System.EventHandler(this.btn_peliculas_Click);
            // 
            // btn_sucur
            // 
            this.btn_sucur.Location = new System.Drawing.Point(12, 110);
            this.btn_sucur.Name = "btn_sucur";
            this.btn_sucur.Size = new System.Drawing.Size(125, 51);
            this.btn_sucur.TabIndex = 1;
            this.btn_sucur.Text = "Sucursales";
            this.btn_sucur.UseVisualStyleBackColor = true;
            this.btn_sucur.Click += new System.EventHandler(this.btn_sucur_Click);
            // 
            // btn_empleado
            // 
            this.btn_empleado.Location = new System.Drawing.Point(12, 252);
            this.btn_empleado.Name = "btn_empleado";
            this.btn_empleado.Size = new System.Drawing.Size(125, 51);
            this.btn_empleado.TabIndex = 2;
            this.btn_empleado.Text = "Empleado";
            this.btn_empleado.UseVisualStyleBackColor = true;
            this.btn_empleado.Click += new System.EventHandler(this.btn_empleado_Click);
            // 
            // btn_funciones
            // 
            this.btn_funciones.Location = new System.Drawing.Point(12, 181);
            this.btn_funciones.Name = "btn_funciones";
            this.btn_funciones.Size = new System.Drawing.Size(125, 51);
            this.btn_funciones.TabIndex = 3;
            this.btn_funciones.Text = "Funciones";
            this.btn_funciones.UseVisualStyleBackColor = true;
            this.btn_funciones.Click += new System.EventHandler(this.btn_funciones_Click);
            // 
            // panel1
            // 
            panel1.Location = new System.Drawing.Point(186, 37);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(560, 373);
            panel1.TabIndex = 4;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(panel1);
            this.Controls.Add(this.btn_funciones);
            this.Controls.Add(this.btn_empleado);
            this.Controls.Add(this.btn_sucur);
            this.Controls.Add(this.btn_peliculas);
            this.Name = "Index";
            this.Text = "Index";
            this.Load += new System.EventHandler(this.Index_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_peliculas;
        private System.Windows.Forms.Button btn_sucur;
        private System.Windows.Forms.Button btn_empleado;
        private System.Windows.Forms.Button btn_funciones;
        public static System.Windows.Forms.Panel panel1;
    }
}