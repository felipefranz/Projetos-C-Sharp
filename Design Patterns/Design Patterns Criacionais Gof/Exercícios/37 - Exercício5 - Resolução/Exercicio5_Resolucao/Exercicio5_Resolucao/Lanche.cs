using static System.Console;

namespace Exercicio5_Resolucao
{
    public class Lanche : LanchePrototype
    {
        public string Pao { get; set; }
        public string Recheio { get; set; }
        public string Condimentos { get; set; }

        public Lanche(string pao, string recheio, string condimentos)
        {
            Pao = pao;
            Recheio = recheio;
            Condimentos = condimentos;
        }

        public override LanchePrototype Clone()
        {
            string ingredientes = Ingredientes();
            WriteLine($"Clonando o lanche com ingredientes:" +
                $" {ingredientes.Remove(ingredientes.LastIndexOf(","))}");

            return MemberwiseClone() as LanchePrototype;
        }

        private string Ingredientes()
        {
            var ingredientes = "";
            if (!string.IsNullOrWhiteSpace(Pao))
            {
                ingredientes += Pao + ", ";
            }
            if (!string.IsNullOrWhiteSpace(Recheio))
            {
                ingredientes += Recheio + ", ";
            }
            if (!string.IsNullOrWhiteSpace(Condimentos))
            {
                ingredientes += Condimentos + ", ";
            }
            return ingredientes;
        }
    }
}
