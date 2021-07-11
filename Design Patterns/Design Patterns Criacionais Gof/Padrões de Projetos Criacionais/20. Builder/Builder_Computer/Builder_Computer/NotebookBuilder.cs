using System;

namespace Builder_Computer
{
    //ConcreteBuilder
    class NotebookBuilder : ComputadorBuilder
    {
        Computador computador;
        public NotebookBuilder()
        {
            computador = new Computador("Notebook");
        }
        public override void BuildDispositivos()
        {
            Console.WriteLine("Build Dispositivos no notebook... ");
        }

        public override void BuildSO()
        {
            Console.WriteLine("Build Sistema Operacional no notebook.. ");
        }

        public Computador TipoComputador
        {
            get { return computador; }
        }
    }
}
