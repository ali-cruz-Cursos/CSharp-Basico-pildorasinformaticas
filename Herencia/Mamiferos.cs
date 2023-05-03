using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    class Mamiferos
    {

        private string nombreSerVivo;

        public Mamiferos(string nombre)
        {
            nombreSerVivo = nombre;
        }

        public void Respirar()
        {
            Console.WriteLine("Respiro");
        }

        public void CuidarCrias()
        {
            Console.WriteLine("Cuido mis crias");
        }

        // Todas las subclases de mamifero deben tener un metodo Pensar que modifique el metodo pensar de mamiferos (agregando/quitando)

        public virtual void Pensar()
        {
            Console.WriteLine("Pensamiento mamifero");
        }

        public void GetNombre()
        {
            Console.WriteLine("El nombre del ser vivo: " + nombreSerVivo);
        }
    }
}
