using System;


namespace State_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Water water = new Water(new LiquidWaterState());
            water.Heat();
            water.Frost();
            water.Frost();

            Console.ReadLine();
        }
    }
}