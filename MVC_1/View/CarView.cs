using System;


namespace MVC_1.View
{
    public class CarView
    {
        public void PrintCarDetails(string carName, string carSpeed)
        {
            Console.WriteLine($"Автомобиль: название {carName}, скорость {carSpeed}");
        }
    }
}