using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    class Humano : Mamiferos
    {
        public Humano (string nombreHumano) : base(nombreHumano)
        {

        }
        public override void Pensar()
        {
            Console.WriteLine("Soy Humano y pienso");
        }
    }
}
