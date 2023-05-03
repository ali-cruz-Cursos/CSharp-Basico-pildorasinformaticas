using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads02
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(MetodoThread1);
            thread1.Start();
            //thread1.Join();

            Thread thread2 = new Thread(MetodoThread2);
            thread2.Start();
            thread2.Join();

            Console.WriteLine("Linea 1");
            Thread.Sleep(500);
            Console.WriteLine("Linea 2");
            Thread.Sleep(500);
            Console.WriteLine("Linea 3");
            Thread.Sleep(500);
            Console.WriteLine("Linea 4");
            Thread.Sleep(500);

            //OtroMetodo();

            Console.ReadLine();
        }

        static void MetodoThread1()
        {
            Console.WriteLine("MetodoThread1 *1");
            Thread.Sleep(500);
            Console.WriteLine("MetodoThread1 *2");
            Thread.Sleep(500);
            Console.WriteLine("MetodoThread1 *3");
            Thread.Sleep(500);
            Console.WriteLine("MetodoThread1 *4");
            Thread.Sleep(500);
        }

        static void MetodoThread2()
        {
            Console.WriteLine("MetodoThread2 *1");
            Thread.Sleep(500);
            Console.WriteLine("MetodoThread2 *2");
            Thread.Sleep(500);
            Console.WriteLine("MetodoThread2 *3");
            Thread.Sleep(500);
            Console.WriteLine("MetodoThread2 *4");
            Thread.Sleep(500);
        }
    }
}
