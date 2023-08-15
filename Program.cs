namespace Name
{
    public class Program
    {
        static void Main(string[] args)
        {
            BuilderComputador bc = new DesktopBuilder();

            var fabricante = new Fabricante();
            fabricante.Build(bc);
        }
    }
}