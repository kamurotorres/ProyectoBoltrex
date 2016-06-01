using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de DaoLogin
/// </summary>
public class DaoLogin
{

    
    private string userName;
    private string pass;
    private char estado;

    //constructor
    public DaoLogin()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
   
    //metodos get*********************************************
    
    public string get_nom_secc()
    {
        return userName;
    }

    public char get_estado_secc()
    {
        return estado;
    }
    //metodos set************************************************

   
    public void set_nom_secc(string nuevo_nom_secc)
    {
        this.userName = nuevo_nom_secc;
    }
    public void set_estado_secc(char nuevo_estado_secc)
    {
        this.estado = nuevo_estado_secc;
    }
    public bool guardarRegistro()
    {
        try
        {


            Constantes.conexion = Singlenton.obtenerconexion();
            Constantes.comando = new SqlCommand("pa_insertar", Constantes.conexion);
            Constantes.comando.CommandType = CommandType.StoredProcedure;
            Constantes.parametro[0] = new SqlParameter("@user", SqlDbType.VarChar, (30));
            Constantes.parametro[0].Value = this.nom_Secc;
            Constantes.parametro[1] = new SqlParameter("@pass", SqlDbType.VarChar, (30));
            Constantes.parametro[1].Value = this.pass;
            Constantes.comando.Parameters.Add(Constantes.parametro[0]);
            Constantes.comando.Parameters.Add(Constantes.parametro[1]);
            Constantes.comando.ExecuteNonQuery();
            Constantes.conexion.Close();
            Constantes.conexion.Dispose();
            Constantes.comando.Dispose();

            Constantes.message += " ** inserto bien esa monda ** ";
            return true;
        }
        catch (Exception ex)
        {
            //conectar.Close();
            //Show(ex.Message);
            //throw;
            Constantes.message += "  " + ex.Message;
            return false;
        }
    }
}