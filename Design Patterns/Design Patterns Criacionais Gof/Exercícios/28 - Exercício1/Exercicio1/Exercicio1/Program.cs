using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Maria");
            cliente1.AtualizaEndereco("Rua Equador, 44", "Santos");

            Cliente cliente2 = new Cliente("Manuel");
            cliente2.AtualizaEndereco("Rua Santos, 13", "Lins");

            Console.ReadLine();
        }
    }
}
