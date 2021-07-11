namespace Builder_Phones
{
    class Celular
    {
        public Celular(string nome)
        {
            NomeCelular = nome;
        }

        public string NomeCelular { get; set; }

        public TipoTela TelaCelular { get; set; }

        public Bateria BateriaCelular { get; set; }

        public SistemaOperacional SistemaCelular { get; set; }

        public override string ToString()
        {
            return string.Format($"Nome: {NomeCelular}\nTela: {TelaCelular}" +
                $"\nBateria {BateriaCelular}\nSO: {SistemaCelular}");
        }
    }
}
