namespace Decorator_2
{
    public class RussianPizza : Pizza
    {
        public RussianPizza() : base("Русская пицца")
        {

        }

        public override int GetCost()
        {
            return 5;
        }
    }
}