namespace Decorator_2
{
    public class TomatoPizza : DecoratorPizza
    {
        public TomatoPizza(Pizza pizza) : base($"{pizza.Name} с томатами", pizza)
        {

        }

        public override int GetCost()
        {
            return _pizza.GetCost() + 2;
        }
    }
}