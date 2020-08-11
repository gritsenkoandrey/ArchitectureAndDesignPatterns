using System;


namespace Factory_Method_4
{
    public class WoodHouse : IHouse
    {
        public WoodHouse()
        {
            Console.WriteLine("Деревянный дом построен");
        }
        public IHouse Create()
        {
            return new WoodHouse();
        }

    }
}