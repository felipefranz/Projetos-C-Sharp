using System;

namespace Abstracao1
{
    class Program
    {
        static void Main(string[] args)
        {
            var servicoEmail = new ServicoEmail();

            servicoEmail.EnviarEmail();
         
            Console.ReadLine();
        }
    }
}
