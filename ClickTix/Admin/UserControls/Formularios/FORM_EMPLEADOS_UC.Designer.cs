namespace ClickTix
{
    partial class FORM_EMPLEADOS_UC
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
            this.back_pelicula = new System.Windows.Forms.Button();
            this.input_nombre = new System.Windows.Forms.TextBox();
            this.label_nombre = new System.Windows.Forms.Label();
            this.input_apellido = new System.Windows.Forms.TextBox();
            this.label_apellido = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.input_usuario = new System.Windows.Forms.TextBox();
            this.label_usuario = new System.Windows.Forms.Label();
            this.input_contraseña = new System.Windows.Forms.TextBox();
            this.label_contrasenia = new System.Windows.Forms.Label();
            this.addempleado_btn = new System.Windows.Forms.Button();
            this.input_sucursal = new System.Windows.Forms.ComboBox();
            this.label_sucursal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back_pelicula
            // 
            this.back_pelicula.Location = new System.Drawing.Point(17, 16);
            this.back_pelicula.Name = "back_pelicula";
            this.back_pelicula.Size = new System.Drawing.Size(30, 30);
            this.back_pelicula.TabIndex = 73;
            this.back_pelicula.Text = "<";
            this.back_pelicula.UseVisualStyleBackColor = true;
            this.back_pelicula.Click += new System.EventHandler(this.back_pelicula_Click);
            // 
            // input_nombre
            // 
            this.input_nombre.Location = new System.Drawing.Point(78, 119);
            this.input_nombre.Name = "input_nombre";
            this.input_nombre.Size = new System.Drawing.Size(268, 20);
            this.input_nombre.TabIndex = 61;
            this.input_nombre.TextChanged += new System.EventHandler(this.input_nombre_TextChanged);
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.Location = new System.Drawing.Point(75, 102);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(52, 15);
            this.label_nombre.TabIndex = 62;
            this.label_nombre.Text = "Nombre";
            this.label_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_apellido
            // 
            this.input_apellido.Location = new System.Drawing.Point(78, 163);
            this.input_apellido.Name = "input_apellido";
            this.input_apellido.Size = new System.Drawing.Size(268, 20);
            this.input_apellido.TabIndex = 63;
            // 
            // label_apellido
            // 
            this.label_apellido.AutoSize = true;
            this.label_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_apellido.Location = new System.Drawing.Point(75, 146);
            this.label_apellido.Name = "label_apellido";
            this.label_apellido.Size = new System.Drawing.Size(51, 15);
            this.label_apellido.TabIndex = 64;
            this.label_apellido.Text = "Apellido";
            this.label_apellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(37, 49);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(528, 25);
            this.title.TabIndex = 65;
            this.title.Text = "INGRESE DATOS PARA AGREGAR NUEVO EMPLEADO";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_usuario
            // 
            this.input_usuario.Location = new System.Drawing.Point(78, 211);
            this.input_usuario.Name = "input_usuario";
            this.input_usuario.Size = new System.Drawing.Size(268, 20);
            this.input_usuario.TabIndex = 66;
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usuario.Location = new System.Drawing.Point(75, 194);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(50, 15);
            this.label_usuario.TabIndex = 67;
            this.label_usuario.Text = "Usuario";
            this.label_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_contraseña
            // 
            this.input_contraseña.Location = new System.Drawing.Point(78, 255);
            this.input_contraseña.Name = "input_contraseña";
            this.input_contraseña.Size = new System.Drawing.Size(268, 20);
            this.input_contraseña.TabIndex = 68;
            // 
            // label_contrasenia
            // 
            this.label_contrasenia.AutoSize = true;
            this.label_contrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contrasenia.Location = new System.Drawing.Point(75, 238);
            this.label_contrasenia.Name = "label_contrasenia";
            this.label_contrasenia.Size = new System.Drawing.Size(70, 15);
            this.label_contrasenia.TabIndex = 69;
            this.label_contrasenia.Text = "Contraseña";
            this.label_contrasenia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addempleado_btn
            // 
            this.addempleado_btn.Location = new System.Drawing.Point(214, 304);
            this.addempleado_btn.Name = "addempleado_btn";
            this.addempleado_btn.Size = new System.Drawing.Size(111, 25);
            this.addempleado_btn.TabIndex = 70;
            this.addempleado_btn.Text = "Agregar";
            this.addempleado_btn.UseVisualStyleBackColor = true;
            this.addempleado_btn.Click += new System.EventHandler(this.addempleado_btn_Click);
            // 
            // input_sucursal
            // 
            this.input_sucursal.FormattingEnabled = true;
            this.input_sucursal.Location = new System.Drawing.Point(386, 186);
            this.input_sucursal.Name = "input_sucursal";
            this.input_sucursal.Size = new System.Drawing.Size(71, 21);
            this.input_sucursal.TabIndex = 71;
            this.input_sucursal.SelectedIndexChanged += new System.EventHandler(this.input_sucursal_SelectedIndexChanged);
            // 
            // label_sucursal
            // 
            this.label_sucursal.AutoSize = true;
            this.label_sucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sucursal.Location = new System.Drawing.Point(393, 169);
            this.label_sucursal.Name = "label_sucursal";
            this.label_sucursal.Size = new System.Drawing.Size(55, 15);
            this.label_sucursal.TabIndex = 72;
            this.label_sucursal.Text = "Sucursal";
            this.label_sucursal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FORM_EMPLEADOS_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.back_pelicula);
            this.Controls.Add(this.label_sucursal);
            this.Controls.Add(this.input_sucursal);
            this.Controls.Add(this.addempleado_btn);
            this.Controls.Add(this.label_contrasenia);
            this.Controls.Add(this.input_contraseña);
            this.Controls.Add(this.label_usuario);
            this.Controls.Add(this.input_usuario);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label_apellido);
            this.Controls.Add(this.input_apellido);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.input_nombre);
            this.Name = "FORM_EMPLEADOS_UC";
            this.Size = new System.Drawing.Size(560, 373);
            this.Load += new System.EventHandler(this.FORM_EMPLEADOS_UC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button back_pelicula;
        private System.Windows.Forms.TextBox input_nombre;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.TextBox input_apellido;
        private System.Windows.Forms.Label label_apellido;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox input_usuario;
        private System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.TextBox input_contraseña;
        private System.Windows.Forms.Label label_contrasenia;
        private System.Windows.Forms.Button addempleado_btn;
        private System.Windows.Forms.ComboBox input_sucursal;
        private System.Windows.Forms.Label label_sucursal;
    }
}
