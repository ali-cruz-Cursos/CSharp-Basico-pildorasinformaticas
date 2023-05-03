using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads03
{
    class CuentaBancaria
    {
        private Object bloqueaSaldoPos = new object();
        double Saldo { get; set; }
        public CuentaBancaria(double saldo)
        {
            this.Saldo = saldo;
        }

        public void Retirar(double cantidad)
        {
           
                if (ValidaSiTengoSaldoSuficiente(cantidad))
                {
                    lock (bloqueaSaldoPos)
                    {
                        Saldo -= cantidad;
                        Console.WriteLine($"Retirado {cantidad}, saldo actual {Saldo}. - Thread {Thread.CurrentThread.Name}.");
                    }
                }
                else
                {
                    Console.WriteLine($"No cuentas con saldo suficiente. - Thread {Thread.CurrentThread.Name}.");
                }
            

            //return Saldo;
        }

        private bool ValidaSiTengoSaldoSuficiente(double cantidadARetirar)
        {
            if (Saldo >= cantidadARetirar)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public void RetiraMoney()
        {
            Console.WriteLine("Thread.CurrentThread.Name " + Thread.CurrentThread.Name);
            Retirar(500);
        }

        
    }
}
