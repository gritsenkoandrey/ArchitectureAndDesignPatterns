using System;


namespace Lesson_3_HomeWork_2
{
    class Circle : IFigure
    {
        public Circle()
        {
            CreateConcreteFigure();
        }

        public void CreateConcreteFigure()
        {
            Console.WriteLine("Круг создан");
        }
    }
}