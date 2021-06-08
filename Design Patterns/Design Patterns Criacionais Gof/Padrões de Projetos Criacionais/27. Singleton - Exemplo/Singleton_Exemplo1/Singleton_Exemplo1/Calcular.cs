namespace Singleton_Exemplo1
{
    public sealed class Calcular
    {
        private Calcular()
        { }

        private static Calcular instance = null;
        private static readonly object padlock = new object();
        public static Calcular Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Calcular();
                        }
                    }
                }
                return instance;
            }
        }

        public double Valor1 { get; set; }
        public double Valor2 { get; set; }

        public double Somar()
        {
            return Valor1 + Valor2;
        }
        public double Subtrair()
        {
            return Valor1 - Valor2;
        }
        public double Multiplicar()
        {
            return Valor1 * Valor2;
        }
        public double Dividir()
        {
            return Valor1 / Valor2;
        }
    }
}
