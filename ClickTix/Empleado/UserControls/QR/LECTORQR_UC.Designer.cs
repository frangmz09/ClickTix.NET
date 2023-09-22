namespace ClickTix.Empleado.UserControls
{
    partial class LECTORQR_UC
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
            this.label_qr = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.title_qr = new System.Windows.Forms.Label();
            this.iniciar_scaneo = new System.Windows.Forms.Button();
            this.detener_scaneo = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.SuspendLayout();
            // 
            // label_qr
            // 
            this.label_qr.AutoSize = true;
            this.label_qr.Location = new System.Drawing.Point(118, 84);
            this.label_qr.Name = "label_qr";
            this.label_qr.Size = new System.Drawing.Size(183, 13);
            this.label_qr.TabIndex = 0;
            this.label_qr.Text = "Seleccione la cámara para escanear:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(121, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // title_qr
            // 
            this.title_qr.AutoSize = true;
            this.title_qr.Font = new System.Drawing.Font("Roboto Bk", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_qr.Location = new System.Drawing.Point(302, 41);
            this.title_qr.Name = "title_qr";
            this.title_qr.Size = new System.Drawing.Size(208, 24);
            this.title_qr.TabIndex = 67;
            this.title_qr.Text = "ECANEAR CODIGO QR";
            this.title_qr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iniciar_scaneo
            // 
            this.iniciar_scaneo.Location = new System.Drawing.Point(121, 127);
            this.iniciar_scaneo.Name = "iniciar_scaneo";
            this.iniciar_scaneo.Size = new System.Drawing.Size(75, 23);
            this.iniciar_scaneo.TabIndex = 68;
            this.iniciar_scaneo.Text = "Iniciar";
            this.iniciar_scaneo.UseVisualStyleBackColor = true;
            // 
            // detener_scaneo
            // 
            this.detener_scaneo.Location = new System.Drawing.Point(202, 127);
            this.detener_scaneo.Name = "detener_scaneo";
            this.detener_scaneo.Size = new System.Drawing.Size(75, 23);
            this.detener_scaneo.TabIndex = 69;
            this.detener_scaneo.Text = "Detener";
            this.detener_scaneo.UseVisualStyleBackColor = true;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // LECTORQR_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.detener_scaneo);
            this.Controls.Add(this.iniciar_scaneo);
            this.Controls.Add(this.title_qr);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_qr);
            this.Name = "LECTORQR_UC";
            this.Size = new System.Drawing.Size(800, 451);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_qr;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label title_qr;
        private System.Windows.Forms.Button iniciar_scaneo;
        private System.Windows.Forms.Button detener_scaneo;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}
