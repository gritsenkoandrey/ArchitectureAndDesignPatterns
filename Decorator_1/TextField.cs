using System;


namespace Decorator_1
{
    public class TextField : Iwidget
    {
        private int _width;
        private int _height;

        public TextField(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public void Draw()
        {
            Console.WriteLine($"TextField: {_width} , {_height}");
        }
    }
}