using System;
using System.Collections.Generic;

namespace Exercicio2_Resolucao
{
    class Program
    {
        static void Main(string[] args)
        {
            IAluno aluno = null;
            AlunoFactory alunoFactory = null;
            List<string> cursos = null;

            Console.WriteLine("Lista de cursos para alunos por Universidade/Departamento\n");

            Console.WriteLine("Selecione a Universidade");
            Console.WriteLine("Univ1 ou Univ2");
            var opcao1 = Console.ReadLine().ToUpper();

            alunoFactory = AlunoFactory.CreateAlunoFactory(opcao1);

            Console.WriteLine("\nUniversidade: " + alunoFactory.GetType().Name);

            Console.WriteLine("\nSelecione o Departamento da Universidade");

            if (opcao1.Equals("UNIV1"))
                Console.WriteLine("Univ1 - Fisica ou Quimica");
            else
                Console.WriteLine("Univ2 - Medicina ou Biologia");

            var opcao2 = Console.ReadLine().ToUpper();

            aluno = alunoFactory.GetAluno(opcao2);

            Console.WriteLine("\nCursos oferecidos para este Departamento");

            Console.WriteLine($"\n{opcao2} - {aluno.GetType().Name}");

            cursos = aluno.Cursos();
            foreach (var item in cursos)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("------------------------------");
            Console.ReadLine();
        }
    }
}
