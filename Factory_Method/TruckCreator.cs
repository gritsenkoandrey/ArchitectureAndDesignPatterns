namespace Factory_Method
{
    class TruckCreator : ICreator
    {
        Truck truck;

        public TruckCreator(string wheelsSize, string engineCapacity, string engineTorque)
        {
            truck = new Truck(wheelsSize, engineCapacity, engineTorque);
        }

        public ICar Create() => truck;
    }
}