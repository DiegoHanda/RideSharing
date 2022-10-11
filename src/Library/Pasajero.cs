using System;
using System.Collections.Generic;

namespace Library;

public class Pasajero:Usuario
{   
    public static List<string> listap =new List<string>();
    public Pasajero(string nombre, string apellido, string cedula, int calificacion) : base(nombre, apellido, cedula, calificacion)
    {
    }
    public override string ToString()
    {
        string str = $"{Nombre} {Apellido} {Cedula} {Calificacion}";
        listap.Add(str);
        return str ;
    }
}