using System;

namespace Exercicio6_Resolucao
{
    class Program
    {
        static void Main(string[] args)
        {
            LancheCreator creator = null;

            Console.WriteLine("Criando o Misto Quente :");
            creator = new MistoQuenteCreator();
            creator.MontaLanche();
            Console.WriteLine();

            Console.WriteLine("Criando o Cachorro Quente :");
            creator = new CachorroQuenteCreator();
            creator.MontaLanche();
            Console.WriteLine();

            Console.WriteLine("Criando o Lanche Natural :");
            creator = new LancheNaturalCreator();
            creator.MontaLanche();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
