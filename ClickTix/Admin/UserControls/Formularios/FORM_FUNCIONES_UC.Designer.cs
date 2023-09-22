namespace ClickTix.UserControls
{
    partial class FORM_FUNCIONES_UC
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
            this.addfuncion_btn = new System.Windows.Forms.Button();
            this.label_pelicula = new System.Windows.Forms.Label();
            this.label_idioma = new System.Windows.Forms.Label();
            this.label_dimension = new System.Windows.Forms.Label();
            this.label_turno = new System.Windows.Forms.Label();
            this.label_fecha = new System.Windows.Forms.Label();
            this.label_sala = new System.Windows.Forms.Label();
            this.input_idioma = new System.Windows.Forms.ComboBox();
            this.input_sala = new System.Windows.Forms.ComboBox();
            this.input_dimension = new System.Windows.Forms.ComboBox();
            this.input_turno = new System.Windows.Forms.ComboBox();
            this.input_fecha = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.input_sucursal = new System.Windows.Forms.ComboBox();
            this.label_sucursal = new System.Windows.Forms.Label();
            this.back_pelicula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Roboto Bk", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(76, 22);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(400, 24);
            this.title.TabIndex = 1;
            this.title.Text = "INGRESE DATOS PARA AGREGAR FUNCION";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addfuncion_btn
            // 
            this.addfuncion_btn.Location = new System.Drawing.Point(289, 280);
            this.addfuncion_btn.Name = "addfuncion_btn";
            this.addfuncion_btn.Size = new System.Drawing.Size(111, 25);
            this.addfuncion_btn.TabIndex = 32;
            this.addfuncion_btn.Text = "Agregar";
            this.addfuncion_btn.UseVisualStyleBackColor = true;
            // 
            // label_pelicula
            // 
            this.label_pelicula.AutoSize = true;
            this.label_pelicula.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pelicula.Location = new System.Drawing.Point(82, 57);
            this.label_pelicula.Name = "label_pelicula";
            this.label_pelicula.Size = new System.Drawing.Size(45, 14);
            this.label_pelicula.TabIndex = 31;
            this.label_pelicula.Text = "Pelicula";
            this.label_pelicula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_idioma
            // 
            this.label_idioma.AutoSize = true;
            this.label_idioma.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idioma.Location = new System.Drawing.Point(296, 205);
            this.label_idioma.Name = "label_idioma";
            this.label_idioma.Size = new System.Drawing.Size(40, 14);
            this.label_idioma.TabIndex = 30;
            this.label_idioma.Text = "Idioma";
            this.label_idioma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_dimension
            // 
            this.label_dimension.AutoSize = true;
            this.label_dimension.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dimension.Location = new System.Drawing.Point(377, 153);
            this.label_dimension.Name = "label_dimension";
            this.label_dimension.Size = new System.Drawing.Size(57, 14);
            this.label_dimension.TabIndex = 29;
            this.label_dimension.Text = "Dimension";
            this.label_dimension.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_turno
            // 
            this.label_turno.AutoSize = true;
            this.label_turno.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_turno.Location = new System.Drawing.Point(386, 100);
            this.label_turno.Name = "label_turno";
            this.label_turno.Size = new System.Drawing.Size(35, 14);
            this.label_turno.TabIndex = 28;
            this.label_turno.Text = "Turno";
            this.label_turno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fecha.Location = new System.Drawing.Point(300, 100);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(35, 14);
            this.label_fecha.TabIndex = 27;
            this.label_fecha.Text = "Fecha";
            this.label_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_sala
            // 
            this.label_sala.AutoSize = true;
            this.label_sala.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sala.Location = new System.Drawing.Point(302, 153);
            this.label_sala.Name = "label_sala";
            this.label_sala.Size = new System.Drawing.Size(28, 14);
            this.label_sala.TabIndex = 26;
            this.label_sala.Text = "Sala";
            this.label_sala.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input_idioma
            // 
            this.input_idioma.FormattingEnabled = true;
            this.input_idioma.Location = new System.Drawing.Point(272, 222);
            this.input_idioma.Name = "input_idioma";
            this.input_idioma.Size = new System.Drawing.Size(92, 21);
            this.input_idioma.TabIndex = 25;
            // 
            // input_sala
            // 
            this.input_sala.FormattingEnabled = true;
            this.input_sala.Location = new System.Drawing.Point(272, 170);
            this.input_sala.Name = "input_sala";
            this.input_sala.Size = new System.Drawing.Size(92, 21);
            this.input_sala.TabIndex = 24;
            // 
            // input_dimension
            // 
            this.input_dimension.FormattingEnabled = true;
            this.input_dimension.Location = new System.Drawing.Point(370, 170);
            this.input_dimension.Name = "input_dimension";
            this.input_dimension.Size = new System.Drawing.Size(71, 21);
            this.input_dimension.TabIndex = 23;
            // 
            // input_turno
            // 
            this.input_turno.FormattingEnabled = true;
            this.input_turno.Location = new System.Drawing.Point(370, 116);
            this.input_turno.Name = "input_turno";
            this.input_turno.Size = new System.Drawing.Size(71, 21);
            this.input_turno.TabIndex = 22;
            // 
            // input_fecha
            // 
            this.input_fecha.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.input_fecha.Location = new System.Drawing.Point(272, 116);
            this.input_fecha.Name = "input_fecha";
            this.input_fecha.Size = new System.Drawing.Size(92, 21);
            this.input_fecha.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(80, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 204);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // input_sucursal
            // 
            this.input_sucursal.FormattingEnabled = true;
            this.input_sucursal.Location = new System.Drawing.Point(370, 222);
            this.input_sucursal.Name = "input_sucursal";
            this.input_sucursal.Size = new System.Drawing.Size(71, 21);
            this.input_sucursal.TabIndex = 33;
            // 
            // label_sucursal
            // 
            this.label_sucursal.AutoSize = true;
            this.label_sucursal.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sucursal.Location = new System.Drawing.Point(377, 205);
            this.label_sucursal.Name = "label_sucursal";
            this.label_sucursal.Size = new System.Drawing.Size(48, 14);
            this.label_sucursal.TabIndex = 34;
            this.label_sucursal.Text = "Sucursal";
            this.label_sucursal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // back_pelicula
            // 
            this.back_pelicula.Location = new System.Drawing.Point(17, 16);
            this.back_pelicula.Name = "back_pelicula";
            this.back_pelicula.Size = new System.Drawing.Size(30, 30);
            this.back_pelicula.TabIndex = 64;
            this.back_pelicula.Text = "<";
            this.back_pelicula.UseVisualStyleBackColor = true;
            this.back_pelicula.Click += new System.EventHandler(this.back_pelicula_Click);
            // 
            // FORMFUNCIONES_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.back_pelicula);
            this.Controls.Add(this.label_sucursal);
            this.Controls.Add(this.input_sucursal);
            this.Controls.Add(this.addfuncion_btn);
            this.Controls.Add(this.label_pelicula);
            this.Controls.Add(this.label_idioma);
            this.Controls.Add(this.label_dimension);
            this.Controls.Add(this.label_turno);
            this.Controls.Add(this.label_fecha);
            this.Controls.Add(this.label_sala);
            this.Controls.Add(this.input_idioma);
            this.Controls.Add(this.input_sala);
            this.Controls.Add(this.input_dimension);
            this.Controls.Add(this.input_turno);
            this.Controls.Add(this.input_fecha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.title);
            this.Name = "FORMFUNCIONES_UC";
            this.Size = new System.Drawing.Size(560, 373);
            this.Load += new System.EventHandler(this.FUNCIONES_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button addfuncion_btn;
        private System.Windows.Forms.Label label_pelicula;
        private System.Windows.Forms.Label label_idioma;
        private System.Windows.Forms.Label label_dimension;
        private System.Windows.Forms.Label label_turno;
        private System.Windows.Forms.Label label_fecha;
        private System.Windows.Forms.Label label_sala;
        private System.Windows.Forms.ComboBox input_idioma;
        private System.Windows.Forms.ComboBox input_sala;
        private System.Windows.Forms.ComboBox input_dimension;
        private System.Windows.Forms.ComboBox input_turno;
        private System.Windows.Forms.DateTimePicker input_fecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox input_sucursal;
        private System.Windows.Forms.Label label_sucursal;
        private System.Windows.Forms.Button back_pelicula;
    }
}
