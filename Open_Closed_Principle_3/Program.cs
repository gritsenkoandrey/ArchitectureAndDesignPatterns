using System;


namespace Open_Closed_Principle_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MealBase[] menu = new MealBase[] { new PotatoMeal(), new SaladMeal() };
            Cook cook = new Cook("Stan");
            cook.MakeDinner(menu);

            Console.ReadLine();
        }
    }
}