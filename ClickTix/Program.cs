using ClickTix.Conexion;
using ClickTix.Modelo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix
{
    internal static class Program
    {

        public static Usuario logeado;





        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
       static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ManagerConnection.getInstance();
            if (validateConnection())
            {
                Trace.WriteLine("Conexion a la base de datos establecida con exito");
            }
            Application.Run(new Login());
        }

        private static bool validateConnection()
        {
           try 
            {
                ManagerConnection.OpenConnection();
                ManagerConnection.CloseConnection();
                return true;
            } 
            catch (Exception ex)
            {
                Trace.WriteLine("Error al conectar a la base de datos: " + ex.Message);

                return false;
            }
        }
    }
}
