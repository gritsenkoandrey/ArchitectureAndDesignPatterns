using System;


namespace Single_Responsibility_Principle_3
{
    class ConsolePhoneReader : IPhoneReader
    {
        public string[] GetInputData()
        {
            Console.WriteLine("Введите модель");
            string model = Console.ReadLine();
            Console.WriteLine("Введите цену");
            string price = Console.ReadLine();
            return new string[] { model, price };
        }
    }
}