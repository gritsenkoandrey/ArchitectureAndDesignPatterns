using System;


namespace State_2
{
    public class SolidWaterState : IWaterState
    {
        public void Frost(Water water)
        {
            Console.WriteLine("Продолжаем заморозку льда");
        }

        public void Heat(Water water)
        {
            Console.WriteLine("Превращаем лед в жидкость");
            water.State = new LiquidWaterState();
        }
    }
}