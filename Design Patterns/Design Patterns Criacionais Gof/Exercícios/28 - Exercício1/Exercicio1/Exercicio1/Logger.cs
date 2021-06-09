using System;

namespace Exercicio1
{
    public class Logger
    {
        private Logger()
        {}
        public static Logger GetLogger()
        {
            return new Logger();
        }
        public void Registrar(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
