namespace Name
{
    public class DesktopBuilder : BuilderComputador
    {
        Computador computador;
        public DesktopBuilder() 
        { 
            computador = new Computador("Desktop");
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