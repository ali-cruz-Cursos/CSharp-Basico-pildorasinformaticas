using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads03
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuentaBancariaALI = new CuentaBancaria(4500);

            Thread[] threadArr = new Thread[15];

            for (int i = 0; i < 15; i++)
            {
                Thread t = new Thread(cuentaBancariaALI.RetiraMoney);
                t.Name = i.ToString();
                threadArr[i] = t;
            }

            for (int ii = 0; ii < 15; ii++)
            {
                threadArr[ii].Start();
                threadArr[ii].Join();
            }
            

            

            Console.ReadKey();
        }
    }
}
