using System;

namespace Exercicio3_Resolucao
{
    public class MontadoraSimpleFactory
    {
        public static IMontadora CriaMontadora(string nomeMontadora)
        {
            IMontadora montadora = null;

            switch (nomeMontadora)
            {
                case "C":
                    montadora = new Chevrolet();
                    break;
                case "F":
                    montadora = new Ford();
                    break;
                case "H":
                    montadora = new Honda();
                    break;
                default:
                    throw new ApplicationException($"A montadora {montadora} não foi criada");
            }
            return montadora;
        }
    }
}
