namespace ClickTix
{
    partial class Login
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(56, 47);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(174, 20);
            this.txt_user.TabIndex = 0;
            this.txt_user.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_pw
            // 
            this.txt_pw.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_pw.Location = new System.Drawing.Point(56, 111);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.Size = new System.Drawing.Size(174, 20);
            this.txt_pw.TabIndex = 1;
            this.txt_pw.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "USUARIO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CONTRASEÑA";
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_login.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_login.Location = new System.Drawing.Point(61, 166);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(163, 62);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Iniciar Sesion";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_pw);
            this.groupBox1.Controls.Add(this.txt_user);
            this.groupBox1.Location = new System.Drawing.Point(235, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

