namespace ClickTix.Empleado.UserControls
{
    partial class TICKET_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TICKET_UC));
            this.button1 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.nombre_pelicula_ticket = new System.Windows.Forms.Label();
            this.fila_ticket = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fecha_ticket = new System.Windows.Forms.Label();
            this.hora_ticket = new System.Windows.Forms.Label();
            this.precio_ticket = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.columna_ticket = new System.Windows.Forms.Label();
            this.nrosala_ticket = new System.Windows.Forms.Label();
            this.idioma_ticket = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(389, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Confirmar e Imprimir Ticket";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // nombre_pelicula_ticket
            // 
            this.nombre_pelicula_ticket.AutoSize = true;
            this.nombre_pelicula_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_pelicula_ticket.Location = new System.Drawing.Point(150, 103);
            this.nombre_pelicula_ticket.Name = "nombre_pelicula_ticket";
            this.nombre_pelicula_ticket.Size = new System.Drawing.Size(70, 25);
            this.nombre_pelicula_ticket.TabIndex = 2;
            this.nombre_pelicula_ticket.Text = "label1";
            // 
            // fila_ticket
            // 
            this.fila_ticket.AutoSize = true;
            this.fila_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fila_ticket.Location = new System.Drawing.Point(223, 214);
            this.fila_ticket.Name = "fila_ticket";
            this.fila_ticket.Size = new System.Drawing.Size(70, 25);
            this.fila_ticket.TabIndex = 4;
            this.fila_ticket.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fila:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pelicula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 42);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sala:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(142, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hora:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(142, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Precio:";
            // 
            // fecha_ticket
            // 
            this.fecha_ticket.AutoSize = true;
            this.fecha_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_ticket.Location = new System.Drawing.Point(223, 140);
            this.fecha_ticket.Name = "fecha_ticket";
            this.fecha_ticket.Size = new System.Drawing.Size(70, 25);
            this.fecha_ticket.TabIndex = 12;
            this.fecha_ticket.Text = "label8";
            // 
            // hora_ticket
            // 
            this.hora_ticket.AutoSize = true;
            this.hora_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora_ticket.Location = new System.Drawing.Point(223, 179);
            this.hora_ticket.Name = "hora_ticket";
            this.hora_ticket.Size = new System.Drawing.Size(70, 25);
            this.hora_ticket.TabIndex = 13;
            this.hora_ticket.Text = "label9";
            // 
            // precio_ticket
            // 
            this.precio_ticket.AutoSize = true;
            this.precio_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio_ticket.Location = new System.Drawing.Point(223, 291);
            this.precio_ticket.Name = "precio_ticket";
            this.precio_ticket.Size = new System.Drawing.Size(79, 25);
            this.precio_ticket.TabIndex = 14;
            this.precio_ticket.Text = "Precio:";
            this.precio_ticket.Click += new System.EventHandler(this.id_precio_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Columna:";
            // 
            // columna_ticket
            // 
            this.columna_ticket.AutoSize = true;
            this.columna_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columna_ticket.Location = new System.Drawing.Point(257, 252);
            this.columna_ticket.Name = "columna_ticket";
            this.columna_ticket.Size = new System.Drawing.Size(70, 25);
            this.columna_ticket.TabIndex = 15;
            this.columna_ticket.Text = "label3";
            // 
            // nrosala_ticket
            // 
            this.nrosala_ticket.AutoSize = true;
            this.nrosala_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrosala_ticket.Location = new System.Drawing.Point(191, 57);
            this.nrosala_ticket.Name = "nrosala_ticket";
            this.nrosala_ticket.Size = new System.Drawing.Size(70, 25);
            this.nrosala_ticket.TabIndex = 17;
            this.nrosala_ticket.Text = "label1";
            // 
            // idioma_ticket
            // 
            this.idioma_ticket.AutoSize = true;
            this.idioma_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idioma_ticket.Location = new System.Drawing.Point(439, 140);
            this.idioma_ticket.Name = "idioma_ticket";
            this.idioma_ticket.Size = new System.Drawing.Size(79, 25);
            this.idioma_ticket.TabIndex = 19;
            this.idioma_ticket.Text = "Precio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(358, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Idioma";
            // 
            // TICKET_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.idioma_ticket);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nrosala_ticket);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.columna_ticket);
            this.Controls.Add(this.precio_ticket);
            this.Controls.Add(this.hora_ticket);
            this.Controls.Add(this.fecha_ticket);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fila_ticket);
            this.Controls.Add(this.nombre_pelicula_ticket);
            this.Controls.Add(this.button1);
            this.Name = "TICKET_UC";
            this.Size = new System.Drawing.Size(800, 451);
            this.Load += new System.EventHandler(this.TICKET_UC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label nombre_pelicula_ticket;
        private System.Windows.Forms.Label fila_ticket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label fecha_ticket;
        private System.Windows.Forms.Label hora_ticket;
        private System.Windows.Forms.Label precio_ticket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label columna_ticket;
        private System.Windows.Forms.Label nrosala_ticket;
        private System.Windows.Forms.Label idioma_ticket;
        private System.Windows.Forms.Label label9;
    }
}
