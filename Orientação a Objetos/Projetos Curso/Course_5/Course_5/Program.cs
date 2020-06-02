using System;
using System.Globalization;

namespace Course_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];
            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }
            double avg = sum / n;
            Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            /*
            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
            */

            /*
               Produto p = new Produto();
               Console.WriteLine("Entre os dados do produto:");
               Console.Write("Nome: ");
               p.Nome = Console.ReadLine();
               Console.Write("Preço: ");
               p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               Console.Write("Quantidade no estoque: ");
               p.Quantidade = int.Parse(Console.ReadLine());
               Console.WriteLine();
               Console.WriteLine("Dados do produto: " + p);
               Console.WriteLine();
               Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
               int qte = int.Parse(Console.ReadLine());
               p.AdicionarProdutos(qte);
               Console.WriteLine();
               Console.WriteLine("Dados atualizados: " + p);
               Console.WriteLine();
               Console.Write("Digite o número de produtos a ser removido do estoque: ");
               qte = int.Parse(Console.ReadLine());
               p.RemoverProdutos(qte);
               Console.WriteLine();
               Console.WriteLine("Dados atualizados: " + p);
           */

        }
    }
}
