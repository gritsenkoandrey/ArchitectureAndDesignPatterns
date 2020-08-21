namespace Decorator_2
{
    public abstract class DecoratorPizza : Pizza
    {
        protected Pizza _pizza;

        public DecoratorPizza(string name, Pizza pizza) : base(name)
        {
            _pizza = pizza;
        }
    }
}