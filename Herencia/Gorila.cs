using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    class Gorila : Mamiferos, IMamiferosTerrestres
    {
        public Gorila(string nombreGorila) : base(nombreGorila)
        {

        }
        public void Trepar()
        {
            Console.WriteLine("Yo puedo Trepar");
        }

        public override void Pensar()
        {
            Console.WriteLine("Pienso como Gorila");
        }

        public int NumeroPatas()
        {
            return 2;
        }
    }
}
