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
            this.combobox_idioma = new System.Windows.Forms.ComboBox();
            this.combobox_sala = new System.Windows.Forms.ComboBox();
            this.combobox_dimension = new System.Windows.Forms.ComboBox();
            this.combobox_turno = new System.Windows.Forms.ComboBox();
            this.combobox_fecha = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.combobox_pelicula = new System.Windows.Forms.ComboBox();
            this.combobox_sucursal = new System.Windows.Forms.ComboBox();
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
            this.addfuncion_btn.Click += new System.EventHandler(this.addfuncion_btn_Click);
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
            this.label_dimension.Location = new System.Drawing.Point(384, 205);
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
            this.label_turno.Location = new System.Drawing.Point(400, 100);
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
            this.label_sala.Location = new System.Drawing.Point(400, 155);
            this.label_sala.Name = "label_sala";
            this.label_sala.Size = new System.Drawing.Size(28, 14);
            this.label_sala.TabIndex = 26;
            this.label_sala.Text = "Sala";
            this.label_sala.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combobox_idioma
            // 
            this.combobox_idioma.FormattingEnabled = true;
            this.combobox_idioma.Location = new System.Drawing.Point(272, 222);
            this.combobox_idioma.Name = "combobox_idioma";
            this.combobox_idioma.Size = new System.Drawing.Size(92, 21);
            this.combobox_idioma.TabIndex = 25;
            // 
            // combobox_sala
            // 
            this.combobox_sala.Enabled = false;
            this.combobox_sala.FormattingEnabled = true;
            this.combobox_sala.Location = new System.Drawing.Point(377, 172);
            this.combobox_sala.Name = "combobox_sala";
            this.combobox_sala.Size = new System.Drawing.Size(71, 21);
            this.combobox_sala.TabIndex = 24;
            // 
            // combobox_dimension
            // 
            this.combobox_dimension.FormattingEnabled = true;
            this.combobox_dimension.Location = new System.Drawing.Point(377, 222);
            this.combobox_dimension.Name = "combobox_dimension";
            this.combobox_dimension.Size = new System.Drawing.Size(71, 21);
            this.combobox_dimension.TabIndex = 23;
            // 
            // combobox_turno
            // 
            this.combobox_turno.FormattingEnabled = true;
            this.combobox_turno.Location = new System.Drawing.Point(377, 116);
            this.combobox_turno.Name = "combobox_turno";
            this.combobox_turno.Size = new System.Drawing.Size(71, 21);
            this.combobox_turno.TabIndex = 22;
            // 
            // combobox_fecha
            // 
            this.combobox_fecha.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.combobox_fecha.Location = new System.Drawing.Point(272, 116);
            this.combobox_fecha.Name = "combobox_fecha";
            this.combobox_fecha.Size = new System.Drawing.Size(92, 21);
            this.combobox_fecha.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(80, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 204);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // combobox_pelicula
            // 
            this.combobox_pelicula.FormattingEnabled = true;
            this.combobox_pelicula.Location = new System.Drawing.Point(80, 74);
            this.combobox_pelicula.Name = "combobox_pelicula";
            this.combobox_pelicula.Size = new System.Drawing.Size(152, 21);
            this.combobox_pelicula.TabIndex = 19;
            // 
            // combobox_sucursal
            // 
            this.combobox_sucursal.FormattingEnabled = true;
            this.combobox_sucursal.Location = new System.Drawing.Point(272, 172);
            this.combobox_sucursal.Name = "combobox_sucursal";
            this.combobox_sucursal.Size = new System.Drawing.Size(92, 21);
            this.combobox_sucursal.TabIndex = 33;
            // 
            // label_sucursal
            // 
            this.label_sucursal.AutoSize = true;
            this.label_sucursal.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sucursal.Location = new System.Drawing.Point(286, 155);
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
            // FORM_FUNCIONES_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.back_pelicula);
            this.Controls.Add(this.label_sucursal);
            this.Controls.Add(this.combobox_sucursal);
            this.Controls.Add(this.addfuncion_btn);
            this.Controls.Add(this.label_pelicula);
            this.Controls.Add(this.label_idioma);
            this.Controls.Add(this.label_dimension);
            this.Controls.Add(this.label_turno);
            this.Controls.Add(this.label_fecha);
            this.Controls.Add(this.label_sala);
            this.Controls.Add(this.combobox_idioma);
            this.Controls.Add(this.combobox_sala);
            this.Controls.Add(this.combobox_dimension);
            this.Controls.Add(this.combobox_turno);
            this.Controls.Add(this.combobox_fecha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.combobox_pelicula);
            this.Controls.Add(this.title);
            this.Name = "FORM_FUNCIONES_UC";
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
        private System.Windows.Forms.ComboBox combobox_idioma;
        private System.Windows.Forms.ComboBox combobox_sala;
        private System.Windows.Forms.ComboBox combobox_dimension;
        private System.Windows.Forms.ComboBox combobox_turno;
        private System.Windows.Forms.DateTimePicker combobox_fecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox combobox_pelicula;
        private System.Windows.Forms.ComboBox combobox_sucursal;
        private System.Windows.Forms.Label label_sucursal;
        private System.Windows.Forms.Button back_pelicula;
    }
}
