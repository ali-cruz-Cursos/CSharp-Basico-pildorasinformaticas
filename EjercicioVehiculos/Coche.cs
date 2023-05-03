using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioVehiculos
{
    public class Coche: Vehiculo
    {
        private int numeroRuedas;

        public void Rodar()
        {
            Console.WriteLine("Ruedo como un coche");
        }

        public override void Conducir()
        {
            Console.WriteLine("Conduzco como coche");
        }
    }
}
