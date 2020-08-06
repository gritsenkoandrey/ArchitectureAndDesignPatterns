namespace Factory_Method
{
    public interface ICar
    {
        string WheelsSize { get; }
        string EngineCapacity { get; }
        string EngineTorque { get; }
        string Name { get; }
    }
}