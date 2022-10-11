using System;
using System.Collections.Generic;

namespace Library;

public class Usuario
{   
    public string Nombre {get; set;}
    public string Apellido {get; set;}
    public string Cedula {get; set;}
    public int Calificacion {get; set;}
    public static List<string> Usuarios=new List<string>();

    public Usuario(string nombre, string apellido, string cedula, int calificacion)
    {
        Nombre=nombre;
        Apellido=apellido;
        Cedula=cedula;
        Calificacion=calificacion;
    }

    
}