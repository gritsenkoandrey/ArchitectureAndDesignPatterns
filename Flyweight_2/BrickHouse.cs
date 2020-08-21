using System;


namespace Flyweight_2
{
    public class BrickHouse : House
    {
        public BrickHouse()
        {
            stages = 5;
        }

        public override void Build(double longitude, double latitude)
        {
            Console.WriteLine($"Построен кирпичный дом из {stages} этажей;" +
                $"координаты: {latitude} широты и {longitude} долготы");
        }
    }
}