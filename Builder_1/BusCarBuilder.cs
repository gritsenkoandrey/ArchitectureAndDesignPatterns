namespace Builder_1
{
    public class BusCarBuilder : CarBuilder
    {
        public override void BuildBody()
        {
            car.SetBody("Bus Body");
        }

        public override void BuildChasiss()
        {
            car.SetChasiss("Bus Chasiss");
        }

        public override void BuildEngine()
        {
            car.SetEngine("Bus Engine");
        }
    }
}