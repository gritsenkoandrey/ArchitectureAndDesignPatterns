namespace Factory_Method
{
    class BusCreator : ICreator
    {
        Bus bus;

        public BusCreator(string wheelsSize, string engineCapacity, string engineTorque)
        {
            bus = new Bus(wheelsSize, engineCapacity, engineTorque);
        }

        public ICar Create() => bus;
    }
}