using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {

            // List rellena las posiciones vacias en memoria (Deben estar los datos contiguos)
            List<int> listaNumeros = new List<int>();
            listaNumeros.Add(5);
            listaNumeros.Add(7);
            listaNumeros.Add(9);

            int[] arrayList = new int[] { 3, 6, 8, 10, 50 };


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(listaNumeros[i]);
            }

            List<int> listaNumeros2 = new List<int>();

            Console.WriteLine("Cuantos elementos queires introducir: ");
            int elementos = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < elementos; i++)
                listaNumeros2.Add(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Elementos introducidos:");
            for (int i = 0; i < elementos; i++)
            {
                Console.WriteLine(listaNumeros2[i].ToString());
            }


            List<int> listaNumeros3 = new List<int>();
            Console.WriteLine();

            Console.WriteLine("Introduce los elementos en tu lista: 0 para salir ");

            int elemento = 1;

            while (elemento != 0)
            {
                elemento = Convert.ToInt32(Console.ReadLine());
                listaNumeros3.Add(elemento);
            }
            Console.WriteLine("--------");

            foreach (int item in listaNumeros3)
            {
                Console.WriteLine(item);
            }


            // LinkedList

            LinkedList<int> numerosLinked = new LinkedList<int>();

            foreach (int numero01 in new int[] {10,8,6,4,2,0})
            {
                numerosLinked.AddFirst(numero01);
            }

            Console.WriteLine("Print");

            foreach (int num in numerosLinked)
            {
                Console.WriteLine(num);
            }
        }
    }
}
