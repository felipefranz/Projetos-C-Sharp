using System;
using System.Data.SqlTypes;

namespace Heranca1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cp1 = new ContaPoupanca();
            cp1.Numero = 10;
            cp1.Saldo = 100;
            cp1.Juros = 2;
            cp1.GetSaldo();
            Console.ReadLine();
        }
    }
}
