using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// usar metodos de una clase estatica
using static System.Math;


namespace ClasesInstanciasV28
{
    class Program
    {
        static void Main(string[] args)
        {

            // Clases e instancias
            Circulo objetoCirculo1; // Variable objeto, es diferente a la variable primitiva

            objetoCirculo1 = new Circulo();

            Console.WriteLine(objetoCirculo1.calculoArea(3));

            Circulo objetoCirculo2 = new Circulo();

            Console.WriteLine(objetoCirculo2.calculoArea(9));

            //objetoCirculo2.pi = 544.25;

            // Encapsulacion 

            ConversorEuroDolar objConversor = new ConversorEuroDolar();

            objConversor.cambiaValorEuro(-7.5);
            Console.WriteLine(objConversor.convierte(50));


            // Constructor y sobre carga
            Console.WriteLine("Clase Coche");

            Coche objCoche1 = new Coche();

            Coche objCoche3 = new Coche(452.2, 456.3);


            // getter - setter Video 31
            Console.WriteLine(objCoche3.getInfoCoche());


            objCoche1.setExtras(true, "Tapizaaado");

            Console.WriteLine(objCoche1.getExtras());

            realizarTarea();

            // Video 35
            // Haciendo uso de using static
            double raiz = Sqrt(9);
            double potencia = Math.Pow(3, 4);

            Console.WriteLine($"Video 35- raiz: {raiz}, potencia: {potencia}");

            // Clases Anonimas

            var miVariableClaseAnonima = new { Nombre = "Ali", Edad = 34 };
            Console.WriteLine(miVariableClaseAnonima.Nombre + " " + miVariableClaseAnonima.Edad);

            // Numero de campos, mismo orden y mismo tipo, entonces se asigna la misma clase.
            // Campos publicos. Ya deben ser iniciados, no se pueden usar campos static, no se
            // pueden definir metodos.
            var miOtraVariableClaseAnonima = new { Nombre = "Sara", Edad = 9 };

            miVariableClaseAnonima = miOtraVariableClaseAnonima; // Son de la misma clase

            Console.ReadLine();


        }

        static void realizarTarea()
        {
            Punto objPuntoOrigen = new Punto();
            Punto objPuntoDestino = new Punto(128, 80);

            double distancia = objPuntoOrigen.distancia(objPuntoDestino);
            Console.WriteLine($"La distancia entre los puntos es {distancia}");

            Console.WriteLine($"Numero de objetos creados {Punto.getContadorDeObjetos()}");
        }

    }

    class Circulo
    {
        private const double pi = 3.1416;  // Propiedad de clase / Campo de clase

        public double calculoArea(int radio)
        {

            return pi * radio * radio;

        }
    }

    class ConversorEuroDolar
    {
        private double euro = 1.253;
        
        public double convierte(double cantidad)
        {
            return cantidad * euro;

            // TODO: Lista de tareas pendientes // Video 32
        }

        public void cambiaValorEuro(double nuevoValor)
        {
            if (nuevoValor > 0)
                euro = nuevoValor;
        }
    }

    partial class Coche
    {
        // partial class Video 31

        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private String tapiceria;
    }

    partial class Coche { 

        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.8;
            tapiceria = "Tela";
        }

        public Coche(double largoCoche, double anchocoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchocoche;
        }

        public int getRuedas()
        {
            return ruedas;
        }

        public String getInfoCoche()
        {
            return "Informacion del coche: \n" + "Ruedas: " + ruedas + " Largo: " + largo + " Ancho: " + ancho;
        }

        public void setExtras(bool climatizador, String tapiceria)
        {
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
            // TODO
        }

        public String getExtras()
        {
            return "Extras del coche: \n " + "Tapiceria: " + tapiceria + " Climatizador: " + climatizador;
        }

    }


}
