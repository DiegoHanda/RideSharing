using System;

namespace Library;

public class Usuario
{   
    public string Nombre {get; set;}
    public string Apellido {get; set;}
    public string Cedula {get; set;}
    public int Calificacion {get; set;}

    public Usuario(string nombre, string apellido, string cedula, int calificacion)
    {
        Nombre=nombre;
        Apellido=apellido;
        Cedula=cedula;
        Calificacion=calificacion;
    }
        public override string ToString()
    {
        return $"{Nombre} {Apellido} {Cedula} {Calificacion}" ;
    }
}