using System.Collections.Generic;


namespace Flyweight_2
{
    public class HouseFactory
    {
        private Dictionary<string, House> houses = new Dictionary<string, House>();

        public HouseFactory()
        {
            houses.Add("Panel", new PanelHouse());
            houses.Add("Brick", new BrickHouse());
        }

        public House GetHouse(string key)
        {
            if (houses.ContainsKey(key))
            {
                return houses[key];
            }
            else
            {
                return null;
            }
        }
    }
}