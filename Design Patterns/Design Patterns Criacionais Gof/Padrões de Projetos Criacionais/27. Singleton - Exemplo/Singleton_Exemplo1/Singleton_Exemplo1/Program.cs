using System;

namespace Singleton_Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            var v1 = Calcular.Instance.Valor1 = 10.5;
            var v2 = Calcular.Instance.Valor2 = 5.5;

            Console.WriteLine($"Valor1 = {v1} Valor2 = {v2}");

            Console.WriteLine("\n----------------------\n");

            Console.WriteLine("Adição : " + Calcular.Instance.Somar());
            Console.WriteLine("Subtratação : " + Calcular.Instance.Subtrair());
            Console.WriteLine("Multiplicação : " + Calcular.Instance.Multiplicar());
            Console.WriteLine("Divisão : " + Calcular.Instance.Dividir());

            Console.WriteLine("\n----------------------\n");

            Console.ReadLine();
        }
    }
}
