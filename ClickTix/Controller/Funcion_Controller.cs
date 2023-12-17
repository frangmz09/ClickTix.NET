using ClickTix.Conexion;
using iTextSharp.tool.xml.html.head;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.PDF417.Internal;

namespace ClickTix.Modelo
{
    public class Funcion_Controller
    {
        public static List<Funcion> obtenerTodos()
        {
            List<Funcion> funciones = new List<Funcion>();
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                ManagerConnection.OpenConnection();
                string query = "SELECT id, fecha, id_dimension, id_pelicula, id_sala, idioma_funcion, turno_id FROM funcion";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Funcion funcion = new Funcion();

                            funcion.Id = reader.GetInt32("id");
                            funcion.Id_Dimension = reader.GetInt32("id_dimension");
                            funcion.Id_Sala = reader.GetInt32("id_sala");
                            funcion.Id_Pelicula= reader.GetInt32("id_pelicula");
                            funcion.Id_Idioma = reader.GetInt32("idioma_funcion");
                            funcion.Fecha = reader.GetDateTime("fecha");
                            funcion.Id_Turno = reader.GetInt32("turno_id");

                            funciones.Add(funcion);
                        }
                    }
                }
                ManagerConnection.CloseConnection();

            }

            return funciones;
        }


        public static List<Funcion> obtenerTodosCartelera(string titulo)
        {
            List<Funcion> funciones = new List<Funcion>();
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                ManagerConnection.OpenConnection();

                string query = "select  funcion.id, sala.nro_sala , dimension.dimension, idioma.idioma, dimension.precio, funcion.fecha, turno.hora from funcion left join sala on funcion.id_sala = sala.id left join pelicula on funcion.id_pelicula = pelicula.id left join dimension on funcion.id_dimension = dimension.id left join idioma  on funcion.idioma_funcion = idioma.id left join turno on funcion.turno_id = turno.id where pelicula.titulo = @tituloP and sala.id_sucursal = @id_sucursal and funcion.fecha > NOW();";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@tituloP", titulo);
                    command.Parameters.AddWithValue("@id_sucursal", Program.logeado.Id_sucursal);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Funcion funcion = new Funcion();

                            funcion.Id = reader.GetInt32("id");
                            funcion.nroSala = reader.GetInt32("nro_sala");
                            funcion.dimension = reader.GetString("dimension");
                            funcion.idioma = reader.GetString("idioma");
                            funcion.precio = reader.GetDecimal("precio");
                            funcion.Fecha = reader.GetDateTime("fecha");
                            funcion.hora = reader.GetTimeSpan("hora");

                            funciones.Add(funcion);
                        }
                    }
                }
                ManagerConnection.CloseConnection();

            }

            return funciones;
        }

        public static List<Funcion> obtenerTodosPorSucursal()
        {
            List<Funcion> funciones = new List<Funcion>();
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                ManagerConnection.OpenConnection();

                string query = "select  funcion.id, pelicula.titulo, sala.nro_sala , dimension.dimension, idioma.idioma, dimension.precio, funcion.fecha, turno.hora from funcion left join sala on funcion.id_sala = sala.id left join pelicula on funcion.id_pelicula = pelicula.id left join dimension on funcion.id_dimension = dimension.id left join idioma  on funcion.idioma_funcion = idioma.id left join turno on funcion.turno_id = turno.id where sala.id_sucursal = @id_sucursal and funcion.fecha > NOW();";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@id_sucursal", Program.logeado.Id_sucursal);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Funcion funcion = new Funcion();

                            funcion.Id = reader.GetInt32("id");
                            funcion.peliculaNombre = reader.GetString("titulo");
                            funcion.nroSala = reader.GetInt32("nro_sala");
                            funcion.dimension = reader.GetString("dimension");
                            funcion.idioma = reader.GetString("idioma");
                            funcion.precio = reader.GetDecimal("precio");
                            funcion.Fecha = reader.GetDateTime("fecha");
                            funcion.hora = reader.GetTimeSpan("hora");

                            funciones.Add(funcion);
                        }
                    }
                }
                ManagerConnection.CloseConnection();

            }

            return funciones;
        }
        public static List<string> obtenerTodosTitulosPorSucursal()
        {
            List<string> peliculas = new List<string>();
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                ManagerConnection.OpenConnection();

                string query = "select pelicula.titulo from funcion left join sala on funcion.id_sala = sala.id left join pelicula on funcion.id_pelicula = pelicula.id left join dimension on funcion.id_dimension = dimension.id left join idioma  on funcion.idioma_funcion = idioma.id left join turno on funcion.turno_id = turno.id where sala.id_sucursal = @id_sucursal and funcion.fecha > NOW() group by pelicula.titulo;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@id_sucursal", Program.logeado.Id_sucursal);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            string nombre = reader.GetString("titulo");


                            peliculas.Add(nombre);
                        }
                    }
                }
                ManagerConnection.CloseConnection();

            }

            return peliculas;
        }
        
        public static List<string> obtenerTodasFechasPorSucursal()
        {
            List<string> fechas = new List<string>();
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                ManagerConnection.OpenConnection();

                string query = "select funcion.fecha from funcion left join sala on funcion.id_sala = sala.id left join pelicula on funcion.id_pelicula = pelicula.id left join dimension on funcion.id_dimension = dimension.id left join idioma  on funcion.idioma_funcion = idioma.id left join turno on funcion.turno_id = turno.id where sala.id_sucursal = @id_sucursal and funcion.fecha > NOW() group by funcion.fecha;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@id_sucursal", Program.logeado.Id_sucursal);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            DateTime fecha = reader.GetDateTime("fecha");


                            fechas.Add(fecha.ToString());
                        }
                    }
                }
                ManagerConnection.CloseConnection();

            }

            return fechas;
        }
        public static List<Funcion> obtenerPorFiltros(Dictionary<string, object> filtros)
        {
            List<Funcion> funciones = obtenerTodosPorSucursal();

            // Filtrar la lista según los parámetros proporcionados en el diccionario
            foreach (var filtro in filtros)
            {
                switch (filtro.Key)
                {
                    case "Titulo":
                        funciones = funciones.Where(funcion => funcion.peliculaNombre == (string)filtro.Value).ToList();
                        break;
                    case "Fecha":
                        funciones = funciones.Where(funcion => funcion.Fecha == (DateTime)filtro.Value).ToList();
                        break;
                    case "Dimension":
                        funciones = funciones.Where(funcion => funcion.dimension == (string)filtro.Value).ToList();
                        break;
                }
            }

            return funciones;
        }

        public static List<string> obtenerTodasDimensionesPorSucursal()
        {
            List<string> dimensiones = new List<string>();
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                ManagerConnection.OpenConnection();

                string query = "select dimension.dimension from funcion left join sala on funcion.id_sala = sala.id left join pelicula on funcion.id_pelicula = pelicula.id left join dimension on funcion.id_dimension = dimension.id left join idioma  on funcion.idioma_funcion = idioma.id left join turno on funcion.turno_id = turno.id where sala.id_sucursal = @id_sucursal and funcion.fecha > NOW() group by dimension.dimension;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@id_sucursal", Program.logeado.Id_sucursal);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            string dimension = reader.GetString("dimension");


                            dimensiones.Add(dimension);
                        }
                    }
                }
                ManagerConnection.CloseConnection();

            }

            return dimensiones;
        }
        public static void llenarCamposAddFuncion(ComboBox peliculas, ComboBox turnos, ComboBox sucursal, ComboBox dimension,ComboBox idioma) {
            llenarPeliculas(peliculas);
            llenarTurnos(turnos);
            llenarSucursales(sucursal);
            llenarDimensiones(dimension);
            llenarIdiomas(idioma);
        }

        public static string ObtenerHorarioPorID(int idTurno)
        {
            string horario = "";
            ManagerConnection.OpenConnection();
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                string query = "SELECT hora FROM turno WHERE id = @idTurno";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@idTurno", idTurno);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        horario = result.ToString();
                    }
                }
            }
            ManagerConnection.CloseConnection();

            return horario;

        }


        private static void llenarPeliculas(ComboBox combobox_pelicula)
        {
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                mysqlConnection.Open();
                string query = "SELECT * FROM pelicula;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        combobox_pelicula.Items.Add(reader.GetString(1));
                    }

                    reader.Close();
                }
                mysqlConnection.Close();
            }
        }

        public static int obtenerIdPelicula(ComboBox combobox_pelicula) {

            int idReturn=0;

            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                mysqlConnection.Open();
                string query = "SELECT id FROM pelicula where titulo=@nombre_seleccionado;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@nombre_seleccionado",combobox_pelicula.Text.ToString());
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        idReturn = reader.GetInt32(0);
                    }

                    reader.Close();
                }
                mysqlConnection.Close();
            }
            return idReturn;
        }



        public static int obtenerIdIdioma(ComboBox combobox_idioma) {
            int idReturn = 0;
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                mysqlConnection.Open();
                string query = "SELECT id FROM idioma where idioma=@idioma_seleccionado;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@idioma_seleccionado", combobox_idioma.Text.ToString());
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        idReturn = reader.GetInt32(0);
                    }

                    reader.Close();
                }
                mysqlConnection.Close();
            }
            return idReturn;        
        }

        public static int obtenerIdDimension(ComboBox combobox_dimension)
        {
            int idReturn = 0;
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                ManagerConnection.OpenConnection();
                string query = "SELECT id FROM dimension where dimension=@dimension_seleccionada;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@dimension_seleccionada", combobox_dimension.Text.ToString());
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        idReturn = reader.GetInt32(0);
                    }

                    reader.Close();
                }
                ManagerConnection.CloseConnection();
            }
            return idReturn;
        }

        public static double obtenerPrecioFuncion(int idFuncion)
        {
            double valorRetorno = 0;
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                ManagerConnection.OpenConnection();
                string query = "select dimension.precio from funcion inner join dimension on funcion.id_dimension = dimension.id where funcion.id = @id_funcion";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@id_funcion", idFuncion);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        valorRetorno = reader.GetDouble(0);
                    }

                    reader.Close();
                }
                ManagerConnection.CloseConnection();
            }
            return valorRetorno;
        }

        public static int ObtenerIdTurno(ComboBox combobox_turno)
        {
            int idReturn = 0;

            try
            {
                using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
                {
                    mysqlConnection.Open();
                    string query = "SELECT id FROM turno WHERE hora = @fecha_seleccionada;";

                    using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                    {
                        if (combobox_turno != null && combobox_turno.Enabled == true)
                        {
                            command.Parameters.AddWithValue("@fecha_seleccionada", combobox_turno.Text.ToString());

                        }

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                idReturn = reader.GetInt32(0);
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                
                Console.WriteLine("Error de base de datos: " + ex.Message);
            }

            return idReturn;
        }
        public static string ObtenerIdiomaFuncion(int idFuncion)
        {
            ManagerConnection.OpenConnection();
            string idioma = "";
            string query = "SELECT idioma FROM idioma WHERE id = @idFuncion";

            MySqlCommand cmd = new MySqlCommand(query, ManagerConnection.getInstance());
            cmd.Parameters.AddWithValue("@idFuncion", idFuncion);

            try
            {
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    idioma = Convert.ToString(result);
                }

                return idioma;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el idioma: " + ex.Message);
            }
            finally
            {
                ManagerConnection.CloseConnection();
            }
        }
        public static int obtenerIdSala(ComboBox combobox_sala, ComboBox combobox_sucursal) { 

            int idReturn =0;

            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                mysqlConnection.Open();
                string query = "select nro_sala, sala.id from sucursal " +
                    "inner join sala " +
                    "on sucursal.id = sala.id_sucursal " +
                    "where sucursal.nombre = @nombre_sucursal and sala.nro_sala=@sala_seleccionada;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@nombre_sucursal", combobox_sucursal.Text.ToString());
                    command.Parameters.AddWithValue("@sala_seleccionada", combobox_sala.SelectedItem);

                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        idReturn = reader.GetInt32(1);
                    }

                    reader.Close();
                }
                mysqlConnection.Close();
            }

            return idReturn;
        }


        public static int obtenerIdSalaporFuncion(int idFuncion)
        {

            int idReturn = 0;

            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                mysqlConnection.Open();
                string query = "select id_sala from funcion where id = @idFuncion";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@idFuncion", idFuncion);

                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        idReturn = reader.GetInt32(0);
                    }

                    reader.Close();
                }
                mysqlConnection.Close();
            }

            return idReturn;
        }
        public static void llenarSalas(ComboBox combobox_sucursal, ComboBox combobox_sala)
        {
            combobox_sala.Items.Clear();
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                mysqlConnection.Open();
                string query = "select nro_sala from sucursal " +
                    "inner join sala " +
                    "on sucursal.id = sala.id_sucursal " +
                    "where sucursal.nombre = @nombre_sucursal;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@nombre_sucursal", combobox_sucursal.Text.ToString());

                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        combobox_sala.Items.Add(reader.GetInt32(0));
                    }

                    reader.Close();
                }
                mysqlConnection.Close();
            }
            combobox_sala.Enabled = true;
        }

        private static void llenarTurnos(ComboBox combobox_turno) {
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                mysqlConnection.Open();
                string query = "SELECT * FROM turno;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        combobox_turno.Items.Add(reader.GetTimeSpan(1));
                    }

                    reader.Close();
                }
                mysqlConnection.Close();
            }
        }



        public static void LlenarTurnos(ComboBox combobox_turno, List<int> turnos)
        {
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                mysqlConnection.Open();

                
                if (turnos.Count > 0)
                {
                   
                    string parameters = string.Join(",", turnos);

                    string query = "SELECT hora FROM turno WHERE id IN (" + parameters + ");";

                    using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                    {
                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            combobox_turno.Items.Add(reader.GetTimeSpan(0));
                        }

                        reader.Close();
                    }
                }

                mysqlConnection.Close();
            }
        }














        public static string obtenerDimensionDesdeId(int idDimension)
        {
            ManagerConnection.OpenConnection();
            string dimension = "";
            string query = "SELECT dimension FROM dimension WHERE id = @idDimension";

            MySqlCommand cmd = new MySqlCommand(query, ManagerConnection.getInstance());
            cmd.Parameters.AddWithValue("@idDimension", idDimension);

            try
            {
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    dimension = Convert.ToString(result);
                }

                return dimension;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el idioma: " + ex.Message);
            }
            finally
            {
                ManagerConnection.CloseConnection();
            }
        }

        public static string obtenerSucursalDesdeIdSala(int idSala)
        {
            ManagerConnection.OpenConnection();
            string dimension = "";
            string query = "select nombre from sala inner join sucursal on sala.id_sucursal = sucursal.id where sala.id = @idSala";

            MySqlCommand cmd = new MySqlCommand(query, ManagerConnection.getInstance());
            cmd.Parameters.AddWithValue("@idSala", idSala);

            try
            {
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    dimension = Convert.ToString(result);
                }

                return dimension;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el idioma: " + ex.Message);
            }
            finally
            {
                ManagerConnection.CloseConnection();
            }
        }









        public static List<int> ObtenerTodosLosIdsDeTurno()
        {
            List<int> idsDeTurno = new List<int>();

            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                mysqlConnection.Open();
                string query = "SELECT id FROM turno;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0)) // Verifica si el campo no es nulo
                            {
                                int idTurno = reader.GetInt32(0);
                                idsDeTurno.Add(idTurno);
                            }
                        }
                    }
                }
                mysqlConnection.Close();
            }

            return idsDeTurno;
        }


        public static List<int> ObtenerTurnosPorPeliculaYSala(int idPelicula, int idSala)
        {
            List<int> turnos = new List<int>();

            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                mysqlConnection.Open();

                string query = "SELECT turno_id " +
                               "FROM funcion " +
                               "WHERE id_pelicula = @IdPelicula AND id_sala = @IdSala";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@IdPelicula", idPelicula);
                    command.Parameters.AddWithValue("@IdSala", idSala);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                int turno = reader.GetInt32(0);
                                turnos.Add(turno);
                            }
                        }
                    }
                }
            }

            return turnos;
        }


        public static int ObtenerIdSucursalPorIdSala(int idSala)
        {
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                mysqlConnection.Open();
                string query = "SELECT s.id_sucursal FROM funcion f " +
                               "INNER JOIN sala s ON f.id_sala = s.id " +
                               "WHERE f.id_sala = @IdSala;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@IdSala", idSala);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        // Manejo de error o valor predeterminado si no se encuentra el registro.
                        return -1; // Por ejemplo, -1 podría indicar que no se encontró la sala.
                    }
                }
                mysqlConnection.Close();
            }
        }





        private static void llenarIdiomas(ComboBox combobox_idioma)
        {
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                mysqlConnection.Open();
                string query = "SELECT * FROM idioma;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        combobox_idioma.Items.Add(reader.GetString(1));
                    }

                    reader.Close();
                }
                mysqlConnection.Close();
            }
        }
        private static void llenarDimensiones(ComboBox combobox_dimension)
        {
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                mysqlConnection.Open();
                string query = "SELECT * FROM dimension;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        combobox_dimension.Items.Add(reader.GetString(1));
                    }

                    reader.Close();
                }
                mysqlConnection.Close();
            }
        }

        private static void llenarSucursales(ComboBox combobox_sucursal)
        {
            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                mysqlConnection.Open();
                string query = "SELECT * FROM sucursal where id <> 0;";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        combobox_sucursal.Items.Add(reader.GetString(1));
                    }

                    reader.Close();
                }
                mysqlConnection.Close();
            }
        }
        public static int crearFuncion(Funcion funcion)
        {

            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                string consulta = "INSERT INTO funcion (id,fecha,id_dimension,id_sala,id_pelicula,idioma_funcion,turno_id) " +
                                  "VALUES (@id,@fecha,@id_dimension,@id_sala,@id_pelicula,@idioma_funcion,@turno_id)";
                    int id = GetMaxIDFuncion()+1;
                    using (MySqlCommand cmd = new MySqlCommand(consulta, mysqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@fecha", funcion.Fecha);
                        cmd.Parameters.AddWithValue("@id_dimension", funcion.Id_Dimension);
                        cmd.Parameters.AddWithValue("@id_sala", funcion.Id_Sala);
                        cmd.Parameters.AddWithValue("@id_pelicula", funcion.Id_Pelicula);
                        cmd.Parameters.AddWithValue("@idioma_funcion", funcion.Id_Idioma);
                        cmd.Parameters.AddWithValue("@turno_id", funcion.Id_Turno);

                    ManagerConnection.OpenConnection();

                    cmd.ExecuteNonQuery();
                    }
                ManagerConnection.CloseConnection();

                return id;



            }


        }
        private static int GetMaxIDFuncion()
        {
            int maxID = -1;

            try
            {
                ManagerConnection.OpenConnection();

                string query = "SELECT MAX(id) FROM funcion";

                MySqlCommand command = new MySqlCommand(query, ManagerConnection.getInstance());
                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    maxID = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al obtener el ID máximo: " + ex.Message);
            }
            ManagerConnection.CloseConnection();


            return maxID;
        }


        public static void Funcion_Load(DataGridView tabla)
        {
            ManagerConnection.OpenConnection();

            string query = "SELECT id , fecha, id_dimension as dimension , id_pelicula as pelicula , id_sala as sala ,idioma_funcion as idioma" +
                ", turno_id as turno FROM funcion";

            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    tabla.DataSource = dt;
                }
            }
            ManagerConnection.CloseConnection();

        }

        public static bool EliminarRegistroFuncion(int id)
        {
            try
            {
                using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
                {
                    mysqlConnection.Open();

                    
                    string deleteAsientoQuery = "DELETE FROM asiento WHERE id_funcion = @id";
                    using (MySqlCommand deleteAsientoCommand = new MySqlCommand(deleteAsientoQuery, mysqlConnection))
                    {
                        deleteAsientoCommand.Parameters.AddWithValue("@id", id);
                        deleteAsientoCommand.ExecuteNonQuery();
                    }

                    
                    string deleteFuncionQuery = "DELETE FROM funcion WHERE id = @id";
                    using (MySqlCommand deleteFuncionCommand = new MySqlCommand(deleteFuncionQuery, mysqlConnection))
                    {
                        deleteFuncionCommand.Parameters.AddWithValue("@id", id);
                        int rowsAffected = deleteFuncionCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el registro a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede borrar esta funcion, ya hay cliente que reservaron asientos para la misma: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                ManagerConnection.CloseConnection();
            }
        }



        public static bool ActualizarFuncion(Funcion funcion)


        {

            ManagerConnection.OpenConnection();
            string query = "UPDATE funcion " +
                           "SET fecha = @fecha,id_dimension = @id_dimension , id_pelicula=@id_pelicula  , id_sala=@id_sala  ,idioma_funcion = @idioma_funcion, turno_id =@turno_id WHERE id = @id";

            MySqlCommand cmd = new MySqlCommand(query, ManagerConnection.getInstance()); ;

            cmd.Parameters.AddWithValue("@id", funcion.Id);
            cmd.Parameters.AddWithValue("@fecha", funcion.Fecha);
            cmd.Parameters.AddWithValue("@id_dimension", funcion.Id_Dimension);
            cmd.Parameters.AddWithValue("@id_sala", funcion.Id_Sala);
            cmd.Parameters.AddWithValue("@id_pelicula", funcion.Id_Pelicula);
            cmd.Parameters.AddWithValue("@idioma_funcion", funcion.Id_Idioma);
            cmd.Parameters.AddWithValue("@turno_id", funcion.Id_Turno);

            try
            {

                int filasActualizadas = cmd.ExecuteNonQuery();


                return filasActualizadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la sucursal: " + ex.Message);
            }
            finally
            {
                ManagerConnection.CloseConnection();
            }
        }



        public static void validarAsientosaBorrar()
        {
            List<int> idsABorrar = new List<int>();
            ManagerConnection.OpenConnection();

            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                string query = "SELECT id FROM funcion WHERE fecha < NOW()";

                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int funcionId = reader.GetInt32(0);
                        idsABorrar.Add(funcionId);
                    }
                }
            }

            foreach (int id in idsABorrar)
            {
                Asiento_Controller.borrarAsientosDeFuncion(id);
            }

            ManagerConnection.CloseConnection();
        }




        public static Funcion buscarFuncionPorId(int idFuncion) {

            Funcion funcionAuxiliar = new Funcion();

            ManagerConnection.OpenConnection();

            string query = "select * from funcion where id=@id";

            using (MySqlConnection mysqlConnection = ManagerConnection.getInstance())
            {
                using (MySqlCommand command = new MySqlCommand(query, mysqlConnection))
                {
                    command.Parameters.AddWithValue("@id", idFuncion);

                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        funcionAuxiliar.Id = reader.GetInt32(0);
                        funcionAuxiliar.Fecha = reader.GetDateTime(1);
                        funcionAuxiliar.Id_Dimension = reader.GetInt32(2);
                        funcionAuxiliar.Id_Pelicula = reader.GetInt32(3);
                        funcionAuxiliar.Id_Sala = reader.GetInt32(4);
                        funcionAuxiliar.Id_Idioma = reader.GetInt32(5);
                        funcionAuxiliar.Id_Turno = reader.GetInt32(6);


                    }

                    reader.Close();

                }
            }
            ManagerConnection.CloseConnection();

            return funcionAuxiliar;
        }



















    }
}
