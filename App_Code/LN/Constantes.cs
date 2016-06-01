using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de Constantes
/// </summary>
public class Constantes
{
    public static SqlConnection conexion;
    public static SqlDataAdapter da;
    public static SqlCommand comando;
    public static SqlParameter[] parametro;
    public static DataSet ds;
    public static SqlDataReader dr;
    public static int controlLista, controlSalvar;
    //public static string modo = "Actualizar";
	public Constantes()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}
}