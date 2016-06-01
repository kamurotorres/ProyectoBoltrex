using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

public partial class Paginas_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string user;
        string pass;

        user = txtUser.Text;
        pass = txtPass.Text;

        Constantes.conexion = Singlenton.obtenerconexion();
        Constantes.comando = new SqlCommand ();       
       
        Constantes.comando = new SqlCommand("SELECT logeoUser.username,logeoUser.pass from logeoUser where username='"+user+"' and pass'"+pass+"';",Constantes.conexion);
        int iuu = Constantes.comando.
        //Constantes.comando.CommandType = CommandType.StoredProcedure;
         Constantes.dr = Constantes.comando.ExecuteReader();
        // Data is accessible through the DataReader object here.

        Constantes.conexion.Close();
    }
}