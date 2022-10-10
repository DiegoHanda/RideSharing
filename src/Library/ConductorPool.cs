using System;

namespace Library;

public class ConductorPool:Conductor
{   
    public int Disponible {get; set;}
    public ConductorPool(string nombre, string apellido, string cedula, int calificacion,string vehiculo, string biografia, int disponible) : base(nombre, apellido, cedula, calificacion, vehiculo, biografia)
    {
        Disponible=disponible;
    }
        public override string ToString()
    {
        return $"{Nombre} {Apellido} {Cedula} {Calificacion} {Vehiculo} {Biografia} {Disponible}" ;
    }
}