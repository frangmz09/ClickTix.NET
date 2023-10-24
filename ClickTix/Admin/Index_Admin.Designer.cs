namespace ClickTix
{
    partial class Index_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index_Admin));
            this.btn_peliculas = new System.Windows.Forms.Button();
            this.btn_sucur = new System.Windows.Forms.Button();
            this.btn_empleado = new System.Windows.Forms.Button();
            this.btn_funciones = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_dimensiones = new System.Windows.Forms.Button();
            this.btn_logOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_peliculas
            // 
            this.btn_peliculas.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btn_sucur.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btn_empleado.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btn_funciones.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Location = new System.Drawing.Point(186, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 373);
            this.panel1.TabIndex = 4;
            // 
            // btn_dimensiones
            // 
            this.btn_dimensiones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_dimensiones.Location = new System.Drawing.Point(12, 323);
            this.btn_dimensiones.Name = "btn_dimensiones";
            this.btn_dimensiones.Size = new System.Drawing.Size(125, 51);
            this.btn_dimensiones.TabIndex = 5;
            this.btn_dimensiones.Text = "Precios/Dimensiones";
            this.btn_dimensiones.UseVisualStyleBackColor = true;
            this.btn_dimensiones.Click += new System.EventHandler(this.btn_dimensiones_Click);
            // 
            // btn_logOut
            // 
            this.btn_logOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_logOut.Location = new System.Drawing.Point(648, 8);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(98, 23);
            this.btn_logOut.TabIndex = 6;
            this.btn_logOut.Text = "Cerrar Sesion";
            this.btn_logOut.UseVisualStyleBackColor = true;
            this.btn_logOut.Click += new System.EventHandler(this.button1_Click);
            // 
            // Index_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_logOut);
            this.Controls.Add(this.btn_dimensiones);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_funciones);
            this.Controls.Add(this.btn_empleado);
            this.Controls.Add(this.btn_sucur);
            this.Controls.Add(this.btn_peliculas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Index_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Index";
            this.Load += new System.EventHandler(this.Index_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_peliculas;
        private System.Windows.Forms.Button btn_sucur;
        private System.Windows.Forms.Button btn_empleado;
        private System.Windows.Forms.Button btn_funciones;
        private System.Windows.Forms.Button btn_dimensiones;
        private System.Windows.Forms.Button btn_logOut;
        public System.Windows.Forms.Panel panel1;
    }
}