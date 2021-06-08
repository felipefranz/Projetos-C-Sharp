using System;
using static System.Console;

namespace Singleton_LazyLoading
{
    public sealed class Singleton
    {
        //Lazy Loading       
        private static readonly Lazy<Singleton> Instancelock =
                 new Lazy<Singleton>(() => new Singleton());

        private static int contador = 0;
        private Singleton()
        {
            contador++;
            WriteLine($"Instância {contador}");
        }     
        public static Singleton Instance
        {
            get
            {
                return Instancelock.Value;
            }
        }
    }
}