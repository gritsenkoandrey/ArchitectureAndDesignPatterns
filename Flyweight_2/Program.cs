using System;


namespace Flyweight_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            double longitude = 47d;
            double latitude = 74d;

            HouseFactory houseFactory = new HouseFactory();

            for (int i = 0; i < 10; i++)
            {
                House panelHouse = houseFactory.GetHouse("Panel");
                if (panelHouse != null)
                {
                    panelHouse.Build(longitude, latitude);
                    longitude += 0.7;
                    latitude += 0.4;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                House brickHouse = houseFactory.GetHouse("Brick");
                if (brickHouse != null)
                {
                    brickHouse.Build(longitude, latitude);
                    longitude += 0.4;
                    latitude += 0.7;
                }
            }

            Console.ReadLine();
        }
    }
}