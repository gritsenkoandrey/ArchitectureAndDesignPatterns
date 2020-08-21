using System;
using System.Drawing;


namespace Flyweight_1
{
    public class RedLine : IDrawLineAPI
    {
        public static int ObjectCounter = 0;
        private Brush _brush;

        public RedLine()
        {
            _brush = Brushes.Red;
            ObjectCounter++;
        }

        public void DrawLine(Point point1, Point point2)
        {
            Console.WriteLine($"Drawing Line[ color: red, point1: {point1}, point2: { point2}]");
        }
    }
}