using System;


namespace Template_Method_1
{
    public class Preferans : Game
    {
        public override void EndPlay()
        {
            Console.WriteLine("Игра завершена!");
        }

        public override void Initialize()
        {
            Console.WriteLine("Карты розданы");
        }

        public override void StartPlay()
        {
            Console.WriteLine("Игра началась!");
        }
    }
}