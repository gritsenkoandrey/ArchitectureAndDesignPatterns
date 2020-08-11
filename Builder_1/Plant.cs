namespace Builder_1
{
    class Plant
    {
        private CarBuilder carBuilder;

        public void SetCarBuilder(CarBuilder builder)
        {
            carBuilder = builder;
        }

        public Car GetCar()
        {
            return carBuilder.GetCar();
        }

        public void ConstructCar()
        {
            carBuilder.CreateNewCarProduct();
            carBuilder.BuildBody();
            carBuilder.BuildChasiss();
            carBuilder.BuildEngine();
        }
    }
}