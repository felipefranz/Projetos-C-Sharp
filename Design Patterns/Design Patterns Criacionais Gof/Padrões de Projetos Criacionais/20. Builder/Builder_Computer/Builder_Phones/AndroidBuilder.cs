namespace Builder_Phones
{
    class AndroidBuilder : ICelularBuilder
    {
        public AndroidBuilder()
        {
            fone = new Celular("Celular Android");
        }

        public Celular fone;
        public Celular Fone
        {
            get { return fone; }
        }

        public void BuildBateria()
        {
            fone.BateriaCelular = Bateria.MAH_1500;
        }

        public void BuildSO()
        {
            fone.SistemaCelular = SistemaOperacional.ANDROID;
        }

        public void BuildTela()
        {
            fone.TelaCelular = TipoTela.Tela_TOUCH_CAPACITIVE;
        }
    }
}
    