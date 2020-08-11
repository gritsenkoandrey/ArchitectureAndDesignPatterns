using System;


namespace Builder_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Plant plant = new Plant();
            CarBuilder truck = new TruckCarBuilder();
            CarBuilder bus = new BusCarBuilder();

            plant.SetCarBuilder(truck);
            plant.ConstructCar();

            Car car = plant.GetCar();
            Console.WriteLine(car.ToString());

            Console.ReadLine();
        }
    }
}