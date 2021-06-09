using static System.Console;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                IMontadora instancia = null;
                WriteLine("Selecione a Montadora (para sair digite S)");
                WriteLine("(C)hevrolet (F)ord (H)onda ");
                var opcao = ReadLine().ToUpper();

                if (opcao.Equals("S"))
                    break;
               
                switch (opcao)
                {
                    case "C":
                        instancia = new Chevrolet();
                        break;
                    case "F":
                        instancia = new Ford();
                        break;
                    case "H":
                        instancia = new Honda();
                        break;
                    default:
                        WriteLine("Opção não implementada");
                        break;
                }
                WriteLine($"\n{instancia.Modelo()} - {instancia.Cor}\n");
            }
        }
    }
}
