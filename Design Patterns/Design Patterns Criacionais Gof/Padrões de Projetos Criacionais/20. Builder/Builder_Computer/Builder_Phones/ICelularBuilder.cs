namespace Builder_Phones
{
    interface ICelularBuilder
    {
        void BuildTela();
        void BuildBateria();
        void BuildSO();
        Celular Fone { get; }
    }
}
