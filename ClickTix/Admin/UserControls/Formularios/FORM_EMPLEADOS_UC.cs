using ClickTix.Conexion;
using ClickTix.Modelo;
using ClickTix.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix
{
    public partial class FORM_EMPLEADOS_UC : UserControl
    {
        internal static DialogResult showdialog;
        private Usuario usuario;

        public DialogResult Dialogresult { get; private set; }

        public FORM_EMPLEADOS_UC()
        {
            InitializeComponent();

            input_sucursal.Items.Clear();

            input_sucursal.Items.Add(0);
            input_sucursal.Items.Add(1);
            input_sucursal.Items.Add(2);
        }

        private void back_pelicula_Click(object sender, EventArgs e)
        {
            ABM_EMPLEADOS_UC abmempleados = new ABM_EMPLEADOS_UC();
            Index_Admin.addUserControl(abmempleados);
        }

        private void addempleado_btn_Click(object sender, EventArgs e)
        {
            int sucursal = 0;

            Usuario usuario = null;

            if (input_sucursal.SelectedIndex ==0)
            {
                usuario = new Usuario(0, input_nombre.Text, input_apellido.Text, input_contraseña.Text, 0, input_usuario.Text, 0);
                sucursal = 0;
               
            }
            

            
            if (Usuario_Controller.crearUsuario(usuario))
            {
                this.Dialogresult = DialogResult.OK;
            }
        }

        private void input_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        internal static DialogResult Showdialog()
        {
            throw new NotImplementedException();
        }
    }
}
