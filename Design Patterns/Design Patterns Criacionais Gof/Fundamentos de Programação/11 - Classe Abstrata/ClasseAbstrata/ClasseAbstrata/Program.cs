using System;

namespace ClasseAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado q = new Quadrado();

            Console.WriteLine(q.Descricao());

            Console.WriteLine("Informe o valor do lado do quadrado em metros.");

            q.Lado = Convert.ToDouble(Console.ReadLine());
            q.CalcularArea();
            q.CalcularPerimetro();

            Console.WriteLine("A área do quadrado é : " + q.Area + " m2 ");

            Console.WriteLine("O perímetro do quadrado é : " + q.Perimetro + " m ");

            Console.ReadLine();
        }
    }
}
