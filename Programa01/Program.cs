using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programa01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uso de Do While - 

            Random numero = new Random();
            int aleatorio = numero.Next(0, 100);
            int miNumero = 0, intentos = 0;

            Console.WriteLine("Calculando un numero al azar...");
            Console.WriteLine("Numero seleccionado!");
            Console.WriteLine("Introduce un numero entero entre 0 y 100");

            do
            {
                intentos++;
                try                
                {
                    miNumero = int.Parse(Console.ReadLine());
                }
                //catch (FormatException e)
                //{
                //    Console.WriteLine("Error, solo acepto numeros");
                //}
                catch (Exception e) when (e.GetType() != typeof(FormatException))
                {
                    Console.WriteLine("Existe un error. FormatException!");
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Existe un error. Exception!");
                    Console.WriteLine(e.Message);
                }

                //catch (FormatException e)
                //{
                //    Console.WriteLine("Solo acepto numeros enteros");
                //} catch (OverflowException e)
                //{
                //    Console.WriteLine("Solo acepto valores entre 0 y 100");
                //}

                if (miNumero > aleatorio)
                    Console.WriteLine("El no. es mas bajo. a={0}", aleatorio);
                if (miNumero < aleatorio)
                    Console.WriteLine("El no. es mas alto. a={0}", aleatorio);
            } while (aleatorio != miNumero);

            Console.WriteLine($"Correcto! has necesitado {intentos} intentios");

            Console.WriteLine("A partir de esta linea de codigo el programa continua");

            // checked unchecked
            int numero2 = int.MaxValue;

            Console.WriteLine("sin desborde {0}", numero2);

            int res = numero2 + 20;

            Console.WriteLine("con desborde {0}", res);

            //checked
            //{
            //    int numero3 = int.MaxValue;

            //    Console.WriteLine("Sin desborde: {0}", numero3);

            //    int res3 = numero3 + 100;

            //    Console.WriteLine("Con desborde {0}", res3);
            //}


            // checked / unchecked
            // Solo funciona con int y float

            int numero4 = int.MaxValue;
            Console.WriteLine("numero4 Sin desborde: {0}", numero4);

            int res4 = unchecked(numero4 + 100);

            int numero5 = checked(numero4 + 1000);

            Console.WriteLine("res4 Con desborde {0}", res4);

            Console.WriteLine("Numero5 Con desborde {0}", numero5);



        }
    }
}
