using System;


namespace Factory_Method_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer[] devs = { 
                new PanelDeveloper("ООО Панельные дома"), 
                new WoodDeveloper("ООО Деревянные дома") };

            IHouse house = new PanelHouse();

            //for (int i = 0; i < devs.Length; i++)
            //{
            //    house.Create();
            //}

            //Developer dev = new PanelDeveloper("ООО КирпичСтрой");
            //House house2 = dev.Create();
            //dev = new WoodDeveloper("Частный застройщик");
            //House house = dev.Create();

            Console.ReadLine();
        }
    }
}