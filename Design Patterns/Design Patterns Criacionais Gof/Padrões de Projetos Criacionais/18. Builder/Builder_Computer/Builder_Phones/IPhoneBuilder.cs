namespace Builder_Phones
{
    class IPhoneBuilder : ICelularBuilder
    {
        Celular fone;

        public IPhoneBuilder()
        {
            fone = new Celular("IPhone");
        }

        public Celular Fone => fone;

        public void BuildBateria()
        {
            fone.BateriaCelular = Bateria.MAH_2000;
        }

        public void BuildSO()
        {
            fone.SistemaCelular = SistemaOperacional.IPhone;
        }
            
        public void BuildTela()
        {
            fone.TelaCelular = TipoTela.Tela_TOUCH_CAPACITIVE;
        }
    }
}
