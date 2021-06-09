using System;

namespace Exercicio1_Resolucao
{
    public sealed class Logger
    {
        private static Logger _logger;
        private static readonly object _syncLock = new object();

        private Logger()
        {
        }
        public static Logger GetLogger()
        {
            if (_logger == null)
            {
                lock (_syncLock)
                {
                    if (_logger == null)
                    {
                        _logger = new Logger();
                    }
                }
            }

            return _logger;
        }
        public void Registrar(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
