using System;


namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreator[] cars = {
                new BusCreator("275", "100", "1000"),
                new TruckCreator("100", "50", "750") };

            foreach (ICreator car in cars)
            {
                Console.WriteLine($"Автомобиль: { car.GetType() }, { car.Create() }");
            }

            Console.ReadLine();
        }
    }
}