using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

public class ConexionMySql : Conexion
{
	
	private MySqlConnection connection;
	private string cadenaConexion;
	public ConexionMySql()
	{
        cadenaConexion = "Server=" + server +
                 ";Database=" + database +
                 ";User Id=" + user +
                 ";Password=" + password;

        connection = new MySqlConnection(cadenaConexion);
	}

	public MySqlConnection getConnection()
	{
		try
		{ 
			if (connection.State != System.Data.ConnectionState.Open)
			{
				connection.Open();
			}
		} 
		
		catch(Exception e)
		{
			MessageBox.Show(e.ToString());
		}
		return connection;
	}


}
