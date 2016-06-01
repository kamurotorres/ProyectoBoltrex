using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Seccion
/// </summary>
public class Seccion
{
    private string UsuarioLogin;
    private string pass;
    private string permiso;
    private char estado;
    private int ccempleado;
	public Seccion()
	{
        UsuarioLogin = "";
        pass = "";
      
        
       
	}

    //metodos get*********************************************
 
    public string getUsername()
    {
        return  UsuarioLogin;
    }

    public string getClave()
    {
        return pass;
    }

    public string getPermisos()
    {
        return UsuarioLogin;
    }

    public char get_estado_secc()
    {
        return estado;
    }

    public int getccempleado()
    {
        return ccempleado;
    }
    //metodos set************************************************

    public void setUserName(string nuevoUser)
    {
        this.UsuarioLogin = nuevoUser;
    }
    public void setPass(string nuevoPass)
    {
        this.pass = nuevoPass;
    }
    public void setPermiso(string nuevoPermiso)
    {
        this.permiso = nuevoPermiso;
    }
    public void setEstado(char nuevoEstado)
    {
        this.estado = nuevoEstado;
    }
    public void setEmpleado(int nuevoEmpleado)
    {
        this.ccempleado = nuevoEmpleado;
    }
}