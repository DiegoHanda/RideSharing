using System;
using System.Collections;
using Library;

namespace PII_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario pasajero1 = new Pasajero("Pepe","Álvarez","54912398",5);
            Usuario conductor1 = new Conductor("Brian","Mor","434543",3,"Ferrari","Montevideo");
            Conductor conductorPool1 = new ConductorPool("Jose","Raerera","48578391",3,"Onix","Montevideo",3);
            Console.WriteLine(conductor1);
            Console.WriteLine(pasajero1.Nombre);




            /*
            En éste método deberas mostrar un ejemplo de funcionamiento de tu programa an pseudocódigo. A continuación te 
            planteamos un ejemplo de como hacerlo. Esto no significa que te limites a hacer solamente esto, debes pensar 
            en grande!

            Usuario pasajero1 = nuevo Pasajero()
            Usuario pasajero2 = nuevo Pasajero()
            Usuario pasajero3 = nuevo Pasajero()
            Usuario conductor1 = nuevo Conductor()
            Usuario conductorPool1 = nuevo ConductorPool(maxPasajeros = 3)
            UcuRideShare rideShare = nuevo UcuRideShare()
            
            rideShare.Add(conductor1)
            Se publica en Twitter un nuevo conductor!

            rideShare.Add(conductorPool1)
            Se publica en Twitter un nuevo conductor!
            
            rideShare.Add(pasajero1)
            Se publica en Twitter nuevo registro de pasajero!
            
            rideShare.Add(pasajero2)
            Se publica en Twitter nuevo registro de pasajero!

            rideShare.Add(pasajero3)
            Se publica en Twitter nuevo registro de pasajero!

            */
        
        }
    }
}
