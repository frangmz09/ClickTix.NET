using ClickTix.Conexion;
using ClickTix.Modelo;
using Firebase.Storage;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickTix
{
    internal static class Program
    {

        public static Usuario logeado;
        public static Login login ;
        public static FirebaseStorage storage;



        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
       static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ManagerConnection.getInstance();
            string rutaCredenciales = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "FirebaseCredentials\\clicktixmobile-firebase-adminsdk-vl0f0-d2cf63174e.json");
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", rutaCredenciales);

            var options = new FirebaseStorageOptions
            {
                AuthTokenAsyncFactory = () => Task.FromResult(File.ReadAllText(rutaCredenciales))
            };

            Program.storage = new FirebaseStorage("clicktixmobile.appspot.com", options);


            if (validateConnection()== true)
            {
                Trace.WriteLine("Conexion a la base de datos establecida con exito");
                Funcion_Controller.validarAsientosaBorrar();
                Application.Run(login = new Login());

            }
            else
            {
                MessageBox.Show("La conexion a la Base de Datos no se pudo establecer, no podrá utilizar ClickTix ");
            }
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
