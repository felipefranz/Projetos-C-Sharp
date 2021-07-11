using static System.Console;

namespace Single_MultiThread
{
    public sealed class Singleton
    {
        // Estamos usando volatile para garantir que
        // atribuição à variável de instância termina antes de
        // acesso.
        // A palavra-chave volatile indica que um campo pode 
        // ser modificado por vários threads em execução ao mesmo tempo.
        private static int contador = 0;
        private static volatile Singleton instance;
        private static object lockObject = new object();

        private Singleton()
        {
            contador++;
            WriteLine($"Instância = {contador}");
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    //lock (lockObject)
                    //{
                        //if (instance == null)
                        instance = new Singleton();
                    //}
                }
                return instance;
            }
        }
    }
}
