using System;


namespace Lesson_5_HomeWork_2
{
    public class Program
    {
        private static readonly string fold = "+";
        private static readonly string subtract = "-";
        private static readonly string multiply = "*";
        private static readonly string split = "/";

        static void Main(string[] args)
        {
            ICalculate calculate = new MathProxy(fold);
            int sum = calculate.Calculate(10, 20);
            Console.WriteLine(sum);

            calculate = new MathProxy(subtract);
            sum = calculate.Calculate(60, 10);
            Console.WriteLine(sum);

            calculate = new MathProxy(multiply);
            sum = calculate.Calculate(4, 7);
            Console.WriteLine(sum);

            calculate = new MathProxy(split);
            sum = calculate.Calculate(60, 2);
            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}