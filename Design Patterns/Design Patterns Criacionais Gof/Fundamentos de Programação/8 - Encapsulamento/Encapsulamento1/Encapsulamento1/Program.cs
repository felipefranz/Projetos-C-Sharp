using System;

namespace Encapsulamento1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var conta1 = new Conta();
                conta1.Saldo = 200;

                Console.WriteLine($"O saldo da conta é {conta1.Saldo}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
