using System;

namespace AbstractFactory1
{
    class Program
    {
        static void Main(string[] args)
        {
            IMontadora fabrica = new FabricaHonda();
            ISedan sedan = fabrica.CriarSedan();
            ISuv suv = fabrica.CriarSuv();
            Console.WriteLine("********* HONDA ********");
            ExibeDetalhes(sedan, suv);

            fabrica = new FabricaHyundai();
            sedan = fabrica.CriarSedan();
            suv = fabrica.CriarSuv();
            Console.WriteLine("******* HYUNDAI **********");
            ExibeDetalhes(sedan, suv);

            Console.ReadKey();
        }

        private static void ExibeDetalhes(ISedan sedan, ISuv suv)
        {
            Console.WriteLine(sedan.ExibeDetalhes());
            Console.WriteLine(suv.ExibeDetalhes());
        }
    }
}
