using System;


namespace Template_Method_1
{
    public class Chess : Game
    {
        public override void EndPlay()
        {
            Console.WriteLine("Шахматная партия закончилась!");
        }

        public override void Initialize()
        {
            Console.WriteLine("Шахматные фигуры расставлены.");
        }

        public override void StartPlay()
        {
            Console.WriteLine("Шахматная партия началась!");
        }
    }
}