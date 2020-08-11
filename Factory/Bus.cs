namespace Factory
{
    public class Bus : ICar
    {
        private string wheelsSize;
        private string engineCapacity;
        private string engineTorque;

        public Bus(string wheelsSize, string engineCapacity, string engineTorque)
        {
            this.wheelsSize = wheelsSize;
            this.engineCapacity = engineCapacity;
            this.engineTorque = engineTorque;
        }

        public string WheelsSize => this.wheelsSize;
        public string EngineCapacity => this.engineCapacity;
        public string EngineTorque => this.engineTorque;
        public string Name => "Автобус";

        public override string ToString() => $"{Name}," +
            $"Диаметр колеса = { this.WheelsSize }," +
            $"объем двигателя={ this.EngineCapacity }," +
            $"крутящий момент = { this.EngineTorque }";
    }
}