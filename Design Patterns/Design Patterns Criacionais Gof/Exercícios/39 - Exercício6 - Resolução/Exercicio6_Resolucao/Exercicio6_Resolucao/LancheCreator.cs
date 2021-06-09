using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio6_Resolucao
{
    public abstract class LancheCreator
    {
        protected abstract Lanche CriaLanche();

        public void MontaLanche()
        {
            Lanche lanche = CriaLanche();
            string pao = lanche.GetPao();
            string recheio = lanche.GetRecheio();
            string condimentos = lanche.GetCondimentos();
            //
            PrepararPao(pao);
            PrepararRecheio(recheio);
            PrepararCondimentos(condimentos);
        }

        private void PrepararCondimentos(string condimentos)
        {
            Console.WriteLine($"{condimentos}");
        }
        private void PrepararPao(string pao)
        {
            Console.WriteLine($"{pao}");
        }
        private void PrepararRecheio(string recheio)
        {
            Console.WriteLine($"{recheio}");
        }
    }
}
