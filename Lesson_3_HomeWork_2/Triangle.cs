using System;


namespace Lesson_3_HomeWork_2
{
    public class Triangle : IFigure
    {
        public Triangle()
        {
            CreateConcreteFigure();
        }

        public void CreateConcreteFigure()
        {
            Console.WriteLine("Треугольник создан");
        }
    }
}