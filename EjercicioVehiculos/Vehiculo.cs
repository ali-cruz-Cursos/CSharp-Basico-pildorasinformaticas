using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioVehiculos
{
    public class Vehiculo
    {
        private string Nombre;

        public void ArrancarMotor()
        {
            Console.WriteLine("Arranco Motor Vehiculo");
        }

        public void PararMotor()
        {
            Console.WriteLine("Detengo Motor de vehiculo");
        }

        public virtual void Conducir()
        {
            Console.WriteLine("Conduzco como vehiculo");
        }
    }
}
