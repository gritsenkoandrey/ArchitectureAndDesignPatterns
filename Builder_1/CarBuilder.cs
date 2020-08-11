namespace Builder_1
{
    public abstract class CarBuilder
    {
        protected Car car;
        public Car GetCar() => car;
        public void CreateNewCarProduct() => car = new Car();

        public abstract void BuildBody();
        public abstract void BuildChasiss();
        public abstract void BuildEngine();
    }
}