namespace Decorator_2
{
    public class CheesePizza : DecoratorPizza
    {
        public CheesePizza(Pizza pizza) : base($"{pizza.Name} сырная пицца", pizza)
        {

        }

        public override int GetCost()
        {
            return _pizza.GetCost() + 5;
        }
    }
}