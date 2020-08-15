namespace Bridge_1
{
    public abstract class Shape
    {
        protected IDrawLine drawLine;

        protected Shape(IDrawLine drawLine)
        {
            this.drawLine = drawLine;
        }

        public abstract void Draw();
    }
}