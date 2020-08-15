using System;
using System.Drawing;


namespace Bridge_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shape redLine = new Line(new Point(10, 10), new Point(20, 20), new RedLine());
            Shape greenLine = new Line(new Point(15, 15), new Point(30, 30), new GreenLine());

            redLine.Draw();
            greenLine.Draw();

            Console.ReadLine();
        }
    }
}