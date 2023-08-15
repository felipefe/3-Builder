namespace Name
{
    public class NotebookBuilder : BuilderComputador
    {

        Computador computador;

        public NotebookBuilder()
        {
            computador = new Computador("Notebook");
        }

        public override void BuildDispositivos()
        {
            Console.WriteLine($"Construindo dispositivos {computador.tipo}");
        }

        public override void BuildSO()
        {
            Console.WriteLine($"Construindo Sistema Operacional {computador.tipo}");
        }
    }
}