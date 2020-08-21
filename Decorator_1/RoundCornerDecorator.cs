using System;


namespace Decorator_1
{
    public class RoundCornerDecorator : Decorator
    {
        public RoundCornerDecorator(Iwidget widget) : base(widget)
        {

        }

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("  RoundCornerDecorator");
        }
    }
}