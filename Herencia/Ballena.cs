using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    class Ballena : Mamiferos
    {
        public Ballena(string nombreBallena):base(nombreBallena)
        {

        }

        public void Nadar()
        {
            Console.WriteLine("Nado como ballena");
        }
    }
}
