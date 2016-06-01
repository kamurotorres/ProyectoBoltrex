using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


/// <summary>
/// Descripción breve de DaosCliente
/// </summary>
public class DaosCliente
{
    
	public DaosCliente()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}

    

    public bool guardarRegistro()
    {
        try
        {
           
            
            return true;
        }
        catch (Exception ex)
        {
            //conectar.Close();
            //Show(ex.Message);
            //throw;
            
            return false;
        }
    }
}