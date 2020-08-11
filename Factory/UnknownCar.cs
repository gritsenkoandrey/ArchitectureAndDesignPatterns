namespace Factory
{
    class UnknownCar : ICar
    {
        public UnknownCar() { }
        public string WheelsSize => string.Empty;
        public string EngineCapacity => string.Empty;
        public string EngineTorque => string.Empty;
        public string Name => "Неизвестный автобоиль";

        public override string ToString() => $"{Name}," +
            $"Диаметр колеса = { this.WheelsSize }," +
            $"объем двигателя={ this.EngineCapacity }," +
            $"крутящий момент = { this.EngineTorque }";
    }
}