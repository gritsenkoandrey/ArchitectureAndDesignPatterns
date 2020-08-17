using System;


namespace Interpretator_1
{
    public class Program
    {
        public static IExpression GetFruitExpression()
        {
            IExpression apple = new TerminalExpression("Яблоко");
            IExpression orange = new TerminalExpression("Апельсин");
            return new OrExpression(apple, orange);
        }

        public static IExpression GetJacketExpression()
        {
            IExpression blue = new TerminalExpression("Синий");
            IExpression jacket = new TerminalExpression("Свитер");
            return new AndExpression(blue, jacket);
        }

        static void Main(string[] args)
        {
            IExpression isFruit = GetFruitExpression();
            IExpression isBlueJacket = GetJacketExpression();

            Console.WriteLine($"Яблоко - Фрукт? {isFruit.Interpret("Яблоко")}");
            Console.WriteLine($"Синий - Свитер? {isBlueJacket.Interpret("Синий Свитер")}");

            Console.ReadLine();
        }
    }
}