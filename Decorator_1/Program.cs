using System;


namespace Decorator_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Iwidget widget = new ShadowDecorator(new RoundCornerDecorator(new TextField(25, 50)));
            widget.Draw();

            Console.ReadLine();
        }
    }
}