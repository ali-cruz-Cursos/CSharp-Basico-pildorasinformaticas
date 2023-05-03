using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa02_Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escribe un numero entre 1 y 12 para convertirlo a nombre de mes del año-

            Console.WriteLine("Escribe un numero entre 1 y 12: ");

            int numeroMes = int.Parse(Console.ReadLine());
            
            try
            {
                Console.WriteLine(NombreDelMes(numeroMes));
            } catch (Exception e)
            {
                Console.WriteLine("***** Error: " + e.Message);

            }

            Console.WriteLine("Continua el resto del programa");

            System.IO.StreamReader archivo = null;


            try
            {
                string linea;
                int contador = 0;

                string pathFile = @"C:\Users\userone\Desktop\hola.txt";
                archivo = new System.IO.StreamReader(pathFile);

                while((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;
                }


            } catch (Exception e)
            {
                Console.WriteLine("Error al intentar leer el archivo");

            } finally
            {
                if (archivo != null)
                    archivo.Close();

                Console.WriteLine("Coneion cerrada correctamente");
            }



        }

        public static string NombreDelMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "Enero";
                    
                case 2:
                    return "Febrero";
                    
                case 3:
                    return "Marzo";
                    
                case 4:
                    return "Abril";
                    
                case 5:
                    return "Mayo";
                    
                case 6:
                    return "Junio";
                    
                case 7:
                    return "Julio";
                    
                case 8:
                    return "Agosto";
                    
                case 9:
                    return "Septiembre";
                    
                case 10:
                    return "Octubre";
                    
                case 11:
                    return "Noviembre";
                    
                case 12:
                    return "Diciembre";
                    
                default:
                    throw new ArgumentOutOfRangeException();
                    

            }
        }
    }
}
