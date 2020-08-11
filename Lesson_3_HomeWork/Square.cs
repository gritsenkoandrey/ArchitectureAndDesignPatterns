using System;


namespace Lesson_3_HomeWork
{
    public class Square : Figure
    {
        public Square() : base()
        {
            CreateConcreteFigure();
        }

        public override void CreateConcreteFigure()
        {
            Console.WriteLine("Квадрат создан");
        }
    }
}