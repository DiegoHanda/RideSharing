using System;

namespace Library;

public class Conductor:Usuario
{   
    public string Vehiculo {get; set;}
    public string Biografia {get; set;}
    public Conductor(string nombre, string apellido, string cedula, int calificacion,string vehiculo, string biografia) : base(nombre, apellido, cedula, calificacion)
    {
        Vehiculo=vehiculo;
        Biografia=biografia;
    }
    public override string ToString()
    {
        return $"{Nombre} {Apellido} {Cedula} {Calificacion} {Vehiculo} {Biografia}" ;
    }

}