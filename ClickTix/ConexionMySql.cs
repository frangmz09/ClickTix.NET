using System;


public class ConexionMySql : Conexion
{
	
	private MySqlConnection connection;
	private string cadenaConexion;
	public ConexionMySql()
	{
		cadenaConexion = "Database=" + database +
			";DataSource=" + server +
			";User Id= " + user +
			";Password=" + password;

		connection = new MySqlConnection(cadenaConexion);
	}

	public MySqlConnection getConnection()
	{
		try
		{ 
			if (connection.State != System.Data.ConnectionState.Open)
			{
				conection.Open();
			}
		} 
		
		catch(Exception e)
		{
			MessageBox.show(e.ToString());
		}
		return connection;
	}


}
