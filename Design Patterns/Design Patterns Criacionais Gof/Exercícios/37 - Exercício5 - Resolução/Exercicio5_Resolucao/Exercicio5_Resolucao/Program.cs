using System;

namespace Exercicio5_Resolucao
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando os lanches
            Lanche mistoQuente = new Lanche("Pão de Forma", "Presunto e Queijo", "Tomate e cebola");
            Lanche cachorroQuente = new Lanche("Pao Francês", "Duas Salsichas", "Mostarda, Molho de Tomate");

            //clonando os lanches
            Lanche mistoQuenteClone = mistoQuente.Clone() as Lanche;
            Lanche cachorroQuenteClone = cachorroQuente.Clone() as Lanche;

            Console.ReadLine();
        }
    }
}
