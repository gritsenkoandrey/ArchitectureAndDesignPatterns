using System;


namespace Lesson_3_HomeWork
{
    class Circle : Figure
    {
        public Circle() : base()
        {
            CreateConcreteFigure();
        }

        public override void CreateConcreteFigure()
        {
            Console.WriteLine("Круг создан");
        }
    }
}