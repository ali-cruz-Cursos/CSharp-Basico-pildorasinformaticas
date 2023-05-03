using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioVehiculos
{
    public class Avion : Vehiculo
    {
        private int CantidadGasolina;

        public void Volar()
        {
            Console.WriteLine("Estoy volando como Avion");
        }
        public override void Conducir()
        {
            Console.WriteLine("Conduzco como Avion");
        }
    }
}
