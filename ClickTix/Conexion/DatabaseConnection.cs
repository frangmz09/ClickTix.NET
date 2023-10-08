using System;
using System.Data.SqlClient;

public sealed class DatabaseConnection
{
    private static DatabaseConnection instance = null;
    private SqlConnection connection = null;

    private DatabaseConnection()
    {
        // Configura la cadena de conexión a la base de datos
        string connectionString = "TuCadenaDeConexion";
        connection = new SqlConnection(connectionString);
    }

    public static DatabaseConnection Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new DatabaseConnection();
            }
            return instance;
        }
    }

    public SqlConnection Connection
    {
        get
        {
            return connection;
        }
    }

    public void OpenConnection()
    {
        if (connection.State != System.Data.ConnectionState.Open)
        {
            connection.Open();
        }
    }

    public void CloseConnection()
    {
        if (connection.State != System.Data.ConnectionState.Closed)
        {
            connection.Close();
        }
    }
}