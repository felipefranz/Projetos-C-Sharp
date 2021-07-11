using System;
using static System.Console;

namespace Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria objeto do tipo Saldo
            Soldado soldado = new Soldado();
            soldado.Nome = "Soldado";
            soldado.Arma = "Fuzil";
            soldado.Acessorio= new Acessorio { Nome = "Capacete" };

            //Clone o objeto original
            Soldado soldado_clone1 = (Soldado)soldado.Clone();
            soldado_clone1.Acessorio.Nome = "Visor Noturno";

            Soldado soldado_clone2 = (Soldado)soldado.Clone();
            soldado_clone2.Acessorio.Nome = "Arma Secreta";

            //exibe valores do objeto original
            WriteLine(">> Objeto Original");
            WriteLine($"{soldado.Nome} - {soldado.Arma}");
            WriteLine($"{soldado.Acessorio.Nome}");

            //Valores de objeto clone1
            WriteLine(">> Objeto Clone1");
            WriteLine($"{soldado_clone1.Nome} -  {soldado_clone1.Arma}");
            WriteLine($"{soldado_clone1.Acessorio.Nome}");

            //Valores de objeto clone2
            WriteLine(">> Objeto Clone2");
            WriteLine($"{soldado_clone2.Nome} - {soldado_clone2.Arma}");
            WriteLine($"{soldado_clone2.Acessorio.Nome}");

            ReadLine();
        }
    }
}
