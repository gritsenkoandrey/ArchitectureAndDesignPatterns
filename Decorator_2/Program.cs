using System;


namespace Decorator_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza1 = new ItalianPizza();
            pizza1 = new CheesePizza(pizza1);
            pizza1 = new TomatoPizza(pizza1);
            Console.WriteLine($"Название {pizza1.Name}");
            Console.WriteLine($"Цена {pizza1.GetCost()}");

            Pizza pizza2 = new RussianPizza();
            pizza2 = new CheesePizza(pizza2);
            pizza2 = new TomatoPizza(pizza2);
            Console.WriteLine($"Название {pizza2.Name}");
            Console.WriteLine($"Цена {pizza2.GetCost()}");

            Console.ReadLine();
        }
    }
}