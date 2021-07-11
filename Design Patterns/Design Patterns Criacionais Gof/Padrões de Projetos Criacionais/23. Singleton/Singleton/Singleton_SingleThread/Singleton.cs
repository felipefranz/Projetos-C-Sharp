using static System.Console;

namespace Singleton_SingleThread
{
    public class Singleton
    {
        private static Singleton instance;
        private int numeroDeInstancias = 0;

        private Singleton()
        {
            WriteLine("Instanciando dentro do construtor privado");
            numeroDeInstancias++;
            WriteLine($"Número de Instâncias = {numeroDeInstancias}");
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    WriteLine("Criando a primeira instância");
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
