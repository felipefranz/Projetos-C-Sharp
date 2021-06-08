using static System.Console;

namespace Single_MultiThread
{
    public class Singleton
    {
        private static int contador = 0;
        private static Singleton instance;
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
                   instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
