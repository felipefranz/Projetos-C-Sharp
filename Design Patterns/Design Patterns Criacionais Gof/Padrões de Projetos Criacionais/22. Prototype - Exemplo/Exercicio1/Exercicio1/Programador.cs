namespace Exercicio1
{
    public class Programador : Funcionario
    {
        public string Linguagem { get; set; }

        public override Funcionario Clone()
        {
            return (Funcionario)MemberwiseClone();
        }

        public override string ToString()
        {
            return string.Format($"{Nome} - {Cargo} - {Linguagem}");
        }
    }
}
