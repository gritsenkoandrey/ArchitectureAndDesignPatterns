namespace Factory
{
    public class Truck : ICar
    {
        private string wheelsSize;
        private string engineCapacity;
        private string engineTorque;

        public Truck(string wheelsSize, string engineCapacity, string engineTorque)
        {
            this.wheelsSize = wheelsSize;
            this.engineCapacity = engineCapacity;
            this.engineTorque = engineTorque;
        }

        public string WheelsSize => this.wheelsSize;
        public string EngineCapacity => this.engineCapacity;
        public string EngineTorque => this.engineTorque;
        public string Name => "Грузовик";

        public override string ToString() => $"{Name}," +
            $"Диаметр колеса = { this.WheelsSize }," +
            $"объем двигателя={this.EngineCapacity}," +
            $"крутящий момент = { this.EngineTorque }";
    }
}
