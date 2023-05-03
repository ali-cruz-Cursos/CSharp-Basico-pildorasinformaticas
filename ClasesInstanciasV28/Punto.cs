using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstanciasV28
{
    class Punto
    {

        private int x, y;

        // Video 34 static
        private static int contadorDeObjetos = 0;

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
            contadorDeObjetos++;
            Console.WriteLine($"Coordenada x: {x}, Coordenada y: {y}");

        }

        public Punto()
        {
            this.x = 0;
            this.y = 0;
            contadorDeObjetos++;

            Console.WriteLine("Constructor por defecto");

        }

        public double distancia(Punto otroPunto)
        {
            int difX = this.x - otroPunto.x;
            int difY = this.y - otroPunto.y;

            double distanciaP = Math.Sqrt(Math.Pow(difX, 2) + Math.Pow(difY, 2));

            return distanciaP;
        }

        public static int getContadorDeObjetos()
        {
            return contadorDeObjetos;
        }
    }
}
