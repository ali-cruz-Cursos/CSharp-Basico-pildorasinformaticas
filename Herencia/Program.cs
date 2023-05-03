using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {

            // Implicitamente todos los objetos heredan de la clase object
            // super clase, clase cosmica

            Caballo Mustang = new Caballo("Pony");

            Humano Ali = new Humano("Sara");

            Gorila KingKon = new Gorila("Gorila1");

            Mustang.Galopar();

            Ali.GetNombre();


            Mamiferos mamifero1 = new Caballo("Caballo1");
            mamifero1.Respirar();


            Caballo caballo2 = new Caballo("CuartoDeMilla");

            IMamiferosTerrestres ICaballo2 = caballo2;


            mamifero1 = caballo2;

            Object miAnimal = new Caballo("Pinto");

            Caballo[] almacenCaballos = new Caballo[3];

            almacenCaballos[0] = caballo2;
            //almacenCaballos[1] = KingKon; // Error

            Mamiferos[] almacenMamiferos = new Mamiferos[2];

            almacenMamiferos[0] = Ali;
            almacenMamiferos[1] = Mustang;


            almacenMamiferos[1].GetNombre();


            Ali.Pensar();

            caballo2.Pensar();

            mamifero1.Pensar();

            Console.WriteLine("Recorro almacenMamiferos");
            foreach (Mamiferos obj in almacenMamiferos)
            {
                obj.Pensar();
            }


            Ballena miBallena = new Ballena("Wally");
            miBallena.Nadar();
            Console.WriteLine("Patas: " + ICaballo2.NumeroPatas());

            
            // Interfaces II Video 49
            // Pueden existir diferentes metodos con la misma firma en diferentes interfaces

            // Interfaces II Video 50
            // No se permiten constructores en Interfaz
            // No se deben especificar tipos de datos.


                

            
        }
    } 

 
}
