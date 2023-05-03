using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads04
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskCompletionSource<bool> tareaTerminada = new TaskCompletionSource<bool>();

            Thread thread1 = new Thread(() => { 
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("thread 1");
                    Thread.Sleep(1000);
                }
            });

            Thread thread2 = new Thread(() => {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("thread 2");
                    Thread.Sleep(1000);
                }

                tareaTerminada.TrySetResult(true);
            });



            Thread thread3 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("thread 3");
                    Thread.Sleep(1000);
                }
            });

            Thread thread4 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("thread 4");
                    Thread.Sleep(1000);
                }
            });

            thread1.Start();

            thread2.Start();

            if (tareaTerminada.Task.Result)
            {
                thread3.Start();
            }

            thread4.Start();



            Console.ReadLine();
        }
    }
}
