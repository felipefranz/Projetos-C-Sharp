using static System.Console;

namespace Singleton_SemLock
{
    public sealed class Singleton
    {
        private static int contador = 0;
        private static readonly Singleton instance = new Singleton();

        // construtor estatico explicito
        // informa ao compilador para marcar 
        // o tipo como beforefieldinit
        static Singleton()
        {
        }

        private Singleton()
        {
            contador++;
            WriteLine($"Instância {contador} ");
        }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
