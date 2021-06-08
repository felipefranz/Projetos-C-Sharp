namespace Exercicio1
{
    public class Engenheiro : Funcionario
    {
        public string Especialidade { get; set; }

        public override Funcionario Clone()
        {
            return (Funcionario)MemberwiseClone();
        }

        public override string ToString()
        {
            return string.Format($"{Nome} - {Cargo} - {Especialidade}");
        }

    }
}
