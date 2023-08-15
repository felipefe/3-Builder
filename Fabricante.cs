namespace Name
{
    public class Fabricante
    {
        public void Build(BuilderComputador builder)
        {
            builder.BuildDispositivos();
            builder.BuildSO();
        }
    }
}