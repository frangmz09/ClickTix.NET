using ClickTix.Conexion;
using ClickTix.Empleado;
using ClickTix.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string usuario = txt_user.Text;
            string contraseña = txt_pw.Text;

           
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return; 
            }

            
            if (Usuario_Controller.autenticar(usuario, contraseña, true))
            {
                txt_pw.Text = "";
                txt_user.Text = "";
                if (Program.logeado.Is_admin == 1)
                {
                    Index_Admin index_Admin = new Index_Admin();
                    index_Admin.Show();
                }
                else
                {
                    Index_User index_User = new Index_User();
                    index_User.Show();
                }

                this.Hide(); 
            }
            else
            {
                
                MessageBox.Show("Usuario y/o contraseña incorrectos. Por favor, inténtelo de nuevo.");
            }
        }

        private void validarUsuario(string user, string pw)
        {
            Trace.WriteLine(user + " " + pw);
            txt_user.Text = user;
            txt_pw.Text = pw;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_pw_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
