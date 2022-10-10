using System;

namespace Library;

public class Pasajero:Usuario
{   

    public Pasajero(string nombre, string apellido, string cedula, int calificacion) : base(nombre, apellido, cedula, calificacion)
    {
    }
}