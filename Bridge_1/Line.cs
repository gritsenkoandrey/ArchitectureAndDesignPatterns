using System.Drawing;


namespace Bridge_1
{
    public class Line : Shape
    {
        private Point _point1;
        private Point _point2;

        public Line(Point point1, Point point2, IDrawLine drawLine) : base(drawLine)
        {
            _point1 = point1;
            _point2 = point2;
        }

        public override void Draw()
        {
            drawLine.DrawLine(_point1, _point2);
        }
    }
}