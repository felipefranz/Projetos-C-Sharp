namespace Builder_Computer
{
    //Builder
    abstract class ComputadorBuilder
    {
        public abstract void BuildSO();
        public abstract void BuildDispositivos();
        Computador TipoComputador { get; }
    }
}
