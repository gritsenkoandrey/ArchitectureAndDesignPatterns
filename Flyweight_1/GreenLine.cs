using System;
using System.Drawing;


namespace Flyweight_1
{
    public class GreenLine : IDrawLineAPI
    {
        public static int ObjectCounter = 0;
        private Brush _brush;

        public GreenLine()
        {
            _brush = Brushes.Green;
            ObjectCounter++;
        }

        public void DrawLine(Point point1, Point point2)
        {
            Console.WriteLine($"Drawing Line[ color: green, point1: {point1}, point2: { point2}]");
        }
    }
}