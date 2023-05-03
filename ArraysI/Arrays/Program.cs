/* Video 36 - Arrays I
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrEdades;
            arrEdades = new int[4];
            arrEdades[0] = 15;
            arrEdades[1] = 27;
            arrEdades[2] = 19;
            arrEdades[3] = 80;

            Console.WriteLine(arrEdades[3]);

            int[] arrCalificaciones = { 8, 7, 9, 10, 8 };
            Console.WriteLine(arrCalificaciones[2]);


            // Array implicito Video 37

            // var datos = new[] { "Ali", "Sara", "Abraham", 3 };

            // A todo le da tipo double
            var valores = new[] { 15, 28, 35, 75.5 };

            // array de objetos
            Empleados[] arrEmpleados = new Empleados[2];
            arrEmpleados[0] = new Empleados("Sara", 9);

            Empleados Ali = new Empleados("Ali", 34);

            arrEmpleados[1] = Ali;

            // arrays de tipos / clases anonimas
            var personas = new[]
            {
                new {Nombre = "Ali", Edad = 34},
                new {Nombre = "Tania", Edad = 28},
                new {Nombre = "Abraham", Edad = 1}
            };

            Console.WriteLine(personas[0]);

            // Arrays 3 - Video 38

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine($"valores[{i}] = {valores[i]}");
            }

            foreach (Empleados objEmpleado in arrEmpleados)
            {
                Console.WriteLine("Foreach: " + objEmpleado.GetInfo());
            }

            foreach (var tipo1 in personas)
            {
                Console.WriteLine("Anonimo: " + tipo1);
            }

            // arrays 5 - Video 40
            int[] numeros = new int[4];
            numeros[0] = 7;
            numeros[1] = 9;
            numeros[2] = 15;
            numeros[3] = 3;
            
            ProcesaDatos(numeros);

            int[] arrayDevuelto = LeerDatos();

            foreach (int val in arrayDevuelto)
            {
                Console.WriteLine("Impresion desde el main." + val);
            }
        }

        static void ProcesaDatos(int[] datos)
        {
            foreach (int i in datos)
            {
                Console.WriteLine(i);
            }
        }

        static int[] LeerDatos()
        {
            Console.WriteLine("Cuantos elementos?");
            int respuesta = Convert.ToInt32(Console.ReadLine());

            int[] datos = new int[respuesta];

            for (int i = 0; i < respuesta; i++)
            {
                datos[i] = (i + 3) * 2;
            }

            return datos;
        }
    }

    class Empleados
    {
        string nombre;
        int edad;

        public Empleados (string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public string GetInfo()
        {
            return $"Nombre: {nombre}, Edad: {edad}";
        }
    }

    
}
