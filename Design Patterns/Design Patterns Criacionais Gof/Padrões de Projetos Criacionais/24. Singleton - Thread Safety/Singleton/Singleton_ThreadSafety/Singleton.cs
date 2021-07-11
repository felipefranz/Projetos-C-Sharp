using static System.Console;

namespace Singleton_ThreadSafety
{
    public class Singleton
    {
        private static int contador = 0;
        private static readonly object lockObject = new object();
        private static Singleton instance = null;

        private Singleton()
        {
            contador++;
            WriteLine($"Instância {contador} ");
        }
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
