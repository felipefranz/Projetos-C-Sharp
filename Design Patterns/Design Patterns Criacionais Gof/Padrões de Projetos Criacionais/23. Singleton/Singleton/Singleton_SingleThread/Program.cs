using System;

namespace Singleton_SingleThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("##### Padrão Singleton #####\n");
            Console.WriteLine("Tentando criar uma instância s1.");

            Singleton s1 = Singleton.Instance;

            Console.WriteLine("Tentando criar uma instância s2.");

            Singleton s2 = Singleton.Instance;

            if (s1 == s2)
            {
                Console.WriteLine("Existem somente uma instância (s1==s2)");
            }
            else
            {
                Console.WriteLine("Existem instâncias diferentes (s1 e s2)");
            }
            Console.Read();
        }
    }
}
