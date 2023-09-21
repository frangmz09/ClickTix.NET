namespace ClickTix
{
    partial class FORMEMPLEADOS_UC
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
            this.label_apellido = new System.Windows.Forms.Label();
            this.input_direccion = new System.Windows.Forms.TextBox();
            this.label_nombre = new System.Windows.Forms.Label();
            this.input_nombre = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.label_contrasenia = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_usuario = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addempleado_btn = new System.Windows.Forms.Button();
            this.label_sucursal = new System.Windows.Forms.Label();
            this.input_sucursal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_apellido
            // 
            this.label_apellido.AutoSize = true;
            this.label_apellido.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_apellido.Location = new System.Drawing.Point(80, 149);
            this.label_apellido.Name = "label_apellido";
            this.label_apellido.Size = new System.Drawing.Size(46, 14);
            this.label_apellido.TabIndex = 64;
            this.label_apellido.Text = "Apellido";
            this.label_apellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_direccion
            // 
            this.input_direccion.Location = new System.Drawing.Point(83, 166);
            this.input_direccion.Name = "input_direccion";
            this.input_direccion.Size = new System.Drawing.Size(268, 20);
            this.input_direccion.TabIndex = 63;
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.Location = new System.Drawing.Point(80, 105);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(44, 14);
            this.label_nombre.TabIndex = 62;
            this.label_nombre.Text = "Nombre";
            this.label_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_nombre
            // 
            this.input_nombre.Location = new System.Drawing.Point(83, 122);
            this.input_nombre.Name = "input_nombre";
            this.input_nombre.Size = new System.Drawing.Size(268, 20);
            this.input_nombre.TabIndex = 61;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Roboto Bk", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(42, 52);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(488, 24);
            this.title.TabIndex = 65;
            this.title.Text = "INGRESE DATOS PARA AGREGAR NUEVO EMPLEADO";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_contrasenia
            // 
            this.label_contrasenia.AutoSize = true;
            this.label_contrasenia.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contrasenia.Location = new System.Drawing.Point(80, 241);
            this.label_contrasenia.Name = "label_contrasenia";
            this.label_contrasenia.Size = new System.Drawing.Size(62, 14);
            this.label_contrasenia.TabIndex = 69;
            this.label_contrasenia.Text = "Contraseña";
            this.label_contrasenia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 258);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 20);
            this.textBox1.TabIndex = 68;
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usuario.Location = new System.Drawing.Point(80, 197);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(44, 14);
            this.label_usuario.TabIndex = 67;
            this.label_usuario.Text = "Usuario";
            this.label_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 214);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(268, 20);
            this.textBox2.TabIndex = 66;
            // 
            // addempleado_btn
            // 
            this.addempleado_btn.Location = new System.Drawing.Point(219, 307);
            this.addempleado_btn.Name = "addempleado_btn";
            this.addempleado_btn.Size = new System.Drawing.Size(111, 25);
            this.addempleado_btn.TabIndex = 70;
            this.addempleado_btn.Text = "Agregar";
            this.addempleado_btn.UseVisualStyleBackColor = true;
            // 
            // label_sucursal
            // 
            this.label_sucursal.AutoSize = true;
            this.label_sucursal.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sucursal.Location = new System.Drawing.Point(398, 172);
            this.label_sucursal.Name = "label_sucursal";
            this.label_sucursal.Size = new System.Drawing.Size(48, 14);
            this.label_sucursal.TabIndex = 72;
            this.label_sucursal.Text = "Sucursal";
            this.label_sucursal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_sucursal
            // 
            this.input_sucursal.FormattingEnabled = true;
            this.input_sucursal.Location = new System.Drawing.Point(391, 189);
            this.input_sucursal.Name = "input_sucursal";
            this.input_sucursal.Size = new System.Drawing.Size(71, 21);
            this.input_sucursal.TabIndex = 71;
            // 
            // EMPLEADOS_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_sucursal);
            this.Controls.Add(this.input_sucursal);
            this.Controls.Add(this.addempleado_btn);
            this.Controls.Add(this.label_contrasenia);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_usuario);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label_apellido);
            this.Controls.Add(this.input_direccion);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.input_nombre);
            this.Name = "EMPLEADOS_UC";
            this.Size = new System.Drawing.Size(560, 373);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_apellido;
        private System.Windows.Forms.TextBox input_direccion;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.TextBox input_nombre;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label_contrasenia;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button addempleado_btn;
        private System.Windows.Forms.Label label_sucursal;
        private System.Windows.Forms.ComboBox input_sucursal;
    }
}
