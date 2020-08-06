using System;


namespace Factory_Method_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer[] devs = {
                new PanelDeveloper("ООО Панельные дома"),
                new WoodDeveloper("ООО Деревянные дома") };

            var house = new House[devs.Length];

            for (int i = 0; i < devs.Length; i++)
            {
                house[i] = devs[i].Create();
            }

            //Developer dev = new PanelDeveloper("ООО КирпичСтрой");
            //House house2 = dev.Create();
            //dev = new WoodDeveloper("Частный застройщик");
            //House house = dev.Create();

            Console.ReadLine();
        }
    }
}