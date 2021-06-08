using System;

namespace Builder_Computer
{
    class Program
    {
        static void Main(string[] args) 
        {
            //instancia de Director
            Fabricante fabricante = new Fabricante();

            //instancia do concretebuilder
            NotebookBuilder notebookBuilder = new NotebookBuilder();
            DesktopBuilder desktopBuilder = new DesktopBuilder();
            
            //cria objetos conforme o builder
            fabricante.Build(notebookBuilder);
            fabricante.Build(desktopBuilder);

            Console.ReadLine();

        }
    }
}
