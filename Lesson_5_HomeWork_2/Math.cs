using System;


namespace Lesson_5_HomeWork_2
{
    public class Math : ICalculate
    {
        private int _sum = 0;
        private string _nameOperation;

        public Math(string name)
        {
            _nameOperation = name;
            Console.WriteLine($"Operation is {name}");
        }

        public int Calculate(int num1, int num2)
        {
            switch (_nameOperation)
            {
                case "+":
                    return _sum = num1 + num2;

                case "-":
                    return _sum = num1 - num2;

                case "*":
                    return _sum = num1 * num2;

                case "/":
                    return _sum = num1 / num2;

                default:
                    Console.Write($"Операция {_nameOperation} не опознана ");
                    break;
            }
            return _sum;
        }
    }
}