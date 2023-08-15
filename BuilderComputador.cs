namespace Name
{
    public abstract class BuilderComputador
    {
        public Computador TipoComputador {get; }
        public abstract void BuildSO();
        public abstract void BuildDispositivos();

    }
}