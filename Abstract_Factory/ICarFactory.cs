namespace Abstract_Factory
{
    public interface ICarFactory
    {
        ICar CreateInstance(string description, 
            string wheelsSize,
            string engineCapacity,
            string engineTorque);
    }
}