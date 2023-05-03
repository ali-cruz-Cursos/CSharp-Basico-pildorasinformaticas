using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioVehiculos
{
    class Program
    {
        static void Main(string[] args)
        {

            Avion avion1 = new Avion();

            avion1.ArrancarMotor();
            avion1.Conducir();
            avion1.PararMotor();

            Console.WriteLine("--------------------");

            Coche coche1 = new Coche();
            coche1.ArrancarMotor();
            coche1.Conducir();
            coche1.PararMotor();

            Vehiculo vehiculoEspecial = coche1;

            vehiculoEspecial.Conducir();

            vehiculoEspecial = avion1;

            vehiculoEspecial.Conducir();
        }
    }
}
