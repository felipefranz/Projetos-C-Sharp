using static System.Console;
using System.Threading.Tasks;

namespace Singleton_Sealed
{
    class Program
    {
        static void Main(string[] args)
        {

            Parallel.Invoke(
                () => AcessoThread1(),
                () => AcessoThread2()
           );
            ReadLine();
        }

        private static void AcessoThread1()
        {
            Singleton s1 = Singleton.Instance;
            WriteLine("Thread 1 ");
        }
        private static void AcessoThread2()
        {
            //Singleton s2 = Singleton.Instance;
            ////WriteLine("Thread 2 ");
            //Singleton.SingletonDerivada derivada =
            //    new Singleton.SingletonDerivada();
        }
    }

}
