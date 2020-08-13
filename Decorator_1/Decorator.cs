namespace Decorator_1
{
    public class Decorator : Iwidget
    {
        private Iwidget _widget;

        public Decorator(Iwidget widget)
        {
            _widget = widget;
        }

        public virtual void Draw()
        {
            _widget.Draw();
        }
    }
}