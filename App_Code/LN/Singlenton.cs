using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Singlenton
/// </summary>
public class Singlenton
{
    private static SqlConnection conexion;
    public static string datosc = "Data Source=.;Initial Catalog=makenjo;User ID=sa;Password=3112899501;";
	public Singlenton()
	{
		
	}
    private Singlenton() { }

    public static SqlConnection obtenerconexion()
    {
        if (conexion == null)
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = datosc;
            conexion.Open();
        }

        return conexion;
    }
}