using System;
using System.Collections.Generic;

namespace Library;

public class Conductor:Usuario
{   
    public string Vehiculo {get; set;}
    public string Biografia {get; set;}
    public static List<string> listac =new List<string>();
    public Conductor(string nombre, string apellido, string cedula, int calificacion,string vehiculo, string biografia) : base(nombre, apellido, cedula, calificacion)
    {
        Vehiculo=vehiculo;
        Biografia=biografia;
        string str = $"{Nombre} {Apellido} {Cedula} {Calificacion} {Vehiculo} {Biografia}";
        listac.Add(str);
    }
    public override string ToString()
    {
        return $"{Nombre} {Apellido} {Cedula} {Calificacion} {Vehiculo} {Biografia}";
    }

}