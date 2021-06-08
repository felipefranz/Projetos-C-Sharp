using System;
using System.Threading.Tasks;

namespace Singleton_Estatico
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => AcessoThread1(),
                () => AcessoThread2(),
                () => AcessoThread3()
           );
            Console.ReadLine();
        }

        private static void AcessoThread1()
        {
            Singleton s1 = Singleton.Instance;
            Console.WriteLine("Thread 1 ");
        }
        private static void AcessoThread2()
        {
            Singleton s2 = Singleton.Instance;
            Console.WriteLine("Thread 2 ");
        }
        private static void AcessoThread3()
        {
            Singleton s3 = Singleton.Instance;
            Console.WriteLine("Thread 3 ");
        }
    }
}
