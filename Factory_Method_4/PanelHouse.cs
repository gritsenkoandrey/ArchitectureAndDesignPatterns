using System;


namespace Factory_Method_4
{
    public class PanelHouse : IHouse
    {
        public PanelHouse()
        {
            Console.WriteLine("Панельный дом построен");
        }
        public IHouse Create()
        {
            return new PanelHouse();
        }
    }
}