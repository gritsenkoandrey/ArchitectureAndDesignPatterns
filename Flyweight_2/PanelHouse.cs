using System;


namespace Flyweight_2
{
    public class PanelHouse : House
    {
        public PanelHouse()
        {
            stages = 10;
        }

        public override void Build(double longitude, double latitude)
        {
            Console.WriteLine($"Построен панельный дом из {stages} этажей;" +
                $"координаты: {latitude} широты и {longitude} долготы");
        }
    }
}