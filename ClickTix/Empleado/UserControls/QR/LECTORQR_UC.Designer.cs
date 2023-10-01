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
            this.components = new System.ComponentModel.Container();
            this.label_qr = new System.Windows.Forms.Label();
            this.combobox_camara = new System.Windows.Forms.ComboBox();
            this.title_qr = new System.Windows.Forms.Label();
            this.iniciar_scaneo = new System.Windows.Forms.Button();
            this.detener_scaneo = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_qr
            // 
            this.label_qr.AutoSize = true;
            this.label_qr.Location = new System.Drawing.Point(118, 141);
            this.label_qr.Name = "label_qr";
            this.label_qr.Size = new System.Drawing.Size(183, 13);
            this.label_qr.TabIndex = 0;
            this.label_qr.Text = "Seleccione la cámara para escanear:";
            // 
            // combobox_camara
            // 
            this.combobox_camara.FormattingEnabled = true;
            this.combobox_camara.Location = new System.Drawing.Point(121, 157);
            this.combobox_camara.Name = "combobox_camara";
            this.combobox_camara.Size = new System.Drawing.Size(177, 21);
            this.combobox_camara.TabIndex = 1;
            this.combobox_camara.SelectedIndexChanged += new System.EventHandler(this.combobox_camara_SelectedIndexChanged);
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
            this.iniciar_scaneo.Location = new System.Drawing.Point(121, 184);
            this.iniciar_scaneo.Name = "iniciar_scaneo";
            this.iniciar_scaneo.Size = new System.Drawing.Size(75, 23);
            this.iniciar_scaneo.TabIndex = 68;
            this.iniciar_scaneo.Text = "Iniciar";
            this.iniciar_scaneo.UseVisualStyleBackColor = true;
            this.iniciar_scaneo.Click += new System.EventHandler(this.iniciar_scaneo_Click);
            // 
            // detener_scaneo
            // 
            this.detener_scaneo.Location = new System.Drawing.Point(202, 184);
            this.detener_scaneo.Name = "detener_scaneo";
            this.detener_scaneo.Size = new System.Drawing.Size(75, 23);
            this.detener_scaneo.TabIndex = 69;
            this.detener_scaneo.Text = "Detener";
            this.detener_scaneo.UseVisualStyleBackColor = true;
            this.detener_scaneo.Click += new System.EventHandler(this.detener_scaneo_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "codigo escaneado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(382, 84);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(347, 302);
            this.videoSourcePlayer1.TabIndex = 72;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 248);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 20);
            this.textBox1.TabIndex = 73;
            // 
            // LECTORQR_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.detener_scaneo);
            this.Controls.Add(this.iniciar_scaneo);
            this.Controls.Add(this.title_qr);
            this.Controls.Add(this.combobox_camara);
            this.Controls.Add(this.label_qr);
            this.Name = "LECTORQR_UC";
            this.Size = new System.Drawing.Size(800, 451);
            this.Load += new System.EventHandler(this.LECTORQR_UC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_qr;
        private System.Windows.Forms.ComboBox combobox_camara;
        private System.Windows.Forms.Label title_qr;
        private System.Windows.Forms.Button iniciar_scaneo;
        private System.Windows.Forms.Button detener_scaneo;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
