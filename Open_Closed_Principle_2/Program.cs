using System;


namespace Open_Closed_Principle_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cook cook = new Cook("Stan");
            cook.MakeDinner(new PotatoMeal());
            Console.WriteLine();
            cook.MakeDinner(new SaladMeal());

            Console.ReadLine();
        }
    }
}