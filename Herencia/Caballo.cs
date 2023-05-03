using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    // Debe ir primero siempre las clases heredadas y luego las interfaces y no al revez
    class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas
    {

        public Caballo(string nombreCaballo):base(nombreCaballo)
        {

        }
        public void Galopar()
        {
            Console.WriteLine("Yo galopeo");
        }

        public void Pensar()
        {
            Console.WriteLine("Pienso como caballo");
        }


        // Sin public para que no de error, asi no existe confusion por saber
        // a cual metodo se llamo.
        int IMamiferosTerrestres.NumeroPatas()
        {
            return 4;
        }

        int ISaltoConPatas.NumeroPatas()
        {
            return 2;
        }

        public string TipoDeporte()
        {
            return "Deporte 1";
        }

        public Boolean EsOlimpico()
        {
            return true;
        }
    }
}
