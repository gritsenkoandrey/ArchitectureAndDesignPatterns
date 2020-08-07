using System;


namespace Lesson_3_HomeWork
{
    public class Triangle : Figure
    {
        public Triangle() : base()
        {
            CreateConcreteFigure();
        }

        public override void CreateConcreteFigure()
        {
            Console.WriteLine("Треугольник создан");
        }
    }
}