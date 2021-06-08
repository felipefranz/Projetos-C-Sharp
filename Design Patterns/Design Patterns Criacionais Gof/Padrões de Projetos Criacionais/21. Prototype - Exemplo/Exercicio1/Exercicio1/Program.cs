using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Programador programador = new Programador();
            programador.Nome = "Jefferson";
            programador.Cargo = "Programador Pleno";
            programador.Linguagem = "C#";

            Programador programadorClone = (Programador)programador.Clone();
            programadorClone.Nome = "Sueli";
            programadorClone.Cargo = "Programador Junior";

            Console.WriteLine(programador);
            Console.WriteLine(programadorClone);

            Engenheiro engenheiro = new Engenheiro();
            engenheiro.Nome = "Mario";
            engenheiro.Cargo = "Engenheiro Mecânico";
            engenheiro.Especialidade = "Motores";

            Engenheiro engenheiroClone = (Engenheiro)engenheiro.Clone();
            engenheiroClone.Nome = "Amanda";
            engenheiroClone.Especialidade = "Fluidos";

            Console.WriteLine(engenheiro);
            Console.WriteLine(engenheiroClone);

            Console.ReadLine();
        }
    }
}
