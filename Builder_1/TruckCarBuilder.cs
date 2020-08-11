namespace Builder_1
{
    public class TruckCarBuilder : CarBuilder
    {
        public override void BuildBody()
        {
            car.SetBody("Truck Body");
        }

        public override void BuildChasiss()
        {
            car.SetChasiss("Truck Chasiss");
        }

        public override void BuildEngine()
        {
            car.SetEngine("Truck Engine");
        }
    }
}