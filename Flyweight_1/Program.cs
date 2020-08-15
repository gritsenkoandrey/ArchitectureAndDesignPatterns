using System;
using System.Drawing;


namespace Flyweight_1
{
    public class Program
    {
        private static Random _rnd = new Random();

        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                IDrawLineAPI redLine = LineFactory.GetLine("Red");
                redLine.DrawLine(new Point(_rnd.GetRandomNumber(), _rnd.GetRandomNumber()),
                    new Point(_rnd.GetRandomNumber(), _rnd.GetRandomNumber()));
            }

            for (int i = 0; i < 20; i++)
            {
                IDrawLineAPI greenLine = LineFactory.GetLine("Green");
                greenLine.DrawLine(new Point(_rnd.GetRandomNumber(), _rnd.GetRandomNumber()),
                    new Point(_rnd.GetRandomNumber(), _rnd.GetRandomNumber()));
            }

            Console.WriteLine($"Линий создано, красных: {RedLine.ObjectCounter}," +
                $"зеленых: {GreenLine.ObjectCounter}");

            Console.ReadLine();
        }
    }

    public static class RandomExtension
    {
        public static int GetRandomNumber(this Random random)
        {
            return (int)random.Next(100);
        }
    }
}