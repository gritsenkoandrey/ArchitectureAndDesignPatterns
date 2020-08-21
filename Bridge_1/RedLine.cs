using System;
using System.Drawing;


namespace Bridge_1
{
    public class RedLine : IDrawLine
    {
        public void DrawLine(Point point1, Point point2)
        {
            Console.WriteLine($"Drawing Line[ color: red, point1: {point1}, point2: { point2}]");
        }
    }
}
