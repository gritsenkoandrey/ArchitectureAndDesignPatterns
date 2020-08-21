using System;


namespace Decorator_1
{
    public class ShadowDecorator : Decorator
    {
        public ShadowDecorator(Iwidget widget) : base(widget)
        {

        }

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("  ShadowDecorator");
        }
    }
}