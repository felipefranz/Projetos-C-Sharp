using static System.Console;

namespace Singleton_EagerLoading
{
    public sealed class Singleton
    {
        //eager loading
        private static readonly Singleton instance = new Singleton();

        private static int contador = 0;
        private Singleton()
        {
            contador++;
            WriteLine($"Instancia {contador}");
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
